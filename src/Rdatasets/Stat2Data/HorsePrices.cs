// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// HorsePrices
    /// </summary>

    public class HorsePrices
    {
        public readonly int HorseID;
        public readonly int Price;
        public readonly double Age;
        public readonly string Height;
        public readonly string Sex;

        public HorsePrices(int HorseID, int Price, double Age, string Height, string Sex)
        {
            this.HorseID = HorseID;
            this.Price = Price;
            this.Age = Age;
            this.Height = Height;
            this.Sex = Sex;
        }

        public static IEnumerable<HorsePrices> Data
        {
            get
            {
                yield return new HorsePrices(97, 38000, 3, "16.75", "m");
                yield return new HorsePrices(156, 40000, 5, "17", "m");
                yield return new HorsePrices(56, 10000, 1, null, "m");
                yield return new HorsePrices(139, 12000, 8, "16", "f");
                yield return new HorsePrices(65, 25000, 4, "16.25", "m");
                yield return new HorsePrices(184, 35000, 8, "16.25", "f");
                yield return new HorsePrices(88, 35000, 5, "16.5", "m");
                yield return new HorsePrices(182, 12000, 17, "16.75", "f");
                yield return new HorsePrices(101, 22000, 4, "17.25", "m");
                yield return new HorsePrices(135, 25000, 6, "15.25", "f");
                yield return new HorsePrices(35, 40000, 7, "16.75", "m");
                yield return new HorsePrices(39, 25000, 7, "15.75", "f");
                yield return new HorsePrices(198, 4500, 14, "16", "f");
                yield return new HorsePrices(107, 19900, 6, "15.5", "m");
                yield return new HorsePrices(148, 45000, 3, "15.75", "f");
                yield return new HorsePrices(102, 45000, 6, "16.75", "m");
                yield return new HorsePrices(96, 48000, 6, "16.5", "m");
                yield return new HorsePrices(71, 15500, 12, "15.75", "f");
                yield return new HorsePrices(28, 8500, 7, "16.25", "f");
                yield return new HorsePrices(30, 22000, 7, "16.5", "f");
                yield return new HorsePrices(31, 35000, 5, "16.25", "m");
                yield return new HorsePrices(60, 16000, 7, "16.25", "m");
                yield return new HorsePrices(23, 16000, 3, "16.25", "m");
                yield return new HorsePrices(115, 15000, 7, "16.25", "f");
                yield return new HorsePrices(234, 33000, 4, "16.5", "m");
                yield return new HorsePrices(132, 20000, 14, "16.5", "m");
                yield return new HorsePrices(69, 25000, 6, "17", "m");
                yield return new HorsePrices(141, 30000, 8, "16.75", "m");
                yield return new HorsePrices(63, 50000, 6, "16.75", "m");
                yield return new HorsePrices(164, 1100, 19, "16.25", "f");
                yield return new HorsePrices(178, 15000, 0.5, "14.25", "f");
                yield return new HorsePrices(4, 45000, 14, "17", "m");
                yield return new HorsePrices(211, 2000, 20, "16", "f");
                yield return new HorsePrices(89, 20000, 3, "15.75", "f");
                yield return new HorsePrices(57, 45000, 5, "16.5", "m");
                yield return new HorsePrices(200, 20000, 12, "17", "m");
                yield return new HorsePrices(38, 50000, 7, "17.25", "m");
                yield return new HorsePrices(2, 50000, 8, "16.5", "m");
                yield return new HorsePrices(248, 39000, 11, "17.25", "m");
                yield return new HorsePrices(27, 20000, 11, "16.75", "m");
                yield return new HorsePrices(19, 12000, 6, "16.5", "f");
                yield return new HorsePrices(129, 15000, 2, "15", "f");
                yield return new HorsePrices(13, 27500, 5, "16", "f");
                yield return new HorsePrices(206, 12000, 2, null, "f");
                yield return new HorsePrices(236, 6000, 0.5, null, "f");
                yield return new HorsePrices(179, 15000, 0.5, "14.5", "m");
                yield return new HorsePrices(232, 60000, 13, "16.75", "m");
                yield return new HorsePrices(152, 50000, 4, "16.5", "m");
                yield return new HorsePrices(36, 30000, 9, "16.5", "m");
                yield return new HorsePrices(249, 40000, 7, "17.25", "m");
            }
        }
    }
}
