// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Bids Received By U.S. Firms
    /// </summary>

    public class Bids
    {
        public readonly int κ;
        public readonly int docno;
        public readonly double weeks;
        public readonly int numbids;
        public readonly int takeover;
        public readonly double bidprem;
        public readonly double insthold;
        public readonly double size;
        public readonly int leglrest;
        public readonly int rearest;
        public readonly int finrest;
        public readonly int regulatn;
        public readonly int whtknght;

        public Bids(int κ, int docno, double weeks, int numbids, int takeover, double bidprem, double insthold, double size, int leglrest, int rearest, int finrest, int regulatn, int whtknght)
        {
            this.κ = κ;
            this.docno = docno;
            this.weeks = weeks;
            this.numbids = numbids;
            this.takeover = takeover;
            this.bidprem = bidprem;
            this.insthold = insthold;
            this.size = size;
            this.leglrest = leglrest;
            this.rearest = rearest;
            this.finrest = finrest;
            this.regulatn = regulatn;
            this.whtknght = whtknght;
        }

        public static IEnumerable<Bids> Data
        {
            get
            {
                yield return new Bids(1, 78001, 23.570999, 2, 1, 1.190497, 0.136, 0.76676, 1, 0, 0, 0, 1);
                yield return new Bids(2, 78005, 13.571, 0, 1, 1.036, 0.134, 0.162503, 0, 0, 0, 0, 0);
                yield return new Bids(3, 78015, 5, 1, 1, 1.403412, 0.002, 0.120489, 1, 0, 0, 1, 1);
                yield return new Bids(4, 78016, 7.429, 1, 1, 1.504455, 0.181, 0.0723, 1, 0, 0, 0, 0);
                yield return new Bids(5, 78028, 8.857, 1, 1, 1.380736, 0.329, 0.189118, 1, 0, 0, 1, 0);
                yield return new Bids(6, 78031, 6.429, 3, 1, 1.400069, 0.188, 0.154217, 1, 0, 0, 0, 1);
                yield return new Bids(7, 78033, 13.571, 2, 1, 1.181691, 0.319, 0.460355, 0, 0, 0, 1, 1);
                yield return new Bids(8, 78037, 14.857, 1, 1, 1.32256, 0.123, 0.276814, 0, 0, 0, 1, 0);
                yield return new Bids(9, 78039, 20.714001, 1, 1, 1.650588, 0.379, 0.22895, 0, 0, 0, 0, 0);
                yield return new Bids(10, 78041, 41.429001, 0, 1, 1.35606, 0.343, 0.914039, 1, 1, 0, 1, 0);
                yield return new Bids(11, 78042, 2.857, 1, 1, 1.305793, 0.395, 0.230777, 0, 0, 0, 0, 0);
                yield return new Bids(12, 78043, 7.714, 2, 1, 1.472298, 0.174, 0.107286, 1, 0, 0, 1, 1);
                yield return new Bids(13, 79008, 14.429, 2, 1, 1.387, 0.006, 0.037003, 1, 0, 0, 0, 1);
                yield return new Bids(14, 79015, 8.286, 1, 1, 2.066366, 0.06, 0.308104, 1, 0, 0, 0, 1);
                yield return new Bids(15, 79017, 7.714, 2, 1, 1.333636, 0.152, 0.423673, 0, 0, 0, 1, 1);
                yield return new Bids(16, 79032, 14.286, 1, 1, 1.614583, 0.038, 0.113908, 0, 0, 0, 0, 0);
                yield return new Bids(17, 79033, 8.286, 3, 1, 1.349378, 0.061, 0.180093, 1, 0, 0, 0, 1);
                yield return new Bids(18, 79034, 20.429001, 2, 1, 1.322247, 0.112, 0.551584, 0, 0, 0, 0, 1);
                yield return new Bids(19, 79036, 10, 2, 1, 1.402218, 0.329, 0.22357, 0, 0, 0, 0, 1);
                yield return new Bids(20, 80001, 13.143, 1, 1, 1.536418, 0.081, 0.080982, 0, 0, 0, 0, 0);
                yield return new Bids(21, 80002, 24.429001, 3, 1, 1.510465, 0.081, 0.135537, 0, 0, 0, 1, 0);
                yield return new Bids(22, 80004, 16.714001, 1, 1, 1.530601, 0.087, 0.111916, 0, 0, 0, 0, 1);
                yield return new Bids(23, 80008, 7.286, 2, 1, 1.319529, 0.084, 0.749821, 1, 1, 0, 0, 1);
                yield return new Bids(24, 80011, 19.570999, 4, 1, 0.953461, 0.299, 1.299397, 1, 0, 0, 1, 1);
                yield return new Bids(25, 80014, 10.286, 1, 1, 1.573161, 0, 0.052537, 1, 0, 0, 1, 1);
                yield return new Bids(26, 80015, 9.714, 1, 1, 1.445622, 0.08, 0.035321, 0, 0, 0, 0, 1);
                yield return new Bids(27, 80016, 6.714, 1, 1, 1.419429, 0.297, 0.119377, 0, 0, 0, 0, 1);
                yield return new Bids(28, 80019, 5.714, 1, 1, 1.438874, 0.079, 0.104623, 0, 0, 0, 0, 0);
                yield return new Bids(29, 80020, 17, 4, 1, 1.335253, 0.373, 0.20756, 1, 0, 0, 1, 1);
                yield return new Bids(30, 80024, 8.429, 1, 1, 1.209008, 0.211, 0.221637, 0, 0, 0, 1, 0);
                yield return new Bids(31, 80026, 7.286, 2, 1, 1.217107, 0, 0.030686, 0, 1, 0, 0, 1);
                yield return new Bids(32, 80030, 13.571, 1, 1, 1.673279, 0.272, 0.424543, 1, 0, 0, 0, 1);
                yield return new Bids(33, 81001, 11.143, 4, 1, 1.587993, 0.116, 0.076668, 1, 0, 1, 0, 1);
                yield return new Bids(34, 81003, 4, 1, 1, 1.365418, 0.126, 2.965952, 0, 0, 0, 0, 0);
                yield return new Bids(35, 81004, 5.143, 1, 1, 1.679737, 0.415, 1.764889, 1, 1, 1, 0, 1);
                yield return new Bids(36, 81006, 14.857, 10, 1, 1.303152, 0.496, 11.0363, 1, 1, 0, 1, 1);
                yield return new Bids(37, 81008, 7.714, 1, 1, 1.394373, 0.001, 0.024125, 0, 0, 0, 0, 0);
                yield return new Bids(38, 81010, 4.714, 1, 1, 1.428554, 0.197, 2.010382, 0, 0, 0, 0, 0);
                yield return new Bids(39, 81011, 12.429, 1, 1, 1.389614, 0.117, 0.061078, 0, 0, 0, 0, 1);
                yield return new Bids(40, 81014, 8.857, 1, 1, 1.396612, 0.069, 0.107059, 0, 1, 0, 0, 1);
                yield return new Bids(41, 81015, 11, 1, 1, 1.745144, 0.141, 0.292953, 1, 0, 0, 0, 0);
                yield return new Bids(42, 81016, 21.429001, 2, 1, 1.755294, 0.06, 0.120224, 1, 0, 0, 1, 1);
                yield return new Bids(43, 81017, 9.714, 1, 1, 1.246452, 0.189, 0.215708, 1, 0, 0, 0, 1);
                yield return new Bids(44, 81020, 5.143, 2, 1, 1.49177, 0.373, 0.953882, 1, 0, 0, 1, 1);
                yield return new Bids(45, 81024, 21.714001, 1, 1, 1.890381, 0.32, 0.320775, 1, 0, 0, 1, 0);
                yield return new Bids(46, 81028, 5.714, 2, 1, 1.430947, 0.485, 5.043089, 1, 1, 0, 1, 1);
                yield return new Bids(47, 81030, 6.857, 1, 1, 1.304395, 0.035, 0.050246, 1, 0, 0, 0, 1);
                yield return new Bids(48, 81031, 10, 1, 1, 1.277942, 0.048, 0.083523, 1, 0, 0, 1, 1);
                yield return new Bids(49, 82001, 4.143, 1, 1, 1.373276, 0.06, 0.440406, 0, 1, 0, 0, 0);
                yield return new Bids(50, 82006, 11.286, 3, 1, 1.34238, 0.322, 0.680758, 1, 0, 0, 1, 1);
                yield return new Bids(51, 82007, 10.571, 1, 1, 1.319894, 0.239, 0.608149, 1, 0, 0, 0, 0);
                yield return new Bids(52, 82015, 10, 2, 1, 1.904547, 0.08, 0.067855, 0, 0, 0, 1, 1);
                yield return new Bids(53, 82016, 14.714, 4, 1, 1.37417, 0.358, 6.0485, 1, 1, 0, 1, 1);
                yield return new Bids(54, 82022, 4.143, 1, 1, 1.754313, 0.476, 0.229478, 0, 0, 0, 0, 0);
                yield return new Bids(55, 82023, 18.285999, 3, 1, 1.351873, 0.152, 0.076379, 0, 0, 0, 0, 1);
                yield return new Bids(56, 82024, 26.857, 1, 1, 1.458766, 0.576, 1.120939, 1, 1, 0, 0, 1);
                yield return new Bids(57, 82025, 7, 1, 1, 1.305535, 0.223, 0.104418, 0, 0, 0, 0, 0);
                yield return new Bids(58, 82027, 14, 3, 1, 1.602093, 0.253, 3.2185, 1, 0, 0, 0, 1);
                yield return new Bids(59, 82031, 4.857, 2, 1, 1.045617, 0.05, 0.05657, 1, 0, 0, 0, 0);
                yield return new Bids(60, 82033, 25.857, 2, 1, 1.419652, 0.14, 0.047079, 1, 0, 0, 0, 0);
                yield return new Bids(61, 82034, 7.143, 0, 1, 1.355982, 0.022, 0.04964, 0, 0, 0, 1, 0);
                yield return new Bids(62, 82037, 7, 3, 1, 1.296421, 0.076, 0.120998, 0, 0, 0, 0, 1);
                yield return new Bids(63, 82038, 7.143, 0, 1, 1.402657, 0.348, 3.711206, 0, 1, 1, 1, 0);
                yield return new Bids(64, 82039, 6.429, 1, 1, 1.313242, 0.58, 0.524077, 1, 0, 1, 0, 1);
                yield return new Bids(65, 82040, 8.857, 6, 1, 1.294054, 0.106, 0.407735, 0, 0, 0, 0, 1);
                yield return new Bids(66, 83008, 14.857, 2, 1, 1.362922, 0.065, 0.162966, 0, 0, 1, 0, 1);
                yield return new Bids(67, 83009, 10.286, 2, 1, 1.210732, 0.179, 0.229662, 0, 0, 0, 0, 1);
                yield return new Bids(68, 83010, 11.429, 1, 1, 1.434098, 0.233, 2.832909, 0, 0, 0, 1, 0);
                yield return new Bids(69, 83011, 5, 2, 1, 1.421253, 0.026, 0.133306, 0, 0, 0, 0, 1);
                yield return new Bids(70, 83012, 6.571, 1, 1, 1.508683, 0.576, 0.190389, 0, 0, 1, 0, 0);
                yield return new Bids(71, 83013, 7.571, 1, 1, 1.334118, 0.134, 0.018447, 1, 0, 0, 0, 1);
                yield return new Bids(72, 83014, 7, 5, 1, 1.160266, 0.375, 2.193173, 1, 0, 0, 0, 1);
                yield return new Bids(73, 83015, 38, 3, 1, 1.275455, 0, 0.266395, 0, 1, 0, 0, 1);
                yield return new Bids(74, 83016, 10, 6, 1, 1.143672, 0.05, 0.090863, 1, 0, 0, 0, 1);
                yield return new Bids(75, 83017, 8.286, 1, 1, 1.127, 0.121, 2.413504, 0, 0, 0, 1, 1);
                yield return new Bids(76, 83018, 39.570999, 2, 1, 1.201213, 0.177, 0.162984, 0, 0, 0, 0, 1);
                yield return new Bids(77, 83019, 6.429, 1, 1, 1.404, 0.271, 0.089406, 0, 0, 0, 0, 0);
                yield return new Bids(78, 83020, 5.857, 1, 1, 1.393225, 0.173, 0.534593, 0, 0, 0, 0, 0);
                yield return new Bids(79, 83021, 19.570999, 2, 1, 1.298451, 0.259, 0.123048, 0, 0, 0, 0, 0);
                yield return new Bids(80, 84002, 5.857, 3, 1, 1.294463, 0.207, 9.924488, 0, 0, 0, 0, 0);
                yield return new Bids(81, 84003, 7, 1, 1, 1.261674, 0.045, 0.188814, 0, 0, 0, 1, 0);
                yield return new Bids(82, 84004, 7.571, 1, 1, 1.058623, 0.201, 0.525307, 0, 0, 1, 0, 1);
                yield return new Bids(83, 84009, 18.429001, 2, 1, 1.213127, 0.403, 20.964001, 1, 0, 0, 1, 1);
                yield return new Bids(84, 84012, 5.714, 1, 1, 1.208205, 0.126, 0.069824, 0, 0, 0, 0, 0);
                yield return new Bids(85, 84013, 15.286, 1, 1, 1.633168, 0.214, 22.169001, 0, 0, 0, 1, 0);
                yield return new Bids(86, 84014, 5.714, 3, 1, 1.174125, 0.071, 0.086045, 0, 0, 0, 0, 1);
                yield return new Bids(87, 84017, 12.429, 3, 1, 1.281251, 0.385, 0.689141, 0, 0, 0, 1, 0);
                yield return new Bids(88, 84019, 3.571, 2, 1, 1.13094, 0.072, 0.215535, 0, 0, 0, 0, 0);
                yield return new Bids(89, 84022, 4.286, 1, 1, 1.20638, 0.904, 0.312848, 1, 0, 0, 1, 1);
                yield return new Bids(90, 84027, 5.143, 2, 1, 0.942675, 0.203, 0.949399, 1, 0, 0, 1, 0);
                yield return new Bids(91, 84028, 8.143, 1, 1, 1.397086, 0.317, 0.128793, 0, 0, 0, 0, 1);
                yield return new Bids(92, 84029, 19.285999, 1, 1, 1.493163, 0.411, 0.063375, 1, 0, 0, 0, 1);
                yield return new Bids(93, 84030, 6, 1, 1, 1.320655, 0.474, 1.562195, 1, 1, 0, 0, 0);
                yield return new Bids(94, 84032, 14.571, 1, 1, 1.154, 0, 0.017722, 0, 0, 0, 0, 1);
                yield return new Bids(95, 84034, 3.143, 0, 1, 1.391765, 0.382, 0.221153, 1, 0, 1, 0, 1);
                yield return new Bids(96, 84035, 6.143, 1, 1, 1.31454, 0.486, 2.880077, 0, 1, 0, 0, 1);
                yield return new Bids(97, 84037, 9, 0, 1, 1.58464, 0.529, 0.339681, 0, 0, 0, 0, 1);
                yield return new Bids(98, 84039, 8.857, 1, 1, 1.384925, 0.198, 0.022135, 0, 0, 0, 0, 1);
                yield return new Bids(99, 84041, 37.714001, 1, 1, 1.038503, 0, 0.880029, 0, 1, 0, 0, 1);
                yield return new Bids(100, 84048, 5.429, 1, 1, 1.227943, 0, 0.090916, 0, 0, 0, 0, 0);
                yield return new Bids(101, 84053, 6.857, 1, 1, 1.491344, 0.474, 0.402572, 1, 0, 0, 0, 0);
                yield return new Bids(102, 84057, 5.286, 2, 1, 1.098285, 0.463, 6.388277, 0, 0, 0, 0, 1);
                yield return new Bids(103, 84058, 4.571, 1, 1, 1.20879, 0.574, 0.490398, 1, 1, 0, 0, 0);
                yield return new Bids(104, 84060, 4.857, 1, 1, 1.300976, 0.364, 0.22911, 0, 0, 0, 0, 1);
                yield return new Bids(105, 85006, 15.857, 2, 1, 1.113146, 0.072, 0.079583, 0, 0, 0, 0, 1);
                yield return new Bids(106, 85009, 6.714, 2, 1, 1.19855, 0.642, 0.884122, 0, 0, 0, 0, 0);
                yield return new Bids(107, 85011, 5, 1, 1, 1.416697, 0.439, 4.000699, 1, 1, 0, 0, 1);
                yield return new Bids(108, 85013, 6.143, 1, 1, 1.434406, 0.463, 0.084553, 0, 0, 0, 0, 1);
                yield return new Bids(109, 85016, 10.143, 1, 1, 1.316467, 0.526, 1.4168, 0, 0, 0, 0, 0);
                yield return new Bids(110, 85018, 6.571, 0, 1, 1.219, 0.328, 0.516489, 0, 1, 0, 0, 0);
                yield return new Bids(111, 85023, 19.285999, 0, 1, 1.233214, 0.419, 2.5328, 1, 1, 0, 0, 1);
                yield return new Bids(112, 85024, 3.857, 2, 1, 1.249007, 0.427, 1.453418, 1, 1, 0, 0, 1);
                yield return new Bids(113, 85025, 18.143, 1, 1, 1.237732, 0.348, 0.288937, 0, 0, 0, 0, 0);
                yield return new Bids(114, 85026, 7.429, 1, 1, 1.20264, 0.461, 0.939445, 0, 0, 0, 0, 0);
                yield return new Bids(115, 85027, 5, 1, 1, 1.033141, 0.17, 0.353301, 0, 0, 0, 0, 0);
                yield return new Bids(116, 85033, 12.143, 1, 1, 1.188, 0.163, 0.038863, 0, 0, 0, 1, 1);
                yield return new Bids(117, 85035, 16.429001, 2, 1, 1.176587, 0.437, 0.150459, 1, 0, 0, 0, 0);
                yield return new Bids(118, 85041, 11.714, 7, 1, 1.130624, 0.621, 2.311365, 1, 1, 1, 0, 1);
                yield return new Bids(119, 85042, 14.286, 2, 1, 1.223625, 0.618, 0.375493, 0, 0, 0, 0, 1);
                yield return new Bids(120, 85043, 20, 4, 1, 1.083759, 0.529, 1.159328, 1, 1, 0, 0, 1);
                yield return new Bids(121, 85046, 6, 2, 1, 1.241615, 0.388, 0.271522, 0, 0, 0, 1, 0);
                yield return new Bids(122, 85048, 6, 4, 1, 1.445402, 0.422, 0.9353, 0, 0, 1, 0, 1);
                yield return new Bids(123, 85050, 25.285999, 3, 1, 1.282115, 0.513, 0.525706, 1, 0, 1, 0, 1);
                yield return new Bids(124, 85051, 31, 2, 1, 1.436627, 0.144, 0.174257, 1, 0, 1, 0, 0);
                yield return new Bids(125, 85052, 6.286, 0, 1, 1.272, 0.361, 0.642904, 0, 1, 0, 0, 0);
                yield return new Bids(126, 85059, 10, 1, 1, 1.032875, 0.442, 3.47508, 1, 0, 1, 1, 1);
            }
        }
    }
}
