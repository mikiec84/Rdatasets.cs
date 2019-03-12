// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// MedGPA
    /// </summary>

    public class MedGPA
    {
        public readonly int κ;
        public readonly string Accept;
        public readonly int Acceptance;
        public readonly string Sex;
        public readonly double BCPM;
        public readonly double GPA;
        public readonly int VR;
        public readonly int PS;
        public readonly int? WS;
        public readonly int BS;
        public readonly int MCAT;
        public readonly int Apps;

        public MedGPA(int κ, string Accept, int Acceptance, string Sex, double BCPM, double GPA, int VR, int PS, int? WS, int BS, int MCAT, int Apps)
        {
            this.κ = κ;
            this.Accept = Accept;
            this.Acceptance = Acceptance;
            this.Sex = Sex;
            this.BCPM = BCPM;
            this.GPA = GPA;
            this.VR = VR;
            this.PS = PS;
            this.WS = WS;
            this.BS = BS;
            this.MCAT = MCAT;
            this.Apps = Apps;
        }

        public static IEnumerable<MedGPA> Data
        {
            get
            {
                yield return new MedGPA(1, "D", 0, "F", 3.59, 3.62, 11, 9, 9, 9, 38, 5);
                yield return new MedGPA(2, "A", 1, "M", 3.75, 3.84, 12, 13, 8, 12, 45, 3);
                yield return new MedGPA(3, "A", 1, "F", 3.24, 3.23, 9, 10, 5, 9, 33, 19);
                yield return new MedGPA(4, "A", 1, "F", 3.74, 3.69, 12, 11, 7, 10, 40, 5);
                yield return new MedGPA(5, "A", 1, "F", 3.53, 3.38, 9, 11, 4, 11, 35, 11);
                yield return new MedGPA(6, "A", 1, "M", 3.59, 3.72, 10, 9, 7, 10, 36, 5);
                yield return new MedGPA(7, "A", 1, "M", 3.85, 3.89, 11, 12, 6, 11, 40, 5);
                yield return new MedGPA(8, "D", 0, "M", 3.26, 3.34, 11, 11, 8, 9, 39, 7);
                yield return new MedGPA(9, "A", 1, "F", 3.74, 3.71, 8, 10, 6, 11, 35, 5);
                yield return new MedGPA(10, "A", 1, "F", 3.86, 3.89, 9, 9, 6, 10, 34, 11);
                yield return new MedGPA(11, "A", 1, "F", 4, 3.97, 11, 9, 8, 11, 39, 6);
                yield return new MedGPA(12, "A", 1, "F", 3.35, 3.49, 11, 8, 4, 8, 31, 9);
                yield return new MedGPA(13, "A", 1, "M", 3.77, 3.77, 8, 10, 7, 10, 35, 5);
                yield return new MedGPA(14, "D", 0, "M", 3.6, 3.61, 9, 9, 4, 10, 32, 8);
                yield return new MedGPA(15, "D", 0, "M", 3.29, 3.3, 11, 8, 6, 7, 32, 15);
                yield return new MedGPA(16, "A", 1, "F", 3.26, 3.54, 12, 8, 8, 10, 38, 6);
                yield return new MedGPA(17, "D", 0, "M", 3.75, 3.65, 8, 8, 8, 11, 35, 6);
                yield return new MedGPA(18, "A", 1, "M", 3.51, 3.54, 9, 10, 9, 11, 39, 1);
                yield return new MedGPA(19, "D", 0, "M", 3.27, 3.25, 8, 9, 5, 10, 32, 5);
                yield return new MedGPA(20, "A", 1, "M", 3.95, 3.89, 13, 14, 8, 13, 48, 5);
                yield return new MedGPA(21, "A", 1, "F", 3.71, 3.71, 13, 10, 8, 10, 41, 6);
                yield return new MedGPA(22, "D", 0, "M", 3.73, 3.77, 8, 10, 8, 10, 36, 7);
                yield return new MedGPA(23, "A", 1, "M", 4, 3.91, 10, 13, 6, 12, 41, 17);
                yield return new MedGPA(24, "A", 1, "M", 3.98, 3.88, 9, 10, 8, 12, 39, 17);
                yield return new MedGPA(25, "D", 0, "M", 3.76, 3.68, 7, 9, 6, 9, 31, 10);
                yield return new MedGPA(26, "A", 1, "M", 3.51, 3.56, 6, 10, 6, 10, 32, 5);
                yield return new MedGPA(27, "D", 0, "F", 3.38, 3.44, 11, 9, 4, 8, 32, 10);
                yield return new MedGPA(28, "A", 1, "F", 3.41, 3.58, 11, 11, 6, 9, 37, 14);
                yield return new MedGPA(29, "A", 1, "F", 3.15, 3.4, 10, 10, 6, 10, 36, 1);
                yield return new MedGPA(30, "A", 1, "F", 3.78, 3.82, 10, 11, 10, 10, 41, 5);
                yield return new MedGPA(31, "A", 1, "M", 3.54, 3.62, 10, 12, 6, 11, 39, 7);
                yield return new MedGPA(32, "D", 0, "F", 3.14, 3.09, 7, 10, 8, 9, 34, 24);
                yield return new MedGPA(33, "A", 1, "F", 3.89, 3.89, 8, 9, 8, 10, 35, 7);
                yield return new MedGPA(34, "D", 0, "M", 3.67, 3.7, 7, 10, 8, 9, 34, 11);
                yield return new MedGPA(35, "D", 0, "M", 3.22, 3.24, 11, 12, 8, 10, 41, 11);
                yield return new MedGPA(36, "A", 1, "M", 3.87, 3.86, 10, 11, 8, 11, 40, 8);
                yield return new MedGPA(37, "D", 0, "M", 3.49, 3.54, 11, 9, 10, 6, 36, 18);
                yield return new MedGPA(38, "D", 0, "F", 3.08, 3.4, 8, 6, 4, 9, 27, 7);
                yield return new MedGPA(39, "A", 1, "F", 3.82, 3.87, 10, 10, 5, 9, 34, 12);
                yield return new MedGPA(40, "A", 1, "M", 3.1, 3.14, 10, 9, 8, 11, 38, 12);
                yield return new MedGPA(41, "D", 0, "F", 3.56, 3.37, 6, 8, 9, 8, 31, 4);
                yield return new MedGPA(42, "D", 0, "F", 3.19, 3.38, 9, 8, 8, 9, 34, 6);
                yield return new MedGPA(43, "A", 1, "F", 3.53, 3.62, 11, 10, 8, 11, 40, 5);
                yield return new MedGPA(44, "A", 1, "F", 3.98, 3.94, 13, 8, 8, 10, 39, 12);
                yield return new MedGPA(45, "D", 0, "F", 3.19, 3.37, 10, 9, 6, 9, 34, 5);
                yield return new MedGPA(46, "D", 0, "F", 3.25, 3.36, 11, 8, 9, 12, 40, 12);
                yield return new MedGPA(47, "A", 1, "F", 3.98, 3.97, 11, 13, 10, 14, 48, 6);
                yield return new MedGPA(48, "D", 0, "M", 2.75, 3.04, 10, 9, 8, 9, 36, 7);
                yield return new MedGPA(49, "D", 0, "F", 3.12, 3.29, 11, 10, 8, 8, 37, 12);
                yield return new MedGPA(50, "D", 0, "F", 3.53, 3.67, 12, 10, 9, 8, 39, 6);
                yield return new MedGPA(51, "D", 0, "M", 2.41, 2.72, 8, 8, 8, 8, 32, 7);
                yield return new MedGPA(52, "D", 0, "M", 3.51, 3.56, 11, 8, 6, 9, 34, 6);
                yield return new MedGPA(53, "A", 1, "F", 3.43, 3.48, 7, 10, 7, 10, 34, 14);
                yield return new MedGPA(54, "D", 0, "M", 2.61, 2.8, 7, 5, null, 6, 18, 6);
                yield return new MedGPA(55, "D", 0, "M", 3.36, 3.44, 11, 11, 8, 9, 39, 1);
            }
        }
    }
}
