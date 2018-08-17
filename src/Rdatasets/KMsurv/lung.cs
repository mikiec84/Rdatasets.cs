// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 4.4, p120
    /// </summary>

    public class lung
    {
        public readonly int time;
        public readonly int death;
        public readonly int time2;
        public readonly int death2;

        public lung(int time, int death, int time2, int death2)
        {
            this.time = time;
            this.death = death;
            this.time2 = time2;
            this.death2 = death2;
        }

        public static IEnumerable<lung> Data
        {
            get
            {
                yield return new lung(139, 1, 139, 1);
                yield return new lung(304, 1, 304, 1);
                yield return new lung(193, 1, 193, 1);
                yield return new lung(248, 1, 248, 1);
                yield return new lung(27, 1, 27, 1);
                yield return new lung(210, 1, 210, 1);
                yield return new lung(134, 1, 134, 1);
                yield return new lung(203, 1, 203, 1);
                yield return new lung(724, 1, 320, 0);
                yield return new lung(50, 1, 50, 1);
                yield return new lung(511, 1, 306, 0);
                yield return new lung(22, 1, 22, 1);
                yield return new lung(561, 1, 290, 0);
                yield return new lung(580, 1, 276, 0);
                yield return new lung(136, 1, 136, 1);
                yield return new lung(308, 1, 231, 0);
                yield return new lung(224, 1, 217, 0);
                yield return new lung(482, 1, 198, 0);
                yield return new lung(191, 1, 186, 0);
                yield return new lung(144, 1, 144, 1);
                yield return new lung(68, 1, 68, 1);
                yield return new lung(683, 1, 131, 0);
                yield return new lung(256, 1, 121, 0);
                yield return new lung(441, 1, 108, 0);
                yield return new lung(101, 1, 99, 0);
            }
        }
    }
}
