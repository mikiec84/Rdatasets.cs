// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements of Forensic Glass Fragments
    /// </summary>

    public class fgl
    {
        public readonly double RI;
        public readonly double Na;
        public readonly double Mg;
        public readonly double Al;
        public readonly double Si;
        public readonly double K;
        public readonly double Ca;
        public readonly double Ba;
        public readonly double Fe;
        public readonly string type;

        public fgl(double RI, double Na, double Mg, double Al, double Si, double K, double Ca, double Ba, double Fe, string type)
        {
            this.RI = RI;
            this.Na = Na;
            this.Mg = Mg;
            this.Al = Al;
            this.Si = Si;
            this.K = K;
            this.Ca = Ca;
            this.Ba = Ba;
            this.Fe = Fe;
            this.type = type;
        }

        public static IEnumerable<fgl> Data
        {
            get
            {
                yield return new fgl(3.00999999999999, 13.64, 4.49, 1.1, 71.78, 0.06, 8.75, 0, 0, "WinF");
                yield return new fgl(-0.3900000000001, 13.89, 3.6, 1.36, 72.73, 0.48, 7.83, 0, 0, "WinF");
                yield return new fgl(-1.81999999999994, 13.53, 3.55, 1.54, 72.99, 0.39, 7.78, 0, 0, "WinF");
                yield return new fgl(-0.339999999999918, 13.21, 3.69, 1.29, 72.61, 0.57, 8.22, 0, 0, "WinF");
                yield return new fgl(-0.579999999999927, 13.27, 3.62, 1.24, 73.08, 0.55, 8.07, 0, 0, "WinF");
                yield return new fgl(-2.03999999999996, 12.79, 3.61, 1.62, 72.97, 0.64, 8.07, 0, 0.26, "WinF");
                yield return new fgl(-0.569999999999936, 13.3, 3.6, 1.14, 73.09, 0.58, 8.17, 0, 0, "WinF");
                yield return new fgl(-0.440000000000055, 13.15, 3.61, 1.05, 73.24, 0.57, 8.24, 0, 0, "WinF");
                yield return new fgl(1.18000000000006, 14.04, 3.58, 1.37, 72.08, 0.56, 8.3, 0, 0, "WinF");
                yield return new fgl(-0.450000000000045, 13, 3.6, 1.36, 72.99, 0.57, 8.4, 0, 0.11, "WinF");
                yield return new fgl(-2.29000000000019, 12.72, 3.46, 1.56, 73.2, 0.67, 8.09, 0, 0.24, "WinF");
                yield return new fgl(-0.369999999999891, 12.8, 3.66, 1.27, 73.01, 0.6, 8.56, 0, 0, "WinF");
                yield return new fgl(-2.11000000000013, 12.88, 3.43, 1.4, 73.28, 0.69, 8.05, 0, 0.24, "WinF");
                yield return new fgl(-0.519999999999982, 12.86, 3.56, 1.27, 73.21, 0.54, 8.38, 0, 0.17, "WinF");
                yield return new fgl(-0.369999999999891, 12.61, 3.59, 1.31, 73.29, 0.58, 8.5, 0, 0, "WinF");
                yield return new fgl(-0.3900000000001, 12.81, 3.54, 1.23, 73.24, 0.58, 8.39, 0, 0, "WinF");
                yield return new fgl(-0.159999999999854, 12.68, 3.67, 1.16, 73.11, 0.61, 8.7, 0, 0, "WinF");
                yield return new fgl(3.96000000000004, 14.36, 3.85, 0.89, 71.36, 0.15, 9.15, 0, 0, "WinF");
                yield return new fgl(1.1099999999999, 13.9, 3.73, 1.18, 72.12, 0.06, 8.89, 0, 0, "WinF");
                yield return new fgl(-0.650000000000091, 13.02, 3.54, 1.69, 72.73, 0.54, 8.44, 0, 0.07, "WinF");
                yield return new fgl(-0.5, 12.82, 3.55, 1.49, 72.75, 0.54, 8.52, 0, 0.19, "WinF");
                yield return new fgl(1.66000000000008, 14.77, 3.75, 0.29, 72.02, 0.03, 9, 0, 0, "WinF");
                yield return new fgl(-0.639999999999873, 12.78, 3.62, 1.29, 72.79, 0.59, 8.7, 0, 0, "WinF");
                yield return new fgl(-0.490000000000009, 12.81, 3.57, 1.35, 73.02, 0.62, 8.59, 0, 0, "WinF");
                yield return new fgl(-0.799999999999955, 13.38, 3.5, 1.15, 72.85, 0.5, 8.43, 0, 0, "WinF");
                yield return new fgl(-0.3599999999999, 12.98, 3.54, 1.21, 73, 0.65, 8.53, 0, 0, "WinF");
                yield return new fgl(-0.0699999999999363, 13.21, 3.48, 1.41, 72.64, 0.59, 8.43, 0, 0, "WinF");
                yield return new fgl(-0.789999999999964, 12.87, 3.48, 1.33, 73.04, 0.56, 8.43, 0, 0, "WinF");
                yield return new fgl(-0.320000000000164, 12.56, 3.52, 1.43, 73.15, 0.57, 8.54, 0, 0, "WinF");
                yield return new fgl(-0.159999999999854, 13.08, 3.49, 1.28, 72.86, 0.6, 8.49, 0, 0, "WinF");
                yield return new fgl(-0.320000000000164, 12.65, 3.56, 1.3, 73.08, 0.61, 8.69, 0, 0.14, "WinF");
                yield return new fgl(-0.529999999999973, 12.84, 3.5, 1.14, 73.27, 0.56, 8.55, 0, 0, "WinF");
                yield return new fgl(-0.25, 12.85, 3.48, 1.23, 72.97, 0.61, 8.56, 0.09, 0.22, "WinF");
                yield return new fgl(-0.470000000000027, 12.57, 3.47, 1.38, 73.39, 0.6, 8.55, 0, 0.06, "WinF");
                yield return new fgl(-0.170000000000073, 12.69, 3.54, 1.34, 72.95, 0.57, 8.75, 0, 0, "WinF");
                yield return new fgl(-2.32999999999993, 13.29, 3.45, 1.21, 72.74, 0.56, 8.57, 0, 0, "WinF");
                yield return new fgl(1.09000000000015, 13.89, 3.53, 1.32, 71.81, 0.51, 8.78, 0.11, 0, "WinF");
                yield return new fgl(-0.0299999999999727, 12.74, 3.48, 1.35, 72.96, 0.64, 8.68, 0, 0, "WinF");
                yield return new fgl(4.12999999999988, 14.21, 3.82, 0.47, 71.77, 0.11, 9.57, 0, 0, "WinF");
                yield return new fgl(4.12999999999988, 14.21, 3.82, 0.47, 71.77, 0.11, 9.57, 0, 0, "WinF");
                yield return new fgl(-0.0699999999999363, 12.79, 3.5, 1.12, 73.03, 0.64, 8.77, 0, 0, "WinF");
                yield return new fgl(-0.450000000000045, 12.71, 3.42, 1.2, 73.2, 0.59, 8.64, 0, 0, "WinF");
                yield return new fgl(-0.210000000000036, 13.21, 3.39, 1.33, 72.76, 0.59, 8.59, 0, 0, "WinF");
                yield return new fgl(4.09999999999991, 13.73, 3.84, 0.72, 71.76, 0.17, 9.74, 0, 0, "WinF");
                yield return new fgl(-0.1400000000001, 12.73, 3.43, 1.19, 72.95, 0.62, 8.76, 0, 0.3, "WinF");
                yield return new fgl(1, 13.49, 3.48, 1.35, 71.95, 0.55, 9, 0, 0, "WinF");
                yield return new fgl(0.690000000000055, 13.19, 3.37, 1.18, 72.72, 0.57, 8.83, 0, 0.16, "WinF");
                yield return new fgl(8.67000000000007, 13.99, 3.7, 0.71, 71.57, 0.02, 9.82, 0, 0.1, "WinF");
                yield return new fgl(4.23000000000002, 13.21, 3.77, 0.79, 71.99, 0.13, 10.02, 0, 0, "WinF");
                yield return new fgl(0.980000000000018, 13.58, 3.35, 1.23, 72.08, 0.59, 8.91, 0, 0, "WinF");
                yield return new fgl(5.20000000000005, 13.72, 3.72, 0.51, 71.75, 0.09, 10.06, 0, 0.16, "WinF");
                yield return new fgl(1.25999999999999, 13.2, 3.33, 1.28, 72.36, 0.6, 9.14, 0, 0.11, "WinF");
                yield return new fgl(0.0800000000001546, 13.43, 2.87, 1.19, 72.84, 0.55, 9.03, 0, 0, "WinF");
                yield return new fgl(0.369999999999891, 13.14, 2.84, 1.28, 72.85, 0.55, 9.07, 0, 0, "WinF");
                yield return new fgl(-0.220000000000027, 13.21, 2.81, 1.29, 72.98, 0.51, 9.02, 0, 0.09, "WinF");
                yield return new fgl(-0.309999999999945, 12.45, 2.71, 1.29, 73.7, 0.56, 9.06, 0, 0.24, "WinF");
                yield return new fgl(-5.84999999999991, 12.99, 3.47, 1.12, 72.98, 0.62, 8.35, 0, 0.31, "WinF");
                yield return new fgl(0.240000000000009, 12.87, 3.48, 1.29, 72.95, 0.6, 8.43, 0, 0, "WinF");
                yield return new fgl(-0.460000000000036, 13.48, 3.74, 1.17, 72.99, 0.59, 8.03, 0, 0, "WinF");
                yield return new fgl(-0.460000000000036, 13.39, 3.66, 1.19, 72.79, 0.57, 8.27, 0, 0.11, "WinF");
                yield return new fgl(1.04999999999995, 13.6, 3.62, 1.11, 72.64, 0.14, 8.76, 0, 0, "WinF");
                yield return new fgl(1.76999999999998, 13.81, 3.58, 1.32, 71.72, 0.12, 8.67, 0.69, 0, "WinF");
                yield return new fgl(3.72000000000003, 13.51, 3.86, 0.88, 71.79, 0.23, 9.54, 0, 0.11, "WinF");
                yield return new fgl(4.26999999999998, 14.17, 3.81, 0.78, 71.35, 0, 9.69, 0, 0, "WinF");
                yield return new fgl(3.72000000000003, 13.48, 3.74, 0.9, 72.01, 0.18, 9.61, 0, 0.07, "WinF");
                yield return new fgl(2.99000000000001, 13.69, 3.59, 1.12, 71.96, 0.09, 9.4, 0, 0, "WinF");
                yield return new fgl(3.51999999999998, 13.05, 3.65, 0.87, 72.22, 0.19, 9.85, 0, 0.17, "WinF");
                yield return new fgl(3.51999999999998, 13.05, 3.65, 0.87, 72.32, 0.19, 9.85, 0, 0.17, "WinF");
                yield return new fgl(3.51999999999998, 13.12, 3.58, 0.9, 72.2, 0.23, 9.82, 0, 0.16, "WinF");
                yield return new fgl(5, 13.31, 3.58, 0.82, 71.99, 0.12, 10.17, 0, 0.03, "WinF");
                yield return new fgl(-2.25999999999999, 14.86, 3.67, 1.74, 71.87, 0.16, 7.36, 0, 0.12, "WinNF");
                yield return new fgl(0.480000000000018, 13.64, 3.87, 1.27, 71.96, 0.54, 8.32, 0, 0.32, "WinNF");
                yield return new fgl(-2.06999999999994, 13.09, 3.59, 1.52, 73.1, 0.67, 7.83, 0, 0, "WinNF");
                yield return new fgl(-1.69000000000005, 13.34, 3.57, 1.57, 72.87, 0.61, 7.89, 0, 0, "WinNF");
                yield return new fgl(-2.03999999999996, 13.02, 3.56, 1.54, 73.11, 0.72, 7.9, 0, 0, "WinNF");
                yield return new fgl(-2.09999999999991, 13.02, 3.58, 1.51, 73.12, 0.69, 7.96, 0, 0, "WinNF");
                yield return new fgl(-1.54999999999995, 13.44, 3.61, 1.54, 72.39, 0.66, 8.03, 0, 0, "WinNF");
                yield return new fgl(-1.73000000000002, 13, 3.58, 1.54, 72.83, 0.61, 8.04, 0, 0, "WinNF");
                yield return new fgl(-1.87000000000012, 13.92, 3.52, 1.25, 72.88, 0.37, 7.94, 0, 0.14, "WinNF");
                yield return new fgl(-2.09999999999991, 12.82, 3.52, 1.9, 72.86, 0.69, 7.97, 0, 0, "WinNF");
                yield return new fgl(-2.08000000000015, 12.86, 3.52, 2.12, 72.66, 0.69, 7.97, 0, 0, "WinNF");
                yield return new fgl(-2.06999999999994, 13.25, 3.45, 1.43, 73.17, 0.61, 7.86, 0, 0, "WinNF");
                yield return new fgl(-1.54000000000019, 13.41, 3.55, 1.25, 72.81, 0.68, 8.1, 0, 0, "WinNF");
                yield return new fgl(-2.05999999999995, 13.09, 3.52, 1.55, 72.87, 0.68, 8.05, 0, 0.09, "WinNF");
                yield return new fgl(-3.91000000000008, 14.25, 3.09, 2.08, 72.28, 1.1, 7.08, 0, 0, "WinNF");
                yield return new fgl(-1.75, 13.36, 3.58, 1.49, 72.72, 0.45, 8.21, 0, 0, "WinNF");
                yield return new fgl(-2.30999999999995, 13.24, 3.49, 1.47, 73.25, 0.38, 8.03, 0, 0, "WinNF");
                yield return new fgl(-1.54999999999995, 13.4, 3.49, 1.52, 72.65, 0.67, 8.08, 0, 0.1, "WinNF");
                yield return new fgl(-1.81999999999994, 13.01, 3.5, 1.48, 72.89, 0.6, 8.12, 0, 0, "WinNF");
                yield return new fgl(-1.60000000000014, 12.55, 3.48, 1.87, 73.23, 0.63, 8.08, 0, 0.09, "WinNF");
                yield return new fgl(0.410000000000082, 12.93, 3.74, 1.11, 72.28, 0.64, 8.96, 0, 0.22, "WinNF");
                yield return new fgl(-1.95000000000005, 12.9, 3.44, 1.45, 73.06, 0.44, 8.27, 0, 0, "WinNF");
                yield return new fgl(-2.12000000000012, 13.12, 3.41, 1.58, 73.26, 0.07, 8.39, 0, 0.19, "WinNF");
                yield return new fgl(-2.09999999999991, 13.24, 3.34, 1.47, 73.1, 0.39, 8.22, 0, 0, "WinNF");
                yield return new fgl(-1.71000000000004, 12.71, 3.33, 1.49, 73.28, 0.67, 8.24, 0, 0, "WinNF");
                yield return new fgl(0.599999999999909, 13.36, 3.43, 1.43, 72.26, 0.51, 8.6, 0, 0, "WinNF");
                yield return new fgl(0.410000000000082, 13.02, 3.62, 1.06, 72.34, 0.64, 9.13, 0, 0.15, "WinNF");
                yield return new fgl(-0.569999999999936, 12.2, 3.25, 1.16, 73.55, 0.62, 8.9, 0, 0.24, "WinNF");
                yield return new fgl(-1.1099999999999, 12.67, 2.88, 1.71, 73.21, 0.73, 8.54, 0, 0, "WinNF");
                yield return new fgl(0.110000000000127, 12.96, 2.96, 1.43, 72.92, 0.6, 8.79, 0.14, 0, "WinNF");
                yield return new fgl(-1.45000000000005, 12.75, 2.85, 1.44, 73.27, 0.57, 8.79, 0.11, 0.22, "WinNF");
                yield return new fgl(-0.699999999999818, 12.35, 2.72, 1.63, 72.87, 0.7, 9.23, 0, 0, "WinNF");
                yield return new fgl(0.200000000000045, 12.62, 2.76, 0.83, 73.81, 0.35, 9.42, 0, 0.2, "WinNF");
                yield return new fgl(9.25, 13.8, 3.15, 0.66, 70.57, 0.08, 11.64, 0, 0, "WinNF");
                yield return new fgl(6.09999999999991, 13.83, 2.9, 1.17, 71.15, 0.08, 10.79, 0, 0, "WinNF");
                yield return new fgl(6.75, 11.45, 0, 1.88, 72.19, 0.81, 13.24, 0, 0.34, "WinNF");
                yield return new fgl(13.25, 10.73, 0, 2.1, 69.81, 0.58, 13.3, 3.15, 0.28, "WinNF");
                yield return new fgl(15.9300000000001, 12.3, 0, 1, 70.16, 0.12, 16.19, 0, 0.24, "WinNF");
                yield return new fgl(4.2199999999998, 14.43, 0, 1, 72.67, 0.1, 11.52, 0, 0.08, "WinNF");
                yield return new fgl(0.180000000000064, 13.72, 0, 0.56, 74.45, 0, 10.99, 0, 0, "WinNF");
                yield return new fgl(8.6400000000001, 11.23, 0, 0.77, 73.21, 0, 14.68, 0, 0, "WinNF");
                yield return new fgl(9.3900000000001, 11.02, 0, 0.75, 73.08, 0, 14.96, 0, 0, "WinNF");
                yield return new fgl(9.76999999999998, 12.64, 0, 0.67, 72.02, 0.06, 14.4, 0, 0, "WinNF");
                yield return new fgl(0.920000000000073, 13.46, 3.83, 1.26, 72.55, 0.57, 8.21, 0, 0.14, "WinNF");
                yield return new fgl(0.470000000000027, 13.1, 3.97, 1.19, 72.44, 0.6, 8.43, 0, 0, "WinNF");
                yield return new fgl(0.459999999999809, 13.41, 3.89, 1.33, 72.38, 0.51, 8.28, 0, 0, "WinNF");
                yield return new fgl(0.289999999999964, 13.24, 3.9, 1.41, 72.33, 0.55, 8.31, 0, 0.1, "WinNF");
                yield return new fgl(-0.920000000000073, 13.72, 3.68, 1.81, 72.06, 0.64, 7.88, 0, 0, "WinNF");
                yield return new fgl(-1.26999999999998, 13.3, 3.64, 1.53, 72.53, 0.65, 8.03, 0, 0.29, "WinNF");
                yield return new fgl(-1.48000000000002, 13.56, 3.57, 1.47, 72.45, 0.64, 7.96, 0, 0, "WinNF");
                yield return new fgl(0.440000000000055, 13.25, 3.76, 1.32, 72.4, 0.58, 8.42, 0, 0, "WinNF");
                yield return new fgl(-1.37000000000012, 12.93, 3.54, 1.62, 72.96, 0.64, 8.03, 0, 0.21, "WinNF");
                yield return new fgl(-1.13000000000011, 13.23, 3.54, 1.48, 72.84, 0.56, 8.1, 0, 0, "WinNF");
                yield return new fgl(-0.930000000000064, 13.48, 3.48, 1.71, 72.52, 0.62, 7.99, 0, 0, "WinNF");
                yield return new fgl(3.76999999999998, 13.2, 3.68, 1.15, 72.75, 0.54, 8.52, 0, 0, "WinNF");
                yield return new fgl(0.720000000000027, 12.93, 3.66, 1.56, 72.51, 0.58, 8.55, 0, 0.12, "WinNF");
                yield return new fgl(-1.32999999999993, 12.94, 3.61, 1.26, 72.75, 0.56, 8.6, 0, 0, "WinNF");
                yield return new fgl(2.80999999999995, 13.78, 2.28, 1.43, 71.99, 0.49, 9.85, 0, 0.17, "WinNF");
                yield return new fgl(2.68000000000006, 13.55, 2.09, 1.67, 72.18, 0.53, 9.57, 0.27, 0.17, "WinNF");
                yield return new fgl(2.20000000000005, 13.98, 1.35, 1.63, 71.76, 0.39, 10.56, 0, 0.18, "WinNF");
                yield return new fgl(3.76999999999998, 13.75, 1.01, 1.36, 72.19, 0.33, 11.14, 0, 0, "WinNF");
                yield return new fgl(8.1400000000001, 13.7, 0, 1.36, 71.24, 0.19, 13.44, 0, 0.1, "WinNF");
                yield return new fgl(0.129999999999882, 13.43, 3.98, 1.18, 72.49, 0.58, 8.15, 0, 0, "WinNF");
                yield return new fgl(0, 13.71, 3.93, 1.54, 71.81, 0.54, 8.21, 0, 0.15, "WinNF");
                yield return new fgl(0.110000000000127, 13.33, 3.85, 1.25, 72.78, 0.52, 8.12, 0, 0, "WinNF");
                yield return new fgl(-0.110000000000127, 13.19, 3.9, 1.3, 72.33, 0.55, 8.44, 0, 0.28, "WinNF");
                yield return new fgl(0.0599999999999454, 13, 3.8, 1.08, 73.07, 0.56, 8.38, 0, 0.12, "WinNF");
                yield return new fgl(-0.8900000000001, 12.89, 3.62, 1.57, 72.96, 0.61, 8.11, 0, 0, "WinNF");
                yield return new fgl(-1.25999999999999, 12.79, 3.52, 1.54, 73.36, 0.66, 7.9, 0, 0, "WinNF");
                yield return new fgl(-1.25999999999999, 12.87, 3.56, 1.64, 73.14, 0.65, 7.99, 0, 0, "WinNF");
                yield return new fgl(-1.10000000000014, 13.33, 3.54, 1.61, 72.54, 0.68, 8.11, 0, 0, "WinNF");
                yield return new fgl(0.509999999999991, 13.2, 3.63, 1.07, 72.83, 0.57, 8.41, 0.09, 0.17, "WinNF");
                yield return new fgl(-1.37999999999988, 12.85, 3.51, 1.44, 73.01, 0.68, 8.23, 0.06, 0.25, "WinNF");
                yield return new fgl(-0.909999999999854, 13, 3.47, 1.79, 72.72, 0.66, 8.18, 0, 0, "WinNF");
                yield return new fgl(-1.40000000000009, 12.99, 3.18, 1.23, 72.97, 0.58, 8.81, 0, 0.24, "WinNF");
                yield return new fgl(0.389999999999873, 12.85, 3.67, 1.24, 72.57, 0.62, 8.68, 0, 0.35, "WinNF");
                yield return new fgl(-0.309999999999945, 13.65, 3.66, 1.11, 72.77, 0.11, 8.6, 0, 0, "Veh");
                yield return new fgl(-1.90000000000009, 13.33, 3.53, 1.34, 72.67, 0.56, 8.33, 0, 0, "Veh");
                yield return new fgl(-1.29999999999995, 13.24, 3.57, 1.38, 72.7, 0.56, 8.44, 0, 0.1, "Veh");
                yield return new fgl(-1.57000000000016, 12.16, 3.52, 1.35, 72.89, 0.57, 8.53, 0, 0, "Veh");
                yield return new fgl(-1.34999999999991, 13.14, 3.45, 1.76, 72.48, 0.6, 8.38, 0, 0.17, "Veh");
                yield return new fgl(3.26999999999998, 14.32, 3.9, 0.83, 71.5, 0, 9.49, 0, 0, "Veh");
                yield return new fgl(-0.210000000000036, 13.64, 3.65, 0.65, 73, 0.06, 8.93, 0, 0, "Veh");
                yield return new fgl(-1.90000000000009, 13.42, 3.4, 1.22, 72.69, 0.59, 8.32, 0, 0, "Veh");
                yield return new fgl(-1.05999999999995, 12.86, 3.58, 1.31, 72.61, 0.61, 8.79, 0, 0, "Veh");
                yield return new fgl(-1.54000000000019, 13.04, 3.4, 1.26, 73.01, 0.52, 8.58, 0, 0, "Veh");
                yield return new fgl(-1.45000000000005, 13.41, 3.39, 1.28, 72.64, 0.52, 8.65, 0, 0, "Veh");
                yield return new fgl(3.21000000000004, 14.03, 3.76, 0.58, 71.79, 0.11, 9.65, 0, 0, "Veh");
                yield return new fgl(-0.240000000000009, 13.53, 3.41, 1.52, 72.04, 0.58, 8.79, 0, 0, "Veh");
                yield return new fgl(-0.0399999999999636, 13.5, 3.36, 1.63, 71.94, 0.57, 8.81, 0, 0.09, "Veh");
                yield return new fgl(0.319999999999936, 13.33, 3.34, 1.54, 72.14, 0.56, 8.99, 0, 0, "Veh");
                yield return new fgl(1.33999999999992, 13.64, 3.54, 0.75, 72.65, 0.16, 8.89, 0.15, 0.24, "Veh");
                yield return new fgl(4.11000000000013, 14.19, 3.78, 0.91, 71.36, 0.23, 9.14, 0, 0.37, "Veh");
                yield return new fgl(-2.86000000000013, 14.01, 2.68, 3.5, 69.89, 1.68, 5.87, 2.2, 0, "Con");
                yield return new fgl(1.15000000000009, 12.73, 1.85, 1.86, 72.69, 0.6, 10.09, 0, 0, "Con");
                yield return new fgl(3.70999999999981, 11.56, 1.88, 1.56, 72.86, 0.47, 11.41, 0, 0, "Con");
                yield return new fgl(3.50999999999999, 11.03, 1.71, 1.56, 73.44, 0.58, 11.62, 0, 0, "Con");
                yield return new fgl(1.69000000000005, 12.64, 0, 1.65, 73.75, 0.38, 11.53, 0, 0, "Con");
                yield return new fgl(-1.34000000000015, 12.86, 0, 1.83, 73.88, 0.97, 10.17, 0, 0, "Con");
                yield return new fgl(1.94000000000005, 13.27, 0, 1.76, 73.03, 0.47, 11.32, 0, 0, "Con");
                yield return new fgl(5.69000000000005, 13.44, 0, 1.58, 72.22, 0.32, 12.24, 0, 0, "Con");
                yield return new fgl(-4.83999999999992, 13.02, 0, 3.04, 70.48, 6.21, 6.96, 0, 0, "Con");
                yield return new fgl(-4.78999999999996, 13, 0, 3.02, 70.7, 6.21, 6.93, 0, 0, "Con");
                yield return new fgl(2.42999999999984, 13.38, 0, 1.4, 72.25, 0.33, 12.5, 0, 0, "Con");
                yield return new fgl(2.58000000000015, 12.85, 1.61, 2.17, 72.18, 0.76, 9.7, 0.24, 0.51, "Con");
                yield return new fgl(3.19000000000005, 12.97, 0.33, 1.51, 73.39, 0.13, 11.27, 0, 0.28, "Con");
                yield return new fgl(1.04999999999995, 14, 2.39, 1.56, 72.37, 0, 9.57, 0, 0, "Tabl");
                yield return new fgl(1.37000000000012, 13.79, 2.41, 1.19, 72.76, 0, 9.77, 0, 0, "Tabl");
                yield return new fgl(0.289999999999964, 14.46, 2.24, 1.62, 72.38, 0, 9.26, 0, 0, "Tabl");
                yield return new fgl(0.519999999999982, 14.09, 2.19, 1.66, 72.67, 0, 9.32, 0, 0, "Tabl");
                yield return new fgl(-5.00999999999999, 14.4, 1.74, 1.54, 74.55, 0, 7.59, 0, 0, "Tabl");
                yield return new fgl(0.880000000000109, 14.99, 0.78, 1.74, 72.5, 0, 9.95, 0, 0, "Tabl");
                yield return new fgl(1.16000000000008, 14.15, 0, 2.09, 72.74, 0, 10.88, 0, 0, "Tabl");
                yield return new fgl(1.69000000000005, 14.56, 0, 0.56, 73.48, 0, 11.22, 0, 0, "Tabl");
                yield return new fgl(-6.84999999999991, 17.38, 0, 0.34, 75.41, 0, 6.65, 0, 0, "Tabl");
                yield return new fgl(-6.69000000000005, 13.69, 3.2, 1.81, 72.81, 1.76, 5.43, 1.19, 0, "Head");
                yield return new fgl(0.380000000000109, 14.32, 3.26, 2.22, 71.25, 1.46, 5.79, 1.63, 0, "Head");
                yield return new fgl(5.15000000000009, 13.44, 3.34, 1.23, 72.38, 0.6, 8.83, 0, 0, "Head");
                yield return new fgl(4.47000000000003, 14.86, 2.2, 2.06, 70.26, 0.76, 9.76, 0, 0, "Head");
                yield return new fgl(5.64999999999986, 15.79, 1.83, 1.31, 70.43, 0.31, 8.61, 1.68, 0, "Head");
                yield return new fgl(-1.87000000000012, 13.88, 1.78, 1.79, 73.1, 0, 8.67, 0.76, 0, "Head");
                yield return new fgl(-1.98000000000002, 14.85, 0, 2.38, 73.28, 0, 8.76, 0.64, 0.09, "Head");
                yield return new fgl(-1.76999999999998, 14.2, 0, 2.79, 73.46, 0.04, 9.04, 0.4, 0.09, "Head");
                yield return new fgl(-0.809999999999945, 14.75, 0, 2, 73.02, 0, 8.53, 1.59, 0.08, "Head");
                yield return new fgl(-1.17000000000007, 14.56, 0, 1.98, 73.29, 0, 8.52, 1.57, 0.07, "Head");
                yield return new fgl(-2.54999999999995, 14.14, 0, 2.68, 73.39, 0.08, 9.07, 0.61, 0.05, "Head");
                yield return new fgl(-2.44000000000005, 13.87, 0, 2.54, 73.23, 0.14, 9.41, 0.81, 0.01, "Head");
                yield return new fgl(-0.730000000000018, 14.7, 0, 2.34, 73.28, 0, 8.95, 0.66, 0, "Head");
                yield return new fgl(-2.69000000000005, 14.38, 0, 2.66, 73.1, 0.04, 9.08, 0.64, 0, "Head");
                yield return new fgl(-1.91000000000008, 15.01, 0, 2.51, 73.05, 0.05, 8.83, 0.53, 0, "Head");
                yield return new fgl(-2.92000000000007, 15.15, 0, 2.25, 73.5, 0, 8.34, 0.63, 0, "Head");
                yield return new fgl(-1.47000000000003, 11.95, 0, 1.19, 75.18, 2.7, 8.93, 0, 0, "Head");
                yield return new fgl(-2.86000000000013, 14.85, 0, 2.42, 73.72, 0, 8.39, 0.56, 0, "Head");
                yield return new fgl(-1.42000000000007, 14.8, 0, 1.99, 73.11, 0, 8.28, 1.71, 0, "Head");
                yield return new fgl(-1.82999999999993, 14.95, 0, 2.27, 73.3, 0, 8.71, 0.67, 0, "Head");
                yield return new fgl(-0.680000000000064, 14.95, 0, 1.8, 72.99, 0, 8.61, 1.55, 0, "Head");
                yield return new fgl(-1.54999999999995, 14.94, 0, 1.87, 73.11, 0, 8.67, 1.38, 0, "Head");
                yield return new fgl(0.309999999999945, 14.39, 0, 1.82, 72.86, 1.41, 6.47, 2.88, 0, "Head");
                yield return new fgl(-1.60000000000014, 14.37, 0, 2.74, 72.85, 0, 9.45, 0.54, 0, "Head");
                yield return new fgl(-1.76999999999998, 14.14, 0, 2.88, 72.61, 0.08, 9.18, 1.06, 0, "Head");
                yield return new fgl(-1.14999999999986, 14.92, 0, 1.99, 73.06, 0, 8.4, 1.59, 0, "Head");
                yield return new fgl(2.65000000000009, 14.36, 0, 2.02, 73.42, 0, 8.44, 1.64, 0, "Head");
                yield return new fgl(-1.49000000000001, 14.38, 0, 1.94, 73.61, 0, 8.48, 1.57, 0, "Head");
                yield return new fgl(-0.8900000000001, 14.23, 0, 2.08, 73.36, 0, 8.62, 1.67, 0, "Head");
            }
        }
    }
}
