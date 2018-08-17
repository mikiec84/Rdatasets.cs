// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Schizophrenia Data
    /// </summary>

    public class schizophrenia2
    {
        public readonly int subject;
        public readonly string onset;
        public readonly string disorder;
        public readonly int month;

        public schizophrenia2(int subject, string onset, string disorder, int month)
        {
            this.subject = subject;
            this.onset = onset;
            this.disorder = disorder;
            this.month = month;
        }

        public static IEnumerable<schizophrenia2> Data
        {
            get
            {
                yield return new schizophrenia2(1, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(1, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(1, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(1, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(1, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(2, "> 20 yrs", "absent", 0);
                yield return new schizophrenia2(2, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(2, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(2, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(2, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(3, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(3, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(3, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(3, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(3, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(4, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(4, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(4, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(4, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(4, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(5, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(5, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(5, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(5, "< 20 yrs", "present", 8);
                yield return new schizophrenia2(5, "< 20 yrs", "present", 10);
                yield return new schizophrenia2(6, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(6, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(6, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(6, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(6, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(7, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(7, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(7, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(7, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(7, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(8, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(8, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(8, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(8, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(8, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(9, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(9, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(9, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(9, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(9, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(10, "> 20 yrs", "absent", 0);
                yield return new schizophrenia2(10, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(10, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(10, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(10, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(11, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(11, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(11, "> 20 yrs", "present", 6);
                yield return new schizophrenia2(11, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(11, "> 20 yrs", "present", 10);
                yield return new schizophrenia2(12, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(12, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(12, "< 20 yrs", null, 6);
                yield return new schizophrenia2(12, "< 20 yrs", null, 8);
                yield return new schizophrenia2(12, "< 20 yrs", null, 10);
                yield return new schizophrenia2(13, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(13, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(13, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(13, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(13, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(14, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(14, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(14, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(14, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(14, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(15, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(15, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(15, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(15, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(15, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(16, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(16, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(16, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(16, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(16, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(17, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(17, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(17, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(17, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(17, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(18, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(18, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(18, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(18, "< 20 yrs", "present", 8);
                yield return new schizophrenia2(18, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(19, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(19, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(19, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(19, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(19, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(20, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(20, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(20, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(20, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(20, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(21, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(21, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(21, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(21, "< 20 yrs", "present", 8);
                yield return new schizophrenia2(21, "< 20 yrs", "present", 10);
                yield return new schizophrenia2(22, "> 20 yrs", "absent", 0);
                yield return new schizophrenia2(22, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(22, "> 20 yrs", "present", 6);
                yield return new schizophrenia2(22, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(22, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(23, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(23, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(23, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(23, "< 20 yrs", "present", 8);
                yield return new schizophrenia2(23, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(24, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(24, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(24, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(24, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(24, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(25, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(25, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(25, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(25, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(25, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(26, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(26, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(26, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(26, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(26, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(27, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(27, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(27, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(27, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(27, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(28, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(28, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(28, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(28, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(28, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(29, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(29, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(29, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(29, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(29, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(30, "> 20 yrs", "absent", 0);
                yield return new schizophrenia2(30, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(30, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(30, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(30, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(31, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(31, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(31, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(31, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(31, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(32, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(32, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(32, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(32, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(32, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(33, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(33, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(33, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(33, "< 20 yrs", "present", 8);
                yield return new schizophrenia2(33, "< 20 yrs", "present", 10);
                yield return new schizophrenia2(34, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(34, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(34, "< 20 yrs", "present", 6);
                yield return new schizophrenia2(34, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(34, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(35, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(35, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(35, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(35, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(35, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(36, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(36, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(36, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(36, "> 20 yrs", null, 8);
                yield return new schizophrenia2(36, "> 20 yrs", null, 10);
                yield return new schizophrenia2(37, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(37, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(37, "< 20 yrs", null, 6);
                yield return new schizophrenia2(37, "< 20 yrs", null, 8);
                yield return new schizophrenia2(37, "< 20 yrs", null, 10);
                yield return new schizophrenia2(38, "> 20 yrs", "absent", 0);
                yield return new schizophrenia2(38, "> 20 yrs", "absent", 2);
                yield return new schizophrenia2(38, "> 20 yrs", "absent", 6);
                yield return new schizophrenia2(38, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(38, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(39, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(39, "< 20 yrs", null, 2);
                yield return new schizophrenia2(39, "< 20 yrs", null, 6);
                yield return new schizophrenia2(39, "< 20 yrs", null, 8);
                yield return new schizophrenia2(39, "< 20 yrs", null, 10);
                yield return new schizophrenia2(40, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(40, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(40, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(40, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(40, "< 20 yrs", "absent", 10);
                yield return new schizophrenia2(41, "> 20 yrs", "present", 0);
                yield return new schizophrenia2(41, "> 20 yrs", "present", 2);
                yield return new schizophrenia2(41, "> 20 yrs", "present", 6);
                yield return new schizophrenia2(41, "> 20 yrs", "absent", 8);
                yield return new schizophrenia2(41, "> 20 yrs", "absent", 10);
                yield return new schizophrenia2(42, "< 20 yrs", "absent", 0);
                yield return new schizophrenia2(42, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(42, "< 20 yrs", null, 6);
                yield return new schizophrenia2(42, "< 20 yrs", null, 8);
                yield return new schizophrenia2(42, "< 20 yrs", null, 10);
                yield return new schizophrenia2(43, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(43, "< 20 yrs", "absent", 2);
                yield return new schizophrenia2(43, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(43, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(43, "< 20 yrs", null, 10);
                yield return new schizophrenia2(44, "< 20 yrs", "present", 0);
                yield return new schizophrenia2(44, "< 20 yrs", "present", 2);
                yield return new schizophrenia2(44, "< 20 yrs", "absent", 6);
                yield return new schizophrenia2(44, "< 20 yrs", "absent", 8);
                yield return new schizophrenia2(44, "< 20 yrs", "absent", 10);
            }
        }
    }
}
