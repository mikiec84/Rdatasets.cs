// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Labour Training Evaluation Data
    /// </summary>

    public class nsw74psid3
    {
        public readonly int κ;
        public readonly int trt;
        public readonly int age;
        public readonly int educ;
        public readonly int black;
        public readonly int hisp;
        public readonly int marr;
        public readonly int nodeg;
        public readonly double re74;
        public readonly double re75;
        public readonly double re78;

        public nsw74psid3(int κ, int trt, int age, int educ, int black, int hisp, int marr, int nodeg, double re74, double re75, double re78)
        {
            this.κ = κ;
            this.trt = trt;
            this.age = age;
            this.educ = educ;
            this.black = black;
            this.hisp = hisp;
            this.marr = marr;
            this.nodeg = nodeg;
            this.re74 = re74;
            this.re75 = re75;
            this.re78 = re78;
        }

        public static IEnumerable<nsw74psid3> Data
        {
            get
            {
                yield return new nsw74psid3(1, 1, 37, 11, 1, 0, 1, 1, 0, 0, 9930.046);
                yield return new nsw74psid3(2, 1, 22, 9, 0, 1, 0, 1, 0, 0, 3595.894);
                yield return new nsw74psid3(3, 1, 30, 12, 1, 0, 0, 0, 0, 0, 24909.45);
                yield return new nsw74psid3(4, 1, 27, 11, 1, 0, 0, 1, 0, 0, 7506.146);
                yield return new nsw74psid3(5, 1, 33, 8, 1, 0, 0, 1, 0, 0, 289.7899);
                yield return new nsw74psid3(6, 1, 22, 9, 1, 0, 0, 1, 0, 0, 4056.494);
                yield return new nsw74psid3(7, 1, 23, 12, 1, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(8, 1, 32, 11, 1, 0, 0, 1, 0, 0, 8472.158);
                yield return new nsw74psid3(9, 1, 22, 16, 1, 0, 0, 0, 0, 0, 2164.022);
                yield return new nsw74psid3(10, 1, 33, 12, 0, 0, 1, 0, 0, 0, 12418.07);
                yield return new nsw74psid3(11, 1, 19, 9, 1, 0, 0, 1, 0, 0, 8173.908);
                yield return new nsw74psid3(12, 1, 21, 13, 1, 0, 0, 0, 0, 0, 17094.64);
                yield return new nsw74psid3(13, 1, 18, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(14, 1, 27, 10, 1, 0, 1, 1, 0, 0, 18739.93);
                yield return new nsw74psid3(15, 1, 17, 7, 1, 0, 0, 1, 0, 0, 3023.879);
                yield return new nsw74psid3(16, 1, 19, 10, 1, 0, 0, 1, 0, 0, 3228.503);
                yield return new nsw74psid3(17, 1, 27, 13, 1, 0, 0, 0, 0, 0, 14581.86);
                yield return new nsw74psid3(18, 1, 23, 10, 1, 0, 0, 1, 0, 0, 7693.4);
                yield return new nsw74psid3(19, 1, 40, 12, 1, 0, 0, 0, 0, 0, 10804.32);
                yield return new nsw74psid3(20, 1, 26, 12, 1, 0, 0, 0, 0, 0, 10747.35);
                yield return new nsw74psid3(21, 1, 23, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(22, 1, 41, 14, 0, 0, 0, 0, 0, 0, 5149.501);
                yield return new nsw74psid3(23, 1, 38, 9, 0, 0, 0, 1, 0, 0, 6408.95);
                yield return new nsw74psid3(24, 1, 24, 11, 1, 0, 0, 1, 0, 0, 1991.4);
                yield return new nsw74psid3(25, 1, 18, 10, 1, 0, 0, 1, 0, 0, 11163.17);
                yield return new nsw74psid3(26, 1, 29, 11, 1, 0, 1, 1, 0, 0, 9642.999);
                yield return new nsw74psid3(27, 1, 25, 11, 1, 0, 0, 1, 0, 0, 9897.049);
                yield return new nsw74psid3(28, 1, 27, 10, 0, 1, 0, 1, 0, 0, 11142.87);
                yield return new nsw74psid3(29, 1, 17, 10, 1, 0, 0, 1, 0, 0, 16218.04);
                yield return new nsw74psid3(30, 1, 24, 11, 1, 0, 0, 1, 0, 0, 995.7002);
                yield return new nsw74psid3(31, 1, 17, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(32, 1, 48, 4, 1, 0, 0, 1, 0, 0, 6551.592);
                yield return new nsw74psid3(33, 1, 25, 11, 1, 0, 1, 1, 0, 0, 1574.424);
                yield return new nsw74psid3(34, 1, 20, 12, 1, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(35, 1, 25, 12, 1, 0, 0, 0, 0, 0, 3191.753);
                yield return new nsw74psid3(36, 1, 42, 14, 1, 0, 0, 0, 0, 0, 20505.93);
                yield return new nsw74psid3(37, 1, 25, 5, 1, 0, 0, 1, 0, 0, 6181.88);
                yield return new nsw74psid3(38, 1, 23, 12, 1, 0, 1, 0, 0, 0, 5911.551);
                yield return new nsw74psid3(39, 1, 46, 8, 1, 0, 1, 1, 0, 0, 3094.156);
                yield return new nsw74psid3(40, 1, 24, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(41, 1, 21, 12, 1, 0, 0, 0, 0, 0, 1254.582);
                yield return new nsw74psid3(42, 1, 19, 9, 0, 0, 0, 1, 0, 0, 13188.83);
                yield return new nsw74psid3(43, 1, 17, 8, 1, 0, 0, 1, 0, 0, 8061.485);
                yield return new nsw74psid3(44, 1, 18, 8, 0, 1, 1, 1, 0, 0, 2787.96);
                yield return new nsw74psid3(45, 1, 20, 11, 1, 0, 0, 1, 0, 0, 3972.54);
                yield return new nsw74psid3(46, 1, 25, 11, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(47, 1, 17, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(48, 1, 17, 9, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(49, 1, 25, 5, 1, 0, 0, 1, 0, 0, 12187.41);
                yield return new nsw74psid3(50, 1, 23, 12, 1, 0, 0, 0, 0, 0, 4843.176);
                yield return new nsw74psid3(51, 1, 28, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(52, 1, 31, 11, 1, 0, 1, 1, 0, 0, 8087.487);
                yield return new nsw74psid3(53, 1, 18, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(54, 1, 25, 12, 1, 0, 0, 0, 0, 0, 2348.973);
                yield return new nsw74psid3(55, 1, 30, 11, 1, 0, 1, 1, 0, 0, 590.7818);
                yield return new nsw74psid3(56, 1, 17, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(57, 1, 37, 9, 1, 0, 0, 1, 0, 0, 1067.506);
                yield return new nsw74psid3(58, 1, 41, 4, 1, 0, 1, 1, 0, 0, 7284.986);
                yield return new nsw74psid3(59, 1, 42, 14, 1, 0, 1, 0, 0, 0, 13167.52);
                yield return new nsw74psid3(60, 1, 22, 11, 0, 0, 0, 1, 0, 0, 1048.432);
                yield return new nsw74psid3(61, 1, 17, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(62, 1, 29, 8, 1, 0, 0, 1, 0, 0, 1923.938);
                yield return new nsw74psid3(63, 1, 35, 10, 1, 0, 0, 1, 0, 0, 4666.236);
                yield return new nsw74psid3(64, 1, 27, 11, 1, 0, 0, 1, 0, 0, 549.2984);
                yield return new nsw74psid3(65, 1, 29, 4, 1, 0, 0, 1, 0, 0, 762.9146);
                yield return new nsw74psid3(66, 1, 28, 9, 1, 0, 0, 1, 0, 0, 10694.29);
                yield return new nsw74psid3(67, 1, 27, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(68, 1, 23, 7, 0, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(69, 1, 45, 5, 1, 0, 1, 1, 0, 0, 8546.715);
                yield return new nsw74psid3(70, 1, 29, 13, 1, 0, 0, 0, 0, 0, 7479.656);
                yield return new nsw74psid3(71, 1, 27, 9, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(72, 1, 46, 13, 1, 0, 0, 0, 0, 0, 647.2046);
                yield return new nsw74psid3(73, 1, 18, 6, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(74, 1, 25, 12, 1, 0, 0, 0, 0, 0, 11965.81);
                yield return new nsw74psid3(75, 1, 28, 15, 1, 0, 0, 0, 0, 0, 9598.541);
                yield return new nsw74psid3(76, 1, 25, 11, 0, 0, 0, 1, 0, 0, 18783.35);
                yield return new nsw74psid3(77, 1, 22, 12, 1, 0, 0, 0, 0, 0, 18678.08);
                yield return new nsw74psid3(78, 1, 21, 9, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(79, 1, 40, 11, 1, 0, 0, 1, 0, 0, 23005.6);
                yield return new nsw74psid3(80, 1, 22, 11, 1, 0, 0, 1, 0, 0, 6456.697);
                yield return new nsw74psid3(81, 1, 25, 12, 1, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(82, 1, 18, 12, 1, 0, 0, 0, 0, 0, 2321.107);
                yield return new nsw74psid3(83, 1, 38, 12, 0, 0, 0, 0, 0, 0, 4941.849);
                yield return new nsw74psid3(84, 1, 27, 13, 1, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(85, 1, 27, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(86, 1, 38, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(87, 1, 23, 8, 0, 1, 0, 1, 0, 0, 3881.284);
                yield return new nsw74psid3(88, 1, 26, 11, 1, 0, 0, 1, 0, 0, 17230.96);
                yield return new nsw74psid3(89, 1, 21, 12, 0, 0, 0, 0, 0, 0, 8048.603);
                yield return new nsw74psid3(90, 1, 25, 8, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(91, 1, 31, 11, 1, 0, 1, 1, 0, 0, 14509.93);
                yield return new nsw74psid3(92, 1, 17, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(93, 1, 25, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(94, 1, 21, 12, 1, 0, 0, 0, 0, 0, 9983.784);
                yield return new nsw74psid3(95, 1, 44, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(96, 1, 25, 12, 0, 0, 0, 0, 0, 0, 5587.503);
                yield return new nsw74psid3(97, 1, 18, 9, 1, 0, 0, 1, 0, 0, 4482.845);
                yield return new nsw74psid3(98, 1, 42, 12, 1, 0, 0, 0, 0, 0, 2456.153);
                yield return new nsw74psid3(99, 1, 25, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(100, 1, 31, 9, 0, 1, 0, 1, 0, 0, 26817.6);
                yield return new nsw74psid3(101, 1, 24, 10, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(102, 1, 26, 10, 1, 0, 0, 1, 0, 0, 9265.788);
                yield return new nsw74psid3(103, 1, 25, 11, 1, 0, 0, 1, 0, 0, 485.2298);
                yield return new nsw74psid3(104, 1, 18, 11, 1, 0, 0, 1, 0, 0, 4814.627);
                yield return new nsw74psid3(105, 1, 19, 11, 1, 0, 0, 1, 0, 0, 7458.105);
                yield return new nsw74psid3(106, 1, 43, 9, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(107, 1, 27, 13, 1, 0, 0, 0, 0, 0, 34099.28);
                yield return new nsw74psid3(108, 1, 17, 9, 1, 0, 0, 1, 0, 0, 1953.268);
                yield return new nsw74psid3(109, 1, 30, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(110, 1, 26, 10, 1, 0, 1, 1, 2027.999, 0, 0);
                yield return new nsw74psid3(111, 1, 20, 9, 1, 0, 0, 1, 6083.994, 0, 8881.665);
                yield return new nsw74psid3(112, 1, 17, 9, 0, 1, 0, 1, 445.1704, 74.34345, 6210.67);
                yield return new nsw74psid3(113, 1, 20, 12, 1, 0, 0, 0, 989.2678, 165.2077, 0);
                yield return new nsw74psid3(114, 1, 18, 11, 1, 0, 0, 1, 858.2543, 214.5636, 929.8839);
                yield return new nsw74psid3(115, 1, 27, 12, 1, 0, 1, 0, 3670.872, 334.0493, 0);
                yield return new nsw74psid3(116, 1, 21, 12, 0, 0, 0, 0, 3670.872, 334.0494, 12558.02);
                yield return new nsw74psid3(117, 1, 27, 12, 1, 0, 0, 0, 2143.413, 357.9499, 22163.25);
                yield return new nsw74psid3(118, 1, 20, 12, 1, 0, 0, 0, 0, 377.5686, 1652.637);
                yield return new nsw74psid3(119, 1, 19, 10, 1, 0, 0, 1, 0, 385.2741, 8124.715);
                yield return new nsw74psid3(120, 1, 23, 12, 1, 0, 0, 0, 5506.308, 501.0741, 671.3318);
                yield return new nsw74psid3(121, 1, 29, 14, 1, 0, 0, 0, 0, 679.6734, 17814.98);
                yield return new nsw74psid3(122, 1, 18, 10, 1, 0, 0, 1, 0, 798.9079, 9737.154);
                yield return new nsw74psid3(123, 1, 19, 9, 1, 0, 0, 1, 0, 798.9079, 17685.18);
                yield return new nsw74psid3(124, 1, 27, 13, 0, 0, 1, 0, 9381.566, 853.7225, 0);
                yield return new nsw74psid3(125, 1, 18, 11, 0, 0, 0, 1, 3678.231, 919.5579, 4321.705);
                yield return new nsw74psid3(126, 1, 27, 9, 1, 0, 1, 1, 0, 934.4454, 1773.423);
                yield return new nsw74psid3(127, 1, 22, 12, 1, 0, 0, 0, 5605.852, 936.1773, 0);
                yield return new nsw74psid3(128, 1, 23, 10, 1, 0, 1, 1, 0, 936.4386, 11233.26);
                yield return new nsw74psid3(129, 1, 23, 12, 0, 1, 0, 0, 9385.74, 1117.439, 559.4432);
                yield return new nsw74psid3(130, 1, 20, 11, 1, 0, 0, 1, 3637.498, 1220.836, 1085.44);
                yield return new nsw74psid3(131, 1, 17, 9, 1, 0, 0, 1, 1716.509, 1253.439, 5445.2);
                yield return new nsw74psid3(132, 1, 28, 11, 1, 0, 0, 1, 0, 1284.079, 60307.93);
                yield return new nsw74psid3(133, 1, 26, 11, 1, 0, 1, 1, 0, 1392.853, 1460.36);
                yield return new nsw74psid3(134, 1, 20, 11, 1, 0, 0, 1, 16318.62, 1484.994, 6943.342);
                yield return new nsw74psid3(135, 1, 24, 11, 1, 0, 1, 1, 824.3886, 1666.113, 4032.708);
                yield return new nsw74psid3(136, 1, 31, 9, 1, 0, 0, 1, 0, 1698.607, 10363.27);
                yield return new nsw74psid3(137, 1, 23, 8, 0, 0, 1, 1, 0, 1713.15, 4232.309);
                yield return new nsw74psid3(138, 1, 18, 10, 1, 0, 0, 1, 2143.411, 1784.274, 11141.39);
                yield return new nsw74psid3(139, 1, 29, 12, 1, 0, 0, 0, 10881.94, 1817.284, 0);
                yield return new nsw74psid3(140, 1, 26, 11, 0, 0, 0, 1, 0, 2226.266, 13385.86);
                yield return new nsw74psid3(141, 1, 24, 9, 1, 0, 0, 1, 9154.7, 2288.675, 4849.559);
                yield return new nsw74psid3(142, 1, 25, 12, 1, 0, 0, 0, 14426.79, 2409.274, 0);
                yield return new nsw74psid3(143, 1, 24, 10, 1, 0, 0, 1, 4250.402, 2421.947, 1660.508);
                yield return new nsw74psid3(144, 1, 46, 8, 1, 0, 0, 1, 3165.658, 2594.723, 0);
                yield return new nsw74psid3(145, 1, 31, 12, 0, 0, 0, 0, 0, 2611.218, 2484.549);
                yield return new nsw74psid3(146, 1, 19, 11, 1, 0, 0, 1, 2305.026, 2615.276, 4146.603);
                yield return new nsw74psid3(147, 1, 19, 8, 1, 0, 0, 1, 0, 2657.057, 9970.681);
                yield return new nsw74psid3(148, 1, 27, 11, 1, 0, 0, 1, 2206.94, 2666.274, 0);
                yield return new nsw74psid3(149, 1, 26, 11, 1, 0, 1, 1, 0, 2754.646, 26372.28);
                yield return new nsw74psid3(150, 1, 20, 10, 1, 0, 0, 1, 5005.731, 2777.355, 5615.189);
                yield return new nsw74psid3(151, 1, 28, 10, 1, 0, 0, 1, 0, 2836.506, 3196.571);
                yield return new nsw74psid3(152, 1, 24, 12, 1, 0, 0, 0, 13765.75, 2842.764, 6167.681);
                yield return new nsw74psid3(153, 1, 19, 8, 1, 0, 0, 1, 2636.353, 2937.264, 7535.942);
                yield return new nsw74psid3(154, 1, 23, 12, 1, 0, 0, 0, 6269.341, 3039.96, 8484.239);
                yield return new nsw74psid3(155, 1, 42, 9, 1, 0, 1, 1, 0, 3058.531, 1294.409);
                yield return new nsw74psid3(156, 1, 25, 13, 1, 0, 0, 0, 12362.93, 3090.732, 0);
                yield return new nsw74psid3(157, 1, 18, 9, 1, 0, 0, 1, 0, 3287.375, 5010.342);
                yield return new nsw74psid3(158, 1, 21, 12, 1, 0, 0, 0, 6473.683, 3332.409, 9371.037);
                yield return new nsw74psid3(159, 1, 27, 10, 1, 0, 0, 1, 1001.146, 3550.075, 0);
                yield return new nsw74psid3(160, 1, 21, 8, 1, 0, 0, 1, 989.2678, 3695.897, 4279.613);
                yield return new nsw74psid3(161, 1, 22, 9, 1, 0, 0, 1, 2192.877, 3836.986, 3462.564);
                yield return new nsw74psid3(162, 1, 31, 4, 1, 0, 0, 1, 8517.589, 4023.211, 7382.549);
                yield return new nsw74psid3(163, 1, 24, 10, 1, 0, 1, 1, 11703.2, 4078.152, 0);
                yield return new nsw74psid3(164, 1, 29, 10, 1, 0, 0, 1, 0, 4398.95, 0);
                yield return new nsw74psid3(165, 1, 29, 12, 1, 0, 0, 0, 9748.387, 4878.937, 10976.51);
                yield return new nsw74psid3(166, 1, 19, 10, 0, 0, 0, 1, 0, 5324.109, 13829.62);
                yield return new nsw74psid3(167, 1, 19, 11, 0, 1, 1, 1, 5424.485, 5463.803, 6788.463);
                yield return new nsw74psid3(168, 1, 31, 9, 1, 0, 0, 1, 10717.03, 5517.841, 9558.501);
                yield return new nsw74psid3(169, 1, 22, 10, 1, 0, 1, 1, 1468.348, 5588.664, 13228.28);
                yield return new nsw74psid3(170, 1, 21, 9, 1, 0, 0, 1, 6416.47, 5749.331, 743.6666);
                yield return new nsw74psid3(171, 1, 17, 10, 1, 0, 0, 1, 1291.468, 5793.852, 5522.788);
                yield return new nsw74psid3(172, 1, 26, 12, 1, 0, 1, 0, 8408.762, 5794.831, 1424.944);
                yield return new nsw74psid3(173, 1, 20, 9, 0, 1, 0, 1, 12260.78, 5875.049, 1358.643);
                yield return new nsw74psid3(174, 1, 19, 10, 1, 0, 0, 1, 4121.949, 6056.754, 0);
                yield return new nsw74psid3(175, 1, 26, 10, 1, 0, 0, 1, 25929.68, 6788.958, 672.8773);
                yield return new nsw74psid3(176, 1, 28, 11, 1, 0, 0, 1, 1929.029, 6871.856, 0);
                yield return new nsw74psid3(177, 1, 22, 12, 0, 1, 1, 0, 492.2305, 7055.702, 10092.83);
                yield return new nsw74psid3(178, 1, 33, 11, 1, 0, 0, 1, 0, 7867.916, 6281.433);
                yield return new nsw74psid3(179, 1, 22, 12, 0, 0, 0, 0, 6759.994, 8455.504, 12590.71);
                yield return new nsw74psid3(180, 1, 29, 10, 0, 1, 0, 1, 0, 8853.674, 5112.014);
                yield return new nsw74psid3(181, 1, 33, 12, 1, 0, 1, 0, 20279.95, 10941.35, 15952.6);
                yield return new nsw74psid3(182, 1, 25, 14, 1, 0, 1, 0, 35040.07, 11536.57, 36646.95);
                yield return new nsw74psid3(183, 1, 35, 9, 1, 0, 1, 1, 13602.43, 13830.64, 12803.97);
                yield return new nsw74psid3(184, 1, 35, 8, 1, 0, 1, 1, 13732.07, 17976.15, 3786.628);
                yield return new nsw74psid3(185, 1, 33, 11, 1, 0, 1, 1, 14660.71, 25142.24, 4181.942);
                yield return new nsw74psid3(186, 0, 46, 6, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(187, 0, 45, 7, 1, 0, 1, 1, 0, 0, 11821.813);
                yield return new nsw74psid3(188, 0, 45, 9, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(189, 0, 49, 14, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(190, 0, 53, 6, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(191, 0, 47, 12, 0, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(192, 0, 47, 8, 0, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(193, 0, 52, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(194, 0, 40, 10, 0, 1, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(195, 0, 55, 14, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(196, 0, 54, 3, 1, 0, 0, 1, 0, 0, 221.65899);
                yield return new nsw74psid3(197, 0, 50, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(198, 0, 52, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(199, 0, 25, 11, 1, 0, 0, 1, 0, 0, 3694.3164);
                yield return new nsw74psid3(200, 0, 46, 9, 0, 1, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(201, 0, 48, 9, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(202, 0, 44, 12, 0, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(203, 0, 26, 17, 0, 0, 1, 0, 0, 0, 11821.813);
                yield return new nsw74psid3(204, 0, 51, 5, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(205, 0, 34, 16, 0, 0, 1, 0, 0, 0, 11821.813);
                yield return new nsw74psid3(206, 0, 41, 6, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(207, 0, 55, 8, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(208, 0, 46, 9, 0, 1, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(209, 0, 55, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(210, 0, 34, 14, 1, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(211, 0, 28, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(212, 0, 54, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(213, 0, 53, 7, 0, 1, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(214, 0, 54, 10, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(215, 0, 55, 12, 0, 1, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(216, 0, 53, 8, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(217, 0, 47, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(218, 0, 55, 13, 0, 1, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(219, 0, 41, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(220, 0, 45, 9, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(221, 0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(222, 0, 54, 9, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(223, 0, 54, 10, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(224, 0, 53, 4, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(225, 0, 25, 12, 1, 0, 0, 0, 0, 0, 0);
                yield return new nsw74psid3(226, 0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(227, 0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(228, 0, 44, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(229, 0, 51, 4, 1, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(230, 0, 45, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new nsw74psid3(231, 0, 41, 11, 0, 0, 1, 1, 0, 0, 14481.72);
                yield return new nsw74psid3(232, 0, 23, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(233, 0, 50, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new nsw74psid3(234, 0, 23, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new nsw74psid3(235, 0, 23, 12, 1, 0, 0, 0, 0, 0, 4728.725);
                yield return new nsw74psid3(236, 0, 21, 13, 0, 0, 0, 0, 0, 692.85484, 2659.9078);
                yield return new nsw74psid3(237, 0, 23, 14, 0, 0, 0, 0, 0, 3401.6129, 5319.8157);
                yield return new nsw74psid3(238, 0, 25, 12, 1, 0, 1, 0, 0, 21483.871, 1220.6022);
                yield return new nsw74psid3(239, 0, 43, 3, 1, 0, 1, 1, 17.633401, 0, 0);
                yield return new nsw74psid3(240, 0, 52, 6, 1, 0, 1, 1, 235.11202, 1246.0645, 1477.7266);
                yield return new nsw74psid3(241, 0, 54, 8, 0, 0, 1, 1, 293.89002, 537.09677, 295.54531);
                yield return new nsw74psid3(242, 0, 52, 7, 1, 0, 0, 1, 293.89002, 5012.9032, 0);
                yield return new nsw74psid3(243, 0, 24, 12, 1, 0, 0, 0, 783.70672, 0, 10344.086);
                yield return new nsw74psid3(244, 0, 22, 13, 0, 0, 0, 0, 783.70672, 0, 2305.2535);
                yield return new nsw74psid3(245, 0, 23, 12, 1, 0, 0, 0, 1077.5967, 3222.5806, 5910.9063);
                yield return new nsw74psid3(246, 0, 22, 12, 1, 0, 1, 0, 1269.6049, 0, 0);
                yield return new nsw74psid3(247, 0, 24, 17, 0, 0, 1, 0, 1371.4868, 0, 24825.806);
                yield return new nsw74psid3(248, 0, 31, 6, 1, 0, 0, 1, 1410.6721, 555, 16059.932);
                yield return new nsw74psid3(249, 0, 27, 16, 0, 0, 1, 0, 1469.4501, 1253.2258, 4363.7266);
                yield return new nsw74psid3(250, 0, 19, 11, 1, 0, 0, 1, 1567.4134, 0, 0);
                yield return new nsw74psid3(251, 0, 35, 9, 1, 0, 0, 1, 1567.4134, 5370.9677, 5910.9063);
                yield return new nsw74psid3(252, 0, 21, 12, 1, 0, 0, 0, 1959.2668, 5460.4839, 1152.6267);
                yield return new nsw74psid3(253, 0, 22, 12, 1, 0, 1, 0, 2006.2892, 2470.6452, 0);
                yield return new nsw74psid3(254, 0, 23, 13, 0, 0, 1, 0, 2155.1935, 5370.9677, 11378.495);
                yield return new nsw74psid3(255, 0, 19, 14, 0, 0, 0, 0, 2938.9002, 3222.5806, 0);
                yield return new nsw74psid3(256, 0, 40, 4, 1, 0, 0, 1, 2962.4114, 1933.5484, 1034.4086);
                yield return new nsw74psid3(257, 0, 22, 9, 1, 0, 0, 1, 3134.8269, 4345.1129, 13299.539);
                yield return new nsw74psid3(258, 0, 23, 15, 0, 0, 1, 0, 3320.9572, 2506.4516, 9974.6544);
                yield return new nsw74psid3(259, 0, 19, 6, 1, 0, 0, 1, 3526.6802, 0, 0);
                yield return new nsw74psid3(260, 0, 27, 15, 0, 0, 1, 0, 3722.6069, 4654.8387, 19210.445);
                yield return new nsw74psid3(261, 0, 27, 12, 1, 0, 1, 0, 3918.5336, 1994.4194, 17732.719);
                yield return new nsw74psid3(262, 0, 43, 10, 1, 0, 1, 1, 3918.5336, 2148.3871, 0);
                yield return new nsw74psid3(263, 0, 20, 12, 0, 0, 0, 0, 4811.9593, 716.12903, 0);
                yield return new nsw74psid3(264, 0, 52, 12, 0, 0, 1, 0, 4898.167, 0, 0);
                yield return new nsw74psid3(265, 0, 24, 11, 1, 0, 1, 1, 5427.169, 0, 1329.9539);
                yield return new nsw74psid3(266, 0, 38, 10, 1, 0, 1, 1, 5877.8004, 0, 0);
                yield return new nsw74psid3(267, 0, 24, 9, 1, 0, 0, 1, 5877.8004, 5370.9677, 13299.539);
                yield return new nsw74psid3(268, 0, 32, 11, 1, 0, 1, 1, 6524.3585, 0, 930.96774);
                yield return new nsw74psid3(269, 0, 22, 13, 0, 0, 0, 0, 6857.4338, 6266.129, 17363.287);
                yield return new nsw74psid3(270, 0, 21, 14, 0, 0, 1, 0, 6974.9898, 11407.935, 17141.628);
                yield return new nsw74psid3(271, 0, 29, 10, 0, 0, 1, 1, 7347.2505, 0, 0);
                yield return new nsw74psid3(272, 0, 54, 12, 0, 0, 1, 0, 7445.2138, 0, 0);
                yield return new nsw74psid3(273, 0, 33, 13, 0, 0, 0, 0, 7837.0672, 3580.6452, 16254.992);
                yield return new nsw74psid3(274, 0, 27, 11, 1, 0, 1, 1, 7837.0672, 5370.9677, 7388.6329);
                yield return new nsw74psid3(275, 0, 21, 11, 1, 0, 1, 1, 8032.9939, 4848.1935, 8570.8141);
                yield return new nsw74psid3(276, 0, 54, 6, 1, 0, 1, 1, 8354.3136, 0, 0);
                yield return new nsw74psid3(277, 0, 23, 9, 0, 0, 1, 1, 9012.6273, 0, 14777.266);
                yield return new nsw74psid3(278, 0, 24, 12, 0, 0, 1, 0, 9371.1731, 2864.5161, 2216.5899);
                yield return new nsw74psid3(279, 0, 20, 13, 0, 1, 0, 0, 9404.4807, 0, 8275.2688);
                yield return new nsw74psid3(280, 0, 26, 12, 0, 0, 1, 0, 9561.222, 0, 13299.539);
                yield return new nsw74psid3(281, 0, 27, 12, 1, 0, 1, 0, 9796.334, 0, 11821.813);
                yield return new nsw74psid3(282, 0, 29, 12, 1, 0, 1, 0, 9796.334, 12532.258, 19210.445);
                yield return new nsw74psid3(283, 0, 32, 10, 1, 0, 0, 1, 10188.187, 8951.6129, 0);
                yield return new nsw74psid3(284, 0, 47, 8, 0, 1, 1, 1, 10286.151, 7161.2903, 1477.7266);
                yield return new nsw74psid3(285, 0, 26, 12, 1, 0, 1, 0, 11167.821, 1074.1935, 8866.3594);
                yield return new nsw74psid3(286, 0, 43, 12, 0, 0, 1, 0, 11755.601, 0, 295.54531);
                yield return new nsw74psid3(287, 0, 34, 11, 1, 0, 0, 1, 11755.601, 2148.3871, 15516.129);
                yield return new nsw74psid3(288, 0, 53, 12, 0, 0, 1, 0, 11755.601, 9893.3226, 5172.043);
                yield return new nsw74psid3(289, 0, 42, 13, 0, 0, 1, 0, 13701.153, 0, 33987.711);
                yield return new nsw74psid3(290, 0, 22, 12, 1, 0, 1, 0, 13714.868, 0, 664.97696);
                yield return new nsw74psid3(291, 0, 47, 12, 0, 0, 1, 0, 13714.868, 0, 12560.676);
                yield return new nsw74psid3(292, 0, 26, 12, 0, 0, 1, 0, 13714.868, 716.12903, 22904.762);
                yield return new nsw74psid3(293, 0, 53, 5, 1, 0, 1, 1, 14008.758, 2660.4194, 11082.949);
                yield return new nsw74psid3(294, 0, 54, 8, 0, 1, 1, 1, 14302.648, 0, 8866.3594);
                yield return new nsw74psid3(295, 0, 54, 8, 0, 1, 1, 1, 14302.648, 0, 8866.3594);
                yield return new nsw74psid3(296, 0, 37, 13, 0, 0, 1, 0, 14694.501, 8951.6129, 17732.719);
                yield return new nsw74psid3(297, 0, 49, 8, 0, 1, 0, 1, 15674.134, 1074.1935, 0);
                yield return new nsw74psid3(298, 0, 21, 13, 0, 0, 0, 0, 15674.134, 4946.6613, 1733.3733);
                yield return new nsw74psid3(299, 0, 18, 10, 0, 1, 1, 1, 15674.134, 10741.935, 20688.172);
                yield return new nsw74psid3(300, 0, 54, 12, 0, 0, 1, 0, 15674.134, 25064.516, 0);
                yield return new nsw74psid3(301, 0, 54, 12, 0, 0, 1, 0, 15674.134, 25064.516, 0);
                yield return new nsw74psid3(302, 0, 53, 4, 1, 0, 1, 1, 16142.399, 984.67742, 0);
                yield return new nsw74psid3(303, 0, 45, 4, 0, 1, 1, 1, 16261.914, 28108.065, 28076.805);
                yield return new nsw74psid3(304, 0, 25, 12, 0, 0, 1, 0, 16653.768, 12181.355, 17732.719);
                yield return new nsw74psid3(305, 0, 46, 10, 0, 1, 1, 1, 17633.401, 10741.935, 5910.9063);
                yield return new nsw74psid3(306, 0, 26, 12, 0, 1, 1, 0, 19055.829, 0, 13299.539);
                yield return new nsw74psid3(307, 0, 21, 12, 1, 0, 0, 0, 19592.668, 716.12903, 22165.899);
                yield return new nsw74psid3(308, 0, 48, 10, 0, 0, 1, 1, 23511.202, 2864.5161, 0);
                yield return new nsw74psid3(309, 0, 46, 12, 0, 0, 0, 0, 23918.729, 12532.258, 0);
                yield return new nsw74psid3(310, 0, 26, 16, 0, 0, 0, 0, 24490.835, 27750, 9605.2227);
                yield return new nsw74psid3(311, 0, 48, 8, 0, 0, 1, 1, 25470.468, 0, 13299.539);
                yield return new nsw74psid3(312, 0, 50, 12, 0, 0, 1, 0, 26254.175, 0, 0);
                yield return new nsw74psid3(313, 0, 41, 13, 0, 0, 0, 0, 29389.002, 0, 30293.395);
            }
        }
    }
}
