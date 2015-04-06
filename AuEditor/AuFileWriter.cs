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

        public bool ExportToWav(AuFile inputFile)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return false;

            var totalBytes = 44 + (int)(inputFile.Header.DataSize);
            var output = new byte[totalBytes];

            // Populate WAV Header
            Buffer.BlockCopy(BitConverter.GetBytes(0x46464952), 0, output, 0, 4);  // "RIFF"
            Buffer.BlockCopy(BitConverter.GetBytes(totalBytes - 8), 0, output, 4, 4);  // RIFF chunk size
            Buffer.BlockCopy(BitConverter.GetBytes(0x45564157), 0, output, 8, 4);  // "WAVE"
            Buffer.BlockCopy(BitConverter.GetBytes(0x20746D66), 0, output, 12, 4); // "fmt "
            Buffer.BlockCopy(BitConverter.GetBytes(16), 0, output, 16, 4); // fmt chunk size
            Buffer.BlockCopy(BitConverter.GetBytes((short)1), 0, output, 20, 2);   // compression code (1 - PCM/Uncompressed)
            Buffer.BlockCopy(BitConverter.GetBytes((short)inputFile.Header.Channels), 0, output, 22, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((int)inputFile.Header.SampleRate), 0, output, 24, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(
                (int)(inputFile.Header.SampleRate * inputFile.Header.BytesPerSample * inputFile.Header.Channels)), 0, output, 28, 4);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(inputFile.Header.BytesPerSample * inputFile.Header.Channels)), 0, output, 32, 2);
            Buffer.BlockCopy(BitConverter.GetBytes((short)(inputFile.Header.BytesPerSample * 8)), 0, output, 34, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(0x61746164), 0, output, 36, 4); // "data"
            Buffer.BlockCopy(BitConverter.GetBytes(totalBytes - 44), 0, output, 40, 4);

            // Populate WAV Samples
            for (var i = 0; i < inputFile.Header.SamplesPerChannel; i++)
            {
                for (var j = 0; j < (int)inputFile.Header.Channels; j++)
                {
                    Buffer.BlockCopy(BitConverter.GetBytes(inputFile.Channels[j][i]), 0, output, 
                        (int)(inputFile.Header.BytesPerSample * i * inputFile.Header.Channels) + 44 + inputFile.Header.BytesPerSample * j, 
                        inputFile.Header.BytesPerSample);
                }
            }

            // Write Bytes to Output Stream
            Write(output);
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
