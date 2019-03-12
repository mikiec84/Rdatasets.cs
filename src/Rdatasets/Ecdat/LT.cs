// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Dollar Sterling Exchange Rate
    /// </summary>

    public class LT
    {
        public readonly int κ;
        public readonly double s;
        public readonly double uswpi;
        public readonly double ukwpi;

        public LT(int κ, double s, double uswpi, double ukwpi)
        {
            this.κ = κ;
            this.s = s;
            this.uswpi = uswpi;
            this.ukwpi = ukwpi;
        }

        public static IEnumerable<LT> Data
        {
            get
            {
                yield return new LT(1, 4.5802, 85.6, 110.6);
                yield return new LT(2, 4.4925, 93.7, 108.7);
                yield return new LT(3, 4.5353, 102.7, 119.2);
                yield return new LT(4, 4.7765, 108.8, 121.5);
                yield return new LT(5, 4.573, 131.9, 141.7);
                yield return new LT(6, 4.3114, 147, 143.2);
                yield return new LT(7, 4.4625, 131.9, 130.9);
                yield return new LT(8, 4.4142, 122.9, 133.1);
                yield return new LT(9, 4.1563, 126.9, 153.7);
                yield return new LT(10, 4.5746, 129.9, 186.2);
                yield return new LT(11, 4.4067, 143.1, 192);
                yield return new LT(12, 4.5111, 117.9, 150.7);
                yield return new LT(13, 4.5673, 118.8, 152.4);
                yield return new LT(14, 4.5785, 127.1, 153.3);
                yield return new LT(15, 4.3732, 142.2, 167.9);
                yield return new LT(16, 4.4589, 135.1, 165.9);
                yield return new LT(17, 4.4516, 131, 161.8);
                yield return new LT(18, 4.6531, 116, 178.2);
                yield return new LT(19, 4.6008, 131, 191.1);
                yield return new LT(20, 4.3244, 131.9, 189.2);
                yield return new LT(21, 3.8389, 127.1, 179.3);
                yield return new LT(22, 3.6374, 131.9, 201.8);
                yield return new LT(23, 3.7717, 162.7, 208.3);
                yield return new LT(24, 4.2647, 183.5, 189.5);
                yield return new LT(25, 4.7237, 171.3, 160.2);
                yield return new LT(26, 5.2544, 152.1, 146.2);
                yield return new LT(27, 4.6289, 152.1, 162.7);
                yield return new LT(28, 4.5261, 148.2, 171);
                yield return new LT(29, 4.5393, 125.9, 158);
                yield return new LT(30, 4.5484, 106.9, 142.4);
                yield return new LT(31, 4.8491, 106.9, 122.9);
                yield return new LT(32, 5.0071, 106.9, 108.4);
                yield return new LT(33, 4.828, 103.7, 120.3);
                yield return new LT(34, 4.878, 98.9, 125.7);
                yield return new LT(35, 4.84, 103.7, 139.4);
                yield return new LT(36, 4.9309, 99.7, 123.3);
                yield return new LT(37, 4.9468, 98.9, 122.5);
                yield return new LT(38, 4.9395, 97.7, 118.8);
                yield return new LT(39, 4.8772, 96.8, 118.2);
                yield return new LT(40, 4.786, 91.7, 116.6);
                yield return new LT(41, 4.8629, 94.5, 117.5);
                yield return new LT(42, 4.8697, 95.7, 112.8);
                yield return new LT(43, 4.8169, 95.7, 109.2);
                yield return new LT(44, 4.6033, 90.6, 106.6);
                yield return new LT(45, 4.862, 100.9, 104.2);
                yield return new LT(46, 4.8294, 114.9, 117.4);
                yield return new LT(47, 4.9717, 116, 116.3);
                yield return new LT(48, 4.88, 110.8, 120.7);
                yield return new LT(49, 4.8946, 112.8, 128.7);
                yield return new LT(50, 4.8198, 95.7, 126.4);
                yield return new LT(51, 4.8925, 92.6, 120.4);
                yield return new LT(52, 4.7834, 82.6, 109.5);
                yield return new LT(53, 4.7997, 75.5, 98.3);
                yield return new LT(54, 4.8716, 77.5, 100);
                yield return new LT(55, 4.8834, 83.7, 102.7);
                yield return new LT(56, 4.8278, 83.7, 106.1);
                yield return new LT(57, 4.8054, 90.6, 119.4);
                yield return new LT(58, 4.8806, 82.6, 100.9);
                yield return new LT(59, 4.826, 82.6, 91.1);
                yield return new LT(60, 4.8868, 84.6, 90.6);
                yield return new LT(61, 4.9292, 83.7, 88.2);
                yield return new LT(62, 4.9142, 88.6, 91.8);
                yield return new LT(63, 4.8998, 97.7, 111.8);
                yield return new LT(64, 4.8948, 108.9, 120.1);
                yield return new LT(65, 4.8974, 110.8, 118.8);
                yield return new LT(66, 4.9184, 105.7, 118.8);
                yield return new LT(67, 4.9007, 111.9, 123.5);
                yield return new LT(68, 4.8663, 93.8, 107.1);
                yield return new LT(69, 4.9157, 97, 110.6);
                yield return new LT(70, 4.8657, 93.8, 116.6);
                yield return new LT(71, 4.7896, 89.7, 115.3);
                yield return new LT(72, 5.0848, 104.8, 118.8);
                yield return new LT(73, 6.8131, 133.9, 121.2);
                yield return new LT(74, 7.5752, 194.5, 123.5);
                yield return new LT(75, 7.5762, 186.3, 118.8);
                yield return new LT(76, 6.1759, 175.2, 120.1);
                yield return new LT(77, 6.2329, 163.3, 117.7);
                yield return new LT(78, 6.37, 159.2, 116.6);
                yield return new LT(79, 6.2033, 152.1, 115.3);
                yield return new LT(80, 5.4554, 136, 113);
                yield return new LT(81, 5.3147, 131, 117.7);
                yield return new LT(82, 5.2704, 137, 128.3);
                yield return new LT(83, 5.4762, 133.9, 130.6);
                yield return new LT(84, 5.3475, 127.1, 120.1);
                yield return new LT(85, 5.4331, 118.8, 113);
                yield return new LT(86, 5.3696, 110.8, 111.8);
                yield return new LT(87, 5.0776, 106.9, 110.6);
                yield return new LT(88, 4.9183, 91.7, 102.4);
                yield return new LT(89, 4.8692, 90.6, 97.7);
                yield return new LT(90, 4.8602, 100.9, 103.5);
                yield return new LT(91, 4.8451, 103.7, 100);
                yield return new LT(92, 4.8855, 108.9, 98.9);
                yield return new LT(93, 4.8647, 101.7, 96.5);
                yield return new LT(94, 4.8694, 93.8, 89.5);
                yield return new LT(95, 4.8716, 85.8, 84.7);
                yield return new LT(96, 4.8771, 82.6, 81.2);
                yield return new LT(97, 4.8675, 85.8, 80);
                yield return new LT(98, 4.886, 86.7, 82.4);
                yield return new LT(99, 4.8844, 81.4, 84.7);
                yield return new LT(100, 4.8711, 82.6, 84.7);
                yield return new LT(101, 4.8717, 82.1, 84.7);
                yield return new LT(102, 4.8838, 76.6, 80);
                yield return new LT(103, 4.8745, 78.7, 80);
                yield return new LT(104, 4.8875, 70.4, 74.1);
                yield return new LT(105, 4.899, 71.8, 72.9);
                yield return new LT(106, 4.883, 68.4, 71.8);
                yield return new LT(107, 4.8734, 68.4, 72.9);
                yield return new LT(108, 4.859, 71.3, 75.3);
                yield return new LT(109, 4.8733, 76.6, 80);
                yield return new LT(110, 4.8717, 82.3, 88.2);
                yield return new LT(111, 4.8786, 81.2, 82.4);
                yield return new LT(112, 4.8764, 86.7, 81.2);
                yield return new LT(113, 4.8682, 87.8, 84.6);
                yield return new LT(114, 4.8717, 87.8, 82.4);
                yield return new LT(115, 4.8663, 88.3, 84.7);
                yield return new LT(116, 4.8573, 90.9, 90.6);
                yield return new LT(117, 4.8667, 95.7, 94.2);
                yield return new LT(118, 4.8684, 92.6, 86);
                yield return new LT(119, 4.876, 99.5, 87.1);
                yield return new LT(120, 4.8676, 103.4, 91.8);
                yield return new LT(121, 4.866, 95.4, 94.2);
                yield return new LT(122, 4.8701, 101.7, 100);
                yield return new LT(123, 4.8689, 102.5, 100);
                yield return new LT(124, 4.9296, 100, 100);
                yield return new LT(125, 4.757, 102.3, 127.1);
                yield return new LT(126, 4.766, 125.7, 160);
                yield return new LT(127, 4.7644, 172.7, 210.6);
                yield return new LT(128, 4.7651, 193.1, 225.9);
                yield return new LT(129, 4.4258, 203.7, 242.5);
                yield return new LT(130, 3.6643, 227.1, 295.4);
                yield return new LT(131, 3.849, 143.6, 182.4);
                yield return new LT(132, 4.4292, 142.2, 154.2);
                yield return new LT(133, 4.5748, 147.9, 151.8);
                yield return new LT(134, 4.4171, 144.2, 163.6);
                yield return new LT(135, 4.8289, 152.1, 160);
                yield return new LT(136, 4.8582, 147, 148.3);
                yield return new LT(137, 4.861, 140.4, 143.6);
                yield return new LT(138, 4.8662, 142.4, 141.2);
                yield return new LT(139, 4.8569, 139.9, 135.4);
                yield return new LT(140, 4.8621, 127.1, 114.2);
                yield return new LT(141, 4.535, 107.1, 97.7);
                yield return new LT(142, 3.5061, 95.7, 94.2);
                yield return new LT(143, 4.2368, 96.8, 92.9);
                yield return new LT(144, 5.0393, 109.9, 96.5);
                yield return new LT(145, 4.9018, 117.7, 98.9);
                yield return new LT(146, 4.9709, 118.8, 104.8);
                yield return new LT(147, 4.944, 126.8, 120.1);
                yield return new LT(148, 4.8894, 115.4, 107.1);
                yield return new LT(149, 4.4354, 113.3, 108.6);
                yield return new LT(150, 3.83, 115.4, 144.2);
                yield return new LT(151, 4.0318, 128.5, 161.1);
                yield return new LT(152, 4.035, 145, 168.3);
                yield return new LT(153, 4.035, 152.7, 171.9);
                yield return new LT(154, 4.035, 152.7, 175.5);
                yield return new LT(155, 4.0302, 155.5, 178.5);
                yield return new LT(156, 4.0328, 177.5, 184.9);
                yield return new LT(157, 4.0286, 217.9, 202.5);
                yield return new LT(158, 4.0313, 236, 231.5);
                yield return new LT(159, 3.6872, 224.3, 243.9);
                yield return new LT(160, 2.8007, 233, 278.8);
                yield return new LT(161, 2.7996, 259.6, 326.1);
                yield return new LT(162, 2.7926, 252.5, 333.6);
                yield return new LT(163, 2.8127, 249, 326.1);
                yield return new LT(164, 2.8087, 249.6, 326.1);
                yield return new LT(165, 2.7913, 250.2, 336);
                yield return new LT(166, 2.7957, 258.4, 348.5);
                yield return new LT(167, 2.7932, 265.8, 360.9);
                yield return new LT(168, 2.8098, 269.5, 363.4);
                yield return new LT(169, 2.8088, 270.1, 363.4);
                yield return new LT(170, 2.8076, 270.1, 368.4);
                yield return new LT(171, 2.8022, 269.5, 378.4);
                yield return new LT(172, 2.8078, 270.1, 388.3);
                yield return new LT(173, 2.8, 269.3, 390.8);
                yield return new LT(174, 2.7921, 269.8, 403.3);
                yield return new LT(175, 2.7959, 275.2, 418.2);
                yield return new LT(176, 2.793, 284.4, 430.6);
                yield return new LT(177, 2.7504, 284.9, 435.6);
                yield return new LT(178, 2.3935, 292, 450.6);
                yield return new LT(179, 2.3901, 303.4, 470.5);
                yield return new LT(180, 2.3959, 314.5, 500.3);
                yield return new LT(181, 2.442, 324.5, 545.1);
                yield return new LT(182, 2.5008, 339.3, 575);
                yield return new LT(183, 2.451, 383.7, 617.3);
                yield return new LT(184, 2.3403, 456.2, 761.7);
                yield return new LT(185, 2.2216, 498.3, 936);
                yield return new LT(186, 1.8062, 521.2, 1087.8);
                yield return new LT(187, 1.7455, 552.9, 1284.5);
                yield return new LT(188, 1.9195, 595.9, 1411.4);
                yield return new LT(189, 2.1178, 670.6, 1565.7);
                yield return new LT(190, 2.324, 765.6, 1784.8);
                yield return new LT(191, 2.0095, 835, 1956.5);
                yield return new LT(192, 1.7469, 851.7, 2105.9);
                yield return new LT(193, 1.5158, 862.3, 2220.4);
                yield return new LT(194, 1.3301, 883.3, 2357.3);
                yield return new LT(195, 1.2833, 879, 2489.2);
                yield return new LT(196, 1.467, 853.5, 2601.3);
                yield return new LT(197, 1.6389, 876.3, 2698.3);
                yield return new LT(198, 1.7814, 911.5, 2817.8);
                yield return new LT(199, 1.6397, 956.3, 2962.2);
                yield return new LT(200, 1.7841, 990.6, 3064.3);
            }
        }
    }
}
