// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Romano-British Pottery Data
    /// </summary>

    public class pottery
    {
        public readonly int κ;
        public readonly double Al2O3;
        public readonly double Fe2O3;
        public readonly double MgO;
        public readonly double CaO;
        public readonly double Na2O;
        public readonly double K2O;
        public readonly double TiO2;
        public readonly double MnO;
        public readonly double BaO;

        public pottery(int κ, double Al2O3, double Fe2O3, double MgO, double CaO, double Na2O, double K2O, double TiO2, double MnO, double BaO)
        {
            this.κ = κ;
            this.Al2O3 = Al2O3;
            this.Fe2O3 = Fe2O3;
            this.MgO = MgO;
            this.CaO = CaO;
            this.Na2O = Na2O;
            this.K2O = K2O;
            this.TiO2 = TiO2;
            this.MnO = MnO;
            this.BaO = BaO;
        }

        public static IEnumerable<pottery> Data
        {
            get
            {
                yield return new pottery(1, 18.8, 9.52, 2, 0.79, 0.4, 3.2, 1.01, 0.077, 0.015);
                yield return new pottery(2, 16.9, 7.33, 1.65, 0.84, 0.4, 3.05, 0.99, 0.067, 0.018);
                yield return new pottery(3, 18.2, 7.64, 1.82, 0.77, 0.4, 3.07, 0.98, 0.087, 0.014);
                yield return new pottery(4, 16.9, 7.29, 1.56, 0.76, 0.4, 3.05, 1, 0.063, 0.019);
                yield return new pottery(5, 17.8, 7.24, 1.83, 0.92, 0.43, 3.12, 0.93, 0.061, 0.019);
                yield return new pottery(6, 18.8, 7.45, 2.06, 0.87, 0.25, 3.26, 0.98, 0.072, 0.017);
                yield return new pottery(7, 16.5, 7.05, 1.81, 1.73, 0.33, 3.2, 0.95, 0.066, 0.019);
                yield return new pottery(8, 18, 7.42, 2.06, 1, 0.28, 3.37, 0.96, 0.072, 0.017);
                yield return new pottery(9, 15.8, 7.15, 1.62, 0.71, 0.38, 3.25, 0.93, 0.062, 0.017);
                yield return new pottery(10, 14.6, 6.87, 1.67, 0.76, 0.33, 3.06, 0.91, 0.055, 0.012);
                yield return new pottery(11, 13.7, 5.83, 1.5, 0.66, 0.13, 2.25, 0.75, 0.034, 0.012);
                yield return new pottery(12, 14.6, 6.76, 1.63, 1.48, 0.2, 3.02, 0.87, 0.055, 0.016);
                yield return new pottery(13, 14.8, 7.07, 1.62, 1.44, 0.24, 3.03, 0.86, 0.08, 0.016);
                yield return new pottery(14, 17.1, 7.79, 1.99, 0.83, 0.46, 3.13, 0.93, 0.09, 0.02);
                yield return new pottery(15, 16.8, 7.86, 1.86, 0.84, 0.46, 2.93, 0.94, 0.094, 0.02);
                yield return new pottery(16, 15.8, 7.65, 1.94, 0.81, 0.83, 3.33, 0.96, 0.112, 0.019);
                yield return new pottery(17, 18.6, 7.85, 2.33, 0.87, 0.38, 3.17, 0.98, 0.081, 0.018);
                yield return new pottery(18, 16.9, 7.87, 1.83, 1.31, 0.53, 3.09, 0.95, 0.092, 0.023);
                yield return new pottery(19, 18.9, 7.58, 2.05, 0.83, 0.13, 3.29, 0.98, 0.072, 0.015);
                yield return new pottery(20, 18, 7.5, 1.94, 0.69, 0.12, 3.14, 0.93, 0.035, 0.017);
                yield return new pottery(21, 17.8, 7.28, 1.92, 0.81, 0.18, 3.15, 0.9, 0.067, 0.017);
                yield return new pottery(22, 14.4, 7, 4.3, 0.15, 0.51, 4.25, 0.79, 0.16, 0.019);
                yield return new pottery(23, 13.8, 7.08, 3.43, 0.12, 0.17, 4.14, 0.77, 0.144, 0.02);
                yield return new pottery(24, 14.6, 7.09, 3.88, 0.13, 0.2, 4.36, 0.81, 0.124, 0.019);
                yield return new pottery(25, 11.5, 6.37, 5.64, 0.16, 0.14, 3.89, 0.69, 0.087, 0.009);
                yield return new pottery(26, 13.8, 7.06, 5.34, 0.2, 0.2, 4.31, 0.71, 0.101, 0.021);
                yield return new pottery(27, 10.9, 6.26, 3.47, 0.17, 0.22, 3.4, 0.66, 0.109, 0.01);
                yield return new pottery(28, 10.1, 4.26, 4.26, 0.2, 0.18, 3.32, 0.59, 0.149, 0.017);
                yield return new pottery(29, 11.6, 5.78, 5.91, 0.18, 0.16, 3.7, 0.65, 0.082, 0.015);
                yield return new pottery(30, 11.1, 5.49, 4.52, 0.29, 0.3, 4.03, 0.63, 0.08, 0.016);
                yield return new pottery(31, 13.4, 6.92, 7.23, 0.28, 0.2, 4.54, 0.69, 0.163, 0.017);
                yield return new pottery(32, 12.4, 6.13, 5.69, 0.22, 0.54, 4.65, 0.7, 0.159, 0.015);
                yield return new pottery(33, 13.1, 6.64, 5.51, 0.31, 0.24, 4.89, 0.72, 0.094, 0.017);
                yield return new pottery(34, 11.6, 5.39, 3.77, 0.29, 0.06, 4.51, 0.56, 0.11, 0.015);
                yield return new pottery(35, 11.8, 5.44, 3.94, 0.3, 0.04, 4.64, 0.59, 0.085, 0.013);
                yield return new pottery(36, 18.3, 1.28, 0.67, 0.03, 0.03, 1.96, 0.65, 0.001, 0.014);
                yield return new pottery(37, 15.8, 2.39, 0.63, 0.01, 0.04, 1.94, 1.29, 0.001, 0.014);
                yield return new pottery(38, 18, 1.5, 0.67, 0.01, 0.06, 2.11, 0.92, 0.001, 0.016);
                yield return new pottery(39, 18, 1.88, 0.68, 0.01, 0.04, 2, 1.11, 0.006, 0.022);
                yield return new pottery(40, 20.8, 1.51, 0.72, 0.07, 0.1, 2.37, 1.26, 0.002, 0.016);
                yield return new pottery(41, 17.7, 1.12, 0.56, 0.06, 0.06, 2.06, 0.79, 0.001, 0.013);
                yield return new pottery(42, 18.3, 1.14, 0.67, 0.06, 0.05, 2.11, 0.89, 0.006, 0.019);
                yield return new pottery(43, 16.7, 0.92, 0.53, 0.01, 0.05, 1.76, 0.91, 0.004, 0.013);
                yield return new pottery(44, 14.8, 2.74, 0.67, 0.03, 0.05, 2.15, 1.34, 0.003, 0.015);
                yield return new pottery(45, 19.1, 1.64, 0.6, 0.1, 0.03, 1.75, 1.04, 0.007, 0.018);
            }
        }
    }
}
