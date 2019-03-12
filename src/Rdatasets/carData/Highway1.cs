// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Highway Accidents
    /// </summary>

    public class Highway1
    {
        public readonly int κ;
        public readonly double rate;
        public readonly double len;
        public readonly int adt;
        public readonly int trks;
        public readonly double sigs1;
        public readonly int slim;
        public readonly int shld;
        public readonly int lane;
        public readonly double acpt;
        public readonly double itg;
        public readonly int lwid;
        public readonly string htype;

        public Highway1(int κ, double rate, double len, int adt, int trks, double sigs1, int slim, int shld, int lane, double acpt, double itg, int lwid, string htype)
        {
            this.κ = κ;
            this.rate = rate;
            this.len = len;
            this.adt = adt;
            this.trks = trks;
            this.sigs1 = sigs1;
            this.slim = slim;
            this.shld = shld;
            this.lane = lane;
            this.acpt = acpt;
            this.itg = itg;
            this.lwid = lwid;
            this.htype = htype;
        }

        public static IEnumerable<Highway1> Data
        {
            get
            {
                yield return new Highway1(1, 4.58, 4.99, 69, 8, 0.200400801603206, 55, 10, 8, 4.6, 1.2, 12, "FAI");
                yield return new Highway1(2, 2.86, 16.11, 73, 8, 0.0620732464307883, 60, 10, 4, 4.4, 1.43, 12, "FAI");
                yield return new Highway1(3, 3.02, 9.75, 49, 10, 0.102564102564103, 60, 10, 4, 4.7, 1.54, 12, "FAI");
                yield return new Highway1(4, 2.29, 10.65, 61, 13, 0.0938967136150235, 65, 10, 6, 3.8, 0.94, 12, "FAI");
                yield return new Highway1(5, 1.61, 20.01, 28, 12, 0.0499750124937531, 70, 10, 4, 2.2, 0.65, 12, "FAI");
                yield return new Highway1(6, 6.87, 5.97, 30, 6, 2.00750418760469, 55, 10, 4, 24.8, 0.34, 12, "PA");
                yield return new Highway1(7, 3.85, 8.57, 46, 8, 0.816686114352392, 55, 8, 4, 11, 0.47, 12, "PA");
                yield return new Highway1(8, 6.12, 5.24, 25, 9, 0.570839694656489, 55, 10, 4, 18.5, 0.38, 12, "PA");
                yield return new Highway1(9, 3.29, 15.79, 43, 12, 1.45333122229259, 50, 4, 4, 7.5, 0.95, 12, "PA");
                yield return new Highway1(10, 5.88, 8.26, 23, 7, 1.33106537530266, 50, 5, 4, 8.2, 0.12, 12, "PA");
                yield return new Highway1(11, 4.2, 7.03, 23, 6, 1.99224751066856, 60, 10, 4, 5.4, 0.29, 12, "PA");
                yield return new Highway1(12, 4.61, 13.28, 20, 9, 1.28530120481928, 50, 2, 4, 11.2, 0.15, 12, "PA");
                yield return new Highway1(13, 4.8, 5.4, 18, 14, 0.745185185185185, 50, 8, 2, 15.2, 0, 12, "PA");
                yield return new Highway1(14, 3.85, 2.96, 21, 8, 0.337837837837838, 60, 10, 4, 5.4, 0.34, 12, "PA");
                yield return new Highway1(15, 2.69, 11.75, 27, 7, 0.685106382978724, 55, 10, 4, 7.9, 0.26, 12, "PA");
                yield return new Highway1(16, 1.99, 8.86, 22, 9, 0.112866817155756, 60, 10, 4, 3.2, 0.68, 12, "PA");
                yield return new Highway1(17, 2.01, 9.78, 19, 9, 0.202249488752556, 60, 10, 4, 11, 0.2, 12, "PA");
                yield return new Highway1(18, 4.22, 5.49, 9, 11, 0.362149362477231, 50, 6, 2, 8.9, 0.18, 12, "PA");
                yield return new Highway1(19, 2.76, 8.63, 12, 8, 0.115874855156431, 55, 6, 2, 12.4, 0.14, 13, "PA");
                yield return new Highway1(20, 2.55, 20.31, 12, 7, 1.0392368291482, 60, 10, 4, 7.8, 0.05, 12, "PA");
                yield return new Highway1(21, 1.89, 40.09, 15, 13, 0.144943876278374, 55, 8, 4, 9.6, 0.05, 12, "PA");
                yield return new Highway1(22, 2.34, 11.81, 8, 8, 0.0846740050804403, 60, 10, 2, 4.3, 0, 12, "PA");
                yield return new Highway1(23, 2.83, 11.39, 5, 9, 0.177796312554873, 50, 8, 2, 11.1, 0, 12, "PA");
                yield return new Highway1(24, 1.81, 22, 5, 15, 0.0454545454545455, 60, 7, 2, 6.8, 0, 12, "PA");
                yield return new Highway1(25, 9.23, 3.58, 23, 6, 2.78932960893855, 40, 2, 4, 53, 0.56, 12, "MA");
                yield return new Highway1(26, 8.6, 3.23, 13, 6, 1.23959752321981, 45, 2, 2, 17.3, 0.31, 12, "MA");
                yield return new Highway1(27, 8.21, 7.73, 7, 8, 0.649366106080207, 55, 8, 2, 27.3, 0.13, 12, "MA");
                yield return new Highway1(28, 2.93, 14.41, 10, 10, 0.139396252602359, 55, 6, 2, 18, 0, 12, "MA");
                yield return new Highway1(29, 7.48, 11.54, 12, 7, 0.176655112651646, 45, 3, 2, 30.2, 0.09, 12, "MA");
                yield return new Highway1(30, 2.57, 11.1, 9, 8, 0.09009009009009, 60, 7, 2, 10.3, 0, 12, "MA");
                yield return new Highway1(31, 5.77, 22.09, 4, 8, 0.185269352648257, 45, 3, 2, 18.2, 0, 11, "MA");
                yield return new Highway1(32, 2.9, 9.39, 5, 10, 0.106496272630458, 55, 1, 2, 12.3, 0, 13, "MA");
                yield return new Highway1(33, 2.97, 19.49, 4, 13, 0.0513083632632119, 55, 4, 2, 7.1, 0, 12, "MA");
                yield return new Highway1(34, 1.84, 21.01, 5, 12, 0.147596382674917, 55, 8, 2, 14, 0, 10, "MA");
                yield return new Highway1(35, 3.78, 27.16, 2, 10, 0.076818851251841, 55, 3, 2, 11.3, 0.04, 12, "MA");
                yield return new Highway1(36, 2.76, 14.03, 3, 8, 0.0712758374910905, 50, 4, 2, 16.3, 0.07, 12, "MA");
                yield return new Highway1(37, 4.27, 20.63, 1, 11, 0.0484730974309258, 55, 4, 2, 9.6, 0, 11, "MA");
                yield return new Highway1(38, 3.05, 20.06, 3, 11, 0.0498504486540379, 60, 8, 2, 9, 0, 12, "MC");
                yield return new Highway1(39, 4.12, 12.91, 1, 10, 0.0774593338497289, 55, 3, 2, 10.4, 0, 12, "MC");
            }
        }
    }
}
