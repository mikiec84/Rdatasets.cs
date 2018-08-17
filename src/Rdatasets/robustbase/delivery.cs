// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Delivery Time Data
    /// </summary>

    public class delivery
    {
        public readonly int n_prod;
        public readonly int distance;
        public readonly double delTime;

        public delivery(int n_prod, int distance, double delTime)
        {
            this.n_prod = n_prod;
            this.distance = distance;
            this.delTime = delTime;
        }

        public static IEnumerable<delivery> Data
        {
            get
            {
                yield return new delivery(7, 560, 16.68);
                yield return new delivery(3, 220, 11.5);
                yield return new delivery(3, 340, 12.03);
                yield return new delivery(4, 80, 14.88);
                yield return new delivery(6, 150, 13.75);
                yield return new delivery(7, 330, 18.11);
                yield return new delivery(2, 110, 8);
                yield return new delivery(7, 210, 17.83);
                yield return new delivery(30, 1460, 79.24);
                yield return new delivery(5, 605, 21.5);
                yield return new delivery(16, 688, 40.33);
                yield return new delivery(10, 215, 21);
                yield return new delivery(4, 255, 13.5);
                yield return new delivery(6, 462, 19.75);
                yield return new delivery(9, 448, 24);
                yield return new delivery(10, 776, 29);
                yield return new delivery(6, 200, 15.35);
                yield return new delivery(7, 132, 19);
                yield return new delivery(3, 36, 9.5);
                yield return new delivery(17, 770, 35.1);
                yield return new delivery(10, 140, 17.9);
                yield return new delivery(26, 810, 52.32);
                yield return new delivery(9, 450, 18.75);
                yield return new delivery(8, 635, 19.83);
                yield return new delivery(4, 150, 10.75);
            }
        }
    }
}
