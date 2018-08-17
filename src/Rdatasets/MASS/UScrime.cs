// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Effect of Punishment Regimes on Crime Rates
    /// </summary>

    public class UScrime
    {
        public readonly int M;
        public readonly int So;
        public readonly int Ed;
        public readonly int Po1;
        public readonly int Po2;
        public readonly int LF;
        public readonly int M_F;
        public readonly int Pop;
        public readonly int NW;
        public readonly int U1;
        public readonly int U2;
        public readonly int GDP;
        public readonly int Ineq;
        public readonly double Prob;
        public readonly double Time;
        public readonly int y;

        public UScrime(int M, int So, int Ed, int Po1, int Po2, int LF, int M_F, int Pop, int NW, int U1, int U2, int GDP, int Ineq, double Prob, double Time, int y)
        {
            this.M = M;
            this.So = So;
            this.Ed = Ed;
            this.Po1 = Po1;
            this.Po2 = Po2;
            this.LF = LF;
            this.M_F = M_F;
            this.Pop = Pop;
            this.NW = NW;
            this.U1 = U1;
            this.U2 = U2;
            this.GDP = GDP;
            this.Ineq = Ineq;
            this.Prob = Prob;
            this.Time = Time;
            this.y = y;
        }

        public static IEnumerable<UScrime> Data
        {
            get
            {
                yield return new UScrime(151, 1, 91, 58, 56, 510, 950, 33, 301, 108, 41, 394, 261, 0.084602, 26.2011, 791);
                yield return new UScrime(143, 0, 113, 103, 95, 583, 1012, 13, 102, 96, 36, 557, 194, 0.029599, 25.2999, 1635);
                yield return new UScrime(142, 1, 89, 45, 44, 533, 969, 18, 219, 94, 33, 318, 250, 0.083401, 24.3006, 578);
                yield return new UScrime(136, 0, 121, 149, 141, 577, 994, 157, 80, 102, 39, 673, 167, 0.015801, 29.9012, 1969);
                yield return new UScrime(141, 0, 121, 109, 101, 591, 985, 18, 30, 91, 20, 578, 174, 0.041399, 21.2998, 1234);
                yield return new UScrime(121, 0, 110, 118, 115, 547, 964, 25, 44, 84, 29, 689, 126, 0.034201, 20.9995, 682);
                yield return new UScrime(127, 1, 111, 82, 79, 519, 982, 4, 139, 97, 38, 620, 168, 0.0421, 20.6993, 963);
                yield return new UScrime(131, 1, 109, 115, 109, 542, 969, 50, 179, 79, 35, 472, 206, 0.040099, 24.5988, 1555);
                yield return new UScrime(157, 1, 90, 65, 62, 553, 955, 39, 286, 81, 28, 421, 239, 0.071697, 29.4001, 856);
                yield return new UScrime(140, 0, 118, 71, 68, 632, 1029, 7, 15, 100, 24, 526, 174, 0.044498, 19.5994, 705);
                yield return new UScrime(124, 0, 105, 121, 116, 580, 966, 101, 106, 77, 35, 657, 170, 0.016201, 41.6, 1674);
                yield return new UScrime(134, 0, 108, 75, 71, 595, 972, 47, 59, 83, 31, 580, 172, 0.031201, 34.2984, 849);
                yield return new UScrime(128, 0, 113, 67, 60, 624, 972, 28, 10, 77, 25, 507, 206, 0.045302, 36.2993, 511);
                yield return new UScrime(135, 0, 117, 62, 61, 595, 986, 22, 46, 77, 27, 529, 190, 0.0532, 21.501, 664);
                yield return new UScrime(152, 1, 87, 57, 53, 530, 986, 30, 72, 92, 43, 405, 264, 0.0691, 22.7008, 798);
                yield return new UScrime(142, 1, 88, 81, 77, 497, 956, 33, 321, 116, 47, 427, 247, 0.052099, 26.0991, 946);
                yield return new UScrime(143, 0, 110, 66, 63, 537, 977, 10, 6, 114, 35, 487, 166, 0.076299, 19.1002, 539);
                yield return new UScrime(135, 1, 104, 123, 115, 537, 978, 31, 170, 89, 34, 631, 165, 0.119804, 18.1996, 929);
                yield return new UScrime(130, 0, 116, 128, 128, 536, 934, 51, 24, 78, 34, 627, 135, 0.019099, 24.9008, 750);
                yield return new UScrime(125, 0, 108, 113, 105, 567, 985, 78, 94, 130, 58, 626, 166, 0.034801, 26.401, 1225);
                yield return new UScrime(126, 0, 108, 74, 67, 602, 984, 34, 12, 102, 33, 557, 195, 0.0228, 37.5998, 742);
                yield return new UScrime(157, 1, 89, 47, 44, 512, 962, 22, 423, 97, 34, 288, 276, 0.089502, 37.0994, 439);
                yield return new UScrime(132, 0, 96, 87, 83, 564, 953, 43, 92, 83, 32, 513, 227, 0.0307, 25.1989, 1216);
                yield return new UScrime(131, 0, 116, 78, 73, 574, 1038, 7, 36, 142, 42, 540, 176, 0.041598, 17.6, 968);
                yield return new UScrime(130, 0, 116, 63, 57, 641, 984, 14, 26, 70, 21, 486, 196, 0.069197, 21.9003, 523);
                yield return new UScrime(131, 0, 121, 160, 143, 631, 1071, 3, 77, 102, 41, 674, 152, 0.041698, 22.1005, 1993);
                yield return new UScrime(135, 0, 109, 69, 71, 540, 965, 6, 4, 80, 22, 564, 139, 0.036099, 28.4999, 342);
                yield return new UScrime(152, 0, 112, 82, 76, 571, 1018, 10, 79, 103, 28, 537, 215, 0.038201, 25.8006, 1216);
                yield return new UScrime(119, 0, 107, 166, 157, 521, 938, 168, 89, 92, 36, 637, 154, 0.0234, 36.7009, 1043);
                yield return new UScrime(166, 1, 89, 58, 54, 521, 973, 46, 254, 72, 26, 396, 237, 0.075298, 28.3011, 696);
                yield return new UScrime(140, 0, 93, 55, 54, 535, 1045, 6, 20, 135, 40, 453, 200, 0.041999, 21.7998, 373);
                yield return new UScrime(125, 0, 109, 90, 81, 586, 964, 97, 82, 105, 43, 617, 163, 0.042698, 30.9014, 754);
                yield return new UScrime(147, 1, 104, 63, 64, 560, 972, 23, 95, 76, 24, 462, 233, 0.049499, 25.5005, 1072);
                yield return new UScrime(126, 0, 118, 97, 97, 542, 990, 18, 21, 102, 35, 589, 166, 0.040799, 21.6997, 923);
                yield return new UScrime(123, 0, 102, 97, 87, 526, 948, 113, 76, 124, 50, 572, 158, 0.0207, 37.4011, 653);
                yield return new UScrime(150, 0, 100, 109, 98, 531, 964, 9, 24, 87, 38, 559, 153, 0.0069, 44.0004, 1272);
                yield return new UScrime(177, 1, 87, 58, 56, 638, 974, 24, 349, 76, 28, 382, 254, 0.045198, 31.6995, 831);
                yield return new UScrime(133, 0, 104, 51, 47, 599, 1024, 7, 40, 99, 27, 425, 225, 0.053998, 16.6999, 566);
                yield return new UScrime(149, 1, 88, 61, 54, 515, 953, 36, 165, 86, 35, 395, 251, 0.047099, 27.3004, 826);
                yield return new UScrime(145, 1, 104, 82, 74, 560, 981, 96, 126, 88, 31, 488, 228, 0.038801, 29.3004, 1151);
                yield return new UScrime(148, 0, 122, 72, 66, 601, 998, 9, 19, 84, 20, 590, 144, 0.0251, 30.0001, 880);
                yield return new UScrime(141, 0, 109, 56, 54, 523, 968, 4, 2, 107, 37, 489, 170, 0.088904, 12.1996, 542);
                yield return new UScrime(162, 1, 99, 75, 70, 522, 996, 40, 208, 73, 27, 496, 224, 0.054902, 31.9989, 823);
                yield return new UScrime(136, 0, 121, 95, 96, 574, 1012, 29, 36, 111, 37, 622, 162, 0.0281, 30.0001, 1030);
                yield return new UScrime(139, 1, 88, 46, 41, 480, 968, 19, 49, 135, 53, 457, 249, 0.056202, 32.5996, 455);
                yield return new UScrime(126, 0, 104, 106, 97, 599, 989, 40, 24, 78, 25, 593, 171, 0.046598, 16.6999, 508);
                yield return new UScrime(130, 0, 121, 90, 91, 623, 1049, 3, 22, 113, 40, 588, 160, 0.052802, 16.0997, 849);
            }
        }
    }
}
