// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Herbicide applied to Galium aparine
    /// </summary>

    public class G_aparine
    {
        public readonly int κ;
        public readonly double dose;
        public readonly int drymatter;
        public readonly int treatment;

        public G_aparine(int κ, double dose, int drymatter, int treatment)
        {
            this.κ = κ;
            this.dose = dose;
            this.drymatter = drymatter;
            this.treatment = treatment;
        }

        public static IEnumerable<G_aparine> Data
        {
            get
            {
                yield return new G_aparine(1, 0, 1146, 1);
                yield return new G_aparine(2, 0, 1005, 1);
                yield return new G_aparine(3, 0, 756, 1);
                yield return new G_aparine(4, 0, 1108, 1);
                yield return new G_aparine(5, 0, 956, 1);
                yield return new G_aparine(6, 0, 989, 1);
                yield return new G_aparine(7, 0, 1109, 1);
                yield return new G_aparine(8, 0, 867, 1);
                yield return new G_aparine(9, 0, 864, 1);
                yield return new G_aparine(10, 0, 997, 1);
                yield return new G_aparine(11, 0, 891, 1);
                yield return new G_aparine(12, 0, 744, 1);
                yield return new G_aparine(13, 0, 781, 1);
                yield return new G_aparine(14, 0, 937, 1);
                yield return new G_aparine(15, 0, 866, 1);
                yield return new G_aparine(16, 0, 946, 1);
                yield return new G_aparine(17, 0, 788, 1);
                yield return new G_aparine(18, 0, 690, 1);
                yield return new G_aparine(19, 0, 895, 1);
                yield return new G_aparine(20, 0, 765, 1);
                yield return new G_aparine(21, 0, 886, 1);
                yield return new G_aparine(22, 0, 1061, 1);
                yield return new G_aparine(23, 0, 1147, 1);
                yield return new G_aparine(24, 0, 888, 1);
                yield return new G_aparine(25, 0, 961, 1);
                yield return new G_aparine(26, 0, 957, 1);
                yield return new G_aparine(27, 0, 873, 1);
                yield return new G_aparine(28, 0, 886, 1);
                yield return new G_aparine(29, 0, 1029, 1);
                yield return new G_aparine(30, 0, 1031, 1);
                yield return new G_aparine(31, 0, 931, 1);
                yield return new G_aparine(32, 0, 1135, 1);
                yield return new G_aparine(33, 0, 1240, 1);
                yield return new G_aparine(34, 0, 821, 1);
                yield return new G_aparine(35, 0, 993, 1);
                yield return new G_aparine(36, 0, 1125, 1);
                yield return new G_aparine(37, 0, 1125, 1);
                yield return new G_aparine(38, 0, 888, 1);
                yield return new G_aparine(39, 0, 883, 1);
                yield return new G_aparine(40, 0, 962, 1);
                yield return new G_aparine(41, 3.16, 913, 1);
                yield return new G_aparine(42, 3.16, 1174, 1);
                yield return new G_aparine(43, 3.16, 853, 1);
                yield return new G_aparine(44, 3.16, 842, 1);
                yield return new G_aparine(45, 3.16, 847, 1);
                yield return new G_aparine(46, 3.16, 1016, 1);
                yield return new G_aparine(47, 3.16, 1116, 1);
                yield return new G_aparine(48, 3.16, 899, 1);
                yield return new G_aparine(49, 3.16, 1155, 1);
                yield return new G_aparine(50, 3.16, 1377, 1);
                yield return new G_aparine(51, 6.32, 677, 1);
                yield return new G_aparine(52, 6.32, 966, 1);
                yield return new G_aparine(53, 6.32, 861, 1);
                yield return new G_aparine(54, 6.32, 903, 1);
                yield return new G_aparine(55, 6.32, 1025, 1);
                yield return new G_aparine(56, 6.32, 774, 1);
                yield return new G_aparine(57, 6.32, 900, 1);
                yield return new G_aparine(58, 6.32, 858, 1);
                yield return new G_aparine(59, 6.32, 1120, 1);
                yield return new G_aparine(60, 6.32, 1054, 1);
                yield return new G_aparine(61, 12.67, 921, 1);
                yield return new G_aparine(62, 12.67, 1020, 1);
                yield return new G_aparine(63, 12.67, 811, 1);
                yield return new G_aparine(64, 12.67, 1093, 1);
                yield return new G_aparine(65, 12.67, 933, 1);
                yield return new G_aparine(66, 12.67, 1015, 1);
                yield return new G_aparine(67, 12.67, 869, 1);
                yield return new G_aparine(68, 12.67, 812, 1);
                yield return new G_aparine(69, 12.67, 1304, 1);
                yield return new G_aparine(70, 12.67, 1022, 1);
                yield return new G_aparine(71, 25.34, 870, 1);
                yield return new G_aparine(72, 25.34, 795, 1);
                yield return new G_aparine(73, 25.34, 880, 1);
                yield return new G_aparine(74, 25.34, 852, 1);
                yield return new G_aparine(75, 25.34, 772, 1);
                yield return new G_aparine(76, 25.34, 885, 1);
                yield return new G_aparine(77, 25.34, 854, 1);
                yield return new G_aparine(78, 25.34, 914, 1);
                yield return new G_aparine(79, 25.34, 721, 1);
                yield return new G_aparine(80, 25.34, 979, 1);
                yield return new G_aparine(81, 50.68, 598, 1);
                yield return new G_aparine(82, 50.68, 712, 1);
                yield return new G_aparine(83, 50.68, 748, 1);
                yield return new G_aparine(84, 50.68, 852, 1);
                yield return new G_aparine(85, 50.68, 735, 1);
                yield return new G_aparine(86, 50.68, 704, 1);
                yield return new G_aparine(87, 50.68, 674, 1);
                yield return new G_aparine(88, 50.68, 834, 1);
                yield return new G_aparine(89, 50.68, 897, 1);
                yield return new G_aparine(90, 50.68, 674, 1);
                yield return new G_aparine(91, 101.35, 830, 1);
                yield return new G_aparine(92, 101.35, 749, 1);
                yield return new G_aparine(93, 101.35, 837, 1);
                yield return new G_aparine(94, 101.35, 580, 1);
                yield return new G_aparine(95, 101.35, 484, 1);
                yield return new G_aparine(96, 101.35, 783, 1);
                yield return new G_aparine(97, 101.35, 516, 1);
                yield return new G_aparine(98, 101.35, 543, 1);
                yield return new G_aparine(99, 101.35, 558, 1);
                yield return new G_aparine(100, 101.35, 587, 1);
                yield return new G_aparine(101, 202.7, 580, 1);
                yield return new G_aparine(102, 202.7, 531, 1);
                yield return new G_aparine(103, 202.7, 370, 1);
                yield return new G_aparine(104, 202.7, 559, 1);
                yield return new G_aparine(105, 202.7, 564, 1);
                yield return new G_aparine(106, 202.7, 570, 1);
                yield return new G_aparine(107, 202.7, 600, 1);
                yield return new G_aparine(108, 202.7, 532, 1);
                yield return new G_aparine(109, 202.7, 506, 1);
                yield return new G_aparine(110, 202.7, 523, 1);
                yield return new G_aparine(111, 405.4, 579, 1);
                yield return new G_aparine(112, 405.4, 491, 1);
                yield return new G_aparine(113, 405.4, 483, 1);
                yield return new G_aparine(114, 405.4, 402, 1);
                yield return new G_aparine(115, 405.4, 544, 1);
                yield return new G_aparine(116, 405.4, 514, 1);
                yield return new G_aparine(117, 405.4, 684, 1);
                yield return new G_aparine(118, 405.4, 495, 1);
                yield return new G_aparine(119, 405.4, 670, 1);
                yield return new G_aparine(120, 405.4, 419, 1);
                yield return new G_aparine(121, 810.8, 472, 1);
                yield return new G_aparine(122, 810.8, 515, 1);
                yield return new G_aparine(123, 810.8, 668, 1);
                yield return new G_aparine(124, 810.8, 486, 1);
                yield return new G_aparine(125, 810.8, 455, 1);
                yield return new G_aparine(126, 810.8, 410, 1);
                yield return new G_aparine(127, 810.8, 549, 1);
                yield return new G_aparine(128, 810.8, 628, 1);
                yield return new G_aparine(129, 810.8, 410, 1);
                yield return new G_aparine(130, 810.8, 702, 1);
                yield return new G_aparine(131, 1621.6, 430, 1);
                yield return new G_aparine(132, 1621.6, 254, 1);
                yield return new G_aparine(133, 1621.6, 482, 1);
                yield return new G_aparine(134, 1621.6, 623, 1);
                yield return new G_aparine(135, 1621.6, 607, 1);
                yield return new G_aparine(136, 1621.6, 441, 1);
                yield return new G_aparine(137, 1621.6, 650, 1);
                yield return new G_aparine(138, 1621.6, 530, 1);
                yield return new G_aparine(139, 1621.6, 536, 1);
                yield return new G_aparine(140, 1621.6, 480, 1);
                yield return new G_aparine(141, 3.16, 930, 2);
                yield return new G_aparine(142, 3.16, 1125, 2);
                yield return new G_aparine(143, 3.16, 985, 2);
                yield return new G_aparine(144, 3.16, 1214, 2);
                yield return new G_aparine(145, 3.16, 1120, 2);
                yield return new G_aparine(146, 3.16, 1082, 2);
                yield return new G_aparine(147, 3.16, 1124, 2);
                yield return new G_aparine(148, 3.16, 1020, 2);
                yield return new G_aparine(149, 3.16, 1083, 2);
                yield return new G_aparine(150, 3.16, 1230, 2);
                yield return new G_aparine(151, 6.32, 800, 2);
                yield return new G_aparine(152, 6.32, 1136, 2);
                yield return new G_aparine(153, 6.32, 950, 2);
                yield return new G_aparine(154, 6.32, 875, 2);
                yield return new G_aparine(155, 6.32, 1106, 2);
                yield return new G_aparine(156, 6.32, 1008, 2);
                yield return new G_aparine(157, 6.32, 978, 2);
                yield return new G_aparine(158, 6.32, 1184, 2);
                yield return new G_aparine(159, 6.32, 1074, 2);
                yield return new G_aparine(160, 6.32, 980, 2);
                yield return new G_aparine(161, 12.67, 1087, 2);
                yield return new G_aparine(162, 12.67, 1162, 2);
                yield return new G_aparine(163, 12.67, 832, 2);
                yield return new G_aparine(164, 12.67, 998, 2);
                yield return new G_aparine(165, 12.67, 877, 2);
                yield return new G_aparine(166, 12.67, 1070, 2);
                yield return new G_aparine(167, 12.67, 831, 2);
                yield return new G_aparine(168, 12.67, 931, 2);
                yield return new G_aparine(169, 12.67, 1038, 2);
                yield return new G_aparine(170, 12.67, 938, 2);
                yield return new G_aparine(171, 25.34, 888, 2);
                yield return new G_aparine(172, 25.34, 762, 2);
                yield return new G_aparine(173, 25.34, 754, 2);
                yield return new G_aparine(174, 25.34, 900, 2);
                yield return new G_aparine(175, 25.34, 1017, 2);
                yield return new G_aparine(176, 25.34, 907, 2);
                yield return new G_aparine(177, 25.34, 878, 2);
                yield return new G_aparine(178, 25.34, 895, 2);
                yield return new G_aparine(179, 25.34, 887, 2);
                yield return new G_aparine(180, 25.34, 1097, 2);
                yield return new G_aparine(181, 50.68, 937, 2);
                yield return new G_aparine(182, 50.68, 825, 2);
                yield return new G_aparine(183, 50.68, 624, 2);
                yield return new G_aparine(184, 50.68, 646, 2);
                yield return new G_aparine(185, 50.68, 693, 2);
                yield return new G_aparine(186, 50.68, 879, 2);
                yield return new G_aparine(187, 50.68, 663, 2);
                yield return new G_aparine(188, 50.68, 678, 2);
                yield return new G_aparine(189, 50.68, 767, 2);
                yield return new G_aparine(190, 50.68, 712, 2);
                yield return new G_aparine(191, 101.35, 611, 2);
                yield return new G_aparine(192, 101.35, 495, 2);
                yield return new G_aparine(193, 101.35, 770, 2);
                yield return new G_aparine(194, 101.35, 464, 2);
                yield return new G_aparine(195, 101.35, 697, 2);
                yield return new G_aparine(196, 101.35, 487, 2);
                yield return new G_aparine(197, 101.35, 498, 2);
                yield return new G_aparine(198, 101.35, 471, 2);
                yield return new G_aparine(199, 101.35, 565, 2);
                yield return new G_aparine(200, 101.35, 635, 2);
                yield return new G_aparine(201, 202.7, 302, 2);
                yield return new G_aparine(202, 202.7, 268, 2);
                yield return new G_aparine(203, 202.7, 302, 2);
                yield return new G_aparine(204, 202.7, 481, 2);
                yield return new G_aparine(205, 202.7, 331, 2);
                yield return new G_aparine(206, 202.7, 291, 2);
                yield return new G_aparine(207, 202.7, 292, 2);
                yield return new G_aparine(208, 202.7, 315, 2);
                yield return new G_aparine(209, 202.7, 313, 2);
                yield return new G_aparine(210, 202.7, 291, 2);
                yield return new G_aparine(211, 405.4, 197, 2);
                yield return new G_aparine(212, 405.4, 160, 2);
                yield return new G_aparine(213, 405.4, 167, 2);
                yield return new G_aparine(214, 405.4, 166, 2);
                yield return new G_aparine(215, 405.4, 191, 2);
                yield return new G_aparine(216, 405.4, 198, 2);
                yield return new G_aparine(217, 405.4, 187, 2);
                yield return new G_aparine(218, 405.4, 165, 2);
                yield return new G_aparine(219, 405.4, 264, 2);
                yield return new G_aparine(220, 405.4, 184, 2);
                yield return new G_aparine(221, 810.8, 171, 2);
                yield return new G_aparine(222, 810.8, 173, 2);
                yield return new G_aparine(223, 810.8, 203, 2);
                yield return new G_aparine(224, 810.8, 168, 2);
                yield return new G_aparine(225, 810.8, 144, 2);
                yield return new G_aparine(226, 810.8, 181, 2);
                yield return new G_aparine(227, 810.8, 221, 2);
                yield return new G_aparine(228, 810.8, 123, 2);
                yield return new G_aparine(229, 810.8, 141, 2);
                yield return new G_aparine(230, 810.8, 162, 2);
                yield return new G_aparine(231, 1621.6, 195, 2);
                yield return new G_aparine(232, 1621.6, 172, 2);
                yield return new G_aparine(233, 1621.6, 197, 2);
                yield return new G_aparine(234, 1621.6, 188, 2);
                yield return new G_aparine(235, 1621.6, 139, 2);
                yield return new G_aparine(236, 1621.6, 130, 2);
                yield return new G_aparine(237, 1621.6, 178, 2);
                yield return new G_aparine(238, 1621.6, 175, 2);
                yield return new G_aparine(239, 1621.6, 208, 2);
                yield return new G_aparine(240, 1621.6, 171, 2);
            }
        }
    }
}
