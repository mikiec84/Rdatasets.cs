// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Morphological Measurements on Leptograpsus Crabs
    /// </summary>

    public class crabs
    {
        public readonly string sp;
        public readonly string sex;
        public readonly int index;
        public readonly double FL;
        public readonly double RW;
        public readonly double CL;
        public readonly double CW;
        public readonly double BD;

        public crabs(string sp, string sex, int index, double FL, double RW, double CL, double CW, double BD)
        {
            this.sp = sp;
            this.sex = sex;
            this.index = index;
            this.FL = FL;
            this.RW = RW;
            this.CL = CL;
            this.CW = CW;
            this.BD = BD;
        }

        public static IEnumerable<crabs> Data
        {
            get
            {
                yield return new crabs("B", "M", 1, 8.1, 6.7, 16.1, 19, 7);
                yield return new crabs("B", "M", 2, 8.8, 7.7, 18.1, 20.8, 7.4);
                yield return new crabs("B", "M", 3, 9.2, 7.8, 19, 22.4, 7.7);
                yield return new crabs("B", "M", 4, 9.6, 7.9, 20.1, 23.1, 8.2);
                yield return new crabs("B", "M", 5, 9.8, 8, 20.3, 23, 8.2);
                yield return new crabs("B", "M", 6, 10.8, 9, 23, 26.5, 9.8);
                yield return new crabs("B", "M", 7, 11.1, 9.9, 23.8, 27.1, 9.8);
                yield return new crabs("B", "M", 8, 11.6, 9.1, 24.5, 28.4, 10.4);
                yield return new crabs("B", "M", 9, 11.8, 9.6, 24.2, 27.8, 9.7);
                yield return new crabs("B", "M", 10, 11.8, 10.5, 25.2, 29.3, 10.3);
                yield return new crabs("B", "M", 11, 12.2, 10.8, 27.3, 31.6, 10.9);
                yield return new crabs("B", "M", 12, 12.3, 11, 26.8, 31.5, 11.4);
                yield return new crabs("B", "M", 13, 12.6, 10, 27.7, 31.7, 11.4);
                yield return new crabs("B", "M", 14, 12.8, 10.2, 27.2, 31.8, 10.9);
                yield return new crabs("B", "M", 15, 12.8, 10.9, 27.4, 31.5, 11);
                yield return new crabs("B", "M", 16, 12.9, 11, 26.8, 30.9, 11.4);
                yield return new crabs("B", "M", 17, 13.1, 10.6, 28.2, 32.3, 11);
                yield return new crabs("B", "M", 18, 13.1, 10.9, 28.3, 32.4, 11.2);
                yield return new crabs("B", "M", 19, 13.3, 11.1, 27.8, 32.3, 11.3);
                yield return new crabs("B", "M", 20, 13.9, 11.1, 29.2, 33.3, 12.1);
                yield return new crabs("B", "M", 21, 14.3, 11.6, 31.3, 35.5, 12.7);
                yield return new crabs("B", "M", 22, 14.6, 11.3, 31.9, 36.4, 13.7);
                yield return new crabs("B", "M", 23, 15, 10.9, 31.4, 36.4, 13.2);
                yield return new crabs("B", "M", 24, 15, 11.5, 32.4, 37, 13.4);
                yield return new crabs("B", "M", 25, 15, 11.9, 32.5, 37.2, 13.6);
                yield return new crabs("B", "M", 26, 15.2, 12.1, 32.3, 36.7, 13.6);
                yield return new crabs("B", "M", 27, 15.4, 11.8, 33, 37.5, 13.6);
                yield return new crabs("B", "M", 28, 15.7, 12.6, 35.8, 40.3, 14.5);
                yield return new crabs("B", "M", 29, 15.9, 12.7, 34, 38.9, 14.2);
                yield return new crabs("B", "M", 30, 16.1, 11.6, 33.8, 39, 14.4);
                yield return new crabs("B", "M", 31, 16.1, 12.8, 34.9, 40.7, 15.7);
                yield return new crabs("B", "M", 32, 16.2, 13.3, 36, 41.7, 15.4);
                yield return new crabs("B", "M", 33, 16.3, 12.7, 35.6, 40.9, 14.9);
                yield return new crabs("B", "M", 34, 16.4, 13, 35.7, 41.8, 15.2);
                yield return new crabs("B", "M", 35, 16.6, 13.5, 38.1, 43.4, 14.9);
                yield return new crabs("B", "M", 36, 16.8, 12.8, 36.2, 41.8, 14.9);
                yield return new crabs("B", "M", 37, 16.9, 13.2, 37.3, 42.7, 15.6);
                yield return new crabs("B", "M", 38, 17.1, 12.6, 36.4, 42, 15.1);
                yield return new crabs("B", "M", 39, 17.1, 12.7, 36.7, 41.9, 15.6);
                yield return new crabs("B", "M", 40, 17.2, 13.5, 37.6, 43.9, 16.1);
                yield return new crabs("B", "M", 41, 17.7, 13.6, 38.7, 44.5, 16);
                yield return new crabs("B", "M", 42, 17.9, 14.1, 39.7, 44.6, 16.8);
                yield return new crabs("B", "M", 43, 18, 13.7, 39.2, 44.4, 16.2);
                yield return new crabs("B", "M", 44, 18.8, 15.8, 42.1, 49, 17.8);
                yield return new crabs("B", "M", 45, 19.3, 13.5, 41.6, 47.4, 17.8);
                yield return new crabs("B", "M", 46, 19.3, 13.8, 40.9, 46.5, 16.8);
                yield return new crabs("B", "M", 47, 19.7, 15.3, 41.9, 48.5, 17.8);
                yield return new crabs("B", "M", 48, 19.8, 14.2, 43.2, 49.7, 18.6);
                yield return new crabs("B", "M", 49, 19.8, 14.3, 42.4, 48.9, 18.3);
                yield return new crabs("B", "M", 50, 21.3, 15.7, 47.1, 54.6, 20);
                yield return new crabs("B", "F", 1, 7.2, 6.5, 14.7, 17.1, 6.1);
                yield return new crabs("B", "F", 2, 9, 8.5, 19.3, 22.7, 7.7);
                yield return new crabs("B", "F", 3, 9.1, 8.1, 18.5, 21.6, 7.7);
                yield return new crabs("B", "F", 4, 9.1, 8.2, 19.2, 22.2, 7.7);
                yield return new crabs("B", "F", 5, 9.5, 8.2, 19.6, 22.4, 7.8);
                yield return new crabs("B", "F", 6, 9.8, 8.9, 20.4, 23.9, 8.8);
                yield return new crabs("B", "F", 7, 10.1, 9.3, 20.9, 24.4, 8.4);
                yield return new crabs("B", "F", 8, 10.3, 9.5, 21.3, 24.7, 8.9);
                yield return new crabs("B", "F", 9, 10.4, 9.7, 21.7, 25.4, 8.3);
                yield return new crabs("B", "F", 10, 10.8, 9.5, 22.5, 26.3, 9.1);
                yield return new crabs("B", "F", 11, 11, 9.8, 22.5, 25.7, 8.2);
                yield return new crabs("B", "F", 12, 11.2, 10, 22.8, 26.9, 9.4);
                yield return new crabs("B", "F", 13, 11.5, 11, 24.7, 29.2, 10.1);
                yield return new crabs("B", "F", 14, 11.6, 11, 24.6, 28.5, 10.4);
                yield return new crabs("B", "F", 15, 11.6, 11.4, 23.7, 27.7, 10);
                yield return new crabs("B", "F", 16, 11.7, 10.6, 24.9, 28.5, 10.4);
                yield return new crabs("B", "F", 17, 11.9, 11.4, 26, 30.1, 10.9);
                yield return new crabs("B", "F", 18, 12, 10.7, 24.6, 28.9, 10.5);
                yield return new crabs("B", "F", 19, 12, 11.1, 25.4, 29.2, 11);
                yield return new crabs("B", "F", 20, 12.6, 12.2, 26.1, 31.6, 11.2);
                yield return new crabs("B", "F", 21, 12.8, 11.7, 27.1, 31.2, 11.9);
                yield return new crabs("B", "F", 22, 12.8, 12.2, 26.7, 31.1, 11.1);
                yield return new crabs("B", "F", 23, 12.8, 12.2, 27.9, 31.9, 11.5);
                yield return new crabs("B", "F", 24, 13, 11.4, 27.3, 31.8, 11.3);
                yield return new crabs("B", "F", 25, 13.1, 11.5, 27.6, 32.6, 11.1);
                yield return new crabs("B", "F", 26, 13.2, 12.2, 27.9, 32.1, 11.5);
                yield return new crabs("B", "F", 27, 13.4, 11.8, 28.4, 32.7, 11.7);
                yield return new crabs("B", "F", 28, 13.7, 12.5, 28.6, 33.8, 11.9);
                yield return new crabs("B", "F", 29, 13.9, 13, 30, 34.9, 13.1);
                yield return new crabs("B", "F", 30, 14.7, 12.5, 30.1, 34.7, 12.5);
                yield return new crabs("B", "F", 31, 14.9, 13.2, 30.1, 35.6, 12);
                yield return new crabs("B", "F", 32, 15, 13.8, 31.7, 36.9, 14);
                yield return new crabs("B", "F", 33, 15, 14.2, 32.8, 37.4, 14);
                yield return new crabs("B", "F", 34, 15.1, 13.3, 31.8, 36.3, 13.5);
                yield return new crabs("B", "F", 35, 15.1, 13.5, 31.9, 37, 13.8);
                yield return new crabs("B", "F", 36, 15.1, 13.8, 31.7, 36.6, 13);
                yield return new crabs("B", "F", 37, 15.2, 14.3, 33.9, 38.5, 14.7);
                yield return new crabs("B", "F", 38, 15.3, 14.2, 32.6, 38.3, 13.8);
                yield return new crabs("B", "F", 39, 15.4, 13.3, 32.4, 37.6, 13.8);
                yield return new crabs("B", "F", 40, 15.5, 13.8, 33.4, 38.7, 14.7);
                yield return new crabs("B", "F", 41, 15.6, 13.9, 32.8, 37.9, 13.4);
                yield return new crabs("B", "F", 42, 15.6, 14.7, 33.9, 39.5, 14.3);
                yield return new crabs("B", "F", 43, 15.7, 13.9, 33.6, 38.5, 14.1);
                yield return new crabs("B", "F", 44, 15.8, 15, 34.5, 40.3, 15.3);
                yield return new crabs("B", "F", 45, 16.2, 15.2, 34.5, 40.1, 13.9);
                yield return new crabs("B", "F", 46, 16.4, 14, 34.2, 39.8, 15.2);
                yield return new crabs("B", "F", 47, 16.7, 16.1, 36.6, 41.9, 15.4);
                yield return new crabs("B", "F", 48, 17.4, 16.9, 38.2, 44.1, 16.6);
                yield return new crabs("B", "F", 49, 17.5, 16.7, 38.6, 44.5, 17);
                yield return new crabs("B", "F", 50, 19.2, 16.5, 40.9, 47.9, 18.1);
                yield return new crabs("O", "M", 1, 9.1, 6.9, 16.7, 18.6, 7.4);
                yield return new crabs("O", "M", 2, 10.2, 8.2, 20.2, 22.2, 9);
                yield return new crabs("O", "M", 3, 10.7, 8.6, 20.7, 22.7, 9.2);
                yield return new crabs("O", "M", 4, 11.4, 9, 22.7, 24.8, 10.1);
                yield return new crabs("O", "M", 5, 12.5, 9.4, 23.2, 26, 10.8);
                yield return new crabs("O", "M", 6, 12.5, 9.4, 24.2, 27, 11.2);
                yield return new crabs("O", "M", 7, 12.7, 10.4, 26, 28.8, 12.1);
                yield return new crabs("O", "M", 8, 13.2, 11, 27.1, 30.4, 12.2);
                yield return new crabs("O", "M", 9, 13.4, 10.1, 26.6, 29.6, 12);
                yield return new crabs("O", "M", 10, 13.7, 11, 27.5, 30.5, 12.2);
                yield return new crabs("O", "M", 11, 14, 11.5, 29.2, 32.2, 13.1);
                yield return new crabs("O", "M", 12, 14.1, 10.4, 28.9, 31.8, 13.5);
                yield return new crabs("O", "M", 13, 14.1, 10.5, 29.1, 31.6, 13.1);
                yield return new crabs("O", "M", 14, 14.1, 10.7, 28.7, 31.9, 13.3);
                yield return new crabs("O", "M", 15, 14.2, 10.6, 28.7, 31.7, 12.9);
                yield return new crabs("O", "M", 16, 14.2, 10.7, 27.8, 30.9, 12.7);
                yield return new crabs("O", "M", 17, 14.2, 11.3, 29.2, 32.2, 13.5);
                yield return new crabs("O", "M", 18, 14.6, 11.3, 29.9, 33.5, 12.8);
                yield return new crabs("O", "M", 19, 14.7, 11.1, 29, 32.1, 13.1);
                yield return new crabs("O", "M", 20, 15.1, 11.4, 30.2, 33.3, 14);
                yield return new crabs("O", "M", 21, 15.1, 11.5, 30.9, 34, 13.9);
                yield return new crabs("O", "M", 22, 15.4, 11.1, 30.2, 33.6, 13.5);
                yield return new crabs("O", "M", 23, 15.7, 12.2, 31.7, 34.2, 14.2);
                yield return new crabs("O", "M", 24, 16.2, 11.8, 32.3, 35.3, 14.7);
                yield return new crabs("O", "M", 25, 16.3, 11.6, 31.6, 34.2, 14.5);
                yield return new crabs("O", "M", 26, 17.1, 12.6, 35, 38.9, 15.7);
                yield return new crabs("O", "M", 27, 17.4, 12.8, 36.1, 39.5, 16.2);
                yield return new crabs("O", "M", 28, 17.5, 12, 34.4, 37.3, 15.3);
                yield return new crabs("O", "M", 29, 17.5, 12.7, 34.6, 38.4, 16.1);
                yield return new crabs("O", "M", 30, 17.8, 12.5, 36, 39.8, 16.7);
                yield return new crabs("O", "M", 31, 17.9, 12.9, 36.9, 40.9, 16.5);
                yield return new crabs("O", "M", 32, 18, 13.4, 36.7, 41.3, 17.1);
                yield return new crabs("O", "M", 33, 18.2, 13.7, 38.8, 42.7, 17.2);
                yield return new crabs("O", "M", 34, 18.4, 13.4, 37.9, 42.2, 17.7);
                yield return new crabs("O", "M", 35, 18.6, 13.4, 37.8, 41.9, 17.3);
                yield return new crabs("O", "M", 36, 18.6, 13.5, 36.9, 40.2, 17);
                yield return new crabs("O", "M", 37, 18.8, 13.4, 37.2, 41.1, 17.5);
                yield return new crabs("O", "M", 38, 18.8, 13.8, 39.2, 43.3, 17.9);
                yield return new crabs("O", "M", 39, 19.4, 14.1, 39.1, 43.2, 17.8);
                yield return new crabs("O", "M", 40, 19.4, 14.4, 39.8, 44.3, 17.9);
                yield return new crabs("O", "M", 41, 20.1, 13.7, 40.6, 44.5, 18);
                yield return new crabs("O", "M", 42, 20.6, 14.4, 42.8, 46.5, 19.6);
                yield return new crabs("O", "M", 43, 21, 15, 42.9, 47.2, 19.4);
                yield return new crabs("O", "M", 44, 21.5, 15.5, 45.5, 49.7, 20.9);
                yield return new crabs("O", "M", 45, 21.6, 15.4, 45.7, 49.7, 20.6);
                yield return new crabs("O", "M", 46, 21.6, 14.8, 43.4, 48.2, 20.1);
                yield return new crabs("O", "M", 47, 21.9, 15.7, 45.4, 51, 21.1);
                yield return new crabs("O", "M", 48, 22.1, 15.8, 44.6, 49.6, 20.5);
                yield return new crabs("O", "M", 49, 23, 16.8, 47.2, 52.1, 21.5);
                yield return new crabs("O", "M", 50, 23.1, 15.7, 47.6, 52.8, 21.6);
                yield return new crabs("O", "F", 1, 10.7, 9.7, 21.4, 24, 9.8);
                yield return new crabs("O", "F", 2, 11.4, 9.2, 21.7, 24.1, 9.7);
                yield return new crabs("O", "F", 3, 12.5, 10, 24.1, 27, 10.9);
                yield return new crabs("O", "F", 4, 12.6, 11.5, 25, 28.1, 11.5);
                yield return new crabs("O", "F", 5, 12.9, 11.2, 25.8, 29.1, 11.9);
                yield return new crabs("O", "F", 6, 14, 11.9, 27, 31.4, 12.6);
                yield return new crabs("O", "F", 7, 14, 12.8, 28.8, 32.4, 12.7);
                yield return new crabs("O", "F", 8, 14.3, 12.2, 28.1, 31.8, 12.5);
                yield return new crabs("O", "F", 9, 14.7, 13.2, 29.6, 33.4, 12.9);
                yield return new crabs("O", "F", 10, 14.9, 13, 30, 33.7, 13.3);
                yield return new crabs("O", "F", 11, 15, 12.3, 30.1, 33.3, 14);
                yield return new crabs("O", "F", 12, 15.6, 13.5, 31.2, 35.1, 14.1);
                yield return new crabs("O", "F", 13, 15.6, 14, 31.6, 35.3, 13.8);
                yield return new crabs("O", "F", 14, 15.6, 14.1, 31, 34.5, 13.8);
                yield return new crabs("O", "F", 15, 15.7, 13.6, 31, 34.8, 13.8);
                yield return new crabs("O", "F", 16, 16.1, 13.6, 31.6, 36, 14);
                yield return new crabs("O", "F", 17, 16.1, 13.7, 31.4, 36.1, 13.9);
                yield return new crabs("O", "F", 18, 16.2, 14, 31.6, 35.6, 13.7);
                yield return new crabs("O", "F", 19, 16.7, 14.3, 32.3, 37, 14.7);
                yield return new crabs("O", "F", 20, 17.1, 14.5, 33.1, 37.2, 14.6);
                yield return new crabs("O", "F", 21, 17.5, 14.3, 34.5, 39.6, 15.6);
                yield return new crabs("O", "F", 22, 17.5, 14.4, 34.5, 39, 16);
                yield return new crabs("O", "F", 23, 17.5, 14.7, 33.3, 37.6, 14.6);
                yield return new crabs("O", "F", 24, 17.6, 14, 34, 38.6, 15.5);
                yield return new crabs("O", "F", 25, 18, 14.9, 34.7, 39.5, 15.7);
                yield return new crabs("O", "F", 26, 18, 16.3, 37.9, 43, 17.2);
                yield return new crabs("O", "F", 27, 18.3, 15.7, 35.1, 40.5, 16.1);
                yield return new crabs("O", "F", 28, 18.4, 15.5, 35.6, 40, 15.9);
                yield return new crabs("O", "F", 29, 18.4, 15.7, 36.5, 41.6, 16.4);
                yield return new crabs("O", "F", 30, 18.5, 14.6, 37, 42, 16.6);
                yield return new crabs("O", "F", 31, 18.6, 14.5, 34.7, 39.4, 15);
                yield return new crabs("O", "F", 32, 18.8, 15.2, 35.8, 40.5, 16.6);
                yield return new crabs("O", "F", 33, 18.9, 16.7, 36.3, 41.7, 15.3);
                yield return new crabs("O", "F", 34, 19.1, 16, 37.8, 42.3, 16.8);
                yield return new crabs("O", "F", 35, 19.1, 16.3, 37.9, 42.6, 17.2);
                yield return new crabs("O", "F", 36, 19.7, 16.7, 39.9, 43.6, 18.2);
                yield return new crabs("O", "F", 37, 19.9, 16.6, 39.4, 43.9, 17.9);
                yield return new crabs("O", "F", 38, 19.9, 17.9, 40.1, 46.4, 17.9);
                yield return new crabs("O", "F", 39, 20, 16.7, 40.4, 45.1, 17.7);
                yield return new crabs("O", "F", 40, 20.1, 17.2, 39.8, 44.1, 18.6);
                yield return new crabs("O", "F", 41, 20.3, 16, 39.4, 44.1, 18);
                yield return new crabs("O", "F", 42, 20.5, 17.5, 40, 45.5, 19.2);
                yield return new crabs("O", "F", 43, 20.6, 17.5, 41.5, 46.2, 19.2);
                yield return new crabs("O", "F", 44, 20.9, 16.5, 39.9, 44.7, 17.5);
                yield return new crabs("O", "F", 45, 21.3, 18.4, 43.8, 48.4, 20);
                yield return new crabs("O", "F", 46, 21.4, 18, 41.2, 46.2, 18.7);
                yield return new crabs("O", "F", 47, 21.7, 17.1, 41.7, 47.2, 19.6);
                yield return new crabs("O", "F", 48, 21.9, 17.2, 42.6, 47.4, 19.5);
                yield return new crabs("O", "F", 49, 22.5, 17.2, 43, 48.7, 19.8);
                yield return new crabs("O", "F", 50, 23.1, 20.2, 46.2, 52.5, 21.1);
            }
        }
    }
}
