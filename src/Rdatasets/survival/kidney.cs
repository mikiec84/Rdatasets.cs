// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Kidney catheter data
    /// </summary>

    public class kidney
    {
        public readonly int κ;
        public readonly int id;
        public readonly int time;
        public readonly int status;
        public readonly int age;
        public readonly int sex;
        public readonly string disease;
        public readonly double frail;

        public kidney(int κ, int id, int time, int status, int age, int sex, string disease, double frail)
        {
            this.κ = κ;
            this.id = id;
            this.time = time;
            this.status = status;
            this.age = age;
            this.sex = sex;
            this.disease = disease;
            this.frail = frail;
        }

        public static IEnumerable<kidney> Data
        {
            get
            {
                yield return new kidney(1, 1, 8, 1, 28, 1, "Other", 2.3);
                yield return new kidney(2, 1, 16, 1, 28, 1, "Other", 2.3);
                yield return new kidney(3, 2, 23, 1, 48, 2, "GN", 1.9);
                yield return new kidney(4, 2, 13, 0, 48, 2, "GN", 1.9);
                yield return new kidney(5, 3, 22, 1, 32, 1, "Other", 1.2);
                yield return new kidney(6, 3, 28, 1, 32, 1, "Other", 1.2);
                yield return new kidney(7, 4, 447, 1, 31, 2, "Other", 0.5);
                yield return new kidney(8, 4, 318, 1, 32, 2, "Other", 0.5);
                yield return new kidney(9, 5, 30, 1, 10, 1, "Other", 1.5);
                yield return new kidney(10, 5, 12, 1, 10, 1, "Other", 1.5);
                yield return new kidney(11, 6, 24, 1, 16, 2, "Other", 1.1);
                yield return new kidney(12, 6, 245, 1, 17, 2, "Other", 1.1);
                yield return new kidney(13, 7, 7, 1, 51, 1, "GN", 3);
                yield return new kidney(14, 7, 9, 1, 51, 1, "GN", 3);
                yield return new kidney(15, 8, 511, 1, 55, 2, "GN", 0.5);
                yield return new kidney(16, 8, 30, 1, 56, 2, "GN", 0.5);
                yield return new kidney(17, 9, 53, 1, 69, 2, "AN", 0.7);
                yield return new kidney(18, 9, 196, 1, 69, 2, "AN", 0.7);
                yield return new kidney(19, 10, 15, 1, 51, 1, "GN", 0.4);
                yield return new kidney(20, 10, 154, 1, 52, 1, "GN", 0.4);
                yield return new kidney(21, 11, 7, 1, 44, 2, "AN", 0.6);
                yield return new kidney(22, 11, 333, 1, 44, 2, "AN", 0.6);
                yield return new kidney(23, 12, 141, 1, 34, 2, "Other", 1.2);
                yield return new kidney(24, 12, 8, 0, 34, 2, "Other", 1.2);
                yield return new kidney(25, 13, 96, 1, 35, 2, "AN", 1.4);
                yield return new kidney(26, 13, 38, 1, 35, 2, "AN", 1.4);
                yield return new kidney(27, 14, 149, 0, 42, 2, "AN", 0.4);
                yield return new kidney(28, 14, 70, 0, 42, 2, "AN", 0.4);
                yield return new kidney(29, 15, 536, 1, 17, 2, "Other", 0.4);
                yield return new kidney(30, 15, 25, 0, 17, 2, "Other", 0.4);
                yield return new kidney(31, 16, 17, 1, 60, 1, "AN", 1.1);
                yield return new kidney(32, 16, 4, 0, 60, 1, "AN", 1.1);
                yield return new kidney(33, 17, 185, 1, 60, 2, "Other", 0.8);
                yield return new kidney(34, 17, 177, 1, 60, 2, "Other", 0.8);
                yield return new kidney(35, 18, 292, 1, 43, 2, "Other", 0.8);
                yield return new kidney(36, 18, 114, 1, 44, 2, "Other", 0.8);
                yield return new kidney(37, 19, 22, 0, 53, 2, "GN", 0.5);
                yield return new kidney(38, 19, 159, 0, 53, 2, "GN", 0.5);
                yield return new kidney(39, 20, 15, 1, 44, 2, "Other", 1.3);
                yield return new kidney(40, 20, 108, 0, 44, 2, "Other", 1.3);
                yield return new kidney(41, 21, 152, 1, 46, 1, "PKD", 0.2);
                yield return new kidney(42, 21, 562, 1, 47, 1, "PKD", 0.2);
                yield return new kidney(43, 22, 402, 1, 30, 2, "Other", 0.6);
                yield return new kidney(44, 22, 24, 0, 30, 2, "Other", 0.6);
                yield return new kidney(45, 23, 13, 1, 62, 2, "AN", 1.7);
                yield return new kidney(46, 23, 66, 1, 63, 2, "AN", 1.7);
                yield return new kidney(47, 24, 39, 1, 42, 2, "AN", 1);
                yield return new kidney(48, 24, 46, 0, 43, 2, "AN", 1);
                yield return new kidney(49, 25, 12, 1, 43, 1, "AN", 0.7);
                yield return new kidney(50, 25, 40, 1, 43, 1, "AN", 0.7);
                yield return new kidney(51, 26, 113, 0, 57, 2, "AN", 0.5);
                yield return new kidney(52, 26, 201, 1, 58, 2, "AN", 0.5);
                yield return new kidney(53, 27, 132, 1, 10, 2, "GN", 1.1);
                yield return new kidney(54, 27, 156, 1, 10, 2, "GN", 1.1);
                yield return new kidney(55, 28, 34, 1, 52, 2, "AN", 1.8);
                yield return new kidney(56, 28, 30, 1, 52, 2, "AN", 1.8);
                yield return new kidney(57, 29, 2, 1, 53, 1, "GN", 1.5);
                yield return new kidney(58, 29, 25, 1, 53, 1, "GN", 1.5);
                yield return new kidney(59, 30, 130, 1, 54, 2, "GN", 1.5);
                yield return new kidney(60, 30, 26, 1, 54, 2, "GN", 1.5);
                yield return new kidney(61, 31, 27, 1, 56, 2, "AN", 1.7);
                yield return new kidney(62, 31, 58, 1, 56, 2, "AN", 1.7);
                yield return new kidney(63, 32, 5, 0, 50, 2, "AN", 1.3);
                yield return new kidney(64, 32, 43, 1, 51, 2, "AN", 1.3);
                yield return new kidney(65, 33, 152, 1, 57, 2, "PKD", 2.9);
                yield return new kidney(66, 33, 30, 1, 57, 2, "PKD", 2.9);
                yield return new kidney(67, 34, 190, 1, 44, 2, "GN", 0.7);
                yield return new kidney(68, 34, 5, 0, 45, 2, "GN", 0.7);
                yield return new kidney(69, 35, 119, 1, 22, 2, "Other", 2.2);
                yield return new kidney(70, 35, 8, 1, 22, 2, "Other", 2.2);
                yield return new kidney(71, 36, 54, 0, 42, 2, "Other", 0.7);
                yield return new kidney(72, 36, 16, 0, 42, 2, "Other", 0.7);
                yield return new kidney(73, 37, 6, 0, 52, 2, "PKD", 2.1);
                yield return new kidney(74, 37, 78, 1, 52, 2, "PKD", 2.1);
                yield return new kidney(75, 38, 63, 1, 60, 1, "PKD", 1.2);
                yield return new kidney(76, 38, 8, 0, 60, 1, "PKD", 1.2);
            }
        }
    }
}
