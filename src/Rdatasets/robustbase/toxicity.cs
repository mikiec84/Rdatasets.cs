// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Toxicity of Carboxylic Acids Data
    /// </summary>

    public class toxicity
    {
        public readonly double toxicity_;
        public readonly double logKow;
        public readonly double pKa;
        public readonly double ELUMO;
        public readonly double Ecarb;
        public readonly double Emet;
        public readonly double RM;
        public readonly double IR;
        public readonly double Ts;
        public readonly double P;

        public toxicity(double toxicity_, double logKow, double pKa, double ELUMO, double Ecarb, double Emet, double RM, double IR, double Ts, double P)
        {
            this.toxicity_ = toxicity_;
            this.logKow = logKow;
            this.pKa = pKa;
            this.ELUMO = ELUMO;
            this.Ecarb = Ecarb;
            this.Emet = Emet;
            this.RM = RM;
            this.IR = IR;
            this.Ts = Ts;
            this.P = P;
        }

        public static IEnumerable<toxicity> Data
        {
            get
            {
                yield return new toxicity(-0.15, 1.68, 1, 4.81, 17.8635, 1.4838, 31.36, 1.425, 31.3, 12.43);
                yield return new toxicity(-0.33, 0.94, 0.98, 4.68, 16.9491, 0, 22.1, 1.408, 30.4, 8.76);
                yield return new toxicity(-0.34, 1.16, 0.96, 4.86, 17.1806, 0.2778, 26.73, 1.418, 30.9, 10.59);
                yield return new toxicity(0.03, 2.75, 1, 4.83, 18.4794, 3.5836, 40.63, 1.435, 31.8, 16.1);
                yield return new toxicity(-0.57, 0.79, 0.97, 4.8, 16.8022, 1.0232, 22.14, 1.411, 32.5, 8.77);
                yield return new toxicity(0.08, 2.64, 1.01, 4.9, 18.3937, 3.7145, 40.63, 1.435, 31.8, 16.1);
                yield return new toxicity(-0.27, 1.39, 0.96, 4.82, 17.1101, 2.0815, 26.77, 1.42, 32.7, 10.61);
                yield return new toxicity(-0.25, 1.47, 1.02, 4.62, 17.5139, 0, 26.74, 1.419, 30.2, 10.6);
                yield return new toxicity(-0.51, 0.33, 0.95, 4.74, 16.3449, 0.2222, 17.51, 1.397, 32.3, 6.94);
                yield return new toxicity(-0.11, 2.42, 0.94, 4.88, 17.7382, 4.5544, 36.04, 1.432, 32.9, 14.28);
                yield return new toxicity(0.35, 3.47, 0.97, 4.97, 17.7382, 7.2507, 45.3, 1.44, 33.1, 17.96);
                yield return new toxicity(0.51, 4.09, 0.96, 4.83, 17.8253, 8.6425, 49.94, 1.443, 33.1, 19.79);
                yield return new toxicity(0.9, 4.42, 0.96, 4.86, 17.8983, 10.0532, 54.57, 1.445, 33.2, 21.63);
                yield return new toxicity(-0.23, 1.75, 0.98, 4.86, 17.4886, 1.2528, 31.36, 1.425, 31.3, 12.43);
                yield return new toxicity(-0.27, 1.75, 0.97, 4.86, 17.3705, 1.0902, 31.36, 1.425, 31.3, 12.43);
                yield return new toxicity(0.08, 3.05, 0.94, 4.9, 17.6321, 5.8845, 40.67, 1.437, 33, 16.12);
                yield return new toxicity(-0.21, 1.92, 0.97, 4.87, 17.3322, 3.277, 31.41, 1.427, 32.8, 12.45);
                yield return new toxicity(-0.64, -0.29, 0.81, 4.35, 16.8734, 0.0866, 28.34, 1.476, 56.1, 1.476);
                yield return new toxicity(-0.61, 0.08, 0.81, 4.35, 17.1579, 1.0178, 32.97, 1.476, 52.4, 1.476);
                yield return new toxicity(-0.94, -0.59, 0.6, 3.76, 16.4629, -0.5926, 23.7, 1.477, 61.6, 1.477);
                yield return new toxicity(0.08, 4.13, 0.9069, 4.44, 18.0218, 11.2898, 70.03, 1.474, 41.7, 1.474);
                yield return new toxicity(-0.09, 3.07, 0.8757, 4.44, 17.9095, 8.5144, 60.77, 1.474, 43.1, 1.474);
                yield return new toxicity(-0.71, -0.58, 0.1296, 2.77, 15.8195, -0.8056, 19.07, 1.478, 70.5, 1.478);
                yield return new toxicity(-0.58, 0.43, 0.7474, 4.4, 17.3666, 2.1002, 37.6, 1.476, 49.8, 1.476);
                yield return new toxicity(-0.27, 2.01, 0.8548, 4.44, 17.7543, 5.8246, 51.5, 1.475, 44.9, 1.475);
                yield return new toxicity(-0.51, 0.95, 0.7951, 4.42, 17.5262, 3.281, 42.24, 1.475, 47.8, 1.475);
                yield return new toxicity(-0.28, 1.41, -0.16, 4.72, 16.7559, 0.784, 26.83, 1.452, 34.1, 1.452);
                yield return new toxicity(0.12, 0.87, 0.92, 4.74, 16.9781, 1.8572, 26.5, 1.438, 33.1, 1.438);
                yield return new toxicity(-0.13, 1.94, -0.19, 4.72, 16.9432, 4.132, 31.46, 1.455, 34, 1.455);
                yield return new toxicity(-0.22, 1.4, 0.65, 4.54, 17.143, 1.0567, 31.46, 1.455, 34, 1.455);
                yield return new toxicity(-0.54, 0.72, -0.19, 4.62, 16.448, 0, 22.2, 1.448, 34.2, 1.448);
                yield return new toxicity(0.16, 0.35, -0.2, 1.86, 15.8727, 2.9606, 17.23, 1.422, 32.8, 1.422);
                yield return new toxicity(0.21, 3, -0.17, 4.72, 17.2779, 4.3525, 40.73, 1.459, 34, 1.459);
                yield return new toxicity(-0.06, 2.12, 0.12, 2.67, 16.9238, 4, 38.68, 1.47, 40.9, 1.47);
                yield return new toxicity(-0.29, -0.52, 0.06, 1.86, 15.4004, 0, 15.33, 1.455, 52.9, 1.455);
                yield return new toxicity(0.71, 2.65, 0.12, 2.39, 17.0299, 5.3118, 43.31, 1.47, 40.1, 1.47);
                yield return new toxicity(0.6, 3.53, -0.17, 4.39, 17.384, 5.6883, 45.36, 1.46, 33.9, 1.46);
                yield return new toxicity(-0.64, 0.64, 0.8, 4.39, 16.5416, 3.2756, 21.87, 1.432, 33, 1.432);
            }
        }
    }
}
