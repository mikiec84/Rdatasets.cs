// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths from various causes, in London from 1629 till 1881, with gaps
    /// </summary>

    public class poxetc
    {
        public readonly string fpox;
        public readonly string measles;
        public readonly string all;
        public readonly string fpox2all;
        public readonly string measles2all;

        public poxetc(string fpox, string measles, string all, string fpox2all, string measles2all)
        {
            this.fpox = fpox;
            this.measles = measles;
            this.all = all;
            this.fpox2all = fpox2all;
            this.measles2all = measles2all;
        }

        public static IEnumerable<poxetc> Data
        {
            get
            {
                yield return new poxetc("72", "42", "8814", "8.17", "4.47");
                yield return new poxetc("40", "2", "10471", "3.82", "0.19");
                yield return new poxetc("58", "3", "8458", "6.85", "0.35");
                yield return new poxetc("531", "80", "9539", "55.66", "8.38");
                yield return new poxetc("72", "21", "8427", "8.54", "2.49");
                yield return new poxetc("1354", "33", "10865", "124.62", "3.03");
                yield return new poxetc("293", "27", "10641", "27.53", "2.53");
                yield return new poxetc("127", "12", "23382", "5.48", "0.51");
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc("139", "5", "13784", "10.08", "0.36");
                yield return new poxetc("400", "92", "9896", "40.42", "93");
                yield return new poxetc("1190", "3", "10532", "112.29", "0.28");
                yield return new poxetc("184", "33", "8681", "21.19", "3.8");
                yield return new poxetc("525", "33", "10773", "48.73", "3.06");
                yield return new poxetc("1279", "62", "12541", "101.98", "4.94");
                yield return new poxetc("139", "8", "9082", "15.3", "0.88");
                yield return new poxetc("812", "52", "13126", "61.86", "3.96");
                yield return new poxetc("1294", "11", "11409", "113.42", "0.96");
                yield return new poxetc("823", "153", "13752", "59.85", "11.12");
                yield return new poxetc("835", "15", "12434", "67.15", "1.2");
                yield return new poxetc("409", "80", "14993", "27.27", "5.33");
                yield return new poxetc("1523", "6", "14756", "103.21", "0.4");
                yield return new poxetc("354", "74", "15118", "23.41", "4.89");
                yield return new poxetc("1246", "188", "19771", "63.02", "9.5");
                yield return new poxetc("768", "20", "16554", "46.39", "1.2");
                yield return new poxetc("411", "42", "15356", "26.76", "2.73");
                yield return new poxetc("1233", "311", "18297", "67.38", "16.99");
                yield return new poxetc("655", "7", "97306", "6.73", "0.07");
                yield return new poxetc("38", "3", "12738", "2.98", "0.23");
                yield return new poxetc("1196", "83", "15842", "75.49", "5.23");
                yield return new poxetc("1987", "200", "17278", "115", "11.57");
                yield return new poxetc("951", "15", "19432", "48.93", "0.77");
                yield return new poxetc("1465", "295", "20198", "72.53", "14.6");
                yield return new poxetc("696", "7", "15729", "44.24", "0.44");
                yield return new poxetc("1116", "118", "18230", "61.21", "6.47");
                yield return new poxetc("853", "15", "17504", "48.73", "0.85");
                yield return new poxetc("2507", "795", "21201", "118.24", "37.49");
                yield return new poxetc("997", "1", "17244", "57.81", "0.05");
                yield return new poxetc("359", "83", "18732", "19.16", "4.43");
                yield return new poxetc("1678", "87", "19067", "88", "4.56");
                yield return new poxetc("1798", "93", "20678", "86.95", "4.49");
                yield return new poxetc("1967", "117", "21730", "90.52", "5.38");
                yield return new poxetc("689", "49", "21053", "32.72", "2.32");
                yield return new poxetc("2982", "121", "23971", "124.4", "5.04");
                yield return new poxetc("1408", "50", "20691", "68.04", "2.41");
                yield return new poxetc("2096", "39", "20587", "101.81", "1.89");
                yield return new poxetc("1560", "6", "23202", "67.23", "0.25");
                yield return new poxetc("2496", "197", "23222", "107.48", "8.48");
                yield return new poxetc("1062", "25", "22609", "46.97", "1.7");
                yield return new poxetc("1551", null, "21460", "72.27", null);
                yield return new poxetc("1318", null, "22921", "57.5", null);
                yield return new poxetc("1389", null, "23502", "59.1", null);
                yield return new poxetc("778", null, "21461", "36.25", null);
                yield return new poxetc("1241", null, "22691", "54.69", null);
                yield return new poxetc("1592", null, "20874", "76.26", null);
                yield return new poxetc("1164", null, "20959", "55.53", null);
                yield return new poxetc("1683", null, "24100", "69.83", null);
                yield return new poxetc("784", null, "19047", "41.16", null);
                yield return new poxetc("196", null, "18638", "10.51", null);
                yield return new poxetc("634", null, "20970", "30.23", null);
                yield return new poxetc("1813", null, "20183", "89.82", null);
                yield return new poxetc("890", null, "20795", "42.79", null);
                yield return new poxetc("1031", null, "19443", "53.02", null);
                yield return new poxetc("1095", "4", "20471", "53.49", "0.95");
                yield return new poxetc("311", "27", "19481", "15.96", "1.38");
                yield return new poxetc("898", "51", "20720", "43.33", "2.46");
                yield return new poxetc("1501", "12", "22684", "66.16", "0.52");
                yield return new poxetc("1095", "319", "22097", "49.55", "14.43");
                yield return new poxetc("721", "361", "19847", "36.32", "18.18");
                yield return new poxetc("1078", "37", "21600", "49.9", "1.71");
                yield return new poxetc("1687", "126", "21291", "79.23", "5.91");
                yield return new poxetc("1024", "89", "21800", "46.97", "4.08");
                yield return new poxetc("3138", "181", "24620", "127.45", "7.35");
                yield return new poxetc("915", "97", "19833", "46.13", "4.89");
                yield return new poxetc("1943", "77", "21198", "91.65", "3.63");
                yield return new poxetc("1614", "61", "21057", "76.64", "2.89");
                yield return new poxetc("2810", "139", "26569", "105.76", "5.23");
                yield return new poxetc("1057", "30", "22232", "47.54", "1.34");
                yield return new poxetc("2427", "270", "24436", "99.32", "11.04");
                yield return new poxetc("2211", "35", "23446", "94.3", "1.49");
                yield return new poxetc("1884", "492", "26523", "71.03", "18.54");
                yield return new poxetc("3229", "243", "28347", "113.9", "8.57");
                yield return new poxetc("1440", "213", "25454", "56.57", "8.36");
                yield return new poxetc("2375", "238", "26142", "90.84", "9.1");
                yield return new poxetc("2167", "114", "25750", "84.15", "4.42");
                yield return new poxetc("3271", "231", "29197", "112.03", "7.91");
                yield return new poxetc("1227", "118", "25952", "47.39", "4.54");
                yield return new poxetc("3188", "70", "25523", "124.9", "2.74");
                yield return new poxetc("1519", "256", "29647", "52.92", "8.63");
                yield return new poxetc("2379", "72", "28418", "83.71", "2.53");
                yield return new poxetc("2105", "82", "27810", "75.69", "2.94");
                yield return new poxetc("2849", "41", "29722", "95.85", "1.37");
                yield return new poxetc("1914", "311", "26761", "71.52", "11.62");
                yield return new poxetc("2640", "102", "25262", "104.5", "4.03");
                yield return new poxetc("1197", "30", "23358", "51.24", "1.28");
                yield return new poxetc("1370", "605", "29233", "46.86", "20.69");
                yield return new poxetc("2688", "20", "26062", "103.13", "0.76");
                yield return new poxetc("1594", "10", "23538", "67.72", "0.42");
                yield return new poxetc("3014", "169", "27581", "109.27", "6.12");
                yield return new poxetc("2084", "127", "27823", "74.9", "4.56");
                yield return new poxetc("1590", "216", "25825", "61.56", "8.36");
                yield return new poxetc("1690", "326", "25432", "66.45", "12.81");
                yield return new poxetc("2725", "46", "30811", "88.44", "1.48");
                yield return new poxetc("1977", "42", "32169", "61.45", "1.3");
                yield return new poxetc("1429", "981", "27483", "51.99", "35.69");
                yield return new poxetc("2029", "17", "25200", "80.51", "0.67");
                yield return new poxetc("1633", "5", "20606", "79.24", "0.24");
                yield return new poxetc("1206", "14", "21296", "56.63", "0.65");
                yield return new poxetc("3236", "250", "28157", "114.92", "8.87");
                yield return new poxetc("1380", "81", "25494", "54.13", "3.17");
                yield return new poxetc("1789", "10", "23869", "74.95", "0.41");
                yield return new poxetc("2625", "106", "25516", "102.87", "4.15");
                yield return new poxetc("1229", "321", "23727", "52.64", "13.52");
                yield return new poxetc("998", "21", "21028", "47.46", "0.99");
                yield return new poxetc("3538", "111", "20485", "172.71", "5.41");
                yield return new poxetc("774", "253", "19276", "40.15", "13.12");
                yield return new poxetc("2359", "12", "22696", "103.93", "0.52");
                yield return new poxetc("1988", "423", "21917", "90.7", "19.3");
                yield return new poxetc("1608", "156", "20872", "77.04", "7.42");
                yield return new poxetc("3296", "24", "21313", "154.64", "1.12");
                yield return new poxetc("1273", "696", "17576", "72.42", "39.59");
                yield return new poxetc("2596", "316", "19604", "132.42", "16.12");
                yield return new poxetc("2187", "175", "19830", "110.28", "8.82");
                yield return new poxetc("1525", "394", "21063", "72.4", "18.7");
                yield return new poxetc("2743", "122", "26326", "104.19", "4.63");
                yield return new poxetc("3582", "610", "26148", "136.98", "23.32");
                yield return new poxetc("2382", "65", "23202", "102.66", "2.8");
                yield return new poxetc("2498", "54", "23230", "107.53", "2.32");
                yield return new poxetc("2334", "482", "23911", "97.61", "20.15");
                yield return new poxetc("2188", "80", "22612", "96.76", "3.53");
                yield return new poxetc("3028", "409", "23639", "128.09", "17.3");
                yield return new poxetc("1968", "90", "21847", "90.08", "4.11");
                yield return new poxetc("1986", "325", "22434", "88.52", "14.48");
                yield return new poxetc("1660", "115", "21780", "76.21", "52.8");
                yield return new poxetc("3992", "211", "26053", "15.32", "8.09");
                yield return new poxetc("1039", "199", "21656", "47.97", "9.18");
                yield return new poxetc("2479", "121", "20884", "118.7", "5.79");
                yield return new poxetc("2669", "283", "20514", "130.1", "13.79");
                yield return new poxetc("1728", "153", "19048", "90.71", "8.03");
                yield return new poxetc("2567", "145", "23334", "110.01", "6.21");
                yield return new poxetc("1425", "388", "20399", "69.85", "19.02");
                yield return new poxetc("2493", "99", "20420", "122.08", "4.84");
                yield return new poxetc("871", "272", "20517", "42.45", "13.25");
                yield return new poxetc("3500", "201", "20709", "169", "9.7");
                yield return new poxetc("636", "170", "17918", "35.49", "9.48");
                yield return new poxetc("1550", "185", "19029", "81.45", "9.72");
                yield return new poxetc("1759", "29", "17828", "98.66", "1.62");
                yield return new poxetc("1999", "20", "18919", "105.66", "1.05");
                yield return new poxetc("1210", "793", "20454", "59.15", "38.76");
                yield return new poxetc("2418", "84", "19349", "124.96", "4.34");
                yield return new poxetc("1101", "55", "19697", "55.89", "2.79");
                yield return new poxetc("2077", "534", "20749", "100.1", "25.73");
                yield return new poxetc("1617", "119", "18038", "89.64", "6.59");
                yield return new poxetc("1747", "156", "18760", "93.12", "8.31");
                yield return new poxetc("1568", "450", "20213", "77.57", "22.26");
                yield return new poxetc("2382", "248", "21749", "109.52", "11.4");
                yield return new poxetc("1913", "172", "19241", "99.42", "8.93");
                yield return new poxetc("1040", "328", "21179", "49.1", "15.48");
                yield return new poxetc("3548", "307", "19288", "183.94", "15.91");
                yield return new poxetc("522", "222", "17014", "30.68", "13.04");
                yield return new poxetc("2337", "196", "18155", "128.72", "10.79");
                yield return new poxetc("1111", "223", "18134", "61.26", "12.29");
                yield return new poxetc("2409", "395", "23068", "104.43", "17.12");
                yield return new poxetc("1461", "136", "19374", "75.41", "7.02");
                yield return new poxetc("1579", "559", "19379", "81.99", "28.48");
                yield return new poxetc("1202", "438", "19582", "61.38", "22.36");
                yield return new poxetc("622", "619", "17034", "36.5", "36.33");
                yield return new poxetc("1685", "523", "17565", "95.92", "29.77");
                yield return new poxetc("1158", "530", "17938", "64.55", "29.54");
                yield return new poxetc("1297", "452", "18334", "70.74", "24.56");
                yield return new poxetc("1169", "1386", "19954", "58.58", "69.45");
                yield return new poxetc("1163", "106", "16680", "69.72", "6.35");
                yield return new poxetc("1198", "1031", "19893", "60.22", "51.82");
                yield return new poxetc("751", "235", "17043", "44.06", "13.78");
                yield return new poxetc("1287", "427", "18295", "70.34", "23.33");
                yield return new poxetc("898", "550", "17322", "51.89", "31.75");
                yield return new poxetc("638", "817", "19283", "33.08", "42.36");
                yield return new poxetc("725", "711", "19560", "37.06", "36.34");
                yield return new poxetc("653", "1106", "20316", "32.14", "54.43");
                yield return new poxetc("1051", "725", "19968", "52.63", "36.3");
                yield return new poxetc("421", "728", "19705", "21.36", "36.94");
                yield return new poxetc("712", "695", "19228", "37.02", "36.14");
                yield return new poxetc("792", "720", "19348", "40.93", "37.21");
                yield return new poxetc("508", "547", "18451", "27.53", "29.64");
                yield return new poxetc("604", "712", "18865", "32.01", "37.74");
                yield return new poxetc("774", "573", "20587", "37.59", "27.83");
                yield return new poxetc("725", "966", "20237", "35.82", "17.73");
                yield return new poxetc("1299", "743", "21026", "61.78", "35.33");
                yield return new poxetc("503", "774", "20758", "24.23", "37.28");
                yield return new poxetc("616", "525", "22292", "27.63", "23.55");
                yield return new poxetc("598", "736", "21709", "27.54", "33.9");
                yield return new poxetc("736", "578", "23524", "31.28", "24.57");
                yield return new poxetc("627", "479", "21645", "28.97", "22.12");
                yield return new poxetc("563", "750", "25337", "22.22", "29.6");
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc(null, null, null, null, null);
                yield return new poxetc("1053", "973", "45507", "23.11", "21.38");
                yield return new poxetc("360", "1293", "45400", "7.92", "28.48");
                yield return new poxetc("438", "1442", "48718", "8.99", "29.6");
                yield return new poxetc("1804", "1182", "51110", "35.29", "23.12");
                yield return new poxetc("909", "2318", "48318", "18.81", "47.97");
                yield return new poxetc("257", "747", "49450", "5.1", "15.1");
                yield return new poxetc("955", "1778", "59131", "16.15", "30.06");
                yield return new poxetc("1620", "1144", "57771", "28.04", "19.8");
                yield return new poxetc("521", "1154", "68755", "7.57", "16.78");
                yield return new poxetc("499", "980", "48950", "10.19", "20.02");
                yield return new poxetc("1062", "1297", "55488", "19.13", "23.37");
                yield return new poxetc("1159", "595", "54638", "21.21", "10.88");
                yield return new poxetc("211", "978", "60069", "3.51", "16.28");
                yield return new poxetc("694", "1409", "73697", "9.41", "19.11");
                yield return new poxetc("1039", "878", "61942", "16.77", "14.17");
                yield return new poxetc("531", "1479", "57274", "9.27", "25.82");
                yield return new poxetc("156", "1341", "59103", "2.63", "22.68");
                yield return new poxetc("242", "2369", "64093", "3.77", "36.96");
                yield return new poxetc("1158", "1330", "61860", "18.55", "21.5");
                yield return new poxetc("898", "2090", "62309", "14.41", "33.54");
                yield return new poxetc("217", "1062", "65251", "3.32", "16.27");
                yield return new poxetc("366", "2334", "67371", "5.43", "34.64");
                yield return new poxetc("1996", "1634", "71060", "28.08", "22.99");
                yield return new poxetc("547", "2788", "78238", "6.99", "35.63");
                yield return new poxetc("640", "1290", "73531", "8.7", "17.53");
                yield return new poxetc("1391", "2220", "80453", "17.28", "27.59");
                yield return new poxetc("1345", "1143", "70924", "18.96", "16.11");
                yield return new poxetc("597", "1962", "73798", "8.09", "26.59");
                yield return new poxetc("275", "1456", "78082", "3.52", "18.65");
                yield return new poxetc("973", "1449", "77634", "12.53", "18.66");
                yield return new poxetc("7912", "1427", "80430", "98.37", "17.74");
                yield return new poxetc("1786", "1680", "71355", "25.02", "23.54");
                yield return new poxetc("113", "2149", "75459", "1.49", "28.47");
                yield return new poxetc("57", "1680", "76813", "0.74", "21.87");
                yield return new poxetc("46", "1408", "81964", "0.56", "17.17");
                yield return new poxetc("736", "1720", "77671", "9.47", "22.14");
                yield return new poxetc("2551", "2387", "77449", "32.93", "30.82");
                yield return new poxetc("1417", "1500", "84188", "16.83", "17.81");
                yield return new poxetc("450", "2475", "83805", "5.36", "29.53");
                yield return new poxetc("475", "1501", "81128", "5.85", "18.5");
                yield return new poxetc("2371", "2533", "81071", "29.24", "31.25");
            }
        }
    }
}
