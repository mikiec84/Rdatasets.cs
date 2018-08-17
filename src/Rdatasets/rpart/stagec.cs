// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Stage C Prostate Cancer
    /// </summary>

    public class stagec
    {
        public readonly double pgtime;
        public readonly int pgstat;
        public readonly int age;
        public readonly string eet;
        public readonly string g2;
        public readonly int grade;
        public readonly string gleason;
        public readonly string ploidy;

        public stagec(double pgtime, int pgstat, int age, string eet, string g2, int grade, string gleason, string ploidy)
        {
            this.pgtime = pgtime;
            this.pgstat = pgstat;
            this.age = age;
            this.eet = eet;
            this.g2 = g2;
            this.grade = grade;
            this.gleason = gleason;
            this.ploidy = ploidy;
        }

        public static IEnumerable<stagec> Data
        {
            get
            {
                yield return new stagec(6.1, 0, 64, "2", "10.26", 2, "4", "diploid");
                yield return new stagec(9.4, 0, 62, "1", null, 3, "8", "aneuploid");
                yield return new stagec(5.2, 1, 59, "2", "9.99", 3, "7", "diploid");
                yield return new stagec(3.2, 1, 62, "2", "3.57", 2, "4", "diploid");
                yield return new stagec(1.9, 1, 64, "2", "22.56", 4, "8", "tetraploid");
                yield return new stagec(4.8, 0, 69, "1", "6.14", 3, "7", "diploid");
                yield return new stagec(5.8, 0, 75, "2", "13.69", 2, null, "tetraploid");
                yield return new stagec(7.3, 0, 71, "2", null, 3, "7", "aneuploid");
                yield return new stagec(3.7, 1, 73, "2", "11.77", 3, "6", "diploid");
                yield return new stagec(15.9, 0, 64, "2", "27.27", 3, "7", "tetraploid");
                yield return new stagec(6.3, 0, 65, "2", "19.34", 3, "7", "tetraploid");
                yield return new stagec(2.9, 1, 58, "2", "14.82", 4, "8", "tetraploid");
                yield return new stagec(1.5, 1, 70, "2", "10.22", 3, "8", "diploid");
                yield return new stagec(14.5, 0, 67, "2", "15.66", 2, "6", "tetraploid");
                yield return new stagec(4.2, 1, 66, "2", "17.79", 3, "7", "tetraploid");
                yield return new stagec(1.7, 1, 74, "2", "11.11", 3, "8", "diploid");
                yield return new stagec(5, 0, 70, "2", "11.44", 2, "5", "diploid");
                yield return new stagec(13.2, 0, 57, "2", "14.78", 2, "4", "tetraploid");
                yield return new stagec(10.9, 0, 63, "2", "54.93", 3, "8", "tetraploid");
                yield return new stagec(13, 0, 65, "2", "24.58", 3, "7", "tetraploid");
                yield return new stagec(11.4, 0, 62, "2", "27.79", 2, "5", "tetraploid");
                yield return new stagec(2.6, 1, 72, "2", "14.86", 3, "6", "tetraploid");
                yield return new stagec(9.8, 0, 64, "1", "10.51", 2, "5", "diploid");
                yield return new stagec(3.4, 1, 67, null, "14.22", 2, "6", "tetraploid");
                yield return new stagec(7.6, 1, 64, "2", "15.28", 2, "5", "tetraploid");
                yield return new stagec(4.8, 1, 70, "2", "16.91", 3, "6", "tetraploid");
                yield return new stagec(3.7, 1, 58, "1", "17.87", 3, "7", "tetraploid");
                yield return new stagec(13.9, 0, 57, "2", "12.13", 3, "6", "diploid");
                yield return new stagec(4.9, 1, 54, "1", "17.25", 2, "5", "tetraploid");
                yield return new stagec(15.9, 0, 61, "1", "16.53", 3, "7", "tetraploid");
                yield return new stagec(2.9, 1, 68, "2", "17.49", 2, "4", "tetraploid");
                yield return new stagec(9.3, 0, 64, "1", "3.85", 3, "6", "aneuploid");
                yield return new stagec(6.5, 0, 70, "1", "7.88", 2, "6", "diploid");
                yield return new stagec(1.7, 0, 64, "2", "16.64", 2, "5", "tetraploid");
                yield return new stagec(6.9, 0, 66, "2", "13.19", 3, "7", "tetraploid");
                yield return new stagec(5.5, 0, 61, "2", "9.42", 2, "5", "diploid");
                yield return new stagec(5.7, 0, 70, "2", "22.79", 2, "5", "tetraploid");
                yield return new stagec(4.1, 1, 63, "2", "11.37", 2, "6", "diploid");
                yield return new stagec(0.3, 1, 59, "2", "3.77", 3, "6", "aneuploid");
                yield return new stagec(1.1, 1, 66, "1", "13.76", 3, "6", "tetraploid");
                yield return new stagec(7.8, 0, 53, "2", "14.52", 2, "5", "tetraploid");
                yield return new stagec(2, 1, 62, "2", "7.55", 3, "7", "diploid");
                yield return new stagec(7.3, 0, 69, "2", "8.46", 2, "5", "diploid");
                yield return new stagec(13.5, 0, 63, "2", "7.66", 3, "7", "diploid");
                yield return new stagec(11.7, 0, 61, "2", "8.4", 2, "5", "diploid");
                yield return new stagec(8.7, 0, 70, "1", "4.43", 1, "3", "diploid");
                yield return new stagec(3.4, 0, 61, "2", "10.37", 3, "7", "diploid");
                yield return new stagec(6.3, 0, 62, "2", "10.82", 2, "6", "diploid");
                yield return new stagec(10.6, 0, 55, "2", "7.81", 2, "5", "diploid");
                yield return new stagec(9.3, 0, 61, "2", "11.23", 2, "5", "diploid");
                yield return new stagec(7.9, 0, 63, "2", "13.99", 3, "6", "tetraploid");
                yield return new stagec(4.9, 0, 67, "2", "6.41", 2, "5", "diploid");
                yield return new stagec(13.4, 0, 59, "2", "16.05", 2, "5", "tetraploid");
                yield return new stagec(17.7, 0, 58, "2", "22.97", 3, "6", "tetraploid");
                yield return new stagec(1, 1, 61, "1", "2.4", 4, "10", "diploid");
                yield return new stagec(0.3, 1, 47, "2", "11.92", 4, "10", "diploid");
                yield return new stagec(13.1, 0, 65, "2", null, 3, "6", "tetraploid");
                yield return new stagec(16.7, 0, 56, "2", "5.29", 1, "3", "diploid");
                yield return new stagec(4.5, 0, 63, "2", "5.75", 2, "5", "diploid");
                yield return new stagec(3.4, 1, 69, "1", "7.64", 3, "8", "aneuploid");
                yield return new stagec(2.4, 1, 50, "1", "16.81", 3, "7", "tetraploid");
                yield return new stagec(6.8, 0, 70, "2", "29.56", 2, "5", "tetraploid");
                yield return new stagec(3, 1, 55, "1", "13.35", 3, "6", "aneuploid");
                yield return new stagec(10.4, 0, 55, "2", "8.1", 2, "5", "diploid");
                yield return new stagec(11.8, 0, 62, "1", "12.62", 2, "5", "diploid");
                yield return new stagec(8, 1, 66, "2", "14.14", 2, "5", "tetraploid");
                yield return new stagec(5.7, 0, 71, "1", "10.16", 2, "6", "diploid");
                yield return new stagec(6.1, 0, 63, "2", "17.21", 2, "5", "tetraploid");
                yield return new stagec(5.2, 0, 54, "2", "11.35", 2, "6", "diploid");
                yield return new stagec(6.2, 0, 65, "2", "11.35", 2, "5", "diploid");
                yield return new stagec(11.4, 0, 59, "2", "7.61", 2, "5", "diploid");
                yield return new stagec(7, 1, 61, "2", "20.82", 3, "6", "tetraploid");
                yield return new stagec(6.5, 0, 65, "1", "12.93", 3, "7", "diploid");
                yield return new stagec(0.5, 1, 57, "1", "21.75", 3, "7", "tetraploid");
                yield return new stagec(6.1, 0, 69, "2", "8.58", 2, "6", "diploid");
                yield return new stagec(5.1, 1, 53, "1", "14.94", 3, "7", "tetraploid");
                yield return new stagec(3.7, 1, 48, "2", "17.16", 3, "7", "tetraploid");
                yield return new stagec(12.2, 0, 57, "2", "23.62", 3, "8", "tetraploid");
                yield return new stagec(7.7, 1, 63, "2", "16.06", 3, "9", "tetraploid");
                yield return new stagec(7, 0, 52, "2", "7.15", 2, "7", "diploid");
                yield return new stagec(7.2, 1, 57, "2", "13.21", 3, "8", "tetraploid");
                yield return new stagec(4.4, 1, 62, "2", "11.35", 3, "6", "diploid");
                yield return new stagec(6.7, 0, 54, "2", "8.11", 2, "4", "diploid");
                yield return new stagec(6.8, 1, 67, "2", "11.18", 3, "7", "diploid");
                yield return new stagec(5.2, 1, 65, "2", "24.84", 3, "7", "tetraploid");
                yield return new stagec(8.7, 0, 67, "2", "7.67", 3, "6", "diploid");
                yield return new stagec(10.8, 0, 72, "1", "6.68", 2, null, "diploid");
                yield return new stagec(2.6, 1, 66, "2", "15.23", 3, "8", "tetraploid");
                yield return new stagec(10.9, 0, 72, "2", "6.8", 2, "5", "diploid");
                yield return new stagec(5.6, 1, 60, "2", "14.58", 3, "7", "tetraploid");
                yield return new stagec(10.1, 0, 70, "2", "13.17", 2, "6", "tetraploid");
                yield return new stagec(7.2, 0, 63, "1", "9.76", 2, "5", "diploid");
                yield return new stagec(10.2, 0, 64, "1", "7.61", 2, null, "diploid");
                yield return new stagec(7.7, 1, 62, "2", "38.05", 3, "7", "tetraploid");
                yield return new stagec(2.7, 1, 61, "1", "13.87", 3, "6", "tetraploid");
                yield return new stagec(1.9, 1, 64, "2", "21.2", 3, "7", "tetraploid");
                yield return new stagec(3.6, 0, 64, "1", "17.96", 3, "7", "tetraploid");
                yield return new stagec(8.2, 0, 68, "2", "27.14", 3, "9", "tetraploid");
                yield return new stagec(9.2, 0, 62, "1", "6.74", 2, "5", "diploid");
                yield return new stagec(6.1, 0, 69, "2", "11.21", 3, "8", "diploid");
                yield return new stagec(8.7, 0, 59, "2", "20.22", 3, "6", "tetraploid");
                yield return new stagec(7.4, 1, 66, "1", "15.35", 3, "8", "tetraploid");
                yield return new stagec(1.6, 1, 53, "1", "16.79", 3, "9", "tetraploid");
                yield return new stagec(8.4, 0, 59, "2", "8.76", 2, "6", "diploid");
                yield return new stagec(4.7, 1, 58, "2", "13.23", 2, "6", "tetraploid");
                yield return new stagec(5.7, 0, 61, "2", "34.01", 2, "7", "tetraploid");
                yield return new stagec(3.2, 1, 65, null, "14.68", 3, "8", "tetraploid");
                yield return new stagec(4.9, 0, 67, "1", "17.95", 3, "8", "tetraploid");
                yield return new stagec(3.4, 1, 57, "1", "23.34", 3, "8", "tetraploid");
                yield return new stagec(1, 1, 55, "2", "10.25", 3, "7", "aneuploid");
                yield return new stagec(5.4, 1, 57, "2", null, 3, "8", "aneuploid");
                yield return new stagec(4.7, 0, 57, "1", "15.1", 3, "7", "tetraploid");
                yield return new stagec(6.3, 0, 68, "1", "26.55", 2, "6", "tetraploid");
                yield return new stagec(7, 0, 67, "2", "7.78", 2, "6", "diploid");
                yield return new stagec(1.5, 1, 60, "1", null, 4, "9", "aneuploid");
                yield return new stagec(7.1, 0, 63, "2", "21.2", 3, "7", "tetraploid");
                yield return new stagec(6, 0, 69, "2", "7.93", 3, "6", "diploid");
                yield return new stagec(3.8, 0, 54, "2", "10.58", 3, "8", "diploid");
                yield return new stagec(6.5, 0, 66, "2", "5.92", 2, "5", "diploid");
                yield return new stagec(3.1, 0, 59, "2", "5.08", 3, "7", "diploid");
                yield return new stagec(6.8, 0, 62, "2", "13.1", 3, "8", "tetraploid");
                yield return new stagec(6.7, 0, 73, "1", "41.31", 3, "8", "tetraploid");
                yield return new stagec(5.7, 1, 65, "2", "11.29", 3, "7", "diploid");
                yield return new stagec(1.5, 1, 67, "2", "14.02", 3, "7", "tetraploid");
                yield return new stagec(5.2, 0, 75, "2", "12.46", 3, "7", "diploid");
                yield return new stagec(1.3, 1, 70, "2", "13.69", 3, "8", "tetraploid");
                yield return new stagec(6.2, 0, 59, "2", "12.06", 2, "5", "diploid");
                yield return new stagec(6.5, 0, 73, "2", "13.01", 3, "6", "diploid");
                yield return new stagec(1.2, 1, 66, "2", "13.21", 2, "6", "tetraploid");
                yield return new stagec(5.7, 0, 66, "2", "10.43", 3, "5", "diploid");
                yield return new stagec(3.4, 1, 65, "2", null, 3, "7", "aneuploid");
                yield return new stagec(5.6, 0, 66, "1", "13.33", 2, "5", "tetraploid");
                yield return new stagec(6, 0, 66, "2", "37.49", 3, "7", "tetraploid");
                yield return new stagec(5.1, 0, 59, "2", "11.69", 3, "7", "diploid");
                yield return new stagec(6, 0, 52, "2", "9.9", 2, "4", "diploid");
                yield return new stagec(5.4, 0, 68, "2", "13.01", 2, "5", "diploid");
                yield return new stagec(2.4, 0, 63, "2", "4.81", 3, "8", "diploid");
                yield return new stagec(4.2, 0, 67, "2", "14.71", 2, "5", "tetraploid");
                yield return new stagec(5.5, 0, 59, "1", "9.01", 2, "5", "diploid");
                yield return new stagec(5.4, 0, 57, "1", "10.9", 3, "6", "diploid");
                yield return new stagec(8.2, 0, 62, "2", "10.72", 3, "7", "diploid");
                yield return new stagec(10.2, 0, 63, "2", "5.14", 2, "5", "diploid");
                yield return new stagec(2.5, 1, 73, "2", "46.92", 4, "9", "tetraploid");
                yield return new stagec(7.9, 0, 68, "2", null, 2, "5", "aneuploid");
                yield return new stagec(5.6, 0, 51, "2", "9.59", 3, "6", "diploid");
                yield return new stagec(2.1, 1, 56, "2", "9.01", 3, "7", "diploid");
            }
        }
    }
}
