// ReSharper disable All

namespace Rdatasets.texmex
{
    using System.Collections.Generic;

    /// <summary>
    /// Air pollution data, separately for summer and winter months
    /// </summary>

    public class winter
    {
        public readonly int κ;
        public readonly int O3;
        public readonly int NO2;
        public readonly int NO;
        public readonly int SO2;
        public readonly int PM10;

        public winter(int κ, int O3, int NO2, int NO, int SO2, int PM10)
        {
            this.κ = κ;
            this.O3 = O3;
            this.NO2 = NO2;
            this.NO = NO;
            this.SO2 = SO2;
            this.PM10 = PM10;
        }

        public static IEnumerable<winter> Data
        {
            get
            {
                yield return new winter(1, 27, 50, 112, 13, 34);
                yield return new winter(2, 27, 51, 126, 13, 29);
                yield return new winter(3, 15, 43, 90, 21, 33);
                yield return new winter(4, 9, 71, 470, 44, 101);
                yield return new winter(5, 20, 51, 167, 48, 30);
                yield return new winter(6, 8, 50, 211, 16, 44);
                yield return new winter(7, 5, 62, 434, 54, 109);
                yield return new winter(8, 12, 38, 50, 22, 25);
                yield return new winter(9, 18, 55, 192, 44, 75);
                yield return new winter(10, 7, 52, 199, 46, 76);
                yield return new winter(11, 19, 51, 76, 18, 29);
                yield return new winter(12, 26, 46, 38, 21, 33);
                yield return new winter(13, 25, 54, 190, 10, 23);
                yield return new winter(14, 11, 43, 132, 18, 42);
                yield return new winter(15, 25, 33, 34, 5, 18);
                yield return new winter(16, 30, 52, 108, 14, 51);
                yield return new winter(17, 20, 49, 104, 22, 28);
                yield return new winter(18, 22, 51, 159, 32, 51);
                yield return new winter(19, 18, 59, 172, 20, 41);
                yield return new winter(20, 30, 55, 163, 21, 29);
                yield return new winter(21, 24, 48, 93, 8, 25);
                yield return new winter(22, 35, 48, 84, 3, 20);
                yield return new winter(23, 20, 47, 166, 24, 49);
                yield return new winter(24, 26, 66, 152, 13, 34);
                yield return new winter(25, 35, 43, 72, 18, 40);
                yield return new winter(26, 30, 43, 96, 16, 26);
                yield return new winter(27, 31, 44, 52, 12, 39);
                yield return new winter(28, 24, 40, 45, 23, 41);
                yield return new winter(29, 29, 42, 63, 9, 26);
                yield return new winter(30, 18, 45, 81, 16, 40);
                yield return new winter(31, 24, 54, 107, 6, 21);
                yield return new winter(32, 19, 53, 178, 58, 102);
                yield return new winter(33, 14, 38, 58, 120, 36);
                yield return new winter(34, 21, 43, 67, 57, 45);
                yield return new winter(35, 5, 41, 129, 26, 45);
                yield return new winter(36, 10, 47, 149, 19, 38);
                yield return new winter(37, 9, 62, 351, 28, 64);
                yield return new winter(38, 8, 38, 62, 79, 36);
                yield return new winter(39, 14, 37, 59, 53, 46);
                yield return new winter(40, 32, 29, 20, 21, 34);
                yield return new winter(41, 33, 27, 29, 22, 99);
                yield return new winter(42, 23, 62, 242, 59, 93);
                yield return new winter(43, 5, 60, 188, 44, 95);
                yield return new winter(44, 6, 50, 141, 46, 67);
                yield return new winter(45, 7, 60, 94, 116, 89);
                yield return new winter(46, 8, 65, 90, 133, 95);
                yield return new winter(47, 23, 41, 40, 24, 54);
                yield return new winter(48, 15, 52, 108, 35, 80);
                yield return new winter(49, 8, 47, 27, 18, 59);
                yield return new winter(50, 14, 51, 136, 9, 37);
                yield return new winter(51, 9, 52, 141, 85, 59);
                yield return new winter(52, 6, 61, 261, 35, 90);
                yield return new winter(53, 23, 44, 32, 23, 44);
                yield return new winter(54, 6, 44, 155, 23, 35);
                yield return new winter(55, 22, 54, 148, 13, 39);
                yield return new winter(56, 6, 40, 223, 52, 84);
                yield return new winter(57, 9, 32, 89, 57, 46);
                yield return new winter(58, 7, 48, 335, 32, 85);
                yield return new winter(59, 19, 39, 164, 25, 177);
                yield return new winter(60, 5, 37, 162, 47, 69);
                yield return new winter(61, 4, 33, 66, 59, 48);
                yield return new winter(62, 7, 42, 64, 87, 36);
                yield return new winter(63, 8, 33, 102, 9, 41);
                yield return new winter(64, 10, 34, 118, 57, 71);
                yield return new winter(65, 4, 30, 87, 89, 44);
                yield return new winter(66, 20, 25, 49, 11, 17);
                yield return new winter(67, 31, 35, 49, 24, 34);
                yield return new winter(68, 33, 55, 176, 6, 24);
                yield return new winter(69, 35, 46, 159, 21, 37);
                yield return new winter(70, 26, 46, 143, 15, 34);
                yield return new winter(71, 35, 58, 347, 24, 76);
                yield return new winter(72, 23, 41, 113, 15, 38);
                yield return new winter(73, 30, 44, 112, 6, 24);
                yield return new winter(74, 9, 42, 385, 29, 81);
                yield return new winter(75, 6, 46, 338, 31, 89);
                yield return new winter(76, 19, 45, 115, 12, 47);
                yield return new winter(77, 29, 42, 141, 19, 45);
                yield return new winter(78, 7, 52, 248, 44, 100);
                yield return new winter(79, 23, 38, 77, 3, 29);
                yield return new winter(80, 23, 32, 56, 7, 36);
                yield return new winter(81, 18, 46, 230, 17, 62);
                yield return new winter(82, 7, 62, 310, 43, 89);
                yield return new winter(83, 5, 41, 143, 25, 80);
                yield return new winter(84, 4, 43, 104, 31, 94);
                yield return new winter(85, 4, 43, 139, 29, 47);
                yield return new winter(86, 22, 41, 60, 19, 31);
                yield return new winter(87, 15, 41, 95, 28, 26);
                yield return new winter(88, 33, 45, 113, 24, 41);
                yield return new winter(89, 34, 47, 150, 22, 54);
                yield return new winter(90, 35, 41, 73, 15, 25);
                yield return new winter(91, 28, 44, 85, 14, 39);
                yield return new winter(92, 26, 49, 191, 31, 56);
                yield return new winter(93, 31, 33, 26, 13, 22);
                yield return new winter(94, 28, 22, 10, 21, 20);
                yield return new winter(95, 30, 58, 149, 12, 22);
                yield return new winter(96, 33, 38, 115, 15, 34);
                yield return new winter(97, 15, 59, 568, 32, 106);
                yield return new winter(98, 8, 61, 530, 69, 106);
                yield return new winter(99, 30, 50, 167, 19, 48);
                yield return new winter(100, 24, 46, 89, 17, 32);
                yield return new winter(101, 25, 40, 49, 12, 27);
                yield return new winter(102, 29, 53, 121, 14, 35);
                yield return new winter(103, 25, 45, 126, 12, 39);
                yield return new winter(104, 9, 39, 273, 35, 50);
                yield return new winter(105, 10, 39, 226, 36, 49);
                yield return new winter(106, 28, 43, 185, 5, 15);
                yield return new winter(107, 26, 41, 119, 10, 12);
                yield return new winter(108, 32, 39, 27, 43, 18);
                yield return new winter(109, 31, 32, 129, 12, 36);
                yield return new winter(110, 37, 40, 62, 9, 16);
                yield return new winter(111, 37, 45, 159, 10, 24);
                yield return new winter(112, 29, 33, 44, 19, 26);
                yield return new winter(113, 33, 19, 11, 34, 15);
                yield return new winter(114, 32, 32, 39, 66, 43);
                yield return new winter(115, 10, 78, 435, 54, 113);
                yield return new winter(116, 8, 40, 115, 41, 41);
                yield return new winter(117, 11, 39, 254, 26, 55);
                yield return new winter(118, 25, 38, 57, 11, 29);
                yield return new winter(119, 10, 41, 111, 27, 40);
                yield return new winter(120, 26, 42, 138, 7, 20);
                yield return new winter(121, 35, 47, 119, 7, 28);
                yield return new winter(122, 36, 42, 130, 14, 25);
                yield return new winter(123, 25, 41, 78, 38, 33);
                yield return new winter(124, 27, 44, 119, 30, 35);
                yield return new winter(125, 22, 48, 174, 19, 42);
                yield return new winter(126, 27, 37, 108, 18, 27);
                yield return new winter(127, 27, 36, 59, 28, 37);
                yield return new winter(128, 34, 34, 37, 7, 32);
                yield return new winter(129, 31, 38, 90, 33, 36);
                yield return new winter(130, 39, 50, 144, 16, 40);
                yield return new winter(131, 27, 43, 126, 86, 42);
                yield return new winter(132, 26, 52, 110, 24, 29);
                yield return new winter(133, 34, 36, 46, 29, 25);
                yield return new winter(134, 37, 32, 58, 13, 19);
                yield return new winter(135, 35, 44, 128, 7, 25);
                yield return new winter(136, 33, 47, 131, 20, 39);
                yield return new winter(137, 24, 63, 344, 50, 98);
                yield return new winter(138, 30, 28, 44, 21, 21);
                yield return new winter(139, 24, 65, 398, 48, 71);
                yield return new winter(140, 25, 45, 74, 16, 26);
                yield return new winter(141, 24, 33, 39, 6, 18);
                yield return new winter(142, 30, 54, 192, 57, 76);
                yield return new winter(143, 34, 55, 119, 24, 19);
                yield return new winter(144, 36, 55, 157, 23, 36);
                yield return new winter(145, 28, 56, 288, 37, 77);
                yield return new winter(146, 34, 46, 116, 19, 36);
                yield return new winter(147, 26, 45, 104, 7, 28);
                yield return new winter(148, 24, 41, 98, 14, 28);
                yield return new winter(149, 27, 52, 182, 10, 39);
                yield return new winter(150, 39, 51, 125, 6, 35);
                yield return new winter(151, 38, 38, 71, 13, 40);
                yield return new winter(152, 15, 39, 82, 32, 31);
                yield return new winter(153, 15, 38, 95, 43, 26);
                yield return new winter(154, 23, 44, 105, 36, 33);
                yield return new winter(155, 32, 32, 41, 14, 25);
                yield return new winter(156, 33, 46, 117, 18, 36);
                yield return new winter(157, 24, 47, 148, 18, 36);
                yield return new winter(158, 26, 51, 134, 12, 27);
                yield return new winter(159, 33, 47, 168, 14, 26);
                yield return new winter(160, 32, 49, 143, 10, 35);
                yield return new winter(161, 30, 58, 142, 15, 40);
                yield return new winter(162, 28, 51, 105, 19, 36);
                yield return new winter(163, 36, 52, 145, 16, 22);
                yield return new winter(164, 29, 52, 189, 15, 44);
                yield return new winter(165, 18, 64, 257, 29, 66);
                yield return new winter(166, 23, 42, 54, 16, 40);
                yield return new winter(167, 26, 45, 64, 11, 29);
                yield return new winter(168, 26, 55, 167, 18, 30);
                yield return new winter(169, 35, 37, 28, 23, 59);
                yield return new winter(170, 13, 36, 119, 15, 21);
                yield return new winter(171, 21, 34, 126, 11, 26);
                yield return new winter(172, 12, 38, 109, 9, 44);
                yield return new winter(173, 7, 60, 330, 24, 76);
                yield return new winter(174, 5, 50, 206, 12, 58);
                yield return new winter(175, 14, 50, 119, 8, 24);
                yield return new winter(176, 18, 52, 306, 10, 56);
                yield return new winter(177, 9, 39, 158, 19, 27);
                yield return new winter(178, 9, 39, 40, 39, 42);
                yield return new winter(179, 4, 40, 60, 22, 42);
                yield return new winter(180, 6, 36, 135, 40, 77);
                yield return new winter(181, 3, 48, 228, 21, 84);
                yield return new winter(182, 12, 57, 230, 14, 53);
                yield return new winter(183, 30, 38, 68, 7, 18);
                yield return new winter(184, 25, 30, 55, 7, 19);
                yield return new winter(185, 22, 35, 53, 7, 20);
                yield return new winter(186, 27, 36, 87, 5, 21);
                yield return new winter(187, 4, 50, 363, 40, 84);
                yield return new winter(188, 3, 39, 197, 20, 68);
                yield return new winter(189, 13, 47, 153, 18, 70);
                yield return new winter(190, 20, 45, 66, 12, 24);
                yield return new winter(191, 31, 42, 86, 9, 29);
                yield return new winter(192, 23, 41, 136, 10, 36);
                yield return new winter(193, 10, 34, 57, 13, 24);
                yield return new winter(194, 10, 38, 70, 13, 25);
                yield return new winter(195, 3, 37, 61, 84, 40);
                yield return new winter(196, 2, 30, 110, 59, 36);
                yield return new winter(197, 5, 41, 47, 59, 43);
                yield return new winter(198, 2, 37, 82, 44, 55);
                yield return new winter(199, 2, 27, 65, 45, 35);
                yield return new winter(200, 1, 26, 78, 12, 36);
                yield return new winter(201, 22, 38, 95, 8, 35);
                yield return new winter(202, 27, 36, 60, 3, 17);
                yield return new winter(203, 21, 42, 85, 12, 34);
                yield return new winter(204, 7, 36, 186, 26, 71);
                yield return new winter(205, 3, 47, 257, 22, 74);
                yield return new winter(206, 4, 88, 560, 32, 141);
                yield return new winter(207, 3, 59, 364, 54, 59);
                yield return new winter(208, 5, 59, 548, 56, 79);
                yield return new winter(209, 9, 33, 103, 15, 26);
                yield return new winter(210, 23, 46, 81, 7, 23);
                yield return new winter(211, 22, 32, 57, 4, 22);
                yield return new winter(212, 30, 34, 49, 2, 23);
                yield return new winter(213, 23, 34, 42, 3, 27);
                yield return new winter(214, 27, 34, 40, 3, 45);
                yield return new winter(215, 18, 44, 117, 9, 48);
                yield return new winter(216, 16, 39, 105, 9, 28);
                yield return new winter(217, 24, 48, 114, 11, 40);
                yield return new winter(218, 8, 44, 131, 31, 39);
                yield return new winter(219, 11, 41, 197, 16, 23);
                yield return new winter(220, 20, 37, 55, 2, 24);
                yield return new winter(221, 5, 47, 193, 15, 42);
                yield return new winter(222, 30, 40, 53, 9, 22);
                yield return new winter(223, 31, 26, 25, 6, 26);
                yield return new winter(224, 21, 51, 269, 9, 46);
                yield return new winter(225, 8, 49, 237, 86, 48);
                yield return new winter(226, 5, 40, 157, 200, 46);
                yield return new winter(227, 20, 29, 24, 4, 34);
                yield return new winter(228, 20, 26, 72, 3, 59);
                yield return new winter(229, 2, 21, 106, 13, 43);
                yield return new winter(230, 2, 38, 254, 39, 90);
                yield return new winter(231, 1, 36, 130, 32, 60);
                yield return new winter(232, 3, 32, 63, 88, 33);
                yield return new winter(233, 2, 30, 66, 58, 38);
                yield return new winter(234, 2, 30, 70, 85, 43);
                yield return new winter(235, 15, 41, 62, 51, 38);
                yield return new winter(236, 15, 43, 85, 19, 40);
                yield return new winter(237, 17, 46, 106, 22, 54);
                yield return new winter(238, 16, 52, 223, 31, 67);
                yield return new winter(239, 6, 37, 83, 30, 49);
                yield return new winter(240, 13, 43, 69, 15, 44);
                yield return new winter(241, 29, 40, 57, 8, 32);
                yield return new winter(242, 13, 27, 40, 36, 40);
                yield return new winter(243, 3, 65, 422, 33, 143);
                yield return new winter(244, 3, 56, 295, 34, 76);
                yield return new winter(245, 2, 53, 236, 31, 152);
                yield return new winter(246, 1, 48, 128, 26, 66);
                yield return new winter(247, 2, 32, 92, 114, 48);
                yield return new winter(248, 6, 40, 66, 58, 72);
                yield return new winter(249, 15, 24, 33, 10, 51);
                yield return new winter(250, 20, 30, 65, 10, 84);
                yield return new winter(251, 22, 26, 42, 8, 64);
                yield return new winter(252, 23, 28, 45, 10, 67);
                yield return new winter(253, 28, 24, 31, 5, 39);
                yield return new winter(254, 32, 28, 37, 3, 27);
                yield return new winter(255, 35, 29, 24, 41, 51);
                yield return new winter(256, 30, 22, 14, 15, 50);
                yield return new winter(257, 33, 39, 57, 4, 31);
                yield return new winter(258, 23, 32, 63, 10, 50);
                yield return new winter(259, 23, 32, 65, 18, 50);
                yield return new winter(260, 23, 34, 69, 5, 52);
                yield return new winter(261, 18, 36, 83, 5, 47);
                yield return new winter(262, 21, 38, 89, 4, 23);
                yield return new winter(263, 18, 47, 65, 21, 76);
                yield return new winter(264, 7, 43, 129, 29, 61);
                yield return new winter(265, 16, 36, 82, 23, 51);
                yield return new winter(266, 8, 40, 98, 43, 57);
                yield return new winter(267, 19, 60, 212, 42, 70);
                yield return new winter(268, 7, 54, 136, 26, 38);
                yield return new winter(269, 20, 47, 159, 14, 34);
                yield return new winter(270, 18, 48, 192, 12, 29);
                yield return new winter(271, 29, 30, 48, 7, 29);
                yield return new winter(272, 20, 27, 52, 4, 35);
                yield return new winter(273, 34, 25, 33, 3, 38);
                yield return new winter(274, 34, 49, 115, 10, 25);
                yield return new winter(275, 35, 52, 113, 7, 18);
                yield return new winter(276, 38, 36, 53, 4, 44);
                yield return new winter(277, 38, 36, 46, 7, 41);
                yield return new winter(278, 30, 51, 104, 11, 61);
                yield return new winter(279, 15, 49, 124, 17, 35);
                yield return new winter(280, 7, 48, 113, 11, 66);
                yield return new winter(281, 28, 47, 78, 8, 26);
                yield return new winter(282, 33, 50, 98, 12, 51);
                yield return new winter(283, 16, 61, 173, 35, 56);
                yield return new winter(284, 20, 88, 509, 30, 103);
                yield return new winter(285, 6, 104, 321, 34, 177);
                yield return new winter(286, 21, 47, 106, 17, 53);
                yield return new winter(287, 20, 26, 27, 17, 34);
                yield return new winter(288, 32, 22, 22, 9, 36);
                yield return new winter(289, 24, 35, 34, 5, 25);
                yield return new winter(290, 35, 39, 94, 6, 84);
                yield return new winter(291, 38, 31, 29, 3, 29);
                yield return new winter(292, 29, 41, 155, 7, 32);
                yield return new winter(293, 13, 41, 146, 15, 40);
                yield return new winter(294, 28, 35, 144, 6, 41);
                yield return new winter(295, 8, 32, 178, 16, 55);
                yield return new winter(296, 27, 26, 49, 4, 24);
                yield return new winter(297, 30, 30, 31, 3, 24);
                yield return new winter(298, 29, 38, 110, 9, 43);
                yield return new winter(299, 3, 39, 136, 15, 39);
                yield return new winter(300, 10, 42, 170, 13, 100);
                yield return new winter(301, 3, 35, 107, 8, 26);
                yield return new winter(302, 29, 28, 21, 4, 24);
                yield return new winter(303, 22, 62, 479, 14, 85);
                yield return new winter(304, 27, 56, 305, 24, 73);
                yield return new winter(305, 34, 31, 62, 5, 24);
                yield return new winter(306, 20, 59, 175, 18, 62);
                yield return new winter(307, 22, 45, 143, 7, 28);
                yield return new winter(308, 20, 35, 52, 5, 22);
                yield return new winter(309, 21, 40, 156, 17, 32);
                yield return new winter(310, 26, 38, 187, 10, 52);
                yield return new winter(311, 30, 40, 175, 5, 44);
                yield return new winter(312, 5, 43, 188, 13, 39);
                yield return new winter(313, 5, 60, 257, 25, 63);
                yield return new winter(314, 23, 51, 88, 5, 22);
                yield return new winter(315, 36, 51, 128, 6, 29);
                yield return new winter(316, 26, 49, 134, 8, 34);
                yield return new winter(317, 33, 68, 150, 3, 37);
                yield return new winter(318, 26, 78, 286, 26, 41);
                yield return new winter(319, 28, 65, 120, 8, 35);
                yield return new winter(320, 4, 57, 218, 6, 33);
                yield return new winter(321, 8, 68, 261, 14, 46);
                yield return new winter(322, 3, 56, 308, 18, 96);
                yield return new winter(323, 4, 47, 369, 27, 90);
                yield return new winter(324, 3, 43, 214, 71, 94);
                yield return new winter(325, 5, 41, 115, 79, 37);
                yield return new winter(326, 10, 33, 107, 4, 40);
                yield return new winter(327, 22, 36, 128, 6, 53);
                yield return new winter(328, 27, 40, 96, 6, 34);
                yield return new winter(329, 15, 45, 148, 10, 36);
                yield return new winter(330, 29, 40, 75, 4, 23);
                yield return new winter(331, 16, 46, 210, 19, 62);
                yield return new winter(332, 3, 45, 252, 21, 98);
                yield return new winter(333, 5, 42, 325, 21, 96);
                yield return new winter(334, 27, 25, 23, 3, 7);
                yield return new winter(335, 24, 31, 34, 1, 28);
                yield return new winter(336, 29, 26, 25, 1, 29);
                yield return new winter(337, 29, 31, 29, 2, 17);
                yield return new winter(338, 34, 32, 48, 9, 18);
                yield return new winter(339, 33, 37, 24, 2, 30);
                yield return new winter(340, 25, 41, 146, 5, 33);
                yield return new winter(341, 3, 38, 100, 21, 45);
                yield return new winter(342, 18, 34, 47, 6, 14);
                yield return new winter(343, 23, 37, 133, 5, 32);
                yield return new winter(344, 23, 32, 92, 5, 21);
                yield return new winter(345, 26, 34, 52, 3, 25);
                yield return new winter(346, 33, 24, 12, 2, 23);
                yield return new winter(347, 37, 36, 23, 4, 21);
                yield return new winter(348, 23, 49, 83, 10, 27);
                yield return new winter(349, 30, 33, 25, 8, 33);
                yield return new winter(350, 35, 20, 10, 1, 25);
                yield return new winter(351, 34, 36, 29, 6, 34);
                yield return new winter(352, 12, 44, 88, 12, 31);
                yield return new winter(353, 19, 45, 90, 42, 53);
                yield return new winter(354, 29, 42, 88, 7, 82);
                yield return new winter(355, 32, 46, 97, 8, 88);
                yield return new winter(356, 13, 43, 101, 60, 60);
                yield return new winter(357, 2, 35, 124, 24, 64);
                yield return new winter(358, 12, 34, 106, 18, 45);
                yield return new winter(359, 13, 49, 360, 11, 66);
                yield return new winter(360, 7, 72, 320, 22, 135);
                yield return new winter(361, 2, 54, 189, 33, 141);
                yield return new winter(362, 3, 56, 151, 16, 71);
                yield return new winter(363, 9, 42, 124, 19, 53);
                yield return new winter(364, 22, 33, 44, 12, 37);
                yield return new winter(365, 25, 40, 123, 10, 32);
                yield return new winter(366, 12, 72, 419, 88, 100);
                yield return new winter(367, 16, 40, 152, 24, 41);
                yield return new winter(368, 3, 39, 202, 40, 88);
                yield return new winter(369, 3, 60, 344, 27, 88);
                yield return new winter(370, 4, 73, 487, 44, 119);
                yield return new winter(371, 5, 87, 481, 43, 154);
                yield return new winter(372, 6, 64, 248, 25, 101);
                yield return new winter(373, 13, 60, 318, 12, 76);
                yield return new winter(374, 4, 70, 370, 30, 108);
                yield return new winter(375, 3, 64, 232, 88, 124);
                yield return new winter(376, 3, 49, 225, 59, 99);
                yield return new winter(377, 17, 34, 65, 15, 49);
                yield return new winter(378, 26, 35, 87, 8, 35);
                yield return new winter(379, 29, 47, 166, 17, 43);
                yield return new winter(380, 34, 44, 199, 8, 46);
                yield return new winter(381, 18, 49, 97, 8, 35);
                yield return new winter(382, 25, 45, 68, 11, 62);
                yield return new winter(383, 26, 54, 148, 10, 35);
                yield return new winter(384, 20, 42, 136, 32, 31);
                yield return new winter(385, 36, 52, 183, 11, 51);
                yield return new winter(386, 35, 52, 105, 3, 40);
                yield return new winter(387, 33, 49, 158, 12, 42);
                yield return new winter(388, 22, 48, 132, 12, 25);
                yield return new winter(389, 31, 53, 186, 5, 30);
                yield return new winter(390, 30, 42, 107, 5, 34);
                yield return new winter(391, 32, 49, 127, 26, 62);
                yield return new winter(392, 22, 38, 73, 22, 43);
                yield return new winter(393, 35, 39, 55, 5, 26);
                yield return new winter(394, 38, 50, 116, 11, 32);
                yield return new winter(395, 29, 43, 66, 10, 30);
                yield return new winter(396, 36, 44, 54, 15, 37);
                yield return new winter(397, 36, 56, 118, 15, 35);
                yield return new winter(398, 36, 31, 18, 7, 26);
                yield return new winter(399, 38, 36, 26, 3, 23);
                yield return new winter(400, 44, 34, 34, 3, 30);
                yield return new winter(401, 35, 50, 83, 9, 32);
                yield return new winter(402, 19, 44, 72, 31, 42);
                yield return new winter(403, 18, 37, 64, 4, 23);
                yield return new winter(404, 21, 37, 66, 31, 20);
                yield return new winter(405, 23, 35, 37, 36, 36);
                yield return new winter(406, 8, 55, 132, 34, 135);
                yield return new winter(407, 6, 56, 145, 12, 109);
                yield return new winter(408, 16, 56, 133, 27, 67);
                yield return new winter(409, 17, 45, 113, 22, 64);
                yield return new winter(410, 33, 43, 39, 10, 30);
                yield return new winter(411, 15, 52, 293, 10, 65);
                yield return new winter(412, 15, 49, 141, 12, 41);
                yield return new winter(413, 10, 59, 277, 12, 66);
                yield return new winter(414, 5, 77, 474, 15, 118);
                yield return new winter(415, 3, 52, 226, 21, 71);
                yield return new winter(416, 4, 53, 347, 22, 96);
                yield return new winter(417, 9, 39, 62, 16, 27);
                yield return new winter(418, 9, 39, 78, 12, 47);
                yield return new winter(419, 6, 34, 93, 9, 40);
                yield return new winter(420, 12, 41, 50, 14, 30);
                yield return new winter(421, 12, 52, 118, 23, 40);
                yield return new winter(422, 21, 52, 308, 33, 74);
                yield return new winter(423, 3, 49, 119, 51, 56);
                yield return new winter(424, 11, 32, 49, 89, 31);
                yield return new winter(425, 16, 36, 53, 42, 34);
                yield return new winter(426, 4, 36, 63, 25, 47);
                yield return new winter(427, 2, 32, 137, 10, 64);
                yield return new winter(428, 33, 61, 71, 11, 53);
                yield return new winter(429, 32, 28, 10, 5, 24);
                yield return new winter(430, 30, 38, 123, 10, 37);
                yield return new winter(431, 36, 26, 26, 7, 34);
                yield return new winter(432, 35, 36, 21, 5, 20);
                yield return new winter(433, 31, 51, 149, 12, 47);
                yield return new winter(434, 30, 53, 185, 22, 60);
                yield return new winter(435, 28, 44, 64, 6, 28);
                yield return new winter(436, 33, 48, 114, 11, 33);
                yield return new winter(437, 32, 37, 50, 13, 36);
                yield return new winter(438, 12, 38, 107, 16, 52);
                yield return new winter(439, 6, 29, 85, 23, 51);
                yield return new winter(440, 17, 57, 195, 10, 51);
                yield return new winter(441, 2, 33, 99, 54, 49);
                yield return new winter(442, 21, 37, 120, 15, 35);
                yield return new winter(443, 16, 47, 81, 9, 37);
                yield return new winter(444, 28, 35, 62, 4, 28);
                yield return new winter(445, 21, 39, 47, 9, 27);
                yield return new winter(446, 25, 34, 53, 9, 20);
                yield return new winter(447, 35, 25, 22, 2, 26);
                yield return new winter(448, 35, 65, 323, 26, 101);
                yield return new winter(449, 3, 51, 158, 31, 82);
                yield return new winter(450, 2, 36, 138, 18, 69);
                yield return new winter(451, 27, 40, 148, 20, 64);
                yield return new winter(452, 29, 27, 37, 2, 20);
                yield return new winter(453, 27, 25, 11, 3, 24);
                yield return new winter(454, 35, 42, 62, 23, 25);
                yield return new winter(455, 15, 36, 45, 32, 42);
                yield return new winter(456, 17, 54, 207, 49, 93);
                yield return new winter(457, 12, 44, 167, 40, 63);
                yield return new winter(458, 14, 41, 115, 12, 43);
                yield return new winter(459, 16, 43, 32, 8, 38);
                yield return new winter(460, 10, 39, 87, 15, 43);
                yield return new winter(461, 23, 33, 41, 5, 29);
                yield return new winter(462, 25, 51, 145, 14, 53);
                yield return new winter(463, 22, 52, 112, 4, 30);
                yield return new winter(464, 28, 57, 110, 7, 31);
                yield return new winter(465, 26, 46, 96, 5, 41);
                yield return new winter(466, 29, 43, 36, 4, 25);
                yield return new winter(467, 29, 35, 22, 6, 25);
                yield return new winter(468, 31, 42, 62, 4, 24);
                yield return new winter(469, 32, 44, 77, 5, 36);
                yield return new winter(470, 31, 43, 42, 4, 31);
                yield return new winter(471, 11, 48, 143, 10, 59);
                yield return new winter(472, 25, 56, 137, 15, 56);
                yield return new winter(473, 31, 35, 20, 13, 135);
                yield return new winter(474, 33, 49, 104, 2, 37);
                yield return new winter(475, 28, 58, 131, 8, 28);
                yield return new winter(476, 24, 47, 112, 26, 68);
                yield return new winter(477, 9, 54, 148, 15, 67);
                yield return new winter(478, 27, 54, 129, 19, 74);
                yield return new winter(479, 34, 54, 181, 9, 34);
                yield return new winter(480, 34, 45, 101, 6, 26);
                yield return new winter(481, 29, 57, 141, 4, 29);
                yield return new winter(482, 28, 45, 57, 7, 34);
                yield return new winter(483, 15, 48, 115, 11, 71);
                yield return new winter(484, 33, 49, 95, 6, 43);
                yield return new winter(485, 37, 49, 73, 2, 107);
                yield return new winter(486, 37, 35, 36, 4, 20);
                yield return new winter(487, 19, 38, 92, 3, 19);
                yield return new winter(488, 10, 37, 155, 24, 37);
                yield return new winter(489, 16, 31, 72, 8, 22);
                yield return new winter(490, 15, 38, 68, 5, 40);
                yield return new winter(491, 29, 59, 155, 4, 65);
                yield return new winter(492, 32, 56, 346, 13, 132);
                yield return new winter(493, 17, 46, 244, 11, 123);
                yield return new winter(494, 24, 42, 64, 10, 31);
                yield return new winter(495, 33, 55, 129, 9, 43);
                yield return new winter(496, 35, 46, 105, 5, 28);
                yield return new winter(497, 31, 49, 140, 15, 51);
                yield return new winter(498, 24, 41, 118, 9, 64);
                yield return new winter(499, 33, 62, 203, 7, 29);
                yield return new winter(500, 21, 43, 93, 7, 26);
                yield return new winter(501, 19, 29, 30, 5, 14);
                yield return new winter(502, 29, 42, 117, 8, 34);
                yield return new winter(503, 4, 83, 501, 35, 163);
                yield return new winter(504, 3, 67, 345, 27, 112);
                yield return new winter(505, 3, 45, 153, 21, 65);
                yield return new winter(506, 3, 40, 142, 18, 47);
                yield return new winter(507, 7, 36, 81, 10, 30);
                yield return new winter(508, 19, 37, 78, 7, 51);
                yield return new winter(509, 2, 44, 213, 21, 80);
                yield return new winter(510, 18, 48, 214, 13, 49);
                yield return new winter(511, 5, 68, 465, 18, 112);
                yield return new winter(512, 22, 43, 79, 7, 31);
                yield return new winter(513, 24, 58, 392, 15, 89);
                yield return new winter(514, 22, 38, 101, 9, 33);
                yield return new winter(515, 21, 30, 32, 5, 21);
                yield return new winter(516, 17, 58, 317, 28, 96);
                yield return new winter(517, 3, 51, 249, 37, 87);
                yield return new winter(518, 9, 44, 176, 15, 32);
                yield return new winter(519, 29, 40, 204, 9, 48);
                yield return new winter(520, 33, 31, 54, 4, 25);
                yield return new winter(521, 30, 31, 38, 3, 27);
                yield return new winter(522, 28, 46, 227, 8, 58);
                yield return new winter(523, 4, 49, 289, 42, 109);
                yield return new winter(524, 2, 47, 158, 21, 44);
                yield return new winter(525, 4, 68, 472, 18, 105);
                yield return new winter(526, 3, 51, 271, 14, 42);
                yield return new winter(527, 13, 50, 288, 17, 67);
                yield return new winter(528, 26, 41, 183, 9, 44);
                yield return new winter(529, 35, 36, 54, 8, 32);
                yield return new winter(530, 30, 39, 49, 7, 26);
                yield return new winter(531, 26, 60, 143, 8, 51);
                yield return new winter(532, 19, 48, 121, 8, 31);
            }
        }
    }
}
