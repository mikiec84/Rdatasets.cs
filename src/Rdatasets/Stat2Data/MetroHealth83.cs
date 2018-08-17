// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// MetroHealth83
    /// </summary>

    public class MetroHealth83
    {
        public readonly string City;
        public readonly int NumMDs;
        public readonly int RateMDs;
        public readonly int NumHospitals;
        public readonly int NumBeds;
        public readonly int RateBeds;
        public readonly int NumMedicare;
        public readonly double PctChangeMedicare;
        public readonly int MedicareRate;
        public readonly int SSBNum;
        public readonly int SSBRate;
        public readonly double SSBChange;
        public readonly int NumRetired;
        public readonly int SSINum;
        public readonly int SSIRate;
        public readonly double SqrtMDs;

        public MetroHealth83(string City, int NumMDs, int RateMDs, int NumHospitals, int NumBeds, int RateBeds, int NumMedicare, double PctChangeMedicare, int MedicareRate, int SSBNum, int SSBRate, double SSBChange, int NumRetired, int SSINum, int SSIRate, double SqrtMDs)
        {
            this.City = City;
            this.NumMDs = NumMDs;
            this.RateMDs = RateMDs;
            this.NumHospitals = NumHospitals;
            this.NumBeds = NumBeds;
            this.RateBeds = RateBeds;
            this.NumMedicare = NumMedicare;
            this.PctChangeMedicare = PctChangeMedicare;
            this.MedicareRate = MedicareRate;
            this.SSBNum = SSBNum;
            this.SSBRate = SSBRate;
            this.SSBChange = SSBChange;
            this.NumRetired = NumRetired;
            this.SSINum = SSINum;
            this.SSIRate = SSIRate;
            this.SqrtMDs = SqrtMDs;
        }

        public static IEnumerable<MetroHealth83> Data
        {
            get
            {
                yield return new MetroHealth83("Holland-Grand Haven, MI", 349, 140, 3, 316, 127, 29533, 8.3, 11835, 34135, 13679, 8.1, 23165, 2070, 820, 18.6815);
                yield return new MetroHealth83("Louisville, KY-IN", 4042, 340, 18, 3909, 328, 173845, 3, 14606, 202485, 17013, 3, 118920, 29017, 2416, 63.5767);
                yield return new MetroHealth83("Battle Creek, MI", 256, 184, 3, 517, 372, 22972, 2.4, 16539, 27245, 19615, 3.3, 16645, 4095, 2945, 16);
                yield return new MetroHealth83("Madison, WI", 2679, 510, 7, 1467, 279, 60530, 5.2, 11528, 68705, 13085, 4.9, 47085, 6492, 1221, 51.7591);
                yield return new MetroHealth83("Fort Smith, AR-OK", 502, 179, 8, 975, 348, 45185, 4.6, 16146, 55370, 19785, 5.8, 29415, 9313, 3301, 22.4054);
                yield return new MetroHealth83("Sarasota-Bradenton-Venice, FL", 2352, 371, 7, 1899, 299, 161625, 2.5, 25474, 175580, 27674, 2.7, 129855, 7559, 1160, 48.4974);
                yield return new MetroHealth83("Anderson, IN", 200, 153, 2, 231, 176, 22828, 1.1, 17408, 26740, 20391, 1.1, 17040, 2717, 2080, 14.1421);
                yield return new MetroHealth83("Honolulu, HI", 3478, 389, 13, 2160, 242, 126752, 5.2, 14188, 136730, 15305, 4.7, 99140, 16226, 1804, 58.9746);
                yield return new MetroHealth83("Asheville, NC", 1489, 389, 5, 1213, 317, 76397, 5.1, 19970, 87520, 22877, 5.1, 56820, 8641, 2231, 38.5876);
                yield return new MetroHealth83("Winston-Salem, NC", 2018, 462, 6, 1901, 435, 66298, 6, 15165, 76180, 17426, 5.6, 50440, 7878, 1784, 44.9222);
                yield return new MetroHealth83("Springfield, IL", 1033, 505, 2, 1023, 500, 31300, 1.8, 15300, 36675, 17927, 2.5, 23275, 4734, 2312, 32.1403);
                yield return new MetroHealth83("Lakeland, FL", 954, 187, 4, 1190, 233, 93608, 5, 18324, 112470, 22017, 6.1, 73255, 14071, 2683, 30.8869);
                yield return new MetroHealth83("Sacramento--Arden-Arcade--Roseville, CA", 5738, 290, 15, 3584, 181, 245669, 8.3, 12436, 267360, 13534, 6.6, 167300, 68111, 3377, 75.7496);
                yield return new MetroHealth83("Green Bay, WI", 653, 224, 5, 669, 229, 37330, 4.6, 12790, 44345, 15193, 5.4, 28605, 3866, 1308, 25.5539);
                yield return new MetroHealth83("Myrtle Beach-Conway-North Myrtle Beach, SC", 419, 199, 3, 571, 271, 33827, 12.8, 16031, 45520, 21572, 13.5, 29905, 4429, 2035, 20.4695);
                yield return new MetroHealth83("Charleston, WV", 996, 324, 6, 1287, 419, 58627, 3, 19075, 68595, 22318, 3, 35070, 11931, 3877, 31.5595);
                yield return new MetroHealth83("Janesville, WI", 333, 215, 3, 394, 254, 22752, 4.2, 14683, 26990, 17418, 4.8, 17825, 2960, 1891, 18.2483);
                yield return new MetroHealth83("Raleigh-Cary, NC", 2036, 229, 6, 1739, 196, 85016, 11, 9579, 101005, 11381, 11.3, 62375, 13388, 1464, 45.1221);
                yield return new MetroHealth83("Providence-New Bedford-Fall River, RI-MA", 4990, 307, 15, 3595, 221, 261178, 0.7, 16091, 294285, 18131, 1, 193780, 48355, 2969, 70.6399);
                yield return new MetroHealth83("Pueblo, CO", 416, 279, 2, 543, 364, 25964, 3.5, 17424, 28160, 18898, 1.7, 15630, 4900, 3263, 20.3961);
                yield return new MetroHealth83("Beaumont-Port Arthur, TX", 708, 185, 10, 1412, 369, 58169, 1.4, 15193, 69150, 18061, 2.4, 38030, 10598, 2764, 26.6083);
                yield return new MetroHealth83("Trenton-Ewing, NJ", 1484, 411, 6, 1296, 359, 52272, 1.1, 14472, 56975, 15774, 0.1, 38370, 7578, 2075, 38.5227);
                yield return new MetroHealth83("Lewiston, ID-WA", 143, 245, 2, 197, 338, 11311, 6.1, 19411, 13140, 22549, 5.1, 8095, 1495, 2549, 11.9583);
                yield return new MetroHealth83("Odessa, TX", 255, 207, 2, 438, 356, 15937, 4.2, 12953, 18630, 15142, 2.9, 10020, 3501, 2812, 15.9687);
                yield return new MetroHealth83("Scranton--Wilkes-Barre, PA", 1404, 254, 14, 2140, 387, 115273, -2.2, 20855, 131200, 23737, -0.7, 85525, 15062, 2731, 37.47);
                yield return new MetroHealth83("Oxnard-Thousand Oaks-Ventura, CA", 1889, 239, 7, 1353, 171, 91182, 7.3, 11534, 101275, 12811, 5.8, 66365, 15092, 1892, 43.4626);
                yield return new MetroHealth83("Victoria, TX", 245, 217, 3, 656, 581, 16135, 4.9, 14279, 19075, 16881, 4.9, 11045, 2794, 2463, 15.6525);
                yield return new MetroHealth83("Hot Springs, AR", 297, 326, 3, 465, 510, 23127, 2.6, 25361, 24615, 26992, 2.4, 16325, 2692, 2922, 17.2337);
                yield return new MetroHealth83("Decatur, IL", 286, 257, 2, 494, 444, 20177, 0.9, 18124, 22655, 20349, 1.5, 14320, 3063, 2760, 16.9115);
                yield return new MetroHealth83("Fort Lauderdale-Pompano Beach-Deerfield Beach, FL Metropolitan Division", 4612, 267, 17, 4921, 285, 244892, -2.1, 14164, 273865, 15840, -1.8, 187475, 31563, 1799, 67.9117);
                yield return new MetroHealth83("Springfield, OH", 237, 166, 2, 392, 274, 24374, 0.6, 17066, 27120, 18988, 1.1, 16120, 3549, 2489, 15.3948);
                yield return new MetroHealth83("Springfield, IL", 1033, 505, 2, 1023, 500, 31300, 1.8, 15300, 36675, 17927, 2.5, 23275, 4734, 2312, 32.1403);
                yield return new MetroHealth83("Morgantown, WV", 843, 743, 4, 728, 641, 15026, 2, 13239, 17860, 15735, 3.2, 9965, 2788, 2450, 29.0345);
                yield return new MetroHealth83("Idaho Falls, ID", 226, 210, 2, 299, 278, 12830, 7.4, 11939, 15760, 14666, 8.6, 9775, 1622, 1469, 15.0333);
                yield return new MetroHealth83("Minneapolis-St. Paul-Bloomington, MN-WI", 9410, 305, 32, 6177, 200, 330821, 4.6, 10724, 376260, 12197, 4.7, 254260, 41751, 1340, 97.0052);
                yield return new MetroHealth83("Lawton, OK", 235, 213, 2, 445, 403, 13205, 5.2, 11972, 15795, 14320, 5.2, 9070, 2520, 2280, 15.3297);
                yield return new MetroHealth83("Anderson, IN", 200, 153, 2, 231, 176, 22828, 1.1, 17408, 26740, 20391, 1.1, 17040, 2717, 2080, 14.1421);
                yield return new MetroHealth83("Charleston, WV", 996, 324, 6, 1287, 419, 58627, 3, 19075, 68595, 22318, 3, 35070, 11931, 3877, 31.5595);
                yield return new MetroHealth83("Indianapolis, IN", 6180, 386, 18, 4997, 312, 190606, 4.5, 11907, 225295, 14074, 4.7, 144260, 22070, 1361, 78.613);
                yield return new MetroHealth83("Spartanburg, SC", 612, 234, 3, 626, 239, 41603, 6, 15891, 49690, 18980, 6.5, 28770, 6099, 2308, 24.7386);
                yield return new MetroHealth83("Brownsville-Harlingen, TX", 550, 152, 5, 975, 269, 38107, 5.6, 10516, 44335, 12235, 6, 24875, 17613, 4737, 23.4521);
                yield return new MetroHealth83("Huntsville, AL", 849, 237, 4, 973, 272, 46661, 10.6, 13048, 54080, 15123, 9.9, 32920, 7757, 2140, 29.1376);
                yield return new MetroHealth83("Hanford-Corcoran, CA", 144, 104, 3, 141, 102, 11430, 7.4, 8240, 13965, 10068, 7, 7760, 4377, 3070, 12);
                yield return new MetroHealth83("Reno-Sparks, NV", 1176, 314, 5, 1017, 271, 45320, 12.7, 12094, 53520, 14282, 12.8, 36230, 4822, 1254, 34.2929);
                yield return new MetroHealth83("Augusta-Richmond County, GA-SC", 1039, 204, 9, 1830, 359, 67240, 5.7, 13173, 82715, 16205, 5.9, 47615, 14179, 2752, 32.2335);
                yield return new MetroHealth83("Visalia-Porterville, CA", 527, 135, 3, 736, 188, 42622, 4.1, 10898, 51120, 13071, 4.7, 29935, 17503, 4359, 22.9565);
                yield return new MetroHealth83("Duluth, MN-WI", 821, 297, 11, 1567, 567, 49355, 0.5, 17860, 55110, 19942, 1.8, 33770, 6318, 2291, 28.6531);
                yield return new MetroHealth83("Shreveport-Bossier City, LA", 1714, 453, 9, 2235, 590, 55367, 2.8, 14622, 63285, 16714, 2.4, 36760, 13800, 3614, 41.4005);
                yield return new MetroHealth83("Little Rock-North Little Rock, AR", 2773, 441, 14, 3008, 478, 84220, 6.5, 13383, 103955, 16519, 6.1, 60350, 15323, 2407, 52.6593);
                yield return new MetroHealth83("Baton Rouge, LA", 1639, 227, 13, 2079, 288, 80643, 5.7, 11178, 98115, 13599, 5.8, 50580, 19953, 2738, 40.4846);
                yield return new MetroHealth83("Pocatello, ID", 180, 217, 2, 369, 445, 10306, 4.7, 12439, 11245, 13573, 4.8, 6775, 1583, 1904, 13.4164);
                yield return new MetroHealth83("Yuba City, CA", 272, 183, 2, 213, 144, 20038, 5.2, 13515, 22900, 15445, 3.4, 13260, 7185, 4746, 16.4924);
                yield return new MetroHealth83("Binghamton, NY", 681, 272, 2, 665, 265, 46273, 1.2, 18465, 53405, 21311, 1.1, 35075, 6612, 2653, 26.096);
                yield return new MetroHealth83("Kennewick-Richland-Pasco, WA", 389, 185, 4, 431, 205, 22589, 7.4, 10746, 26855, 12775, 6.7, 17070, 3226, 1497, 19.7231);
                yield return new MetroHealth83("Kankakee-Bradley, IL", 185, 174, 2, 445, 419, 16616, 2.1, 15636, 18995, 17875, 2.1, 11075, 2553, 2382, 13.6015);
                yield return new MetroHealth83("Barnstable Town, MA", 844, 368, 2, 306, 134, 57608, 2.6, 25149, 63295, 27632, 2.3, 45965, 3372, 1475, 29.0517);
                yield return new MetroHealth83("Worcester, MA", 2753, 355, 10, 1634, 211, 112188, 0.2, 14461, 126480, 16304, -0.5, 80890, 18941, 2430, 52.469);
                yield return new MetroHealth83("Fayetteville-Springdale-Rogers, AR-MO", 711, 188, 8, 860, 227, 50698, 5.2, 13396, 61165, 16162, 5.6, 37530, 5787, 1481, 26.6646);
                yield return new MetroHealth83("Flagstaff, AZ", 324, 267, 2, 267, 220, 14208, 10.7, 11725, 13425, 11079, 8.2, 7485, 3052, 2486, 18);
                yield return new MetroHealth83("Binghamton, NY", 681, 272, 2, 665, 265, 46273, 1.2, 18465, 53405, 21311, 1.1, 35075, 6612, 2653, 26.096);
                yield return new MetroHealth83("New Orleans-Metairie-Kenner, LA", 6050, 460, 23, 5723, 435, 179082, 2.7, 13610, 210865, 16025, 2.4, 111380, 49528, 3753, 77.7817);
                yield return new MetroHealth83("Boise City-Nampa, ID", 1195, 234, 6, 1062, 208, 56800, 10.1, 11102, 67440, 13182, 11.4, 43575, 7377, 1405, 34.5688);
                yield return new MetroHealth83("Medford, OR", 601, 316, 3, 539, 283, 33915, 6, 17816, 39415, 20705, 5.2, 26530, 3133, 1623, 24.5153);
                yield return new MetroHealth83("Bakersfield, CA", 1121, 157, 10, 1498, 210, 78689, 6.4, 11029, 94080, 13187, 6.4, 52445, 30476, 4147, 33.4813);
                yield return new MetroHealth83("La Crosse, WI-MN", 576, 448, 2, 484, 377, 18833, 2.7, 14656, 21235, 16525, 2.4, 14520, 2165, 1683, 24);
                yield return new MetroHealth83("Altoona, PA", 340, 267, 5, 469, 368, 25027, 0.6, 19634, 25500, 20005, 3.8, 16115, 4606, 3613, 18.4391);
                yield return new MetroHealth83("Warren-Farmington Hills-Troy, MI Metropolitan Division", 8107, 330, 23, 5046, 205, 325382, 3.8, 13237, 380405, 15475, 4.2, 245850, 29404, 1187, 90.0389);
                yield return new MetroHealth83("Ogden-Clearfield, UT", 765, 163, 4, 718, 153, 44492, 7.5, 9491, 48980, 10449, 7.3, 32330, 3982, 834, 27.6586);
                yield return new MetroHealth83("Trenton-Ewing, NJ", 1484, 411, 6, 1296, 359, 52272, 1.1, 14472, 56975, 15774, 0.1, 38370, 7578, 2075, 38.5227);
                yield return new MetroHealth83("Buffalo-Niagara Falls, NY", 4070, 351, 14, 5182, 447, 207164, -0.7, 17889, 234705, 20268, -0.7, 147130, 30670, 2657, 63.7966);
                yield return new MetroHealth83("Florence-Muscle Shoals, AL", 274, 193, 3, 552, 389, 26830, 5.1, 18923, 32430, 22872, 5.4, 17685, 4691, 3296, 16.5529);
                yield return new MetroHealth83("Winston-Salem, NC", 2018, 462, 6, 1901, 435, 66298, 6, 15165, 76180, 17426, 5.6, 50440, 7878, 1784, 44.9222);
                yield return new MetroHealth83("Midland, TX", 223, 188, 2, 373, 314, 14662, 5.3, 12335, 17410, 14647, 3.8, 10785, 2141, 1779, 14.9332);
                yield return new MetroHealth83("Clarksville, TN-KY", 364, 154, 3, 365, 155, 26365, 6.6, 11160, 32585, 13793, 6.6, 18670, 5496, 2301, 19.0788);
                yield return new MetroHealth83("Salt Lake City, UT", 3544, 352, 12, 2036, 202, 88603, 5.1, 8811, 103625, 10305, 5.1, 67300, 9802, 962, 59.5315);
                yield return new MetroHealth83("Midland, TX", 223, 188, 2, 373, 314, 14662, 5.3, 12335, 17410, 14647, 3.8, 10785, 2141, 1779, 14.9332);
                yield return new MetroHealth83("Wilmington, NC", 904, 308, 4, 890, 303, 49311, 11.2, 16785, 59720, 20329, 11.1, 37940, 6725, 2218, 30.0666);
                yield return new MetroHealth83("Oklahoma City, OK", 3267, 288, 21, 3721, 328, 140357, 4.4, 12385, 166030, 14650, 4.9, 105815, 20139, 1760, 57.1577);
                yield return new MetroHealth83("Nashville-Davidson--Murfreesboro, TN", 5089, 371, 23, 4499, 328, 162946, 6.4, 11875, 194260, 14158, 5.9, 119985, 23170, 1660, 71.3372);
                yield return new MetroHealth83("Las Cruces, NM", 318, 174, 2, 314, 172, 22166, 9.8, 12142, 25490, 13963, 8, 15535, 5936, 3190, 17.8326);
                yield return new MetroHealth83("Oakland-Fremont-Hayward, CA Metropolitan Division", 7575, 308, 19, 5351, 218, 280877, 2.4, 11424, 296135, 12044, 1.4, 190815, 72225, 2931, 87.0345);
                yield return new MetroHealth83("Wichita, KS", 1515, 260, 11, 1997, 343, 78040, 2.3, 13405, 89560, 15384, 2.9, 58535, 9095, 1556, 38.923);
                yield return new MetroHealth83("Knoxville, TN", 2293, 358, 9, 2353, 367, 101631, 5.2, 15864, 119125, 18595, 4.7, 71635, 15177, 2345, 47.8853);
            }
        }
    }
}
