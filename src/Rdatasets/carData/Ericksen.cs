// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// The 1980 U.S. Census Undercount
    /// </summary>

    public class Ericksen
    {
        public readonly double minority;
        public readonly int crime;
        public readonly double poverty;
        public readonly double language;
        public readonly double highschool;
        public readonly double housing;
        public readonly string city;
        public readonly int conventional;
        public readonly double undercount;

        public Ericksen(double minority, int crime, double poverty, double language, double highschool, double housing, string city, int conventional, double undercount)
        {
            this.minority = minority;
            this.crime = crime;
            this.poverty = poverty;
            this.language = language;
            this.highschool = highschool;
            this.housing = housing;
            this.city = city;
            this.conventional = conventional;
            this.undercount = undercount;
        }

        public static IEnumerable<Ericksen> Data
        {
            get
            {
                yield return new Ericksen(26.1, 49, 18.9, 0.2, 43.5, 7.6, "state", 0, -0.04);
                yield return new Ericksen(5.7, 62, 10.7, 1.7, 17.5, 23.6, "state", 100, 3.35);
                yield return new Ericksen(18.9, 81, 13.2, 3.2, 27.6, 8.1, "state", 18, 2.48);
                yield return new Ericksen(16.9, 38, 19, 0.2, 44.5, 7, "state", 0, -0.74);
                yield return new Ericksen(24.3, 73, 10.4, 5, 26, 11.8, "state", 4, 3.6);
                yield return new Ericksen(15.2, 73, 10.1, 1.2, 21.4, 9.2, "state", 19, 1.34);
                yield return new Ericksen(10.8, 58, 8, 2.4, 29.7, 21, "state", 0, -0.26);
                yield return new Ericksen(17.5, 68, 11.8, 0.7, 31.4, 8.9, "state", 0, -0.16);
                yield return new Ericksen(22.3, 81, 13.4, 3.6, 33.3, 10.1, "state", 0, 2.2);
                yield return new Ericksen(27.6, 55, 16.6, 0.3, 43.6, 10.2, "state", 0, 0.37);
                yield return new Ericksen(9.1, 75, 9.9, 5.7, 26.2, 17, "state", 29, 1.46);
                yield return new Ericksen(4.2, 48, 12.6, 1, 26.3, 9.1, "state", 56, 1.53);
                yield return new Ericksen(8.1, 48, 7.7, 1, 29.8, 13.5, "state", 0, 1.69);
                yield return new Ericksen(7.1, 48, 9.4, 0.5, 33.6, 9.9, "state", 0, -0.68);
                yield return new Ericksen(2.3, 47, 10.1, 0.3, 28.5, 10.4, "state", 0, -0.59);
                yield return new Ericksen(7.9, 54, 10.1, 0.5, 26.7, 8.5, "state", 14, 0.94);
                yield return new Ericksen(7.7, 34, 17.6, 0.2, 46.9, 10.6, "state", 0, -1.41);
                yield return new Ericksen(31.4, 54, 18.6, 1.1, 42.3, 9.7, "state", 0, 2.46);
                yield return new Ericksen(0.7, 44, 13, 1, 31.3, 19.5, "state", 40, 2.06);
                yield return new Ericksen(16.7, 58, 6.8, 0.8, 28.2, 10.5, "state", 0, 2.03);
                yield return new Ericksen(3.8, 53, 8.5, 2.1, 27.4, 26.9, "state", 4, -0.57);
                yield return new Ericksen(7, 61, 8.7, 0.7, 29.9, 9.4, "state", 8, 0.89);
                yield return new Ericksen(2.1, 48, 9.5, 0.5, 26.9, 10.7, "state", 11, 1.57);
                yield return new Ericksen(35.8, 34, 23.9, 0.2, 45.2, 7.2, "state", 0, 1.52);
                yield return new Ericksen(7.8, 45, 11.2, 0.3, 34.9, 9.1, "state", 0, 0.81);
                yield return new Ericksen(1.5, 50, 12.3, 0.4, 25.6, 12.8, "state", 75, 1.81);
                yield return new Ericksen(4.8, 43, 10.7, 0.5, 26.6, 9.7, "state", 33, 0.36);
                yield return new Ericksen(13, 88, 8.7, 1.6, 24.5, 11.7, "state", 10, 5.08);
                yield return new Ericksen(1, 47, 8.5, 0.8, 27.7, 20.3, "state", 0, -1.49);
                yield return new Ericksen(19, 64, 9.5, 3.6, 32.6, 23.7, "state", 0, 1.44);
                yield return new Ericksen(38.4, 59, 17.6, 4.6, 31.1, 10.7, "state", 58, 2.69);
                yield return new Ericksen(8, 48, 8.9, 1.3, 29.3, 21.6, "state", 0, -1.48);
                yield return new Ericksen(23.1, 46, 14.8, 0.2, 45.2, 8.2, "state", 0, 1.36);
                yield return new Ericksen(1, 30, 12.6, 0.5, 33.6, 15.1, "state", 70, 0.35);
                yield return new Ericksen(8.9, 52, 9.6, 0.5, 32.1, 11.3, "state", 0, 0.97);
                yield return new Ericksen(8.6, 50, 13.4, 0.5, 34, 8, "state", 0, -0.12);
                yield return new Ericksen(3.9, 60, 10.7, 0.8, 24.4, 7.9, "state", 13, 0.93);
                yield return new Ericksen(4.8, 33, 8.8, 0.6, 33.6, 13.3, "state", 0, -0.78);
                yield return new Ericksen(4.9, 59, 10.3, 3.2, 38.9, 29.6, "state", 0, 0.74);
                yield return new Ericksen(31, 53, 16.6, 0.2, 46.3, 7.9, "state", 0, 6.19);
                yield return new Ericksen(0.9, 32, 16.9, 0.4, 32.1, 12, "state", 84, 0.42);
                yield return new Ericksen(16.4, 44, 16.4, 0.2, 43.8, 9.4, "state", 0, -2.31);
                yield return new Ericksen(30.6, 55, 15, 4.7, 38.7, 7.7, "state", 1, 0.27);
                yield return new Ericksen(4.7, 58, 10.3, 0.9, 20, 11.3, "state", 14, 1.14);
                yield return new Ericksen(0.9, 50, 12.1, 0.5, 29, 20.8, "state", 0, -1.12);
                yield return new Ericksen(20, 46, 11.8, 0.5, 37.6, 10.3, "state", 0, 1.11);
                yield return new Ericksen(5.4, 69, 9.8, 1, 22.4, 9.4, "state", 4, 1.48);
                yield return new Ericksen(3.9, 25, 15, 0.2, 44, 9, "state", 0, -0.69);
                yield return new Ericksen(1.7, 45, 7.9, 0.4, 29.5, 12.8, "state", 9, 1.45);
                yield return new Ericksen(5.9, 49, 7.9, 0.7, 22.1, 13.2, "state", 100, 4.01);
                yield return new Ericksen(55.5, 100, 22.9, 0.7, 51.6, 23.3, "city", 0, 6.15);
                yield return new Ericksen(28.4, 135, 20.2, 4.4, 31.6, 52.1, "city", 0, 2.27);
                yield return new Ericksen(53.7, 66, 20.3, 6.7, 43.8, 51.4, "city", 0, 5.42);
                yield return new Ericksen(46.7, 101, 22.1, 1.6, 49.1, 36.4, "city", 0, 5.01);
                yield return new Ericksen(41.6, 118, 14.2, 3.1, 31.5, 12.9, "city", 0, 8.18);
                yield return new Ericksen(65.4, 106, 21.9, 1.6, 45.8, 18.6, "city", 0, 4.33);
                yield return new Ericksen(45.1, 80, 12.7, 5.1, 31.6, 8.9, "city", 0, 5.79);
                yield return new Ericksen(22.5, 53, 11.5, 0.3, 33.3, 13.6, "city", 0, 0.31);
                yield return new Ericksen(44.4, 100, 16.4, 12.7, 31.4, 15, "city", 0, 7.52);
                yield return new Ericksen(27.2, 65, 13.8, 1.6, 46.4, 27.2, "city", 0, 3.17);
                yield return new Ericksen(44, 101, 20, 8.9, 39.8, 32.2, "city", 0, 7.39);
                yield return new Ericksen(41.3, 60, 20.6, 2.2, 45.7, 21.7, "city", 0, 6.41);
                yield return new Ericksen(46.7, 143, 21.8, 0.5, 51.8, 40.9, "city", 0, 3.6);
                yield return new Ericksen(23.6, 81, 12.4, 4.2, 21.1, 11.2, "city", 0, 0.47);
                yield return new Ericksen(24.8, 107, 13.7, 9.2, 26, 20.3, "city", 0, 5.18);
                yield return new Ericksen(72.6, 102, 18.6, 1.1, 32.9, 21, "city", 0, 5.93);
            }
        }
    }
}
