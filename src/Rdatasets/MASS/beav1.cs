// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Body Temperature Series of Beaver 1
    /// </summary>

    public class beav1
    {
        public readonly int day;
        public readonly int time;
        public readonly double temp;
        public readonly int activ;

        public beav1(int day, int time, double temp, int activ)
        {
            this.day = day;
            this.time = time;
            this.temp = temp;
            this.activ = activ;
        }

        public static IEnumerable<beav1> Data
        {
            get
            {
                yield return new beav1(346, 840, 36.33, 0);
                yield return new beav1(346, 850, 36.34, 0);
                yield return new beav1(346, 900, 36.35, 0);
                yield return new beav1(346, 910, 36.42, 0);
                yield return new beav1(346, 920, 36.55, 0);
                yield return new beav1(346, 930, 36.69, 0);
                yield return new beav1(346, 940, 36.71, 0);
                yield return new beav1(346, 950, 36.75, 0);
                yield return new beav1(346, 1000, 36.81, 0);
                yield return new beav1(346, 1010, 36.88, 0);
                yield return new beav1(346, 1020, 36.89, 0);
                yield return new beav1(346, 1030, 36.91, 0);
                yield return new beav1(346, 1040, 36.85, 0);
                yield return new beav1(346, 1050, 36.89, 0);
                yield return new beav1(346, 1100, 36.89, 0);
                yield return new beav1(346, 1110, 36.67, 0);
                yield return new beav1(346, 1120, 36.5, 0);
                yield return new beav1(346, 1130, 36.74, 0);
                yield return new beav1(346, 1140, 36.77, 0);
                yield return new beav1(346, 1150, 36.76, 0);
                yield return new beav1(346, 1200, 36.78, 0);
                yield return new beav1(346, 1210, 36.82, 0);
                yield return new beav1(346, 1220, 36.89, 0);
                yield return new beav1(346, 1230, 36.99, 0);
                yield return new beav1(346, 1240, 36.92, 0);
                yield return new beav1(346, 1250, 36.99, 0);
                yield return new beav1(346, 1300, 36.89, 0);
                yield return new beav1(346, 1310, 36.94, 0);
                yield return new beav1(346, 1320, 36.92, 0);
                yield return new beav1(346, 1330, 36.97, 0);
                yield return new beav1(346, 1340, 36.91, 0);
                yield return new beav1(346, 1350, 36.79, 0);
                yield return new beav1(346, 1400, 36.77, 0);
                yield return new beav1(346, 1410, 36.69, 0);
                yield return new beav1(346, 1420, 36.62, 0);
                yield return new beav1(346, 1430, 36.54, 0);
                yield return new beav1(346, 1440, 36.55, 0);
                yield return new beav1(346, 1450, 36.67, 0);
                yield return new beav1(346, 1500, 36.69, 0);
                yield return new beav1(346, 1510, 36.62, 0);
                yield return new beav1(346, 1520, 36.64, 0);
                yield return new beav1(346, 1530, 36.59, 0);
                yield return new beav1(346, 1540, 36.65, 0);
                yield return new beav1(346, 1550, 36.75, 0);
                yield return new beav1(346, 1600, 36.8, 0);
                yield return new beav1(346, 1610, 36.81, 0);
                yield return new beav1(346, 1620, 36.87, 0);
                yield return new beav1(346, 1630, 36.87, 0);
                yield return new beav1(346, 1640, 36.89, 0);
                yield return new beav1(346, 1650, 36.94, 0);
                yield return new beav1(346, 1700, 36.98, 0);
                yield return new beav1(346, 1710, 36.95, 0);
                yield return new beav1(346, 1720, 37, 0);
                yield return new beav1(346, 1730, 37.07, 1);
                yield return new beav1(346, 1740, 37.05, 0);
                yield return new beav1(346, 1750, 37, 0);
                yield return new beav1(346, 1800, 36.95, 0);
                yield return new beav1(346, 1810, 37, 0);
                yield return new beav1(346, 1820, 36.94, 0);
                yield return new beav1(346, 1830, 36.88, 0);
                yield return new beav1(346, 1840, 36.93, 0);
                yield return new beav1(346, 1850, 36.98, 0);
                yield return new beav1(346, 1900, 36.97, 0);
                yield return new beav1(346, 1910, 36.85, 0);
                yield return new beav1(346, 1920, 36.92, 0);
                yield return new beav1(346, 1930, 36.99, 0);
                yield return new beav1(346, 1940, 37.01, 0);
                yield return new beav1(346, 1950, 37.1, 1);
                yield return new beav1(346, 2000, 37.09, 0);
                yield return new beav1(346, 2010, 37.02, 0);
                yield return new beav1(346, 2020, 36.96, 0);
                yield return new beav1(346, 2030, 36.84, 0);
                yield return new beav1(346, 2040, 36.87, 0);
                yield return new beav1(346, 2050, 36.85, 0);
                yield return new beav1(346, 2100, 36.85, 0);
                yield return new beav1(346, 2110, 36.87, 0);
                yield return new beav1(346, 2120, 36.89, 0);
                yield return new beav1(346, 2130, 36.86, 0);
                yield return new beav1(346, 2140, 36.91, 0);
                yield return new beav1(346, 2150, 37.53, 1);
                yield return new beav1(346, 2200, 37.23, 0);
                yield return new beav1(346, 2210, 37.2, 0);
                yield return new beav1(346, 2230, 37.25, 1);
                yield return new beav1(346, 2240, 37.2, 0);
                yield return new beav1(346, 2250, 37.21, 0);
                yield return new beav1(346, 2300, 37.24, 1);
                yield return new beav1(346, 2310, 37.1, 0);
                yield return new beav1(346, 2320, 37.2, 0);
                yield return new beav1(346, 2330, 37.18, 0);
                yield return new beav1(346, 2340, 36.93, 0);
                yield return new beav1(346, 2350, 36.83, 0);
                yield return new beav1(347, 0, 36.93, 0);
                yield return new beav1(347, 10, 36.83, 0);
                yield return new beav1(347, 20, 36.8, 0);
                yield return new beav1(347, 30, 36.75, 0);
                yield return new beav1(347, 40, 36.71, 0);
                yield return new beav1(347, 50, 36.73, 0);
                yield return new beav1(347, 100, 36.75, 0);
                yield return new beav1(347, 110, 36.72, 0);
                yield return new beav1(347, 120, 36.76, 0);
                yield return new beav1(347, 130, 36.7, 0);
                yield return new beav1(347, 140, 36.82, 0);
                yield return new beav1(347, 150, 36.88, 0);
                yield return new beav1(347, 200, 36.94, 0);
                yield return new beav1(347, 210, 36.79, 0);
                yield return new beav1(347, 220, 36.78, 0);
                yield return new beav1(347, 230, 36.8, 0);
                yield return new beav1(347, 240, 36.82, 0);
                yield return new beav1(347, 250, 36.84, 0);
                yield return new beav1(347, 300, 36.86, 0);
                yield return new beav1(347, 310, 36.88, 0);
                yield return new beav1(347, 320, 36.93, 0);
                yield return new beav1(347, 330, 36.97, 0);
                yield return new beav1(347, 340, 37.15, 1);
            }
        }
    }
}
