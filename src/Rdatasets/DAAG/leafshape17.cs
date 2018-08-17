// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Subset of Leaf Shape Data Set
    /// </summary>

    public class leafshape17
    {
        public readonly double bladelen;
        public readonly double petiole;
        public readonly double bladewid;
        public readonly double latitude;
        public readonly double logwid;
        public readonly double logpet;
        public readonly double loglen;
        public readonly int arch;

        public leafshape17(double bladelen, double petiole, double bladewid, double latitude, double logwid, double logpet, double loglen, int arch)
        {
            this.bladelen = bladelen;
            this.petiole = petiole;
            this.bladewid = bladewid;
            this.latitude = latitude;
            this.logwid = logwid;
            this.logpet = logpet;
            this.loglen = loglen;
            this.arch = arch;
        }

        public static IEnumerable<leafshape17> Data
        {
            get
            {
                yield return new leafshape17(6.93, 0.449064, 3.1, 17.1, 1.1314021114911, -0.800589862422096, 1.93585981320181, 0);
                yield return new leafshape17(7.27, 0.26172, 2.5, 17.1, 0.916290731874155, -1.3404800489806, 1.98375629154543, 0);
                yield return new leafshape17(7.43, 0.766033, 2.98, 17.1, 1.09192330051731, -0.266530029229555, 2.00552585872967, 0);
                yield return new leafshape17(8, 0.5928, 3.06, 17.1, 1.11841491596429, -0.52289820500026, 2.07944154167984, 0);
                yield return new leafshape17(8.08, 0.4929, 3.03, 17.1, 1.10856261952128, -0.707448965270805, 2.089391872533, 0);
                yield return new leafshape17(8.48, 0.819168, 4.33, 17.1, 1.4655675420144, -0.199466087959853, 2.13771044980381, 0);
                yield return new leafshape17(8.56, 0.598344, 4.82, 17.1, 1.57277392806251, -0.513589439588722, 2.14710019015365, 0);
                yield return new leafshape17(8.72, 0.5901, 4.88, 17.1, 1.58514521986506, -0.527463264919014, 2.16561923792089, 0);
                yield return new leafshape17(9.153333, 0.520824648, 3.01, 17.1, 1.10194007876078, -0.652341862018734, 2.21411807525511, 0);
                yield return new leafshape17(9.353333, 0.893243302, 4.04, 17.1, 1.39624469197306, -0.112896280567409, 2.23573275036829, 0);
                yield return new leafshape17(9.48, 0.239844, 3.24, 17.1, 1.17557332980424, -1.42776656698173, 2.24918431626693, 0);
                yield return new leafshape17(9.56, 0.65964, 2.84, 17.1, 1.04380405217311, -0.416061047321568, 2.25758772706331, 0);
                yield return new leafshape17(10.06, 1.259512, 3.37, 17.1, 1.21491274436427, 0.230724344355454, 2.30856716467159, 0);
                yield return new leafshape17(10.06, 0.602594, 3.79, 17.1, 1.33236601909433, -0.50651160918914, 2.30856716467159, 0);
                yield return new leafshape17(10.11, 0.7446015, 3.72, 17.1, 1.31372366828506, -0.294906103041118, 2.31352503303238, 0);
                yield return new leafshape17(10.37, 0.281, 3.48, 17.1, 1.24703229378638, -1.26940060964839, 2.33891702224144, 0);
                yield return new leafshape17(10.44, 0.489636, 3.99, 17.1, 1.38379123090177, -0.714093021075411, 2.34564458245449, 0);
                yield return new leafshape17(10.5, 0.09975, 3.33, 17.1, 1.20297230399235, -2.30508822321216, 2.35137525716348, 0);
                yield return new leafshape17(10.55, 1.00014, 5.16, 17.1, 1.64093657949347, 0.0001399902009146, 2.35612585992208, 0);
                yield return new leafshape17(10.87, 0.84786, 4.01, 17.1, 1.38879124131848, -0.165039751159427, 2.38600670113312, 0);
                yield return new leafshape17(11.22, 1.104048, 4.65, 17.1, 1.53686721959927, 0.098983425170621, 2.41769790009455, 0);
                yield return new leafshape17(11.66, 0.871, 3.62, 17.1, 1.28647402583768, -0.138113302129634, 2.45616418092235, 0);
                yield return new leafshape17(11.86, 0.856292, 4.33, 17.1, 1.4655675420144, -0.155143839513777, 2.47317139356958, 0);
                yield return new leafshape17(12.23, 0.386468, 4.11, 17.1, 1.41342302850814, -0.95070620869019, 2.50389194969908, 0);
                yield return new leafshape17(12.84, 0.889812, 4.36, 17.1, 1.47247205736094, -0.116745074524464, 2.55256529826182, 0);
                yield return new leafshape17(12.9, 0.2709, 4.18, 17.1, 1.43031124653667, -1.30600552989109, 2.55722731136763, 0);
                yield return new leafshape17(12.96, 0.415368, 4.03, 17.1, 1.39376637595859, -0.87859040469133, 2.56186769092413, 0);
                yield return new leafshape17(13.03, 0.28763725, 3.29, 17.1, 1.19088756477728, -1.24605514135536, 2.56725439113675, 0);
                yield return new leafshape17(13.4, 1.47802, 5.59, 17.1, 1.72097928716701, 0.390703354234185, 2.59525470695687, 0);
                yield return new leafshape17(13.413333, 0.854871952, 4.34, 17.1, 1.46787434811231, -0.156803585003776, 2.59624921227248, 0);
                yield return new leafshape17(13.59, 0.9696465, 5.64, 17.1, 1.72988406550997, -0.0308237068962393, 2.60933422816305, 0);
                yield return new leafshape17(14.36, 0.548552, 4.26, 17.1, 1.44926916028128, -0.600473199749529, 2.66444656362008, 0);
                yield return new leafshape17(14.4, 0.45072, 3.975, 17.1, 1.3800247481063, -0.796908974854075, 2.66722820658195, 0);
                yield return new leafshape17(14.6, 1.04828, 3.05, 17.1, 1.11514159061932, 0.0471507257863323, 2.68102152871429, 0);
                yield return new leafshape17(14.9, 0.93125, 4.57, 17.1, 1.51951320490611, -0.0712275092883678, 2.70136121295141, 0);
                yield return new leafshape17(16.49, 1.205419, 7.61, 17.1, 2.0294631718736, 0.186827224345103, 2.80275413657151, 0);
                yield return new leafshape17(16.67, 0.698473, 5.68, 17.1, 1.73695123273306, -0.358858755291342, 2.8136106967627, 0);
                yield return new leafshape17(17.04, 1.159572, 6.86, 17.1, 1.92570744173779, 0.148050971516508, 2.83556352140117, 0);
                yield return new leafshape17(19.89, 1.1795, 7.81, 17.1, 2.0554049638516, 0.165090619865593, 2.99021709286588, 0);
                yield return new leafshape17(24.43, 1.2044, 6.96, 17.1, 1.94017947434633, 0.185981517625442, 3.19581188526965, 0);
                yield return new leafshape17(30.35, 1.6586275, 6.78, 17.1, 1.9139771019523, 0.505990453145918, 3.41279651750551, 0);
                yield return new leafshape17(13.98, 1.50984, 3.9, 17.1, 1.3609765531356, 0.412003684947747, 2.63762773680566, 1);
                yield return new leafshape17(14.45, 2.88422, 5.72, 17.1, 1.74396880539171, 1.05925449945367, 2.67069441455844, 1);
                yield return new leafshape17(15.25, 0.840275, 3, 17.1, 1.09861228866811, -0.174026059769848, 2.72457950305342, 1);
                yield return new leafshape17(15.3, 1.87425, 5.88, 17.1, 1.77155676191054, 0.628208579401034, 2.72785282839839, 1);
                yield return new leafshape17(15.348, 1.8049248, 4.84, 17.1, 1.57691472072854, 0.590518928867095, 2.73098517238471, 1);
                yield return new leafshape17(15.46, 1.842832, 5.85, 17.1, 1.76644166124377, 0.611303518808388, 2.73825604315928, 1);
                yield return new leafshape17(15.56, 1.039408, 4.72, 17.1, 1.55180879959746, 0.0386513203107086, 2.74470351875025, 1);
                yield return new leafshape17(17, 0.4148, 7.22, 17.1, 1.97685495290474, -0.879958802626765, 2.83321334405622, 1);
                yield return new leafshape17(17.8, 1.55572, 5.28, 17.1, 1.66392609771817, 0.441938460977392, 2.87919845729804, 1);
                yield return new leafshape17(17.97, 3.5212215, 6.15, 17.1, 1.81645208181843, 1.25880794645897, 2.88870370079547, 1);
                yield return new leafshape17(18.76, 1.876, 7.19, 17.1, 1.97269117173296, 0.629141850584033, 2.93172694357808, 1);
                yield return new leafshape17(19.68, 6.5928, 8.16, 17.1, 2.09924416897602, 1.88597814446704, 2.97960289162411, 1);
                yield return new leafshape17(20.98, 3.268684, 6.58, 17.1, 1.88403474533723, 1.18438745742266, 3.04356960296815, 1);
                yield return new leafshape17(22.215, 10.4743725, 11.46, 17.1, 2.43886271128659, 2.34893155947925, 3.10076773638787, 1);
                yield return new leafshape17(22.64, 0.875036, 3.8, 17.1, 1.33500106673234, -0.133490250613724, 3.11971825333498, 1);
                yield return new leafshape17(25.275, 3.634545, 6.85, 17.1, 1.92424865227413, 1.29048393121134, 3.22981576490653, 1);
                yield return new leafshape17(26.55, 2.6350875, 5.92, 17.1, 1.77833644889591, 0.96891638827311, 3.27902974768795, 1);
                yield return new leafshape17(26.9925, 3.83563425, 8.53, 17.1, 2.14358936150359, 1.34433480576008, 3.29555904963916, 1);
                yield return new leafshape17(35.843333, 3.799393298, 9.51, 17.1, 2.2523438765573, 1.33484139556453, 3.5791575804346, 1);
                yield return new leafshape17(42.275, 1.49442125, 23.45, 17.1, 3.15487049489229, 0.401739008145089, 3.74419589478464, 1);
            }
        }
    }
}
