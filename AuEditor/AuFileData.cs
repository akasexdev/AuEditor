using System;

namespace AuEditor
{
    public class AuFileData
    {
        public int[][] Samples { get; set; }

        public AuFileData(int numberOfChannels, int samplesPerChannel)
        {
            Samples = new int[numberOfChannels][];
            for (var i = 0; i < Samples.GetLength(0); i++)
                Samples[i] = new int[samplesPerChannel];
        }

        public int[] this[int index]
        {
            get
            {
                if (index >= 0 && (Samples != null && index < Samples.GetLength(0)))
                    return Samples[index];
                throw new ArgumentOutOfRangeException("index");
            }
            set
            {
                if (index >= 0 && (Samples != null && index < Samples.GetLength(0)))
                    Samples[index] = value;
                else
                    throw new ArgumentOutOfRangeException("index");
            }
        }
    }
}
