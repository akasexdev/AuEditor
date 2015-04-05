using System;

namespace AuEditor
{
    public static class ByteHelper
    {
        public const int Int24MaxValue = 8388607;

        public static int BigEndianToInt32(byte[] bytes, int numberOfBytes)
        {
            Array.Reverse(bytes);

            if (numberOfBytes == 1)
                return (sbyte)bytes[0];
            if (numberOfBytes == 2)
                return BitConverter.ToInt16(bytes, 0);
            if (numberOfBytes == 3)
            {
                var data = new byte[] { 0x00, bytes[0], bytes[1], bytes[2] };
                return BitConverter.ToInt32(data, 0) >> 8;
            }
            if (numberOfBytes == 4)
                return BitConverter.ToInt32(bytes, 0);
            throw new ArgumentException("Invalid Number of Bytes");
        }

        public static byte[] Int32ToBigEndian(int value, int numberOfBytes)
        {
            if (numberOfBytes > 0 && numberOfBytes < 5)
            {
                var bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);

                if (numberOfBytes == 1)
                    return new[] { bytes[3] };
                if (numberOfBytes == 2)
                    return new[] { bytes[2], bytes[3] };
                if (numberOfBytes == 3)
                    return new[] { bytes[1], bytes[2], bytes[3] };

                return bytes;
            }
            throw new ArgumentException("Invalid Number of Bytes");
        }
    }
}
