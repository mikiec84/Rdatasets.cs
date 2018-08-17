// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Nursing
    /// </summary>

    public class Nursing
    {
        public readonly int Beds;
        public readonly int InPatientDays;
        public readonly int AllPatientDays;
        public readonly int PatientRevenue;
        public readonly int NurseSalaries;
        public readonly int FacilitiesExpend;
        public readonly int Rural;

        public Nursing(int Beds, int InPatientDays, int AllPatientDays, int PatientRevenue, int NurseSalaries, int FacilitiesExpend, int Rural)
        {
            this.Beds = Beds;
            this.InPatientDays = InPatientDays;
            this.AllPatientDays = AllPatientDays;
            this.PatientRevenue = PatientRevenue;
            this.NurseSalaries = NurseSalaries;
            this.FacilitiesExpend = FacilitiesExpend;
            this.Rural = Rural;
        }

        public static IEnumerable<Nursing> Data
        {
            get
            {
                yield return new Nursing(244, 128, 385, 23521, 5230, 5334, 0);
                yield return new Nursing(59, 155, 203, 9160, 2459, 493, 1);
                yield return new Nursing(120, 281, 392, 21900, 6304, 6115, 0);
                yield return new Nursing(120, 291, 419, 22354, 6590, 6346, 0);
                yield return new Nursing(120, 238, 363, 17421, 5362, 6225, 0);
                yield return new Nursing(65, 180, 234, 10531, 3622, 449, 1);
                yield return new Nursing(120, 306, 372, 22147, 4406, 4998, 1);
                yield return new Nursing(90, 214, 305, 14025, 4173, 966, 1);
                yield return new Nursing(96, 155, 169, 8812, 1955, 1260, 0);
                yield return new Nursing(120, 133, 188, 11729, 3224, 6442, 1);
                yield return new Nursing(62, 148, 192, 8896, 2409, 1236, 0);
                yield return new Nursing(120, 274, 426, 20987, 2066, 3360, 1);
                yield return new Nursing(116, 154, 321, 17655, 5946, 4231, 0);
                yield return new Nursing(59, 120, 164, 7085, 1925, 1280, 1);
                yield return new Nursing(80, 261, 284, 13089, 4166, 1123, 1);
                yield return new Nursing(120, 338, 375, 21453, 5257, 5206, 1);
                yield return new Nursing(80, 77, 133, 7790, 1988, 4443, 1);
                yield return new Nursing(100, 204, 318, 18309, 4156, 4585, 1);
                yield return new Nursing(60, 97, 213, 8872, 1914, 1675, 1);
                yield return new Nursing(110, 178, 280, 17881, 5173, 5686, 1);
                yield return new Nursing(120, 232, 336, 17004, 4630, 907, 0);
                yield return new Nursing(135, 316, 442, 23829, 7489, 3351, 0);
                yield return new Nursing(59, 163, 191, 9424, 2051, 1756, 1);
                yield return new Nursing(60, 96, 202, 12474, 3803, 2123, 0);
                yield return new Nursing(25, 74, 83, 4078, 2008, 4531, 1);
                yield return new Nursing(221, 514, 776, 36029, 1288, 2543, 1);
                yield return new Nursing(64, 91, 214, 8782, 4729, 4446, 1);
                yield return new Nursing(62, 146, 204, 8951, 2367, 1064, 0);
                yield return new Nursing(108, 255, 366, 17446, 5933, 2987, 1);
                yield return new Nursing(62, 144, 220, 6164, 2782, 411, 1);
                yield return new Nursing(90, 151, 286, 2853, 4651, 4197, 0);
                yield return new Nursing(146, 100, 375, 21334, 6857, 1198, 0);
                yield return new Nursing(62, 174, 189, 8082, 2143, 1209, 1);
                yield return new Nursing(30, 54, 88, 3948, 3025, 137, 1);
                yield return new Nursing(79, 213, 278, 11649, 2905, 1279, 0);
                yield return new Nursing(44, 127, 158, 7850, 1498, 1273, 1);
                yield return new Nursing(120, 208, 423, 29035, 6236, 3524, 0);
                yield return new Nursing(100, 255, 300, 17532, 3547, 2561, 1);
                yield return new Nursing(49, 110, 177, 8197, 2810, 3874, 1);
                yield return new Nursing(123, 208, 336, 22555, 6059, 6402, 1);
                yield return new Nursing(82, 114, 136, 8459, 1995, 1911, 1);
                yield return new Nursing(58, 166, 205, 10412, 2245, 1122, 1);
                yield return new Nursing(110, 228, 323, 16661, 4029, 3893, 1);
                yield return new Nursing(62, 183, 222, 12406, 2784, 2212, 1);
                yield return new Nursing(86, 62, 200, 11312, 3720, 2959, 1);
                yield return new Nursing(102, 326, 355, 14499, 3866, 3006, 1);
                yield return new Nursing(135, 157, 471, 24274, 7485, 1344, 0);
                yield return new Nursing(78, 154, 203, 9327, 3672, 1242, 1);
                yield return new Nursing(83, 224, 390, 12362, 3995, 1484, 1);
                yield return new Nursing(60, 48, 213, 10644, 2820, 1154, 0);
                yield return new Nursing(54, 119, 144, 7556, 2088, 245, 1);
                yield return new Nursing(120, 217, 327, 20182, 4432, 6274, 0);
            }
        }
    }
}
