// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Calcium Uptake Data
    /// </summary>

    public class calcium
    {
        public readonly double time;
        public readonly double cal;

        public calcium(double time, double cal)
        {
            this.time = time;
            this.cal = cal;
        }

        public static IEnumerable<calcium> Data
        {
            get
            {
                yield return new calcium(0.45, 0.3417);
                yield return new calcium(0.45, -0.00438);
                yield return new calcium(0.45, 0.82531);
                yield return new calcium(1.3, 1.77967);
                yield return new calcium(1.3, 0.95384);
                yield return new calcium(1.3, 0.6408);
                yield return new calcium(2.4, 1.75136);
                yield return new calcium(2.4, 1.27497);
                yield return new calcium(2.4, 1.17332);
                yield return new calcium(4, 3.12273);
                yield return new calcium(4, 2.60958);
                yield return new calcium(4, 2.57429);
                yield return new calcium(6.1, 3.17881);
                yield return new calcium(6.1, 3.00782);
                yield return new calcium(6.1, 2.67061);
                yield return new calcium(8.05, 3.05959);
                yield return new calcium(8.05, 3.94321);
                yield return new calcium(8.05, 3.43726);
                yield return new calcium(11.15, 4.80735);
                yield return new calcium(11.15, 3.35583);
                yield return new calcium(11.15, 2.78309);
                yield return new calcium(13.15, 5.13825);
                yield return new calcium(13.15, 4.70274);
                yield return new calcium(13.15, 4.25702);
                yield return new calcium(15, 3.60407);
                yield return new calcium(15, 4.15029);
                yield return new calcium(15, 3.42484);
            }
        }
    }
}
