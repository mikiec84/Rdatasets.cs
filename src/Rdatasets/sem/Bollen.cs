// ReSharper disable All

namespace Rdatasets.sem
{
    using System.Collections.Generic;

    /// <summary>
    /// Bollen's Data on Industrialization and Political Democracy
    /// </summary>

    public class Bollen
    {
        public readonly double y1;
        public readonly double y2;
        public readonly double y3;
        public readonly double y4;
        public readonly double y5;
        public readonly double y6;
        public readonly double y7;
        public readonly double y8;
        public readonly double x1;
        public readonly double x2;
        public readonly double x3;

        public Bollen(double y1, double y2, double y3, double y4, double y5, double y6, double y7, double y8, double x1, double x2, double x3)
        {
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.y5 = y5;
            this.y6 = y6;
            this.y7 = y7;
            this.y8 = y8;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
        }

        public static IEnumerable<Bollen> Data
        {
            get
            {
                yield return new Bollen(2.5, 0, 3.333333, 0, 1.25, 0, 3.72636, 3.333333, 4.442651, 3.637586, 2.557615);
                yield return new Bollen(1.25, 0, 3.333333, 0, 6.25, 1.1, 6.666666, 0.736999, 5.384495, 5.062595, 3.568079);
                yield return new Bollen(7.5, 8.8, 9.999998, 9.199991, 8.75, 8.094061, 9.999998, 8.211809, 5.961005, 6.25575, 5.224433);
                yield return new Bollen(8.9, 8.8, 9.999998, 9.199991, 8.907948, 8.127979, 9.999998, 4.615086, 6.285998, 7.567863, 6.267495);
                yield return new Bollen(10, 3.333333, 9.999998, 6.666666, 7.5, 3.333333, 9.999998, 6.666666, 5.863631, 6.818924, 4.573679);
                yield return new Bollen(7.5, 3.333333, 6.666666, 6.666666, 6.25, 1.1, 6.666666, 0.3685, 5.533389, 5.135798, 3.89227);
                yield return new Bollen(7.5, 3.333333, 6.666666, 6.666666, 5, 2.233333, 8.271257, 1.485166, 5.308268, 5.075174, 3.316213);
                yield return new Bollen(7.5, 2.233333, 9.999998, 1.496333, 6.25, 3.333333, 9.999998, 6.666666, 5.347108, 4.85203, 4.263183);
                yield return new Bollen(2.5, 3.333333, 3.333333, 3.333333, 6.25, 3.333333, 3.333333, 3.333333, 5.521461, 5.241747, 4.115168);
                yield return new Bollen(10, 6.666666, 9.999998, 8.899991, 8.75, 6.666666, 9.999998, 10, 5.828946, 5.370638, 4.446216);
                yield return new Bollen(7.5, 3.333333, 9.999998, 6.666666, 8.75, 3.333333, 9.999998, 6.666666, 5.916202, 6.423247, 3.791545);
                yield return new Bollen(7.5, 3.333333, 6.666666, 6.666666, 8.75, 3.333333, 6.666666, 6.666666, 5.398163, 6.246107, 4.535708);
                yield return new Bollen(7.5, 3.333333, 9.999998, 6.666666, 7.5, 3.333333, 6.666666, 10, 6.622736, 7.872074, 4.906154);
                yield return new Bollen(7.5, 7.766664, 9.999998, 6.666666, 7.5, 0, 9.999998, 0, 5.204007, 5.225747, 4.561047);
                yield return new Bollen(7.5, 9.999998, 3.333333, 10, 7.5, 6.666666, 9.999998, 10, 5.509388, 6.202536, 4.586286);
                yield return new Bollen(7.5, 9.999998, 9.999998, 7.766666, 7.5, 1.1, 6.666666, 6.666666, 5.26269, 5.820083, 3.948911);
                yield return new Bollen(2.5, 3.333333, 6.666666, 6.666666, 5, 1.1, 6.666666, 0.3685, 4.70048, 5.023881, 4.394491);
                yield return new Bollen(1.25, 0, 3.333333, 3.333333, 1.25, 3.333333, 3.333333, 3.333333, 5.209486, 4.465908, 4.510268);
                yield return new Bollen(10, 9.999998, 9.999998, 10, 8.75, 9.999998, 9.999998, 10, 5.916202, 6.732211, 5.829084);
                yield return new Bollen(7.5, 3.333299, 3.333333, 6.666666, 7.5, 2.233299, 6.666666, 2.948164, 6.523562, 6.992096, 6.424591);
                yield return new Bollen(10, 9.999998, 9.999998, 10, 10, 9.999998, 9.999998, 10, 6.238325, 6.746412, 5.741711);
                yield return new Bollen(1.25, 0, 0, 0, 2.5, 0, 0, 0, 5.976351, 6.712956, 5.948168);
                yield return new Bollen(2.5, 0, 3.333333, 3.333333, 2.5, 0, 3.333333, 3.333333, 5.631212, 5.937536, 5.686755);
                yield return new Bollen(7.5, 6.666666, 9.999998, 10, 7.5, 6.666666, 9.999998, 7.766666, 6.033086, 6.09357, 4.611429);
                yield return new Bollen(8.5, 9.999998, 6.666666, 6.666666, 8.75, 9.999998, 7.351018, 6.666666, 6.196444, 6.704414, 5.475261);
                yield return new Bollen(6.1, 0, 5.4, 3.333333, 0, 0, 4.696028, 3.333333, 4.248495, 2.70805, 1.74083);
                yield return new Bollen(3.3, 0, 6.666666, 3.333333, 6.25, 0, 6.666666, 3.333333, 5.141664, 4.564348, 2.255134);
                yield return new Bollen(2.9, 3.333333, 6.666666, 3.333333, 2.385559, 0, 3.177568, 1.116666, 4.174387, 3.688879, 3.046927);
                yield return new Bollen(9.2, 0, 9.9, 3.333333, 7.60966, 0, 8.118828, 3.333333, 4.382027, 2.890372, 1.711279);
                yield return new Bollen(6.9, 0, 6.666666, 3.333333, 4.226033, 0, 0, 0, 4.290459, 1.609438, 1.001674);
                yield return new Bollen(2.9, 0, 3.333333, 3.333333, 5, 0, 3.333333, 3.333333, 4.934474, 4.234107, 1.418971);
                yield return new Bollen(2, 0, 0, 0, 0, 0, 0, 0, 3.850148, 1.94591, 2.345229);
                yield return new Bollen(5, 0, 3.333333, 3.333333, 5, 0, 3.333333, 3.333333, 5.181784, 4.394449, 3.167167);
                yield return new Bollen(5, 0, 9.999998, 3.333333, 0, 0, 3.333333, 0.74437, 5.062595, 4.59512, 3.83497);
                yield return new Bollen(4.1, 9.999998, 4.7, 6.666666, 3.75, 0, 7.827667, 6.666666, 4.691348, 4.143135, 2.255134);
                yield return new Bollen(6.3, 9.999998, 9.999998, 6.666666, 6.25, 2.233333, 6.666666, 2.955702, 4.248495, 3.367296, 3.217506);
                yield return new Bollen(5.2, 4.999998, 6.6, 3.333333, 3.633403, 1.1, 3.314128, 3.333333, 5.56452, 5.236442, 2.677633);
                yield return new Bollen(5, 3.333333, 6.4, 6.666666, 2.844997, 0, 4.429657, 1.485166, 4.727388, 3.610918, 1.418971);
                yield return new Bollen(3.1, 4.999998, 4.2, 5, 3.75, 0, 6.164304, 3.333333, 4.143135, 2.302585, 1.418971);
                yield return new Bollen(4.1, 9.999998, 6.666666, 3.333333, 5, 0, 4.938089, 2.233333, 4.317488, 4.955827, 4.249888);
                yield return new Bollen(5, 9.999998, 6.666666, 1.666666, 5, 0, 6.666666, 0.3685, 5.141664, 4.430817, 3.046927);
                yield return new Bollen(5, 7.7, 6.666666, 8.399997, 6.25, 4.358243, 9.999998, 4.141377, 4.488636, 3.465736, 2.013579);
                yield return new Bollen(5, 6.2, 9.999998, 6.060997, 5, 2.782771, 6.666666, 4.974739, 4.615121, 4.941642, 2.255134);
                yield return new Bollen(5.6, 4.9, 0, 0, 6.555647, 4.055463, 6.666666, 3.821796, 3.850148, 2.397895, 1.74083);
                yield return new Bollen(5.7, 4.8, 0, 0, 6.555647, 4.055463, 0, 0, 3.970292, 2.397895, 1.050741);
                yield return new Bollen(7.5, 9.999998, 7.9, 6.666666, 3.75, 9.999998, 7.631891, 6.666666, 3.78419, 3.091042, 2.113313);
                yield return new Bollen(2.5, 0, 6.666666, 3.333333, 2.5, 0, 0, 0, 3.806662, 2.079442, 2.137561);
                yield return new Bollen(8.9, 9.999998, 9.7, 6.666666, 5, 9.999998, 9.556024, 6.666666, 4.532599, 3.610918, 1.587802);
                yield return new Bollen(7.6, 0, 10, 0, 5, 1.1, 6.666666, 1.099999, 5.117994, 4.934474, 3.83497);
                yield return new Bollen(7.8, 9.999998, 6.666666, 6.666666, 5, 3.333333, 6.666666, 6.666666, 5.049856, 5.111988, 4.38149);
                yield return new Bollen(2.5, 0, 6.666666, 3.333333, 5, 0, 6.666666, 3.333333, 5.393628, 5.638355, 4.169451);
                yield return new Bollen(3.8, 0, 5.1, 0, 3.75, 0, 6.666666, 1.485166, 4.477337, 3.931826, 2.474671);
                yield return new Bollen(5, 3.333333, 3.333333, 2.233333, 5, 3.333333, 6.666666, 5.566663, 5.257495, 5.840642, 5.001796);
                yield return new Bollen(6.25, 3.333333, 9.999998, 2.955702, 6.25, 5.566663, 9.999998, 6.666666, 5.379897, 5.505332, 3.299937);
                yield return new Bollen(1.25, 0, 3.333333, 0, 2.5, 0, 0, 0, 5.298317, 6.274762, 4.38149);
                yield return new Bollen(1.25, 0, 4.7, 0.736999, 2.5, 0, 3.333333, 3.333333, 4.859812, 5.669881, 3.537416);
                yield return new Bollen(1.25, 0, 6.666666, 0, 2.5, 0, 5.228375, 0, 4.969813, 5.56452, 4.510268);
                yield return new Bollen(7.5, 7.766664, 9.999998, 6.666666, 7.5, 3.333333, 9.999998, 6.666666, 6.011267, 6.253829, 5.001796);
                yield return new Bollen(2.5, 0, 6.666666, 4.433333, 5, 0, 6.666666, 1.485166, 5.075174, 5.252273, 5.350708);
                yield return new Bollen(7.5, 9.999998, 9.999998, 10, 8.75, 9.999998, 9.999998, 10, 6.736967, 7.125283, 6.330518);
                yield return new Bollen(1.25, 0, 0, 0, 1.25, 0, 0, 0, 5.225747, 5.451038, 3.167167);
                yield return new Bollen(1.25, 0, 0, 0, 0, 0, 0, 0, 4.025352, 1.791759, 2.657972);
                yield return new Bollen(2.5, 0, 0, 0, 0, 0, 6.666666, 2.948164, 4.234107, 2.70805, 2.474671);
                yield return new Bollen(6.25, 2.233299, 6.666666, 2.970332, 3.75, 3.333299, 6.666666, 3.333333, 4.644391, 5.56452, 3.046927);
                yield return new Bollen(7.5, 9.999998, 9.999998, 10, 7.5, 9.999998, 9.999998, 10, 4.418841, 4.941642, 3.380653);
                yield return new Bollen(5, 0, 6.1, 0, 5, 3.333333, 9.999998, 3.333333, 4.26268, 4.219508, 4.368462);
                yield return new Bollen(7.5, 9.999998, 9.999998, 10, 3.75, 9.999998, 9.999998, 10, 4.875197, 4.70048, 3.83497);
                yield return new Bollen(4.9, 2.233333, 9.999998, 0, 5, 0, 3.621989, 3.333333, 4.189655, 1.386294, 1.418971);
                yield return new Bollen(5, 0, 8.2, 0, 5, 0, 0, 0, 4.521789, 4.127134, 2.113313);
                yield return new Bollen(2.9, 3.333333, 6.666666, 3.333333, 2.5, 3.333333, 6.666666, 3.333333, 4.65396, 3.555348, 1.881917);
                yield return new Bollen(5.4, 9.999998, 6.666666, 3.333333, 3.75, 6.666666, 6.666666, 1.485166, 4.477337, 3.091042, 1.987909);
                yield return new Bollen(7.5, 8.8, 9.999998, 6.066666, 7.5, 6.666666, 9.999998, 6.666666, 5.337538, 5.631212, 3.491004);
                yield return new Bollen(7.5, 7, 9.999998, 6.852998, 7.5, 6.34834, 6.666666, 7.508044, 6.12905, 6.403574, 5.001796);
                yield return new Bollen(10, 6.666666, 9.999998, 10, 10, 6.666666, 9.999998, 10, 5.003946, 4.962845, 3.976994);
                yield return new Bollen(3.75, 3.333333, 0, 0, 1.25, 3.333333, 0, 0, 4.488636, 4.89784, 2.867566);
            }
        }
    }
}
