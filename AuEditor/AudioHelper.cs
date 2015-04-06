using System;

namespace AuEditor
{
    public static class AudioHelper
    {
        // FadeIn: GetLinearValue(i - startingSample, numberOfSamples);
        // FadeOut: 1.0f - GetLinearValue(i - startingSample, numberOfSamples);
        public static float GetLinearValue(int position, int total)
        {
            return (1.0f * position) / total;
        }

        // FadeIn: GetLogarithmicValue(i - startingSample, numberOfSamples);
        // FadeOut: 1.0f - GetLogarithmicValue(i - startingSample, numberOfSamples);
        public static float GetLogarithmicValue(int position, int total)
        {
            return 1.0f;
        }

        public static void FadeIn(AuFile inputFile, Func<int, int, float> filter,
            int start, int duration)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return;

            var startingSample = (int) inputFile.Header.SampleRate * start;
            var numberOfSamples = (int) inputFile.Header.SampleRate * duration;

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
        }

        public static void FadeOut(AuFile inputFile, Func<int, int, float> filter,
            int start, int duration)
        {
            if (inputFile == null || !inputFile.Header.IsValid)
                return;

            var startingSample = (int)inputFile.Header.SampleRate * start;
            var numberOfSamples = (int)inputFile.Header.SampleRate * duration;

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
        }

        public static void CrossFade(AuFile inputFile, Func<int, int, float> filter,
            int start, int duration)
        {
        }
    }
}
