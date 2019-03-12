// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Florence Nightingale's data on deaths from various causes in the Crimean War
    /// </summary>

    public class Nightingale
    {
        public readonly int κ;
        public readonly string Date;
        public readonly string Month;
        public readonly int Year;
        public readonly int Army;
        public readonly int Disease;
        public readonly int Wounds;
        public readonly int Other;
        public readonly double Disease_rate;
        public readonly double Wounds_rate;
        public readonly double Other_rate;

        public Nightingale(int κ, string Date, string Month, int Year, int Army, int Disease, int Wounds, int Other, double Disease_rate, double Wounds_rate, double Other_rate)
        {
            this.κ = κ;
            this.Date = Date;
            this.Month = Month;
            this.Year = Year;
            this.Army = Army;
            this.Disease = Disease;
            this.Wounds = Wounds;
            this.Other = Other;
            this.Disease_rate = Disease_rate;
            this.Wounds_rate = Wounds_rate;
            this.Other_rate = Other_rate;
        }

        public static IEnumerable<Nightingale> Data
        {
            get
            {
                yield return new Nightingale(1, "1854-04-01", "Apr", 1854, 8571, 1, 0, 5, 1.4, 0, 7);
                yield return new Nightingale(2, "1854-05-01", "May", 1854, 23333, 12, 0, 9, 6.2, 0, 4.6);
                yield return new Nightingale(3, "1854-06-01", "Jun", 1854, 28333, 11, 0, 6, 4.7, 0, 2.5);
                yield return new Nightingale(4, "1854-07-01", "Jul", 1854, 28722, 359, 0, 23, 150, 0, 9.6);
                yield return new Nightingale(5, "1854-08-01", "Aug", 1854, 30246, 828, 1, 30, 328.5, 0.4, 11.9);
                yield return new Nightingale(6, "1854-09-01", "Sep", 1854, 30290, 788, 81, 70, 312.2, 32.1, 27.7);
                yield return new Nightingale(7, "1854-10-01", "Oct", 1854, 30643, 503, 132, 128, 197, 51.7, 50.1);
                yield return new Nightingale(8, "1854-11-01", "Nov", 1854, 29736, 844, 287, 106, 340.6, 115.8, 42.8);
                yield return new Nightingale(9, "1854-12-01", "Dec", 1854, 32779, 1725, 114, 131, 631.5, 41.7, 48);
                yield return new Nightingale(10, "1855-01-01", "Jan", 1855, 32393, 2761, 83, 324, 1022.8, 30.7, 120);
                yield return new Nightingale(11, "1855-02-01", "Feb", 1855, 30919, 2120, 42, 361, 822.8, 16.3, 140.1);
                yield return new Nightingale(12, "1855-03-01", "Mar", 1855, 30107, 1205, 32, 172, 480.3, 12.8, 68.6);
                yield return new Nightingale(13, "1855-04-01", "Apr", 1855, 32252, 477, 48, 57, 177.5, 17.9, 21.2);
                yield return new Nightingale(14, "1855-05-01", "May", 1855, 35473, 508, 49, 37, 171.8, 16.6, 12.5);
                yield return new Nightingale(15, "1855-06-01", "Jun", 1855, 38863, 802, 209, 31, 247.6, 64.5, 9.6);
                yield return new Nightingale(16, "1855-07-01", "Jul", 1855, 42647, 382, 134, 33, 107.5, 37.7, 9.3);
                yield return new Nightingale(17, "1855-08-01", "Aug", 1855, 44614, 483, 164, 25, 129.9, 44.1, 6.7);
                yield return new Nightingale(18, "1855-09-01", "Sep", 1855, 47751, 189, 276, 20, 47.5, 69.4, 5);
                yield return new Nightingale(19, "1855-10-01", "Oct", 1855, 46852, 128, 53, 18, 32.8, 13.6, 4.6);
                yield return new Nightingale(20, "1855-11-01", "Nov", 1855, 37853, 178, 33, 32, 56.4, 10.5, 10.1);
                yield return new Nightingale(21, "1855-12-01", "Dec", 1855, 43217, 91, 18, 28, 25.3, 5, 7.8);
                yield return new Nightingale(22, "1856-01-01", "Jan", 1856, 44212, 42, 2, 48, 11.4, 0.5, 13);
                yield return new Nightingale(23, "1856-02-01", "Feb", 1856, 43485, 24, 0, 19, 6.6, 0, 5.2);
                yield return new Nightingale(24, "1856-03-01", "Mar", 1856, 46140, 15, 0, 35, 3.9, 0, 9.1);
            }
        }
    }
}
