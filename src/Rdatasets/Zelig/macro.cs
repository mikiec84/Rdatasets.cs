// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Macroeconomic Data
    /// </summary>

    public class macro
    {
        public readonly string country;
        public readonly int year;
        public readonly double gdp;
        public readonly double unem;
        public readonly int capmob;
        public readonly double trade;

        public macro(string country, int year, double gdp, double unem, int capmob, double trade)
        {
            this.country = country;
            this.year = year;
            this.gdp = gdp;
            this.unem = unem;
            this.capmob = capmob;
            this.trade = trade;
        }

        public static IEnumerable<macro> Data
        {
            get
            {
                yield return new macro("United States", 1966, 5.1111407, 3.8, 0, 9.622906);
                yield return new macro("United States", 1967, 2.2772829, 3.8, 0, 9.983546);
                yield return new macro("United States", 1968, 4.7, 3.6, 0, 10.08912);
                yield return new macro("United States", 1969, 2.8, 3.5, 0, 10.43593);
                yield return new macro("United States", 1970, -0.2, 4.9, 0, 10.49535);
                yield return new macro("United States", 1971, 3.1, 5.9, 0, 11.27827);
                yield return new macro("United States", 1972, 5.4, 5.6, 0, 11.21771);
                yield return new macro("United States", 1973, 5.7, 4.9, 0, 11.76705);
                yield return new macro("United States", 1974, -0.9, 5.6, 0, 13.77255);
                yield return new macro("United States", 1975, -0.8, 8.5, 0, 17.42326);
                yield return new macro("United States", 1976, 4.7, 7.7, 0, 16.52211);
                yield return new macro("United States", 1977, 5.5, 7.1, 0, 17.23492);
                yield return new macro("United States", 1978, 4.7, 6.1, 0, 17.54099);
                yield return new macro("United States", 1979, 2.6, 5.8, 0, 18.17591);
                yield return new macro("United States", 1980, -0.4, 7.1, 0, 19.73285);
                yield return new macro("United States", 1981, 3.4, 7.5, 0, 21.51057);
                yield return new macro("United States", 1982, -3, 9.5, 0, 20.53895);
                yield return new macro("United States", 1983, 2.9, 9.5, 0, 18.56972);
                yield return new macro("United States", 1984, 7.2, 7.5, 0, 17.81588);
                yield return new macro("United States", 1985, 3.8, 7.1, 0, 18.02899);
                yield return new macro("United States", 1986, 2.8, 7, 0, 17.20371);
                yield return new macro("United States", 1987, 3.7, 6.2, 0, 17.23095);
                yield return new macro("United States", 1988, 4.6, 5.5, 0, 18.29418);
                yield return new macro("United States", 1989, 2.8, 5.2700837, 0, 19.413526);
                yield return new macro("United States", 1990, 0.9, 5.4145596, 0, 20.638364);
                yield return new macro("Canada", 1966, 6.8021676, 3.6, 0, 38.45467);
                yield return new macro("Canada", 1967, 2.9236458, 4.1, 0, 40.16167);
                yield return new macro("Canada", 1968, 5.6, 4.8, 0, 41.06574);
                yield return new macro("Canada", 1969, 5.2, 4.7, 0, 42.76849);
                yield return new macro("Canada", 1970, 2.6, 5.9, 0, 44.16533);
                yield return new macro("Canada", 1971, 7, 6.4, 0, 43.8499);
                yield return new macro("Canada", 1972, 5.8, 6.3, 0, 42.67813);
                yield return new macro("Canada", 1973, 7.5, 5.6, 0, 43.88472);
                yield return new macro("Canada", 1974, 3.5, 5.4, 0, 46.41543);
                yield return new macro("Canada", 1975, 1.1, 6.9, 0, 50.49331);
                yield return new macro("Canada", 1976, 6.1, 7.1, 0, 48.16162);
                yield return new macro("Canada", 1977, 2.2, 8.1, 0, 46.12166);
                yield return new macro("Canada", 1978, 3.9, 8.4, 0, 48.00311);
                yield return new macro("Canada", 1979, 3.4, 7.5, 0, 51.22656);
                yield return new macro("Canada", 1980, 1, 7.5, 0, 54.93203);
                yield return new macro("Canada", 1981, 4, 7.6, 0, 55.77161);
                yield return new macro("Canada", 1982, -4.3, 11, 0, 54.325);
                yield return new macro("Canada", 1983, 2.8, 11.9, 0, 48.58355);
                yield return new macro("Canada", 1984, 5.4, 11.3, 0, 48.40208);
                yield return new macro("Canada", 1985, 4.7, 10.5, 0, 53.52345);
                yield return new macro("Canada", 1986, 3.1, 9.6, 0, 54.3082);
                yield return new macro("Canada", 1987, 4.5, 8.9, 0, 53.4611);
                yield return new macro("Canada", 1988, 5, 7.8, 0, 52.15683);
                yield return new macro("Canada", 1989, 2.4, 7.4952143, 0, 52.077395);
                yield return new macro("Canada", 1990, 0.4, 8.059593, 0, 49.932476);
                yield return new macro("United Kingdom", 1966, 1.8770983, 1.5, -1, 37.9319);
                yield return new macro("United Kingdom", 1967, 2.2550651, 2.3, -1, 37.83032);
                yield return new macro("United Kingdom", 1968, 4.1, 2.5, -1, 37.76296);
                yield return new macro("United Kingdom", 1969, 1.5, 2.4, -2, 41.92546);
                yield return new macro("United Kingdom", 1970, 2.2, 2.6, -2, 42.79789);
                yield return new macro("United Kingdom", 1971, 2.7, 3.5, -1, 44.08434);
                yield return new macro("United Kingdom", 1972, 2.3, 3.8, -1, 43.51069);
                yield return new macro("United Kingdom", 1973, 7.6, 2.7, -1, 42.86721);
                yield return new macro("United Kingdom", 1974, -1, 2.6, -1, 48.8228);
                yield return new macro("United Kingdom", 1975, -0.7, 4, -1, 59.62837);
                yield return new macro("United Kingdom", 1976, 3.8, 5.5, -1, 52.51037);
                yield return new macro("United Kingdom", 1977, 1, 5.8, -1, 56.87488);
                yield return new macro("United Kingdom", 1978, 3.6, 5.7, -1, 59.06499);
                yield return new macro("United Kingdom", 1979, 2.2, 5.3, -1, 55.53134);
                yield return new macro("United Kingdom", 1980, -2.3, 7, 0, 55.78893);
                yield return new macro("United Kingdom", 1981, -1.4, 10.5, 0, 52.5135);
                yield return new macro("United Kingdom", 1982, 1.5, 11.2, 0, 50.54586);
                yield return new macro("United Kingdom", 1983, 3.4, 11.7, 0, 51.03159);
                yield return new macro("United Kingdom", 1984, 1.8, 11.7, 0, 52.77322);
                yield return new macro("United Kingdom", 1985, 3.7, 11.2, 0, 58.07664);
                yield return new macro("United Kingdom", 1986, 3.5, 11.2, 0, 57.58285);
                yield return new macro("United Kingdom", 1987, 4.7, 10.2, 0, 53.52335);
                yield return new macro("United Kingdom", 1988, 4.1, 8.3, 0, 52.65015);
                yield return new macro("United Kingdom", 1989, 2.3, 6.1140732, 0, 50.248182);
                yield return new macro("United Kingdom", 1990, 0.8, 5.4717446, 0, 52.35597);
                yield return new macro("Netherlands", 1966, 1.8770983, 1, -2, 87.05895);
                yield return new macro("Netherlands", 1967, 2.2550651, 2, -2, 85.44972);
                yield return new macro("Netherlands", 1968, 2.3, 1.9, -3, 82.56051);
                yield return new macro("Netherlands", 1969, 6.4, 1.4, -2, 82.63106);
                yield return new macro("Netherlands", 1970, 6.7, 1.1, -2, 86.03879);
                yield return new macro("Netherlands", 1971, 4.2, 1.6, -2, 91.87628);
                yield return new macro("Netherlands", 1972, 3.3, 2.8, -1, 91.26911);
                yield return new macro("Netherlands", 1973, 4.7, 2.8, -1, 87.19008);
                yield return new macro("Netherlands", 1974, 4, 3.5, -1, 91.15795);
                yield return new macro("Netherlands", 1975, -0.1, 5.3, -1, 104.9757);
                yield return new macro("Netherlands", 1976, 5.1, 5.6, -1, 96.28062);
                yield return new macro("Netherlands", 1977, 2.3, 5.5, -1, 98.3404);
                yield return new macro("Netherlands", 1978, 2.5, 5.5, 0, 93.89299);
                yield return new macro("Netherlands", 1979, 2.4, 5.6, 0, 89.75119);
                yield return new macro("Netherlands", 1980, 0.9, 6, 0, 98.66754);
                yield return new macro("Netherlands", 1981, -0.7, 8.9, 0, 105.5502);
                yield return new macro("Netherlands", 1982, -1.4, 10.3, 0, 112.4727);
                yield return new macro("Netherlands", 1983, 0.9, 12.3, 0, 111.3337);
                yield return new macro("Netherlands", 1984, 1.7, 12.3, 0, 112.8105);
                yield return new macro("Netherlands", 1985, 2.6, 10.2, 0, 119.0031);
                yield return new macro("Netherlands", 1986, 2, 10, 0, 122.6721);
                yield return new macro("Netherlands", 1987, 1.1, 10, 0, 104.1273);
                yield return new macro("Netherlands", 1988, 2.7, 10.1, 0, 102.312);
                yield return new macro("Netherlands", 1989, 4, 8.31223, 0, 105.057288);
                yield return new macro("Netherlands", 1990, 3.9, 7.5087311, 0, 111.762226);
                yield return new macro("Belgium", 1966, 3.1622589, 2.7, -2, 73.61844);
                yield return new macro("Belgium", 1967, 3.8753976, 3.7, -2, 74.54204);
                yield return new macro("Belgium", 1968, 4.2, 4.5, -2, 73.58559);
                yield return new macro("Belgium", 1969, 6.6, 3.6, -1, 78.44779);
                yield return new macro("Belgium", 1970, 6.4, 2.9, -1, 84.37925);
                yield return new macro("Belgium", 1971, 3.7, 2.9, -1, 86.75947);
                yield return new macro("Belgium", 1972, 5.3, 3.4, 0, 86.10609);
                yield return new macro("Belgium", 1973, 5.9, 3.6, 0, 85.15666);
                yield return new macro("Belgium", 1974, 4.1, 4, 0, 94.41487);
                yield return new macro("Belgium", 1975, -1.5, 6.7, 0, 108.1774);
                yield return new macro("Belgium", 1976, 5.3, 6.8, 0, 93.60921);
                yield return new macro("Belgium", 1977, 0.4, 7.8, 0, 98.26746);
                yield return new macro("Belgium", 1978, 3, 8.4, 0, 107.1681);
                yield return new macro("Belgium", 1979, 2.1, 8.7, 0, 104.3904);
                yield return new macro("Belgium", 1980, 4, 9.4, 0, 115.2146);
                yield return new macro("Belgium", 1981, -1.5, 10, 0, 121.3896);
                yield return new macro("Belgium", 1982, 1.5, 11.7, 0, 130.5714);
                yield return new macro("Belgium", 1983, -0.1, 12.9, 0, 138.4857);
                yield return new macro("Belgium", 1984, 1.4, 13, 0, 137.1896);
                yield return new macro("Belgium", 1985, 0.9, 12, 0, 146.0202);
                yield return new macro("Belgium", 1986, 1.6, 11.3, 0, 141.2755);
                yield return new macro("Belgium", 1987, 1.9, 11.1, 0, 127.2102);
                yield return new macro("Belgium", 1988, 4.3, 10, 0, 126.9076);
                yield return new macro("Belgium", 1989, 3.6, 9.2664093, 0, 133.281122);
                yield return new macro("Belgium", 1990, 3.8, 8.7341469, 0, 142.686084);
                yield return new macro("France", 1966, 5.2141824, 0.7, 0, 24.30256);
                yield return new macro("France", 1967, 4.6882107, 0.9, 0, 25.00878);
                yield return new macro("France", 1968, 4.3, 1.2, 0, 24.85014);
                yield return new macro("France", 1969, 7, 1, -1, 25.40206);
                yield return new macro("France", 1970, 5.7, 1.2, -1, 27.82975);
                yield return new macro("France", 1971, 5.4, 1.6, -1, 31.51196);
                yield return new macro("France", 1972, 5.9, 2, -1, 32.18585);
                yield return new macro("France", 1973, 5.4, 2.6, -1, 32.61595);
                yield return new macro("France", 1974, 3.2, 2.8, -1, 34.76036);
                yield return new macro("France", 1975, 0.2, 4.1, -1, 43.20575);
                yield return new macro("France", 1976, 5.2, 4.4, -1, 37.32651);
                yield return new macro("France", 1977, 3.1, 4.7, -1, 40.42973);
                yield return new macro("France", 1978, 3.8, 5.2, -1, 41.56883);
                yield return new macro("France", 1979, 3.3, 5.9, -1, 40.2554);
                yield return new macro("France", 1980, 1.1, 6.3, -1, 42.54165);
                yield return new macro("France", 1981, 0.5, 7.3, -1, 44.89193);
                yield return new macro("France", 1982, 1.8, 8.1, -1, 46.89539);
                yield return new macro("France", 1983, 0.7, 8.3, -1, 46.22432);
                yield return new macro("France", 1984, 1.3, 9.9, -1, 45.69321);
                yield return new macro("France", 1985, 1.9, 10.2, -1, 47.64652);
                yield return new macro("France", 1986, 2.3, 10.4, -1, 47.21023);
                yield return new macro("France", 1987, 1.9, 10.5, -1, 41.62719);
                yield return new macro("France", 1988, 3.5, 9.9, -1, 41.46514);
                yield return new macro("France", 1989, 3.6, 9.3791118, -1, 42.861233);
                yield return new macro("France", 1990, 2.6, 8.9709547, -1, 49.667118);
                yield return new macro("West Germany", 1966, 2.9414163, 0.7, 0, 37.89446);
                yield return new macro("West Germany", 1967, -0.1188883, 2.1, 0, 38.81367);
                yield return new macro("West Germany", 1968, 6.3, 1.5, 0, 39.50642);
                yield return new macro("West Germany", 1969, 7.8, 0.9, 0, 41.40414);
                yield return new macro("West Germany", 1970, 6, 0.7, 0, 43.06893);
                yield return new macro("West Germany", 1971, 2.9, 0.8, 0, 43.21042);
                yield return new macro("West Germany", 1972, 4.2, 1.1, 0, 43.2477);
                yield return new macro("West Germany", 1973, 4.7, 1.2, 0, 42.76834);
                yield return new macro("West Germany", 1974, 0.3, 2.6, 0, 44.19636);
                yield return new macro("West Germany", 1975, -1.6, 4.7, 0, 52.19484);
                yield return new macro("West Germany", 1976, 5.4, 4.6, 0, 49.9167);
                yield return new macro("West Germany", 1977, 3, 4.5, 0, 52.59491);
                yield return new macro("West Germany", 1978, 2.9, 4.3, 0, 52.03534);
                yield return new macro("West Germany", 1979, 4.2, 3.8, 0, 50.73377);
                yield return new macro("West Germany", 1980, 1.4, 3.8, 0, 53.40189);
                yield return new macro("West Germany", 1981, 0.2, 5.5, 0, 57.20418);
                yield return new macro("West Germany", 1982, -0.6, 7.5, 0, 61.45247);
                yield return new macro("West Germany", 1983, 1.2, 9.1, 0, 62.33753);
                yield return new macro("West Germany", 1984, 2.6, 9.1, 0, 60.67839);
                yield return new macro("West Germany", 1985, 2, 9.3, 0, 64.16871);
                yield return new macro("West Germany", 1986, 2.3, 9, 0, 66.31547);
                yield return new macro("West Germany", 1987, 1.8, 8.9, 0, 59.98089);
                yield return new macro("West Germany", 1988, 3.7, 8.7, 0, 58.09554);
                yield return new macro("West Germany", 1989, 3.2, 6.843749, 0, 59.254416);
                yield return new macro("West Germany", 1990, 4.7, 6.2089887, 0, 64.47238);
                yield return new macro("Austria", 1966, 5.6429989, 1.7, -2, 50.82818);
                yield return new macro("Austria", 1967, 3.0076867, 1.8, -2, 51.53986);
                yield return new macro("Austria", 1968, 4.5, 2, -2, 50.87713);
                yield return new macro("Austria", 1969, 6.3, 1.8, -2, 51.62636);
                yield return new macro("Austria", 1970, 7.1, 1.4, -2, 55.52404);
                yield return new macro("Austria", 1971, 5.1, 1.2, -2, 61.16313);
                yield return new macro("Austria", 1972, 6.2, 1, -2, 60.62628);
                yield return new macro("Austria", 1973, 4.9, 1, -3, 60.49547);
                yield return new macro("Austria", 1974, 3.9, 1.1, -1, 60.68523);
                yield return new macro("Austria", 1975, -0.4, 1.7, -1, 66.36381);
                yield return new macro("Austria", 1976, 4.6, 1.7, -1, 63.06676);
                yield return new macro("Austria", 1977, 4.4, 1.5, -1, 66.72645);
                yield return new macro("Austria", 1978, 0.5, 1.8, -1, 67.23354);
                yield return new macro("Austria", 1979, 4.7, 1.7, -1, 66.62471);
                yield return new macro("Austria", 1980, 3, 1.6, -1, 71.77694);
                yield return new macro("Austria", 1981, -0.1, 2.1, -1, 75.59992);
                yield return new macro("Austria", 1982, 1.2, 3.1, -1, 77.91716);
                yield return new macro("Austria", 1983, 2.1, 3.8, -1, 74.13298);
                yield return new macro("Austria", 1984, 2, 3.8, -1, 73.28623);
                yield return new macro("Austria", 1985, 2.5, 3.6, -1, 77.68645);
                yield return new macro("Austria", 1986, 1.1, 3.1, -1, 80.93437);
                yield return new macro("Austria", 1987, 1.9, 3.8, -1, 72.72447);
                yield return new macro("Austria", 1988, 4.2, 3.6, -1, 70.36277);
                yield return new macro("Austria", 1989, 3.7, 3.1304348, -1, 74.421892);
                yield return new macro("Austria", 1990, 4.9, 3.2331254, -1, 79.472929);
                yield return new macro("Italy", 1966, 5.9849301, 5.9, -1, 26.93998);
                yield return new macro("Italy", 1967, 7.1776258, 5.4, -1, 28.23712);
                yield return new macro("Italy", 1968, 6.5, 5.7, -1, 28.7611);
                yield return new macro("Italy", 1969, 6.1, 5.7, -1, 29.41873);
                yield return new macro("Italy", 1970, 5.3, 5.4, -1, 31.44462);
                yield return new macro("Italy", 1971, 1.6, 5.4, -1, 32.473);
                yield return new macro("Italy", 1972, 3.2, 6.4, -1, 32.66676);
                yield return new macro("Italy", 1973, 7, 6.4, -1, 34.19679);
                yield return new macro("Italy", 1974, 4.1, 5.4, -1, 37.14928);
                yield return new macro("Italy", 1975, -3.6, 5.9, -2, 46.89348);
                yield return new macro("Italy", 1976, 5.9, 6.7, -1, 43.18141);
                yield return new macro("Italy", 1977, 1.9, 7.2, -2, 48.34128);
                yield return new macro("Italy", 1978, 2.7, 7.2, -1, 48.47882);
                yield return new macro("Italy", 1979, 4.9, 7.7, -1, 47.99013);
                yield return new macro("Italy", 1980, 3.9, 7.6, -1, 51.30311);
                yield return new macro("Italy", 1981, 0.2, 8.4, -1, 50.45122);
                yield return new macro("Italy", 1982, -0.5, 9.1, -2, 46.008);
                yield return new macro("Italy", 1983, -0.2, 9.9, -1, 44.53123);
                yield return new macro("Italy", 1984, 2.8, 10.1, 0, 41.13525);
                yield return new macro("Italy", 1985, 2.6, 10.1, 0, 43.64893);
                yield return new macro("Italy", 1986, 2.5, 11.1, 0, 43.84961);
                yield return new macro("Italy", 1987, 3, 12, -1, 37.01633);
                yield return new macro("Italy", 1988, 3.9, 12, -1, 36.8253);
                yield return new macro("Italy", 1989, 3, 11.8115106, -1, 38.838481);
                yield return new macro("Italy", 1990, 2, 10.7891162, -1, 38.649988);
                yield return new macro("Finland", 1966, 2.3721416, 1.5, -3, 42.16415);
                yield return new macro("Finland", 1967, 2.1688613, 2.9, -3, 41.39525);
                yield return new macro("Finland", 1968, 2.5, 3.8, -2, 40.35631);
                yield return new macro("Finland", 1969, 9.6, 2.8, -2, 43.75069);
                yield return new macro("Finland", 1970, 7.9, 1.9, -2, 47.38203);
                yield return new macro("Finland", 1971, 2.1, 2.2, -2, 52.59821);
                yield return new macro("Finland", 1972, 7.6, 2.5, -2, 50.48052);
                yield return new macro("Finland", 1973, 6.7, 2.3, -3, 50.74626);
                yield return new macro("Finland", 1974, 3, 1.7, -3, 51.49655);
                yield return new macro("Finland", 1975, 1.2, 2.2, -3, 58.73077);
                yield return new macro("Finland", 1976, 0.3, 3.8, -4, 53.37948);
                yield return new macro("Finland", 1977, 0.2, 5.8, -3, 52.09085);
                yield return new macro("Finland", 1978, 2.6, 7.2, -3, 55.15342);
                yield return new macro("Finland", 1979, 7.4, 5.9, -3, 55.9532);
                yield return new macro("Finland", 1980, 5.6, 4.6, -3, 61.35039);
                yield return new macro("Finland", 1981, 1.8, 5.1, -3, 66.6819);
                yield return new macro("Finland", 1982, 3, 5.4, -3, 65.71604);
                yield return new macro("Finland", 1983, 2.9, 5.4, -3, 61.49152);
                yield return new macro("Finland", 1984, 3, 5.2, -3, 60.64693);
                yield return new macro("Finland", 1985, 3.3, 5, -2, 58.25233);
                yield return new macro("Finland", 1986, 2.1, 5.4, -2, 57.31776);
                yield return new macro("Finland", 1987, 4, 5.1, -3, 51.93765);
                yield return new macro("Finland", 1988, 5.2, 4.6, -3, 50.27617);
                yield return new macro("Finland", 1989, 5.4, 3.4456059, -3, 49.786669);
                yield return new macro("Finland", 1990, 0.4, 3.5541195, -3, 48.981816);
                yield return new macro("Sweden", 1966, 2.0909698, 1.4, -2, 44.78557);
                yield return new macro("Sweden", 1967, 3.3656264, 1.7, -2, 43.72852);
                yield return new macro("Sweden", 1968, 3.6, 2, -2, 42.46237);
                yield return new macro("Sweden", 1969, 5, 1.7, -2, 43.51757);
                yield return new macro("Sweden", 1970, 6.5, 1.4, -2, 46.27839);
                yield return new macro("Sweden", 1971, 0.9, 2, -2, 48.77312);
                yield return new macro("Sweden", 1972, 2.3, 2, -2, 47.52033);
                yield return new macro("Sweden", 1973, 4, 1.9, -2, 46.86441);
                yield return new macro("Sweden", 1974, 3.2, 1.5, -1, 52.04547);
                yield return new macro("Sweden", 1975, 2.6, 1.4, -1, 65.1786);
                yield return new macro("Sweden", 1976, 1.1, 1.2, -1, 56.49882);
                yield return new macro("Sweden", 1977, -1.6, 1.2, -1, 56.97875);
                yield return new macro("Sweden", 1978, 1.8, 1.6, -1, 56.4408);
                yield return new macro("Sweden", 1979, 3.8, 1.5, -1, 55.41762);
                yield return new macro("Sweden", 1980, 1.7, 1.4, -1, 61.8139);
                yield return new macro("Sweden", 1981, -0.3, 2.5, -1, 61.51982);
                yield return new macro("Sweden", 1982, 0.8, 3.1, -1, 60.16333);
                yield return new macro("Sweden", 1983, 2.4, 3.5, -1, 64.76091);
                yield return new macro("Sweden", 1984, 3.4, 3.1, -1, 68.5121);
                yield return new macro("Sweden", 1985, 2.2, 2.8, -1, 68.25501);
                yield return new macro("Sweden", 1986, 2.3, 2.6, -1, 68.22753);
                yield return new macro("Sweden", 1987, 2.9, 1.9, -1, 62.7877);
                yield return new macro("Sweden", 1988, 2.3, 1.6, -1, 61.83354);
                yield return new macro("Sweden", 1989, 2.4, 0.6847802, -1, 63.454899);
                yield return new macro("Sweden", 1990, 0.6, 1.5075377, -1, 63.819325);
                yield return new macro("Norway", 1966, 3.7861464, 0.8, -2, 82.25382);
                yield return new macro("Norway", 1967, 6.2568582, 0.8, -2, 83.08898);
                yield return new macro("Norway", 1968, 2.3, 1.1, -2, 85.66164);
                yield return new macro("Norway", 1969, 6.4, 1, -2, 84.23661);
                yield return new macro("Norway", 1970, 6.7, 0.8, -2, 82.44259);
                yield return new macro("Norway", 1971, 4.6, 0.8, -2, 84.91699);
                yield return new macro("Norway", 1972, 5.2, 1.7, -2, 83.66345);
                yield return new macro("Norway", 1973, 4.1, 1.5, -2, 80.62762);
                yield return new macro("Norway", 1974, 5.2, 1.5, -1, 87.61421);
                yield return new macro("Norway", 1975, 4.2, 2.3, -1, 95.4297);
                yield return new macro("Norway", 1976, 6.8, 1.8, -1, 90.33502);
                yield return new macro("Norway", 1977, 3.6, 1.5, -1, 91.72334);
                yield return new macro("Norway", 1978, 4.5, 1.7, -1, 90.33905);
                yield return new macro("Norway", 1979, 5.1, 2, -1, 82.75804);
                yield return new macro("Norway", 1980, 4.2, 1.7, -1, 85.70865);
                yield return new macro("Norway", 1981, 0.9, 2, -1, 88.46642);
                yield return new macro("Norway", 1982, 0.3, 2.6, -1, 87.5138);
                yield return new macro("Norway", 1983, 3.9, 3.3, -1, 85.11059);
                yield return new macro("Norway", 1984, 3.8, 3.1, -1, 83.61769);
                yield return new macro("Norway", 1985, 5.3, 2.6, -1, 85.50693);
                yield return new macro("Norway", 1986, 4.2, 2, -1, 85.75997);
                yield return new macro("Norway", 1987, 3.4, 2.1, -1, 79.00841);
                yield return new macro("Norway", 1988, 1.1, 3.2, -1, 73.38462);
                yield return new macro("Norway", 1989, 0.4, 4.9187935, -1, 73.863705);
                yield return new macro("Norway", 1990, 1.8, 5.2287582, -1, 79.656174);
                yield return new macro("Denmark", 1966, 2.7412402, 2.3, -3, 62.28668);
                yield return new macro("Denmark", 1967, 3.4212094, 2.7, -3, 58.78237);
                yield return new macro("Denmark", 1968, 3.8, 5, -2, 56.86628);
                yield return new macro("Denmark", 1969, 6.5, 3.9, -2, 56.77313);
                yield return new macro("Denmark", 1970, 2.3, 2.9, -2, 57.00761);
                yield return new macro("Denmark", 1971, 2.7, 3.7, -2, 58.80617);
                yield return new macro("Denmark", 1972, 5.3, 3.6, -2, 57.03129);
                yield return new macro("Denmark", 1973, 3.6, 2.4, -2, 53.59322);
                yield return new macro("Denmark", 1974, -0.9, 5.2, -1, 58.96134);
                yield return new macro("Denmark", 1975, -0.7, 6, -1, 66.43667);
                yield return new macro("Denmark", 1976, 6.5, 5.3, -1, 61.09859);
                yield return new macro("Denmark", 1977, 1.6, 6.4, -1, 62.33729);
                yield return new macro("Denmark", 1978, 1.5, 7.3, -1, 61.26526);
                yield return new macro("Denmark", 1979, 3.5, 6.1, -1, 57.73387);
                yield return new macro("Denmark", 1980, -0.4, 6.9, -1, 61.31303);
                yield return new macro("Denmark", 1981, -0.9, 10.3, -1, 66.47386);
                yield return new macro("Denmark", 1982, 3, 11, -1, 72.36322);
                yield return new macro("Denmark", 1983, 2.1, 11.4, -1, 71.87047);
                yield return new macro("Denmark", 1984, 3.5, 8.5, -1, 70.32415);
                yield return new macro("Denmark", 1985, 4.3, 7.3, -1, 72.59833);
                yield return new macro("Denmark", 1986, 3.6, 5.5, -1, 72.94829);
                yield return new macro("Denmark", 1987, -0.6, 6.9, -1, 64.36702);
                yield return new macro("Denmark", 1988, -0.2, 7.2, -1, 61.44821);
                yield return new macro("Denmark", 1989, 0.8, 8.1278222, 0, 62.473431);
                yield return new macro("Denmark", 1990, 1.7, 8.3104396, 0, 61.443299);
                yield return new macro("Japan", 1966, 10.6382757, 0.9, -2, 20.64122);
                yield return new macro("Japan", 1967, 11.0823408, 1.3, -2, 20.5948);
                yield return new macro("Japan", 1968, 12.8, 1.2, -2, 20.05519);
                yield return new macro("Japan", 1969, 12.3, 1.1, -2, 20.08211);
                yield return new macro("Japan", 1970, 9.8, 1.2, -2, 20.59826);
                yield return new macro("Japan", 1971, 4.2, 1.2, -1, 21.5081);
                yield return new macro("Japan", 1972, 8.4, 1.4, -1, 21.95309);
                yield return new macro("Japan", 1973, 7.9, 1.3, -1, 20.1664);
                yield return new macro("Japan", 1974, -1.2, 1.4, -1, 21.53925);
                yield return new macro("Japan", 1975, 2.6, 1.9, -1, 29.91749);
                yield return new macro("Japan", 1976, 4.8, 2, -1, 27.42852);
                yield return new macro("Japan", 1977, 5.3, 2, -1, 28.03661);
                yield return new macro("Japan", 1978, 5.1, 2.2, -1, 26.11608);
                yield return new macro("Japan", 1979, 5.2, 2.1, -1, 22.00218);
                yield return new macro("Japan", 1980, 4.4, 2, 0, 26.31612);
                yield return new macro("Japan", 1981, 3.9, 2.2, 0, 31.21532);
                yield return new macro("Japan", 1982, 2.8, 2.4, 0, 32.51882);
                yield return new macro("Japan", 1983, 3.2, 2.6, 0, 32.80608);
                yield return new macro("Japan", 1984, 5, 2.7, 0, 29.7358);
                yield return new macro("Japan", 1985, 4.7, 2.6, 0, 30.6541);
                yield return new macro("Japan", 1986, 2.5, 2.8, 0, 29.16159);
                yield return new macro("Japan", 1987, 4.4, 2.9, 0, 21.90987);
                yield return new macro("Japan", 1988, 5.7, 2.5, 0, 21.71235);
                yield return new macro("Japan", 1989, 4.7, 2.2647528, 0, 23.128797);
                yield return new macro("Japan", 1990, 5.2, 2.0989975, 0, 20.000304);
            }
        }
    }
}
