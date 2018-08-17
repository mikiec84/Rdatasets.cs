// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Snowfall data for Grand Rapids, MI
    /// </summary>

    public class SnowGR
    {
        public readonly int SeasonStart;
        public readonly int SeasonEnd;
        public readonly int Jul;
        public readonly int Aug;
        public readonly int Sep;
        public readonly double Oct;
        public readonly double Nov;
        public readonly double Dec;
        public readonly string Jan;
        public readonly string Feb;
        public readonly string Mar;
        public readonly string Apr;
        public readonly string May;
        public readonly string Jun;
        public readonly string Total;

        public SnowGR(int SeasonStart, int SeasonEnd, int Jul, int Aug, int Sep, double Oct, double Nov, double Dec, string Jan, string Feb, string Mar, string Apr, string May, string Jun, string Total)
        {
            this.SeasonStart = SeasonStart;
            this.SeasonEnd = SeasonEnd;
            this.Jul = Jul;
            this.Aug = Aug;
            this.Sep = Sep;
            this.Oct = Oct;
            this.Nov = Nov;
            this.Dec = Dec;
            this.Jan = Jan;
            this.Feb = Feb;
            this.Mar = Mar;
            this.Apr = Apr;
            this.May = May;
            this.Jun = Jun;
            this.Total = Total;
        }

        public static IEnumerable<SnowGR> Data
        {
            get
            {
                yield return new SnowGR(1893, 1894, 0, 0, 0, 0, 8, 24.9, "12.5", "6.8", "4.8", "2", "0", "0", "59");
                yield return new SnowGR(1894, 1895, 0, 0, 0, 0, 7.5, 5.3, "21.5", "8", "22.5", "0", "0", "0", "64.8");
                yield return new SnowGR(1895, 1896, 0, 0, 0, 0.4, 23.2, 15, null, "8.5", "2", "0", "0", "0", "49.1");
                yield return new SnowGR(1896, 1897, 0, 0, 0, 0.2, 8, 8, "4.9", "11.2", "12", "0", "0", "0", "44.3");
                yield return new SnowGR(1897, 1898, 0, 0, 0, 0, 1.4, 8, "15.5", "29.5", "0", "0", "0", "0", "54.4");
                yield return new SnowGR(1898, 1899, 0, 0, 0, 0, 18.5, 18, "20", "3.4", "16", "0", "0", "0", "75.9");
                yield return new SnowGR(1899, 1900, 0, 0, 0, 0, 1.5, 7.2, "12", "35.5", "19", "3.5", "0", "0", "78.7");
                yield return new SnowGR(1900, 1901, 0, 0, 0, 0, 8, 5.5, "22.5", "23", "5.5", "0", "0", "0", "64.5");
                yield return new SnowGR(1901, 1902, 0, 0, 0, 0, 0.5, 9, "4", "11", "3.5", "0.3", "5.5", "0", "33.8");
                yield return new SnowGR(1902, 1903, 0, 0, 0, 0, 2.5, 5.1, "7", "5.3", null, "0.3", "0", "0", "20.2");
                yield return new SnowGR(1903, 1904, 0, 0, 0, 0, 5, 22.1, "15.6", "11.9", "20", "3.2", "0", "0", "77.8");
                yield return new SnowGR(1904, 1905, 0, 0, 0, 0, 0.6, 15.7, "14.5", "18.8", "2.4", "1.7", "0", "0", "53.7");
                yield return new SnowGR(1905, 1906, 0, 0, 0, 0, 0.1, 5.3, "5.6", "2.7", "6.3", "0", "0", "0", "20");
                yield return new SnowGR(1906, 1907, 0, 0, 0, 2.6, 0, 3.8, "13.1", "2.4", "5.1", "3.1", "0", "0", "30.1");
                yield return new SnowGR(1907, 1908, 0, 0, 0, 0, 0, 13.8, "11.7", "17.6", "0.2", "0.1", "0", "0", "43.4");
                yield return new SnowGR(1908, 1909, 0, 0, 0, 0, 4.8, 7.4, "9", "8.4", "2.8", "2.9", "0.3", "0", "35.6");
                yield return new SnowGR(1909, 1910, 0, 0, 0, 0.2, 1.8, 24.2, "10.3", "4.9", "0", "0", "0", "0", "41.4");
                yield return new SnowGR(1910, 1911, 0, 0, 0, 0.1, 4, 18.4, "7.8", "7", "3", "0.6", "0", "0", "40.9");
                yield return new SnowGR(1911, 1912, 0, 0, 0, 0, 6.2, 15.9, "14.7", "17", "13.7", "3", "0", "0", "70.5");
                yield return new SnowGR(1912, 1913, 0, 0, 0, 0, 7.1, 2.3, "13.1", "9.9", "9.6", "0", "0", "0", "42");
                yield return new SnowGR(1913, 1914, 0, 0, 0, 0.3, 1, 2.3, "27", "14.6", "7.5", "4.5", "0", "0", "57.2");
                yield return new SnowGR(1914, 1915, 0, 0, 0, 0, 9.2, 17.6, "6", "5.1", "9.8", "0.4", "0.2", "0", "48.3");
                yield return new SnowGR(1915, 1916, 0, 0, 0, 0, 3.6, 12.6, "10.4", "13.3", "15.9", "0", "0", "0", "55.8");
                yield return new SnowGR(1916, 1917, 0, 0, 0, 0, 1, 23.1, "16.1", "8.4", "3.2", "0.1", "0", "0", "51.9");
                yield return new SnowGR(1917, 1918, 0, 0, 0, 3, 3.6, 9.7, "45", "5.6", "5", "0", "0", "0", "71.9");
                yield return new SnowGR(1918, 1919, 0, 0, 0, 0, 0.3, 7.6, "4.6", "6.2", "18.2", "5", "0", "0", "41.9");
                yield return new SnowGR(1919, 1920, 0, 0, 0, 0, 3.5, 15, "15.8", "12.2", "3.4", "6.5", "0", "0", "56.4");
                yield return new SnowGR(1920, 1921, 0, 0, 0, 0, 6.5, 13.6, "1.1", "8.5", "1.8", "1", "0", "0", "32.5");
                yield return new SnowGR(1921, 1922, 0, 0, 0, 0, 9.7, 10.7, "5.4", "9.1", "8.8", "0", "0", "0", "43.7");
                yield return new SnowGR(1922, 1923, 0, 0, 0, 0, 2, 7.4, "13.1", "13.2", "9.6", "3.7", "5.5", "0", "54.5");
                yield return new SnowGR(1923, 1924, 0, 0, 0, 1.5, 0.8, 9, "18.5", "9", "8.7", "4", "0", "0", "51.5");
                yield return new SnowGR(1924, 1925, 0, 0, 0, 0, 7.1, 12.5, "7.7", "6.1", "7", "0", "0", "0", "40.4");
                yield return new SnowGR(1925, 1926, 0, 0, 0, 7.5, 8.4, 17.1, "15.5", "16.9", "12.9", "11.2", "0", "0", "89.5");
                yield return new SnowGR(1926, 1927, 0, 0, 0, 0, 6.6, 13.3, "12", "3", "1", "1.5", "0", "0", "37.4");
                yield return new SnowGR(1927, 1928, 0, 0, 0, 0, 0.1, 17, "10.4", "9.6", "11.2", "0.8", "0", "0", "49.1");
                yield return new SnowGR(1928, 1929, 0, 0, 0, 0, 3.5, 8, "30.8", "8.2", "1.8", "0", "3", "0", "55.3");
                yield return new SnowGR(1929, 1930, 0, 0, 0, 0, 9.1, 28.9, "37.3", "5.9", "14.3", "0", "0", "0", "95.5");
                yield return new SnowGR(1930, 1931, 0, 0, 0, 0.4, 3.7, 18, "19.6", "7.2", "11.5", "0", "0", "0", "60.4");
                yield return new SnowGR(1931, 1932, 0, 0, 0, 0, 0, 7, "3.1", "5.2", "25.3", "0.3", "0", "0", "40.9");
                yield return new SnowGR(1932, 1933, 0, 0, 0, 0.3, 4.9, 6.8, "0.8", "21.1", "8.2", "0.9", "0", "0", "43");
                yield return new SnowGR(1933, 1934, 0, 0, 0, 0, 11.2, 14, "1.4", "8.7", "1.7", "1.1", "0", "0", "38.1");
                yield return new SnowGR(1934, 1935, 0, 0, 0, 0, 0.3, 15.5, "7.3", "21.2", "7.3", "2.2", "0.4", "0", "54.2");
                yield return new SnowGR(1935, 1936, 0, 0, 0, 0, 2.3, 9, "24.3", "27.3", "3", "10.1", "0", "0", "76");
                yield return new SnowGR(1936, 1937, 0, 0, 0, 0.8, 3.4, 6.5, "6.3", "12", "3.9", "0.9", "0", "0", "33.8");
                yield return new SnowGR(1937, 1938, 0, 0, 0, 0, 4.4, 14.9, "10.2", "6.9", "2.9", "8.7", "0", "0", "48");
                yield return new SnowGR(1938, 1939, 0, 0, 0, 0, 5.6, 10.8, "21.5", "11.2", "11", "4.9", "0", "0", "65");
                yield return new SnowGR(1939, 1940, 0, 0, 0, 0, 0.8, 7.3, "16.1", "9.3", "19.9", "1.6", "0.8", "0", "55.8");
                yield return new SnowGR(1940, 1941, 0, 0, 0, 0, 17.3, 7, "10.4", "9.9", "10.1", "0", "0", "0", "54.7");
                yield return new SnowGR(1941, 1942, 0, 0, 0, 0, 5.4, 5.4, "31.2", "12.8", "12.2", "2", "0", "0", "69");
                yield return new SnowGR(1942, 1943, 0, 0, 0, 0, 5.1, 11.5, "27.1", "8.5", "9.2", "2.7", "0", "0", "64.1");
                yield return new SnowGR(1943, 1944, 0, 0, 0, 0, 9.1, 4.2, "3.7", "9.5", "8.8", "0.4", "0", "0", "35.7");
                yield return new SnowGR(1944, 1945, 0, 0, 0, 0, 4.9, 21.9, "17.6", "8.6", "0", "0", "0", "0", "53");
                yield return new SnowGR(1945, 1946, 0, 0, 0, 0, 9.2, 16.1, "10.2", "22.7", "2.9", "0", "0", "0", "61.1");
                yield return new SnowGR(1946, 1947, 0, 0, 0, 0, 0, 0.9, "18.6", "16.9", "17.2", "0.1", "0", "0", "53.7");
                yield return new SnowGR(1947, 1948, 0, 0, 0, 0, 10.6, 0.8, "21", "8.5", "16.1", "0", "0", "0", "57");
                yield return new SnowGR(1948, 1949, 0, 0, 0, 0, 0, 8.3, "8.1", "7.9", "7.6", "1.4", "0", "0", "33.3");
                yield return new SnowGR(1949, 1950, 0, 0, 0, 0, 7.1, 16.5, "6.2", "16.8", "14.2", "0.7", "0", "0", "61.5");
                yield return new SnowGR(1950, 1951, 0, 0, 0, 0, 17.5, 24, "18.4", "4.8", "11.1", "5.7", "0", "0", "81.5");
                yield return new SnowGR(1951, 1952, 0, 0, 0, 0, 26.9, 51.3, "21.2", "12.6", "9.5", "10.5", "0", "0", "132");
                yield return new SnowGR(1952, 1953, 0, 0, 0, 0, 6.4, 9.5, "11", "6.7", "4.9", "1.2", "0", "0", "39.7");
                yield return new SnowGR(1953, 1954, 0, 0, 0, 0, 7.4, 12.4, "23.7", "10.9", "21.9", "0", "2", "0", "78.3");
                yield return new SnowGR(1954, 1955, 0, 0, 0, 0.4, 3.2, 12.3, "25.1", "12.7", "15.1", "0", "0", "0", "68.8");
                yield return new SnowGR(1955, 1956, 0, 0, 0, 0, 18.6, 9.4, "5.3", "22.9", "17.5", "5.6", "0", "0", "79.3");
                yield return new SnowGR(1956, 1957, 0, 0, 0, 0, 6.1, 6.3, "25.4", "8.2", "11.1", "2.9", "0", "0", "60");
                yield return new SnowGR(1957, 1958, 0, 0, 0, 0, 9.9, 17.4, "23.6", "10.6", "8.8", "0", "0", "0", "70.3");
                yield return new SnowGR(1958, 1959, 0, 0, 0, 0, 8.6, 26.6, "32.6", "16.6", "19.9", "0.4", "0", "0", "104.7");
                yield return new SnowGR(1959, 1960, 0, 0, 0, 0, 15.3, 10.6, "25", "25.6", "13.2", "1", "0", "0", "90.7");
                yield return new SnowGR(1960, 1961, 0, 0, 0, 0, 5.9, 13.5, "30", "4.2", "5.6", "15.6", "0", "0", "74.8");
                yield return new SnowGR(1961, 1962, 0, 0, 0, 0, 0.6, 18.7, "36.1", "21.4", "8", "3.1", "0", "0", "87.9");
                yield return new SnowGR(1962, 1963, 0, 0, 0, 2.6, 0.8, 26.2, "42.6", "8.4", "5", "4.1", "0", "0", "89.7");
                yield return new SnowGR(1963, 1964, 0, 0, 0, 0, 0.9, 21.6, "18.6", "11.6", "16.5", "1.2", "0", "0", "70.4");
                yield return new SnowGR(1964, 1965, 0, 0, 0, 0, 5.8, 13.4, "24.1", "16.7", "36", "5.4", "0", "0", "101.4");
                yield return new SnowGR(1965, 1966, 0, 0, 0, 0, 9.1, 9.6, "25.9", "15", "4.6", "2.8", "0", "0", "67");
                yield return new SnowGR(1966, 1967, 0, 0, 0, 0, 16.6, 17.6, "29.8", "17.5", "10.3", "0", "0", "0", "91.8");
                yield return new SnowGR(1967, 1968, 0, 0, 0, 8.4, 11, 9.6, "11.8", "8.5", "4.2", "1.6", "0", "0", "55.1");
                yield return new SnowGR(1968, 1969, 0, 0, 0, 0, 4.2, 26.2, "27.7", "6.3", "7.9", "0", "0", "0", "72.3");
                yield return new SnowGR(1969, 1970, 0, 0, 0, 0, 14.3, 11.8, "23.2", "8.2", "19.3", "7.8", "0", "0", "84.6");
                yield return new SnowGR(1970, 1971, 0, 0, 0, 0, 6.1, 33.3, "27.2", "4.4", "25.9", "4.1", "0", "0", "101");
                yield return new SnowGR(1971, 1972, 0, 0, 0, 0, 14.9, 3.7, "22.6", "16.9", "14.2", "7.5", "0", "0", "79.8");
                yield return new SnowGR(1972, 1973, 0, 0, 0, 0.9, 11, 19.8, "7", "13.2", "8.5", "5", "0.1", "0", "65.5");
                yield return new SnowGR(1973, 1974, 0, 0, 0, 0, 0.4, 20, "13.3", "18.4", "11.3", "1", "0", "0", "64.4");
                yield return new SnowGR(1974, 1975, 0, 0, 0, 0.4, 8.9, 16.5, "10.7", "10.6", "11.8", "10", "0", "0", "68.9");
                yield return new SnowGR(1975, 1976, 0, 0, 0, 0, 6.6, 23.3, "25", "6.5", "3.5", "4.2", "0.1", "0", "69.2");
                yield return new SnowGR(1976, 1977, 0, 0, 0, 2, 8.5, 17.7, "26.1", "5", "9.5", "2", "0", "0", "70.8");
                yield return new SnowGR(1977, 1978, 0, 0, 0, 0, 10.6, 23.2, "35.8", "8.8", "6.2", "0", "0", "0", "84.6");
                yield return new SnowGR(1978, 1979, 0, 0, 0, 0, 6.2, 30, "45.5", "5.3", "7.2", "1.8", "0", "0", "96");
                yield return new SnowGR(1979, 1980, 0, 0, 0, 0, 9.4, 2.6, "13.3", "12.6", "6.6", "4", "0", "0", "48.5");
                yield return new SnowGR(1980, 1981, 0, 0, 0, 0.4, 5.5, 17.3, "8.1", "18.8", "1.4", "0", "0", "0", "51.5");
                yield return new SnowGR(1981, 1982, 0, 0, 0, 0, 4.4, 8.9, "30.3", "6.7", "11.8", "12.4", "0", "0", "74.5");
                yield return new SnowGR(1982, 1983, 0, 0, 0, 0, 5.2, 8.2, "5.7", "2.9", "13.2", "0.7", "0", "0", "35.9");
                yield return new SnowGR(1983, 1984, 0, 0, 0, 0, 4.7, 34.8, "19.6", "1.6", "10.6", "0.1", "0", "0", "71.4");
                yield return new SnowGR(1984, 1985, 0, 0, 0, 0, 0, 15.7, "22.6", "21.3", "6.7", "3.3", "0", "0", "69.6");
                yield return new SnowGR(1985, 1986, 0, 0, 0, 0, 3.5, 30.7, "18.4", "20.2", "6.1", "0.2", "0", "0", "79.1");
                yield return new SnowGR(1986, 1987, 0, 0, 0, 0, 5.3, 12.7, "19.2", "0.9", "5.7", "3.8", "0", "0", "47.6");
                yield return new SnowGR(1987, 1988, 0, 0, 0, 1.6, 0.7, 18.2, "21.9", "18.1", "3.4", "0.3", "0", "0", "64.2");
                yield return new SnowGR(1988, 1989, 0, 0, 0, 0.2, 5.5, 14.4, "8.7", "25.1", "6.3", "2.2", "0", "0", "62.4");
                yield return new SnowGR(1989, 1990, 0, 0, 0, 5.8, 19.4, 25.2, "10.6", "23.8", "2.7", "2.1", "0.2", "0", "89.8");
                yield return new SnowGR(1990, 1991, 0, 0, 0, 0, 2, 18.6, "27.7", "9.5", "2.8", "0", "0", "0", "60.6");
                yield return new SnowGR(1991, 1992, 0, 0, 0, 0.3, 25.3, 27.9, "13.4", "3.5", "15.1", "2.3", "0", "0", "87.8");
                yield return new SnowGR(1992, 1993, 0, 0, 0, 2.3, 4.2, 14.2, "11.1", "18.6", "11.6", "3.3", "0", "0", "65.3");
                yield return new SnowGR(1993, 1994, 0, 0, 0, 0, 1.9, 17.7, "25.3", "29.6", "1.9", "0", "0.1", "0", "76.5");
                yield return new SnowGR(1994, 1995, 0, 0, 0, 0, 0.6, 8.9, "21.6", "18.6", "4.4", "0.8", "0", "0", "54.9");
                yield return new SnowGR(1995, 1996, 0, 0, 0, 0, 20.8, 17.4, "13.5", "6.9", "19.3", "1.8", "0", "0", "79.7");
                yield return new SnowGR(1996, 1997, 0, 0, 0, 0, 5.6, 24.6, "45.5", "14", "5.2", "3.5", "0", "0", "98.4");
                yield return new SnowGR(1997, 1998, 0, 0, 0, 2.4, 11.3, 11.5, "20.3", "0.5", "13.8", "0", "0", "0", "59.8");
                yield return new SnowGR(1998, 1999, 0, 0, 0, 0, 0.2, 7.5, "46.8", "8", "14.2", "0", "0", "0", "76.7");
                yield return new SnowGR(1999, 2000, 0, 0, 0, 0, 0.1, 18.4, "15.7", "11.9", "0.6", "7.8", "0", "0", "54.5");
                yield return new SnowGR(2000, 2001, 0, 0, 0, 0.1, 23, 59.2, "4.1", "7.4", "4.1", "0.2", "0", "0", "98.1");
                yield return new SnowGR(2001, 2002, 0, 0, 0, 0.5, 0, 53.9, "17.5", "8.7", "22.6", "2.1", "0", "0", "105.3");
                yield return new SnowGR(2002, 2003, 0, 0, 0, 0, 7.6, 15.6, "30.2", "18.9", "14.4", "1.3", "0", "0", "88");
                yield return new SnowGR(2003, 2004, 0, 0, 0, 0, 4.3, 8.4, "44.2", "13", "3.9", "0.2", "0", "0", "74");
                yield return new SnowGR(2004, 2005, 0, 0, 0, 0, 10.3, 13.1, "27.8", "15.1", "14.4", "1", "0", "0", "81.7");
                yield return new SnowGR(2005, 2006, 0, 0, 0, 0, 17.3, 28.9, "9.6", "10.1", "3.3", "0", "0", "0", "69.2");
                yield return new SnowGR(2006, 2007, 0, 0, 0, 2.1, 0.3, 11.6, "15.4", "33.6", "13.6", "6.7", "0", "0", "83.3");
                yield return new SnowGR(2007, 2008, 0, 0, 0, 0, 2.9, 25, "28.3", "41.6", "9.2", "0", "0", "0", "107");
                yield return new SnowGR(2008, 2009, 0, 0, 0, 0, 10, 54.6, "29.9", "10", "0.4", "0", "0", "0", "104.9");
                yield return new SnowGR(2009, 2010, 0, 0, 0, 0, 0.7, 35.4, "9.3", "24.8", "2", "0", "0", "0", "72.2");
                yield return new SnowGR(2010, 2011, 0, 0, 0, 0, 0.1, 11.4, "21.2", "38.2", "1.2", "1.9", "0", "0", "74");
                yield return new SnowGR(2011, 2012, 0, 0, 0, 0, 0.7, 4.5, "4.6", null, null, null, null, null, null);
            }
        }
    }
}
