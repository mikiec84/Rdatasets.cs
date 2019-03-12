// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival from Malignant Melanoma
    /// </summary>

    public class Melanoma
    {
        public readonly int κ;
        public readonly int time;
        public readonly int status;
        public readonly int sex;
        public readonly int age;
        public readonly int year;
        public readonly double thickness;
        public readonly int ulcer;

        public Melanoma(int κ, int time, int status, int sex, int age, int year, double thickness, int ulcer)
        {
            this.κ = κ;
            this.time = time;
            this.status = status;
            this.sex = sex;
            this.age = age;
            this.year = year;
            this.thickness = thickness;
            this.ulcer = ulcer;
        }

        public static IEnumerable<Melanoma> Data
        {
            get
            {
                yield return new Melanoma(1, 10, 3, 1, 76, 1972, 6.76, 1);
                yield return new Melanoma(2, 30, 3, 1, 56, 1968, 0.65, 0);
                yield return new Melanoma(3, 35, 2, 1, 41, 1977, 1.34, 0);
                yield return new Melanoma(4, 99, 3, 0, 71, 1968, 2.9, 0);
                yield return new Melanoma(5, 185, 1, 1, 52, 1965, 12.08, 1);
                yield return new Melanoma(6, 204, 1, 1, 28, 1971, 4.84, 1);
                yield return new Melanoma(7, 210, 1, 1, 77, 1972, 5.16, 1);
                yield return new Melanoma(8, 232, 3, 0, 60, 1974, 3.22, 1);
                yield return new Melanoma(9, 232, 1, 1, 49, 1968, 12.88, 1);
                yield return new Melanoma(10, 279, 1, 0, 68, 1971, 7.41, 1);
                yield return new Melanoma(11, 295, 1, 0, 53, 1969, 4.19, 1);
                yield return new Melanoma(12, 355, 3, 0, 64, 1972, 0.16, 1);
                yield return new Melanoma(13, 386, 1, 0, 68, 1965, 3.87, 1);
                yield return new Melanoma(14, 426, 1, 1, 63, 1970, 4.84, 1);
                yield return new Melanoma(15, 469, 1, 0, 14, 1969, 2.42, 1);
                yield return new Melanoma(16, 493, 3, 1, 72, 1971, 12.56, 1);
                yield return new Melanoma(17, 529, 1, 1, 46, 1971, 5.8, 1);
                yield return new Melanoma(18, 621, 1, 1, 72, 1972, 7.06, 1);
                yield return new Melanoma(19, 629, 1, 1, 95, 1968, 5.48, 1);
                yield return new Melanoma(20, 659, 1, 1, 54, 1972, 7.73, 1);
                yield return new Melanoma(21, 667, 1, 0, 89, 1968, 13.85, 1);
                yield return new Melanoma(22, 718, 1, 1, 25, 1967, 2.34, 1);
                yield return new Melanoma(23, 752, 1, 1, 37, 1973, 4.19, 1);
                yield return new Melanoma(24, 779, 1, 1, 43, 1967, 4.04, 1);
                yield return new Melanoma(25, 793, 1, 1, 68, 1970, 4.84, 1);
                yield return new Melanoma(26, 817, 1, 0, 67, 1966, 0.32, 0);
                yield return new Melanoma(27, 826, 3, 0, 86, 1965, 8.54, 1);
                yield return new Melanoma(28, 833, 1, 0, 56, 1971, 2.58, 1);
                yield return new Melanoma(29, 858, 1, 0, 16, 1967, 3.56, 0);
                yield return new Melanoma(30, 869, 1, 0, 42, 1965, 3.54, 0);
                yield return new Melanoma(31, 872, 1, 0, 65, 1968, 0.97, 0);
                yield return new Melanoma(32, 967, 1, 1, 52, 1970, 4.83, 1);
                yield return new Melanoma(33, 977, 1, 1, 58, 1967, 1.62, 1);
                yield return new Melanoma(34, 982, 1, 0, 60, 1970, 6.44, 1);
                yield return new Melanoma(35, 1041, 1, 1, 68, 1967, 14.66, 0);
                yield return new Melanoma(36, 1055, 1, 0, 75, 1967, 2.58, 1);
                yield return new Melanoma(37, 1062, 1, 1, 19, 1966, 3.87, 1);
                yield return new Melanoma(38, 1075, 1, 1, 66, 1971, 3.54, 1);
                yield return new Melanoma(39, 1156, 1, 0, 56, 1970, 1.34, 1);
                yield return new Melanoma(40, 1228, 1, 1, 46, 1973, 2.24, 1);
                yield return new Melanoma(41, 1252, 1, 0, 58, 1971, 3.87, 1);
                yield return new Melanoma(42, 1271, 1, 0, 74, 1971, 3.54, 1);
                yield return new Melanoma(43, 1312, 1, 0, 65, 1970, 17.42, 1);
                yield return new Melanoma(44, 1427, 3, 1, 64, 1972, 1.29, 0);
                yield return new Melanoma(45, 1435, 1, 1, 27, 1969, 3.22, 0);
                yield return new Melanoma(46, 1499, 2, 1, 73, 1973, 1.29, 0);
                yield return new Melanoma(47, 1506, 1, 1, 56, 1970, 4.51, 1);
                yield return new Melanoma(48, 1508, 2, 1, 63, 1973, 8.38, 1);
                yield return new Melanoma(49, 1510, 2, 0, 69, 1973, 1.94, 0);
                yield return new Melanoma(50, 1512, 2, 0, 77, 1973, 0.16, 0);
                yield return new Melanoma(51, 1516, 1, 1, 80, 1968, 2.58, 1);
                yield return new Melanoma(52, 1525, 3, 0, 76, 1970, 1.29, 1);
                yield return new Melanoma(53, 1542, 2, 0, 65, 1973, 0.16, 0);
                yield return new Melanoma(54, 1548, 1, 0, 61, 1972, 1.62, 0);
                yield return new Melanoma(55, 1557, 2, 0, 26, 1973, 1.29, 0);
                yield return new Melanoma(56, 1560, 1, 0, 57, 1973, 2.1, 0);
                yield return new Melanoma(57, 1563, 2, 0, 45, 1973, 0.32, 0);
                yield return new Melanoma(58, 1584, 1, 1, 31, 1970, 0.81, 0);
                yield return new Melanoma(59, 1605, 2, 0, 36, 1973, 1.13, 0);
                yield return new Melanoma(60, 1621, 1, 0, 46, 1972, 5.16, 1);
                yield return new Melanoma(61, 1627, 2, 0, 43, 1973, 1.62, 0);
                yield return new Melanoma(62, 1634, 2, 0, 68, 1973, 1.37, 0);
                yield return new Melanoma(63, 1641, 2, 1, 57, 1973, 0.24, 0);
                yield return new Melanoma(64, 1641, 2, 0, 57, 1973, 0.81, 0);
                yield return new Melanoma(65, 1648, 2, 0, 55, 1973, 1.29, 0);
                yield return new Melanoma(66, 1652, 2, 0, 58, 1973, 1.29, 0);
                yield return new Melanoma(67, 1654, 2, 1, 20, 1973, 0.97, 0);
                yield return new Melanoma(68, 1654, 2, 0, 67, 1973, 1.13, 0);
                yield return new Melanoma(69, 1667, 1, 0, 44, 1971, 5.8, 1);
                yield return new Melanoma(70, 1678, 2, 0, 59, 1973, 1.29, 0);
                yield return new Melanoma(71, 1685, 2, 0, 32, 1973, 0.48, 0);
                yield return new Melanoma(72, 1690, 1, 1, 83, 1971, 1.62, 0);
                yield return new Melanoma(73, 1710, 2, 0, 55, 1973, 2.26, 0);
                yield return new Melanoma(74, 1710, 2, 1, 15, 1973, 0.58, 0);
                yield return new Melanoma(75, 1726, 1, 0, 58, 1970, 0.97, 1);
                yield return new Melanoma(76, 1745, 2, 0, 47, 1973, 2.58, 1);
                yield return new Melanoma(77, 1762, 2, 0, 54, 1973, 0.81, 0);
                yield return new Melanoma(78, 1779, 2, 1, 55, 1973, 3.54, 1);
                yield return new Melanoma(79, 1787, 2, 1, 38, 1973, 0.97, 0);
                yield return new Melanoma(80, 1787, 2, 0, 41, 1973, 1.78, 1);
                yield return new Melanoma(81, 1793, 2, 0, 56, 1973, 1.94, 0);
                yield return new Melanoma(82, 1804, 2, 0, 48, 1973, 1.29, 0);
                yield return new Melanoma(83, 1812, 2, 1, 44, 1973, 3.22, 1);
                yield return new Melanoma(84, 1836, 2, 0, 70, 1972, 1.53, 0);
                yield return new Melanoma(85, 1839, 2, 0, 40, 1972, 1.29, 0);
                yield return new Melanoma(86, 1839, 2, 1, 53, 1972, 1.62, 1);
                yield return new Melanoma(87, 1854, 2, 0, 65, 1972, 1.62, 1);
                yield return new Melanoma(88, 1856, 2, 1, 54, 1972, 0.32, 0);
                yield return new Melanoma(89, 1860, 3, 1, 71, 1969, 4.84, 1);
                yield return new Melanoma(90, 1864, 2, 0, 49, 1972, 1.29, 0);
                yield return new Melanoma(91, 1899, 2, 0, 55, 1972, 0.97, 0);
                yield return new Melanoma(92, 1914, 2, 0, 69, 1972, 3.06, 0);
                yield return new Melanoma(93, 1919, 2, 1, 83, 1972, 3.54, 0);
                yield return new Melanoma(94, 1920, 2, 1, 60, 1972, 1.62, 1);
                yield return new Melanoma(95, 1927, 2, 1, 40, 1972, 2.58, 1);
                yield return new Melanoma(96, 1933, 1, 0, 77, 1972, 1.94, 0);
                yield return new Melanoma(97, 1942, 2, 0, 35, 1972, 0.81, 0);
                yield return new Melanoma(98, 1955, 2, 0, 46, 1972, 7.73, 1);
                yield return new Melanoma(99, 1956, 2, 0, 34, 1972, 0.97, 0);
                yield return new Melanoma(100, 1958, 2, 0, 69, 1972, 12.88, 0);
                yield return new Melanoma(101, 1963, 2, 0, 60, 1972, 2.58, 0);
                yield return new Melanoma(102, 1970, 2, 1, 84, 1972, 4.09, 1);
                yield return new Melanoma(103, 2005, 2, 0, 66, 1972, 0.64, 0);
                yield return new Melanoma(104, 2007, 2, 1, 56, 1972, 0.97, 0);
                yield return new Melanoma(105, 2011, 2, 0, 75, 1972, 3.22, 1);
                yield return new Melanoma(106, 2024, 2, 0, 36, 1972, 1.62, 0);
                yield return new Melanoma(107, 2028, 2, 1, 52, 1972, 3.87, 1);
                yield return new Melanoma(108, 2038, 2, 0, 58, 1972, 0.32, 1);
                yield return new Melanoma(109, 2056, 2, 0, 39, 1972, 0.32, 0);
                yield return new Melanoma(110, 2059, 2, 1, 68, 1972, 3.22, 1);
                yield return new Melanoma(111, 2061, 1, 1, 71, 1968, 2.26, 0);
                yield return new Melanoma(112, 2062, 1, 0, 52, 1965, 3.06, 0);
                yield return new Melanoma(113, 2075, 2, 1, 55, 1972, 2.58, 1);
                yield return new Melanoma(114, 2085, 3, 0, 66, 1970, 0.65, 0);
                yield return new Melanoma(115, 2102, 2, 1, 35, 1972, 1.13, 0);
                yield return new Melanoma(116, 2103, 1, 1, 44, 1966, 0.81, 0);
                yield return new Melanoma(117, 2104, 2, 0, 72, 1972, 0.97, 0);
                yield return new Melanoma(118, 2108, 1, 0, 58, 1969, 1.76, 1);
                yield return new Melanoma(119, 2112, 2, 0, 54, 1972, 1.94, 1);
                yield return new Melanoma(120, 2150, 2, 0, 33, 1972, 0.65, 0);
                yield return new Melanoma(121, 2156, 2, 0, 45, 1972, 0.97, 0);
                yield return new Melanoma(122, 2165, 2, 1, 62, 1972, 5.64, 0);
                yield return new Melanoma(123, 2209, 2, 0, 72, 1971, 9.66, 0);
                yield return new Melanoma(124, 2227, 2, 0, 51, 1971, 0.1, 0);
                yield return new Melanoma(125, 2227, 2, 1, 77, 1971, 5.48, 1);
                yield return new Melanoma(126, 2256, 1, 0, 43, 1971, 2.26, 1);
                yield return new Melanoma(127, 2264, 2, 0, 65, 1971, 4.83, 1);
                yield return new Melanoma(128, 2339, 2, 0, 63, 1971, 0.97, 0);
                yield return new Melanoma(129, 2361, 2, 1, 60, 1971, 0.97, 0);
                yield return new Melanoma(130, 2387, 2, 0, 50, 1971, 5.16, 1);
                yield return new Melanoma(131, 2388, 1, 1, 40, 1966, 0.81, 0);
                yield return new Melanoma(132, 2403, 2, 0, 67, 1971, 2.9, 1);
                yield return new Melanoma(133, 2426, 2, 0, 69, 1971, 3.87, 0);
                yield return new Melanoma(134, 2426, 2, 0, 74, 1971, 1.94, 1);
                yield return new Melanoma(135, 2431, 2, 0, 49, 1971, 0.16, 0);
                yield return new Melanoma(136, 2460, 2, 0, 47, 1971, 0.64, 0);
                yield return new Melanoma(137, 2467, 1, 0, 42, 1965, 2.26, 1);
                yield return new Melanoma(138, 2492, 2, 0, 54, 1971, 1.45, 0);
                yield return new Melanoma(139, 2493, 2, 1, 72, 1971, 4.82, 1);
                yield return new Melanoma(140, 2521, 2, 0, 45, 1971, 1.29, 1);
                yield return new Melanoma(141, 2542, 2, 1, 67, 1971, 7.89, 1);
                yield return new Melanoma(142, 2559, 2, 0, 48, 1970, 0.81, 1);
                yield return new Melanoma(143, 2565, 1, 1, 34, 1970, 3.54, 1);
                yield return new Melanoma(144, 2570, 2, 0, 44, 1970, 1.29, 0);
                yield return new Melanoma(145, 2660, 2, 0, 31, 1970, 0.64, 0);
                yield return new Melanoma(146, 2666, 2, 0, 42, 1970, 3.22, 1);
                yield return new Melanoma(147, 2676, 2, 0, 24, 1970, 1.45, 1);
                yield return new Melanoma(148, 2738, 2, 0, 58, 1970, 0.48, 0);
                yield return new Melanoma(149, 2782, 1, 1, 78, 1969, 1.94, 0);
                yield return new Melanoma(150, 2787, 2, 1, 62, 1970, 0.16, 0);
                yield return new Melanoma(151, 2984, 2, 1, 70, 1969, 0.16, 0);
                yield return new Melanoma(152, 3032, 2, 0, 35, 1969, 1.29, 0);
                yield return new Melanoma(153, 3040, 2, 0, 61, 1969, 1.94, 0);
                yield return new Melanoma(154, 3042, 1, 0, 54, 1967, 3.54, 1);
                yield return new Melanoma(155, 3067, 2, 0, 29, 1969, 0.81, 0);
                yield return new Melanoma(156, 3079, 2, 1, 64, 1969, 0.65, 0);
                yield return new Melanoma(157, 3101, 2, 1, 47, 1969, 7.09, 0);
                yield return new Melanoma(158, 3144, 2, 1, 62, 1969, 0.16, 0);
                yield return new Melanoma(159, 3152, 2, 0, 32, 1969, 1.62, 0);
                yield return new Melanoma(160, 3154, 3, 1, 49, 1969, 1.62, 0);
                yield return new Melanoma(161, 3180, 2, 0, 25, 1969, 1.29, 0);
                yield return new Melanoma(162, 3182, 3, 1, 49, 1966, 6.12, 0);
                yield return new Melanoma(163, 3185, 2, 0, 64, 1969, 0.48, 0);
                yield return new Melanoma(164, 3199, 2, 0, 36, 1969, 0.64, 0);
                yield return new Melanoma(165, 3228, 2, 0, 58, 1969, 3.22, 1);
                yield return new Melanoma(166, 3229, 2, 0, 37, 1969, 1.94, 0);
                yield return new Melanoma(167, 3278, 2, 1, 54, 1969, 2.58, 0);
                yield return new Melanoma(168, 3297, 2, 0, 61, 1968, 2.58, 1);
                yield return new Melanoma(169, 3328, 2, 1, 31, 1968, 0.81, 0);
                yield return new Melanoma(170, 3330, 2, 1, 61, 1968, 0.81, 1);
                yield return new Melanoma(171, 3338, 1, 0, 60, 1967, 3.22, 1);
                yield return new Melanoma(172, 3383, 2, 0, 43, 1968, 0.32, 0);
                yield return new Melanoma(173, 3384, 2, 0, 68, 1968, 3.22, 1);
                yield return new Melanoma(174, 3385, 2, 0, 4, 1968, 2.74, 0);
                yield return new Melanoma(175, 3388, 2, 1, 60, 1968, 4.84, 1);
                yield return new Melanoma(176, 3402, 2, 1, 50, 1968, 1.62, 0);
                yield return new Melanoma(177, 3441, 2, 0, 20, 1968, 0.65, 0);
                yield return new Melanoma(178, 3458, 3, 0, 54, 1967, 1.45, 0);
                yield return new Melanoma(179, 3459, 2, 0, 29, 1968, 0.65, 0);
                yield return new Melanoma(180, 3459, 2, 1, 56, 1968, 1.29, 1);
                yield return new Melanoma(181, 3476, 2, 0, 60, 1968, 1.62, 0);
                yield return new Melanoma(182, 3523, 2, 0, 46, 1968, 3.54, 0);
                yield return new Melanoma(183, 3667, 2, 0, 42, 1967, 3.22, 0);
                yield return new Melanoma(184, 3695, 2, 0, 34, 1967, 0.65, 0);
                yield return new Melanoma(185, 3695, 2, 0, 56, 1967, 1.03, 0);
                yield return new Melanoma(186, 3776, 2, 1, 12, 1967, 7.09, 1);
                yield return new Melanoma(187, 3776, 2, 0, 21, 1967, 1.29, 1);
                yield return new Melanoma(188, 3830, 2, 1, 46, 1967, 0.65, 0);
                yield return new Melanoma(189, 3856, 2, 0, 49, 1967, 1.78, 0);
                yield return new Melanoma(190, 3872, 2, 0, 35, 1967, 12.24, 1);
                yield return new Melanoma(191, 3909, 2, 1, 42, 1967, 8.06, 1);
                yield return new Melanoma(192, 3968, 2, 0, 47, 1967, 0.81, 0);
                yield return new Melanoma(193, 4001, 2, 0, 69, 1967, 2.1, 0);
                yield return new Melanoma(194, 4103, 2, 0, 52, 1966, 3.87, 0);
                yield return new Melanoma(195, 4119, 2, 1, 52, 1966, 0.65, 0);
                yield return new Melanoma(196, 4124, 2, 0, 30, 1966, 1.94, 1);
                yield return new Melanoma(197, 4207, 2, 1, 22, 1966, 0.65, 0);
                yield return new Melanoma(198, 4310, 2, 1, 55, 1966, 2.1, 0);
                yield return new Melanoma(199, 4390, 2, 0, 26, 1965, 1.94, 1);
                yield return new Melanoma(200, 4479, 2, 0, 19, 1965, 1.13, 1);
                yield return new Melanoma(201, 4492, 2, 1, 29, 1965, 7.06, 1);
                yield return new Melanoma(202, 4668, 2, 0, 40, 1965, 6.12, 0);
                yield return new Melanoma(203, 4688, 2, 0, 42, 1965, 0.48, 0);
                yield return new Melanoma(204, 4926, 2, 0, 50, 1964, 2.26, 0);
                yield return new Melanoma(205, 5565, 2, 0, 41, 1962, 2.9, 0);
            }
        }
    }
}
