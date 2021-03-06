// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Methods of Teaching Reading Comprehension
    /// </summary>

    public class Baumann
    {
        public readonly int κ;
        public readonly string group;
        public readonly int pretest_1;
        public readonly int pretest_2;
        public readonly int post_test_1;
        public readonly int post_test_2;
        public readonly int post_test_3;

        public Baumann(int κ, string group, int pretest_1, int pretest_2, int post_test_1, int post_test_2, int post_test_3)
        {
            this.κ = κ;
            this.group = group;
            this.pretest_1 = pretest_1;
            this.pretest_2 = pretest_2;
            this.post_test_1 = post_test_1;
            this.post_test_2 = post_test_2;
            this.post_test_3 = post_test_3;
        }

        public static IEnumerable<Baumann> Data
        {
            get
            {
                yield return new Baumann(1, "Basal", 4, 3, 5, 4, 41);
                yield return new Baumann(2, "Basal", 6, 5, 9, 5, 41);
                yield return new Baumann(3, "Basal", 9, 4, 5, 3, 43);
                yield return new Baumann(4, "Basal", 12, 6, 8, 5, 46);
                yield return new Baumann(5, "Basal", 16, 5, 10, 9, 46);
                yield return new Baumann(6, "Basal", 15, 13, 9, 8, 45);
                yield return new Baumann(7, "Basal", 14, 8, 12, 5, 45);
                yield return new Baumann(8, "Basal", 12, 7, 5, 5, 32);
                yield return new Baumann(9, "Basal", 12, 3, 8, 7, 33);
                yield return new Baumann(10, "Basal", 8, 8, 7, 7, 39);
                yield return new Baumann(11, "Basal", 13, 7, 12, 4, 42);
                yield return new Baumann(12, "Basal", 9, 2, 4, 4, 45);
                yield return new Baumann(13, "Basal", 12, 5, 4, 6, 39);
                yield return new Baumann(14, "Basal", 12, 2, 8, 8, 44);
                yield return new Baumann(15, "Basal", 12, 2, 6, 4, 36);
                yield return new Baumann(16, "Basal", 10, 10, 9, 10, 49);
                yield return new Baumann(17, "Basal", 8, 5, 3, 3, 40);
                yield return new Baumann(18, "Basal", 12, 5, 5, 5, 35);
                yield return new Baumann(19, "Basal", 11, 3, 4, 5, 36);
                yield return new Baumann(20, "Basal", 8, 4, 2, 3, 40);
                yield return new Baumann(21, "Basal", 7, 3, 5, 4, 54);
                yield return new Baumann(22, "Basal", 9, 6, 7, 8, 32);
                yield return new Baumann(23, "DRTA", 7, 2, 7, 6, 31);
                yield return new Baumann(24, "DRTA", 7, 6, 5, 6, 40);
                yield return new Baumann(25, "DRTA", 12, 4, 13, 3, 48);
                yield return new Baumann(26, "DRTA", 10, 1, 5, 7, 30);
                yield return new Baumann(27, "DRTA", 16, 8, 14, 7, 42);
                yield return new Baumann(28, "DRTA", 15, 7, 14, 6, 48);
                yield return new Baumann(29, "DRTA", 9, 6, 10, 9, 49);
                yield return new Baumann(30, "DRTA", 8, 7, 13, 5, 53);
                yield return new Baumann(31, "DRTA", 13, 7, 12, 7, 48);
                yield return new Baumann(32, "DRTA", 12, 8, 11, 6, 43);
                yield return new Baumann(33, "DRTA", 7, 6, 8, 5, 55);
                yield return new Baumann(34, "DRTA", 6, 2, 7, 0, 55);
                yield return new Baumann(35, "DRTA", 8, 4, 10, 6, 57);
                yield return new Baumann(36, "DRTA", 9, 6, 8, 6, 53);
                yield return new Baumann(37, "DRTA", 9, 4, 8, 7, 37);
                yield return new Baumann(38, "DRTA", 8, 4, 10, 11, 50);
                yield return new Baumann(39, "DRTA", 9, 5, 12, 6, 54);
                yield return new Baumann(40, "DRTA", 13, 6, 10, 6, 41);
                yield return new Baumann(41, "DRTA", 10, 2, 11, 6, 49);
                yield return new Baumann(42, "DRTA", 8, 6, 7, 8, 47);
                yield return new Baumann(43, "DRTA", 8, 5, 8, 8, 49);
                yield return new Baumann(44, "DRTA", 10, 6, 12, 6, 49);
                yield return new Baumann(45, "Strat", 11, 7, 11, 12, 53);
                yield return new Baumann(46, "Strat", 7, 6, 4, 8, 47);
                yield return new Baumann(47, "Strat", 4, 6, 4, 10, 41);
                yield return new Baumann(48, "Strat", 7, 2, 4, 4, 49);
                yield return new Baumann(49, "Strat", 7, 6, 3, 9, 43);
                yield return new Baumann(50, "Strat", 6, 5, 8, 5, 45);
                yield return new Baumann(51, "Strat", 11, 5, 12, 8, 50);
                yield return new Baumann(52, "Strat", 14, 6, 14, 12, 48);
                yield return new Baumann(53, "Strat", 13, 6, 12, 11, 49);
                yield return new Baumann(54, "Strat", 9, 5, 7, 11, 42);
                yield return new Baumann(55, "Strat", 12, 3, 5, 10, 38);
                yield return new Baumann(56, "Strat", 13, 9, 9, 9, 42);
                yield return new Baumann(57, "Strat", 4, 6, 1, 10, 34);
                yield return new Baumann(58, "Strat", 13, 8, 13, 1, 48);
                yield return new Baumann(59, "Strat", 6, 4, 7, 9, 51);
                yield return new Baumann(60, "Strat", 12, 3, 5, 13, 33);
                yield return new Baumann(61, "Strat", 6, 6, 7, 9, 44);
                yield return new Baumann(62, "Strat", 11, 4, 11, 7, 48);
                yield return new Baumann(63, "Strat", 14, 4, 15, 7, 49);
                yield return new Baumann(64, "Strat", 8, 2, 9, 5, 33);
                yield return new Baumann(65, "Strat", 5, 3, 6, 8, 45);
                yield return new Baumann(66, "Strat", 8, 3, 4, 6, 42);
            }
        }
    }
}
