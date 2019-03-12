// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.8
    /// </summary>

    public class larynx
    {
        public readonly int κ;
        public readonly int stage;
        public readonly double time;
        public readonly int age;
        public readonly int diagyr;
        public readonly int delta;

        public larynx(int κ, int stage, double time, int age, int diagyr, int delta)
        {
            this.κ = κ;
            this.stage = stage;
            this.time = time;
            this.age = age;
            this.diagyr = diagyr;
            this.delta = delta;
        }

        public static IEnumerable<larynx> Data
        {
            get
            {
                yield return new larynx(1, 1, 0.6, 77, 76, 1);
                yield return new larynx(2, 1, 1.3, 53, 71, 1);
                yield return new larynx(3, 1, 2.4, 45, 71, 1);
                yield return new larynx(4, 1, 2.5, 57, 78, 0);
                yield return new larynx(5, 1, 3.2, 58, 74, 1);
                yield return new larynx(6, 1, 3.2, 51, 77, 0);
                yield return new larynx(7, 1, 3.3, 76, 74, 1);
                yield return new larynx(8, 1, 3.3, 63, 77, 0);
                yield return new larynx(9, 1, 3.5, 43, 71, 1);
                yield return new larynx(10, 1, 3.5, 60, 73, 1);
                yield return new larynx(11, 1, 4, 52, 71, 1);
                yield return new larynx(12, 1, 4, 63, 76, 1);
                yield return new larynx(13, 1, 4.3, 86, 74, 1);
                yield return new larynx(14, 1, 4.5, 48, 76, 0);
                yield return new larynx(15, 1, 4.5, 68, 76, 0);
                yield return new larynx(16, 1, 5.3, 81, 72, 1);
                yield return new larynx(17, 1, 5.5, 70, 75, 0);
                yield return new larynx(18, 1, 5.9, 58, 75, 0);
                yield return new larynx(19, 1, 5.9, 47, 75, 0);
                yield return new larynx(20, 1, 6, 75, 73, 1);
                yield return new larynx(21, 1, 6.1, 77, 75, 0);
                yield return new larynx(22, 1, 6.2, 64, 75, 0);
                yield return new larynx(23, 1, 6.4, 77, 72, 1);
                yield return new larynx(24, 1, 6.5, 67, 70, 1);
                yield return new larynx(25, 1, 6.5, 79, 74, 0);
                yield return new larynx(26, 1, 6.7, 61, 74, 0);
                yield return new larynx(27, 1, 7, 66, 74, 0);
                yield return new larynx(28, 1, 7.4, 68, 71, 1);
                yield return new larynx(29, 1, 7.4, 73, 73, 0);
                yield return new larynx(30, 1, 8.1, 56, 73, 0);
                yield return new larynx(31, 1, 8.1, 73, 73, 0);
                yield return new larynx(32, 1, 9.6, 58, 71, 0);
                yield return new larynx(33, 1, 10.7, 68, 70, 0);
                yield return new larynx(34, 2, 0.2, 86, 74, 1);
                yield return new larynx(35, 2, 1.8, 64, 77, 1);
                yield return new larynx(36, 2, 2, 63, 75, 1);
                yield return new larynx(37, 2, 2.2, 71, 78, 0);
                yield return new larynx(38, 2, 2.6, 67, 78, 0);
                yield return new larynx(39, 2, 3.3, 51, 77, 0);
                yield return new larynx(40, 2, 3.6, 70, 77, 1);
                yield return new larynx(41, 2, 3.6, 72, 77, 0);
                yield return new larynx(42, 2, 4, 81, 71, 1);
                yield return new larynx(43, 2, 4.3, 47, 76, 0);
                yield return new larynx(44, 2, 4.3, 64, 76, 0);
                yield return new larynx(45, 2, 5, 66, 76, 0);
                yield return new larynx(46, 2, 6.2, 74, 72, 1);
                yield return new larynx(47, 2, 7, 62, 73, 1);
                yield return new larynx(48, 2, 7.5, 50, 73, 0);
                yield return new larynx(49, 2, 7.6, 53, 73, 0);
                yield return new larynx(50, 2, 9.3, 61, 71, 0);
                yield return new larynx(51, 3, 0.3, 49, 72, 1);
                yield return new larynx(52, 3, 0.3, 71, 76, 1);
                yield return new larynx(53, 3, 0.5, 57, 74, 1);
                yield return new larynx(54, 3, 0.7, 79, 77, 1);
                yield return new larynx(55, 3, 0.8, 82, 74, 1);
                yield return new larynx(56, 3, 1, 49, 76, 1);
                yield return new larynx(57, 3, 1.3, 60, 76, 1);
                yield return new larynx(58, 3, 1.6, 64, 72, 1);
                yield return new larynx(59, 3, 1.8, 74, 71, 1);
                yield return new larynx(60, 3, 1.9, 72, 74, 1);
                yield return new larynx(61, 3, 1.9, 53, 74, 1);
                yield return new larynx(62, 3, 3.2, 54, 75, 1);
                yield return new larynx(63, 3, 3.5, 81, 74, 1);
                yield return new larynx(64, 3, 3.7, 52, 77, 0);
                yield return new larynx(65, 3, 4.5, 66, 76, 0);
                yield return new larynx(66, 3, 4.8, 54, 76, 0);
                yield return new larynx(67, 3, 4.8, 63, 76, 0);
                yield return new larynx(68, 3, 5, 59, 73, 1);
                yield return new larynx(69, 3, 5, 49, 76, 0);
                yield return new larynx(70, 3, 5.1, 69, 76, 0);
                yield return new larynx(71, 3, 6.3, 70, 72, 1);
                yield return new larynx(72, 3, 6.4, 65, 72, 1);
                yield return new larynx(73, 3, 6.5, 65, 74, 0);
                yield return new larynx(74, 3, 7.8, 68, 72, 1);
                yield return new larynx(75, 3, 8, 78, 73, 0);
                yield return new larynx(76, 3, 9.3, 69, 71, 0);
                yield return new larynx(77, 3, 10.1, 51, 71, 0);
                yield return new larynx(78, 4, 0.1, 65, 72, 1);
                yield return new larynx(79, 4, 0.3, 71, 76, 1);
                yield return new larynx(80, 4, 0.4, 76, 77, 1);
                yield return new larynx(81, 4, 0.8, 65, 76, 1);
                yield return new larynx(82, 4, 0.8, 78, 77, 1);
                yield return new larynx(83, 4, 1, 41, 77, 1);
                yield return new larynx(84, 4, 1.5, 68, 73, 1);
                yield return new larynx(85, 4, 2, 69, 76, 1);
                yield return new larynx(86, 4, 2.3, 62, 71, 1);
                yield return new larynx(87, 4, 2.9, 74, 78, 0);
                yield return new larynx(88, 4, 3.6, 71, 75, 1);
                yield return new larynx(89, 4, 3.8, 84, 74, 1);
                yield return new larynx(90, 4, 4.3, 48, 76, 0);
            }
        }
    }
}
