// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Australian Relative Wool Prices
    /// </summary>

    public class wool
    {
        public readonly int time;
        public readonly double value;

        public wool(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<wool> Data
        {
            get
            {
                yield return new wool(1, 0.1585);
                yield return new wool(2, 0.1668);
                yield return new wool(3, 0.1745);
                yield return new wool(4, 0.1553);
                yield return new wool(5, 0.1477);
                yield return new wool(6, 0.1552);
                yield return new wool(7, 0.1448);
                yield return new wool(8, 0.1353);
                yield return new wool(9, 0.1352);
                yield return new wool(10, 0.1123);
                yield return new wool(11, 0.1053);
                yield return new wool(12, 0.0934);
                yield return new wool(13, 0.0924);
                yield return new wool(14, 0.0956);
                yield return new wool(15, 0.0953);
                yield return new wool(16, 0.0875);
                yield return new wool(17, 0.075);
                yield return new wool(18, 0.081);
                yield return new wool(19, 0.0865);
                yield return new wool(20, 0.102);
                yield return new wool(21, 0.1087);
                yield return new wool(22, 0.1026);
                yield return new wool(23, 0.1087);
                yield return new wool(24, 0.122);
                yield return new wool(25, 0.1283);
                yield return new wool(26, 0.122);
                yield return new wool(27, 0.122);
                yield return new wool(28, 0.1251);
                yield return new wool(29, 0.1255);
                yield return new wool(30, 0.1231);
                yield return new wool(31, 0.1263);
                yield return new wool(32, 0.1425);
                yield return new wool(33, 0.149);
                yield return new wool(34, 0.149);
                yield return new wool(35, 0.1689);
                yield return new wool(36, 0.1756);
                yield return new wool(37, 0.1655);
                yield return new wool(38, 0.1655);
                yield return new wool(39, 0.1589);
                yield return new wool(40, 0.1655);
                yield return new wool(41, 0.1749);
                yield return new wool(42, 0.1749);
                yield return new wool(43, 0.1691);
                yield return new wool(44, 0.1589);
                yield return new wool(45, 0.1623);
                yield return new wool(46, 0.1556);
                yield return new wool(47, 0.1522);
                yield return new wool(48, 0.146);
                yield return new wool(49, 0.1422);
                yield return new wool(50, 0.1319);
                yield return new wool(51, 0.1254);
                yield return new wool(52, 0.1228);
                yield return new wool(53, 0.1298);
                yield return new wool(54, 0.1265);
                yield return new wool(55, 0.1298);
                yield return new wool(56, 0.1397);
                yield return new wool(57, 0.1431);
                yield return new wool(58, 0.1498);
                yield return new wool(59, 0.1498);
                yield return new wool(60, 0.1498);
                yield return new wool(61, 0.1464);
                yield return new wool(62, 0.1431);
                yield return new wool(63, 0.1356);
                yield return new wool(64, 0.1352);
                yield return new wool(65, 0.1381);
                yield return new wool(66, 0.1343);
                yield return new wool(67, 0.1254);
                yield return new wool(68, 0.1323);
                yield return new wool(69, 0.1376);
                yield return new wool(70, 0.1397);
                yield return new wool(71, 0.1425);
                yield return new wool(72, 0.1453);
                yield return new wool(73, 0.142);
                yield return new wool(74, 0.142);
                yield return new wool(75, 0.1388);
                yield return new wool(76, 0.1291);
                yield return new wool(77, 0.1279);
                yield return new wool(78, 0.1311);
                yield return new wool(79, 0.1355);
                yield return new wool(80, 0.1192);
                yield return new wool(81, 0.1255);
                yield return new wool(82, 0.1192);
                yield return new wool(83, 0.1255);
                yield return new wool(84, 0.1255);
                yield return new wool(85, 0.122);
                yield return new wool(86, 0.122);
                yield return new wool(87, 0.1192);
                yield return new wool(88, 0.1216);
                yield return new wool(89, 0.1216);
                yield return new wool(90, 0.1248);
                yield return new wool(91, 0.1307);
                yield return new wool(92, 0.1307);
                yield return new wool(93, 0.1279);
                yield return new wool(94, 0.1251);
                yield return new wool(95, 0.122);
                yield return new wool(96, 0.124);
                yield return new wool(97, 0.124);
                yield return new wool(98, 0.1184);
                yield return new wool(99, 0.1181);
                yield return new wool(100, 0.1292);
                yield return new wool(101, 0.1261);
                yield return new wool(102, 0.1416);
                yield return new wool(103, 0.1384);
                yield return new wool(104, 0.1538);
                yield return new wool(105, 0.1346);
                yield return new wool(106, 0.1461);
                yield return new wool(107, 0.1542);
                yield return new wool(108, 0.1596);
                yield return new wool(109, 0.1568);
                yield return new wool(110, 0.194);
                yield return new wool(111, 0.2076);
                yield return new wool(112, 0.2562);
                yield return new wool(113, 0.259);
                yield return new wool(114, 0.2534);
                yield return new wool(115, 0.2617);
                yield return new wool(116, 0.2645);
                yield return new wool(117, 0.244);
                yield return new wool(118, 0.2412);
                yield return new wool(119, 0.2467);
                yield return new wool(120, 0.2384);
                yield return new wool(121, 0.2291);
                yield return new wool(122, 0.24);
                yield return new wool(123, 0.2373);
                yield return new wool(124, 0.2425);
                yield return new wool(125, 0.2371);
                yield return new wool(126, 0.249);
                yield return new wool(127, 0.2445);
                yield return new wool(128, 0.2582);
                yield return new wool(129, 0.2926);
                yield return new wool(130, 0.2746);
                yield return new wool(131, 0.2795);
                yield return new wool(132, 0.2755);
                yield return new wool(133, 0.2757);
                yield return new wool(134, 0.287);
                yield return new wool(135, 0.2949);
                yield return new wool(136, 0.2963);
                yield return new wool(137, 0.2744);
                yield return new wool(138, 0.2864);
                yield return new wool(139, 0.2851);
                yield return new wool(140, 0.2766);
                yield return new wool(141, 0.2645);
                yield return new wool(142, 0.2802);
                yield return new wool(143, 0.3173);
                yield return new wool(144, 0.3127);
                yield return new wool(145, 0.3145);
                yield return new wool(146, 0.3489);
                yield return new wool(147, 0.3677);
                yield return new wool(148, 0.3537);
                yield return new wool(149, 0.3554);
                yield return new wool(150, 0.347);
                yield return new wool(151, 0.3662);
                yield return new wool(152, 0.3579);
                yield return new wool(153, 0.3607);
                yield return new wool(154, 0.3631);
                yield return new wool(155, 0.3656);
                yield return new wool(156, 0.3747);
                yield return new wool(157, 0.3468);
                yield return new wool(158, 0.3462);
                yield return new wool(159, 0.3285);
                yield return new wool(160, 0.3337);
                yield return new wool(161, 0.3238);
                yield return new wool(162, 0.3411);
                yield return new wool(163, 0.3198);
                yield return new wool(164, 0.311);
                yield return new wool(165, 0.3215);
                yield return new wool(166, 0.3002);
                yield return new wool(167, 0.2926);
                yield return new wool(168, 0.2927);
                yield return new wool(169, 0.2664);
                yield return new wool(170, 0.2706);
                yield return new wool(171, 0.2582);
                yield return new wool(172, 0.2394);
                yield return new wool(173, 0.2408);
                yield return new wool(174, 0.2208);
                yield return new wool(175, 0.2236);
                yield return new wool(176, 0.2109);
                yield return new wool(177, 0.2208);
                yield return new wool(178, 0.2231);
                yield return new wool(179, 0.2236);
                yield return new wool(180, 0.2265);
                yield return new wool(181, 0.2333);
                yield return new wool(182, 0.2455);
                yield return new wool(183, 0.2623);
                yield return new wool(184, 0.2779);
                yield return new wool(185, 0.273);
                yield return new wool(186, 0.2737);
                yield return new wool(187, 0.2688);
                yield return new wool(188, 0.2647);
                yield return new wool(189, 0.246);
                yield return new wool(190, 0.2447);
                yield return new wool(191, 0.2376);
                yield return new wool(192, 0.2306);
                yield return new wool(193, 0.2403);
                yield return new wool(194, 0.2403);
                yield return new wool(195, 0.245);
                yield return new wool(196, 0.2026);
                yield return new wool(197, 0.2069);
                yield return new wool(198, 0.2069);
                yield return new wool(199, 0.2116);
                yield return new wool(200, 0.2151);
                yield return new wool(201, 0.217);
                yield return new wool(202, 0.2183);
                yield return new wool(203, 0.2151);
                yield return new wool(204, 0.2135);
                yield return new wool(205, 0.2165);
                yield return new wool(206, 0.2099);
                yield return new wool(207, 0.2075);
                yield return new wool(208, 0.2103);
                yield return new wool(209, 0.2127);
                yield return new wool(210, 0.2165);
                yield return new wool(211, 0.2141);
                yield return new wool(212, 0.2255);
                yield return new wool(213, 0.2255);
                yield return new wool(214, 0.2232);
                yield return new wool(215, 0.219);
                yield return new wool(216, 0.2209);
                yield return new wool(217, 0.2231);
                yield return new wool(218, 0.2191);
                yield return new wool(219, 0.2294);
                yield return new wool(220, 0.2677);
                yield return new wool(221, 0.2632);
                yield return new wool(222, 0.2707);
                yield return new wool(223, 0.2713);
                yield return new wool(224, 0.2667);
                yield return new wool(225, 0.2712);
                yield return new wool(226, 0.2735);
                yield return new wool(227, 0.2627);
                yield return new wool(228, 0.2565);
                yield return new wool(229, 0.2543);
                yield return new wool(230, 0.2632);
                yield return new wool(231, 0.2677);
                yield return new wool(232, 0.2814);
                yield return new wool(233, 0.2768);
                yield return new wool(234, 0.2784);
                yield return new wool(235, 0.283);
                yield return new wool(236, 0.2853);
                yield return new wool(237, 0.2762);
                yield return new wool(238, 0.2808);
                yield return new wool(239, 0.259);
                yield return new wool(240, 0.2613);
                yield return new wool(241, 0.247);
                yield return new wool(242, 0.2583);
                yield return new wool(243, 0.247);
                yield return new wool(244, 0.236);
                yield return new wool(245, 0.2631);
                yield return new wool(246, 0.2684);
                yield return new wool(247, 0.2713);
                yield return new wool(248, 0.2549);
                yield return new wool(249, 0.2537);
                yield return new wool(250, 0.2537);
                yield return new wool(251, 0.2593);
                yield return new wool(252, 0.2649);
                yield return new wool(253, 0.286);
                yield return new wool(254, 0.2808);
                yield return new wool(255, 0.2843);
                yield return new wool(256, 0.2802);
                yield return new wool(257, 0.2843);
                yield return new wool(258, 0.2808);
                yield return new wool(259, 0.2845);
                yield return new wool(260, 0.2876);
                yield return new wool(261, 0.3188);
                yield return new wool(262, 0.2882);
                yield return new wool(263, 0.3072);
                yield return new wool(264, 0.3134);
                yield return new wool(265, 0.2962);
                yield return new wool(266, 0.3004);
                yield return new wool(267, 0.3026);
                yield return new wool(268, 0.2966);
                yield return new wool(269, 0.2945);
                yield return new wool(270, 0.3065);
                yield return new wool(271, 0.3097);
                yield return new wool(272, 0.2824);
                yield return new wool(273, 0.265);
                yield return new wool(274, 0.265);
                yield return new wool(275, 0.2603);
                yield return new wool(276, 0.263);
                yield return new wool(277, 0.263);
                yield return new wool(278, 0.2726);
                yield return new wool(279, 0.2603);
                yield return new wool(280, 0.2559);
                yield return new wool(281, 0.2532);
                yield return new wool(282, 0.2622);
                yield return new wool(283, 0.2703);
                yield return new wool(284, 0.2622);
                yield return new wool(285, 0.2708);
                yield return new wool(286, 0.2691);
                yield return new wool(287, 0.2755);
                yield return new wool(288, 0.2792);
                yield return new wool(289, 0.2898);
                yield return new wool(290, 0.3016);
                yield return new wool(291, 0.3288);
                yield return new wool(292, 0.3848);
                yield return new wool(293, 0.423);
                yield return new wool(294, 0.3973);
                yield return new wool(295, 0.431);
                yield return new wool(296, 0.431);
                yield return new wool(297, 0.4728);
                yield return new wool(298, 0.4585);
                yield return new wool(299, 0.4559);
                yield return new wool(300, 0.4581);
                yield return new wool(301, 0.4685);
                yield return new wool(302, 0.4624);
                yield return new wool(303, 0.4645);
                yield return new wool(304, 0.4604);
                yield return new wool(305, 0.4624);
                yield return new wool(306, 0.4624);
                yield return new wool(307, 0.4584);
                yield return new wool(308, 0.4604);
                yield return new wool(309, 0.4544);
            }
        }
    }
}
