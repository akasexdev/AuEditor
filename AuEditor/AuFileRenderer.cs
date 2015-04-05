using System;
using System.Drawing;
using System.Linq;

namespace AuEditor
{
    public static class AuFileRenderer
    {
        public static void Render(int width, int height, AuFile inputFile, Graphics graphics)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return;

            var channelHeight = height / (int) inputFile.Header.Channels;

            var samplesPerPixel = (inputFile.Header.SamplesPerChannel / width) + 1;
            for (var x = 0; x < width; x++)
            {
                for (var i = 0; i < inputFile.Header.Channels; i++)
                {
                    var low = 0.0f;
                    var high = 0.0f;
                    var samples = inputFile.Channels[i].Skip(x * samplesPerPixel)
                        .Take(samplesPerPixel);

                    foreach (var sample in samples)
                    {
                        if (sample < low) 
                            low = sample;
                        if (sample > high)
                            high = sample;
                    }

                    if (inputFile.Header.BytesPerSample == 1)
                    {
                        low = (low * Int32.MaxValue) / SByte.MaxValue;
                        high = (high * Int32.MaxValue) / SByte.MaxValue;
                    }
                    else if (inputFile.Header.BytesPerSample == 2)
                    {
                        low = (low * Int32.MaxValue) / Int16.MaxValue;
                        high = (high * Int32.MaxValue) / Int16.MaxValue;
                    }
                    else if (inputFile.Header.BytesPerSample == 3)
                    {
                        low = (low * Int32.MaxValue) / ByteHelper.Int24MaxValue;
                        high = (high * Int32.MaxValue) / ByteHelper.Int24MaxValue;
                    }

                    var lowPercent = (low - Int32.MinValue) / UInt32.MaxValue;
                    var highPercent = (high - Int32.MinValue) / UInt32.MaxValue;

                    var lowValue = (channelHeight * i) + channelHeight * lowPercent;
                    var highValue = (channelHeight * i) + channelHeight * highPercent;

                    graphics.DrawLine(Pens.Blue, x, lowValue, x, highValue);
                }
            }
        }
    }
}
