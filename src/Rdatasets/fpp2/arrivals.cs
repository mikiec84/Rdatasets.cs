// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// International Arrivals to Australia
    /// </summary>

    public class arrivals
    {
        public readonly double Japan;
        public readonly double NZ;
        public readonly double UK;
        public readonly double US;

        public arrivals(double Japan, double NZ, double UK, double US)
        {
            this.Japan = Japan;
            this.NZ = NZ;
            this.UK = UK;
            this.US = US;
        }

        public static IEnumerable<arrivals> Data
        {
            get
            {
                yield return new arrivals(14.763, 49.14, 45.266, 32.316);
                yield return new arrivals(9.321, 87.467, 19.886, 23.721);
                yield return new arrivals(10.166, 85.841, 24.839, 24.533);
                yield return new arrivals(19.509, 61.882, 52.264, 33.438);
                yield return new arrivals(17.117, 42.045, 53.636, 33.527);
                yield return new arrivals(10.617, 63.081, 34.802, 28.366);
                yield return new arrivals(11.737, 73.275, 31.126, 30.856);
                yield return new arrivals(20.961, 54.808, 53.619, 33.293);
                yield return new arrivals(20.671, 41.03, 43.423, 32.472);
                yield return new arrivals(12.235, 56.155, 23.421, 32.369);
                yield return new arrivals(14.567, 69.395, 29.142, 37.476);
                yield return new arrivals(24.363, 58.423, 51.771, 38.112);
                yield return new arrivals(23.169, 37.039, 44.182, 42.553);
                yield return new arrivals(16.296, 71.564, 24.92, 41.277);
                yield return new arrivals(18.504, 71.26, 27.566, 33.056);
                yield return new arrivals(29.938, 54.597, 48.88, 44.472);
                yield return new arrivals(30.24, 41.646, 49.563, 47.792);
                yield return new arrivals(20.28, 63.668, 23.867, 43.07);
                yield return new arrivals(20.908, 67.803, 25.895, 41.116);
                yield return new arrivals(36.169, 72.177, 54.092, 65.428);
                yield return new arrivals(37.989, 55.192, 54.903, 59.377);
                yield return new arrivals(32.366, 89.073, 26.089, 53.283);
                yield return new arrivals(28.131, 97.746, 28.248, 48.51);
                yield return new arrivals(47.15, 94.696, 66.813, 85.878);
                yield return new arrivals(51.736, 71.13, 61.167, 84.13);
                yield return new arrivals(38.254, 111.416, 32.4, 64.347);
                yield return new arrivals(53.807, 127.619, 33.287, 65.976);
                yield return new arrivals(71.807, 117.078, 72.115, 96.165);
                yield return new arrivals(80.3, 90.498, 81.925, 78.609);
                yield return new arrivals(79.596, 135.435, 42.091, 69.306);
                yield return new arrivals(88.708, 176.899, 46.253, 86.267);
                yield return new arrivals(103.738, 131.457, 90.062, 92.738);
                yield return new arrivals(94.172, 83.029, 84.191, 73.321);
                yield return new arrivals(76.462, 111.748, 48.709, 59.819);
                yield return new arrivals(88.393, 128.51, 46.905, 60.868);
                yield return new arrivals(90.527, 126.021, 93.075, 67.761);
                yield return new arrivals(119.654, 75.584, 81.185, 67.637);
                yield return new arrivals(106.965, 109.472, 53.693, 56.153);
                yield return new arrivals(128.472, 122.164, 48.037, 58.783);
                yield return new arrivals(124.773, 111.222, 94.827, 69.018);
                yield return new arrivals(119.638, 90.067, 79.365, 63.235);
                yield return new arrivals(115.049, 114.05, 52.961, 56.691);
                yield return new arrivals(140.47, 152.662, 42.366, 85.473);
                yield return new arrivals(153.436, 123.821, 89.041, 66.332);
                yield return new arrivals(166.732, 75.376, 87.85, 69.861);
                yield return new arrivals(141.886, 107.369, 57.261, 61.501);
                yield return new arrivals(160.455, 128.55, 51.058, 57.869);
                yield return new arrivals(160.807, 136.25, 93.736, 73.632);
                yield return new arrivals(178.466, 90.758, 95.137, 76.323);
                yield return new arrivals(151.904, 124.972, 55.661, 62.718);
                yield return new arrivals(168.131, 153.153, 56.4, 64.731);
                yield return new arrivals(172.358, 130.393, 103.089, 77.495);
                yield return new arrivals(191.367, 90.095, 100.25, 81.428);
                yield return new arrivals(158.207, 113.799, 57.464, 63.554);
                yield return new arrivals(183.289, 148.605, 61.831, 66.505);
                yield return new arrivals(188.273, 127.879, 115.736, 78.19);
                yield return new arrivals(196.48, 95.295, 112.684, 83.047);
                yield return new arrivals(174.307, 130.073, 64.209, 67.448);
                yield return new arrivals(214.067, 166.383, 59.287, 69.234);
                yield return new arrivals(197.85, 146.632, 111.719, 85.16);
                yield return new arrivals(227.335, 132.41, 108.173, 84.995);
                yield return new arrivals(174.325, 166.735, 64.632, 71.005);
                yield return new arrivals(219.347, 205.12, 64.742, 71.412);
                yield return new arrivals(192.137, 167.569, 129.994, 89.483);
                yield return new arrivals(223.64, 142.502, 126.261, 87.405);
                yield return new arrivals(167.269, 160.522, 65.146, 73.061);
                yield return new arrivals(227.641, 205.25, 74.071, 79.986);
                yield return new arrivals(195.35, 177.366, 145.139, 89.141);
                yield return new arrivals(205.468, 128.179, 143.115, 101.167);
                yield return new arrivals(168.52, 184.943, 82.747, 85.384);
                yield return new arrivals(200.86, 212.263, 78.303, 82.586);
                yield return new arrivals(176.235, 183.996, 163.356, 104.76);
                yield return new arrivals(193.822, 143.015, 160.239, 113.86);
                yield return new arrivals(154.86, 179.577, 81.152, 92.494);
                yield return new arrivals(188.08, 215.732, 107.941, 95.001);
                yield return new arrivals(170.689, 190.461, 179.102, 115.704);
                yield return new arrivals(192.023, 154.537, 161.953, 118.84);
                yield return new arrivals(154.701, 212.401, 105.394, 107.313);
                yield return new arrivals(182.13, 229.048, 107.231, 131.833);
                yield return new arrivals(192.135, 221.071, 205.874, 130.1);
                yield return new arrivals(193.645, 162.48, 184.901, 126.702);
                yield return new arrivals(156.303, 215.84, 107.454, 113.471);
                yield return new arrivals(186.861, 233.074, 121.889, 105.239);
                yield return new arrivals(136.748, 203.493, 202.988, 101.058);
                yield return new arrivals(177.263, 159.879, 206.655, 121.127);
                yield return new arrivals(158.357, 191.215, 95.564, 97.016);
                yield return new arrivals(183.821, 226.008, 115.95, 102.261);
                yield return new arrivals(196.006, 213, 224.496, 114.103);
                yield return new arrivals(176.132, 150.7, 196.276, 112.908);
                yield return new arrivals(102.633, 203.4, 107.563, 94.212);
                yield return new arrivals(156.396, 241.8, 125.171, 102.961);
                yield return new arrivals(192.591, 243.2, 243.894, 112.039);
                yield return new arrivals(185.175, 188.873, 205.423, 114.017);
                yield return new arrivals(153.363, 252.262, 111.924, 101.065);
                yield return new arrivals(181.659, 312.956, 125.132, 105.884);
                yield return new arrivals(190.143, 278.709, 233.761, 112.335);
                yield return new arrivals(193.547, 219.527, 235.242, 122.725);
                yield return new arrivals(135.461, 270.782, 105.37, 104.542);
                yield return new arrivals(176.242, 325.633, 131.141, 107.725);
                yield return new arrivals(180.085, 282.908, 237.053, 111.286);
                yield return new arrivals(189.187, 212.323, 224.933, 123.608);
                yield return new arrivals(128.92, 269.964, 116.211, 109.865);
                yield return new arrivals(163.649, 307.149, 123.808, 107.787);
                yield return new arrivals(169.314, 286.361, 269.292, 114.824);
                yield return new arrivals(165.823, 219.885, 231.686, 124.677);
                yield return new arrivals(111.484, 301.654, 108.543, 108.089);
                yield return new arrivals(149.065, 320.737, 122.734, 107.738);
                yield return new arrivals(146.673, 295.727, 226.031, 119.189);
                yield return new arrivals(136.544, 222.77, 230.109, 128.066);
                yield return new arrivals(88.879, 282.076, 107.43, 99.471);
                yield return new arrivals(121.951, 304.979, 115.758, 111.243);
                yield return new arrivals(109.858, 303.481, 218.864, 115.636);
                yield return new arrivals(106.123, 221.287, 210.109, 119.158);
                yield return new arrivals(65.748, 275.761, 113.973, 105.507);
                yield return new arrivals(88.371, 311.431, 116.517, 118.979);
                yield return new arrivals(95.214, 301.983, 223.178, 136.094);
                yield return new arrivals(109.072, 228.162, 213.568, 127.535);
                yield return new arrivals(71.253, 281.791, 99.497, 105.974);
                yield return new arrivals(117.876, 330.812, 108.208, 111.615);
                yield return new arrivals(99.987, 320.897, 225.395, 127.002);
                yield return new arrivals(92.889, 239.103, 188.56, 125.264);
                yield return new arrivals(53.397, 292.072, 110.212, 101.814);
                yield return new arrivals(96.467, 311.994, 107.089, 101.925);
                yield return new arrivals(89.9, 329.47, 202.24, 127.15);
                yield return new arrivals(98.18, 247.91, 194.64, 129.52);
                yield return new arrivals(59.76, 301.88, 92.97, 105.7);
                yield return new arrivals(101.9, 319.84, 101.69, 106.54);
            }
        }
    }
}