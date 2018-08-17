// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Soil Compositions of Physical and Chemical Characteristics
    /// </summary>

    public class Soils
    {
        public readonly int Group;
        public readonly string Contour;
        public readonly string Depth;
        public readonly string Gp;
        public readonly int Block;
        public readonly double pH;
        public readonly double N;
        public readonly double Dens;
        public readonly int P;
        public readonly double Ca;
        public readonly double Mg;
        public readonly double K;
        public readonly double Na;
        public readonly double Conduc;

        public Soils(int Group, string Contour, string Depth, string Gp, int Block, double pH, double N, double Dens, int P, double Ca, double Mg, double K, double Na, double Conduc)
        {
            this.Group = Group;
            this.Contour = Contour;
            this.Depth = Depth;
            this.Gp = Gp;
            this.Block = Block;
            this.pH = pH;
            this.N = N;
            this.Dens = Dens;
            this.P = P;
            this.Ca = Ca;
            this.Mg = Mg;
            this.K = K;
            this.Na = Na;
            this.Conduc = Conduc;
        }

        public static IEnumerable<Soils> Data
        {
            get
            {
                yield return new Soils(1, "Top", "0-10", "T0", 1, 5.4, 0.188, 0.92, 215, 16.35, 7.65, 0.72, 1.14, 1.09);
                yield return new Soils(1, "Top", "0-10", "T0", 2, 5.65, 0.165, 1.04, 208, 12.25, 5.15, 0.71, 0.94, 1.35);
                yield return new Soils(1, "Top", "0-10", "T0", 3, 5.14, 0.26, 0.95, 300, 13.02, 5.68, 0.68, 0.6, 1.41);
                yield return new Soils(1, "Top", "0-10", "T0", 4, 5.14, 0.169, 1.1, 248, 11.92, 7.88, 1.09, 1.01, 1.64);
                yield return new Soils(2, "Top", "10-30", "T1", 1, 5.14, 0.164, 1.12, 174, 14.17, 8.12, 0.7, 2.17, 1.85);
                yield return new Soils(2, "Top", "10-30", "T1", 2, 5.1, 0.094, 1.22, 129, 8.55, 6.92, 0.81, 2.67, 3.18);
                yield return new Soils(2, "Top", "10-30", "T1", 3, 4.7, 0.1, 1.52, 117, 8.74, 8.16, 0.39, 3.32, 4.16);
                yield return new Soils(2, "Top", "10-30", "T1", 4, 4.46, 0.112, 1.47, 170, 9.49, 9.16, 0.7, 3.76, 5.14);
                yield return new Soils(3, "Top", "30-60", "T3", 1, 4.37, 0.112, 1.07, 121, 8.85, 10.35, 0.74, 5.74, 5.73);
                yield return new Soils(3, "Top", "30-60", "T3", 2, 4.39, 0.058, 1.54, 115, 4.73, 6.91, 0.77, 5.85, 6.45);
                yield return new Soils(3, "Top", "30-60", "T3", 3, 4.17, 0.078, 1.26, 112, 6.29, 7.95, 0.26, 5.3, 8.37);
                yield return new Soils(3, "Top", "30-60", "T3", 4, 3.89, 0.07, 1.42, 117, 6.61, 9.76, 0.41, 8.3, 9.21);
                yield return new Soils(4, "Top", "60-90", "T6", 1, 3.88, 0.077, 1.25, 127, 6.41, 10.96, 0.56, 9.67, 10.64);
                yield return new Soils(4, "Top", "60-90", "T6", 2, 4.07, 0.046, 1.54, 91, 3.82, 6.61, 0.5, 7.67, 10.07);
                yield return new Soils(4, "Top", "60-90", "T6", 3, 3.88, 0.055, 1.53, 91, 4.98, 8, 0.23, 8.78, 11.26);
                yield return new Soils(4, "Top", "60-90", "T6", 4, 3.74, 0.053, 1.4, 79, 5.86, 10.14, 0.41, 11.04, 12.15);
                yield return new Soils(5, "Slope", "0-10", "S0", 1, 5.11, 0.247, 0.94, 261, 13.25, 7.55, 0.61, 1.86, 2.61);
                yield return new Soils(5, "Slope", "0-10", "S0", 2, 5.46, 0.298, 0.96, 300, 12.3, 7.5, 0.68, 2, 1.98);
                yield return new Soils(5, "Slope", "0-10", "S0", 3, 5.61, 0.145, 1.1, 242, 9.66, 6.76, 0.63, 1.01, 0.76);
                yield return new Soils(5, "Slope", "0-10", "S0", 4, 5.85, 0.186, 1.2, 229, 13.78, 7.12, 0.62, 3.09, 2.85);
                yield return new Soils(6, "Slope", "10-30", "S1", 1, 4.57, 0.102, 1.37, 156, 8.58, 9.92, 0.63, 3.67, 3.24);
                yield return new Soils(6, "Slope", "10-30", "S1", 2, 5.11, 0.097, 1.3, 139, 8.58, 8.69, 0.42, 4.7, 4.63);
                yield return new Soils(6, "Slope", "10-30", "S1", 3, 4.78, 0.122, 1.3, 214, 8.22, 7.75, 0.32, 3.07, 3.67);
                yield return new Soils(6, "Slope", "10-30", "S1", 4, 6.67, 0.083, 1.42, 132, 12.68, 9.56, 0.55, 8.3, 8.1);
                yield return new Soils(7, "Slope", "30-60", "S3", 1, 3.96, 0.059, 1.53, 98, 4.8, 10, 0.36, 6.52, 7.72);
                yield return new Soils(7, "Slope", "30-60", "S3", 2, 4, 0.05, 1.5, 115, 5.06, 8.91, 0.28, 7.91, 9.78);
                yield return new Soils(7, "Slope", "30-60", "S3", 3, 4.12, 0.086, 1.55, 148, 6.16, 7.58, 0.16, 6.39, 9.07);
                yield return new Soils(7, "Slope", "30-60", "S3", 4, 4.99, 0.048, 1.46, 97, 7.49, 9.38, 0.4, 9.7, 9.13);
                yield return new Soils(8, "Slope", "60-90", "S6", 1, 3.8, 0.049, 1.48, 108, 3.82, 8.8, 0.24, 9.57, 11.57);
                yield return new Soils(8, "Slope", "60-90", "S6", 2, 3.96, 0.036, 1.28, 103, 4.78, 7.29, 0.24, 9.67, 11.42);
                yield return new Soils(8, "Slope", "60-90", "S6", 3, 3.93, 0.048, 1.42, 109, 4.93, 7.47, 0.14, 9.65, 13.32);
                yield return new Soils(8, "Slope", "60-90", "S6", 4, 4.02, 0.039, 1.51, 100, 5.66, 8.84, 0.37, 10.54, 11.57);
                yield return new Soils(9, "Depression", "0-10", "D0", 1, 5.24, 0.194, 1, 445, 12.27, 6.27, 0.72, 1.02, 0.75);
                yield return new Soils(9, "Depression", "0-10", "D0", 2, 5.2, 0.256, 0.78, 380, 11.39, 7.55, 0.78, 1.63, 2.2);
                yield return new Soils(9, "Depression", "0-10", "D0", 3, 5.3, 0.136, 1, 259, 9.96, 8.08, 0.45, 1.97, 2.27);
                yield return new Soils(9, "Depression", "0-10", "D0", 4, 5.67, 0.127, 1.13, 248, 9.12, 7.04, 0.55, 1.43, 0.67);
                yield return new Soils(10, "Depression", "10-30", "D1", 1, 4.46, 0.087, 1.24, 276, 7.24, 9.4, 0.43, 4.17, 5.08);
                yield return new Soils(10, "Depression", "10-30", "D1", 2, 4.91, 0.092, 1.47, 158, 7.37, 10.57, 0.59, 5.07, 6.37);
                yield return new Soils(10, "Depression", "10-30", "D1", 3, 4.79, 0.047, 1.46, 121, 6.99, 9.91, 0.3, 5.15, 6.82);
                yield return new Soils(10, "Depression", "10-30", "D1", 4, 5.36, 0.095, 1.26, 195, 8.59, 8.66, 0.48, 4.17, 3.65);
                yield return new Soils(11, "Depression", "30-60", "D3", 1, 3.94, 0.054, 1.6, 148, 4.85, 9.62, 0.18, 7.2, 10.14);
                yield return new Soils(11, "Depression", "30-60", "D3", 2, 4.52, 0.051, 1.53, 115, 6.34, 9.78, 0.34, 8.52, 9.74);
                yield return new Soils(11, "Depression", "30-60", "D3", 3, 4.35, 0.032, 1.55, 82, 5.99, 9.73, 0.22, 7.02, 8.6);
                yield return new Soils(11, "Depression", "30-60", "D3", 4, 4.64, 0.065, 1.46, 152, 4.43, 10.54, 0.22, 7.61, 9.09);
                yield return new Soils(12, "Depression", "60-90", "D6", 1, 3.82, 0.038, 1.4, 105, 4.65, 9.85, 0.18, 10.15, 12.26);
                yield return new Soils(12, "Depression", "60-90", "D6", 2, 4.24, 0.035, 1.47, 100, 4.56, 8.95, 0.33, 10.51, 11.29);
                yield return new Soils(12, "Depression", "60-90", "D6", 3, 4.22, 0.03, 1.56, 97, 5.29, 8.37, 0.14, 8.27, 9.51);
                yield return new Soils(12, "Depression", "60-90", "D6", 4, 4.41, 0.058, 1.58, 130, 4.58, 9.46, 0.14, 9.28, 12.69);
            }
        }
    }
}
