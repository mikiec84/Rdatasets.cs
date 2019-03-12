// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Votes for Republican Candidate in Presidential Elections
    /// </summary>

    public class votes_repub
    {
        public readonly string κ;
        public readonly double? X1856;
        public readonly double? X1860;
        public readonly double? X1864;
        public readonly double? X1868;
        public readonly double? X1872;
        public readonly double? X1876;
        public readonly double? X1880;
        public readonly double? X1884;
        public readonly double? X1888;
        public readonly double? X1892;
        public readonly double? X1896;
        public readonly double? X1900;
        public readonly double? X1904;
        public readonly double? X1908;
        public readonly double? X1912;
        public readonly double? X1916;
        public readonly double? X1920;
        public readonly double? X1924;
        public readonly double? X1928;
        public readonly double? X1932;
        public readonly double? X1936;
        public readonly double? X1940;
        public readonly double? X1944;
        public readonly double? X1948;
        public readonly double? X1952;
        public readonly double? X1956;
        public readonly double X1960;
        public readonly double X1964;
        public readonly double X1968;
        public readonly double X1972;
        public readonly double X1976;

        public votes_repub(string κ, double? X1856, double? X1860, double? X1864, double? X1868, double? X1872, double? X1876, double? X1880, double? X1884, double? X1888, double? X1892, double? X1896, double? X1900, double? X1904, double? X1908, double? X1912, double? X1916, double? X1920, double? X1924, double? X1928, double? X1932, double? X1936, double? X1940, double? X1944, double? X1948, double? X1952, double? X1956, double X1960, double X1964, double X1968, double X1972, double X1976)
        {
            this.κ = κ;
            this.X1856 = X1856;
            this.X1860 = X1860;
            this.X1864 = X1864;
            this.X1868 = X1868;
            this.X1872 = X1872;
            this.X1876 = X1876;
            this.X1880 = X1880;
            this.X1884 = X1884;
            this.X1888 = X1888;
            this.X1892 = X1892;
            this.X1896 = X1896;
            this.X1900 = X1900;
            this.X1904 = X1904;
            this.X1908 = X1908;
            this.X1912 = X1912;
            this.X1916 = X1916;
            this.X1920 = X1920;
            this.X1924 = X1924;
            this.X1928 = X1928;
            this.X1932 = X1932;
            this.X1936 = X1936;
            this.X1940 = X1940;
            this.X1944 = X1944;
            this.X1948 = X1948;
            this.X1952 = X1952;
            this.X1956 = X1956;
            this.X1960 = X1960;
            this.X1964 = X1964;
            this.X1968 = X1968;
            this.X1972 = X1972;
            this.X1976 = X1976;
        }

        public static IEnumerable<votes_repub> Data
        {
            get
            {
                yield return new votes_repub("Alabama", null, null, null, 51.44, 53.19, 40.02, 36.98, 38.44, 32.28, 3.95, 28.13, 34.67, 20.65, 24.38, 8.26, 21.97, 30.98, 27.01, 48.49, 14.15, 12.82, 14.34, 18.2, 19.04, 35.02, 39.39, 41.75, 69.5, 14, 72.4, 43.48);
                yield return new votes_repub("Alaska", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 50.94, 34.1, 45.3, 58.1, 62.91);
                yield return new votes_repub("Arizona", null, null, null, null, null, null, null, null, null, null, null, null, null, null, 12.74, 35.37, 55.41, 41.26, 57.57, 30.53, 26.93, 36.01, 40.9, 43.82, 58.35, 60.99, 55.52, 50.4, 54.8, 64.7, 58.62);
                yield return new votes_repub("Arkansas", null, null, null, 53.73, 52.17, 39.88, 39.55, 40.5, 38.07, 32.01, 25.11, 35.04, 40.25, 37.31, 19.73, 28.01, 38.73, 29.28, 39.33, 12.91, 17.86, 20.87, 29.84, 21.02, 43.76, 45.82, 43.06, 43.9, 30.8, 68.9, 34.97);
                yield return new votes_repub("California", 18.77, 32.96, 58.63, 50.24, 56.38, 50.88, 48.92, 52.08, 49.95, 43.76, 49.13, 54.48, 61.9, 55.46, 0.58, 46.26, 66.24, 57.21, 64.7, 37.4, 31.7, 41.35, 42.99, 47.14, 56.39, 55.4, 50.1, 40.9, 47.8, 55, 50.89);
                yield return new votes_repub("Colorado", null, null, null, null, null, null, 51.28, 54.39, 55.31, 41.13, 13.84, 42.04, 55.27, 46.88, 21.88, 34.75, 59.32, 57.02, 64.72, 41.43, 37.09, 50.92, 53.21, 46.52, 60.27, 59.49, 54.63, 38.7, 50.5, 62.6, 55.89);
                yield return new votes_repub("Connecticut", 53.18, 53.86, 51.38, 51.54, 52.25, 48.34, 50.52, 48.01, 48.44, 46.8, 63.24, 56.94, 58.13, 59.43, 35.88, 49.8, 62.72, 61.54, 53.63, 48.54, 40.35, 46.3, 46.94, 49.55, 55.7, 63.73, 46.27, 32.2, 44.3, 58.6, 52.64);
                yield return new votes_repub("Delaware", 2.11, 23.71, 48.2, 40.98, 50.99, 44.55, 47.86, 42.75, 43.55, 48.55, 52.94, 53.65, 54.04, 52.09, 32.85, 50.2, 55.71, 57.71, 65.03, 50.55, 43.43, 45.05, 45.27, 50.04, 51.75, 55.09, 49, 39.1, 45.1, 59.6, 47.27);
                yield return new votes_repub("Florida", null, null, null, null, 53.52, 50.99, 45.83, 46.82, 39.94, null, 24.3, 19.03, 21.15, 21.58, 8.25, 18.08, 30.79, 28.06, 56.83, 25.04, 23.85, 25.99, 29.68, 33.63, 55.01, 57.2, 51.51, 48.9, 40.5, 71.9, 46.83);
                yield return new votes_repub("Georgia", null, null, null, 35.72, 43.77, 27.94, 34.33, 33.84, 28.33, 21.8, 36.82, 28.56, 18.32, 31.4, 4.27, 7.07, 28.57, 18.19, 43.37, 7.77, 12.6, 14.84, 18.25, 18.31, 30.34, 33.22, 37.44, 54.1, 30.4, 75, 33.02);
                yield return new votes_repub("Hawaii", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 49.97, 21.2, 38.7, 62.5, 48.72);
                yield return new votes_repub("Idaho", null, null, null, null, null, null, null, null, null, 44.87, 21.3, 47.14, 65.84, 54.09, 31.02, 41.13, 66.02, 47.12, 64.74, 38.23, 33.19, 45.31, 48.07, 47.26, 65.42, 61.18, 53.78, 49.1, 56.8, 64.2, 61.77);
                yield return new votes_repub("Illinois", 40.25, 50.68, 54.41, 55.69, 56.27, 50.09, 51.11, 50.16, 49.54, 45.7, 55.65, 52.83, 58.77, 54.52, 22.13, 52.56, 67.81, 58.84, 56.93, 42.04, 39.69, 48.54, 48.05, 49.24, 54.84, 59.52, 49.8, 40.5, 47.1, 59, 51.11);
                yield return new votes_repub("Indiana", 40.03, 51.09, 53.6, 51.39, 53, 48.27, 49.33, 48.16, 49.05, 46.17, 50.81, 50.6, 53.99, 48.4, 23.11, 47.44, 55.14, 55.25, 59.68, 42.94, 41.89, 50.45, 52.38, 49.58, 58.11, 59.9, 55.03, 44, 50.3, 66.1, 53.77);
                yield return new votes_repub("Iowa", 49.13, 54.87, 64.23, 61.92, 64.18, 58.58, 56.85, 52.42, 52.36, 49.6, 55.46, 57.99, 63.37, 55.62, 24.3, 54.06, 70.91, 55.06, 61.8, 39.98, 42.7, 52.03, 51.99, 47.58, 63.76, 59.06, 56.71, 38.1, 53, 57.6, 50.51);
                yield return new votes_repub("Kansas", null, null, 78.61, 68.89, 66.64, 63.1, 60.4, 58.18, 55.39, 48.4, 47.46, 52.56, 64.81, 52.46, 20.48, 44.09, 64.76, 61.54, 72.02, 44.13, 45.95, 56.86, 60.25, 53.63, 68.77, 65.44, 60.45, 45.9, 54.8, 67.7, 53.91);
                yield return new votes_repub("Kentucky", 0.26, 0.93, 30.17, 25.45, 46.45, 37.61, 39.8, 42.81, 44.99, 39.74, 48.92, 48.5, 47.11, 48.04, 25.46, 46.52, 49.25, 48.93, 59.33, 40.15, 39.92, 42.3, 45.22, 41.48, 49.84, 54.3, 53.59, 36, 43.8, 63.4, 46.24);
                yield return new votes_repub("Louisiana", null, null, null, 29.31, 55.69, 51.57, 37.1, 42.39, 26.48, 23.59, 21.79, 20.96, 9.65, 11.92, 4.83, 6.95, 30.57, 20.23, 23.71, 7.03, 11.16, 14.09, 19.4, 17.45, 47.08, 53.28, 28.59, 56.8, 23.5, 65.3, 47);
                yield return new votes_repub("Maine", 61.37, 64.15, 60.22, 62.42, 67.86, 56.73, 51.45, 55.35, 57.49, 54.06, 67.9, 61.89, 67.1, 63, 20.48, 50.95, 68.92, 72.03, 68.63, 55.83, 55.49, 51.1, 52.44, 56.74, 66.05, 70.87, 57.05, 31.2, 43.1, 61.5, 50.34);
                yield return new votes_repub("Maryland", 0.32, 3.11, 55.1, 32.8, 49.65, 43.94, 45.37, 46.09, 47.4, 43.48, 54.6, 51.5, 48.83, 48.85, 23.69, 44.78, 55.11, 45.29, 57.06, 36.04, 37.04, 40.83, 48.15, 49.4, 55.36, 60.04, 46.39, 34.5, 41.9, 61.3, 46.87);
                yield return new votes_repub("Massachusetts", 64.72, 62.75, 72.22, 69.67, 69.25, 57.74, 58.5, 48.32, 53.38, 51.85, 69.36, 57.67, 57.92, 58.21, 31.89, 50.54, 68.55, 62.26, 49.15, 46.64, 41.76, 46.36, 47, 43.17, 54.22, 59.33, 39.55, 23.8, 32.9, 45.2, 41.93);
                yield return new votes_repub("Michigan", 56.98, 57.18, 55.89, 56.98, 62.67, 52.45, 52.54, 47.89, 49.73, 47.81, 53.85, 58.1, 69.5, 61.93, 27.63, 52.09, 72.8, 75.37, 70.36, 44.45, 38.76, 49.85, 49.18, 49.23, 55.44, 55.63, 48.84, 33.3, 41.5, 56.2, 52.68);
                yield return new votes_repub("Minnesota", null, 63.42, 59.06, 60.8, 61.55, 58.77, 62.28, 58.8, 54.12, 45.96, 56.62, 60.21, 73.95, 59.11, 19.25, 46.35, 70.78, 51.18, 57.77, 36.29, 31.01, 47.66, 46.86, 39.89, 55.33, 53.68, 49.16, 36.2, 41.5, 51.6, 44.3);
                yield return new votes_repub("Mississippi", null, null, null, null, 63.47, 31.92, 29.94, 36.25, 26.63, 2.64, 7.27, 9.73, 5.46, 6.56, 2.47, 4.91, 14.03, 7.6, 17.9, 3.55, 2.74, 4.19, 6.44, 2.62, 39.56, 24.46, 24.67, 87.1, 13.5, 78.2, 49.21);
                yield return new votes_repub("Missouri", null, 10.29, 70.17, 58.9, 43.65, 41.23, 38.65, 46.01, 45.31, 41.97, 45.24, 45.94, 49.92, 48.5, 29.75, 46.94, 54.57, 49.58, 55.58, 35.08, 38.16, 47.5, 48.43, 41.5, 50.71, 49.87, 49.74, 36, 44.9, 62.2, 48.22);
                yield return new votes_repub("Montana", null, null, null, null, null, null, null, null, null, 42.54, 19.72, 39.84, 54.21, 46.98, 23.19, 37.57, 61.13, 42.5, 58.37, 36.07, 27.59, 40.17, 44.93, 43.15, 59.39, 57.13, 51.1, 41.1, 50.6, 57.9, 53.65);
                yield return new votes_repub("Nebraska", null, null, null, 64.14, 70.12, 59.65, 62.87, 57.33, 53.51, 43.57, 45.98, 50.46, 61.38, 47.6, 21.73, 41.08, 64.68, 47.09, 63.19, 35.29, 40.74, 57.19, 58.58, 54.15, 69.15, 65.51, 62.07, 47.4, 59.8, 70.5, 60.31);
                yield return new votes_repub("Nevada", null, null, 59.84, 55.39, 57.43, 52.73, 47.6, 56.21, 57.23, 25.84, 18.79, 37.75, 56.66, 43.93, 15.89, 36.4, 56.92, 41.76, 56.54, 30.59, 27.19, 39.92, 45.38, 47.26, 61.45, 57.97, 48.84, 41.4, 47.5, 63.7, 52.27);
                yield return new votes_repub("New Hampshire", 53.59, 56.89, 52.56, 55.02, 53.95, 51.84, 51.94, 51.15, 50.35, 51.11, 68.74, 59.34, 60.14, 59.32, 37.43, 49.06, 59.84, 59.83, 58.66, 50.42, 47.98, 46.78, 47.87, 52.41, 60.92, 66.11, 53.42, 36.1, 52.1, 64, 55.68);
                yield return new votes_repub("New Jersey", 28.52, 48.13, 47.16, 49.12, 54.22, 47, 49.02, 47.31, 47.52, 46.24, 59.66, 55.27, 56.68, 56.79, 20.54, 54.35, 67.6, 62.16, 59.77, 47.59, 39.57, 47.93, 48.95, 50.33, 56.81, 64.68, 49.16, 34.4, 46.1, 61.6, 50.99);
                yield return new votes_repub("New Mexico", null, null, null, null, null, null, null, null, null, null, null, null, null, null, 35.91, 46.53, 54.68, 48.52, 59.01, 35.76, 36.5, 43.28, 46.44, 42.93, 55.39, 57.81, 49.41, 41, 51.8, 61, 51.04);
                yield return new votes_repub("New York", 46.14, 53.71, 50.46, 49.41, 53.12, 48.07, 50.32, 48.15, 49.2, 45.59, 57.55, 53.1, 53.13, 53.11, 28.68, 51.53, 64.56, 55.76, 49.79, 41.33, 38.97, 48.04, 47.3, 45.99, 55.45, 61.2, 47.27, 31.4, 44.3, 58.5, 47.84);
                yield return new votes_repub("North Carolina", null, null, null, 53.37, 57.48, 46.36, 48.04, 46.58, 47.14, 35.79, 46.87, 45.47, 39.7, 45.55, 11.94, 41.73, 43.22, 39.72, 54.87, 29.28, 26.6, 25.97, 33.29, 32.68, 46.09, 49.34, 47.89, 43.8, 39.5, 69.5, 44.43);
                yield return new votes_repub("North Dakota", null, null, null, null, null, null, null, null, null, 48.5, 55.58, 62.11, 74.83, 60.87, 26.67, 49.2, 77.79, 47.68, 54.8, 28, 26.58, 55.06, 53.84, 52.17, 70.97, 61.72, 55.42, 42, 55.9, 62.1, 52.93);
                yield return new votes_repub("Ohio", 48.49, 52.33, 56.33, 53.97, 53.24, 50.21, 51.73, 50.99, 49.51, 47.66, 51.86, 52.3, 59.73, 51.03, 26.82, 44.18, 58.47, 58.33, 64.89, 47.04, 37.43, 47.8, 50.18, 49.24, 56.76, 61.11, 53.28, 37.1, 45.2, 59.6, 49.9);
                yield return new votes_repub("Oklahoma", null, null, null, null, null, null, null, null, null, null, null, null, null, 43.03, 35.69, 33.21, 50.11, 42.82, 63.72, 26.7, 32.69, 42.23, 44.2, 37.25, 54.59, 55.13, 59.02, 44.3, 47.7, 73.7, 50.52);
                yield return new votes_repub("Oregon", null, 34.48, 53.9, 49.63, 58.74, 50.91, 50.51, 50.99, 53.82, 44.59, 50.07, 55.25, 67.06, 56.39, 25.3, 48.47, 60.2, 51.01, 64.18, 36.89, 29.64, 45.63, 46.94, 49.78, 60.54, 55.25, 52.62, 36.3, 49.8, 52.4, 50.01);
                yield return new votes_repub("Pennsylvania", 33.95, 56.25, 51.75, 52.2, 62.18, 50.61, 50.84, 52.68, 52.73, 51.45, 60.98, 60.74, 67.99, 58.84, 22.4, 54.25, 65.8, 65.35, 65.24, 50.84, 40.85, 46.34, 48.36, 50.93, 52.74, 56.49, 48.74, 34.5, 44, 59.1, 48.57);
                yield return new votes_repub("Rhode Island", 57.85, 61.22, 62.2, 66.49, 71.94, 59.29, 62.25, 58.07, 53.89, 50.71, 68.33, 59.74, 60.6, 60.76, 35.57, 51.08, 63.97, 59.63, 49.55, 43.31, 40.18, 43.24, 41.26, 41.44, 50.89, 58.31, 36.37, 19.1, 31.8, 53, 44.24);
                yield return new votes_repub("South Carolina", null, null, null, 57.93, 75.95, 50.26, 33.97, 23.72, 17.27, 18.99, 13.51, 7.04, 4.63, 5.97, 1.06, 2.43, 3.9, 2.21, 8.54, 1.89, 1.43, 4.37, 4.46, 3.78, 49.28, 25.18, 48.76, 58.9, 38.1, 70.8, 43.54);
                yield return new votes_repub("South Dakota", null, null, null, null, null, null, null, null, null, 49.48, 49.48, 56.73, 71.09, 58.84, null, 49.8, 60.74, 49.69, 60.18, 34.4, 42.49, 57.41, 58.33, 51.84, 69.27, 58.39, 58.21, 44.4, 53.3, 54.2, 50.92);
                yield return new votes_repub("Tennessee", null, null, null, 68.33, 47.57, 40.21, 44.53, 47.83, 45.85, 37.51, 46.23, 44.93, 43.4, 45.95, 23.84, 42.7, 51.28, 43.59, 53.76, 32.46, 30.81, 32.36, 39.22, 36.87, 49.98, 49.21, 52.92, 44.5, 37.8, 67.7, 43.21);
                yield return new votes_repub("Texas", null, null, null, null, 40.71, 29.96, 23.95, 28.63, 24.73, 19.28, 30.75, 30.83, 21.9, 22.35, 8.77, 17.45, 23.54, 19.78, 51.77, 11.35, 12.31, 19.13, 16.64, 24.6, 53.13, 55.27, 48.52, 36.7, 39.9, 66.2, 48.01);
                yield return new votes_repub("Utah", null, null, null, null, null, null, null, null, null, null, 17.27, 50.59, 61.45, 56.19, 37.46, 37.82, 55.93, 49.26, 53.58, 41.05, 29.79, 37.59, 39.42, 45.52, 58.93, 64.56, 54.81, 45.3, 56.5, 67.6, 64.94);
                yield return new votes_repub("Vermont", 78.23, 75.79, 76.1, 78.57, 78.26, 68.58, 69.88, 66.54, 71.24, 68.1, 80.1, 75.79, 77.98, 75.12, 37.13, 62.44, 75.87, 78.22, 66.88, 57.66, 56.44, 54.79, 57.06, 61.55, 71.46, 72.18, 58.65, 33.7, 52.8, 62.7, 56.01);
                yield return new votes_repub("Virginia", 0.19, 1.15, null, null, 50.48, 40.62, 39.52, 48.9, 49.47, 38.75, 45.9, 43.81, 36.67, 38.36, 17, 32.05, 37.85, 32.79, 53.91, 30.09, 29.39, 31.55, 37.39, 41.04, 56.32, 55.37, 52.44, 46.5, 41.4, 67.8, 50.73);
                yield return new votes_repub("Washington", null, null, null, null, null, null, null, null, null, 41.45, 41.84, 53.44, 69.95, 57.47, 21.82, 43.89, 55.96, 52.24, 67.06, 33.94, 29.88, 40.58, 42.24, 42.68, 54.33, 53.91, 50.68, 38, 45.1, 56.9, 51.37);
                yield return new votes_repub("West Virginia", null, null, 68.95, 58.84, 51.82, 42.47, 41.03, 47.74, 49.03, 46.94, 52.23, 54.27, 55.26, 53.41, 21.1, 49.38, 55.3, 49.45, 58.43, 44.47, 39.2, 42.9, 45.11, 42.24, 48.08, 54.08, 47.27, 32.1, 40.8, 63.6, 41.95);
                yield return new votes_repub("Wisconsin", 55.29, 56.58, 55.88, 56.24, 54.6, 50.9, 54.04, 50.38, 49.77, 46.02, 59.93, 60.04, 63.24, 54.52, 32.68, 49.25, 70.65, 37.06, 53.52, 31.19, 30.26, 48.32, 50.37, 46.28, 60.95, 61.58, 51.77, 37.9, 47.9, 53.4, 49.16);
                yield return new votes_repub("Wyoming", null, null, null, null, null, null, null, null, null, null, null, null, null, null, 34.42, 41.86, 62.38, 52.39, 63.68, 40.82, 37.47, 46.89, 51.23, 47.27, 62.71, 60.04, 55.05, 43.4, 55.8, 69, 59.85);
            }
        }
    }
}
