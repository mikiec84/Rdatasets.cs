// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Dose-mortality data, for fumigation of codling moth with methyl bromide
    /// </summary>

    public class codling
    {
        public readonly int κ;
        public readonly int dose;
        public readonly int tot;
        public readonly int dead;
        public readonly double pobs;
        public readonly double cm;
        public readonly double ct;
        public readonly string Cultivar;
        public readonly int gp;
        public readonly int year;
        public readonly int numcm;

        public codling(int κ, int dose, int tot, int dead, double pobs, double cm, double ct, string Cultivar, int gp, int year, int numcm)
        {
            this.κ = κ;
            this.dose = dose;
            this.tot = tot;
            this.dead = dead;
            this.pobs = pobs;
            this.cm = cm;
            this.ct = ct;
            this.Cultivar = Cultivar;
            this.gp = gp;
            this.year = year;
            this.numcm = numcm;
        }

        public static IEnumerable<codling> Data
        {
            get
            {
                yield return new codling(1, 5, 866, 246, 0.2841, 0.2178, 15.5941666666667, "ROYAL", 1, 1988, 1676);
                yield return new codling(2, 8, 911, 220, 0.2415, 0.2178, 20.2604166666667, "ROYAL", 1, 1988, 1676);
                yield return new codling(3, 12, 906, 360, 0.3974, 0.2178, 28.6029166666667, "ROYAL", 1, 1988, 1676);
                yield return new codling(4, 16, 712, 271, 0.3806, 0.2178, 32.6883333333333, "ROYAL", 1, 1988, 1676);
                yield return new codling(5, 20, 582, 414, 0.7113, 0.2178, 45.4270833333333, "ROYAL", 1, 1988, 1676);
                yield return new codling(6, 24, 1183, 742, 0.6272, 0.2178, 45.4429166666667, "ROYAL", 1, 1988, 1676);
                yield return new codling(7, 5, 603, 154, 0.2554, 0.216, 16.2583333333333, "ROYAL", 2, 1988, 1597);
                yield return new codling(8, 8, 640, 168, 0.2625, 0.216, 25.1770833333333, "ROYAL", 2, 1988, 1597);
                yield return new codling(9, 12, 627, 180, 0.2871, 0.216, 32.7829166666667, "ROYAL", 2, 1988, 1597);
                yield return new codling(10, 16, 788, 240, 0.3046, 0.216, 40.1695833333333, "ROYAL", 2, 1988, 1597);
                yield return new codling(11, 20, 977, 380, 0.3889, 0.216, 45.0933333333333, "ROYAL", 2, 1988, 1597);
                yield return new codling(12, 24, 1137, 628, 0.5523, 0.216, 53.7120833333333, "ROYAL", 2, 1988, 1597);
                yield return new codling(13, 8, 702, 187, 0.2664, 0.2641, 22.3829166666667, "BRAEBURN", 3, 1988, 1662);
                yield return new codling(15, 16, 825, 302, 0.3661, 0.2641, 33.06, "BRAEBURN", 3, 1988, 1662);
                yield return new codling(16, 20, 572, 500, 0.8741, 0.2641, 50.3742720450844, "BRAEBURN", 3, 1988, 1662);
                yield return new codling(17, 24, 472, 417, 0.8835, 0.2641, 53.2475, "BRAEBURN", 3, 1988, 1662);
                yield return new codling(18, 30, 433, 424, 0.9792, 0.2641, 59.0816666666667, "BRAEBURN", 3, 1988, 1662);
                yield return new codling(19, 8, 613, 219, 0.3573, 0.2765, 23.39875, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(20, 12, 885, 367, 0.4147, 0.2765, 32.9283333333333, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(21, 16, 571, 188, 0.3292, 0.2765, 39.4425, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(22, 20, 239, 151, 0.6318, 0.2765, 47.3595833333333, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(23, 24, 462, 423, 0.9156, 0.2765, 54.53625, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(24, 30, 471, 466, 0.9894, 0.2765, 60.5016666666667, "BRAEBURN", 4, 1988, 2123);
                yield return new codling(25, 8, 656, 218, 0.3323, 0.2126, 29.3770833333333, "FUJI", 5, 1988, 1392);
                yield return new codling(26, 12, 529, 184, 0.3478, 0.2126, 32.73, "FUJI", 5, 1988, 1392);
                yield return new codling(27, 16, 812, 368, 0.4532, 0.2126, 39.1920833333333, "FUJI", 5, 1988, 1392);
                yield return new codling(28, 20, 514, 236, 0.4591, 0.2126, 42.8283333333333, "FUJI", 5, 1988, 1392);
                yield return new codling(29, 24, 524, 402, 0.7672, 0.2126, 51.4825, "FUJI", 5, 1988, 1392);
                yield return new codling(30, 30, 630, 597, 0.9476, 0.2126, 60.20875, "FUJI", 5, 1988, 1392);
                yield return new codling(31, 8, 664, 191, 0.2877, 0.1997, 25.3783333333333, "FUJI", 6, 1988, 1773);
                yield return new codling(32, 12, 582, 173, 0.2973, 0.1997, 33.3458333333333, "FUJI", 6, 1988, 1773);
                yield return new codling(33, 16, 504, 189, 0.375, 0.1997, 40.0575, "FUJI", 6, 1988, 1773);
                yield return new codling(34, 20, 449, 245, 0.5457, 0.1997, 47.5983333333333, "FUJI", 6, 1988, 1773);
                yield return new codling(35, 24, 522, 345, 0.6609, 0.1997, 53.94625, "FUJI", 6, 1988, 1773);
                yield return new codling(36, 30, 596, 552, 0.9262, 0.1997, 61.8966666666667, "FUJI", 6, 1988, 1773);
                yield return new codling(37, 8, 392, 127, 0.324, 0.2141, 27.3968856864114, "GRANNY", 7, 1988, 2284);
                yield return new codling(38, 12, 428, 126, 0.2944, 0.2141, 33.1066666666667, "GRANNY", 7, 1988, 2284);
                yield return new codling(39, 16, 541, 220, 0.4067, 0.2141, 40.12875, "GRANNY", 7, 1988, 2284);
                yield return new codling(40, 20, 638, 408, 0.6395, 0.2141, 47.6920833333333, "GRANNY", 7, 1988, 2284);
                yield return new codling(41, 24, 743, 584, 0.786, 0.2141, 54.77875, "GRANNY", 7, 1988, 2284);
                yield return new codling(42, 30, 314, 311, 0.9904, 0.2141, 63.2333333333333, "GRANNY", 7, 1988, 2284);
                yield return new codling(43, 8, 619, 199, 0.3215, 0.2368, 27.2933333333333, "GRANNY", 8, 1988, 3277);
                yield return new codling(44, 12, 437, 142, 0.3249, 0.2368, 32.9266666666667, "GRANNY", 8, 1988, 3277);
                yield return new codling(45, 16, 670, 285, 0.4254, 0.2368, 40.08625, "GRANNY", 8, 1988, 3277);
                yield return new codling(46, 20, 404, 262, 0.6485, 0.2368, 47.9370833333333, "GRANNY", 8, 1988, 3277);
                yield return new codling(47, 24, 743, 569, 0.7658, 0.2368, 53.5170833333333, "GRANNY", 8, 1988, 3277);
                yield return new codling(48, 30, 535, 488, 0.9121, 0.2368, 61.7095833333333, "GRANNY", 8, 1988, 3277);
                yield return new codling(49, 8, 333, 119, 0.3574, 0.1779, 28.1191666666667, "Red Delicious", 9, 1988, 1147);
                yield return new codling(50, 12, 448, 124, 0.2768, 0.1779, 31.0508333333333, "Red Delicious", 9, 1988, 1147);
                yield return new codling(51, 16, 420, 196, 0.4667, 0.1779, 38.7316666666667, "Red Delicious", 9, 1988, 1147);
                yield return new codling(52, 20, 485, 368, 0.7588, 0.1779, 46.4852289423014, "Red Delicious", 9, 1988, 1147);
                yield return new codling(53, 24, 405, 381, 0.9407, 0.1779, 51.7720833333333, "Red Delicious", 9, 1988, 1147);
                yield return new codling(54, 30, 375, 374, 0.9973, 0.1779, 64.75375, "Red Delicious", 9, 1988, 1147);
                yield return new codling(55, 8, 297, 109, 0.367, 0.1506, 28.5666666666667, "Red Delicious", 10, 1988, 1122);
                yield return new codling(56, 12, 488, 166, 0.3402, 0.1506, 32.1966666666667, "Red Delicious", 10, 1988, 1122);
                yield return new codling(57, 16, 351, 208, 0.5926, 0.1506, 39.4133333333333, "Red Delicious", 10, 1988, 1122);
                yield return new codling(58, 20, 268, 235, 0.8769, 0.1506, 53.6816666666667, "Red Delicious", 10, 1988, 1122);
                yield return new codling(59, 24, 429, 413, 0.9627, 0.1506, 54.0372821059842, "Red Delicious", 10, 1988, 1122);
                yield return new codling(60, 30, 336, 330, 0.9821, 0.1506, 62.41, "Red Delicious", 10, 1988, 1122);
                yield return new codling(61, 8, 334, 96, 0.2874, 0.1978, 26.14875, "Red Delicious", 11, 1988, 1067);
                yield return new codling(62, 12, 621, 203, 0.3269, 0.1978, 31.7758333333333, "Red Delicious", 11, 1988, 1067);
                yield return new codling(63, 16, 369, 211, 0.5718, 0.1978, 40.3879166666667, "Red Delicious", 11, 1988, 1067);
                yield return new codling(64, 20, 352, 276, 0.7841, 0.1978, 47.0875, "Red Delicious", 11, 1988, 1067);
                yield return new codling(65, 24, 446, 412, 0.9238, 0.1978, 53.76875, "Red Delicious", 11, 1988, 1067);
                yield return new codling(66, 30, 456, 441, 0.9671, 0.1978, 64.7441666666667, "Red Delicious", 11, 1988, 1067);
                yield return new codling(211, 8, 878, 273, 0.3109, 0.2353, 26.7354166666667, "Gala", 12, 1989, 2214);
                yield return new codling(322, 12, 513, 181, 0.3528, 0.2353, 32.1033333333333, "Gala", 12, 1989, 2214);
                yield return new codling(433, 16, 662, 323, 0.4879, 0.2353, 40.9820833333333, "Gala", 12, 1989, 2214);
                yield return new codling(544, 20, 1030, 652, 0.633, 0.2353, 48.69625, "Gala", 12, 1989, 2214);
                yield return new codling(655, 24, 278, 274, 0.9856, 0.2353, 53.3166666666667, "Gala", 12, 1989, 2214);
                yield return new codling(76, 30, 1433, 1411, 0.9846, 0.2353, 64.995, "Gala", 12, 1989, 2214);
                yield return new codling(97, 8, 401, 116, 0.2893, 0.2523, 27.1040984981597, "Gala", 13, 1989, 3226);
                yield return new codling(108, 12, 404, 151, 0.3738, 0.2523, 33.1152541053518, "Gala", 13, 1989, 3226);
                yield return new codling(119, 16, 637, 295, 0.4631, 0.2523, 40.7106708886953, "Gala", 13, 1989, 3226);
                yield return new codling(1210, 20, 453, 267, 0.5894, 0.2523, 45.9823271577513, "Gala", 13, 1989, 3226);
                yield return new codling(1311, 24, 650, 535, 0.8231, 0.2523, 53.682656056134, "Gala", 13, 1989, 3226);
                yield return new codling(14, 30, 515, 492, 0.9553, 0.2523, 62.5694727533174, "Gala", 13, 1989, 3226);
                yield return new codling(1612, 8, 820, 183, 0.2232, 0.1946, 29.0990103044695, "Red Delicious", 14, 1989, 4177);
                yield return new codling(1713, 12, 541, 147, 0.2717, 0.1946, 33.9473321403348, "Red Delicious", 14, 1989, 4177);
                yield return new codling(1814, 16, 1166, 556, 0.4768, 0.1946, 41.7075945998572, "Red Delicious", 14, 1989, 4177);
                yield return new codling(1915, 20, 939, 633, 0.6741, 0.1946, 49.5625684076822, "Red Delicious", 14, 1989, 4177);
                yield return new codling(2016, 24, 601, 421, 0.7005, 0.1946, 54.326580708295, "Red Delicious", 14, 1989, 4177);
                yield return new codling(2117, 30, 1152, 1138, 0.9878, 0.1946, 64.32503985641, "Red Delicious", 14, 1989, 4177);
                yield return new codling(2419, 12, 901, 492, 0.5461, 0.2357, 37.8645833333333, "Red Delicious", 15, 1989, 2333);
                yield return new codling(2520, 16, 1164, 602, 0.5172, 0.2357, 42.0395833333333, "Red Delicious", 15, 1989, 2333);
                yield return new codling(2621, 20, 952, 628, 0.6597, 0.2357, 49.68125, "Red Delicious", 15, 1989, 2333);
                yield return new codling(2722, 24, 1019, 873, 0.8567, 0.2357, 56.2041666666667, "Red Delicious", 15, 1989, 2333);
                yield return new codling(2823, 30, 1093, 1067, 0.9762, 0.2357, 63.4945833333333, "Red Delicious", 15, 1989, 2333);
                yield return new codling(3024, 8, 2965, 726, 0.2449, 0.1879, 27.7083333333333, "Splendour", 16, 1989, 1474);
                yield return new codling(3125, 12, 1649, 650, 0.3942, 0.1879, 34.5866666666667, "Splendour", 16, 1989, 1474);
                yield return new codling(3226, 16, 1027, 728, 0.7089, 0.1879, 40.3966666666667, "Splendour", 16, 1989, 1474);
                yield return new codling(3327, 20, 2430, 1492, 0.614, 0.1879, 46.5675, "Splendour", 16, 1989, 1474);
                yield return new codling(3428, 24, 2510, 1729, 0.6888, 0.1879, 51.9270833333333, "Splendour", 16, 1989, 1474);
                yield return new codling(3529, 30, 2097, 1968, 0.9385, 0.1879, 62.51875, "Splendour", 16, 1989, 1474);
                yield return new codling(3831, 12, 1430, 531, 0.3713, 0.2481, 34.9229166666667, "Splendour", 17, 1989, 2648);
                yield return new codling(3932, 16, 558, 273, 0.4892, 0.2481, 42.5129166666667, "Splendour", 17, 1989, 2648);
                yield return new codling(4033, 23, 1094, 911, 0.8327, 0.2481, 54.66375, "Splendour", 17, 1989, 2648);
                yield return new codling(4134, 24, 1156, 937, 0.8106, 0.2481, 53.87, "Splendour", 17, 1989, 2648);
                yield return new codling(4235, 30, 795, 788, 0.9912, 0.2481, 64.13375, "Splendour", 17, 1989, 2648);
            }
        }
    }
}
