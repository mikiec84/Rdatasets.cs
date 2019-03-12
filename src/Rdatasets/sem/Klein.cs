// ReSharper disable All

namespace Rdatasets.sem
{
    using System.Collections.Generic;

    /// <summary>
    /// Klein's Data on the U. S. Economy
    /// </summary>

    public class Klein
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double C;
        public readonly double P;
        public readonly double Wp;
        public readonly double I;
        public readonly double K_lag;
        public readonly double X;
        public readonly double Wg;
        public readonly double G;
        public readonly double T;

        public Klein(int κ, int Year, double C, double P, double Wp, double I, double K_lag, double X, double Wg, double G, double T)
        {
            this.κ = κ;
            this.Year = Year;
            this.C = C;
            this.P = P;
            this.Wp = Wp;
            this.I = I;
            this.K_lag = K_lag;
            this.X = X;
            this.Wg = Wg;
            this.G = G;
            this.T = T;
        }

        public static IEnumerable<Klein> Data
        {
            get
            {
                yield return new Klein(1, 1920, 39.8, 12.7, 28.8, 2.7, 180.1, 44.9, 2.2, 2.4, 3.4);
                yield return new Klein(2, 1921, 41.9, 12.4, 25.5, -0.2, 182.8, 45.6, 2.7, 3.9, 7.7);
                yield return new Klein(3, 1922, 45, 16.9, 29.3, 1.9, 182.6, 50.1, 2.9, 3.2, 3.9);
                yield return new Klein(4, 1923, 49.2, 18.4, 34.1, 5.2, 184.5, 57.2, 2.9, 2.8, 4.7);
                yield return new Klein(5, 1924, 50.6, 19.4, 33.9, 3, 189.7, 57.1, 3.1, 3.5, 3.8);
                yield return new Klein(6, 1925, 52.6, 20.1, 35.4, 5.1, 192.7, 61, 3.2, 3.3, 5.5);
                yield return new Klein(7, 1926, 55.1, 19.6, 37.4, 5.6, 197.8, 64, 3.3, 3.3, 7);
                yield return new Klein(8, 1927, 56.2, 19.8, 37.9, 4.2, 203.4, 64.4, 3.6, 4, 6.7);
                yield return new Klein(9, 1928, 57.3, 21.1, 39.2, 3, 207.6, 64.5, 3.7, 4.2, 4.2);
                yield return new Klein(10, 1929, 57.8, 21.7, 41.3, 5.1, 210.6, 67, 4, 4.1, 4);
                yield return new Klein(11, 1930, 55, 15.6, 37.9, 1, 215.7, 61.2, 4.2, 5.2, 7.7);
                yield return new Klein(12, 1931, 50.9, 11.4, 34.5, -3.4, 216.7, 53.4, 4.8, 5.9, 7.5);
                yield return new Klein(13, 1932, 45.6, 7, 29, -6.2, 213.3, 44.3, 5.3, 4.9, 8.3);
                yield return new Klein(14, 1933, 46.5, 11.2, 28.5, -5.1, 207.1, 45.1, 5.6, 3.7, 5.4);
                yield return new Klein(15, 1934, 48.7, 12.3, 30.6, -3, 202, 49.7, 6, 4, 6.8);
                yield return new Klein(16, 1935, 51.3, 14, 33.2, -1.3, 199, 54.4, 6.1, 4.4, 7.2);
                yield return new Klein(17, 1936, 57.7, 17.6, 36.8, 2.1, 197.7, 62.7, 7.4, 2.9, 8.3);
                yield return new Klein(18, 1937, 58.7, 17.3, 41, 2, 199.8, 65, 6.7, 4.3, 6.7);
                yield return new Klein(19, 1938, 57.5, 15.3, 38.2, -1.9, 201.8, 60.9, 7.7, 5.3, 7.4);
                yield return new Klein(20, 1939, 61.6, 19, 41.6, 1.3, 199.9, 69.5, 7.8, 6.6, 8.9);
                yield return new Klein(21, 1940, 65, 21.1, 45, 3.3, 201.2, 75.7, 8, 7.4, 9.6);
                yield return new Klein(22, 1941, 69.7, 23.5, 53.3, 4.9, 204.5, 88.4, 8.5, 13.8, 11.6);
            }
        }
    }
}
