// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// National Statistics from the United Nations, Mostly From 2009-2011
    /// </summary>

    public class UN
    {
        public readonly string κ;
        public readonly string region;
        public readonly string group;
        public readonly double? fertility;
        public readonly double? ppgdp;
        public readonly double? lifeExpF;
        public readonly int? pctUrban;
        public readonly double? infantMortality;

        public UN(string κ, string region, string group, double? fertility, double? ppgdp, double? lifeExpF, int? pctUrban, double? infantMortality)
        {
            this.κ = κ;
            this.region = region;
            this.group = group;
            this.fertility = fertility;
            this.ppgdp = ppgdp;
            this.lifeExpF = lifeExpF;
            this.pctUrban = pctUrban;
            this.infantMortality = infantMortality;
        }

        public static IEnumerable<UN> Data
        {
            get
            {
                yield return new UN("Afghanistan", "Asia", "other", 5.968, 499, 49.49, 23, 124.535);
                yield return new UN("Albania", "Europe", "other", 1.525, 3677.2, 80.4, 53, 16.561);
                yield return new UN("Algeria", "Africa", "africa", 2.142, 4473, 75, 67, 21.458);
                yield return new UN("American Samoa", null, null, null, null, null, null, 11.2938865700958);
                yield return new UN("Angola", "Africa", "africa", 5.135, 4321.9, 53.17, 59, 96.191);
                yield return new UN("Anguilla", "Caribbean", "other", 2, 13750.1, 81.1, 100, null);
                yield return new UN("Argentina", "Latin Amer", "other", 2.172, 9162.1, 79.89, 93, 12.337);
                yield return new UN("Armenia", "Asia", "other", 1.735, 3030.7, 77.33, 64, 24.272);
                yield return new UN("Aruba", "Caribbean", "other", 1.671, 22851.5, 77.75, 47, 14.687);
                yield return new UN("Australia", "Oceania", "oecd", 1.949, 57118.9, 84.27, 89, 4.455);
                yield return new UN("Austria", "Europe", "oecd", 1.346, 45158.8, 83.55, 68, 3.713);
                yield return new UN("Azerbaijan", "Asia", "other", 2.148, 5637.6, 73.66, 52, 37.566);
                yield return new UN("Bahamas", "Caribbean", "other", 1.877, 22461.6, 78.85, 84, 14.135);
                yield return new UN("Bahrain", "Asia", "other", 2.43, 18184.1, 76.06, 89, 6.663);
                yield return new UN("Bangladesh", "Asia", "other", 2.157, 670.4, 70.23, 29, 41.786);
                yield return new UN("Barbados", "Caribbean", "other", 1.575, 14497.3, 80.26, 45, 12.284);
                yield return new UN("Belarus", "Europe", "other", 1.479, 5702, 76.37, 75, 6.494);
                yield return new UN("Belgium", "Europe", "oecd", 1.835, 43814.8, 82.81, 97, 3.739);
                yield return new UN("Belize", "Latin Amer", "other", 2.679, 4495.8, 77.81, 53, 16.2);
                yield return new UN("Benin", "Africa", "africa", 5.078, 741.1, 58.66, 42, 76.674);
                yield return new UN("Bermuda", "Caribbean", "other", 1.76, 92624.7, 82.3, 100, null);
                yield return new UN("Bhutan", "Asia", "other", 2.258, 2047.2, 69.84, 35, 37.995);
                yield return new UN("Bolivia", "Latin Amer", "other", 3.229, 1977.9, 69.4, 67, 40.684);
                yield return new UN("Bosnia and Herzegovina", "Europe", "other", 1.134, 4477.7, 78.4, 49, 12.695);
                yield return new UN("Botswana", "Africa", "africa", 2.617, 7402.9, 51.34, 62, 35.117);
                yield return new UN("Brazil", "Latin Amer", "other", 1.8, 10715.6, 77.41, 87, 19.016);
                yield return new UN("Brunei Darussalam", "Asia", "other", 1.984, 32647.6, 80.64, 76, 4.529);
                yield return new UN("Bulgaria", "Europe", "other", 1.546, 6365.1, 77.12, 72, 9.149);
                yield return new UN("Burkina Faso", "Africa", "africa", 5.75, 519.7, 57.02, 27, 70.958);
                yield return new UN("Burundi", "Africa", "africa", 4.051, 176.6, 52.58, 11, 94.083);
                yield return new UN("Cambodia", "Asia", "other", 2.422, 797.2, 65.1, 20, 52.835);
                yield return new UN("Cameroon", "Africa", "africa", 4.287, 1206.6, 53.56, 59, 84.915);
                yield return new UN("Canada", "North America", "oecd", 1.691, 46360.9, 83.49, 81, 4.926);
                yield return new UN("Cape Verde", "Africa", "africa", 2.279, 3244, 77.7, 62, 18.458);
                yield return new UN("Cayman Islands", "Caribbean", "other", 1.6, 57047.9, 83.8, 100, null);
                yield return new UN("Central African Republic", "Africa", "africa", 4.423, 450.8, 51.3, 39, 95.781);
                yield return new UN("Chad", "Africa", "africa", 5.737, 727.4, 51.61, 28, 123.94);
                yield return new UN("Channel Islands", null, null, null, null, null, null, 8.169);
                yield return new UN("Chile", "Latin Amer", "oecd", 1.832, 11887.7, 82.35, 89, 6.792);
                yield return new UN("China", "Asia", "other", 1.559, 4354, 75.61, 48, 19.637);
                yield return new UN("Colombia", "Latin Amer", "other", 2.293, 6222.8, 77.69, 75, 16.671);
                yield return new UN("Comoros", "Africa", "africa", 4.742, 736.6, 63.18, 28, 62.83);
                yield return new UN("Congo", "Africa", "africa", 4.442, 2665.1, 59.33, 63, 66.738);
                yield return new UN("Cook Islands", "Oceania", "other", 2.53080628409411, 12212.1, 76.2454672361809, 76, 11.5517876766323);
                yield return new UN("Costa Rica", "Latin Amer", "other", 1.812, 7703.8, 81.99, 65, 9.172);
                yield return new UN("Cote dIvoire", "Africa", "africa", 4.224, 1154.1, 57.71, 51, 68.845);
                yield return new UN("Croatia", "Europe", "other", 1.501, 13819.5, 80.37, 58, 5.571);
                yield return new UN("Cuba", "Caribbean", "other", 1.451, 5704.4, 81.33, 75, 4.959);
                yield return new UN("Cyprus", "Asia", "other", 1.458, 28364.3, 82.14, 71, 4.434);
                yield return new UN("Czech Republic", "Europe", "oecd", 1.501, 18838.8, 81, 74, 2.997);
                yield return new UN("Democratic Republic of the Congo", "Africa", "africa", 5.485, 200.6, 50.56, 36, 109.477);
                yield return new UN("Denmark", "Europe", "oecd", 1.885, 55830.2, 81.37, 87, 3.914);
                yield return new UN("Djibouti", "Africa", "africa", 3.589, 1282.6, 60.04, 76, 74.95);
                yield return new UN("Dominica", "Caribbean", "other", 3, 7020.8, 78.2, 67, null);
                yield return new UN("Dominican Republic", "Caribbean", "other", 2.49, 5195.4, 76.57, 70, 21.589);
                yield return new UN("Timor Leste", "Asia", "other", 5.918, 706.1, 64.2, 29, 56.499);
                yield return new UN("Ecuador", "Latin Amer", "other", 2.393, 4072.6, 78.91, 68, 19.07);
                yield return new UN("Egypt", "Africa", "africa", 2.636, 2653.7, 75.52, 44, 22.029);
                yield return new UN("El Salvador", "Latin Amer", "other", 2.171, 3425.6, 77.09, 65, 19.007);
                yield return new UN("Equatorial Guinea", "Africa", "africa", 4.98, 16852.4, 52.91, 40, 93.315);
                yield return new UN("Eritrea", "Africa", "africa", 4.243, 429.1, 64.41, 22, 47.508);
                yield return new UN("Estonia", "Europe", "oecd", 1.702, 14135.4, 79.95, 70, 4.382);
                yield return new UN("Ethiopia", "Africa", "africa", 3.848, 324.6, 61.59, 17, 62.902);
                yield return new UN("Fiji", "Oceania", "other", 2.602, 3545.7, 72.27, 52, 17.216);
                yield return new UN("Finland", "Europe", "oecd", 1.875, 44501.7, 83.28, 85, 2.783);
                yield return new UN("France", "Europe", "oecd", 1.987, 39545.9, 84.9, 86, 3.345);
                yield return new UN("French Guiana", null, null, null, null, null, null, 12.714);
                yield return new UN("French Polynesia", "Oceania", "other", 2.033, 24669, 78.07, 51, 7.159);
                yield return new UN("Gabon", "Africa", "africa", 3.195, 12468.8, 64.32, 86, 43.77);
                yield return new UN("Gambia", "Africa", "africa", 4.689, 579.1, 60.3, 59, 66.374);
                yield return new UN("Georgia", "Asia", "other", 1.528, 2680.3, 77.31, 53, 25.585);
                yield return new UN("Germany", "Europe", "oecd", 1.457, 39857.1, 82.99, 74, 3.487);
                yield return new UN("Ghana", "Africa", "africa", 3.988, 1333.2, 65.8, 52, 43.867);
                yield return new UN("Greece", "Europe", "oecd", 1.54, 26503.8, 82.58, 62, 4.488);
                yield return new UN("Greenland", "NorthAtlantic", "other", 2.217, 35292.7, 71.6, 84, null);
                yield return new UN("Grenada", "Caribbean", "other", 2.171, 7429, 77.72, 40, 13.042);
                yield return new UN("Guadeloupe", null, null, null, null, null, null, 6.725);
                yield return new UN("Guam", null, null, null, null, null, null, 8.07);
                yield return new UN("Guatemala", "Latin Amer", "other", 3.84, 2882.3, 75.1, 50, 26.269);
                yield return new UN("Guinea", "Africa", "africa", 5.032, 427.5, 56.39, 36, 84.176);
                yield return new UN("Guinea-Bissau", "Africa", "africa", 4.877, 539.4, 50.4, 30, 109.818);
                yield return new UN("Guyana", "Latin Amer", "other", 2.19, 2996, 73.45, 29, 36.83);
                yield return new UN("Haiti", "Caribbean", "other", 3.159, 612.7, 63.87, 54, 58.26);
                yield return new UN("Honduras", "Latin Amer", "other", 2.996, 2026.2, 75.92, 52, 23.515);
                yield return new UN("Hong Kong", "Asia", "other", 1.137, 31823.7, 86.35, 100, 2.026);
                yield return new UN("Hungary", "Europe", "oecd", 1.43, 12884, 78.47, 68, 5.304);
                yield return new UN("Iceland", "Europe", "other", 2.098, 39278, 83.77, 94, 2.057);
                yield return new UN("India", "Asia", "other", 2.538, 1406.4, 67.62, 30, 47.894);
                yield return new UN("Indonesia", "Asia", "other", 2.055, 2949.3, 71.8, 45, 24.929);
                yield return new UN("Iran", "Asia", "other", 1.587, 5227.1, 75.28, 71, 23.385);
                yield return new UN("Iraq", "Asia", "other", 4.535, 888.5, 72.6, 66, 33.293);
                yield return new UN("Ireland", "Europe", "oecd", 2.097, 46220.3, 83.17, 62, 3.859);
                yield return new UN("Israel", "Asia", "oecd", 2.909, 29311.6, 84.19, 92, 3.347);
                yield return new UN("Italy", "Europe", "oecd", 1.476, 33877.1, 84.62, 69, 3.417);
                yield return new UN("Jamaica", "Caribbean", "other", 2.262, 4899, 75.98, 52, 22.023);
                yield return new UN("Japan", "Asia", "oecd", 1.418, 43140.9, 87.12, 67, 2.549);
                yield return new UN("Jordan", "Asia", "other", 2.889, 4445.3, 75.17, 79, 19.14);
                yield return new UN("Kazakhstan", "Asia", "other", 2.481, 9166.7, 72.84, 59, 23.716);
                yield return new UN("Kenya", "Africa", "africa", 4.623, 801.8, 59.16, 23, 58.142);
                yield return new UN("Kiribati", "Oceania", "other", 3.5, 1468.2, 63.1, 44, 52);
                yield return new UN("Kuwait", "Asia", "other", 2.251, 45430.4, 75.89, 98, 7.563);
                yield return new UN("Kyrgyzstan", "Asia", "other", 2.621, 865.4, 72.36, 35, 32.765);
                yield return new UN("Laos", "Asia", "other", 2.543, 1047.6, 69.42, 34, 36.809);
                yield return new UN("Latvia", "Europe", "other", 1.506, 10663, 78.51, 68, 6.7);
                yield return new UN("Lebanon", "Asia", "other", 1.764, 9283.7, 75.07, 87, 20.223);
                yield return new UN("Lesotho", "Africa", "africa", 3.051, 980.7, 48.11, 28, 62.103);
                yield return new UN("Liberia", "Africa", "africa", 5.038, 218.6, 58.59, 48, 76.853);
                yield return new UN("Libya", "Africa", "africa", 2.41, 11320.8, 77.86, 78, 13.248);
                yield return new UN("Lithuania", "Europe", "other", 1.495, 10975.5, 78.28, 67, 5.941);
                yield return new UN("Luxembourg", "Europe", "oecd", 1.683, 105095.4, 82.67, 85, 2.289);
                yield return new UN("Macao", "Asia", "other", 1.163, 49990.2, 83.8, 100, 4.13);
                yield return new UN("Madagascar", "Africa", "africa", 4.493, 421.9, 68.61, 31, 41.03);
                yield return new UN("Malawi", "Africa", "africa", 5.968, 357.4, 55.17, 20, 86.06);
                yield return new UN("Malaysia", "Asia", "other", 2.572, 8372.8, 76.86, 73, 6.88);
                yield return new UN("Maldives", "Asia", "other", 1.668, 4684.5, 78.7, 41, 8.07);
                yield return new UN("Mali", "Africa", "africa", 6.117, 598.8, 53.14, 37, 92.206);
                yield return new UN("Malta", "Europe", "other", 1.284, 19599.2, 82.29, 95, 5.405);
                yield return new UN("Marshall Islands", "Oceania", "other", 4.38446625852824, 3069.4, 70.6, 72, 21);
                yield return new UN("Martinique", null, null, null, null, null, null, 7.158);
                yield return new UN("Mauritania", "Africa", "africa", 4.361, 1131.1, 60.95, 42, 69.93);
                yield return new UN("Mauritius", "Africa", "africa", 1.59, 7488.3, 76.89, 42, 12.112);
                yield return new UN("Mayotte", null, null, null, null, null, null, 5.884);
                yield return new UN("Mexico", "Latin Amer", "oecd", 2.227, 9100.7, 79.64, 78, 14.146);
                yield return new UN("Micronesia", "Oceania", "other", 3.307, 2678.2, 70.17, 23, 31.447);
                yield return new UN("Moldova", "Europe", "other", 1.45, 1625.8, 73.48, 48, 14.344);
                yield return new UN("Mongolia", "Asia", "other", 2.446, 2246.7, 72.83, 63, 30.705);
                yield return new UN("Montenegro", "Europe", "other", 1.63, 6509.8, 77.37, 61, 7.733);
                yield return new UN("Morocco", "Africa", "africa", 2.183, 2865, 74.86, 59, 28.502);
                yield return new UN("Mozambique", "Africa", "africa", 4.713, 407.5, 51.81, 39, 77.858);
                yield return new UN("Myanmar", "Asia", "other", 1.939, 876.2, 67.87, 34, 44.802);
                yield return new UN("Namibia", "Africa", "africa", 3.055, 5124.7, 63.04, 39, 29.761);
                yield return new UN("Nauru", "Oceania", "other", 3.3, 6190.1, 57.1, 100, 45.8);
                yield return new UN("Nepal", "Asia", "other", 2.587, 534.7, 70.05, 19, 32.013);
                yield return new UN("Neth Antilles", "Caribbean", "other", 1.9, 20321.1, 79.86, 93, 12.281);
                yield return new UN("Netherlands", "Europe", "oecd", 1.794, 46909.7, 82.79, 83, 4.168);
                yield return new UN("New Caledonia", "Oceania", "other", 2.091, 35319.5, 80.49, 57, 4.68);
                yield return new UN("New Zealand", "Oceania", "oecd", 2.135, 32372.1, 82.77, 86, 4.757);
                yield return new UN("Nicaragua", "Latin Amer", "other", 2.5, 1131.9, 77.45, 58, 18.315);
                yield return new UN("Niger", "Africa", "africa", 6.925, 357.7, 55.77, 17, 85.82);
                yield return new UN("Nigeria", "Africa", "africa", 5.431, 1239.8, 53.38, 51, 87.561);
                yield return new UN("Niue", null, null, null, null, null, null, 7.8);
                yield return new UN("North Korea", "Asia", "other", 1.988, 504, 72.12, 60, 25.053);
                yield return new UN("Northern Mariana Islands", null, null, null, null, null, null, 4.85908649173955);
                yield return new UN("Norway", "Europe", "oecd", 1.948, 84588.7, 83.47, 80, 2.94);
                yield return new UN("Oman", "Asia", "other", 2.146, 20791, 76.44, 73, 8.414);
                yield return new UN("Pakistan", "Asia", "other", 3.201, 1003.2, 66.88, 36, 65.724);
                yield return new UN("Palau", "Oceania", "other", 2, 10821.8, 72.1, 84, 20.0752823086575);
                yield return new UN("Palestinian Territory", "Asia", "other", 4.27, 1819.5, 74.81, 74, 19.503);
                yield return new UN("Panama", "Latin Amer", "other", 2.409, 7614, 79.07, 75, 16.168);
                yield return new UN("Papua New Guinea", "Oceania", "other", 3.799, 1428.4, 65.52, 13, 44.474);
                yield return new UN("Paraguay", "Latin Amer", "other", 2.858, 2771.1, 74.91, 62, 27.375);
                yield return new UN("Peru", "Latin Amer", "other", 2.41, 5410.7, 76.9, 77, 18.273);
                yield return new UN("Philippines", "Asia", "other", 3.05, 2140.1, 72.57, 49, 20.886);
                yield return new UN("Poland", "Europe", "oecd", 1.415, 12263.2, 80.56, 61, 5.546);
                yield return new UN("Portugal", "Europe", "oecd", 1.312, 21437.6, 82.76, 61, 4.175);
                yield return new UN("Puerto Rico", "Caribbean", "other", 1.757, 26461, 83.2, 99, 7.243);
                yield return new UN("Qatar", "Asia", "other", 2.204, 72397.9, 78.24, 96, 8.195);
                yield return new UN("Republic of Korea", "Asia", "other", 1.389, 21052.2, 83.95, 83, 3.647);
                yield return new UN("Reunion", null, null, null, null, null, null, 5.884);
                yield return new UN("Romania", "Europe", "other", 1.428, 7522.4, 77.95, 58, 12.216);
                yield return new UN("Russian Federation", "Europe", "other", 1.529, 10351.4, 75.01, 73, 10.534);
                yield return new UN("Rwanda", "Africa", "africa", 5.282, 532.3, 57.13, 19, 92.87);
                yield return new UN("Saint Lucia", "Caribbean", "other", 1.907, 6677.1, 77.54, 28, 12.26);
                yield return new UN("Samoa", "Oceania", "other", 3.763, 3343.3, 76.02, 20, 19.848);
                yield return new UN("Sao Tome and Principe", "Africa", "africa", 3.488, 1283.3, 66.48, 63, 47.486);
                yield return new UN("Saudi Arabia", "Asia", "other", 2.639, 15835.9, 75.57, 82, 16.202);
                yield return new UN("Senegal", "Africa", "africa", 4.605, 1032.7, 60.92, 43, 49.802);
                yield return new UN("Serbia", "Europe", "other", 1.562, 5123.2, 77.05, 56, 10.63);
                yield return new UN("Seychelles", "Africa", "africa", 2.34, 11450.6, 78, 56, null);
                yield return new UN("Sierra Leone", "Africa", "africa", 4.728, 351.7, 48.87, 39, 103.459);
                yield return new UN("Singapore", "Asia", "other", 1.367, 43783.1, 83.71, 100, 1.916);
                yield return new UN("Slovakia", "Europe", "oecd", 1.372, 15976, 79.53, 55, 5.676);
                yield return new UN("Slovenia", "Europe", "oecd", 1.477, 23109.8, 82.84, 49, 3.279);
                yield return new UN("Solomon Islands", "Oceania", "other", 4.041, 1193.5, 70, 19, 34.569);
                yield return new UN("Somalia", "Africa", "africa", 6.283, 114.8, 53.38, 38, 100.017);
                yield return new UN("South Africa", "Africa", "africa", 2.383, 7254.8, 54.09, 62, 45.892);
                yield return new UN("Spain", "Europe", "other", 1.504, 30542.8, 84.76, 78, 3.573);
                yield return new UN("Sri Lanka", "Asia", "other", 2.235, 2375.3, 78.4, 14, 11.213);
                yield return new UN("St Vincent and Grenadines", "Caribbean", "other", 1.995, 6171.7, 74.73, 50, 20.974);
                yield return new UN("Sudan", "Africa", "africa", 4.225, 1824.9, 63.82, 41, 57.328);
                yield return new UN("Suriname", "Latin Amer", "other", 2.266, 7018, 74.18, 70, 19.775);
                yield return new UN("Swaziland", "Africa", "africa", 3.174, 3311.2, 48.54, 21, 64.622);
                yield return new UN("Sweden", "Europe", "oecd", 1.925, 48906.2, 83.65, 85, 2.544);
                yield return new UN("Switzerland", "Europe", "oecd", 1.536, 68880.2, 84.71, 74, 3.513);
                yield return new UN("Syria", "Asia", "other", 2.772, 2931.5, 77.72, 56, 13.764);
                yield return new UN("Tajikistan", "Asia", "other", 3.162, 816, 71.23, 26, 50.947);
                yield return new UN("Tanzania", "Africa", "africa", 5.499, 516, 60.31, 27, 53.658);
                yield return new UN("TFYR Macedonia", "Europe", "other", 1.397, 4434.5, 77.14, 59, 13.063);
                yield return new UN("Thailand", "Asia", "other", 1.528, 4612.8, 77.76, 34, 11.398);
                yield return new UN("Togo", "Africa", "africa", 3.864, 524.6, 59.4, 44, 67.297);
                yield return new UN("Tokelau", null, null, null, null, null, null, 31.25);
                yield return new UN("Tonga", "Oceania", "other", 3.783, 3543.1, 75.38, 24, 20.591);
                yield return new UN("Trinidad and Tobago", "Caribbean", "other", 1.632, 15205.1, 73.82, 14, 24.458);
                yield return new UN("Tunisia", "Africa", "africa", 1.909, 4222.1, 77.05, 68, 18.384);
                yield return new UN("Turkey", "Asia", "oecd", 2.022, 10095.1, 76.61, 70, 19.901);
                yield return new UN("Turkmenistan", "Asia", "other", 2.316, 4587.5, 69.4, 50, 48.797);
                yield return new UN("Tuvalu", "Oceania", "other", 3.7, 3187.2, 65.1, 51, 17.3228346456693);
                yield return new UN("Uganda", "Africa", "africa", 5.901, 509, 55.44, 13, 72.265);
                yield return new UN("Ukraine", "Europe", "other", 1.483, 3035, 74.58, 69, 11.822);
                yield return new UN("United Arab Emirates", "Asia", "other", 1.707, 39624.7, 78.02, 84, 6.608);
                yield return new UN("United Kingdom", "Europe", "oecd", 1.867, 36326.8, 82.42, 80, 4.702);
                yield return new UN("United States", "North America", "oecd", 2.077, 46545.9, 81.31, 83, 6.46);
                yield return new UN("United States Virgin Islands", null, null, null, null, null, null, 9.99);
                yield return new UN("Uruguay", "Latin Amer", "other", 2.043, 11952.4, 80.66, 93, 11.754);
                yield return new UN("Uzbekistan", "Asia", "other", 2.264, 1427.3, 71.9, 36, 44.481);
                yield return new UN("Vanuatu", "Oceania", "other", 3.75, 2963.5, 73.58, 26, 24.135);
                yield return new UN("Venezuela", "Latin Amer", "other", 2.391, 13502.7, 77.73, 94, 15.278);
                yield return new UN("Viet Nam", "Asia", "other", 1.75, 1182.7, 77.44, 31, 18.263);
                yield return new UN("Wallis and Futuna Islands", null, null, null, null, null, null, 5.2);
                yield return new UN("Western Sahara", null, null, null, null, null, null, 36.35);
                yield return new UN("Yemen", "Asia", "other", 4.938, 1437.2, 67.66, 32, 44.412);
                yield return new UN("Zambia", "Africa", "africa", 6.3, 1237.8, 50.04, 36, 80.956);
                yield return new UN("Zimbabwe", "Africa", "africa", 3.109, 573.1, 52.72, 39, 47.284);
            }
        }
    }
}
