using System;

namespace AuEditor
{
    public static class AudioHelper
    {
        // FadeIn: GetLinearValue(i - startingSample, numberOfSamples);
        // FadeOut: 1.0f - GetLinearValue(i - startingSample, numberOfSamples);
        public static float LinearInterpolation(int position, int total)
        {
            return (1.0f * position) / total;
        }

        // FadeIn: GetLogarithmicValue(i - startingSample, numberOfSamples);
        // FadeOut: 1.0f - GetLogarithmicValue(i - startingSample, numberOfSamples);
        public static float LogarithmicInterpolation(int position, int total)
        {
            var x = LinearInterpolation(position, total);
            return (float) Math.Log(x + 1, 2);
        }

        public static bool FadeIn(AuFile inputFile, Func<int, int, float> filter,
            float start, float duration)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return false;

            var startingSample = (int) (inputFile.Header.SampleRate * start);
            var numberOfSamples = (int) (inputFile.Header.SampleRate * duration);

            if (startingSample + numberOfSamples > inputFile.Header.SamplesPerChannel)
                return false;

            for (var j = 0; j < (int) inputFile.Header.Channels; j++)
            {
                for (var i = startingSample; i < startingSample + numberOfSamples; i++)
                {
                    var mult = filter(i - startingSample, numberOfSamples);
                    var oldVal = inputFile.Channels[j][i];
                    var newVal = (int) (oldVal*mult);
                    inputFile.Channels[j][i] = newVal;
                }
            }
            return true;
        }

        public static bool FadeOut(AuFile inputFile, Func<int, int, float> filter,
            float start, float duration)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return false;

            var startingSample = (int)(inputFile.Header.SampleRate * start);
            var numberOfSamples = (int)(inputFile.Header.SampleRate * duration);

            if (startingSample + numberOfSamples > inputFile.Header.SamplesPerChannel)
                return false;

            for (var j = 0; j < (int)inputFile.Header.Channels; j++)
            {
                for (var i = startingSample; i < startingSample + numberOfSamples; i++)
                {
                    var mult = 1.0f - filter(i - startingSample, numberOfSamples);
                    var oldVal = inputFile.Channels[j][i];
                    var newVal = (int)(oldVal * mult);
                    inputFile.Channels[j][i] = newVal;
                }
            }
            return true;
        }

        public static bool CrossFade(AuFile inputFile, Func<int, int, float> filter,
            float start, float duration)
        {
            if (inputFile == null || !inputFile.Header.IsValid || inputFile.Header.Channels != 2)
                return false;

            var startingSample = (int)(inputFile.Header.SampleRate * start);
            var numberOfSamples = (int)(inputFile.Header.SampleRate * duration);

            if (startingSample + numberOfSamples > inputFile.Header.SamplesPerChannel)
                return false;

            for (var j = 0; j < (int) inputFile.Header.Channels; j++)
            {
                var halfSize = numberOfSamples / 2;
                // FadeOut first half
                for (var i = startingSample; i < startingSample + halfSize; i++)
                {
                    var mult = 1.0f - filter(i - startingSample, halfSize);
                    var oldVal = inputFile.Channels[j][i];
                    var newVal = (int)(oldVal * mult);
                    inputFile.Channels[j][i] = newVal;
                }
                var startHalf = startingSample + halfSize;
                // FadeIn second half
                for (var i = startHalf; i < startHalf + halfSize; i++)
                {
                    var mult = filter(i - startHalf, halfSize);
                    var oldVal = inputFile.Channels[j][i];
                    var newVal = (int)(oldVal * mult);
                    inputFile.Channels[j][i] = newVal;
                }
            }
            return true;
        }
    }
}
