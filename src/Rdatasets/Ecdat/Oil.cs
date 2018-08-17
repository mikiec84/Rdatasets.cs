// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Oil Investment
    /// </summary>

    public class Oil
    {
        public readonly int dur;
        public readonly int size;
        public readonly int waterd;
        public readonly int gasres;
        public readonly double @operator;
        public readonly double p;
        public readonly double vardp;
        public readonly double p97;
        public readonly double varp97;
        public readonly double p98;
        public readonly double varp98;

        public Oil(int dur, int size, int waterd, int gasres, double @operator, double p, double vardp, double p97, double varp97, double p98, double varp98)
        {
            this.dur = dur;
            this.size = size;
            this.waterd = waterd;
            this.gasres = gasres;
            this.@operator = @operator;
            this.p = p;
            this.vardp = vardp;
            this.p97 = p97;
            this.varp97 = varp97;
            this.p98 = p98;
            this.varp98 = varp98;
        }

        public static IEnumerable<Oil> Data
        {
            get
            {
                yield return new Oil(86, 235, 126, 1140, 2576, 2.1834, 1.87, 2.048, 3.298, 2.2091, 3.905);
                yield return new Oil(227, 105, 91, 0, 16000, 1.3894, 2.4, 2.0047, 4.622, 2.0542, 4.818);
                yield return new Oil(17, 70, 76, 0, 584, 0.9321, 0.007, 0.9076, 0.178, 0.9056, 0.179);
                yield return new Oil(12, 96, 85, 0, 16175, 0.9893, 0.007, 0.8993, 0.15, 0.8939, 0.155);
                yield return new Oil(99, 70, 140, 0, 2445, 2.2432, 1.9576, 2.0662, 3.258, 2.2089, 3.833);
                yield return new Oil(23, 148, 145, 0, 17928, 2.6052, 1.0992, 1.7762, 2.763, 1.9763, 3.042);
                yield return new Oil(10, 800, 115, 1100, 16175, 0.921, 0.007, 0.9091, 0.179, 0.9077, 0.18);
                yield return new Oil(30, 275, 112, 90, 1, 2.6391, 1.2495, 1.9029, 2.787, 2.0984, 3.122);
                yield return new Oil(102, 140, 112, 700, 1, 2.2432, 1.9576, 2.0662, 3.258, 2.2089, 3.833);
                yield return new Oil(144, 60, 112, 50, 1, 1.1616, 2.3976, 1.9862, 4.721, 2.0276, 4.914);
                yield return new Oil(13, 1815, 140, 2500, 16175, 0.9662, 0.007, 0.9043, 0.172, 0.9009, 0.174);
                yield return new Oil(43, 95, 119, 0, 17928, 2.6052, 1.113, 1.7762, 2.781, 1.9763, 3.054);
                yield return new Oil(27, 4, 143, 30, 3173, 1.3894, 2.4042, 2.0047, 4.621, 2.0542, 4.818);
                yield return new Oil(15, 575, 110, 0, 3173, 2.6808, 1.2545, 1.2551, 2.401, 1.3565, 2.474);
                yield return new Oil(54, 150, 80, 40, 17928, 2.1834, 1.8701, 2.048, 3.28, 2.2091, 3.892);
                yield return new Oil(20, 220, 149, 20, 16175, 3.0359, 1.2948, 0.9989, 1.447, 1.0274, 1.45);
                yield return new Oil(56, 370, 149, 40, 16175, 2.4566, 1.0648, 1.8227, 2.709, 2.0144, 2.988);
                yield return new Oil(164, 8, 117, 0, 584, 1.0832, 2.3764, 1.9381, 4.888, 1.9605, 5.081);
                yield return new Oil(61, 13, 104, 0, 17928, 2.42, 1.8978, 2.1, 3.255, 2.2319, 3.765);
                yield return new Oil(144, 20, 163, 0, 17928, 2.4493, 1.916, 2.0892, 3.25, 2.2229, 3.779);
                yield return new Oil(146, 56, 170, 0, 17928, 1.1616, 2.3947, 1.9862, 4.721, 2.0276, 4.914);
                yield return new Oil(33, 18, 80, 0, 584, 2.2432, 1.9576, 2.0662, 3.2568, 2.2089, 3.833);
                yield return new Oil(10, 350, 151, 0, 16175, 3.0359, 1.2948, 0.9989, 1.447, 1.0274, 1.45);
                yield return new Oil(113, 85, 148, 0, 16175, 2.4745, 1.8518, 2.1483, 3.302, 2.2756, 3.736);
                yield return new Oil(132, 43, 154, 0, 86.5, 1.2839, 2.3451, 1.8843, 4.975, 1.8873, 5.169);
                yield return new Oil(14, 2500, 128, 0, 17928, 0.9442, 0.007, 0.8979, 0.15, 0.8918, 0.155);
                yield return new Oil(31, 430, 82, 70, 16175, 2.7272, 1.1105, 1.7468, 2.763, 1.945, 3.042);
                yield return new Oil(128, 130, 91, 480, 16175, 1.288, 2.3646, 1.8524, 5.037, 1.8448, 5.238);
                yield return new Oil(63, 18, 145, 0, 2445, 1.3894, 2.4042, 2.0047, 4.622, 2.0542, 4.818);
                yield return new Oil(8, 100, 145, 0, 1, 2.9407, 1.3173, 1.06, 1.827, 1.1077, 1.84);
                yield return new Oil(91, 85, 128, 0, 10267, 2.2432, 1.9576, 2.0662, 3.258, 2.2089, 3.833);
                yield return new Oil(80, 200, 147, 0, 16000, 2.5645, 1.3467, 1.9544, 3.045, 2.1514, 3.443);
                yield return new Oil(51, 140, 144, 12, 16000, 2.703, 1.0648, 1.8418, 2.713, 2.0321, 3.006);
                yield return new Oil(20, 6, 80, 0, 584, 2.42, 1.8978, 2.1, 3.255, 2.2319, 3.765);
                yield return new Oil(132, 105, 137, 40, 1, 1.7136, 1.838, 2.1581, 3.302, 2.2835, 3.736);
                yield return new Oil(72, 65, 85, 20, 16175, 1.5469, 2.4247, 2.0189, 4.474, 2.0753, 4.681);
                yield return new Oil(13, 10, 149, 0, 16176, 1.288, 2.3646, 1.8524, 5.037, 1.8448, 5.238);
                yield return new Oil(53, 710, 186, 305, 17928, 2.5032, 1.0897, 1.8011, 2.727, 2.0015, 3.007);
                yield return new Oil(59, 208, 96, 0, 16000, 2.8244, 1.113, 1.7134, 2.795, 1.9084, 3.058);
                yield return new Oil(67, 300, 108, 570, 17928, 0.9739, 2.3601, 1.9124, 4.888, 1.9254, 5.081);
                yield return new Oil(16, 6, 97, 0, 16000, 1.288, 2.3646, 1.8524, 5.037, 1.8448, 5.238);
                yield return new Oil(28, 110, 91, 0, 16000, 3.3665, 0.1008, 0.9257, 1.447, 0.9299, 1.45);
                yield return new Oil(3, 1145, 135, 15, 16032, 3.0359, 1.2948, 0.9989, 1.827, 1.0274, 1.84);
                yield return new Oil(12, 340, 156, 55, 16000, 2.9697, 1.1997, 1.4461, 2.679, 1.5923, 2.829);
                yield return new Oil(1, 45, 111, 0, 16176, 1.0566, 2.1566, 2.1447, 3.494, 2.2607, 3.857);
                yield return new Oil(177, 60, 158, 0, 16175, 0.9739, 2.3601, 1.9124, 4.888, 1.9254, 5.081);
                yield return new Oil(135, 21, 135, 14, 10267, 1.0566, 2.1566, 2.1447, 3.494, 2.2607, 3.857);
                yield return new Oil(3, 1000, 145, 120, 3173, 0.9346, 0.007, 0.9084, 0.179, 0.9066, 0.18);
                yield return new Oil(122, 100, 117, 0, 3173, 2.5421, 1.8673, 2.1361, 3.302, 2.2645, 3.736);
                yield return new Oil(7, 3030, 145, 2000, 17928, 2.9407, 1.3173, 1.06, 2.072, 1.1077, 2.099);
                yield return new Oil(32, 114, 145, 58, 16000, 3.092, 1.1408, 1.6291, 2.788, 1.8108, 3.017);
                yield return new Oil(117, 175, 167, 0, 16032, 2.5243, 1.8803, 2.1096, 3.263, 2.2394, 3.754);
                yield return new Oil(24, 457, 162, 7, 17928, 2.9407, 1.3173, 1.06, 1.827, 1.1077, 1.84);
            }
        }
    }
}
