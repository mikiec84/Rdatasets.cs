// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Average Monthly Temperatures at Nottingham, 1920-1939
    /// </summary>

    public class nottem
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public nottem(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<nottem> Data
        {
            get
            {
                yield return new nottem(1, 1920, 40.6);
                yield return new nottem(2, 1920.08333333333, 40.8);
                yield return new nottem(3, 1920.16666666667, 44.4);
                yield return new nottem(4, 1920.25, 46.7);
                yield return new nottem(5, 1920.33333333333, 54.1);
                yield return new nottem(6, 1920.41666666667, 58.5);
                yield return new nottem(7, 1920.5, 57.7);
                yield return new nottem(8, 1920.58333333333, 56.4);
                yield return new nottem(9, 1920.66666666667, 54.3);
                yield return new nottem(10, 1920.75, 50.5);
                yield return new nottem(11, 1920.83333333333, 42.9);
                yield return new nottem(12, 1920.91666666667, 39.8);
                yield return new nottem(13, 1921, 44.2);
                yield return new nottem(14, 1921.08333333333, 39.8);
                yield return new nottem(15, 1921.16666666667, 45.1);
                yield return new nottem(16, 1921.25, 47);
                yield return new nottem(17, 1921.33333333333, 54.1);
                yield return new nottem(18, 1921.41666666667, 58.7);
                yield return new nottem(19, 1921.5, 66.3);
                yield return new nottem(20, 1921.58333333333, 59.9);
                yield return new nottem(21, 1921.66666666667, 57);
                yield return new nottem(22, 1921.75, 54.2);
                yield return new nottem(23, 1921.83333333333, 39.7);
                yield return new nottem(24, 1921.91666666667, 42.8);
                yield return new nottem(25, 1922, 37.5);
                yield return new nottem(26, 1922.08333333333, 38.7);
                yield return new nottem(27, 1922.16666666667, 39.5);
                yield return new nottem(28, 1922.25, 42.1);
                yield return new nottem(29, 1922.33333333333, 55.7);
                yield return new nottem(30, 1922.41666666667, 57.8);
                yield return new nottem(31, 1922.5, 56.8);
                yield return new nottem(32, 1922.58333333333, 54.3);
                yield return new nottem(33, 1922.66666666667, 54.3);
                yield return new nottem(34, 1922.75, 47.1);
                yield return new nottem(35, 1922.83333333333, 41.8);
                yield return new nottem(36, 1922.91666666667, 41.7);
                yield return new nottem(37, 1923, 41.8);
                yield return new nottem(38, 1923.08333333333, 40.1);
                yield return new nottem(39, 1923.16666666667, 42.9);
                yield return new nottem(40, 1923.25, 45.8);
                yield return new nottem(41, 1923.33333333333, 49.2);
                yield return new nottem(42, 1923.41666666667, 52.7);
                yield return new nottem(43, 1923.5, 64.2);
                yield return new nottem(44, 1923.58333333333, 59.6);
                yield return new nottem(45, 1923.66666666667, 54.4);
                yield return new nottem(46, 1923.75, 49.2);
                yield return new nottem(47, 1923.83333333333, 36.3);
                yield return new nottem(48, 1923.91666666667, 37.6);
                yield return new nottem(49, 1924, 39.3);
                yield return new nottem(50, 1924.08333333333, 37.5);
                yield return new nottem(51, 1924.16666666667, 38.3);
                yield return new nottem(52, 1924.25, 45.5);
                yield return new nottem(53, 1924.33333333333, 53.2);
                yield return new nottem(54, 1924.41666666667, 57.7);
                yield return new nottem(55, 1924.5, 60.8);
                yield return new nottem(56, 1924.58333333333, 58.2);
                yield return new nottem(57, 1924.66666666667, 56.4);
                yield return new nottem(58, 1924.75, 49.8);
                yield return new nottem(59, 1924.83333333333, 44.4);
                yield return new nottem(60, 1924.91666666667, 43.6);
                yield return new nottem(61, 1925, 40);
                yield return new nottem(62, 1925.08333333333, 40.5);
                yield return new nottem(63, 1925.16666666667, 40.8);
                yield return new nottem(64, 1925.25, 45.1);
                yield return new nottem(65, 1925.33333333333, 53.8);
                yield return new nottem(66, 1925.41666666667, 59.4);
                yield return new nottem(67, 1925.5, 63.5);
                yield return new nottem(68, 1925.58333333333, 61);
                yield return new nottem(69, 1925.66666666667, 53);
                yield return new nottem(70, 1925.75, 50);
                yield return new nottem(71, 1925.83333333333, 38.1);
                yield return new nottem(72, 1925.91666666667, 36.3);
                yield return new nottem(73, 1926, 39.2);
                yield return new nottem(74, 1926.08333333333, 43.4);
                yield return new nottem(75, 1926.16666666667, 43.4);
                yield return new nottem(76, 1926.25, 48.9);
                yield return new nottem(77, 1926.33333333333, 50.6);
                yield return new nottem(78, 1926.41666666667, 56.8);
                yield return new nottem(79, 1926.5, 62.5);
                yield return new nottem(80, 1926.58333333333, 62);
                yield return new nottem(81, 1926.66666666667, 57.5);
                yield return new nottem(82, 1926.75, 46.7);
                yield return new nottem(83, 1926.83333333333, 41.6);
                yield return new nottem(84, 1926.91666666667, 39.8);
                yield return new nottem(85, 1927, 39.4);
                yield return new nottem(86, 1927.08333333333, 38.5);
                yield return new nottem(87, 1927.16666666667, 45.3);
                yield return new nottem(88, 1927.25, 47.1);
                yield return new nottem(89, 1927.33333333333, 51.7);
                yield return new nottem(90, 1927.41666666667, 55);
                yield return new nottem(91, 1927.5, 60.4);
                yield return new nottem(92, 1927.58333333333, 60.5);
                yield return new nottem(93, 1927.66666666667, 54.7);
                yield return new nottem(94, 1927.75, 50.3);
                yield return new nottem(95, 1927.83333333333, 42.3);
                yield return new nottem(96, 1927.91666666667, 35.2);
                yield return new nottem(97, 1928, 40.8);
                yield return new nottem(98, 1928.08333333333, 41.1);
                yield return new nottem(99, 1928.16666666667, 42.8);
                yield return new nottem(100, 1928.25, 47.3);
                yield return new nottem(101, 1928.33333333333, 50.9);
                yield return new nottem(102, 1928.41666666667, 56.4);
                yield return new nottem(103, 1928.5, 62.2);
                yield return new nottem(104, 1928.58333333333, 60.5);
                yield return new nottem(105, 1928.66666666667, 55.4);
                yield return new nottem(106, 1928.75, 50.2);
                yield return new nottem(107, 1928.83333333333, 43);
                yield return new nottem(108, 1928.91666666667, 37.3);
                yield return new nottem(109, 1929, 34.8);
                yield return new nottem(110, 1929.08333333333, 31.3);
                yield return new nottem(111, 1929.16666666667, 41);
                yield return new nottem(112, 1929.25, 43.9);
                yield return new nottem(113, 1929.33333333333, 53.1);
                yield return new nottem(114, 1929.41666666667, 56.9);
                yield return new nottem(115, 1929.5, 62.5);
                yield return new nottem(116, 1929.58333333333, 60.3);
                yield return new nottem(117, 1929.66666666667, 59.8);
                yield return new nottem(118, 1929.75, 49.2);
                yield return new nottem(119, 1929.83333333333, 42.9);
                yield return new nottem(120, 1929.91666666667, 41.9);
                yield return new nottem(121, 1930, 41.6);
                yield return new nottem(122, 1930.08333333333, 37.1);
                yield return new nottem(123, 1930.16666666667, 41.2);
                yield return new nottem(124, 1930.25, 46.9);
                yield return new nottem(125, 1930.33333333333, 51.2);
                yield return new nottem(126, 1930.41666666667, 60.4);
                yield return new nottem(127, 1930.5, 60.1);
                yield return new nottem(128, 1930.58333333333, 61.6);
                yield return new nottem(129, 1930.66666666667, 57);
                yield return new nottem(130, 1930.75, 50.9);
                yield return new nottem(131, 1930.83333333333, 43);
                yield return new nottem(132, 1930.91666666667, 38.8);
                yield return new nottem(133, 1931, 37.1);
                yield return new nottem(134, 1931.08333333333, 38.4);
                yield return new nottem(135, 1931.16666666667, 38.4);
                yield return new nottem(136, 1931.25, 46.5);
                yield return new nottem(137, 1931.33333333333, 53.5);
                yield return new nottem(138, 1931.41666666667, 58.4);
                yield return new nottem(139, 1931.5, 60.6);
                yield return new nottem(140, 1931.58333333333, 58.2);
                yield return new nottem(141, 1931.66666666667, 53.8);
                yield return new nottem(142, 1931.75, 46.6);
                yield return new nottem(143, 1931.83333333333, 45.5);
                yield return new nottem(144, 1931.91666666667, 40.6);
                yield return new nottem(145, 1932, 42.4);
                yield return new nottem(146, 1932.08333333333, 38.4);
                yield return new nottem(147, 1932.16666666667, 40.3);
                yield return new nottem(148, 1932.25, 44.6);
                yield return new nottem(149, 1932.33333333333, 50.9);
                yield return new nottem(150, 1932.41666666667, 57);
                yield return new nottem(151, 1932.5, 62.1);
                yield return new nottem(152, 1932.58333333333, 63.5);
                yield return new nottem(153, 1932.66666666667, 56.3);
                yield return new nottem(154, 1932.75, 47.3);
                yield return new nottem(155, 1932.83333333333, 43.6);
                yield return new nottem(156, 1932.91666666667, 41.8);
                yield return new nottem(157, 1933, 36.2);
                yield return new nottem(158, 1933.08333333333, 39.3);
                yield return new nottem(159, 1933.16666666667, 44.5);
                yield return new nottem(160, 1933.25, 48.7);
                yield return new nottem(161, 1933.33333333333, 54.2);
                yield return new nottem(162, 1933.41666666667, 60.8);
                yield return new nottem(163, 1933.5, 65.5);
                yield return new nottem(164, 1933.58333333333, 64.9);
                yield return new nottem(165, 1933.66666666667, 60.1);
                yield return new nottem(166, 1933.75, 50.2);
                yield return new nottem(167, 1933.83333333333, 42.1);
                yield return new nottem(168, 1933.91666666667, 35.8);
                yield return new nottem(169, 1934, 39.4);
                yield return new nottem(170, 1934.08333333333, 38.2);
                yield return new nottem(171, 1934.16666666667, 40.4);
                yield return new nottem(172, 1934.25, 46.9);
                yield return new nottem(173, 1934.33333333333, 53.4);
                yield return new nottem(174, 1934.41666666667, 59.6);
                yield return new nottem(175, 1934.5, 66.5);
                yield return new nottem(176, 1934.58333333333, 60.4);
                yield return new nottem(177, 1934.66666666667, 59.2);
                yield return new nottem(178, 1934.75, 51.2);
                yield return new nottem(179, 1934.83333333333, 42.8);
                yield return new nottem(180, 1934.91666666667, 45.8);
                yield return new nottem(181, 1935, 40);
                yield return new nottem(182, 1935.08333333333, 42.6);
                yield return new nottem(183, 1935.16666666667, 43.5);
                yield return new nottem(184, 1935.25, 47.1);
                yield return new nottem(185, 1935.33333333333, 50);
                yield return new nottem(186, 1935.41666666667, 60.5);
                yield return new nottem(187, 1935.5, 64.6);
                yield return new nottem(188, 1935.58333333333, 64);
                yield return new nottem(189, 1935.66666666667, 56.8);
                yield return new nottem(190, 1935.75, 48.6);
                yield return new nottem(191, 1935.83333333333, 44.2);
                yield return new nottem(192, 1935.91666666667, 36.4);
                yield return new nottem(193, 1936, 37.3);
                yield return new nottem(194, 1936.08333333333, 35);
                yield return new nottem(195, 1936.16666666667, 44);
                yield return new nottem(196, 1936.25, 43.9);
                yield return new nottem(197, 1936.33333333333, 52.7);
                yield return new nottem(198, 1936.41666666667, 58.6);
                yield return new nottem(199, 1936.5, 60);
                yield return new nottem(200, 1936.58333333333, 61.1);
                yield return new nottem(201, 1936.66666666667, 58.1);
                yield return new nottem(202, 1936.75, 49.6);
                yield return new nottem(203, 1936.83333333333, 41.6);
                yield return new nottem(204, 1936.91666666667, 41.3);
                yield return new nottem(205, 1937, 40.8);
                yield return new nottem(206, 1937.08333333333, 41);
                yield return new nottem(207, 1937.16666666667, 38.4);
                yield return new nottem(208, 1937.25, 47.4);
                yield return new nottem(209, 1937.33333333333, 54.1);
                yield return new nottem(210, 1937.41666666667, 58.6);
                yield return new nottem(211, 1937.5, 61.4);
                yield return new nottem(212, 1937.58333333333, 61.8);
                yield return new nottem(213, 1937.66666666667, 56.3);
                yield return new nottem(214, 1937.75, 50.9);
                yield return new nottem(215, 1937.83333333333, 41.4);
                yield return new nottem(216, 1937.91666666667, 37.1);
                yield return new nottem(217, 1938, 42.1);
                yield return new nottem(218, 1938.08333333333, 41.2);
                yield return new nottem(219, 1938.16666666667, 47.3);
                yield return new nottem(220, 1938.25, 46.6);
                yield return new nottem(221, 1938.33333333333, 52.4);
                yield return new nottem(222, 1938.41666666667, 59);
                yield return new nottem(223, 1938.5, 59.6);
                yield return new nottem(224, 1938.58333333333, 60.4);
                yield return new nottem(225, 1938.66666666667, 57);
                yield return new nottem(226, 1938.75, 50.7);
                yield return new nottem(227, 1938.83333333333, 47.8);
                yield return new nottem(228, 1938.91666666667, 39.2);
                yield return new nottem(229, 1939, 39.4);
                yield return new nottem(230, 1939.08333333333, 40.9);
                yield return new nottem(231, 1939.16666666667, 42.4);
                yield return new nottem(232, 1939.25, 47.8);
                yield return new nottem(233, 1939.33333333333, 52.4);
                yield return new nottem(234, 1939.41666666667, 58);
                yield return new nottem(235, 1939.5, 60.7);
                yield return new nottem(236, 1939.58333333333, 61.8);
                yield return new nottem(237, 1939.66666666667, 58.2);
                yield return new nottem(238, 1939.75, 46.7);
                yield return new nottem(239, 1939.83333333333, 46.6);
                yield return new nottem(240, 1939.91666666667, 37.8);
            }
        }
    }
}
