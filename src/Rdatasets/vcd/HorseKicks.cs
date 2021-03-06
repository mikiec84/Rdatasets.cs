// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Death by Horse Kicks
    /// </summary>

    public class HorseKicks
    {
        public readonly int κ;
        public readonly int nDeaths;
        public readonly int Freq;

        public HorseKicks(int κ, int nDeaths, int Freq)
        {
            this.κ = κ;
            this.nDeaths = nDeaths;
            this.Freq = Freq;
        }

        public static IEnumerable<HorseKicks> Data
        {
            get
            {
                yield return new HorseKicks(1, 0, 109);
                yield return new HorseKicks(2, 1, 65);
                yield return new HorseKicks(3, 2, 22);
                yield return new HorseKicks(4, 3, 3);
                yield return new HorseKicks(5, 4, 1);
            }
        }
    }
}
