// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Blue Jays
    /// </summary>

    public class BlueJays
    {
        public readonly string BirdID;
        public readonly string KnownSex;
        public readonly double BillDepth;
        public readonly double BillWidth;
        public readonly double BillLength;
        public readonly double Head;
        public readonly double Mass;
        public readonly double Skull;
        public readonly int Sex;

        public BlueJays(string BirdID, string KnownSex, double BillDepth, double BillWidth, double BillLength, double Head, double Mass, double Skull, int Sex)
        {
            this.BirdID = BirdID;
            this.KnownSex = KnownSex;
            this.BillDepth = BillDepth;
            this.BillWidth = BillWidth;
            this.BillLength = BillLength;
            this.Head = Head;
            this.Mass = Mass;
            this.Skull = Skull;
            this.Sex = Sex;
        }

        public static IEnumerable<BlueJays> Data
        {
            get
            {
                yield return new BlueJays("0000-00000", "M", 8.26, 9.21, 25.92, 56.58, 73.3, 30.66, 1);
                yield return new BlueJays("1142-05901", "M", 8.54, 8.76, 24.99, 56.36, 75.1, 31.38, 1);
                yield return new BlueJays("1142-05905", "M", 8.39, 8.78, 26.07, 57.32, 70.25, 31.25, 1);
                yield return new BlueJays("1142-05907", "F", 7.78, 9.3, 23.48, 53.77, 65.5, 30.29, 0);
                yield return new BlueJays("1142-05909", "M", 8.71, 9.84, 25.47, 57.32, 74.9, 31.85, 1);
                yield return new BlueJays("1142-05911", "F", 7.28, 9.3, 22.25, 52.25, 63.9, 30, 0);
                yield return new BlueJays("1142-05912", "M", 8.74, 9.28, 25.35, 57.12, 75.1, 31.77, 1);
                yield return new BlueJays("1142-05914", "M", 8.72, 9.94, 30, 60.67, 78.1, 30.67, 1);
                yield return new BlueJays("1142-05917", "F", 8.2, 9.01, 22.78, 52.83, 64, 30.05, 0);
                yield return new BlueJays("1142-05920", "F", 7.67, 9.31, 24.61, 54.94, 67.33, 30.33, 0);
                yield return new BlueJays("1142-05930", "M", 8.78, 8.83, 25.72, 56.54, 76.4, 30.82, 1);
                yield return new BlueJays("1142-05941", "F", 8.15, 8.67, 24.66, 54.69, 71.5, 30.03, 0);
                yield return new BlueJays("1142-05957", "M", 8.62, 9.28, 24.5, 56.48, 78.2, 31.98, 1);
                yield return new BlueJays("1142-05971", "F", 7.65, 9.11, 23.93, 55.75, 73.4, 31.83, 0);
                yield return new BlueJays("1142-05981", "M", 7.96, 9.31, 25.62, 57.34, 77, 31.73, 1);
                yield return new BlueJays("1142-05986", "F", 8.17, 8.49, 23.15, 53.05, 65, 29.9, 0);
                yield return new BlueJays("1142-05990", "F", 8.13, 8.88, 25, 54.81, 75.2, 29.81, 0);
                yield return new BlueJays("1142-05991", "M", 8.19, 9.98, 25.4, 58.7, 75.7, 33.3, 1);
                yield return new BlueJays("1142-05995", "M", 8.49, 8.81, 25.93, 57.07, 78.4, 31.15, 1);
                yield return new BlueJays("1142-05996", "M", 8.35, 9.57, 24.4, 55.79, 70.6, 31.39, 1);
                yield return new BlueJays("1142-05997", "M", 8.53, 9.71, 26.3, 58.31, 74.7, 32, 1);
                yield return new BlueJays("1142-05998", "M", 8.07, 8.38, 23.62, 54.51, 70, 30.89, 1);
                yield return new BlueJays("1142-05999", "M", 8.23, 10.31, 26.66, 58.21, 75.4, 31.55, 1);
                yield return new BlueJays("702-90556", "F", 7.86, 9.21, 23.87, 54.09, 75.2, 30.22, 0);
                yield return new BlueJays("702-90560", "M", 8.42, 9.3, 24.98, 56.8, 74.5, 31.83, 1);
                yield return new BlueJays("702-90567", "F", 8.48, 9.64, 25.4, 56.82, 62.2, 31.42, 0);
                yield return new BlueJays("702-90576", "F", 8.22, 9.09, 23, 55.39, 72.3, 32.39, 0);
                yield return new BlueJays("702-90577", "F", 8.18, 9.44, 23.44, 54.21, 74, 30.77, 0);
                yield return new BlueJays("702-90578", "M", 8.23, 9.67, 24.86, 56.88, 73.73, 32.02, 1);
                yield return new BlueJays("702-90583", "F", 8.44, 9.19, 26.14, 56.37, 73.97, 30.24, 0);
                yield return new BlueJays("872-94671", "F", 7.21, 8.21, 23.13, 53.7, 66.8, 30.57, 0);
                yield return new BlueJays("872-94673", "M", 8.88, 9.58, 26.19, 55.96, 75.18, 29.77, 1);
                yield return new BlueJays("872-94684", "F", 8.58, 10.63, 24.75, 55.83, 78.3, 31.08, 0);
                yield return new BlueJays("872-94688", "F", 8.36, 9.63, 24.92, 55.47, 70.6, 30.55, 0);
                yield return new BlueJays("872-94689", "M", 8.2, 8.68, 24.24, 55.96, 72.1, 31.72, 1);
                yield return new BlueJays("872-94692", "M", 8.42, 10.24, 25.4, 56.59, 70.2, 31.19, 1);
                yield return new BlueJays("872-94694", "M", 8.6, 8.4, 25.5, 57.5, 74, 32, 1);
                yield return new BlueJays("872-94698", "M", 7.96, 8.62, 24.55, 56.01, 69.67, 31.46, 1);
                yield return new BlueJays("872-94709", "F", 7.58, 10, 23.42, 54.49, 69.4, 31.07, 0);
                yield return new BlueJays("872-94716", "F", 8.05, 9.35, 24.46, 56.04, 77.6, 31.58, 0);
                yield return new BlueJays("872-94731", "M", 8.34, 8.62, 23.92, 53.74, 60.17, 29.82, 1);
                yield return new BlueJays("872-94737", "F", 7.69, 9.01, 23.31, 54.13, 70.5, 30.82, 0);
                yield return new BlueJays("872-94757", "M", 8.88, 9.22, 25.68, 56.8, 67.5, 31.12, 1);
                yield return new BlueJays("872-94761", "M", 8.55, 9.03, 26.55, 57.86, 75.95, 31.31, 1);
                yield return new BlueJays("872-94766", "F", 8.42, 9.49, 26.3, 56.5, 79.5, 30.2, 0);
                yield return new BlueJays("872-94769", "M", 8.54, 8.96, 25.73, 56.82, 77.5, 31.09, 1);
                yield return new BlueJays("872-94771", "M", 8.54, 9.4, 24.29, 56.35, 79.2, 32.06, 1);
                yield return new BlueJays("872-94776", "F", 7.57, 9.32, 23.48, 54.31, 65.3, 30.83, 0);
                yield return new BlueJays("872-94777", "M", 8.4, 8.2, 25.7, 56.4, 69, 30.7, 1);
                yield return new BlueJays("872-94779", "F", 8.11, 8.37, 24.07, 53.04, 65.6, 28.97, 0);
                yield return new BlueJays("872-94780", "F", 8.19, 9.38, 24.93, 55.58, 67.83, 30.64, 0);
                yield return new BlueJays("952-00002", "F", 8.46, 9.69, 25.3, 56.84, 75.7, 31.54, 0);
                yield return new BlueJays("952-00004", "M", 8.58, 9.63, 26.12, 57, 72.6, 30.88, 1);
                yield return new BlueJays("952-00006", "F", 7.8, 8.74, 23.89, 53.74, 58.8, 29.85, 0);
                yield return new BlueJays("952-00007", "F", 8.1, 8.44, 23.75, 55.74, 70.9, 32, 0);
                yield return new BlueJays("952-00012", "F", 8.7, 8.91, 25.46, 55.37, 66.3, 29.91, 0);
                yield return new BlueJays("952-00013", "M", 8.82, 8.6, 25.46, 56.86, 73.9, 31.4, 1);
                yield return new BlueJays("952-00016", "M", 8.39, 9.12, 26.58, 57.64, 71.35, 31.06, 1);
                yield return new BlueJays("952-00020", "M", 7.89, 9.07, 26.12, 57.86, 73.9, 31.74, 1);
                yield return new BlueJays("952-00023", "M", 7.93, 8.72, 24.93, 55.02, 67.2, 30.09, 1);
                yield return new BlueJays("952-00026", "M", 8.86, 10.02, 25.04, 57.3, 73, 32.26, 1);
                yield return new BlueJays("952-00056", "M", 9, 9.4, 25.5, 56.9, 74, 31.4, 1);
                yield return new BlueJays("952-00057", "F", 8, 8.9, 23.6, 52.8, 63.7, 29.2, 0);
                yield return new BlueJays("952-00058", "F", 8.2, 9, 25, 54.2, 72.8, 29.2, 0);
                yield return new BlueJays("952-00059", "M", 8.7, 9.8, 25.6, 57.3, 76.3, 31.7, 1);
                yield return new BlueJays("952-00062", "F", 7.8, 8, 23.1, 53.9, 66, 30.8, 0);
                yield return new BlueJays("952-00063", "M", 8.2, 9.9, 24.4, 56.7, 74, 32.3, 1);
                yield return new BlueJays("952-00064", "M", 8.2, 9.5, 24, 56.3, 76.3, 32.3, 1);
                yield return new BlueJays("952-00065", "M", 8.6, 9.6, 23.7, 55.5, 71.3, 31.8, 1);
                yield return new BlueJays("952-00066", "F", 7.3, 9.9, 22.4, 53.9, 65, 31.5, 0);
                yield return new BlueJays("952-00068", "M", 8.4, 9.4, 25, 56.1, 73.8, 31.1, 1);
                yield return new BlueJays("952-00069", "F", 8, 9.3, 23.4, 54, 69, 30.6, 0);
                yield return new BlueJays("952-00070", "M", 8.3, 9.2, 24.3, 54.9, 72.1, 30.6, 1);
                yield return new BlueJays("952-00071", "M", 8.6, 9.8, 26, 59.2, 80.9, 33.2, 1);
                yield return new BlueJays("952-00072", "F", 8.3, 9, 25.7, 55, 68.5, 29.3, 0);
                yield return new BlueJays("952-00073", "F", 8.2, 9.7, 24.6, 54.4, 70, 29.8, 0);
                yield return new BlueJays("952-00074", "M", 8.5, 9.6, 25.5, 56.7, 75.9, 31.2, 1);
                yield return new BlueJays("952-00076", "M", 8.2, 9.3, 24.9, 55.5, 70, 30.6, 1);
                yield return new BlueJays("952-00077", "F", 8.3, 8.2, 23.7, 53.6, 69, 29.9, 0);
                yield return new BlueJays("952-00078", "M", 8.8, 9.7, 25.3, 56.6, 75.8, 31.3, 1);
                yield return new BlueJays("952-00079", "M", 8.2, 8.1, 25.9, 57.5, 69.7, 31.6, 1);
                yield return new BlueJays("952-00080", "M", 8.8, 9.8, 27.3, 56.2, 65.5, 28.9, 1);
                yield return new BlueJays("952-00081", "F", 7.6, 8.3, 24.8, 56.2, 67.9, 31.4, 0);
                yield return new BlueJays("952-00084", "F", 8.8, 9.7, 25.5, 56.7, 81.5, 31.2, 0);
                yield return new BlueJays("962-62003", "M", 8.56, 9.2, 26.62, 56.48, 74, 29.86, 1);
                yield return new BlueJays("962-62006", "M", 8.92, 9.22, 24.78, 56.45, 71.5, 31.67, 1);
                yield return new BlueJays("962-62007", "F", 7.74, 9.27, 25.05, 55.76, 66.1, 30.71, 0);
                yield return new BlueJays("962-62008", "F", 7.91, 9.38, 25.73, 55.7, 69.8, 29.97, 0);
                yield return new BlueJays("962-62019", "M", 8.72, 9.25, 24.3, 54.76, 68.5, 30.46, 1);
                yield return new BlueJays("962-62021", "F", 7.55, 8.62, 23.55, 52.74, 70, 29.19, 0);
                yield return new BlueJays("962-62024", "M", 8.43, 9.27, 26.32, 56.44, 66.75, 30.12, 1);
                yield return new BlueJays("962-62025", "M", 8.2, 9.28, 26.27, 58.5, 76.5, 32.23, 1);
                yield return new BlueJays("962-62026", "F", 7.62, 9.88, 25.71, 55.97, 69.3, 30.26, 0);
                yield return new BlueJays("962-62027", "M", 8.51, 9.64, 25.91, 55.64, 67.8, 29.73, 1);
                yield return new BlueJays("962-62030", "F", 8.21, 9.21, 23.6, 53.88, 75.5, 30.28, 0);
                yield return new BlueJays("962-62031", "F", 7.86, 9.39, 23.36, 54.04, 73.25, 30.69, 0);
                yield return new BlueJays("962-62038", "M", 8.58, 9.73, 27.04, 57.56, 71.9, 30.52, 1);
                yield return new BlueJays("962-62040", "M", 8.59, 9.97, 25.88, 56, 79.55, 30.12, 1);
                yield return new BlueJays("962-62041", "F", 7.72, 8.97, 22.88, 53.03, 66.75, 30.15, 0);
                yield return new BlueJays("962-62043", "F", 7.58, 9.04, 24.02, 55.65, 73.2, 31.63, 0);
                yield return new BlueJays("962-62045", "F", 8.4, 8.4, 23.9, 54.7, 72.35, 30.8, 0);
                yield return new BlueJays("962-62046", "F", 7.9, 8.48, 22.78, 51.6, 64, 28.82, 0);
                yield return new BlueJays("962-62063", "M", 8.12, 9.67, 24.9, 55.91, 73.5, 31.01, 1);
                yield return new BlueJays("962-62067", "F", 7.92, 9.16, 23.92, 54.69, 68.9, 30.77, 0);
                yield return new BlueJays("962-62068", "F", 7.96, 9.09, 24.33, 54.58, 73.8, 30.25, 0);
                yield return new BlueJays("962-62069", "M", 8.1, 9.1, 25.9, 57.1, 77.4, 31.2, 1);
                yield return new BlueJays("962-62070", "F", 7.5, 9.57, 24.6, 53.8, 61.4, 29.2, 0);
                yield return new BlueJays("962-62081", "M", 8.15, 9.72, 26.05, 56.85, 73.4, 30.8, 1);
                yield return new BlueJays("962-62088", "F", 7.71, 8.58, 25.06, 54.15, 61.2, 29.09, 0);
                yield return new BlueJays("962-62089", "F", 8.05, 9.25, 25.2, 56.25, 69.65, 31.05, 0);
                yield return new BlueJays("962-62090", "F", 8.57, 8.97, 25.15, 54.8, 77, 29.64, 0);
                yield return new BlueJays("962-62099", "F", 8.69, 9.43, 24.94, 56.09, 72.2, 31.15, 0);
                yield return new BlueJays("962-62104", "F", 8.02, 8.62, 24.09, 55.82, 76.55, 31.73, 0);
                yield return new BlueJays("962-62115", "F", 8.57, 10.82, 23.68, 53.95, 68.25, 30.27, 0);
                yield return new BlueJays("962-62117", "M", 8.33, 9.27, 25.78, 56.71, 71.5, 30.93, 1);
                yield return new BlueJays("962-62123", "M", 8.43, 9.23, 25.28, 57.25, 77.53, 31.97, 1);
                yield return new BlueJays("962-62127", "M", 8.2, 9.06, 24.22, 54.58, 68.95, 30.36, 1);
                yield return new BlueJays("962-62138", "F", 8.3, 9.28, 23.92, 56.28, 78.8, 32.36, 0);
                yield return new BlueJays("962-62176", "M", 8.7, 9.12, 24.62, 56.61, 77, 31.99, 1);
                yield return new BlueJays("962-62181", "M", 7.96, 9.8, 25.07, 55.68, 68, 30.61, 1);
                yield return new BlueJays("962-62184", "F", 7.9, 9.3, 23.6, 53.9, 63.9, 30.3, 0);
                yield return new BlueJays("962-62185", "F", 7.63, 8.56, 24.29, 54.19, 70.45, 29.9, 0);
                yield return new BlueJays("962-62200", "F", 7.9, 8, 23, 52.7, 66, 29.7, 0);
            }
        }
    }
}
