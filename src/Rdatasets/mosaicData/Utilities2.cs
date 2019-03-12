// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Utility bills
    /// </summary>

    public class Utilities2
    {
        public readonly int κ;
        public readonly int month;
        public readonly int day;
        public readonly int year;
        public readonly int temp;
        public readonly int kwh;
        public readonly int ccf;
        public readonly double thermsPerDay;
        public readonly int billingDays;
        public readonly double totalbill;
        public readonly double gasbill;
        public readonly double elecbill;
        public readonly string notes;
        public readonly double ccfpday;
        public readonly double kwhpday;
        public readonly double gasbillpday;
        public readonly double elecbillpday;
        public readonly double totalbillpday;
        public readonly double therms;
        public readonly int monthsSinceY2K;

        public Utilities2(int κ, int month, int day, int year, int temp, int kwh, int ccf, double thermsPerDay, int billingDays, double totalbill, double gasbill, double elecbill, string notes, double ccfpday, double kwhpday, double gasbillpday, double elecbillpday, double totalbillpday, double therms, int monthsSinceY2K)
        {
            this.κ = κ;
            this.month = month;
            this.day = day;
            this.year = year;
            this.temp = temp;
            this.kwh = kwh;
            this.ccf = ccf;
            this.thermsPerDay = thermsPerDay;
            this.billingDays = billingDays;
            this.totalbill = totalbill;
            this.gasbill = gasbill;
            this.elecbill = elecbill;
            this.notes = notes;
            this.ccfpday = ccfpday;
            this.kwhpday = kwhpday;
            this.gasbillpday = gasbillpday;
            this.elecbillpday = elecbillpday;
            this.totalbillpday = totalbillpday;
            this.therms = therms;
            this.monthsSinceY2K = monthsSinceY2K;
        }

        public static IEnumerable<Utilities2> Data
        {
            get
            {
                yield return new Utilities2(1, 12, 29, 1999, 26, 892, 194, 5.5, 36, 173.65, 112.72, 68.25, "", 5.38888888888889, 24.7777777777778, 3.13111111111111, 1.89583333333333, 4.82361111111111, 198, 0);
                yield return new Utilities2(2, 1, 28, 2000, 18, 533, 164, 5.6, 30, 139.18, 95.88, 43.3, "", 5.46666666666667, 17.7666666666667, 3.196, 1.44333333333333, 4.63933333333333, 168, 1);
                yield return new Utilities2(3, 2, 26, 2000, 24, 521, 228, 8, 29, 177.48, 134.65, 42.83, "", 7.86206896551724, 17.9655172413793, 4.64310344827586, 1.47689655172414, 6.12, 232, 2);
                yield return new Utilities2(4, 3, 25, 2000, 41, 554, 16, 0.6, 28, 61.27, 15.32, 45.95, "bad meter reading", 0.571428571428571, 19.7857142857143, 0.547142857142857, 1.64107142857143, 2.18821428571429, 16.8, 3);
                yield return new Utilities2(5, 4, 28, 2000, 45, 638, 74, 2.2, 34, 100.33, 47.33, 53, "", 2.17647058823529, 18.7647058823529, 1.39205882352941, 1.55882352941176, 2.95088235294118, 74.8, 4);
                yield return new Utilities2(6, 5, 30, 2000, 60, 700, 129, 4.1, 32, 153.32, 89.87, 63.45, "", 4.03125, 21.875, 2.8084375, 1.9828125, 4.79125, 131.2, 5);
                yield return new Utilities2(7, 6, 24, 2000, 66, 583, 23, 0.9, 25, 85.3, 25.55, 59.75, "", 0.92, 23.32, 1.022, 2.39, 3.412, 22.5, 6);
                yield return new Utilities2(8, 7, 26, 2000, 72, 935, 0, 0, 32, 102.44, 8.08, 94.36, "", 0, 29.21875, 0.2525, 2.94875, 3.20125, 0, 7);
                yield return new Utilities2(9, 8, 24, 2000, 72, 789, 13, 0.4, 29, 96.47, 17.66, 78.81, "", 0.448275862068966, 27.2068965517241, 0.608965517241379, 2.71758620689655, 3.32655172413793, 11.6, 8);
                yield return new Utilities2(10, 9, 25, 2000, 64, 864, 17, 0.5, 32, 104.86, 21.39, 83.47, "", 0.53125, 27, 0.6684375, 2.6084375, 3.276875, 16, 9);
                yield return new Utilities2(11, 10, 24, 2000, 54, 778, 37, 1.3, 29, 107.5, 41.19, 66.31, "", 1.27586206896552, 26.8275862068966, 1.42034482758621, 2.28655172413793, 3.70689655172414, 37.7, 10);
                yield return new Utilities2(12, 11, 26, 2000, 37, 617, 123, 3.8, 33, 150.13, 102.52, 47.61, "", 3.72727272727273, 18.6969696969697, 3.10666666666667, 1.44272727272727, 4.54939393939394, 125.4, 11);
                yield return new Utilities2(13, 12, 27, 2000, 11, 586, 235, 7.7, 31, 254.23, 210.87, 46.59, "", 7.58064516129032, 18.9032258064516, 6.80225806451613, 1.50290322580645, 8.20096774193548, 238.7, 12);
                yield return new Utilities2(14, 6, 26, 2001, 70, 160, 1, 0.1, 10, 31.55, 3.42, 17.43, "transfer back from England", 0.1, 16, 0.342, 1.743, 3.155, 1, 18);
                yield return new Utilities2(15, 7, 26, 2001, 76, 736, 7, 0.2, 30, 92.36, 12.79, 79.57, "", 0.233333333333333, 24.5333333333333, 0.426333333333333, 2.65233333333333, 3.07866666666667, 6, 19);
                yield return new Utilities2(16, 8, 26, 2001, 75, 923, 15, 0.5, 31, 114.95, 18.1, 96.85, "", 0.483870967741935, 29.7741935483871, 0.583870967741935, 3.1241935483871, 3.70806451612903, 15.5, 20);
                yield return new Utilities2(17, 9, 25, 2001, 64, 865, 20, 0.7, 30, 105.91, 20.17, 85.74, "", 0.666666666666667, 28.8333333333333, 0.672333333333333, 2.858, 3.53033333333333, 21, 21);
                yield return new Utilities2(18, 10, 24, 2001, 51, 828, 44, 1.6, 29, 107.58, 32.38, 75.2, "", 1.51724137931034, 28.551724137931, 1.11655172413793, 2.59310344827586, 3.70965517241379, 46.4, 22);
                yield return new Utilities2(19, 11, 26, 2001, 48, 1046, 79, 2.4, 33, 134.5, 53.6, 80.9, "", 2.39393939393939, 31.6969696969697, 1.62424242424242, 2.45151515151515, 4.07575757575758, 79.2, 23);
                yield return new Utilities2(20, 1, 28, 2002, 23, 581, 210, 6.6, 32, 174.45, 127.86, 46.59, "", 6.5625, 18.15625, 3.995625, 1.4559375, 5.4515625, 211.2, 25);
                yield return new Utilities2(21, 2, 26, 2002, 28, 551, 178, 6.2, 29, 147.06, 102.85, 44.21, "", 6.13793103448276, 19, 3.54655172413793, 1.52448275862069, 5.07103448275862, 179.8, 26);
                yield return new Utilities2(22, 3, 27, 2002, 21, 471, 190, 6.6, 29, 152.32, 113.63, 38.69, "", 6.55172413793103, 16.2413793103448, 3.91827586206897, 1.33413793103448, 5.25241379310345, 191.4, 27);
                yield return new Utilities2(23, 4, 28, 2002, 45, 449, 106, 3.3, 32, 106.04, 70.34, 35.7, "", 3.3125, 14.03125, 2.198125, 1.115625, 3.31375, 105.6, 28);
                yield return new Utilities2(24, 5, 28, 2002, 51, 394, 60, 2, 30, 87.47, 48.92, 38.55, "", 2, 13.1333333333333, 1.63066666666667, 1.285, 2.91566666666667, 60, 29);
                yield return new Utilities2(25, 6, 26, 2002, 69, 496, 23, 0.8, 29, 76.43, 23.42, 53.01, "", 0.793103448275862, 17.1034482758621, 0.807586206896552, 1.82793103448276, 2.63551724137931, 23.2, 30);
                yield return new Utilities2(26, 7, 28, 2002, 76, 925, 16, 0.5, 32, 111.65, 18.61, 93.04, "", 0.5, 28.90625, 0.5815625, 2.9075, 3.4890625, 16, 31);
                yield return new Utilities2(27, 8, 26, 2002, 72, 812, 15, 0.5, 29, 101.39, 17.56, 83.83, "", 0.517241379310345, 28, 0.60551724137931, 2.89068965517241, 3.49620689655172, 14.5, 32);
                yield return new Utilities2(28, 9, 25, 2002, 69, 838, 16, 0.5, 30, 99.46, 18.16, 82.2, "", 0.533333333333333, 27.9333333333333, 0.605333333333333, 2.74, 3.31533333333333, 15, 33);
                yield return new Utilities2(29, 10, 24, 2002, 47, 790, 69, 2.4, 29, 122.51, 55.74, 66.77, "", 2.37931034482759, 27.2413793103448, 1.92206896551724, 2.30241379310345, 4.22448275862069, 69.6, 34);
                yield return new Utilities2(30, 11, 24, 2002, 34, 865, 126, 4.1, 31, 154.93, 94.67, 65.02, "", 4.06451612903226, 27.9032258064516, 3.05387096774194, 2.09741935483871, 4.99774193548387, 127.1, 35);
                yield return new Utilities2(31, 12, 29, 2002, 25, 1032, 190, 5.5, 35, 217.42, 140.49, 76.93, "", 5.42857142857143, 29.4857142857143, 4.014, 2.198, 6.212, 192.5, 36);
                yield return new Utilities2(32, 2, 26, 2003, 17, 580, 224, 7.8, 29, 232.41, 187.05, 45.36, "", 7.72413793103448, 20, 6.45, 1.56413793103448, 8.01413793103448, 226.2, 38);
                yield return new Utilities2(33, 3, 27, 2003, 29, 648, 153, 5.3, 29, 226.92, 176.02, 50.9, "", 5.27586206896552, 22.3448275862069, 6.06965517241379, 1.7551724137931, 7.8248275862069, 153.7, 39);
                yield return new Utilities2(34, 4, 28, 2003, 46, 503, 100, 3.2, 32, 127.07, 86.83, 40.24, "", 3.125, 15.71875, 2.7134375, 1.2575, 3.9709375, 102.4, 40);
                yield return new Utilities2(35, 5, 28, 2003, 56, 496, 43, 1.4, 30, 92.86, 43.77, 49.09, "", 1.43333333333333, 16.5333333333333, 1.459, 1.63633333333333, 3.09533333333333, 42, 41);
                yield return new Utilities2(36, 6, 26, 2003, 67, 722, 18, 0.6, 29, 99.52, 24.46, 75.06, "", 0.620689655172414, 24.8965517241379, 0.843448275862069, 2.58827586206897, 3.43172413793103, 17.4, 42);
                yield return new Utilities2(37, 7, 28, 2003, 72, 934, 15, 0.5, 32, 116.29, 21.28, 95.01, "", 0.46875, 29.1875, 0.665, 2.9690625, 3.6340625, 16, 43);
                yield return new Utilities2(38, 8, 26, 2003, 75, 869, 14, 0.5, 29, 108.04, 19.56, 89.12, "", 0.482758620689655, 29.9655172413793, 0.67448275862069, 3.07310344827586, 3.72551724137931, 14.5, 44);
                yield return new Utilities2(39, 9, 25, 2003, 69, 888, 16, 0.5, 30, 108.54, 21.08, 87.46, "", 0.533333333333333, 29.6, 0.702666666666667, 2.91533333333333, 3.618, 15, 45);
                yield return new Utilities2(40, 10, 26, 2003, 53, 927, 48, 1.5, 31, 127.37, 45.28, 82.09, "", 1.54838709677419, 29.9032258064516, 1.46064516129032, 2.64806451612903, 4.10870967741935, 46.5, 46);
                yield return new Utilities2(41, 11, 24, 2003, 35, 570, 130, 4.6, 29, 151.62, 106.61, 45.01, "", 4.48275862068965, 19.6551724137931, 3.67620689655172, 1.55206896551724, 5.22827586206897, 133.4, 47);
                yield return new Utilities2(42, 12, 29, 2003, 25, 725, 204, 5.9, 35, 225.73, 168.93, 56.8, "", 5.82857142857143, 20.7142857142857, 4.82657142857143, 1.62285714285714, 6.44942857142857, 206.5, 48);
                yield return new Utilities2(43, 1, 28, 2004, 15, 594, 242, 8.1, 30, 262.81, 216.89, 47.37, "", 8.06666666666667, 19.8, 7.22966666666667, 1.579, 8.76033333333333, 243, 49);
                yield return new Utilities2(44, 2, 26, 2004, 16, 563, 216, 7.6, 29, 239.6, 193.45, 46.15, "", 7.44827586206897, 19.4137931034483, 6.67068965517241, 1.59137931034483, 8.26206896551724, 220.4, 50);
                yield return new Utilities2(45, 3, 28, 2004, 35, 510, 144, 4.7, 31, 166.51, 124.18, 42.33, "", 4.64516129032258, 16.4516129032258, 4.0058064516129, 1.36548387096774, 5.37129032258064, 145.7, 51);
                yield return new Utilities2(46, 4, 27, 2004, 48, 709, 78, 2.6, 30, 120.08, 65.67, 54.41, "", 2.6, 23.6333333333333, 2.189, 1.81366666666667, 4.00266666666667, 78, 52);
                yield return new Utilities2(47, 5, 26, 2004, 58, 742, 35, 1.2, 29, 109.38, 39.4, 69.98, "", 1.20689655172414, 25.5862068965517, 1.35862068965517, 2.41310344827586, 3.77172413793103, 34.8, 53);
                yield return new Utilities2(48, 6, 27, 2004, 64, 911, 18, 0.6, 32, 119.65, 25.14, 94.51, "", 0.5625, 28.46875, 0.785625, 2.9534375, 3.7390625, 19.2, 54);
                yield return new Utilities2(49, 7, 27, 2004, 72, 860, 8, 0.3, 30, 106.65, 15.59, 91.06, "", 0.266666666666667, 28.6666666666667, 0.519666666666667, 3.03533333333333, 3.555, 9, 55);
                yield return new Utilities2(50, 8, 25, 2004, 67, 841, 15, 0.5, 29, 111.08, 21.72, 89.36, "", 0.517241379310345, 29, 0.748965517241379, 3.08137931034483, 3.83034482758621, 14.5, 56);
                yield return new Utilities2(51, 9, 26, 2004, 71, 922, 15, 0.5, 32, 117.46, 21.25, 96.21, "", 0.46875, 28.8125, 0.6640625, 3.0065625, 3.670625, 16, 57);
                yield return new Utilities2(52, 11, 23, 2004, 43, 860, 82, 2.8, 29, 160.26, 88.51, 71.75, "", 2.82758620689655, 29.6551724137931, 3.05206896551724, 2.47413793103448, 5.52620689655172, 81.2, 59);
                yield return new Utilities2(53, 12, 28, 2004, 23, 1160, 208, 6, 35, 317.47, 224.18, 93.29, "", 5.94285714285714, 33.1428571428571, 6.40514285714286, 2.66542857142857, 9.07057142857143, 210, 60);
                yield return new Utilities2(54, 1, 27, 2005, 15, 891, 224, 7.5, 30, 294.96, 223.92, 71.04, "", 7.46666666666667, 29.7, 7.464, 2.368, 9.832, 225, 61);
                yield return new Utilities2(55, 2, 24, 2005, 29, 557, 166, 6, 28, 213.71, 166.63, 47.08, "", 5.92857142857143, 19.8928571428571, 5.95107142857143, 1.68142857142857, 7.6325, 168, 62);
                yield return new Utilities2(56, 3, 29, 2005, 31, 772, 179, 5.5, 33, 239.85, 117.05, 62.8, "", 5.42424242424242, 23.3939393939394, 3.5469696969697, 1.9030303030303, 7.26818181818182, 181.5, 63);
                yield return new Utilities2(57, 4, 28, 2005, 54, 444, 61, 2, 30, 103.34, 64.99, 38.35, "", 2.03333333333333, 14.8, 2.16633333333333, 1.27833333333333, 3.44466666666667, 60, 64);
                yield return new Utilities2(58, 5, 26, 2005, 56, 645, 51, 1.8, 28, 127.22, 61.81, 65.41, "", 1.82142857142857, 23.0357142857143, 2.2075, 2.33607142857143, 4.54357142857143, 50.4, 65);
                yield return new Utilities2(59, 6, 27, 2005, 72, 939, 19, 0.6, 32, 131.02, 27.3, 103.72, "", 0.59375, 29.34375, 0.853125, 3.24125, 4.094375, 19.2, 66);
                yield return new Utilities2(60, 7, 27, 2005, 78, 862, 11, 0.4, 30, 116.72, 19.96, 96.76, "high efficiency gas furnace and gas water heater installed", 0.366666666666667, 28.7333333333333, 0.665333333333333, 3.22533333333333, 3.89066666666667, 12, 67);
                yield return new Utilities2(61, 8, 25, 2005, 74, 845, 9, 0.3, 29, 120.53, 18.16, 102.37, "", 0.310344827586207, 29.1379310344828, 0.626206896551724, 3.53, 4.15620689655172, 8.7, 68);
                yield return new Utilities2(62, 9, 26, 2005, 69, 995, 11, 0.3, 32, 135.07, 22.33, 112.74, "", 0.34375, 31.09375, 0.6978125, 3.523125, 4.2209375, 9.6, 69);
                yield return new Utilities2(63, 10, 25, 2005, 56, 965, 32, 1.1, 29, 150.62, 55.74, 94.88, "", 1.10344827586207, 33.2758620689655, 1.92206896551724, 3.27172413793103, 5.19379310344828, 31.9, 70);
                yield return new Utilities2(64, 11, 27, 2005, 41, 926, 99, 3.1, 33, 212.49, 153.24, 84.75, "", 3, 28.0606060606061, 4.64363636363636, 2.56818181818182, 6.43909090909091, 102.3, 71);
                yield return new Utilities2(65, 12, 28, 2005, 21, 931, 176, 5.8, 31, 324.52, 240.9, 83.62, "", 5.67741935483871, 30.0322580645161, 7.77096774193548, 2.69741935483871, 10.4683870967742, 179.8, 72);
                yield return new Utilities2(66, 1, 29, 2006, 30, 927, 144, 4.5, 32, 282.25, 193.84, 90.28, "", 4.5, 28.96875, 6.0575, 2.82125, 8.8203125, 144, 73);
                yield return new Utilities2(67, 2, 27, 2006, 22, 876, 161, 5.6, 29, 289.91, 198.11, 91.8, "", 5.55172413793103, 30.2068965517241, 6.83137931034483, 3.16551724137931, 9.99689655172414, 162.4, 74);
                yield return new Utilities2(68, 3, 28, 2006, 34, 749, 116, 4, 29, 210.85, 138.65, 72.2, "", 4, 25.8275862068966, 4.78103448275862, 2.48965517241379, 7.27068965517241, 116, 75);
                yield return new Utilities2(69, 4, 26, 2006, 53, 428, 52, 1.8, 29, 96.87, 55, 41.87, "", 1.79310344827586, 14.7586206896552, 1.89655172413793, 1.44379310344828, 3.34034482758621, 52.2, 76);
                yield return new Utilities2(70, 5, 25, 2006, 59, 450, 38, 1.3, 29, 95.04, 47.39, 47.65, "", 1.31034482758621, 15.5172413793103, 1.63413793103448, 1.64310344827586, 3.27724137931034, 37.7, 77);
                yield return new Utilities2(71, 6, 26, 2006, 74, 694, 10, 0.3, 32, 98.48, 19.19, 79.32, "away for 10 days on vacation", 0.3125, 21.6875, 0.5996875, 2.47875, 3.0775, 9.6, 78);
                yield return new Utilities2(72, 7, 26, 2006, 78, 954, 7, 0.2, 30, 131.27, 16.37, 114.9, "", 0.233333333333333, 31.8, 0.545666666666667, 3.83, 4.37566666666667, 6, 79);
                yield return new Utilities2(73, 8, 24, 2006, 77, 957, 6, 0.2, 29, 134.96, 15.88, 119.3, "", 0.206896551724138, 33, 0.547586206896552, 4.11379310344828, 4.65379310344828, 5.8, 80);
                yield return new Utilities2(74, 9, 25, 2006, 64, 1027, 15, 0.5, 32, 156.51, 25.74, 130.77, "", 0.46875, 32.09375, 0.804375, 4.0865625, 4.8909375, 16, 81);
                yield return new Utilities2(75, 10, 24, 2006, 50, 893, 47, 1.6, 29, 144.16, 46.12, 98.04, "", 1.62068965517241, 30.7931034482759, 1.59034482758621, 3.38068965517241, 4.97103448275862, 46.4, 82);
                yield return new Utilities2(76, 11, 26, 2006, 41, 663, 101, 3.1, 33, 168.24, 106.54, 62.72, "", 3.06060606060606, 20.0909090909091, 3.22848484848485, 1.90060606060606, 5.09818181818182, 102.3, 83);
                yield return new Utilities2(77, 12, 27, 2006, 30, 720, 140, 4.5, 31, 229.4, 159.08, 70.32, "", 4.51612903225806, 23.2258064516129, 5.13161290322581, 2.26838709677419, 7.4, 139.5, 84);
                yield return new Utilities2(78, 1, 28, 2007, 24, 897, 168, 5.3, 32, 267.72, 178.16, 89.97, "", 5.25, 28.03125, 5.5675, 2.8115625, 8.36625, 169.6, 85);
                yield return new Utilities2(79, 2, 26, 2007, 13, 808, 191, 6.7, 29, 298.5, 207.53, 90.97, "", 6.58620689655172, 27.8620689655172, 7.15620689655172, 3.13689655172414, 10.2931034482759, 194.3, 86);
                yield return new Utilities2(80, 3, 26, 2007, 38, 724, 101, 3.6, 29, 192.67, 118.78, 73.89, "", 3.48275862068966, 24.9655172413793, 4.09586206896552, 2.54793103448276, 6.64379310344828, 104.4, 87);
                yield return new Utilities2(81, 4, 26, 2007, 46, 707, 77, 2.6, 30, 159.01, 82.76, 76.25, "", 2.56666666666667, 23.5666666666667, 2.75866666666667, 2.54166666666667, 5.30033333333333, 78, 88);
                yield return new Utilities2(82, 5, 28, 2007, 65, 442, 18, 0.6, 32, 86.54, 32.98, 53.56, "", 0.5625, 13.8125, 1.030625, 1.67375, 2.704375, 19.2, 89);
                yield return new Utilities2(83, 6, 26, 2007, 74, 305, 7, 0.2, 29, 67.19, 21.41, 45.78, "", 0.241379310344828, 10.5172413793103, 0.738275862068966, 1.57862068965517, 2.31689655172414, 5.8, 90);
                yield return new Utilities2(84, 7, 27, 2007, 76, 839, 9, 0.3, 30, 135.73, 22.87, 112.99, "", 0.3, 27.9666666666667, 0.762333333333333, 3.76633333333333, 4.52433333333333, 9, 91);
                yield return new Utilities2(85, 8, 26, 2007, 75, 809, 6, 0.2, 31, 123.07, 19.17, 103.9, "", 0.193548387096774, 26.0967741935484, 0.618387096774194, 3.35161290322581, 3.97, 6.2, 92);
                yield return new Utilities2(86, 9, 25, 2007, 68, 812, 13, 0.4, 30, 117.82, 24.54, 98.9, "5.46 credit for \"cost of gas\"", 0.433333333333333, 27.0666666666667, 0.818, 3.29666666666667, 3.92733333333333, 12, 93);
                yield return new Utilities2(87, 10, 24, 2007, 58, 761, 28, 1, 29, 123.4, 38.59, 85.81, "", 0.96551724137931, 26.2413793103448, 1.33068965517241, 2.95896551724138, 4.2551724137931, 29, 94);
                yield return new Utilities2(88, 11, 26, 2007, 41, 767, 98, 3, 33, 181.53, 104.52, 77.01, "", 2.96969696969697, 23.2424242424242, 3.16727272727273, 2.33363636363636, 5.50090909090909, 99, 95);
                yield return new Utilities2(89, 12, 27, 2007, 18, 980, 182, 6, 31, 296.1, 194.91, 101.19, "", 5.87096774193548, 31.6129032258065, 6.28741935483871, 3.2641935483871, 9.55161290322581, 186, 96);
                yield return new Utilities2(90, 2, 26, 2008, 15, 804, 191, 6.7, 29, 292.12, 207.32, 84.8, "housesitters", 6.58620689655172, 27.7241379310345, 7.14896551724138, 2.92413793103448, 10.0731034482759, 194.3, 98);
                yield return new Utilities2(91, 3, 27, 2008, 28, 752, 139, 4.7, 30, 245.27, 167.3, 77.97, "housesitters", 4.63333333333333, 25.0666666666667, 5.57666666666667, 2.599, 8.17566666666667, 141, 99);
                yield return new Utilities2(92, 4, 27, 2008, 45, 623, 79, 2.6, 31, 160.69, 97.11, 63.58, "housesitters", 2.54838709677419, 20.0967741935484, 3.13258064516129, 2.05096774193548, 5.18354838709677, 80.6, 100);
                yield return new Utilities2(93, 5, 27, 2008, 55, 410, 29, 1, 30, 105.5, 52.15, 53.35, "housesitters", 0.966666666666667, 13.6666666666667, 1.73833333333333, 1.77833333333333, 3.51666666666667, 30, 101);
                yield return new Utilities2(94, 6, 25, 2008, 68, 196, 6, 0.2, 29, 53.92, 20.97, 32.95, "empty house", 0.206896551724138, 6.75862068965517, 0.723103448275862, 1.13620689655172, 1.85931034482759, 5.8, 102);
                yield return new Utilities2(95, 7, 27, 2008, 76, 477, 11, 0.3, 32, 99.14, 69.82, 29.32, "empty house", 0.34375, 14.90625, 2.181875, 0.91625, 3.098125, 9.6, 103);
                yield return new Utilities2(96, 8, 25, 2008, 75, 544, 12, 0.4, 29, 103.28, 26.83, 76.45, "", 0.413793103448276, 18.7586206896552, 0.925172413793103, 2.63620689655172, 3.56137931034483, 11.6, 104);
                yield return new Utilities2(97, 9, 25, 2008, 67, 746, 16, 0.5, 31, 124.82, 29.77, 95.05, "", 0.516129032258065, 24.0645161290323, 0.960322580645161, 3.06612903225806, 4.02645161290323, 15.5, 105);
                yield return new Utilities2(98, 10, 26, 2008, 55, 801, 32, 1.1, 31, 134.3, 41.74, 92.56, "", 1.03225806451613, 25.8387096774194, 1.34645161290323, 2.9858064516129, 4.33225806451613, 34.1, 106);
                yield return new Utilities2(99, 11, 24, 2008, 39, 868, 91, 3, 29, 186.18, 93.6, 92.58, "", 3.13793103448276, 29.9310344827586, 3.22758620689655, 3.19241379310345, 6.42, 87, 107);
                yield return new Utilities2(100, 12, 29, 2008, 18, 1205, 199, 5.8, 35, 332.09, 209.21, 122.88, "", 5.68571428571429, 34.4285714285714, 5.97742857142857, 3.51085714285714, 9.48828571428571, 203, 108);
                yield return new Utilities2(101, 1, 28, 2009, 9, 986, 211, 7.2, 30, 330.27, 225.72, 104.55, "", 7.03333333333333, 32.8666666666667, 7.524, 3.485, 11.009, 216, 109);
                yield return new Utilities2(102, 2, 26, 2009, 23, 870, 159, 5.6, 29, 242.12, 147.82, 94.3, "", 5.48275862068965, 30, 5.09724137931034, 3.25172413793103, 8.34896551724138, 162.4, 110);
                yield return new Utilities2(103, 3, 29, 2009, 32, 830, 134, 4.4, 31, 207.96, 114.66, 93.3, "", 4.32258064516129, 26.7741935483871, 3.69870967741935, 3.00967741935484, 6.70838709677419, 136.4, 111);
                yield return new Utilities2(104, 4, 28, 2009, 47, 497, 74, 2.5, 30, 113.5, 58.03, 55.47, "", 2.46666666666667, 16.5666666666667, 1.93433333333333, 1.849, 3.78333333333333, 75, 112);
                yield return new Utilities2(105, 5, 28, 2009, 61, 436, 34, 1.2, 30, 93.09, 37.33, 55.76, "", 1.13333333333333, 14.5333333333333, 1.24433333333333, 1.85866666666667, 3.103, 36, 113);
                yield return new Utilities2(106, 6, 28, 2009, 69, 579, 19, 0.6, 31, 103.7, 24.88, 78.82, "", 0.612903225806452, 18.6774193548387, 0.80258064516129, 2.54258064516129, 3.34516129032258, 18.6, 114);
                yield return new Utilities2(107, 7, 28, 2009, 71, 734, 15, 0.5, 30, 122.7, 22.86, 99.84, "", 0.5, 24.4666666666667, 0.762, 3.328, 4.09, 15, 115);
                yield return new Utilities2(108, 8, 28, 2009, 72, 774, 10, 0.3, 29, 125.37, 19.43, 105.94, "Was this August?", 0.344827586206897, 26.6896551724138, 0.67, 3.65310344827586, 4.32310344827586, 8.7, 116);
                yield return new Utilities2(109, 9, 27, 2009, 69, 909, 18, 0.6, 32, 142.82, 23.72, 119.1, "", 0.5625, 28.40625, 0.74125, 3.721875, 4.463125, 19.2, 117);
                yield return new Utilities2(110, 10, 26, 2009, 45, 842, 62, 2.2, 29, 158.02, 58.38, 102.52, "", 2.13793103448276, 29.0344827586207, 2.01310344827586, 3.5351724137931, 5.44896551724138, 63.8, 118);
                yield return new Utilities2(111, 11, 24, 2009, 46, 826, 67, 2.3, 29, 153.68, 61.46, 92.22, "", 2.31034482758621, 28.4827586206897, 2.11931034482759, 3.18, 5.29931034482759, 66.7, 119);
                yield return new Utilities2(112, 12, 30, 2009, 22, 1213, 188, 5.4, 36, 283.69, 131.49, 152.2, "estimated reading", 5.22222222222222, 33.6944444444444, 3.6525, 4.22777777777778, 7.88027777777778, 194.4, 120);
                yield return new Utilities2(113, 1, 28, 2010, 15, 992, 206, 6.9, 29, 291.1, 180.73, 110.37, "", 7.10344827586207, 34.2068965517241, 6.23206896551724, 3.80586206896552, 10.0379310344828, 200.1, 121);
                yield return new Utilities2(114, 2, 28, 2010, 20, 1024, 187, 6.1, 31, 268.07, 163.62, 114.02, "9.57 escrow refund", 6.03225806451613, 33.0322580645161, 5.27806451612903, 3.67806451612903, 8.64741935483871, 189.1, 122);
                yield return new Utilities2(115, 3, 29, 2010, 41, 923, 95, 3.3, 29, 181.82, 79.15, 102.67, "", 3.27586206896552, 31.8275862068966, 2.72931034482759, 3.54034482758621, 6.26965517241379, 95.7, 123);
                yield return new Utilities2(116, 4, 27, 2010, 56, 814, 31, 1.1, 29, 100.61, 29.44, 95.22, "24.05 interim elec refund", 1.06896551724138, 28.0689655172414, 1.0151724137931, 3.28344827586207, 3.46931034482759, 31.9, 124);
                yield return new Utilities2(117, 5, 36, 2010, 60, 941, 31, 1.1, 29, 151.57, 38.29, 113.18, "", 1.06896551724138, 32.448275862069, 1.32034482758621, 3.90275862068966, 5.22655172413793, 31.9, 125);
            }
        }
    }
}
