using System;
using System.IO;

namespace AuEditor
{
    public class AuFileWriter : BinaryWriter
    {
        public AuFileWriter(Stream stream)
            : base(stream)
        { }

        public bool WriteFile(AuFile inputFile)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return false;

            // Write File Header
            WriteBigEndianUInt32(inputFile.Header.MagicNumber);
            WriteBigEndianUInt32(inputFile.Header.HeaderSize);
            WriteBigEndianUInt32(inputFile.Header.DataSize);
            WriteBigEndianUInt32((uint)inputFile.Header.Encoding);
            WriteBigEndianUInt32(inputFile.Header.SampleRate);
            WriteBigEndianUInt32(inputFile.Header.Channels);

            // Write Extra Header Data
           if (inputFile.Header.ExtraData != null)
               Write(inputFile.Header.ExtraData);

            // Write Samples
            for (var i = 0; i < inputFile.Header.SamplesPerChannel; i++)
            {
                for (var j = 0; j < inputFile.Header.Channels; j++)
                {
                     WriteBigEndianInt(inputFile.Channels[j][i], inputFile.Header.BytesPerSample);
                }
            }

            return true;
        }

        public void WriteBigEndianUInt32(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes);
            Write(bytes);
        }

        public void WriteBigEndianInt(int value, int numberOfBytes)
        {
            var bytes = ByteHelper.Int32ToBigEndian(value, numberOfBytes);
            Write(bytes);
        }
    }
}
