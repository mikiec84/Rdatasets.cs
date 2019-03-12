// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Utility bills
    /// </summary>

    public class Utilities
    {
        public readonly int κ;
        public readonly int month;
        public readonly int day;
        public readonly int year;
        public readonly int temp;
        public readonly int kwh;
        public readonly int ccf;
        public readonly double thermsPerDay;
        public readonly int billingDays;
        public readonly double totalbill;
        public readonly double gasbill;
        public readonly double elecbill;
        public readonly string notes;

        public Utilities(int κ, int month, int day, int year, int temp, int kwh, int ccf, double thermsPerDay, int billingDays, double totalbill, double gasbill, double elecbill, string notes)
        {
            this.κ = κ;
            this.month = month;
            this.day = day;
            this.year = year;
            this.temp = temp;
            this.kwh = kwh;
            this.ccf = ccf;
            this.thermsPerDay = thermsPerDay;
            this.billingDays = billingDays;
            this.totalbill = totalbill;
            this.gasbill = gasbill;
            this.elecbill = elecbill;
            this.notes = notes;
        }

        public static IEnumerable<Utilities> Data
        {
            get
            {
                yield return new Utilities(1, 12, 29, 1999, 26, 892, 194, 5.5, 36, 173.65, 112.72, 68.25, "");
                yield return new Utilities(2, 1, 28, 2000, 18, 533, 164, 5.6, 30, 139.18, 95.88, 43.3, "");
                yield return new Utilities(3, 2, 26, 2000, 24, 521, 228, 8, 29, 177.48, 134.65, 42.83, "");
                yield return new Utilities(4, 3, 25, 2000, 41, 554, 16, 0.6, 28, 61.27, 15.32, 45.95, "bad meter reading");
                yield return new Utilities(5, 4, 28, 2000, 45, 638, 74, 2.2, 34, 100.33, 47.33, 53, "");
                yield return new Utilities(6, 5, 30, 2000, 60, 700, 129, 4.1, 32, 153.32, 89.87, 63.45, "");
                yield return new Utilities(7, 6, 24, 2000, 66, 583, 23, 0.9, 25, 85.3, 25.55, 59.75, "");
                yield return new Utilities(8, 7, 26, 2000, 72, 935, 0, 0, 32, 102.44, 8.08, 94.36, "");
                yield return new Utilities(9, 8, 24, 2000, 72, 789, 13, 0.4, 29, 96.47, 17.66, 78.81, "");
                yield return new Utilities(10, 9, 25, 2000, 64, 864, 17, 0.5, 32, 104.86, 21.39, 83.47, "");
                yield return new Utilities(11, 10, 24, 2000, 54, 778, 37, 1.3, 29, 107.5, 41.19, 66.31, "");
                yield return new Utilities(12, 11, 26, 2000, 37, 617, 123, 3.8, 33, 150.13, 102.52, 47.61, "");
                yield return new Utilities(13, 12, 27, 2000, 11, 586, 235, 7.7, 31, 254.23, 210.87, 46.59, "");
                yield return new Utilities(14, 6, 26, 2001, 70, 160, 1, 0.1, 10, 31.55, 3.42, 17.43, "transfer back from England");
                yield return new Utilities(15, 7, 26, 2001, 76, 736, 7, 0.2, 30, 92.36, 12.79, 79.57, "");
                yield return new Utilities(16, 8, 26, 2001, 75, 923, 15, 0.5, 31, 114.95, 18.1, 96.85, "");
                yield return new Utilities(17, 9, 25, 2001, 64, 865, 20, 0.7, 30, 105.91, 20.17, 85.74, "");
                yield return new Utilities(18, 10, 24, 2001, 51, 828, 44, 1.6, 29, 107.58, 32.38, 75.2, "");
                yield return new Utilities(19, 11, 26, 2001, 48, 1046, 79, 2.4, 33, 134.5, 53.6, 80.9, "");
                yield return new Utilities(20, 1, 28, 2002, 23, 581, 210, 6.6, 32, 174.45, 127.86, 46.59, "");
                yield return new Utilities(21, 2, 26, 2002, 28, 551, 178, 6.2, 29, 147.06, 102.85, 44.21, "");
                yield return new Utilities(22, 3, 27, 2002, 21, 471, 190, 6.6, 29, 152.32, 113.63, 38.69, "");
                yield return new Utilities(23, 4, 28, 2002, 45, 449, 106, 3.3, 32, 106.04, 70.34, 35.7, "");
                yield return new Utilities(24, 5, 28, 2002, 51, 394, 60, 2, 30, 87.47, 48.92, 38.55, "");
                yield return new Utilities(25, 6, 26, 2002, 69, 496, 23, 0.8, 29, 76.43, 23.42, 53.01, "");
                yield return new Utilities(26, 7, 28, 2002, 76, 925, 16, 0.5, 32, 111.65, 18.61, 93.04, "");
                yield return new Utilities(27, 8, 26, 2002, 72, 812, 15, 0.5, 29, 101.39, 17.56, 83.83, "");
                yield return new Utilities(28, 9, 25, 2002, 69, 838, 16, 0.5, 30, 99.46, 18.16, 82.2, "");
                yield return new Utilities(29, 10, 24, 2002, 47, 790, 69, 2.4, 29, 122.51, 55.74, 66.77, "");
                yield return new Utilities(30, 11, 24, 2002, 34, 865, 126, 4.1, 31, 154.93, 94.67, 65.02, "");
                yield return new Utilities(31, 12, 29, 2002, 25, 1032, 190, 5.5, 35, 217.42, 140.49, 76.93, "");
                yield return new Utilities(32, 2, 26, 2003, 17, 580, 224, 7.8, 29, 232.41, 187.05, 45.36, "");
                yield return new Utilities(33, 3, 27, 2003, 29, 648, 153, 5.3, 29, 226.92, 176.02, 50.9, "");
                yield return new Utilities(34, 4, 28, 2003, 46, 503, 100, 3.2, 32, 127.07, 86.83, 40.24, "");
                yield return new Utilities(35, 5, 28, 2003, 56, 496, 43, 1.4, 30, 92.86, 43.77, 49.09, "");
                yield return new Utilities(36, 6, 26, 2003, 67, 722, 18, 0.6, 29, 99.52, 24.46, 75.06, "");
                yield return new Utilities(37, 7, 28, 2003, 72, 934, 15, 0.5, 32, 116.29, 21.28, 95.01, "");
                yield return new Utilities(38, 8, 26, 2003, 75, 869, 14, 0.5, 29, 108.04, 19.56, 89.12, "");
                yield return new Utilities(39, 9, 25, 2003, 69, 888, 16, 0.5, 30, 108.54, 21.08, 87.46, "");
                yield return new Utilities(40, 10, 26, 2003, 53, 927, 48, 1.5, 31, 127.37, 45.28, 82.09, "");
                yield return new Utilities(41, 11, 24, 2003, 35, 570, 130, 4.6, 29, 151.62, 106.61, 45.01, "");
                yield return new Utilities(42, 12, 29, 2003, 25, 725, 204, 5.9, 35, 225.73, 168.93, 56.8, "");
                yield return new Utilities(43, 1, 28, 2004, 15, 594, 242, 8.1, 30, 262.81, 216.89, 47.37, "");
                yield return new Utilities(44, 2, 26, 2004, 16, 563, 216, 7.6, 29, 239.6, 193.45, 46.15, "");
                yield return new Utilities(45, 3, 28, 2004, 35, 510, 144, 4.7, 31, 166.51, 124.18, 42.33, "");
                yield return new Utilities(46, 4, 27, 2004, 48, 709, 78, 2.6, 30, 120.08, 65.67, 54.41, "");
                yield return new Utilities(47, 5, 26, 2004, 58, 742, 35, 1.2, 29, 109.38, 39.4, 69.98, "");
                yield return new Utilities(48, 6, 27, 2004, 64, 911, 18, 0.6, 32, 119.65, 25.14, 94.51, "");
                yield return new Utilities(49, 7, 27, 2004, 72, 860, 8, 0.3, 30, 106.65, 15.59, 91.06, "");
                yield return new Utilities(50, 8, 25, 2004, 67, 841, 15, 0.5, 29, 111.08, 21.72, 89.36, "");
                yield return new Utilities(51, 9, 26, 2004, 71, 922, 15, 0.5, 32, 117.46, 21.25, 96.21, "");
                yield return new Utilities(52, 11, 23, 2004, 43, 860, 82, 2.8, 29, 160.26, 88.51, 71.75, "");
                yield return new Utilities(53, 12, 28, 2004, 23, 1160, 208, 6, 35, 317.47, 224.18, 93.29, "");
                yield return new Utilities(54, 1, 27, 2005, 15, 891, 224, 7.5, 30, 294.96, 223.92, 71.04, "");
                yield return new Utilities(55, 2, 24, 2005, 29, 557, 166, 6, 28, 213.71, 166.63, 47.08, "");
                yield return new Utilities(56, 3, 29, 2005, 31, 772, 179, 5.5, 33, 239.85, 117.05, 62.8, "");
                yield return new Utilities(57, 4, 28, 2005, 54, 444, 61, 2, 30, 103.34, 64.99, 38.35, "");
                yield return new Utilities(58, 5, 26, 2005, 56, 645, 51, 1.8, 28, 127.22, 61.81, 65.41, "");
                yield return new Utilities(59, 6, 27, 2005, 72, 939, 19, 0.6, 32, 131.02, 27.3, 103.72, "");
                yield return new Utilities(60, 7, 27, 2005, 78, 862, 11, 0.4, 30, 116.72, 19.96, 96.76, "high efficiency gas furnace and gas water heater installed");
                yield return new Utilities(61, 8, 25, 2005, 74, 845, 9, 0.3, 29, 120.53, 18.16, 102.37, "");
                yield return new Utilities(62, 9, 26, 2005, 69, 995, 11, 0.3, 32, 135.07, 22.33, 112.74, "");
                yield return new Utilities(63, 10, 25, 2005, 56, 965, 32, 1.1, 29, 150.62, 55.74, 94.88, "");
                yield return new Utilities(64, 11, 27, 2005, 41, 926, 99, 3.1, 33, 212.49, 153.24, 84.75, "");
                yield return new Utilities(65, 12, 28, 2005, 21, 931, 176, 5.8, 31, 324.52, 240.9, 83.62, "");
                yield return new Utilities(66, 1, 29, 2006, 30, 927, 144, 4.5, 32, 282.25, 193.84, 90.28, "");
                yield return new Utilities(67, 2, 27, 2006, 22, 876, 161, 5.6, 29, 289.91, 198.11, 91.8, "");
                yield return new Utilities(68, 3, 28, 2006, 34, 749, 116, 4, 29, 210.85, 138.65, 72.2, "");
                yield return new Utilities(69, 4, 26, 2006, 53, 428, 52, 1.8, 29, 96.87, 55, 41.87, "");
                yield return new Utilities(70, 5, 25, 2006, 59, 450, 38, 1.3, 29, 95.04, 47.39, 47.65, "");
                yield return new Utilities(71, 6, 26, 2006, 74, 694, 10, 0.3, 32, 98.48, 19.19, 79.32, "away for 10 days on vacation");
                yield return new Utilities(72, 7, 26, 2006, 78, 954, 7, 0.2, 30, 131.27, 16.37, 114.9, "");
                yield return new Utilities(73, 8, 24, 2006, 77, 957, 6, 0.2, 29, 134.96, 15.88, 119.3, "");
                yield return new Utilities(74, 9, 25, 2006, 64, 1027, 15, 0.5, 32, 156.51, 25.74, 130.77, "");
                yield return new Utilities(75, 10, 24, 2006, 50, 893, 47, 1.6, 29, 144.16, 46.12, 98.04, "");
                yield return new Utilities(76, 11, 26, 2006, 41, 663, 101, 3.1, 33, 168.24, 106.54, 62.72, "");
                yield return new Utilities(77, 12, 27, 2006, 30, 720, 140, 4.5, 31, 229.4, 159.08, 70.32, "");
                yield return new Utilities(78, 1, 28, 2007, 24, 897, 168, 5.3, 32, 267.72, 178.16, 89.97, "");
                yield return new Utilities(79, 2, 26, 2007, 13, 808, 191, 6.7, 29, 298.5, 207.53, 90.97, "");
                yield return new Utilities(80, 3, 26, 2007, 38, 724, 101, 3.6, 29, 192.67, 118.78, 73.89, "");
                yield return new Utilities(81, 4, 26, 2007, 46, 707, 77, 2.6, 30, 159.01, 82.76, 76.25, "");
                yield return new Utilities(82, 5, 28, 2007, 65, 442, 18, 0.6, 32, 86.54, 32.98, 53.56, "");
                yield return new Utilities(83, 6, 26, 2007, 74, 305, 7, 0.2, 29, 67.19, 21.41, 45.78, "");
                yield return new Utilities(84, 7, 27, 2007, 76, 839, 9, 0.3, 30, 135.73, 22.87, 112.99, "");
                yield return new Utilities(85, 8, 26, 2007, 75, 809, 6, 0.2, 31, 123.07, 19.17, 103.9, "");
                yield return new Utilities(86, 9, 25, 2007, 68, 812, 13, 0.4, 30, 117.82, 24.54, 98.9, "5.46 credit for \"cost of gas\"");
                yield return new Utilities(87, 10, 24, 2007, 58, 761, 28, 1, 29, 123.4, 38.59, 85.81, "");
                yield return new Utilities(88, 11, 26, 2007, 41, 767, 98, 3, 33, 181.53, 104.52, 77.01, "");
                yield return new Utilities(89, 12, 27, 2007, 18, 980, 182, 6, 31, 296.1, 194.91, 101.19, "");
                yield return new Utilities(90, 2, 26, 2008, 15, 804, 191, 6.7, 29, 292.12, 207.32, 84.8, "housesitters");
                yield return new Utilities(91, 3, 27, 2008, 28, 752, 139, 4.7, 30, 245.27, 167.3, 77.97, "housesitters");
                yield return new Utilities(92, 4, 27, 2008, 45, 623, 79, 2.6, 31, 160.69, 97.11, 63.58, "housesitters");
                yield return new Utilities(93, 5, 27, 2008, 55, 410, 29, 1, 30, 105.5, 52.15, 53.35, "housesitters");
                yield return new Utilities(94, 6, 25, 2008, 68, 196, 6, 0.2, 29, 53.92, 20.97, 32.95, "empty house");
                yield return new Utilities(95, 7, 27, 2008, 76, 477, 11, 0.3, 32, 99.14, 69.82, 29.32, "empty house");
                yield return new Utilities(96, 8, 25, 2008, 75, 544, 12, 0.4, 29, 103.28, 26.83, 76.45, "");
                yield return new Utilities(97, 9, 25, 2008, 67, 746, 16, 0.5, 31, 124.82, 29.77, 95.05, "");
                yield return new Utilities(98, 10, 26, 2008, 55, 801, 32, 1.1, 31, 134.3, 41.74, 92.56, "");
                yield return new Utilities(99, 11, 24, 2008, 39, 868, 91, 3, 29, 186.18, 93.6, 92.58, "");
                yield return new Utilities(100, 12, 29, 2008, 18, 1205, 199, 5.8, 35, 332.09, 209.21, 122.88, "");
                yield return new Utilities(101, 1, 28, 2009, 9, 986, 211, 7.2, 30, 330.27, 225.72, 104.55, "");
                yield return new Utilities(102, 2, 26, 2009, 23, 870, 159, 5.6, 29, 242.12, 147.82, 94.3, "");
                yield return new Utilities(103, 3, 29, 2009, 32, 830, 134, 4.4, 31, 207.96, 114.66, 93.3, "");
                yield return new Utilities(104, 4, 28, 2009, 47, 497, 74, 2.5, 30, 113.5, 58.03, 55.47, "");
                yield return new Utilities(105, 5, 28, 2009, 61, 436, 34, 1.2, 30, 93.09, 37.33, 55.76, "");
                yield return new Utilities(106, 6, 28, 2009, 69, 579, 19, 0.6, 31, 103.7, 24.88, 78.82, "");
                yield return new Utilities(107, 7, 28, 2009, 71, 734, 15, 0.5, 30, 122.7, 22.86, 99.84, "");
                yield return new Utilities(108, 8, 28, 2009, 72, 774, 10, 0.3, 29, 125.37, 19.43, 105.94, "Was this August?");
                yield return new Utilities(109, 9, 27, 2009, 69, 909, 18, 0.6, 32, 142.82, 23.72, 119.1, "");
                yield return new Utilities(110, 10, 26, 2009, 45, 842, 62, 2.2, 29, 158.02, 58.38, 102.52, "");
                yield return new Utilities(111, 11, 24, 2009, 46, 826, 67, 2.3, 29, 153.68, 61.46, 92.22, "");
                yield return new Utilities(112, 12, 30, 2009, 22, 1213, 188, 5.4, 36, 283.69, 131.49, 152.2, "estimated reading");
                yield return new Utilities(113, 1, 28, 2010, 15, 992, 206, 6.9, 29, 291.1, 180.73, 110.37, "");
                yield return new Utilities(114, 2, 28, 2010, 20, 1024, 187, 6.1, 31, 268.07, 163.62, 114.02, "9.57 escrow refund");
                yield return new Utilities(115, 3, 29, 2010, 41, 923, 95, 3.3, 29, 181.82, 79.15, 102.67, "");
                yield return new Utilities(116, 4, 27, 2010, 56, 814, 31, 1.1, 29, 100.61, 29.44, 95.22, "24.05 interim elec refund");
                yield return new Utilities(117, 5, 36, 2010, 60, 941, 31, 1.1, 29, 151.57, 38.29, 113.18, "");
            }
        }
    }
}
