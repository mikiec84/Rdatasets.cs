// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Southern Oscillation Index Data
    /// </summary>

    public class bomsoi2001
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double Jan;
        public readonly double Feb;
        public readonly double Mar;
        public readonly double Apr;
        public readonly double May;
        public readonly double Jun;
        public readonly double Jul;
        public readonly double Aug;
        public readonly double Sep;
        public readonly double Oct;
        public readonly double Nov;
        public readonly double Dec;
        public readonly double SOI;
        public readonly double avrain;

        public bomsoi2001(int κ, int Year, double Jan, double Feb, double Mar, double Apr, double May, double Jun, double Jul, double Aug, double Sep, double Oct, double Nov, double Dec, double SOI, double avrain)
        {
            this.κ = κ;
            this.Year = Year;
            this.Jan = Jan;
            this.Feb = Feb;
            this.Mar = Mar;
            this.Apr = Apr;
            this.May = May;
            this.Jun = Jun;
            this.Jul = Jul;
            this.Aug = Aug;
            this.Sep = Sep;
            this.Oct = Oct;
            this.Nov = Nov;
            this.Dec = Dec;
            this.SOI = SOI;
            this.avrain = avrain;
        }

        public static IEnumerable<bomsoi2001> Data
        {
            get
            {
                yield return new bomsoi2001(25, 1900, -7.3, -6.5, -25.3, -18.7, -7.4, 26.1, 10, 7.8, -16.6, -17.2, -6, -5.5, -5.55, 368.7);
                yield return new bomsoi2001(26, 1901, -0.1, 3, 9.4, 4.5, -0.3, 19.6, 14.6, 9.8, -16, -22.1, -8.6, -1.9, 0.991666666666667, 401.7);
                yield return new bomsoi2001(27, 1902, 17, -2.2, 11.6, 7.8, 7.6, 2.6, 1.6, -8.9, -17.8, -7.4, -3.4, -3, 0.458333333333333, 317.2);
                yield return new bomsoi2001(28, 1903, -9.2, -10.2, 17.6, 17.7, 7.6, -0.6, 6.1, 0.1, 8.7, 4.2, 1.3, 15.9, 4.93333333333333, 518.6);
                yield return new bomsoi2001(29, 1904, 14.1, 16.2, 9.4, 31.7, 9.2, -7.1, -8.9, 0.8, 0.2, 1.2, -17.2, 2.6, 4.35, 504.7);
                yield return new bomsoi2001(30, 1905, -9.2, -16.8, -30.2, -42.6, -37.4, -31.4, -21.3, -7.6, -7, -5.6, -17.9, -13.1, -20.0083333333333, 320.4);
                yield return new bomsoi2001(31, 1906, -3.5, -7.4, -5.2, -8.8, 1.3, -3.9, 6.8, 15.5, 18.3, 9.1, 21.7, 4.7, 4.05, 485.3);
                yield return new bomsoi2001(32, 1907, 5.1, 1.6, -0.3, 4.5, 10, 8.3, -4.3, -8.2, 0.2, 0.6, -2, 8.8, 2.025, 451);
                yield return new bomsoi2001(33, 1908, -10.6, 7.7, 0.2, 16.8, -1.1, -2.3, 2.2, 5.3, 17.7, 7.9, 2.6, -5.5, 3.40833333333333, 447);
                yield return new bomsoi2001(34, 1909, -2.5, -3.2, -0.3, -14.5, 2.1, 22.8, 10.7, 9.8, 0.8, 4.2, 9.2, 4.7, 3.65, 436.2);
                yield return new bomsoi2001(35, 1910, 5.6, 15.2, 12.7, 5.3, 0.5, 22, 20.5, 9.8, 15.3, 10.3, 19.7, 15.9, 12.7333333333333, 523.4);
                yield return new bomsoi2001(36, 1911, 3.2, 1.6, 3.5, 2, -8.2, -12, -12.8, -12.1, -8.8, -11.7, -7.3, -1.4, -5.33333333333333, 427.4);
                yield return new bomsoi2001(37, 1912, -9.7, -17.3, -9, -21.1, -13, -6.3, -0.4, -7.6, -4, -8, 2.6, -8, -8.48333333333333, 378);
                yield return new bomsoi2001(38, 1913, -3.5, -5, 1.3, -6.3, -8.2, -3.9, -1.7, -7.6, -9.4, -9.2, -11.9, -7, -6.03333333333333, 442.1);
                yield return new bomsoi2001(39, 1914, -5.4, 2, 9.4, -14.5, -0.3, -16.8, -18, -17.2, -12.4, -8.6, -11.9, -1.4, -7.925, 425.2);
                yield return new bomsoi2001(40, 1915, -21.6, -2.2, -20.4, -17.8, -12.2, 6.6, 14, 7.2, 7.5, 2.4, -14.6, 9.8, -3.44166666666667, 386.5);
                yield return new bomsoi2001(41, 1916, 5.6, -3.6, -6.3, -0.5, 6.8, 9.1, 25.7, 16.2, 4.5, 6.1, 9.8, 15.4, 7.4, 533.8);
                yield return new bomsoi2001(42, 1917, 5.1, 10, 18.1, 21.8, 21.8, 21.2, 28.3, 34.8, 29.7, 15.2, 21, 22.5, 20.7916666666667, 579.5);
                yield return new bomsoi2001(43, 1918, 14.6, 16.6, -2, 16.8, 10, -4.7, -14.1, -4.4, -8.2, -5, 1.3, -8, 1.075, 433.1);
                yield return new bomsoi2001(44, 1919, -14.9, -11.2, -12.8, -3, -7.4, -10.4, -8.9, -6.9, -5.8, -10.5, -11.3, -9.1, -9.35, 361.2);
                yield return new bomsoi2001(45, 1920, 1.8, -1.7, -4.1, 0.3, -2.7, 6.6, 9.4, 5.3, 5.1, -4.3, -0.1, 9.8, 2.11666666666667, 513.7);
                yield return new bomsoi2001(46, 1921, 10.8, 6.7, 8.9, -7.1, 2.1, 22, 2.9, -6.9, 5.1, 9.7, 8.5, 8.2, 5.90833333333333, 548.1);
                yield return new bomsoi2001(47, 1922, 8, 9.1, 5.6, -5.5, -5.1, 5.8, 2.2, -1.2, 5.1, 6.1, 8.5, 11.8, 4.2, 420.9);
                yield return new bomsoi2001(48, 1923, 5.6, 4.4, 8.9, 8.6, 2.1, 1, -11.5, -18.5, -14.8, -6.2, -12.6, 2.1, -2.575, 411.6);
                yield return new bomsoi2001(49, 1924, -5.4, 1.1, 2.4, -15.4, 11.5, 8.3, 7.4, 10.4, 8.1, 7.9, 11.8, 5.2, 4.44166666666667, 402.5);
                yield return new bomsoi2001(50, 1925, 5.6, 13.8, 14.9, 14.4, -1.1, -4.7, -13.4, -10.8, -6.4, -12.9, -9.3, -7, -1.40833333333333, 425.3);
                yield return new bomsoi2001(51, 1926, -5.4, -14.5, -13.3, -7.1, -2.7, -7.1, -1, -7.6, 1.4, 4.2, 1.3, 6.2, -3.8, 423);
                yield return new bomsoi2001(52, 1927, 5.1, 1.1, 18.1, 6.9, 6, 8.3, 6.1, -5, -0.4, -4.3, -8, 7.7, 3.46666666666667, 422.8);
                yield return new bomsoi2001(53, 1928, -10.1, 10.5, 13.8, 11.9, -2.7, -7.9, -0.4, 9.8, 8.1, 9.1, 2.6, 11.8, 4.70833333333333, 356.9);
                yield return new bomsoi2001(54, 1929, 16, 18, 5.1, 4.5, -12.2, 1, 1.6, 0.1, -0.4, 7.9, 11.1, 5.7, 4.86666666666667, 372.1);
                yield return new bomsoi2001(55, 1930, 12.7, 7.7, 1.8, -3.8, 2.1, -5.5, -4.3, -1.8, -7, 3.6, 1.9, -1.4, 0.5, 493);
                yield return new bomsoi2001(56, 1931, 7, -14.9, 5.6, 8.6, 13.1, 18.8, 9.4, 0.1, 5.1, -12.9, -4.7, 4.7, 3.325, 435.5);
                yield return new bomsoi2001(57, 1932, 1.8, -3.6, -2.5, -2.1, 2.8, -4.7, -5, -6.9, -8.8, -4.3, -4.7, 3.2, -2.9, 386.9);
                yield return new bomsoi2001(58, 1933, -11.1, 4.9, -2, 3.6, 6, -3.9, 3.5, -0.5, 2, 3.6, 7.2, 8.2, 1.79166666666667, 442.1);
                yield return new bomsoi2001(59, 1934, 6.5, 0.1, 0.2, 6.1, -7.4, 10.7, 2.9, -22.4, -6.4, 4.2, 13.1, -2.4, 0.433333333333333, 441.7);
                yield return new bomsoi2001(60, 1935, 6.5, -4.6, 12.2, 2.8, -6.6, -2.3, -0.4, 2.1, 6.3, 7.3, 3.9, -4, 1.93333333333333, 347.3);
                yield return new bomsoi2001(61, 1936, -2, 0.6, 1.8, 22.6, 4.4, -1.5, 4.2, -8.9, 2.6, -0.1, -13.9, 0.6, 0.866666666666666, 398.8);
                yield return new bomsoi2001(62, 1937, 9.4, -5, 6.2, 2, -0.3, 3.4, -5.6, 3.3, 0.8, -2.5, -2, 6.7, 1.36666666666667, 384.4);
                yield return new bomsoi2001(63, 1938, 7.5, 3.4, -3.6, 3.6, 13.1, 18, 18.5, 13, 7.5, 12.8, 1.9, 13.8, 9.125, 361.8);
                yield return new bomsoi2001(64, 1939, 17, 7.7, 11.6, 9.4, -1.1, -1.5, 8.1, -0.5, -9.4, -14.7, -8, -8.6, 0.833333333333333, 489);
                yield return new bomsoi2001(65, 1940, -0.1, -4.1, -10.6, -9.6, -14.5, -19.3, -15.4, -18.5, -19.6, -18.4, -6.7, -29.4, -13.85, 392.7);
                yield return new bomsoi2001(66, 1941, -9.7, -15.4, -10.6, -11.2, -6.6, -14.4, -20.6, -19.1, -8.2, -20.2, -9.3, -8.6, -12.825, 477.4);
                yield return new bomsoi2001(67, 1942, -13, -3.6, -5.8, -5.5, 5.2, 8.3, -1, 4, 8.7, 8.5, -4, 13.8, 1.3, 537.5);
                yield return new bomsoi2001(68, 1943, 9.4, 10.5, 4, 13.5, 2.8, -7.9, 2.9, 7.8, 5.7, 9.1, 3.9, -8.6, 4.425, 393);
                yield return new bomsoi2001(69, 1944, -8.2, 3.9, 5.6, -5.5, -1.1, -3.9, -8.9, 3.3, 2.6, -8.6, -6.7, 4.2, -1.94166666666667, 378.7);
                yield return new bomsoi2001(70, 1945, 5.1, 6.3, 13.2, -7.1, -0.3, 8.3, 3.5, 11.7, 8.7, 2.4, -3.4, 6.7, 4.59166666666667, 407.9);
                yield return new bomsoi2001(71, 1946, -2.5, 4.4, -2, -9.6, -11.4, -9.6, -10.2, -4.4, -16, -12.3, -1.4, -5.5, -6.70833333333333, 403.3);
                yield return new bomsoi2001(72, 1947, -4.9, -4.1, 11.6, -4.6, -13.7, 2.6, 9.4, 7.2, 11.7, -1.9, 9.2, 5.2, 2.30833333333333, 509.3);
                yield return new bomsoi2001(73, 1948, -3, -2.7, -4.1, 2.8, 3.6, -4.7, 0.9, -4.4, -7.6, 6.1, 4.6, -5.5, -1.16666666666667, 384.3);
                yield return new bomsoi2001(74, 1949, -7.3, 2, 5.6, 1.2, -5.8, -12, -1.7, -4.4, 2, 5.4, -6, 7.7, -1.10833333333333, 480.4);
                yield return new bomsoi2001(75, 1950, 5.1, 17.6, 17.6, 16.8, 7.6, 26.9, 21.1, 12.3, 6.9, 17.1, 12.5, 23, 15.375, 633.2);
                yield return new bomsoi2001(76, 1951, 16.5, 9.6, -1.4, -1.3, -6.6, 5, -8.2, -0.5, -7, -8, -3.4, -3, -0.691666666666666, 366);
                yield return new bomsoi2001(77, 1952, -9.2, -7.9, 0.2, -8.8, 6, 7.4, 3.5, -3.7, -3.4, 1.8, -0.7, -12.6, -2.28333333333333, 380.8);
                yield return new bomsoi2001(78, 1953, 2.2, -6, -5.8, -0.5, -31.9, -2.3, -1, -17.2, -13, -0.1, -2, -4, -6.8, 427.8);
                yield return new bomsoi2001(79, 1954, 6, -3.6, -0.9, 6.9, 4.4, -1.5, 4.2, 10.4, 4.5, 1.8, 3.9, 12.8, 4.075, 460.2);
                yield return new bomsoi2001(80, 1955, -5.4, 15.2, 2.9, -3, 13.1, 16.4, 19.2, 14.9, 14.1, 15.2, 15.1, 9.3, 10.5833333333333, 581.9);
                yield return new bomsoi2001(81, 1956, 11.3, 12.4, 9.4, 11.1, 17.9, 12.3, 12.6, 11, 0.2, 18.3, 1.9, 10.3, 10.725, 604.4);
                yield return new bomsoi2001(82, 1957, 5.6, -2.2, -0.9, 1.2, -12.2, -2.3, 0.9, -9.5, -10.6, -1.3, -11.9, -3.5, -3.89166666666667, 385);
                yield return new bomsoi2001(83, 1958, -16.8, -6.9, -1.4, 1.2, -8.2, 0.2, 2.2, 7.8, -3.4, -1.9, -4.7, -6.5, -3.2, 421.6);
                yield return new bomsoi2001(84, 1959, -8.7, -14, 8.4, 3.6, 2.8, -6.3, -5, -5, 0.2, 4.2, 11.1, 8.2, -0.0416666666666668, 415.6);
                yield return new bomsoi2001(85, 1960, 0.3, -2.2, 5.6, 7.8, 5.2, -2.3, 4.8, 6.6, 6.9, -0.7, 7.2, 6.7, 3.825, 472.2);
                yield return new bomsoi2001(86, 1961, -2.5, 6.3, -20.9, 9.4, 1.3, -3.1, 2.2, 0.1, 0.8, -5, 7.2, 13.8, 0.8, 336.3);
                yield return new bomsoi2001(87, 1962, 17, 5.3, -1.4, 1.2, 12.3, 5, -0.4, 4.6, 5.1, 10.3, 5.2, 0.6, 5.4, 439);
                yield return new bomsoi2001(88, 1963, 9.4, 3, 7.3, 6.1, 2.8, -9.6, -1, -2.4, -5.2, -12.9, -9.3, -11.6, -1.95, 484.8);
                yield return new bomsoi2001(89, 1964, -4, -0.3, 8.4, 13.5, 2.8, 7.4, 6.8, 14.3, 14.1, 12.8, 2.6, -3, 6.28333333333333, 427.2);
                yield return new bomsoi2001(90, 1965, -4, 1.6, 2.9, -12.9, -0.3, -12.8, -22.6, -11.4, -14.2, -11.1, -17.9, 1.6, -8.425, 347.7);
                yield return new bomsoi2001(91, 1966, -12, -4.1, -13.9, -7.1, -9, 1, -1, 4, -2.2, -2.5, -0.1, -4, -4.24166666666667, 404.6);
                yield return new bomsoi2001(92, 1967, 14.6, 12.9, 7.8, -3, -3.5, 6.6, 1.6, 5.9, 5.1, -0.1, -4, -5.5, 3.2, 434.8);
                yield return new bomsoi2001(93, 1968, 4.1, 9.6, -3, -3, 14.7, 12.3, 7.4, 0.1, -2.8, -1.9, -3.4, 2.1, 3.01666666666667, 552.6);
                yield return new bomsoi2001(94, 1969, -13.5, -6.9, 1.8, -8.8, -6.6, -0.6, -6.9, -4.4, -10.6, -11.7, -0.1, 3.7, -5.38333333333333, 416.2);
                yield return new bomsoi2001(95, 1970, -10.1, -10.7, 1.8, -4.6, 2.1, 9.9, -5.6, 4, 12.9, 10.3, 19.7, 17.4, 3.925, 384.5);
                yield return new bomsoi2001(96, 1971, 2.7, 15.7, 19.2, 22.6, 9.2, 2.6, 1.6, 14.9, 15.9, 17.7, 7.2, 2.1, 10.95, 493.7);
                yield return new bomsoi2001(97, 1972, 3.7, 8.2, 2.4, -5.5, -16.1, -12, -18.6, -8.9, -14.8, -11.1, -3.4, -12.1, -7.35, 364.7);
                yield return new bomsoi2001(98, 1973, -3, -13.5, 0.8, -2.1, 2.8, 12.3, 6.1, 12.3, 13.5, 9.7, 31.6, 16.9, 7.28333333333333, 661.3);
                yield return new bomsoi2001(99, 1974, 20.8, 16.2, 20.3, 11.1, 10.7, 2.6, 12, 6.6, 12.3, 8.5, -1.4, -0.9, 9.9, 784.2);
                yield return new bomsoi2001(100, 1975, -4.9, 5.3, 11.6, 14.4, 6, 15.5, 21.1, 20.7, 22.5, 17.7, 13.8, 19.5, 13.6, 603.5);
                yield return new bomsoi2001(101, 1976, 11.8, 12.9, 13.2, 1.2, 2.1, 0.2, -12.8, -12.1, -13, 3, 9.8, -3, 1.10833333333333, 527.8);
                yield return new bomsoi2001(102, 1977, -4, 7.7, -9.5, -9.6, -11.4, -17.7, -14.7, -12.1, -9.4, -12.9, -14.6, -10.6, -9.9, 471.8);
                yield return new bomsoi2001(103, 1978, -3, -24.4, -5.8, -7.9, 16.3, 5.8, 6.1, 1.4, 0.8, -6.2, -2, -0.9, -1.65, 525.7);
                yield return new bomsoi2001(104, 1979, -4, 6.7, -3, -5.5, 3.6, 5.8, -8.2, -5, 1.4, -2.5, -4.7, -7.5, -1.90833333333333, 455.6);
                yield return new bomsoi2001(105, 1980, 3.2, 1.1, -8.5, -12.9, -3.5, -4.7, -1.7, 1.4, -5.2, -1.9, -3.4, -0.9, -3.08333333333333, 433);
                yield return new bomsoi2001(106, 1981, 2.7, -3.2, -16.6, -5.5, 7.6, 11.5, 9.4, 5.9, 7.5, -5, 2.6, 4.7, 1.8, 535.1);
                yield return new bomsoi2001(107, 1982, 9.4, 0.6, 2.4, -3.8, -8.2, -20.1, -19.3, -23.6, -21.4, -20.2, -31.1, -21.3, -13.05, 421.4);
                yield return new bomsoi2001(108, 1983, -30.6, -33.3, -28, -17, 6, -3.1, -7.6, 0.1, 9.9, 4.2, -0.7, 0.1, -8.33333333333333, 499.3);
                yield return new bomsoi2001(109, 1984, 1.3, 5.8, -5.8, 2, -0.3, -8.7, 2.2, 2.7, 2, -5, 3.9, -1.4, -0.108333333333333, 555.2);
                yield return new bomsoi2001(110, 1985, -3.5, 6.7, -2, 14.4, 2.8, -9.6, -2.3, 8.5, 0.2, -5.6, -1.4, 2.1, 0.858333333333334, 398.9);
                yield return new bomsoi2001(111, 1986, 8, -10.7, 0.8, 1.2, -6.6, 10.7, 2.2, -7.6, -5.2, 6.1, -13.9, -13.6, -2.38333333333333, 392);
                yield return new bomsoi2001(112, 1987, -6.3, -12.6, -16.6, -24.4, -21.6, -20.1, -18.6, -14, -11.2, -5.6, -1.4, -4.5, -13.075, 453.4);
                yield return new bomsoi2001(113, 1988, -1.1, -5, 2.4, -1.3, 10, -3.9, 11.3, 14.9, 20.1, 14.6, 21, 10.8, 7.81666666666667, 459.8);
                yield return new bomsoi2001(114, 1989, 13.2, 9.1, 6.7, 21, 14.7, 7.4, 9.4, -6.3, 5.7, 7.3, -2, -5, 6.76666666666667, 483.8);
                yield return new bomsoi2001(115, 1990, -1.1, -17.3, -8.5, -0.5, 13.1, 1, 5.5, -5, -7.6, 1.8, -5.3, -2.4, -2.19166666666667, 417.7);
                yield return new bomsoi2001(116, 1991, 5.1, 0.6, -10.6, -12.9, -19.3, -5.5, -1.7, -7.6, -16.6, -12.9, -7.3, -16.7, -8.78333333333333, 469.3);
                yield return new bomsoi2001(117, 1992, -25.4, -9.3, -24.2, -18.7, 0.5, -12.8, -6.9, 1.4, 0.8, -17.2, -7.3, -5.5, -10.3833333333333, 452.4);
                yield return new bomsoi2001(118, 1993, -8.2, -7.9, -8.5, -21.1, -8.2, -16, -10.8, -14, -7.6, -13.5, 0.6, 1.6, -9.46666666666667, 499.4);
                yield return new bomsoi2001(119, 1994, -1.6, 0.6, -10.6, -22.8, -13, -10.4, -18, -17.2, -17.2, -14.1, -7.3, -11.6, -11.9333333333333, 340.6);
                yield return new bomsoi2001(120, 1995, -4, -2.7, 3.5, -16.2, -9, -1.5, 4.2, 0.8, 3.2, -1.3, 1.3, -5.5, -2.26666666666667, 522.8);
                yield return new bomsoi2001(121, 1996, 8.4, 1.1, 6.2, 7.8, 1.3, 13.9, 6.8, 4.6, 6.9, 4.2, -0.1, 7.2, 5.69166666666667, 469.9);
                yield return new bomsoi2001(122, 1997, 4.1, 13.3, -8.5, -16.2, -22.4, -24.1, -9.5, -19.8, -14.8, -17.8, -15.2, -9.1, -11.6666666666667, 527.3);
                yield return new bomsoi2001(123, 1998, -23.5, -19.2, -28.5, -24.4, 0.5, 9.9, 14.6, 9.8, 11.1, 10.9, 12.5, 13.3, -1.08333333333333, 565.5);
                yield return new bomsoi2001(124, 1999, 15.6, 8.6, 8.9, 18.5, 1.3, 1, 4.8, 2.1, -0.4, 9.1, 13.1, 12.8, 7.95, 584.1);
                yield return new bomsoi2001(125, 2000, 5.1, 12.9, 9.4, 16.8, 3.6, -5.5, -3.7, 5.3, 9.9, 9.7, 22.4, 7.7, 7.8, 727.3);
                yield return new bomsoi2001(126, 2001, 8.9, 11.9, 6.7, 0.3, -9, 1.8, -3, -8.9, 1.4, -1.9, 7.2, -9.1, 0.525, 553.1);
            }
        }
    }
}
