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

            for (var i = startingSample; i < startingSample + numberOfSamples; i++)
            {
                var fadeInMult = filter(i - startingSample, numberOfSamples);
                var oldVal = inputFile.Channels[0][i];
                var newVal = (int)(oldVal * fadeInMult);
                inputFile.Channels[0][i] = newVal;
            }

            for (var i = startingSample; i < startingSample + numberOfSamples; i++)
            {
                var fadeOutMult = 1.0f - filter(i - startingSample, numberOfSamples);
                var oldVal = inputFile.Channels[1][i];
                var newVal = (int)(oldVal * fadeOutMult);
                inputFile.Channels[1][i] = newVal;
            }
            return true;
        }
    }
}
