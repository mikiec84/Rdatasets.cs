// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cloud Seeding 2
    /// </summary>

    public class CloudSeeding2
    {
        public readonly int Period;
        public readonly string Seeded;
        public readonly string Season;
        public readonly double TE;
        public readonly double TW;
        public readonly double NC;
        public readonly double SC;
        public readonly double NWC;

        public CloudSeeding2(int Period, string Seeded, string Season, double TE, double TW, double NC, double SC, double NWC)
        {
            this.Period = Period;
            this.Seeded = Seeded;
            this.Season = Season;
            this.TE = TE;
            this.TW = TW;
            this.NC = NC;
            this.SC = SC;
            this.NWC = NWC;
        }

        public static IEnumerable<CloudSeeding2> Data
        {
            get
            {
                yield return new CloudSeeding2(1, "S", "Autumn", 1.69, 3.73, 1.65, 1.8, 3.33);
                yield return new CloudSeeding2(2, "U", "Autumn", 0.74, 0.78, 1.09, 0.79, 1.59);
                yield return new CloudSeeding2(3, "S", "Winter", 0.81, 0.86, 2.39, 0.36, 2.06);
                yield return new CloudSeeding2(4, "U", "Winter", 1.44, 2.01, 2.96, 1.27, 4.05);
                yield return new CloudSeeding2(5, "S", "Winter", 2.48, 4.61, 4.16, 2.16, 6);
                yield return new CloudSeeding2(6, "U", "Winter", 0.84, 2.39, 2.76, 0.87, 4.17);
                yield return new CloudSeeding2(7, "U", "Winter", 0.37, 1.37, 1.08, 0.85, 3.45);
                yield return new CloudSeeding2(8, "S", "Winter", 0.37, 0.84, 0.26, 0.47, 0.9);
                yield return new CloudSeeding2(9, "U", "Spring", 1.33, 2.31, 2.53, 1.08, 3.65);
                yield return new CloudSeeding2(10, "S", "Spring", 3.38, 5.56, 2.76, 3.1, 5.06);
                yield return new CloudSeeding2(11, "S", "Spring", 0.69, 1.46, 1.07, 0.64, 1.95);
                yield return new CloudSeeding2(12, "U", "Spring", 1.42, 2.79, 1.42, 1.08, 1.22);
                yield return new CloudSeeding2(13, "S", "Spring", 0.44, 1.05, 0.24, 0.44, 0.94);
                yield return new CloudSeeding2(14, "U", "Spring", 0.76, 1.24, 0.7, 0.67, 0.94);
                yield return new CloudSeeding2(15, "S", "Summer", 1.13, 2.28, 0.97, 1.66, 2.21);
                yield return new CloudSeeding2(16, "U", "Summer", 0.88, 1.58, 1.06, 1.13, 1.46);
                yield return new CloudSeeding2(45, "S", "Summer", 0.17, 0.55, 0.13, 0.27, 0.35);
                yield return new CloudSeeding2(46, "U", "Summer", 0.25, 0.77, 0.1, 0.3, 0.34);
                yield return new CloudSeeding2(47, "U", "Summer", 0.78, 1.45, 0.38, 0.58, 0.67);
                yield return new CloudSeeding2(48, "S", "Summer", 0.4, 0.34, 0.45, 0.43, 0.44);
                yield return new CloudSeeding2(49, "S", "Autumn", 0.52, 0.79, 0.42, 0.47, 0.53);
                yield return new CloudSeeding2(50, "U", "Autumn", 2.73, 2.09, 2.24, 4.02, 2.52);
                yield return new CloudSeeding2(51, "U", "Autumn", 0.9, 2.45, 0.52, 1.32, 2.18);
                yield return new CloudSeeding2(52, "S", "Autumn", 1.62, 2.54, 0.94, 1.59, 1.73);
                yield return new CloudSeeding2(53, "U", "Autumn", 0.93, 2.11, 1.19, 0.85, 2.31);
                yield return new CloudSeeding2(54, "S", "Autumn", 0.63, 1.31, 0.76, 0.71, 1.28);
                yield return new CloudSeeding2(55, "S", "Winter", 0.42, 1.23, 0.13, 0.59, 0.91);
                yield return new CloudSeeding2(56, "U", "Winter", 0.64, 0.43, 1.5, 0.24, 1.15);
                yield return new CloudSeeding2(57, "U", "Winter", 0.3, 0.69, 1.03, 0.22, 1.88);
                yield return new CloudSeeding2(58, "S", "Winter", 0.88, 1.32, 1.87, 0.58, 2.97);
                yield return new CloudSeeding2(59, "U", "Winter", 0.76, 1.25, 1.85, 1.36, 2.17);
                yield return new CloudSeeding2(60, "S", "Winter", 1.25, 1, 2.04, 0.71, 2.22);
                yield return new CloudSeeding2(61, "U", "Winter", 1.08, 0.99, 1.44, 1, 1.64);
                yield return new CloudSeeding2(62, "S", "Winter", 1.11, 0.8, 1.46, 1.48, 0.4);
                yield return new CloudSeeding2(63, "S", "Spring", 3.43, 2.55, 5.08, 1.77, 4.2);
                yield return new CloudSeeding2(64, "U", "Spring", 0.54, 0.43, 0.66, 0.73, 0.91);
                yield return new CloudSeeding2(65, "S", "Spring", 0.39, 0.44, 0.49, 0.55, 0.51);
                yield return new CloudSeeding2(66, "U", "Spring", 2.53, 3.18, 3.27, 2.68, 3.6);
                yield return new CloudSeeding2(67, "U", "Spring", 0.81, 0.89, 1.33, 0.43, 2.18);
                yield return new CloudSeeding2(68, "S", "Spring", 0.39, 1.22, 0.25, 0.46, 0.89);
                yield return new CloudSeeding2(69, "S", "Summer", 0.86, 1.24, 0.69, 0.49, 0.69);
                yield return new CloudSeeding2(70, "U", "Summer", 2.16, 2.29, 2.12, 0.95, 1.82);
                yield return new CloudSeeding2(95, "U", "Spring", 1.7, 2.18, 1.45, 1.47, 2.2);
                yield return new CloudSeeding2(96, "S", "Spring", 1.22, 2, 2.13, 1.13, 2.33);
                yield return new CloudSeeding2(97, "S", "Spring", 0.07, 0.22, 0.02, 0.08, 0.24);
                yield return new CloudSeeding2(98, "U", "Spring", 0.49, 1.07, 0.36, 0.87, 0.57);
                yield return new CloudSeeding2(99, "U", "Spring", 0.71, 1.73, 0.72, 0.99, 0.98);
                yield return new CloudSeeding2(100, "S", "Spring", 1.67, 3.46, 1.02, 1.89, 2.47);
                yield return new CloudSeeding2(101, "U", "Summer", 0.73, 1.51, 0.18, 1.42, 0.71);
                yield return new CloudSeeding2(102, "S", "Summer", 1.79, 3.13, 1.83, 1.82, 3.11);
                yield return new CloudSeeding2(103, "U", "Summer", 0.19, 1.05, 0.08, 0.4, 0.57);
                yield return new CloudSeeding2(104, "S", "Summer", 0, 0.15, 0, 0.04, 0.04);
                yield return new CloudSeeding2(105, "S", "Summer", 0.44, 0.89, 0.83, 0.38, 0.7);
                yield return new CloudSeeding2(106, "U", "Summer", 0.31, 1.15, 0.01, 0.44, 0.66);
                yield return new CloudSeeding2(107, "S", "Summer", 0.96, 0.88, 2.65, 0.85, 1.48);
                yield return new CloudSeeding2(108, "U", "Summer", 1.04, 1.2, 1.27, 1.39, 1.2);
                yield return new CloudSeeding2(109, "S", "Autumn", 0.05, 0.06, 0.01, 0.23, 0.1);
                yield return new CloudSeeding2(110, "U", "Autumn", 0.04, 0.2, 0.35, 0.75, 0.2);
                yield return new CloudSeeding2(111, "S", "Autumn", 1.83, 2.93, 1.8, 1.62, 3.02);
                yield return new CloudSeeding2(112, "U", "Autumn", 2.24, 2.17, 4.44, 1.05, 3.59);
                yield return new CloudSeeding2(113, "S", "Autumn", 2.5, 3.99, 2.84, 2.44, 4.48);
                yield return new CloudSeeding2(114, "U", "Autumn", 1.1, 1.71, 2.05, 1.3, 4.04);
                yield return new CloudSeeding2(115, "S", "Autumn", 1.83, 3.87, 3.01, 1.66, 4.56);
                yield return new CloudSeeding2(116, "U", "Autumn", 1.41, 2.99, 2.58, 1.21, 3.95);
                yield return new CloudSeeding2(117, "U", "Winter", 0.74, 1.36, 2.22, 0.61, 2.68);
                yield return new CloudSeeding2(118, "S", "Winter", 1.09, 3.56, 0.07, 2.26, 2.08);
                yield return new CloudSeeding2(119, "S", "Winter", 0.79, 1.43, 1.62, 1.16, 2.87);
                yield return new CloudSeeding2(120, "U", "Winter", 4.06, 6.71, 4.34, 3.29, 6.4);
                yield return new CloudSeeding2(121, "U", "Winter", 0.4, 0.64, 1.03, 0.58, 1.77);
                yield return new CloudSeeding2(122, "S", "Winter", 0.76, 1.83, 1.5, 0.41, 2.56);
                yield return new CloudSeeding2(123, "S", "Spring", 1.53, 3.62, 1.52, 1.62, 2.86);
                yield return new CloudSeeding2(124, "U", "Spring", 0.56, 2.88, 0.37, 1.25, 1.74);
                yield return new CloudSeeding2(125, "U", "Spring", 1.74, 3.45, 2.14, 1, 4.39);
                yield return new CloudSeeding2(126, "S", "Spring", 1.59, 3.19, 2.36, 1.53, 3.03);
                yield return new CloudSeeding2(127, "U", "Spring", 1.91, 4.74, 1.71, 2.03, 3.24);
                yield return new CloudSeeding2(128, "S", "Spring", 2.09, 5.23, 2.12, 2.77, 4.44);
                yield return new CloudSeeding2(129, "U", "Summer", 1.59, 3.92, 1.38, 2.11, 3.01);
                yield return new CloudSeeding2(130, "S", "Summer", 0.66, 2.22, 0.21, 1.41, 0.8);
                yield return new CloudSeeding2(131, "U", "Summer", 0.68, 0.42, 0.48, 0.59, 0.68);
                yield return new CloudSeeding2(132, "S", "Summer", 0.46, 1.08, 0.01, 0.65, 0.48);
                yield return new CloudSeeding2(133, "S", "Summer", 0.22, 0.62, 0.15, 0.13, 0.42);
                yield return new CloudSeeding2(134, "U", "Summer", 1.11, 1.7, 1.32, 0.57, 1.54);
                yield return new CloudSeeding2(135, "S", "Summer", 1.76, 1.19, 2.26, 1.04, 1.27);
                yield return new CloudSeeding2(136, "U", "Summer", 5.12, 5.25, 5.95, 3.97, 5.37);
                yield return new CloudSeeding2(171, "U", "Autumn", 0.12, 0.6, 0.19, 0.28, 0.7);
                yield return new CloudSeeding2(172, "S", "Autumn", 0.37, 0.65, 0.31, 0.23, 0.83);
                yield return new CloudSeeding2(173, "S", "Autumn", 4.97, 3.03, 1.44, 3.14, 0.86);
                yield return new CloudSeeding2(174, "U", "Autumn", 0.57, 1.53, 0.3, 0.72, 1.38);
                yield return new CloudSeeding2(175, "S", "Autumn", 0.13, 0.54, 0.11, 0.14, 0.58);
                yield return new CloudSeeding2(176, "U", "Autumn", 2.47, 4.7, 3.66, 1.84, 5.36);
                yield return new CloudSeeding2(177, "U", "Autumn", 1.01, 2.32, 1.14, 0.81, 2.09);
                yield return new CloudSeeding2(178, "S", "Autumn", 0.55, 1.13, 1.3, 0.34, 2.45);
                yield return new CloudSeeding2(179, "S", "Winter", 0.24, 0.61, 0.05, 0.38, 0.9);
                yield return new CloudSeeding2(180, "U", "Winter", 2.36, 1.15, 1.84, 1.73, 2.33);
                yield return new CloudSeeding2(181, "S", "Winter", 2.35, 4.29, 4.24, 1.67, 5.48);
                yield return new CloudSeeding2(182, "U", "Winter", 2.23, 4.3, 1.99, 1.9, 3.67);
                yield return new CloudSeeding2(183, "U", "Winter", 1.16, 3.06, 2.44, 1.52, 4.01);
                yield return new CloudSeeding2(184, "S", "Winter", 1.63, 3.31, 2.21, 2.36, 3.25);
                yield return new CloudSeeding2(185, "S", "Winter", 1.08, 3.17, 0.8, 2.25, 2.79);
                yield return new CloudSeeding2(186, "U", "Winter", 6, 6.15, 9.42, 3.6, 7.84);
                yield return new CloudSeeding2(187, "S", "Spring", 2.67, 6.93, 2.74, 3.03, 6.39);
                yield return new CloudSeeding2(188, "U", "Spring", 0.36, 0.15, 0, 0.19, 0.06);
                yield return new CloudSeeding2(189, "S", "Spring", 0.58, 1.41, 0.96, 0.64, 1.24);
                yield return new CloudSeeding2(190, "U", "Spring", 1.36, 3.43, 1.38, 1.86, 2.91);
                yield return new CloudSeeding2(191, "S", "Spring", 1.17, 1.65, 1.22, 2.28, 1.58);
                yield return new CloudSeeding2(192, "U", "Spring", 2.37, 1.94, 2.46, 2.47, 2.39);
                yield return new CloudSeeding2(193, "S", "Spring", 0.02, 0.08, 0.05, 0.02, 0.09);
                yield return new CloudSeeding2(194, "U", "Spring", 0.92, 2.09, 0.61, 0.87, 1.35);
            }
        }
    }
}
