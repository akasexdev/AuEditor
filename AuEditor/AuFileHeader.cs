using System;

namespace AuEditor
{
    public class AuFileHeader
    {
        public const uint AuFileMagic = 0x2e736e64;
        public const uint AuUnknownSize = UInt32.MaxValue;

        public uint MagicNumber { get; set; }
        public uint HeaderSize { get; set; }
        public uint DataSize { get; set; }
        public AuFileEncoding Encoding { get; set; }
        public uint SampleRate { get; set; }
        public uint Channels { get; set; }

        public int BytesPerSample
        {
            get { return Encoding == AuFileEncoding.None ? 0 : (int)Encoding - 1; }
        }

        public int SamplesPerChannel
        {
            get
            {
                if (DataSize > 0)
                    return ((int)DataSize / (int)(Channels * BytesPerSample));
                return 0;
            }
        }

        public int Duration
        {
            get
            {
                if (DataSize > 0)
                    return ((int)DataSize / (int)(SampleRate * Channels * BytesPerSample));
                return 0;
            }
        }
    }
}
