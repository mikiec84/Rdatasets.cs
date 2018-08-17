// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of Swedish Speed Limits on Accidents
    /// </summary>

    public class Traffic
    {
        public readonly int year;
        public readonly int day;
        public readonly string limit;
        public readonly int y;

        public Traffic(int year, int day, string limit, int y)
        {
            this.year = year;
            this.day = day;
            this.limit = limit;
            this.y = y;
        }

        public static IEnumerable<Traffic> Data
        {
            get
            {
                yield return new Traffic(1961, 1, "no", 9);
                yield return new Traffic(1961, 2, "no", 11);
                yield return new Traffic(1961, 3, "no", 9);
                yield return new Traffic(1961, 4, "no", 20);
                yield return new Traffic(1961, 5, "no", 31);
                yield return new Traffic(1961, 6, "no", 26);
                yield return new Traffic(1961, 7, "no", 18);
                yield return new Traffic(1961, 8, "no", 19);
                yield return new Traffic(1961, 9, "no", 18);
                yield return new Traffic(1961, 10, "no", 13);
                yield return new Traffic(1961, 11, "no", 29);
                yield return new Traffic(1961, 12, "no", 40);
                yield return new Traffic(1961, 13, "no", 28);
                yield return new Traffic(1961, 14, "no", 17);
                yield return new Traffic(1961, 15, "no", 15);
                yield return new Traffic(1961, 16, "no", 21);
                yield return new Traffic(1961, 17, "no", 24);
                yield return new Traffic(1961, 18, "no", 15);
                yield return new Traffic(1961, 19, "no", 32);
                yield return new Traffic(1961, 20, "no", 22);
                yield return new Traffic(1961, 21, "no", 24);
                yield return new Traffic(1961, 22, "no", 11);
                yield return new Traffic(1961, 23, "no", 27);
                yield return new Traffic(1961, 24, "yes", 12);
                yield return new Traffic(1961, 25, "yes", 41);
                yield return new Traffic(1961, 26, "yes", 15);
                yield return new Traffic(1961, 27, "yes", 18);
                yield return new Traffic(1961, 28, "yes", 11);
                yield return new Traffic(1961, 29, "yes", 19);
                yield return new Traffic(1961, 30, "yes", 19);
                yield return new Traffic(1961, 31, "yes", 9);
                yield return new Traffic(1961, 32, "yes", 21);
                yield return new Traffic(1961, 33, "yes", 22);
                yield return new Traffic(1961, 34, "yes", 23);
                yield return new Traffic(1961, 35, "yes", 14);
                yield return new Traffic(1961, 36, "yes", 19);
                yield return new Traffic(1961, 37, "yes", 15);
                yield return new Traffic(1961, 38, "yes", 13);
                yield return new Traffic(1961, 39, "yes", 22);
                yield return new Traffic(1961, 40, "yes", 42);
                yield return new Traffic(1961, 41, "yes", 29);
                yield return new Traffic(1961, 42, "yes", 21);
                yield return new Traffic(1961, 43, "yes", 12);
                yield return new Traffic(1961, 44, "yes", 16);
                yield return new Traffic(1961, 45, "no", 17);
                yield return new Traffic(1961, 46, "no", 27);
                yield return new Traffic(1961, 47, "no", 37);
                yield return new Traffic(1961, 48, "no", 32);
                yield return new Traffic(1961, 49, "no", 25);
                yield return new Traffic(1961, 50, "no", 20);
                yield return new Traffic(1961, 51, "no", 40);
                yield return new Traffic(1961, 52, "no", 21);
                yield return new Traffic(1961, 53, "no", 18);
                yield return new Traffic(1961, 54, "no", 35);
                yield return new Traffic(1961, 55, "no", 21);
                yield return new Traffic(1961, 56, "no", 25);
                yield return new Traffic(1961, 57, "no", 34);
                yield return new Traffic(1961, 58, "no", 42);
                yield return new Traffic(1961, 59, "no", 27);
                yield return new Traffic(1961, 60, "no", 34);
                yield return new Traffic(1961, 61, "no", 47);
                yield return new Traffic(1961, 62, "no", 36);
                yield return new Traffic(1961, 63, "no", 15);
                yield return new Traffic(1961, 64, "no", 26);
                yield return new Traffic(1961, 65, "no", 27);
                yield return new Traffic(1961, 66, "no", 18);
                yield return new Traffic(1961, 67, "no", 16);
                yield return new Traffic(1961, 68, "no", 32);
                yield return new Traffic(1961, 69, "no", 28);
                yield return new Traffic(1961, 70, "no", 17);
                yield return new Traffic(1961, 71, "no", 16);
                yield return new Traffic(1961, 72, "no", 19);
                yield return new Traffic(1961, 73, "no", 18);
                yield return new Traffic(1961, 74, "no", 22);
                yield return new Traffic(1961, 75, "no", 37);
                yield return new Traffic(1961, 76, "no", 29);
                yield return new Traffic(1961, 77, "no", 18);
                yield return new Traffic(1961, 78, "no", 14);
                yield return new Traffic(1961, 79, "no", 14);
                yield return new Traffic(1961, 80, "no", 18);
                yield return new Traffic(1961, 81, "no", 21);
                yield return new Traffic(1961, 82, "no", 39);
                yield return new Traffic(1961, 83, "no", 39);
                yield return new Traffic(1961, 84, "no", 21);
                yield return new Traffic(1961, 85, "no", 15);
                yield return new Traffic(1961, 86, "no", 17);
                yield return new Traffic(1961, 87, "no", 20);
                yield return new Traffic(1961, 88, "no", 24);
                yield return new Traffic(1961, 89, "no", 30);
                yield return new Traffic(1961, 90, "no", 25);
                yield return new Traffic(1961, 91, "no", 8);
                yield return new Traffic(1961, 92, "no", 21);
                yield return new Traffic(1962, 1, "no", 9);
                yield return new Traffic(1962, 2, "no", 20);
                yield return new Traffic(1962, 3, "no", 15);
                yield return new Traffic(1962, 4, "no", 14);
                yield return new Traffic(1962, 5, "no", 30);
                yield return new Traffic(1962, 6, "no", 23);
                yield return new Traffic(1962, 7, "no", 15);
                yield return new Traffic(1962, 8, "no", 14);
                yield return new Traffic(1962, 9, "no", 16);
                yield return new Traffic(1962, 10, "no", 20);
                yield return new Traffic(1962, 11, "yes", 17);
                yield return new Traffic(1962, 12, "yes", 23);
                yield return new Traffic(1962, 13, "yes", 16);
                yield return new Traffic(1962, 14, "yes", 20);
                yield return new Traffic(1962, 15, "yes", 13);
                yield return new Traffic(1962, 16, "yes", 13);
                yield return new Traffic(1962, 17, "yes", 9);
                yield return new Traffic(1962, 18, "yes", 10);
                yield return new Traffic(1962, 19, "yes", 27);
                yield return new Traffic(1962, 20, "yes", 12);
                yield return new Traffic(1962, 21, "yes", 7);
                yield return new Traffic(1962, 22, "yes", 11);
                yield return new Traffic(1962, 23, "yes", 15);
                yield return new Traffic(1962, 24, "yes", 19);
                yield return new Traffic(1962, 25, "yes", 32);
                yield return new Traffic(1962, 26, "yes", 22);
                yield return new Traffic(1962, 27, "yes", 24);
                yield return new Traffic(1962, 28, "yes", 9);
                yield return new Traffic(1962, 29, "no", 10);
                yield return new Traffic(1962, 30, "no", 14);
                yield return new Traffic(1962, 31, "no", 18);
                yield return new Traffic(1962, 32, "no", 26);
                yield return new Traffic(1962, 33, "no", 38);
                yield return new Traffic(1962, 34, "no", 31);
                yield return new Traffic(1962, 35, "no", 12);
                yield return new Traffic(1962, 36, "no", 8);
                yield return new Traffic(1962, 37, "no", 22);
                yield return new Traffic(1962, 38, "no", 17);
                yield return new Traffic(1962, 39, "no", 31);
                yield return new Traffic(1962, 40, "no", 49);
                yield return new Traffic(1962, 41, "no", 23);
                yield return new Traffic(1962, 42, "no", 14);
                yield return new Traffic(1962, 43, "no", 25);
                yield return new Traffic(1962, 44, "no", 24);
                yield return new Traffic(1962, 45, "no", 18);
                yield return new Traffic(1962, 46, "no", 19);
                yield return new Traffic(1962, 47, "yes", 29);
                yield return new Traffic(1962, 48, "yes", 17);
                yield return new Traffic(1962, 49, "yes", 17);
                yield return new Traffic(1962, 50, "yes", 15);
                yield return new Traffic(1962, 51, "yes", 25);
                yield return new Traffic(1962, 52, "yes", 9);
                yield return new Traffic(1962, 53, "yes", 16);
                yield return new Traffic(1962, 54, "yes", 25);
                yield return new Traffic(1962, 55, "yes", 25);
                yield return new Traffic(1962, 56, "yes", 16);
                yield return new Traffic(1962, 57, "yes", 22);
                yield return new Traffic(1962, 58, "yes", 21);
                yield return new Traffic(1962, 59, "yes", 17);
                yield return new Traffic(1962, 60, "yes", 26);
                yield return new Traffic(1962, 61, "yes", 41);
                yield return new Traffic(1962, 62, "yes", 25);
                yield return new Traffic(1962, 63, "yes", 12);
                yield return new Traffic(1962, 64, "yes", 17);
                yield return new Traffic(1962, 65, "no", 21);
                yield return new Traffic(1962, 66, "no", 19);
                yield return new Traffic(1962, 67, "no", 24);
                yield return new Traffic(1962, 68, "no", 44);
                yield return new Traffic(1962, 69, "no", 31);
                yield return new Traffic(1962, 70, "no", 21);
                yield return new Traffic(1962, 71, "no", 20);
                yield return new Traffic(1962, 72, "no", 19);
                yield return new Traffic(1962, 73, "no", 20);
                yield return new Traffic(1962, 74, "no", 29);
                yield return new Traffic(1962, 75, "no", 48);
                yield return new Traffic(1962, 76, "no", 36);
                yield return new Traffic(1962, 77, "no", 15);
                yield return new Traffic(1962, 78, "no", 16);
                yield return new Traffic(1962, 79, "no", 29);
                yield return new Traffic(1962, 80, "no", 12);
                yield return new Traffic(1962, 81, "yes", 24);
                yield return new Traffic(1962, 82, "yes", 26);
                yield return new Traffic(1962, 83, "yes", 16);
                yield return new Traffic(1962, 84, "yes", 15);
                yield return new Traffic(1962, 85, "yes", 12);
                yield return new Traffic(1962, 86, "yes", 22);
                yield return new Traffic(1962, 87, "yes", 24);
                yield return new Traffic(1962, 88, "yes", 16);
                yield return new Traffic(1962, 89, "yes", 25);
                yield return new Traffic(1962, 90, "yes", 14);
                yield return new Traffic(1962, 91, "yes", 15);
                yield return new Traffic(1962, 92, "yes", 9);
            }
        }
    }
}
