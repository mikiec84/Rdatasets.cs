// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Provision of University Teaching and Research
    /// </summary>

    public class University
    {
        public readonly int κ;
        public readonly int undstudents;
        public readonly int poststudents;
        public readonly double nassets;
        public readonly double acnumbers;
        public readonly double acrelnum;
        public readonly double clernum;
        public readonly double compop;
        public readonly double techn;
        public readonly int stfees;
        public readonly int acpay;
        public readonly int acrelpay;
        public readonly int secrpay;
        public readonly int admpay;
        public readonly double agresrk;
        public readonly int furneq;
        public readonly double landbuild;
        public readonly int resgr;

        public University(int κ, int undstudents, int poststudents, double nassets, double acnumbers, double acrelnum, double clernum, double compop, double techn, int stfees, int acpay, int acrelpay, int secrpay, int admpay, double agresrk, int furneq, double landbuild, int resgr)
        {
            this.κ = κ;
            this.undstudents = undstudents;
            this.poststudents = poststudents;
            this.nassets = nassets;
            this.acnumbers = acnumbers;
            this.acrelnum = acrelnum;
            this.clernum = clernum;
            this.compop = compop;
            this.techn = techn;
            this.stfees = stfees;
            this.acpay = acpay;
            this.acrelpay = acrelpay;
            this.secrpay = secrpay;
            this.admpay = admpay;
            this.agresrk = agresrk;
            this.furneq = furneq;
            this.landbuild = landbuild;
            this.resgr = resgr;
        }

        public static IEnumerable<University> Data
        {
            get
            {
                yield return new University(1, 17, 1190, 3669.71, 183, 50, 127, 1, 15, 2821, 4889, 0, 683, 954, 915, 143, 2674, 2176);
                yield return new University(2, 0, 392, 12156, 83, 62, 32, 4, 15, 4037, 993, 110, 457, 1001, 410, 392, 9063, 1502);
                yield return new University(3, 9752, 3975, 185203, 2030, 658, 845.5, 27.5, 633.5, 17296, 30705, 9273, 8667, 4705, 9147.09, 6229, 44888, 40746);
                yield return new University(4, 10035, 3376, 323100, 2008, 412, 800, 200, 440, 18800, 31840, 10478, 5650, 2592, 8962.76, 9400, 18307, 30300);
                yield return new University(5, 2556, 1569, 32154, 345.5, 81, 278, 7, 15, 9314, 10292, 0, 1645, 1931, 1518.4, 829, 16838, 2075);
                yield return new University(6, 5813, 1134, 41669, 897, 181, 405, 9.5, 156.5, 7388, 15636, 2530, 1852, 2126, 3732.425, 2094, 42089, 11352);
                yield return new University(7, 7041, 1973, 76671, 1642, 319, 425, 11, 408, 11461, 34946, 0, 2805, 4471, 6819.4, 3935, 36245, 33234);
                yield return new University(8, 3528, 912, 11829, 523, 120, 249.5, 8, 102, 5259, 10277, 2098, 1448, 1617, 2030.67, 1114, 3128, 4381);
                yield return new University(9, 4416, 2111, 71884, 1373, 315.3, 426, 21, 504, 12541, 30541, 0, 3313, 3739, 5308.3, 5444, 66311, 31435);
                yield return new University(10, 689, 148, 9092, 390, 35, 143.5, 6, 63.5, 1144, 5320, 1071, 689, 683, 1478, 728, 5929, 7246);
                yield return new University(11, 2607, 694, 24961.1, 382, 91, 242.5, 20.5, 86, 5211, 6989, 1135, 1312, 1031, 1416.83, 878, 17406, 3692);
                yield return new University(12, 5580, 1402, 50023, 1231, 287, 408, 8.5, 336, 8930, 20983, 4442, 2209, 2113, 4355.58, 3568, 35742, 14329);
                yield return new University(13, 3137, 945, 16561, 522, 97, 244, 5, 131, 4720, 8916, 1806, 1561, 1088, 1832.33, 1411, 18138, 5896);
                yield return new University(14, 6328, 1185, 76111, 1305, 172, 454, 6, 428, 8571, 22308, 6667, 2337, 2779, 4544.64, 2919, 62383, 17810);
                yield return new University(15, 85, 275, 3556.29, 267, 71, 79, 2, 78, 2524, 8266, 0, 580, 1086, 917.4, 739, 3475, 2506);
                yield return new University(16, 8827, 2015, 254399, 1873, 397, 789, 20, 544.5, 13782, 31237, 7801, 4475, 4245, 6425.685, 7506, 201563, 25207);
                yield return new University(17, 9763, 2259, 109606, 1865, 504, 783, 40, 560.5, 16259, 35253, 8147, 5233, 3852, 6389.3, 7532, 65580, 19728);
                yield return new University(18, 3189, 1176, 37927, 648, 249, 277, 19, 275, 7254, 13651, 3721, 791, 1819, 2180.75, 1683, 32519, 8620);
                yield return new University(19, 6339, 1570, 60915, 1143, 179, 439, 20, 353.5, 9441, 20326, 5818, 2399, 2569, 3760.56, 3229, 31454, 12193);
                yield return new University(20, 4812, 825, 39043.1, 472, 139, 214, 15, 154, 6686, 13038, 0, 1652, 2030, 1551.5, 2036, 32911, 5652);
                yield return new University(21, 6800, 1510, 83300, 1263, 234, 470.5, 11, 404, 10600, 22983, 5829, 3373, 2600, 4052, 3500, 65900, 13800);
                yield return new University(22, 9740, 1751, 117575, 1588, 248, 610, 24, 639.5, 14653, 29280, 10088, 4019, 3281, 5030.75, 5019, 47388, 23353);
                yield return new University(23, 7250, 1720, 40203, 1149, 210, 515.5, 16, 339.5, 10942, 22477, 6080, 2687, 3371, 3612.67, 2816, 26098, 12019);
                yield return new University(24, 3526, 1019, 16230, 611, 130, 324, 5, 161.5, 6279, 10551, 2476, 2645, 1619, 1863.54, 1485, 19858, 7426);
                yield return new University(25, 7836, 1847, 406564, 1524, 285, 625, 12, 558, 15332, 25474, 7238, 2730, 3543, 4595.5, 3489, 362000, 17039);
                yield return new University(26, 4348, 907, 44891, 632, 141, 268.5, 9.5, 183, 6411, 11422, 2398, 1994, 1051, 1899.3, 2518, 31883, 5926);
                yield return new University(27, 6871, 1587, 90924, 1253, 274, 538, 15, 541.5, 10042, 25166, 7117, 2840, 3361, 3747.53, 3549, 65010, 15132);
                yield return new University(28, 4466, 1030, 56795, 614, 119, 251.5, 10, 159.5, 5851, 12386, 2491, 1705, 1411, 1835.36, 1335, 26227, 3614);
                yield return new University(29, 0, 325, 2036.751, 48, 24, 17, 3, 12, 3747, 806, 202, 261, 250, 142.5, 89, 5555, 665);
                yield return new University(30, 816, 26, 17616.4, 342, 32, 98, 1, 192, 797, 5180, 0, 386, 635, 1014, 1084, 13523, 5841);
                yield return new University(31, 4015, 972, 27888, 610, 131, 276, 7, 111.5, 5431, 11953, 1737, 1435, 1502, 1790.17, 1685, 25978, 4562);
                yield return new University(32, 3035, 811, 26308, 572, 173, 285.5, 5, 185.5, 4942, 9921, 2669, 1188, 1308, 1646, 1742, 25008, 8793);
                yield return new University(33, 370, 41, 12988.6, 265, 43, 85, 1, 106, 645, 5247, 0, 562, 614, 755, 491, 9890, 7241);
                yield return new University(34, 3437, 388, 36866.95, 433, 101, 159.5, 9, 115.5, 4496, 8678, 1679, 1204, 1299, 1231.61, 1189, 16905, 3522);
                yield return new University(35, 4523, 1425, 56795, 834, 217, 351.5, 10, 275.5, 8870, 15695, 3582, 1931, 1861, 2371.41, 2765, 37239, 8852);
                yield return new University(36, 8729, 2097, 123429, 1508, 403, 682, 24.5, 509.5, 12172, 29212, 8093, 2781, 3439, 4224.12, 4929, 90990, 13553);
                yield return new University(37, 3392, 816, 23348, 524, 136, 257, 14, 148, 5410, 9682, 2395, 1675, 1196, 1450.5, 4143, 22625, 5405);
                yield return new University(38, 5053, 913, 17150, 795, 185, 295.5, 10, 292.5, 6925, 14871, 3771, 1846, 2001, 2195.005, 1788, 6444, 6843);
                yield return new University(39, 4036, 1232, 35574.2, 770, 143, 336, 6, 229, 6426, 12165, 3289, 1590, 1488, 2090.045, 2306, 30886, 8666);
                yield return new University(40, 3835, 692, 23677, 532, 109, 203.5, 7, 168, 5158, 10189, 2256, 1296, 1062, 1436.93, 1064, 22935, 4269);
                yield return new University(41, 3821, 672, 20391, 523, 132, 256.5, 9, 75.5, 5817, 9737, 1357, 1317, 1893, 1410.74, 1230, 17361, 4740);
                yield return new University(42, 6968, 1781, 66008, 1023, 193, 391.5, 13, 316.5, 11118, 18589, 4311, 2344, 2599, 2748.89, 2947, 70115, 12327);
                yield return new University(43, 3791, 917, 17977, 527, 152, 315, 19.5, 189.5, 5082, 10905, 2643, 1694, 1575, 1411.5, 1602, 17056, 4305);
                yield return new University(44, 5917, 1418, 60717.2, 932, 172, 326, 7, 365, 8702, 23908, 0, 2502, 2854, 2494, 2942, 52084, 15830);
                yield return new University(45, 3199, 508, 26627, 545, 135, 220, 4.5, 188, 3906, 9945, 2478, 1086, 1350, 1455.92, 1787, 20540, 8092);
                yield return new University(46, 4391, 1011, 38985.6, 775, 155, 346, 8.5, 183, 7411, 13889, 3359, 1671, 1215, 2049.375, 3375, 14738, 8153);
                yield return new University(47, 3123, 542, 19215, 336, 131, 290, 8, 116.5, 3145, 6965, 1865, 966, 1411, 884, 1519, 17260, 3148);
                yield return new University(48, 6569, 2077, 53997, 907, 169, 223.5, 8.5, 176, 11635, 18077, 4004, 2283, 1745, 2386.25, 4028, 51822, 7873);
                yield return new University(49, 4364, 805, 32715, 486, 116, 260.5, 6, 134.5, 5520, 10448, 1993, 1491, 1602, 1268.09, 1260, 26157, 2702);
                yield return new University(50, 2798, 663, 32367.2, 424, 157, 154, 6, 147.5, 4538, 8235, 1783, 647, 1493, 1012.42, 2299, 40679.9, 7885);
                yield return new University(51, 2410, 699, 25560, 406, 62, 139, 5, 126.5, 3716, 7639, 1912, 983, 900, 956.25, 800, 21733, 4431);
                yield return new University(52, 6761, 1325, 133140, 966, 271, 321.5, 6, 268.5, 7437, 18631, 3923, 2836, 2352, 2264.49, 4262, 113119, 7095);
                yield return new University(53, 2656, 700, 12094.5, 364, 82, 191, 3.5, 76.5, 4002, 7051, 1101, 841, 1068, 851.68, 716, 13101.3, 2705);
                yield return new University(54, 3666, 320, 28915, 309.5, 69, 156, 2, 127, 2566, 9163, 0, 988, 1093, 713, 1469, 24480, 2115);
                yield return new University(55, 2745, 613, 28662, 373, 85, 161, 6, 101, 3502, 7621, 1512, 871, 894, 850.04, 1163, 17351, 2972);
                yield return new University(56, 2628, 840, 18072, 380, 106, 199, 9, 119, 4311, 7788, 2165, 3575, 1228, 853.5, 1488, 13706, 4998);
                yield return new University(57, 3496, 644, 35035, 443, 264, 286, 7, 112, 4714, 10455, 2239, 1130, 1429, 959.25, 2343, 29382, 3556);
                yield return new University(58, 2257, 1110, 10272, 387, 92, 227.5, 9, 109, 9049, 8732, 2222, 1090, 1288, 787.83, 1174, 2583, 3046);
                yield return new University(59, 772, 42, 7160.82, 72, 11, 29, 1, 10, 520, 1609, 112, 189, 221, 139, 142, 5534, 121);
                yield return new University(60, 2597, 598, 12167.75, 341, 69, 147, 7, 99, 4112, 6625, 1298, 843, 990, 642.295, 1436, 14137, 1974);
                yield return new University(61, 8834, 1576, 4369.8, 910, 236, 365, 20, 205, 7799, 20371, 3311, 2016, 2938, 1528.5, 2763, 89073, 1820);
                yield return new University(62, 768, 41, 27552.823, 265.5, 40, 84, 0, 198, 615, 6035, 0, 636, 612, 860.5, 424, 24364, 6225);
            }
        }
    }
}
