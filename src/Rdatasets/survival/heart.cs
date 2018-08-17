// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Stanford Heart Transplant data
    /// </summary>

    public class heart
    {
        public readonly double start;
        public readonly double stop;
        public readonly int @event;
        public readonly double age;
        public readonly double year;
        public readonly int surgery;
        public readonly int transplant;
        public readonly int id;

        public heart(double start, double stop, int @event, double age, double year, int surgery, int transplant, int id)
        {
            this.start = start;
            this.stop = stop;
            this.@event = @event;
            this.age = age;
            this.year = year;
            this.surgery = surgery;
            this.transplant = transplant;
            this.id = id;
        }

        public static IEnumerable<heart> Data
        {
            get
            {
                yield return new heart(0, 50, 1, -17.1553730321697, 0.123203285420945, 0, 0, 1);
                yield return new heart(0, 6, 1, 3.83572895277207, 0.254620123203285, 0, 0, 2);
                yield return new heart(0, 1, 0, 6.29705681040383, 0.265571526351814, 0, 0, 3);
                yield return new heart(1, 16, 1, 6.29705681040383, 0.265571526351814, 0, 1, 3);
                yield return new heart(0, 36, 0, -7.73716632443532, 0.490075290896646, 0, 0, 4);
                yield return new heart(36, 39, 1, -7.73716632443532, 0.490075290896646, 0, 1, 4);
                yield return new heart(0, 18, 1, -27.2142368240931, 0.607802874743327, 0, 0, 5);
                yield return new heart(0, 3, 1, 6.59548254620123, 0.700889801505818, 0, 0, 6);
                yield return new heart(0, 51, 0, 2.86926762491444, 0.780287474332649, 0, 0, 7);
                yield return new heart(51, 675, 1, 2.86926762491444, 0.780287474332649, 0, 1, 7);
                yield return new heart(0, 40, 1, -2.65023956194388, 0.835044490075291, 0, 0, 8);
                yield return new heart(0, 85, 1, -0.837782340862425, 0.856947296372348, 0, 0, 9);
                yield return new heart(0, 12, 0, -5.49760438056126, 0.862422997946612, 0, 0, 10);
                yield return new heart(12, 58, 1, -5.49760438056126, 0.862422997946612, 0, 1, 10);
                yield return new heart(0, 26, 0, -0.0191649555099218, 0.87337440109514, 0, 0, 11);
                yield return new heart(26, 153, 1, -0.0191649555099218, 0.87337440109514, 0, 1, 11);
                yield return new heart(0, 8, 1, 5.1937029431896, 0.9637234770705, 0, 0, 12);
                yield return new heart(0, 17, 0, 6.57357973990418, 0.969199178644764, 0, 0, 13);
                yield return new heart(17, 81, 1, 6.57357973990418, 0.969199178644764, 0, 1, 13);
                yield return new heart(0, 37, 0, 6.0123203285421, 0.971937029431896, 0, 0, 14);
                yield return new heart(37, 1387, 1, 6.0123203285421, 0.971937029431896, 0, 1, 14);
                yield return new heart(0, 1, 1, 5.81519507186858, 0.991101984941821, 1, 0, 15);
                yield return new heart(0, 28, 0, 1.44832306639288, 1.07049965776865, 0, 0, 16);
                yield return new heart(28, 308, 1, 1.44832306639288, 1.07049965776865, 0, 1, 16);
                yield return new heart(0, 36, 1, -27.668720054757, 1.07597535934292, 0, 0, 17);
                yield return new heart(0, 20, 0, 8.84873374401095, 1.08692676249144, 0, 0, 18);
                yield return new heart(20, 43, 1, 8.84873374401095, 1.08692676249144, 0, 1, 18);
                yield return new heart(0, 37, 1, 11.1238877481177, 1.13347022587269, 0, 0, 19);
                yield return new heart(0, 18, 0, 7.27994524298425, 1.3305954825462, 0, 0, 20);
                yield return new heart(18, 28, 1, 7.27994524298425, 1.3305954825462, 0, 1, 20);
                yield return new heart(0, 8, 0, -4.6570841889117, 1.3388090349076, 0, 0, 21);
                yield return new heart(8, 1032, 1, -4.6570841889117, 1.3388090349076, 0, 1, 21);
                yield return new heart(0, 12, 0, -5.21560574948666, 1.46201232032854, 0, 0, 22);
                yield return new heart(12, 51, 1, -5.21560574948666, 1.46201232032854, 0, 1, 22);
                yield return new heart(0, 3, 0, 10.3572895277207, 1.52772073921971, 0, 0, 23);
                yield return new heart(3, 733, 1, 10.3572895277207, 1.52772073921971, 0, 1, 23);
                yield return new heart(0, 83, 0, 3.80013689253936, 1.56605065023956, 0, 0, 24);
                yield return new heart(83, 219, 1, 3.80013689253936, 1.56605065023956, 0, 1, 24);
                yield return new heart(0, 25, 0, -14.776180698152, 1.57426420260096, 0, 0, 25);
                yield return new heart(25, 1800, 0, -14.776180698152, 1.57426420260096, 0, 1, 25);
                yield return new heart(0, 1401, 0, -17.4647501711157, 1.58247775496235, 0, 0, 26);
                yield return new heart(0, 263, 1, -39.2142368240931, 1.59069130732375, 0, 0, 27);
                yield return new heart(0, 71, 0, 6.02327173169062, 1.68377823408624, 0, 0, 28);
                yield return new heart(71, 72, 1, 6.02327173169062, 1.68377823408624, 0, 1, 28);
                yield return new heart(0, 35, 1, 2.43394934976044, 1.78507871321013, 0, 0, 29);
                yield return new heart(0, 16, 0, -3.08829568788501, 1.88364134154689, 0, 0, 30);
                yield return new heart(16, 852, 1, -3.08829568788501, 1.88364134154689, 0, 1, 30);
                yield return new heart(0, 16, 1, 6.88569472963724, 1.89459274469541, 0, 0, 31);
                yield return new heart(0, 17, 0, 16.4079397672827, 1.91101984941821, 0, 0, 32);
                yield return new heart(17, 77, 1, 16.4079397672827, 1.91101984941821, 0, 1, 32);
                yield return new heart(0, 51, 0, 0.903490759753595, 2.1574264202601, 0, 0, 33);
                yield return new heart(51, 1587, 0, 0.903490759753595, 2.1574264202601, 0, 1, 33);
                yield return new heart(0, 23, 0, -7.44695414099932, 2.19849418206708, 0, 0, 34);
                yield return new heart(23, 1572, 0, -7.44695414099932, 2.19849418206708, 0, 1, 34);
                yield return new heart(0, 12, 1, -4.53388090349076, 2.30800821355236, 0, 0, 35);
                yield return new heart(0, 46, 0, 0.925393566050651, 2.507871321013, 0, 0, 36);
                yield return new heart(46, 100, 1, 0.925393566050651, 2.507871321013, 0, 1, 36);
                yield return new heart(0, 19, 0, 13.5003422313484, 2.56536618754278, 0, 0, 37);
                yield return new heart(19, 66, 1, 13.5003422313484, 2.56536618754278, 0, 1, 37);
                yield return new heart(0, 4.5, 0, -6.52977412731006, 2.5927446954141, 0, 0, 38);
                yield return new heart(4.5, 5, 1, -6.52977412731006, 2.5927446954141, 0, 1, 38);
                yield return new heart(0, 2, 0, 2.51882272416153, 2.63381245722108, 0, 0, 39);
                yield return new heart(2, 53, 1, 2.51882272416153, 2.63381245722108, 0, 1, 39);
                yield return new heart(0, 41, 0, 0.481861738535251, 2.64750171115674, 1, 0, 40);
                yield return new heart(41, 1408, 0, 0.481861738535251, 2.64750171115674, 1, 1, 40);
                yield return new heart(0, 58, 0, -2.69678302532512, 2.8829568788501, 1, 0, 41);
                yield return new heart(58, 1322, 0, -2.69678302532512, 2.8829568788501, 1, 1, 41);
                yield return new heart(0, 3, 1, -11.5592060232717, 2.88843258042437, 0, 0, 42);
                yield return new heart(0, 2, 1, -4.60780287474333, 3.05817932922656, 1, 0, 43);
                yield return new heart(0, 40, 1, -5.42094455852156, 3.16495550992471, 1, 0, 44);
                yield return new heart(0, 1, 0, -11.8165639972622, 3.26351813826146, 0, 0, 45);
                yield return new heart(1, 45, 1, -11.8165639972622, 3.26351813826146, 0, 1, 45);
                yield return new heart(0, 2, 0, 0.610540725530456, 3.27720739219713, 1, 0, 46);
                yield return new heart(2, 996, 1, 0.610540725530456, 3.27720739219713, 1, 1, 46);
                yield return new heart(0, 21, 0, -0.90075290896646, 3.34017796030116, 0, 0, 47);
                yield return new heart(21, 72, 1, -0.90075290896646, 3.34017796030116, 0, 1, 47);
                yield return new heart(0, 9, 1, 8.03559206023272, 3.34839151266256, 0, 0, 48);
                yield return new heart(0, 36, 0, -11.3456536618754, 3.37577002053388, 1, 0, 49);
                yield return new heart(36, 1142, 0, -11.3456536618754, 3.37577002053388, 1, 1, 49);
                yield return new heart(0, 83, 0, -2.11362080766598, 3.37577002053388, 1, 0, 50);
                yield return new heart(83, 980, 1, -2.11362080766598, 3.37577002053388, 1, 1, 50);
                yield return new heart(0, 32, 0, 0.733744010951405, 3.47707049965777, 0, 0, 51);
                yield return new heart(32, 285, 1, 0.733744010951405, 3.47707049965777, 0, 1, 51);
                yield return new heart(0, 102, 1, -6.75154004106776, 3.564681724846, 0, 0, 52);
                yield return new heart(0, 41, 0, -0.657084188911703, 3.75085557837098, 0, 0, 53);
                yield return new heart(41, 188, 1, -0.657084188911703, 3.75085557837098, 0, 1, 53);
                yield return new heart(0, 3, 1, -0.208076659822041, 3.75085557837098, 0, 0, 54);
                yield return new heart(0, 10, 0, 4.45448323066393, 3.854893908282, 0, 0, 55);
                yield return new heart(10, 61, 1, 4.45448323066393, 3.854893908282, 0, 1, 55);
                yield return new heart(0, 67, 0, -9.25667351129363, 3.9233401779603, 0, 0, 56);
                yield return new heart(67, 942, 0, -9.25667351129363, 3.9233401779603, 0, 1, 56);
                yield return new heart(0, 149, 1, -6.73511293634497, 3.95071868583162, 0, 0, 57);
                yield return new heart(0, 21, 0, 0.0164271047227942, 3.97809719370294, 1, 0, 58);
                yield return new heart(21, 343, 1, 0.0164271047227942, 3.97809719370294, 1, 1, 58);
                yield return new heart(0, 78, 0, -6.61738535249829, 3.99452429842574, 1, 0, 59);
                yield return new heart(78, 916, 0, -6.61738535249829, 3.99452429842574, 1, 1, 59);
                yield return new heart(0, 3, 0, 1.05407255304586, 4.13141683778234, 0, 0, 60);
                yield return new heart(3, 68, 1, 1.05407255304586, 4.13141683778234, 0, 1, 60);
                yield return new heart(0, 2, 1, 4.56399726214921, 4.17522245037645, 0, 0, 61);
                yield return new heart(0, 69, 1, -8.64613278576318, 4.18891170431212, 0, 0, 62);
                yield return new heart(0, 27, 0, -15.3401779603012, 4.19712525667351, 0, 0, 63);
                yield return new heart(27, 842, 0, -15.3401779603012, 4.19712525667351, 0, 1, 63);
                yield return new heart(0, 33, 0, 0.815879534565369, 4.33675564681725, 1, 0, 64);
                yield return new heart(33, 584, 1, 0.815879534565369, 4.33675564681725, 1, 1, 64);
                yield return new heart(0, 12, 0, 3.29363449691992, 4.42984257357974, 0, 0, 65);
                yield return new heart(12, 78, 1, 3.29363449691992, 4.42984257357974, 0, 1, 65);
                yield return new heart(0, 32, 1, 5.21286789869952, 4.46817248459959, 0, 0, 66);
                yield return new heart(0, 57, 0, -28.4490075290897, 4.47638603696099, 0, 0, 67);
                yield return new heart(57, 285, 1, -28.4490075290897, 4.47638603696099, 0, 1, 67);
                yield return new heart(0, 3, 0, -2.75975359342916, 4.51745379876797, 0, 0, 68);
                yield return new heart(3, 68, 1, -2.75975359342916, 4.51745379876797, 0, 1, 68);
                yield return new heart(0, 10, 0, -0.0109514031485318, 4.66803559206023, 0, 0, 69);
                yield return new heart(10, 670, 0, -0.0109514031485318, 4.66803559206023, 0, 1, 69);
                yield return new heart(0, 5, 0, 5.00205338809035, 4.71184120465435, 0, 0, 70);
                yield return new heart(5, 30, 1, 5.00205338809035, 4.71184120465435, 0, 1, 70);
                yield return new heart(0, 31, 0, -0.591375770020534, 4.80492813141684, 0, 0, 71);
                yield return new heart(31, 620, 0, -0.591375770020534, 4.80492813141684, 0, 1, 71);
                yield return new heart(0, 4, 0, -21.2731006160164, 4.87063655030801, 0, 0, 72);
                yield return new heart(4, 596, 0, -21.2731006160164, 4.87063655030801, 0, 1, 72);
                yield return new heart(0, 27, 0, 8.33127994524298, 4.94729637234771, 0, 0, 73);
                yield return new heart(27, 90, 1, 8.33127994524298, 4.94729637234771, 0, 1, 73);
                yield return new heart(0, 5, 0, -18.8336755646817, 4.96646132785763, 0, 0, 74);
                yield return new heart(5, 17, 1, -18.8336755646817, 4.96646132785763, 0, 1, 74);
                yield return new heart(0, 2, 1, 4.18069815195072, 4.99657768651609, 0, 0, 75);
                yield return new heart(0, 46, 0, 4.0848733744011, 5.01026694045174, 1, 0, 76);
                yield return new heart(46, 545, 0, 4.0848733744011, 5.01026694045174, 1, 1, 76);
                yield return new heart(0, 21, 1, -6.88843258042436, 5.01574264202601, 0, 0, 77);
                yield return new heart(0, 210, 0, 0.703627652292951, 5.09240246406571, 0, 0, 78);
                yield return new heart(210, 515, 0, 0.703627652292951, 5.09240246406571, 0, 1, 78);
                yield return new heart(0, 67, 0, 5.782340862423, 5.16632443531828, 0, 0, 79);
                yield return new heart(67, 96, 1, 5.782340862423, 5.16632443531828, 0, 1, 79);
                yield return new heart(0, 26, 0, -1.55509924709104, 5.18275154004107, 1, 0, 80);
                yield return new heart(26, 482, 0, -1.55509924709104, 5.18275154004107, 1, 1, 80);
                yield return new heart(0, 6, 0, 4.89253935660506, 5.28405201916496, 0, 0, 81);
                yield return new heart(6, 445, 0, 4.89253935660506, 5.28405201916496, 0, 1, 81);
                yield return new heart(0, 428, 0, -18.798083504449, 4.08487337440109, 0, 0, 82);
                yield return new heart(0, 32, 0, 5.30869267624914, 5.31690622861054, 0, 0, 83);
                yield return new heart(32, 80, 1, 5.30869267624914, 5.31690622861054, 0, 1, 83);
                yield return new heart(0, 37, 0, -5.28131416837783, 5.33333333333333, 0, 0, 84);
                yield return new heart(37, 334, 1, -5.28131416837783, 5.33333333333333, 0, 1, 84);
                yield return new heart(0, 5, 1, -0.0191649555099218, 5.35249828884326, 0, 0, 85);
                yield return new heart(0, 8, 0, 0.919917864476389, 5.4154688569473, 0, 0, 86);
                yield return new heart(8, 397, 0, 0.919917864476389, 5.4154688569473, 0, 1, 86);
                yield return new heart(0, 60, 0, -1.74674880219028, 5.47022587268994, 0, 0, 87);
                yield return new heart(60, 110, 1, -1.74674880219028, 5.47022587268994, 0, 1, 87);
                yield return new heart(0, 31, 0, 6.362765229295, 5.48939082819986, 0, 0, 88);
                yield return new heart(31, 370, 0, 6.362765229295, 5.48939082819986, 0, 1, 88);
                yield return new heart(0, 139, 0, 3.04722792607803, 5.51129363449692, 0, 0, 89);
                yield return new heart(139, 207, 1, 3.04722792607803, 5.51129363449692, 0, 1, 89);
                yield return new heart(0, 160, 0, 4.03285420944559, 5.51403148528405, 1, 0, 90);
                yield return new heart(160, 186, 1, 4.03285420944559, 5.51403148528405, 1, 1, 90);
                yield return new heart(0, 340, 1, -0.40520191649555, 5.53319644079398, 0, 0, 91);
                yield return new heart(0, 310, 0, -3.01711156741958, 5.57152635181383, 0, 0, 92);
                yield return new heart(310, 340, 0, -3.01711156741958, 5.57152635181383, 0, 1, 92);
                yield return new heart(0, 28, 0, -0.249144421629019, 5.77686516084873, 0, 0, 93);
                yield return new heart(28, 265, 0, -0.249144421629019, 5.77686516084873, 0, 1, 93);
                yield return new heart(0, 4, 0, -4.15879534565367, 5.95482546201232, 1, 0, 94);
                yield return new heart(4, 165, 1, -4.15879534565367, 5.95482546201232, 1, 1, 94);
                yield return new heart(0, 2, 0, -7.71800136892539, 5.97672826830938, 0, 0, 95);
                yield return new heart(2, 16, 1, -7.71800136892539, 5.97672826830938, 0, 1, 95);
                yield return new heart(0, 13, 0, -21.3497604380561, 6.00958247775496, 0, 0, 96);
                yield return new heart(13, 180, 0, -21.3497604380561, 6.00958247775496, 0, 1, 96);
                yield return new heart(0, 21, 0, -24.3832991101985, 6.14373716632443, 0, 0, 97);
                yield return new heart(21, 131, 0, -24.3832991101985, 6.14373716632443, 0, 1, 97);
                yield return new heart(0, 96, 0, -19.3702943189596, 6.20396988364134, 0, 0, 98);
                yield return new heart(96, 109, 0, -19.3702943189596, 6.20396988364134, 0, 1, 98);
                yield return new heart(0, 21, 1, 1.83436002737851, 6.23408624229979, 0, 0, 99);
                yield return new heart(0, 38, 0, -12.9390828199863, 6.39561943874059, 1, 0, 100);
                yield return new heart(38, 39, 0, -12.9390828199863, 6.39561943874059, 1, 1, 100);
                yield return new heart(0, 31, 0, 1.51676933607118, 6.41752224503765, 0, 0, 101);
                yield return new heart(0, 11, 0, -7.60848733744011, 6.47227926078029, 0, 0, 102);
                yield return new heart(0, 6, 1, -8.68446269678302, -0.0492813141683778, 0, 0, 103);
            }
        }
    }
}
