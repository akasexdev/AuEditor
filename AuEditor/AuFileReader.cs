using System;
using System.IO;

namespace AuEditor
{
    public class AuFileReader : BinaryReader
    {
        public AuFileReader(Stream stream)
            : base(stream)
        { }

        public AuFile ReadFile()
        {
            var inputFile = new AuFile
            {
                Header = new AuFileHeader
                {
                    MagicNumber = ReadBigEndianUInt32(),
                    HeaderSize = ReadBigEndianUInt32(),
                    DataSize = ReadBigEndianUInt32(),
                    Encoding = (AuFileEncoding) ReadBigEndianUInt32(),
                    SampleRate = ReadBigEndianUInt32(),
                    Channels = ReadBigEndianUInt32()
                }
            };

            if (!inputFile.Header.IsValid)
                return inputFile;

            var headerOffset = (int)inputFile.Header.HeaderSize - 24;
            if (headerOffset > 0)
                ReadBytes(headerOffset);

            inputFile.Channels = new AuFileData((int)inputFile.Header.Channels, inputFile.Header.SamplesPerChannel);
            for (var i = 0; i < inputFile.Header.SamplesPerChannel; i++)
            {
                for (var j = 0; j < inputFile.Header.Channels; j++)
                {
                    inputFile.Channels[j][i] = ReadBigEndianInt(inputFile.Header.BytesPerSample);
                }
            }

            return inputFile;
        }

        public uint ReadBigEndianUInt32()
        {
            var bytes = ReadBytes(4);
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public int ReadBigEndianInt(int numberOfBytes)
        {
            var bytes = ReadBytes(numberOfBytes);
            Array.Reverse(bytes);

            if (numberOfBytes == 1)
                return bytes[0];
            if (numberOfBytes == 2)
                return BitConverter.ToInt16(bytes, 0);
            if (numberOfBytes == 3)
            {
                var data = new byte[] { bytes[0], bytes[1], bytes[2], 0x00 };
                return BitConverter.ToInt32(data, 0);
            }
            if (numberOfBytes == 4)
                return BitConverter.ToInt32(bytes, 0);
            throw new ArgumentException("Invalid Number of Bytes value");
        }
    }
}
