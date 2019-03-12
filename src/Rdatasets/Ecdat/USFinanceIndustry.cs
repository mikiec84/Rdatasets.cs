// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// US Finance Industry Profits
    /// </summary>

    public class USFinanceIndustry
    {
        public readonly string κ;
        public readonly int year;
        public readonly double? CorporateProfitsAdj;
        public readonly double? Domestic;
        public readonly double? Financial;
        public readonly double? Nonfinancial;
        public readonly double? restOfWorld;
        public readonly double? FinanceProportion;

        public USFinanceIndustry(string κ, int year, double? CorporateProfitsAdj, double? Domestic, double? Financial, double? Nonfinancial, double? restOfWorld, double? FinanceProportion)
        {
            this.κ = κ;
            this.year = year;
            this.CorporateProfitsAdj = CorporateProfitsAdj;
            this.Domestic = Domestic;
            this.Financial = Financial;
            this.Nonfinancial = Nonfinancial;
            this.restOfWorld = restOfWorld;
            this.FinanceProportion = FinanceProportion;
        }

        public static IEnumerable<USFinanceIndustry> Data
        {
            get
            {
                yield return new USFinanceIndustry("", 1929, 10.7, 10.4, 1.6, 8.9, 0.2, 0.153846153846154);
                yield return new USFinanceIndustry("", 1930, 7.4, 7.2, 0.7, 6.6, 0.1, 0.0972222222222222);
                yield return new USFinanceIndustry("", 1931, 2.8, 2.8, 0.5, 2.3, 0, 0.178571428571429);
                yield return new USFinanceIndustry("", 1932, -0.3, -0.2, 0.6, -0.9, 0, -3);
                yield return new USFinanceIndustry("", 1933, -0.3, -0.3, 0.8, -1, 0, -2.66666666666667);
                yield return new USFinanceIndustry("", 1934, 2.4, 2.3, 0.5, 1.8, 0.1, 0.217391304347826);
                yield return new USFinanceIndustry("", 1935, 3.9, 3.7, 0.5, 3.2, 0.2, 0.135135135135135);
                yield return new USFinanceIndustry("", 1936, 6, 5.9, 0.9, 5.1, 0.1, 0.152542372881356);
                yield return new USFinanceIndustry("", 1937, 6.9, 6.6, 0.8, 5.8, 0.3, 0.121212121212121);
                yield return new USFinanceIndustry("", 1938, 4.8, 4.5, 0.9, 3.6, 0.3, 0.2);
                yield return new USFinanceIndustry("", 1939, 6.4, 6.1, 0.9, 5.2, 0.3, 0.147540983606557);
                yield return new USFinanceIndustry("", 1940, 9.6, 9.4, 1.1, 8.3, 0.3, 0.117021276595745);
                yield return new USFinanceIndustry("", 1941, 15.3, 14.9, 1.1, 13.7, 0.4, 0.0738255033557047);
                yield return new USFinanceIndustry("", 1942, 20.4, 20.1, 1.2, 18.9, 0.4, 0.0597014925373134);
                yield return new USFinanceIndustry("", 1943, 24.7, 24.4, 1.3, 23, 0.4, 0.0532786885245902);
                yield return new USFinanceIndustry("", 1944, 24.8, 24.4, 1.6, 22.8, 0.4, 0.0655737704918033);
                yield return new USFinanceIndustry("", 1945, 20.2, 19.9, 1.6, 18.2, 0.3, 0.0804020100502513);
                yield return new USFinanceIndustry("", 1946, 17.9, 17.2, 2.1, 15.2, 0.7, 0.122093023255814);
                yield return new USFinanceIndustry("", 1947, 23.5, 22.5, 1.7, 20.8, 1, 0.0755555555555556);
                yield return new USFinanceIndustry("", 1948, 30.9, 29.6, 2.5, 27.1, 1.3, 0.0844594594594595);
                yield return new USFinanceIndustry("", 1949, 28.7, 27.6, 3.1, 24.5, 1.1, 0.11231884057971);
                yield return new USFinanceIndustry("", 1950, 35.6, 34.4, 3.1, 31.3, 1.3, 0.0901162790697674);
                yield return new USFinanceIndustry("", 1951, 40.8, 39.1, 3.4, 35.6, 1.7, 0.0869565217391304);
                yield return new USFinanceIndustry("", 1952, 38.8, 37, 4.1, 32.8, 1.9, 0.110810810810811);
                yield return new USFinanceIndustry("", 1953, 39.1, 37.3, 4.6, 32.8, 1.8, 0.123324396782842);
                yield return new USFinanceIndustry("", 1954, 38.3, 36.4, 4.8, 31.6, 2, 0.131868131868132);
                yield return new USFinanceIndustry("", 1955, 49, 46.6, 5.1, 41.6, 2.4, 0.109442060085837);
                yield return new USFinanceIndustry("", 1956, 48, 45.2, 5.4, 39.8, 2.8, 0.119469026548673);
                yield return new USFinanceIndustry("", 1957, 47.6, 44.5, 5.7, 38.8, 3.1, 0.128089887640449);
                yield return new USFinanceIndustry("", 1958, 42.5, 39.9, 6.1, 33.8, 2.5, 0.152882205513784);
                yield return new USFinanceIndustry("", 1959, 53.8, 51.1, 7.3, 43.8, 2.7, 0.142857142857143);
                yield return new USFinanceIndustry("", 1960, 53.1, 50, 8.2, 41.7, 3.1, 0.164);
                yield return new USFinanceIndustry("", 1961, 54.2, 50.9, 8.2, 42.7, 3.3, 0.161100196463654);
                yield return new USFinanceIndustry("", 1962, 62.3, 58.6, 8.5, 50.1, 3.8, 0.145051194539249);
                yield return new USFinanceIndustry("", 1963, 68.3, 64.3, 8.1, 56.1, 4.1, 0.12597200622084);
                yield return new USFinanceIndustry("", 1964, 75.5, 71.1, 8.7, 62.4, 4.5, 0.122362869198312);
                yield return new USFinanceIndustry("", 1965, 86.5, 81.8, 9.2, 72.7, 4.7, 0.112469437652812);
                yield return new USFinanceIndustry("", 1966, 92.5, 88, 10.5, 77.5, 4.5, 0.119318181818182);
                yield return new USFinanceIndustry("", 1967, 90.2, 85.4, 11, 74.4, 4.8, 0.128805620608899);
                yield return new USFinanceIndustry("", 1968, 97.3, 91.6, 12.7, 78.9, 5.6, 0.138646288209607);
                yield return new USFinanceIndustry("", 1969, 94.5, 87.9, 13.5, 74.4, 6.6, 0.15358361774744);
                yield return new USFinanceIndustry("", 1970, 82.5, 75.4, 15.2, 60.2, 7.1, 0.20159151193634);
                yield return new USFinanceIndustry("", 1971, 96.1, 88.2, 17.4, 70.8, 7.9, 0.197278911564626);
                yield return new USFinanceIndustry("", 1972, 111.4, 101.9, 19.1, 82.8, 9.5, 0.187438665358194);
                yield return new USFinanceIndustry("", 1973, 124.5, 109.6, 20.7, 88.9, 14.9, 0.188868613138686);
                yield return new USFinanceIndustry("", 1974, 115.1, 97.7, 20.2, 77.5, 17.5, 0.20675537359263);
                yield return new USFinanceIndustry("", 1975, 133.3, 118.7, 19.7, 98.9, 14.6, 0.165964616680708);
                yield return new USFinanceIndustry("", 1976, 161.6, 145.1, 24.1, 121, 16.5, 0.166092350103377);
                yield return new USFinanceIndustry("", 1977, 191.8, 172.7, 30.9, 141.9, 19.1, 0.178922987840185);
                yield return new USFinanceIndustry("", 1978, 218.4, 195.6, 38.8, 156.8, 22.9, 0.198364008179959);
                yield return new USFinanceIndustry("", 1979, 225.4, 190.7, 39, 151.8, 34.6, 0.204509701101206);
                yield return new USFinanceIndustry("", 1980, 201.4, 166, 31.2, 134.7, 35.5, 0.187951807228916);
                yield return new USFinanceIndustry("", 1981, 223.3, 193.6, 26.8, 166.8, 29.7, 0.138429752066116);
                yield return new USFinanceIndustry("", 1982, 205.7, 173.1, 22.9, 150.2, 32.6, 0.132293471981514);
                yield return new USFinanceIndustry("", 1983, 259.8, 224.8, 33.6, 191.2, 35.1, 0.149466192170818);
                yield return new USFinanceIndustry("", 1984, 318.6, 282, 32.2, 249.8, 36.6, 0.114184397163121);
                yield return new USFinanceIndustry("", 1985, 332.5, 294.4, 44.8, 249.6, 38.1, 0.152173913043478);
                yield return new USFinanceIndustry("", 1986, 314.1, 274.7, 55.2, 219.5, 39.5, 0.200946487076811);
                yield return new USFinanceIndustry("O1", 1987, 367.8, 319.8, 59.9, 259.9, 48, 0.187304565353346);
                yield return new USFinanceIndustry("", 1988, 426.6, 369.6, 65.4, 304.3, 57, 0.176948051948052);
                yield return new USFinanceIndustry("", 1989, 425.6, 358.4, 74.9, 283.5, 67.1, 0.208984375);
                yield return new USFinanceIndustry("", 1990, 434.4, 358.4, 81.6, 276.7, 76.1, 0.227678571428571);
                yield return new USFinanceIndustry("", 1991, 457.3, 380.8, 109.5, 271.3, 76.5, 0.287552521008403);
                yield return new USFinanceIndustry("", 1992, 496.2, 423.1, 127.1, 296.1, 73.1, 0.300401796265658);
                yield return new USFinanceIndustry("", 1993, 543.7, 466.8, 119.3, 347.5, 76.9, 0.255569837189374);
                yield return new USFinanceIndustry("", 1994, 628.2, 550.3, 116.8, 433.5, 78, 0.212247864801018);
                yield return new USFinanceIndustry("", 1995, 716.2, 623.2, 152.7, 470.6, 92.9, 0.24502567394095);
                yield return new USFinanceIndustry("", 1996, 801.5, 699.5, 162.1, 537.4, 102, 0.231736954967834);
                yield return new USFinanceIndustry("", 1997, 884.8, 777.3, 191.1, 586.2, 107.6, 0.245851022771131);
                yield return new USFinanceIndustry("", 1998, 812.4, 709.7, 165.85, 543.8, 102.8, 0.233690291672538);
                yield return new USFinanceIndustry("", 1999, 856.3, 734.8, 200.75, 534.05, 121.5, 0.273203592814371);
                yield return new USFinanceIndustry("", 2000, 819.2, 673.6, 203.75, 469.85, 145.6, 0.302479216152019);
                yield return new USFinanceIndustry("", 2001, 784.2, 614.5, 244.4, 370.1, 169.7, 0.397721724979658);
                yield return new USFinanceIndustry("", 2002, 872.2, 714.3, 287.1, 427.2, 157.9, 0.401931961360773);
                yield return new USFinanceIndustry("", 2003, 977.8, 812, 325.9, 486.1, 165.8, 0.401354679802956);
                yield return new USFinanceIndustry("", 2004, 1246.9, 1041.9, 364.4, 677.5, 205, 0.349745656972838);
                yield return new USFinanceIndustry("", 2005, 1456.1, 1216.6, 419, 797.6, 239.4, 0.344402433010028);
                yield return new USFinanceIndustry("", 2006, 1608.3, 1351.5, 427.6, 923.9, 256.8, 0.316389197188309);
                yield return new USFinanceIndustry("", 2007, 1510.6, 1159.8, 323.8, 835.9, 350.9, 0.279186066563201);
                yield return new USFinanceIndustry("", 2008, 1248.4, 841.8, 86.8, 755, 406.6, 0.103112378237111);
                yield return new USFinanceIndustry("", 2009, 1342.3, 989.5, 328.9, 660.6, 352.8, 0.332390096008085);
                yield return new USFinanceIndustry("", 2010, 1702.4, 1300.9, 383.7, 917.1, 401.6, 0.29494965024214);
                yield return new USFinanceIndustry("", 2011, 1827, 1388.1, 381, 1007.1, 438.9, 0.274475902312514);
                yield return new USFinanceIndustry("", 2012, null, null, null, null, null, null);
            }
        }
    }
}
