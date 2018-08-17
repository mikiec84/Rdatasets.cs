// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Familial Andenomatous Polyposis
    /// </summary>

    public class polyps3
    {
        public readonly string sex;
        public readonly string treatment;
        public readonly int baseline;
        public readonly int age;
        public readonly int number3m;

        public polyps3(string sex, string treatment, int baseline, int age, int number3m)
        {
            this.sex = sex;
            this.treatment = treatment;
            this.baseline = baseline;
            this.age = age;
            this.number3m = number3m;
        }

        public static IEnumerable<polyps3> Data
        {
            get
            {
                yield return new polyps3("female", "active", 7, 17, 6);
                yield return new polyps3("female", "placebo", 77, 20, 67);
                yield return new polyps3("male", "active", 7, 16, 4);
                yield return new polyps3("female", "placebo", 5, 18, 5);
                yield return new polyps3("male", "active", 23, 22, 16);
                yield return new polyps3("female", "placebo", 35, 13, 31);
                yield return new polyps3("female", "active", 11, 23, 6);
                yield return new polyps3("male", "placebo", 12, 34, 20);
                yield return new polyps3("male", "placebo", 7, 50, 7);
                yield return new polyps3("male", "placebo", 318, 19, 347);
                yield return new polyps3("male", "active", 160, 17, 142);
                yield return new polyps3("female", "active", 8, 23, 1);
                yield return new polyps3("male", "placebo", 20, 22, 16);
                yield return new polyps3("male", "placebo", 11, 30, 20);
                yield return new polyps3("male", "placebo", 24, 27, 26);
                yield return new polyps3("male", "active", 34, 23, 27);
                yield return new polyps3("female", "placebo", 54, 22, 45);
                yield return new polyps3("male", "active", 16, 13, 10);
                yield return new polyps3("male", "placebo", 30, 34, 30);
                yield return new polyps3("female", "active", 10, 23, 6);
                yield return new polyps3("female", "active", 20, 22, 5);
                yield return new polyps3("male", "active", 12, 42, 8);
            }
        }
    }
}
