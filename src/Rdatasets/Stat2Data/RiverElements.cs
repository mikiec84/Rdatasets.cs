// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// RiverElements
    /// </summary>

    public class RiverElements
    {
        public readonly int κ;
        public readonly string River;
        public readonly int Site;
        public readonly int Al;
        public readonly double Ba;
        public readonly int Br;
        public readonly int Ca;
        public readonly double Ce;
        public readonly double Cu;
        public readonly double Dy;
        public readonly double Er;
        public readonly int Fe;
        public readonly double Gd;
        public readonly double? Ho;
        public readonly int K;
        public readonly double La;
        public readonly double Li;
        public readonly int Mg;
        public readonly double Mn;
        public readonly double Nd;
        public readonly double Pr;
        public readonly double Rb;
        public readonly int Si;
        public readonly double Sr;
        public readonly double Y;
        public readonly double Yb;
        public readonly double Zn;
        public readonly double Zr;

        public RiverElements(int κ, string River, int Site, int Al, double Ba, int Br, int Ca, double Ce, double Cu, double Dy, double Er, int Fe, double Gd, double? Ho, int K, double La, double Li, int Mg, double Mn, double Nd, double Pr, double Rb, int Si, double Sr, double Y, double Yb, double Zn, double Zr)
        {
            this.κ = κ;
            this.River = River;
            this.Site = Site;
            this.Al = Al;
            this.Ba = Ba;
            this.Br = Br;
            this.Ca = Ca;
            this.Ce = Ce;
            this.Cu = Cu;
            this.Dy = Dy;
            this.Er = Er;
            this.Fe = Fe;
            this.Gd = Gd;
            this.Ho = Ho;
            this.K = K;
            this.La = La;
            this.Li = Li;
            this.Mg = Mg;
            this.Mn = Mn;
            this.Nd = Nd;
            this.Pr = Pr;
            this.Rb = Rb;
            this.Si = Si;
            this.Sr = Sr;
            this.Y = Y;
            this.Yb = Yb;
            this.Zn = Zn;
            this.Zr = Zr;
        }

        public static IEnumerable<RiverElements> Data
        {
            get
            {
                yield return new RiverElements(1, "Grasse", 1, 231, 13.2, 8, 3602, 0.92, 0.3, 0.14, 0.1, 944, 0.18, 0.04, 230, 0.55, 0.6, 828, 2.18, 0.76, 0.18, 0.58, 3482, 19.35, 1.15, 0.1, 10, 0.1);
                yield return new RiverElements(2, "Grasse", 2, 166, 13.82, 6, 6432, 0.93, 0.5, 0.16, 0.11, 525, 0.19, 0.04, 357, 0.78, 0.6, 1813, 2.34, 0.93, 0.22, 0.94, 3230, 24.8, 1.24, 0.09, 4.1, 0.08);
                yield return new RiverElements(3, "Grasse", 3, 83, 13.39, 10, 10707, 0.52, 1.3, 0.1, 0.07, 327, 0.14, 0.02, 520, 0.41, 0.7, 3421, 1.4, 0.56, 0.13, 1.05, 3343, 41.88, 0.72, 0.07, 2.1, 0.09);
                yield return new RiverElements(4, "Oswegatchie", 1, 373, 11.66, 8, 2262, 1.76, 0.5, 0.21, 0.16, 860, 0.23, 0.05, 325, 1.12, 0.6, 477, 16.69, 1.37, 0.32, 0.8, 2937, 11.21, 1.71, 0.15, 10, 0.11);
                yield return new RiverElements(5, "Oswegatchie", 2, 71, 13.77, 29, 7862, 0.35, 1, 0.07, 0.05, 229, 0.07, 0.02, 482, 0.36, 0.7, 1815, 1.33, 0.4, 0.1, 1.1, 2636, 34.35, 0.57, 0.04, 6.3, 0.05);
                yield return new RiverElements(6, "Oswegatchie", 3, 25, 18.35, 33, 13815, 0.15, 0.9, 0.04, 0.03, 130, 0.06, 0.01, 848, 0.19, 0.7, 3782, 0.44, 0.21, 0.05, 1.31, 3202, 50.15, 0.3, 0.03, 4, 0.05);
                yield return new RiverElements(7, "Raquette", 1, 118, 7.94, 5, 2970, 0.25, 0.5, 0.03, 0.02, 108, 0.04, 0.01, 365, 0.12, 0.5, 708, 0.62, 0.17, 0.04, 1.06, 2213, 16, 0.18, 0.01, 4.4, 0.05);
                yield return new RiverElements(8, "Raquette", 2, 27, 10.28, 7, 4919, 0.05, 0.4, 0.02, 0.02, 36, 0.03, 0.01, 404, 0.06, 0.5, 1342, 0.55, 0.07, 0.02, 1.04, 2322, 21.39, 0.15, 0.02, 2.1, 0.03);
                yield return new RiverElements(9, "Raquette", 3, 13, 11.73, 11, 8311, 0.03, 0.5, 0.01, 0.01, 30, 0.01, null, 605, 0.03, 0.6, 2598, 0.33, 0.03, 0.01, 1.13, 2333, 35.4, 0.07, 0.01, 9.9, 0.02);
                yield return new RiverElements(10, "St. Regis", 1, 258, 11.89, 6, 3792, 0.89, 0.5, 0.14, 0.1, 751, 0.14, 0.03, 210, 0.53, 0.6, 1056, 2.17, 0.78, 0.17, 0.54, 3758, 17.58, 0.99, 0.1, 8, 0.1);
                yield return new RiverElements(11, "St. Regis", 2, 175, 11.03, 6, 5169, 0.62, 0.4, 0.12, 0.07, 568, 0.14, 0.02, 280, 0.43, 0.6, 1530, 2.42, 0.64, 0.14, 0.67, 3519, 18.2, 0.82, 0.07, 5.1, 0.09);
                yield return new RiverElements(12, "St. Regis", 3, 116, 13.95, 8, 7204, 0.41, 0.4, 0.08, 0.06, 350, 0.11, 0.02, 358, 0.28, 0.6, 2221, 1.25, 0.4, 0.09, 0.82, 3273, 24.09, 0.57, 0.06, 2.9, 0.08);
            }
        }
    }
}
