// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Shoe wear data of Box, Hunter and Hunter
    /// </summary>

    public class shoes
    {
        public readonly double A;
        public readonly double B;

        public shoes(double A, double B)
        {
            this.A = A;
            this.B = B;
        }

        public static IEnumerable<shoes> Data
        {
            get
            {
                yield return new shoes(13.2, 14);
                yield return new shoes(8.2, 8.8);
                yield return new shoes(10.9, 11.2);
                yield return new shoes(14.3, 14.2);
                yield return new shoes(10.7, 11.8);
                yield return new shoes(6.6, 6.4);
                yield return new shoes(9.5, 9.8);
                yield return new shoes(10.8, 11.3);
                yield return new shoes(8.8, 9.3);
                yield return new shoes(13.3, 13.6);
            }
        }
    }
}
