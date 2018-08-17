// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.8
    /// </summary>

    public class larynx
    {
        public readonly int stage;
        public readonly double time;
        public readonly int age;
        public readonly int diagyr;
        public readonly int delta;

        public larynx(int stage, double time, int age, int diagyr, int delta)
        {
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
                yield return new larynx(1, 0.6, 77, 76, 1);
                yield return new larynx(1, 1.3, 53, 71, 1);
                yield return new larynx(1, 2.4, 45, 71, 1);
                yield return new larynx(1, 2.5, 57, 78, 0);
                yield return new larynx(1, 3.2, 58, 74, 1);
                yield return new larynx(1, 3.2, 51, 77, 0);
                yield return new larynx(1, 3.3, 76, 74, 1);
                yield return new larynx(1, 3.3, 63, 77, 0);
                yield return new larynx(1, 3.5, 43, 71, 1);
                yield return new larynx(1, 3.5, 60, 73, 1);
                yield return new larynx(1, 4, 52, 71, 1);
                yield return new larynx(1, 4, 63, 76, 1);
                yield return new larynx(1, 4.3, 86, 74, 1);
                yield return new larynx(1, 4.5, 48, 76, 0);
                yield return new larynx(1, 4.5, 68, 76, 0);
                yield return new larynx(1, 5.3, 81, 72, 1);
                yield return new larynx(1, 5.5, 70, 75, 0);
                yield return new larynx(1, 5.9, 58, 75, 0);
                yield return new larynx(1, 5.9, 47, 75, 0);
                yield return new larynx(1, 6, 75, 73, 1);
                yield return new larynx(1, 6.1, 77, 75, 0);
                yield return new larynx(1, 6.2, 64, 75, 0);
                yield return new larynx(1, 6.4, 77, 72, 1);
                yield return new larynx(1, 6.5, 67, 70, 1);
                yield return new larynx(1, 6.5, 79, 74, 0);
                yield return new larynx(1, 6.7, 61, 74, 0);
                yield return new larynx(1, 7, 66, 74, 0);
                yield return new larynx(1, 7.4, 68, 71, 1);
                yield return new larynx(1, 7.4, 73, 73, 0);
                yield return new larynx(1, 8.1, 56, 73, 0);
                yield return new larynx(1, 8.1, 73, 73, 0);
                yield return new larynx(1, 9.6, 58, 71, 0);
                yield return new larynx(1, 10.7, 68, 70, 0);
                yield return new larynx(2, 0.2, 86, 74, 1);
                yield return new larynx(2, 1.8, 64, 77, 1);
                yield return new larynx(2, 2, 63, 75, 1);
                yield return new larynx(2, 2.2, 71, 78, 0);
                yield return new larynx(2, 2.6, 67, 78, 0);
                yield return new larynx(2, 3.3, 51, 77, 0);
                yield return new larynx(2, 3.6, 70, 77, 1);
                yield return new larynx(2, 3.6, 72, 77, 0);
                yield return new larynx(2, 4, 81, 71, 1);
                yield return new larynx(2, 4.3, 47, 76, 0);
                yield return new larynx(2, 4.3, 64, 76, 0);
                yield return new larynx(2, 5, 66, 76, 0);
                yield return new larynx(2, 6.2, 74, 72, 1);
                yield return new larynx(2, 7, 62, 73, 1);
                yield return new larynx(2, 7.5, 50, 73, 0);
                yield return new larynx(2, 7.6, 53, 73, 0);
                yield return new larynx(2, 9.3, 61, 71, 0);
                yield return new larynx(3, 0.3, 49, 72, 1);
                yield return new larynx(3, 0.3, 71, 76, 1);
                yield return new larynx(3, 0.5, 57, 74, 1);
                yield return new larynx(3, 0.7, 79, 77, 1);
                yield return new larynx(3, 0.8, 82, 74, 1);
                yield return new larynx(3, 1, 49, 76, 1);
                yield return new larynx(3, 1.3, 60, 76, 1);
                yield return new larynx(3, 1.6, 64, 72, 1);
                yield return new larynx(3, 1.8, 74, 71, 1);
                yield return new larynx(3, 1.9, 72, 74, 1);
                yield return new larynx(3, 1.9, 53, 74, 1);
                yield return new larynx(3, 3.2, 54, 75, 1);
                yield return new larynx(3, 3.5, 81, 74, 1);
                yield return new larynx(3, 3.7, 52, 77, 0);
                yield return new larynx(3, 4.5, 66, 76, 0);
                yield return new larynx(3, 4.8, 54, 76, 0);
                yield return new larynx(3, 4.8, 63, 76, 0);
                yield return new larynx(3, 5, 59, 73, 1);
                yield return new larynx(3, 5, 49, 76, 0);
                yield return new larynx(3, 5.1, 69, 76, 0);
                yield return new larynx(3, 6.3, 70, 72, 1);
                yield return new larynx(3, 6.4, 65, 72, 1);
                yield return new larynx(3, 6.5, 65, 74, 0);
                yield return new larynx(3, 7.8, 68, 72, 1);
                yield return new larynx(3, 8, 78, 73, 0);
                yield return new larynx(3, 9.3, 69, 71, 0);
                yield return new larynx(3, 10.1, 51, 71, 0);
                yield return new larynx(4, 0.1, 65, 72, 1);
                yield return new larynx(4, 0.3, 71, 76, 1);
                yield return new larynx(4, 0.4, 76, 77, 1);
                yield return new larynx(4, 0.8, 65, 76, 1);
                yield return new larynx(4, 0.8, 78, 77, 1);
                yield return new larynx(4, 1, 41, 77, 1);
                yield return new larynx(4, 1.5, 68, 73, 1);
                yield return new larynx(4, 2, 69, 76, 1);
                yield return new larynx(4, 2.3, 62, 71, 1);
                yield return new larynx(4, 2.9, 74, 78, 0);
                yield return new larynx(4, 3.6, 71, 75, 1);
                yield return new larynx(4, 3.8, 84, 74, 1);
                yield return new larynx(4, 4.3, 48, 76, 0);
            }
        }
    }
}
