using System;

namespace AuEditor
{
    public class AuFileHeader
    {
        public const uint AuFileMagicNumber = 0x2e736e64;
        public const uint AuFileMinHeaderSize = 24;
        public const uint AuUnknownSize = UInt32.MaxValue;

        public uint MagicNumber { get; set; }
        public uint HeaderSize { get; set; }
        public uint DataSize { get; set; }
        public AuFileEncoding Encoding { get; set; }
        public uint SampleRate { get; set; }
        public uint Channels { get; set; }
        public byte[] ExtraData { get; set; }

        public int BytesPerSample
        {
            get { return Encoding == AuFileEncoding.None ? 0 : (int)Encoding - 1; }
        }

        public int SamplesPerChannel
        {
            get
            {
                if (DataSize > 0 && Channels > 0 && BytesPerSample > 0)
                    return ((int)DataSize / (int)(Channels * BytesPerSample));
                return 0;
            }
        }

        public int Duration
        {
            get
            {
                if (DataSize > 0 && Channels > 0 && BytesPerSample > 0)
                    return ((int)DataSize / (int)(SampleRate * Channels * BytesPerSample));
                return 0;
            }
        }

        public bool IsValid
        {
            get 
            { 
                return (MagicNumber == AuFileMagicNumber && HeaderSize >= AuFileMinHeaderSize
                    && DataSize > 0 && Encoding != AuFileEncoding.None && SampleRate > 0
                    && Channels > 0);
            }
        }
    }
}
