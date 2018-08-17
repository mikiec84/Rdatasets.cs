// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Manufacturing Costs
    /// </summary>

    public class ManufCost
    {
        public readonly double cost;
        public readonly double sk;
        public readonly double sl;
        public readonly double se;
        public readonly double sm;
        public readonly double pk;
        public readonly double pl;
        public readonly double pe;
        public readonly double pm;

        public ManufCost(double cost, double sk, double sl, double se, double sm, double pk, double pl, double pe, double pm)
        {
            this.cost = cost;
            this.sk = sk;
            this.sl = sl;
            this.se = se;
            this.sm = sm;
            this.pk = pk;
            this.pl = pl;
            this.pe = pe;
            this.pm = pm;
        }

        public static IEnumerable<ManufCost> Data
        {
            get
            {
                yield return new ManufCost(182.373, 0.05107, 0.24727, 0.04253, 0.65913, 1, 1, 1, 1);
                yield return new ManufCost(183.161, 0.05817, 0.27716, 0.05127, 0.6134, 1.0027, 1.15457, 1.30258, 1.05525);
                yield return new ManufCost(186.533, 0.04602, 0.25911, 0.05075, 0.64411, 0.74371, 1.15584, 1.19663, 1.06625);
                yield return new ManufCost(221.71, 0.04991, 0.24794, 0.04606, 0.65609, 0.92497, 1.23535, 1.12442, 1.1243);
                yield return new ManufCost(255.945, 0.05039, 0.25487, 0.04482, 0.64992, 1.04877, 1.33784, 1.25179, 1.21694);
                yield return new ManufCost(264.699, 0.04916, 0.26655, 0.0446, 0.63969, 0.99744, 1.37949, 1.27919, 1.19961);
                yield return new ManufCost(291.16, 0.04728, 0.26832, 0.04369, 0.64071, 1.00653, 1.43458, 1.27505, 1.19044);
                yield return new ManufCost(274.457, 0.05635, 0.27167, 0.04787, 0.62411, 1.08757, 1.45362, 1.30356, 1.20612);
                yield return new ManufCost(308.908, 0.05258, 0.26465, 0.04517, 0.6376, 1.10315, 1.5112, 1.34277, 1.23835);
                yield return new ManufCost(328.286, 0.04604, 0.2688, 0.04576, 0.6394, 0.99606, 1.58186, 1.37154, 1.29336);
                yield return new ManufCost(338.633, 0.05033, 0.27184, 0.0482, 0.62962, 1.06321, 1.64641, 1.3801, 1.30703);
                yield return new ManufCost(323.318, 0.06015, 0.27283, 0.04836, 0.61886, 1.15619, 1.67389, 1.39338, 1.32699);
                yield return new ManufCost(358.435, 0.06185, 0.27303, 0.04563, 0.61948, 1.30758, 1.7343, 1.36756, 1.30774);
                yield return new ManufCost(366.251, 0.05788, 0.27738, 0.04585, 0.61889, 1.25413, 1.7828, 1.38025, 1.33946);
                yield return new ManufCost(366.162, 0.05903, 0.27839, 0.0464, 0.61617, 1.26328, 1.81977, 1.3763, 1.34319);
                yield return new ManufCost(390.668, 0.05578, 0.2828, 0.0453, 0.61613, 1.26525, 1.88531, 1.37689, 1.34745);
                yield return new ManufCost(412.188, 0.05601, 0.27968, 0.0447, 0.61962, 1.32294, 1.93379, 1.34737, 1.33143);
                yield return new ManufCost(433.768, 0.05452, 0.28343, 0.04392, 0.61814, 1.32798, 2.00998, 1.38969, 1.35197);
                yield return new ManufCost(474.969, 0.05467, 0.27996, 0.04114, 0.62423, 1.40659, 2.05539, 1.38635, 1.37542);
                yield return new ManufCost(521.291, 0.0546, 0.28363, 0.04014, 0.62163, 1.451, 2.13441, 1.40102, 1.41878);
                yield return new ManufCost(540.941, 0.05443, 0.28646, 0.04074, 0.61837, 1.38617, 2.20616, 1.39197, 1.42428);
                yield return new ManufCost(585.447, 0.05758, 0.28883, 0.03971, 0.61388, 1.49901, 2.33869, 1.43388, 1.43481);
                yield return new ManufCost(630.45, 0.0541, 0.29031, 0.03963, 0.61597, 1.44957, 2.46412, 1.46481, 1.53356);
                yield return new ManufCost(623.466, 0.05255, 0.29755, 0.04348, 0.60642, 1.32464, 2.60532, 1.45907, 1.54758);
                yield return new ManufCost(658.235, 0.04675, 0.28905, 0.04479, 0.6194, 1.20177, 2.76025, 1.64689, 1.54978);
            }
        }
    }
}
