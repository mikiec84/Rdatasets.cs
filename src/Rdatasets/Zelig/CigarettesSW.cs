// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Cigarette Consumption Panel Data
    /// </summary>

    public class CigarettesSW
    {
        public readonly string state;
        public readonly int year;
        public readonly double cpi;
        public readonly string population;
        public readonly double packs;
        public readonly int income;
        public readonly double tax;
        public readonly double price;
        public readonly double taxs;

        public CigarettesSW(string state, int year, double cpi, string population, double packs, int income, double tax, double price, double taxs)
        {
            this.state = state;
            this.year = year;
            this.cpi = cpi;
            this.population = population;
            this.packs = packs;
            this.income = income;
            this.tax = tax;
            this.price = price;
            this.taxs = taxs;
        }

        public static IEnumerable<CigarettesSW> Data
        {
            get
            {
                yield return new CigarettesSW("AL", 1985, 1.07599997520447, "3973000", 116.486282348633, 46014968, 32.5000038146973, 102.181671142578, 33.3483352661133);
                yield return new CigarettesSW("AR", 1985, 1.07599997520447, "2327000", 128.534591674805, 26210736, 37, 101.474998474121, 37);
                yield return new CigarettesSW("AZ", 1985, 1.07599997520447, "3184000", 104.522613525391, 43956936, 31, 108.578750610352, 36.1704177856445);
                yield return new CigarettesSW("CA", 1985, 1.07599997520447, "26444000", 100.363037109375, 447102816, 26, 107.837341308594, 32.1040000915527);
                yield return new CigarettesSW("CO", 1985, 1.07599997520447, "3209000", 112.963539123535, 49466672, 31, 94.2666625976562, 31);
                yield return new CigarettesSW("CT", 1985, 1.07599997520447, "3201000", 109.278350830078, 60063368, 42, 128.024993896484, 51.4833335876465);
                yield return new CigarettesSW("DE", 1985, 1.07599997520447, "618000", 143.851135253906, 9927301, 30, 102.491661071777, 30);
                yield return new CigarettesSW("FL", 1985, 1.07599997520447, "11352000", 122.181121826172, 166919248, 37, 115.290000915527, 42.4900016784668);
                yield return new CigarettesSW("GA", 1985, 1.07599997520447, "5963000", 127.234619140625, 78364336, 28, 97.0251693725586, 28.841833114624);
                yield return new CigarettesSW("IA", 1985, 1.07599997520447, "2830000", 113.745582580566, 37902896, 34, 101.842002868652, 37.9169998168945);
                yield return new CigarettesSW("ID", 1985, 1.07599997520447, "994000", 103.018112182617, 11577261, 25.1000003814697, 102.89933013916, 29.0576667785645);
                yield return new CigarettesSW("IL", 1985, 1.07599997520447, "11401000", 123.208480834961, 176786352, 28.0000057220459, 104.440254211426, 28.9152565002441);
                yield return new CigarettesSW("IN", 1985, 1.07599997520447, "5460000", 137.63737487793, 71751616, 26.5, 96.1800003051758, 31.0799999237061);
                yield return new CigarettesSW("KS", 1985, 1.07599997520447, "2428000", 116.680397033691, 34784360, 32, 98.9229125976562, 34.8812484741211);
                yield return new CigarettesSW("KY", 1985, 1.07599997520447, "3695000", 186.035186767578, 42703144, 19, 87.0012512207031, 23.1429176330566);
                yield return new CigarettesSW("LA", 1985, 1.07599997520447, "4409000", 127.557266235352, 53431900, 32, 108.393997192383, 36.1689987182617);
                yield return new CigarettesSW("MA", 1985, 1.07599997520447, "5881000", 115.677597045898, 98328688, 42, 112.208335876465, 42);
                yield return new CigarettesSW("MD", 1985, 1.07599997520447, "4414000", 120.978706359863, 74851664, 29, 91.966667175293, 29);
                yield return new CigarettesSW("ME", 1985, 1.07599997520447, "1163000", 128.116943359375, 14575292, 36, 107.047500610352, 41.0974998474121);
                yield return new CigarettesSW("MI", 1985, 1.07599997520447, "9077000", 128.004852294922, 133728040, 37, 104.914169311523, 37.8308334350586);
                yield return new CigarettesSW("MN", 1985, 1.07599997520447, "4185000", 112.903228759766, 63152360, 34, 113.64966583252, 40.4329986572266);
                yield return new CigarettesSW("MO", 1985, 1.07599997520447, "5001000", 130.373931884766, 69341920, 29.0000038146973, 99.3381652832031, 29.8548374176025);
                yield return new CigarettesSW("MS", 1985, 1.07599997520447, "2588000", 117.040184020996, 25678534, 27.5833320617676, 105.293334960938, 33.5433311462402);
                yield return new CigarettesSW("MT", 1985, 1.07599997520447, "822000", 104.257904052734, 9785230, 32, 99.2916641235352, 32);
                yield return new CigarettesSW("NC", 1985, 1.07599997520447, "6255000", 155.283767700195, 79104656, 18, 84.9679946899414, 21.2679996490479);
                yield return new CigarettesSW("ND", 1985, 1.07599997520447, "677000", 105.465286254883, 8672948, 34, 106.807998657227, 38.1080017089844);
                yield return new CigarettesSW("NE", 1985, 1.07599997520447, "1585000", 107.381706237793, 21778072, 34, 104.606666564941, 38.0233345031738);
                yield return new CigarettesSW("NH", 1985, 1.07599997520447, "997000", 197.993988037109, 15767469, 33, 95.5, 33);
                yield return new CigarettesSW("NJ", 1985, 1.07599997520447, "7566000", 116.521278381348, 133549208, 41, 110.416664123535, 41);
                yield return new CigarettesSW("NM", 1985, 1.07599997520447, "1439000", 88.7421798706055, 17258916, 28, 102.77799987793, 31.9529991149902);
                yield return new CigarettesSW("NV", 1985, 1.07599997520447, "951000", 141.955841064453, 14581495, 31, 114.188499450684, 37.4635009765625);
                yield return new CigarettesSW("NY", 1985, 1.07599997520447, "17794000", 116.66291809082, 297728512, 37.0000038146973, 109.997825622559, 37.8811721801758);
                yield return new CigarettesSW("OH", 1985, 1.07599997520447, "10736000", 127.598739624023, 153455776, 30, 100.42374420166, 34.7820816040039);
                yield return new CigarettesSW("OK", 1985, 1.07599997520447, "3272000", 127.139366149902, 43395580, 34, 101.468078613281, 34.826416015625);
                yield return new CigarettesSW("OR", 1985, 1.07599997520447, "2673000", 119.453796386719, 36205164, 35, 97.033332824707, 35);
                yield return new CigarettesSW("PA", 1985, 1.07599997520447, "11772000", 117.703025817871, 170033840, 34, 109.074005126953, 40.173999786377);
                yield return new CigarettesSW("RI", 1985, 1.07599997520447, "967000", 132.781784057617, 14229156, 39, 100.941665649414, 39);
                yield return new CigarettesSW("SC", 1985, 1.07599997520447, "3304000", 127.209442138672, 38536176, 23, 90.6412506103516, 27.3162498474121);
                yield return new CigarettesSW("SD", 1985, 1.07599997520447, "698000", 106.590255737305, 8340000, 31, 97.0833358764648, 31);
                yield return new CigarettesSW("TN", 1985, 1.07599997520447, "4716000", 129.834594726562, 57749668, 29, 101.945503234863, 34.7705001831055);
                yield return new CigarettesSW("TX", 1985, 1.07599997520447, "16275000", 115.102928161621, 231003152, 35.25, 107.379997253418, 39.3800010681152);
                yield return new CigarettesSW("UT", 1985, 1.07599997520447, "1643000", 68.046257019043, 19462380, 28, 110.195838928223, 34.2374992370605);
                yield return new CigarettesSW("VA", 1985, 1.07599997520447, "5716000", 134.009796142578, 87361632, 18.5000019073486, 91.6153335571289, 22.0236682891846);
                yield return new CigarettesSW("VT", 1985, 1.07599997520447, "530000", 145.283020019531, 6887097, 33, 100.983337402344, 33);
                yield return new CigarettesSW("WA", 1985, 1.07599997520447, "4401000", 96.2281265258789, 64846548, 39, 129.461090087891, 47.4694175720215);
                yield return new CigarettesSW("WI", 1985, 1.07599997520447, "4748000", 107.876998901367, 65732720, 41, 114.590003967285, 46.4566650390625);
                yield return new CigarettesSW("WV", 1985, 1.07599997520447, "1907000", 112.84740447998, 20852964, 33, 108.911247253418, 38.1862487792969);
                yield return new CigarettesSW("WY", 1985, 1.07599997520447, "5e+05", 129.399993896484, 7116756, 24, 93.466667175293, 24);
                yield return new CigarettesSW("AL", 1995, 1.5239999294281, "4262731", 101.085433959961, 83903280, 40.5000038146973, 158.371337890625, 41.904670715332);
                yield return new CigarettesSW("AR", 1995, 1.5239999294281, "2480121", 111.04296875, 45995496, 55.5, 175.542510986328, 63.8591690063477);
                yield return new CigarettesSW("AZ", 1995, 1.5239999294281, "4306908", 71.9541702270508, 88870496, 65.3333282470703, 198.607498168945, 74.7908248901367);
                yield return new CigarettesSW("CA", 1995, 1.5239999294281, "31493524", 56.8593063354492, 771470144, 61, 210.504669189453, 74.7713317871094);
                yield return new CigarettesSW("CO", 1995, 1.5239999294281, "3738061", 82.5829238891602, 92946544, 44, 167.350006103516, 44);
                yield return new CigarettesSW("CT", 1995, 1.5239999294281, "3265293", 79.4721908569336, 104315120, 74, 218.280502319336, 86.3554992675781);
                yield return new CigarettesSW("DE", 1995, 1.5239999294281, "718265", 124.466598510742, 18237436, 48, 165.600006103516, 48);
                yield return new CigarettesSW("FL", 1995, 1.5239999294281, "14185403", 93.0745544433594, 333525344, 57.9000015258789, 187.717178344727, 68.525505065918);
                yield return new CigarettesSW("GA", 1995, 1.5239999294281, "7188538", 97.4746246337891, 159800448, 36, 156.57307434082, 37.4314155578613);
                yield return new CigarettesSW("IA", 1995, 1.5239999294281, "2840860", 92.4015960693359, 60170928, 60, 190.889999389648, 69.0899963378906);
                yield return new CigarettesSW("ID", 1995, 1.5239999294281, "1165000", 74.8497848510742, 22868920, 52, 179.637512207031, 60.5541687011719);
                yield return new CigarettesSW("IL", 1995, 1.5239999294281, "11884935", 83.2650756835938, 304767456, 68.0000076293945, 198.476165771484, 79.234504699707);
                yield return new CigarettesSW("IN", 1995, 1.5239999294281, "5791819", 134.258346557617, 126525008, 39.5, 154.533752441406, 46.8587493896484);
                yield return new CigarettesSW("KS", 1995, 1.5239999294281, "2586942", 88.7534408569336, 56626672, 48, 175.210006713867, 56.343334197998);
                yield return new CigarettesSW("KY", 1995, 1.5239999294281, "3855248", 172.64778137207, 74079712, 27, 145.979675292969, 35.2630004882812);
                yield return new CigarettesSW("LA", 1995, 1.5239999294281, "4327978", 105.176132202148, 84572688, 44, 167.795349121094, 50.4536666870117);
                yield return new CigarettesSW("MA", 1995, 1.5239999294281, "6062335", 76.6206436157227, 170051568, 75, 217.105010986328, 85.3383331298828);
                yield return new CigarettesSW("MD", 1995, 1.5239999294281, "5023650", 77.4735488891602, 135115456, 60, 186.033752441406, 68.8587493896484);
                yield return new CigarettesSW("ME", 1995, 1.5239999294281, "1237438", 102.469779968262, 25045934, 61, 197.230651855469, 72.1640014648438);
                yield return new CigarettesSW("MI", 1995, 1.5239999294281, "9659871", 81.3882522583008, 231594240, 99, 240.849670410156, 112.633003234863);
                yield return new CigarettesSW("MN", 1995, 1.5239999294281, "4605445", 82.9452972412109, 113216856, 72, 220.348663330078, 86.4153366088867);
                yield return new CigarettesSW("MO", 1995, 1.5239999294281, "5324610", 122.45027923584, 117639672, 41.0000038146973, 157.230087280273, 42.3884201049805);
                yield return new CigarettesSW("MS", 1995, 1.5239999294281, "2690788", 105.582450866699, 46241956, 42, 169.229400634766, 53.0710830688477);
                yield return new CigarettesSW("MT", 1995, 1.5239999294281, "868522", 87.1595687866211, 16296835, 42, 156.216674804688, 42);
                yield return new CigarettesSW("NC", 1995, 1.5239999294281, "7185403", 121.538063049316, 157633568, 29, 149.994003295898, 34.7690010070801);
                yield return new CigarettesSW("ND", 1995, 1.5239999294281, "641548", 79.8069686889648, 12243384, 68, 192.248672485352, 78.8820037841797);
                yield return new CigarettesSW("NE", 1995, 1.5239999294281, "1635142", 87.2707061767578, 36293064, 58, 182.175003051758, 66.6750030517578);
                yield return new CigarettesSW("NH", 1995, 1.5239999294281, "1145604", 156.33674621582, 28649564, 49, 166.641662597656, 49);
                yield return new CigarettesSW("NJ", 1995, 1.5239999294281, "7965523", 80.3713684082031, 233208576, 64, 203.087173461914, 75.4954986572266);
                yield return new CigarettesSW("NM", 1995, 1.5239999294281, "1682417", 64.6688690185547, 31716160, 45, 176.146240234375, 53.3879165649414);
                yield return new CigarettesSW("NV", 1995, 1.5239999294281, "1525777", 93.5261154174805, 39377292, 59, 206.599166870117, 72.5158309936523);
                yield return new CigarettesSW("NY", 1995, 1.5239999294281, "18150928", 70.8173217773438, 503163328, 80, 221.858001708984, 88.5329971313477);
                yield return new CigarettesSW("OH", 1995, 1.5239999294281, "11155493", 111.380104064941, 255312928, 48, 165.891250610352, 55.8995819091797);
                yield return new CigarettesSW("OK", 1995, 1.5239999294281, "3265547", 108.680107116699, 63333300, 47, 170.134994506836, 55.1016654968262);
                yield return new CigarettesSW("OR", 1995, 1.5239999294281, "3141421", 92.1557464599609, 71209312, 62, 190.300003051758, 62);
                yield return new CigarettesSW("PA", 1995, 1.5239999294281, "12044780", 95.6430892944336, 285923232, 55, 176.163162231445, 64.9714965820312);
                yield return new CigarettesSW("RI", 1995, 1.5239999294281, "989203", 92.5998001098633, 23786644, 80, 224.459243774414, 94.6842498779297);
                yield return new CigarettesSW("SC", 1995, 1.5239999294281, "3699943", 108.082748413086, 72050072, 31, 152.818740844727, 38.2770843505859);
                yield return new CigarettesSW("SD", 1995, 1.5239999294281, "728251", 97.2192306518555, 14454129, 47, 168.037994384766, 53.4630012512207);
                yield return new CigarettesSW("TN", 1995, 1.5239999294281, "5241168", 122.320053100586, 114259984, 37, 167.067001342773, 49.3753318786621);
                yield return new CigarettesSW("TX", 1995, 1.5239999294281, "18679706", 73.0793075561523, 402096768, 65, 198.202331542969, 76.2190017700195);
                yield return new CigarettesSW("UT", 1995, 1.5239999294281, "1976774", 49.2721977233887, 37278220, 50.5, 180.976257324219, 59.1179161071777);
                yield return new CigarettesSW("VA", 1995, 1.5239999294281, "6601392", 105.386871337891, 161441792, 26.5000057220459, 166.661254882812, 34.4362564086914);
                yield return new CigarettesSW("VT", 1995, 1.5239999294281, "582827", 122.334754943848, 12448607, 44, 175.638748168945, 52.3637504577637);
                yield return new CigarettesSW("WA", 1995, 1.5239999294281, "5431024", 65.5309219360352, 129680832, 80.5, 239.109344482422, 96.1426696777344);
                yield return new CigarettesSW("WI", 1995, 1.5239999294281, "5137004", 92.4663467407227, 115959680, 62, 201.381256103516, 71.5895843505859);
                yield return new CigarettesSW("WV", 1995, 1.5239999294281, "1820560", 115.568832397461, 32611268, 41, 166.517181396484, 50.4254989624023);
                yield return new CigarettesSW("WY", 1995, 1.5239999294281, "478447", 112.238136291504, 10293195, 36, 158.541656494141, 36);
            }
        }
    }
}
