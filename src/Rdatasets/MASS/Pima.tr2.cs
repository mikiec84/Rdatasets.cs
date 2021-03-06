// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Diabetes in Pima Indian Women
    /// </summary>

    public class Pima_tr2
    {
        public readonly int κ;
        public readonly int npreg;
        public readonly int glu;
        public readonly int? bp;
        public readonly int? skin;
        public readonly double? bmi;
        public readonly double ped;
        public readonly int age;
        public readonly string type;

        public Pima_tr2(int κ, int npreg, int glu, int? bp, int? skin, double? bmi, double ped, int age, string type)
        {
            this.κ = κ;
            this.npreg = npreg;
            this.glu = glu;
            this.bp = bp;
            this.skin = skin;
            this.bmi = bmi;
            this.ped = ped;
            this.age = age;
            this.type = type;
        }

        public static IEnumerable<Pima_tr2> Data
        {
            get
            {
                yield return new Pima_tr2(1, 5, 86, 68, 28, 30.2, 0.364, 24, "No");
                yield return new Pima_tr2(2, 7, 195, 70, 33, 25.1, 0.163, 55, "Yes");
                yield return new Pima_tr2(3, 5, 77, 82, 41, 35.8, 0.156, 35, "No");
                yield return new Pima_tr2(4, 0, 165, 76, 43, 47.9, 0.259, 26, "No");
                yield return new Pima_tr2(5, 0, 107, 60, 25, 26.4, 0.133, 23, "No");
                yield return new Pima_tr2(6, 5, 97, 76, 27, 35.6, 0.378, 52, "Yes");
                yield return new Pima_tr2(7, 3, 83, 58, 31, 34.3, 0.336, 25, "No");
                yield return new Pima_tr2(8, 1, 193, 50, 16, 25.9, 0.655, 24, "No");
                yield return new Pima_tr2(9, 3, 142, 80, 15, 32.4, 0.2, 63, "No");
                yield return new Pima_tr2(10, 2, 128, 78, 37, 43.3, 1.224, 31, "Yes");
                yield return new Pima_tr2(11, 0, 137, 40, 35, 43.1, 2.288, 33, "Yes");
                yield return new Pima_tr2(12, 9, 154, 78, 30, 30.9, 0.164, 45, "No");
                yield return new Pima_tr2(13, 1, 189, 60, 23, 30.1, 0.398, 59, "Yes");
                yield return new Pima_tr2(14, 12, 92, 62, 7, 27.6, 0.926, 44, "Yes");
                yield return new Pima_tr2(15, 1, 86, 66, 52, 41.3, 0.917, 29, "No");
                yield return new Pima_tr2(16, 4, 99, 76, 15, 23.2, 0.223, 21, "No");
                yield return new Pima_tr2(17, 1, 109, 60, 8, 25.4, 0.947, 21, "No");
                yield return new Pima_tr2(18, 11, 143, 94, 33, 36.6, 0.254, 51, "Yes");
                yield return new Pima_tr2(19, 1, 149, 68, 29, 29.3, 0.349, 42, "Yes");
                yield return new Pima_tr2(20, 0, 139, 62, 17, 22.1, 0.207, 21, "No");
                yield return new Pima_tr2(21, 2, 99, 70, 16, 20.4, 0.235, 27, "No");
                yield return new Pima_tr2(22, 1, 100, 66, 29, 32, 0.444, 42, "No");
                yield return new Pima_tr2(23, 4, 83, 86, 19, 29.3, 0.317, 34, "No");
                yield return new Pima_tr2(24, 0, 101, 64, 17, 21, 0.252, 21, "No");
                yield return new Pima_tr2(25, 1, 87, 68, 34, 37.6, 0.401, 24, "No");
                yield return new Pima_tr2(26, 9, 164, 84, 21, 30.8, 0.831, 32, "Yes");
                yield return new Pima_tr2(27, 1, 99, 58, 10, 25.4, 0.551, 21, "No");
                yield return new Pima_tr2(28, 0, 140, 65, 26, 42.6, 0.431, 24, "Yes");
                yield return new Pima_tr2(29, 5, 108, 72, 43, 36.1, 0.263, 33, "No");
                yield return new Pima_tr2(30, 2, 110, 74, 29, 32.4, 0.698, 27, "No");
                yield return new Pima_tr2(31, 1, 79, 60, 42, 43.5, 0.678, 23, "No");
                yield return new Pima_tr2(32, 3, 148, 66, 25, 32.5, 0.256, 22, "No");
                yield return new Pima_tr2(33, 0, 121, 66, 30, 34.3, 0.203, 33, "Yes");
                yield return new Pima_tr2(34, 3, 158, 64, 13, 31.2, 0.295, 24, "No");
                yield return new Pima_tr2(35, 2, 105, 80, 45, 33.7, 0.711, 29, "Yes");
                yield return new Pima_tr2(36, 13, 145, 82, 19, 22.2, 0.245, 57, "No");
                yield return new Pima_tr2(37, 1, 79, 80, 25, 25.4, 0.583, 22, "No");
                yield return new Pima_tr2(38, 1, 71, 48, 18, 20.4, 0.323, 22, "No");
                yield return new Pima_tr2(39, 0, 102, 86, 17, 29.3, 0.695, 27, "No");
                yield return new Pima_tr2(40, 0, 119, 66, 27, 38.8, 0.259, 22, "No");
                yield return new Pima_tr2(41, 8, 176, 90, 34, 33.7, 0.467, 58, "Yes");
                yield return new Pima_tr2(42, 1, 97, 68, 21, 27.2, 1.095, 22, "No");
                yield return new Pima_tr2(43, 4, 129, 60, 12, 27.5, 0.527, 31, "No");
                yield return new Pima_tr2(44, 1, 97, 64, 19, 18.2, 0.299, 21, "No");
                yield return new Pima_tr2(45, 0, 86, 68, 32, 35.8, 0.238, 25, "No");
                yield return new Pima_tr2(46, 2, 125, 60, 20, 33.8, 0.088, 31, "No");
                yield return new Pima_tr2(47, 5, 123, 74, 40, 34.1, 0.269, 28, "No");
                yield return new Pima_tr2(48, 2, 92, 76, 20, 24.2, 1.698, 28, "No");
                yield return new Pima_tr2(49, 3, 171, 72, 33, 33.3, 0.199, 24, "Yes");
                yield return new Pima_tr2(50, 1, 199, 76, 43, 42.9, 1.394, 22, "Yes");
                yield return new Pima_tr2(51, 3, 116, 74, 15, 26.3, 0.107, 24, "No");
                yield return new Pima_tr2(52, 2, 83, 66, 23, 32.2, 0.497, 22, "No");
                yield return new Pima_tr2(53, 8, 154, 78, 32, 32.4, 0.443, 45, "Yes");
                yield return new Pima_tr2(54, 1, 114, 66, 36, 38.1, 0.289, 21, "No");
                yield return new Pima_tr2(55, 1, 106, 70, 28, 34.2, 0.142, 22, "No");
                yield return new Pima_tr2(56, 4, 127, 88, 11, 34.5, 0.598, 28, "No");
                yield return new Pima_tr2(57, 1, 124, 74, 36, 27.8, 0.1, 30, "No");
                yield return new Pima_tr2(58, 1, 109, 38, 18, 23.1, 0.407, 26, "No");
                yield return new Pima_tr2(59, 2, 123, 48, 32, 42.1, 0.52, 26, "No");
                yield return new Pima_tr2(60, 8, 167, 106, 46, 37.6, 0.165, 43, "Yes");
                yield return new Pima_tr2(61, 7, 184, 84, 33, 35.5, 0.355, 41, "Yes");
                yield return new Pima_tr2(62, 1, 96, 64, 27, 33.2, 0.289, 21, "No");
                yield return new Pima_tr2(63, 10, 129, 76, 28, 35.9, 0.28, 39, "No");
                yield return new Pima_tr2(64, 6, 92, 62, 32, 32, 0.085, 46, "No");
                yield return new Pima_tr2(65, 6, 109, 60, 27, 25, 0.206, 27, "No");
                yield return new Pima_tr2(66, 5, 139, 80, 35, 31.6, 0.361, 25, "Yes");
                yield return new Pima_tr2(67, 6, 134, 70, 23, 35.4, 0.542, 29, "Yes");
                yield return new Pima_tr2(68, 3, 106, 54, 21, 30.9, 0.292, 24, "No");
                yield return new Pima_tr2(69, 0, 131, 66, 40, 34.3, 0.196, 22, "Yes");
                yield return new Pima_tr2(70, 0, 135, 94, 46, 40.6, 0.284, 26, "No");
                yield return new Pima_tr2(71, 5, 158, 84, 41, 39.4, 0.395, 29, "Yes");
                yield return new Pima_tr2(72, 3, 112, 74, 30, 31.6, 0.197, 25, "Yes");
                yield return new Pima_tr2(73, 8, 181, 68, 36, 30.1, 0.615, 60, "Yes");
                yield return new Pima_tr2(74, 2, 121, 70, 32, 39.1, 0.886, 23, "No");
                yield return new Pima_tr2(75, 1, 168, 88, 29, 35, 0.905, 52, "Yes");
                yield return new Pima_tr2(76, 1, 144, 82, 46, 46.1, 0.335, 46, "Yes");
                yield return new Pima_tr2(77, 2, 101, 58, 17, 24.2, 0.614, 23, "No");
                yield return new Pima_tr2(78, 2, 96, 68, 13, 21.1, 0.647, 26, "No");
                yield return new Pima_tr2(79, 3, 107, 62, 13, 22.9, 0.678, 23, "Yes");
                yield return new Pima_tr2(80, 12, 121, 78, 17, 26.5, 0.259, 62, "No");
                yield return new Pima_tr2(81, 2, 100, 64, 23, 29.7, 0.368, 21, "No");
                yield return new Pima_tr2(82, 4, 154, 72, 29, 31.3, 0.338, 37, "No");
                yield return new Pima_tr2(83, 6, 125, 78, 31, 27.6, 0.565, 49, "Yes");
                yield return new Pima_tr2(84, 10, 125, 70, 26, 31.1, 0.205, 41, "Yes");
                yield return new Pima_tr2(85, 2, 122, 76, 27, 35.9, 0.483, 26, "No");
                yield return new Pima_tr2(86, 2, 114, 68, 22, 28.7, 0.092, 25, "No");
                yield return new Pima_tr2(87, 1, 115, 70, 30, 34.6, 0.529, 32, "Yes");
                yield return new Pima_tr2(88, 7, 114, 76, 17, 23.8, 0.466, 31, "No");
                yield return new Pima_tr2(89, 2, 115, 64, 22, 30.8, 0.421, 21, "No");
                yield return new Pima_tr2(90, 1, 130, 60, 23, 28.6, 0.692, 21, "No");
                yield return new Pima_tr2(91, 1, 79, 75, 30, 32, 0.396, 22, "No");
                yield return new Pima_tr2(92, 4, 112, 78, 40, 39.4, 0.236, 38, "No");
                yield return new Pima_tr2(93, 7, 150, 78, 29, 35.2, 0.692, 54, "Yes");
                yield return new Pima_tr2(94, 1, 91, 54, 25, 25.2, 0.234, 23, "No");
                yield return new Pima_tr2(95, 1, 100, 72, 12, 25.3, 0.658, 28, "No");
                yield return new Pima_tr2(96, 12, 140, 82, 43, 39.2, 0.528, 58, "Yes");
                yield return new Pima_tr2(97, 4, 110, 76, 20, 28.4, 0.118, 27, "No");
                yield return new Pima_tr2(98, 2, 94, 76, 18, 31.6, 0.649, 23, "No");
                yield return new Pima_tr2(99, 2, 84, 50, 23, 30.4, 0.968, 21, "No");
                yield return new Pima_tr2(100, 10, 148, 84, 48, 37.6, 1.001, 51, "Yes");
                yield return new Pima_tr2(101, 3, 61, 82, 28, 34.4, 0.243, 46, "No");
                yield return new Pima_tr2(102, 4, 117, 62, 12, 29.7, 0.38, 30, "Yes");
                yield return new Pima_tr2(103, 3, 99, 80, 11, 19.3, 0.284, 30, "No");
                yield return new Pima_tr2(104, 3, 80, 82, 31, 34.2, 1.292, 27, "Yes");
                yield return new Pima_tr2(105, 4, 154, 62, 31, 32.8, 0.237, 23, "No");
                yield return new Pima_tr2(106, 6, 103, 72, 32, 37.7, 0.324, 55, "No");
                yield return new Pima_tr2(107, 6, 111, 64, 39, 34.2, 0.26, 24, "No");
                yield return new Pima_tr2(108, 0, 124, 70, 20, 27.4, 0.254, 36, "Yes");
                yield return new Pima_tr2(109, 1, 143, 74, 22, 26.2, 0.256, 21, "No");
                yield return new Pima_tr2(110, 1, 81, 74, 41, 46.3, 1.096, 32, "No");
                yield return new Pima_tr2(111, 4, 189, 110, 31, 28.5, 0.68, 37, "No");
                yield return new Pima_tr2(112, 4, 116, 72, 12, 22.1, 0.463, 37, "No");
                yield return new Pima_tr2(113, 7, 103, 66, 32, 39.1, 0.344, 31, "Yes");
                yield return new Pima_tr2(114, 8, 124, 76, 24, 28.7, 0.687, 52, "Yes");
                yield return new Pima_tr2(115, 1, 71, 78, 50, 33.2, 0.422, 21, "No");
                yield return new Pima_tr2(116, 0, 137, 84, 27, 27.3, 0.231, 59, "No");
                yield return new Pima_tr2(117, 9, 112, 82, 32, 34.2, 0.26, 36, "Yes");
                yield return new Pima_tr2(118, 4, 148, 60, 27, 30.9, 0.15, 29, "Yes");
                yield return new Pima_tr2(119, 1, 136, 74, 50, 37.4, 0.399, 24, "No");
                yield return new Pima_tr2(120, 9, 145, 80, 46, 37.9, 0.637, 40, "Yes");
                yield return new Pima_tr2(121, 1, 93, 56, 11, 22.5, 0.417, 22, "No");
                yield return new Pima_tr2(122, 1, 107, 72, 30, 30.8, 0.821, 24, "No");
                yield return new Pima_tr2(123, 12, 151, 70, 40, 41.8, 0.742, 38, "Yes");
                yield return new Pima_tr2(124, 1, 97, 70, 40, 38.1, 0.218, 30, "No");
                yield return new Pima_tr2(125, 5, 144, 82, 26, 32, 0.452, 58, "Yes");
                yield return new Pima_tr2(126, 2, 112, 86, 42, 38.4, 0.246, 28, "No");
                yield return new Pima_tr2(127, 2, 99, 52, 15, 24.6, 0.637, 21, "No");
                yield return new Pima_tr2(128, 1, 109, 56, 21, 25.2, 0.833, 23, "No");
                yield return new Pima_tr2(129, 1, 120, 80, 48, 38.9, 1.162, 41, "No");
                yield return new Pima_tr2(130, 7, 187, 68, 39, 37.7, 0.254, 41, "Yes");
                yield return new Pima_tr2(131, 3, 129, 92, 49, 36.4, 0.968, 32, "Yes");
                yield return new Pima_tr2(132, 7, 179, 95, 31, 34.2, 0.164, 60, "No");
                yield return new Pima_tr2(133, 6, 80, 66, 30, 26.2, 0.313, 41, "No");
                yield return new Pima_tr2(134, 2, 105, 58, 40, 34.9, 0.225, 25, "No");
                yield return new Pima_tr2(135, 3, 191, 68, 15, 30.9, 0.299, 34, "No");
                yield return new Pima_tr2(136, 0, 95, 80, 45, 36.5, 0.33, 26, "No");
                yield return new Pima_tr2(137, 4, 99, 72, 17, 25.6, 0.294, 28, "No");
                yield return new Pima_tr2(138, 0, 137, 68, 14, 24.8, 0.143, 21, "No");
                yield return new Pima_tr2(139, 1, 97, 70, 15, 18.2, 0.147, 21, "No");
                yield return new Pima_tr2(140, 0, 100, 88, 60, 46.8, 0.962, 31, "No");
                yield return new Pima_tr2(141, 1, 167, 74, 17, 23.4, 0.447, 33, "Yes");
                yield return new Pima_tr2(142, 0, 180, 90, 26, 36.5, 0.314, 35, "Yes");
                yield return new Pima_tr2(143, 2, 122, 70, 27, 36.8, 0.34, 27, "No");
                yield return new Pima_tr2(144, 1, 90, 62, 12, 27.2, 0.58, 24, "No");
                yield return new Pima_tr2(145, 3, 120, 70, 30, 42.9, 0.452, 30, "No");
                yield return new Pima_tr2(146, 6, 154, 78, 41, 46.1, 0.571, 27, "No");
                yield return new Pima_tr2(147, 2, 56, 56, 28, 24.2, 0.332, 22, "No");
                yield return new Pima_tr2(148, 0, 177, 60, 29, 34.6, 1.072, 21, "Yes");
                yield return new Pima_tr2(149, 3, 124, 80, 33, 33.2, 0.305, 26, "No");
                yield return new Pima_tr2(150, 8, 85, 55, 20, 24.4, 0.136, 42, "No");
                yield return new Pima_tr2(151, 12, 88, 74, 40, 35.3, 0.378, 48, "No");
                yield return new Pima_tr2(152, 9, 152, 78, 34, 34.2, 0.893, 33, "Yes");
                yield return new Pima_tr2(153, 0, 198, 66, 32, 41.3, 0.502, 28, "Yes");
                yield return new Pima_tr2(154, 0, 188, 82, 14, 32, 0.682, 22, "Yes");
                yield return new Pima_tr2(155, 5, 139, 64, 35, 28.6, 0.411, 26, "No");
                yield return new Pima_tr2(156, 7, 168, 88, 42, 38.2, 0.787, 40, "Yes");
                yield return new Pima_tr2(157, 2, 197, 70, 99, 34.7, 0.575, 62, "Yes");
                yield return new Pima_tr2(158, 2, 142, 82, 18, 24.7, 0.761, 21, "No");
                yield return new Pima_tr2(159, 8, 126, 74, 38, 25.9, 0.162, 39, "No");
                yield return new Pima_tr2(160, 3, 158, 76, 36, 31.6, 0.851, 28, "Yes");
                yield return new Pima_tr2(161, 3, 130, 78, 23, 28.4, 0.323, 34, "Yes");
                yield return new Pima_tr2(162, 2, 100, 54, 28, 37.8, 0.498, 24, "No");
                yield return new Pima_tr2(163, 1, 164, 82, 43, 32.8, 0.341, 50, "No");
                yield return new Pima_tr2(164, 4, 95, 60, 32, 35.4, 0.284, 28, "No");
                yield return new Pima_tr2(165, 2, 122, 52, 43, 36.2, 0.816, 28, "No");
                yield return new Pima_tr2(166, 4, 85, 58, 22, 27.8, 0.306, 28, "No");
                yield return new Pima_tr2(167, 0, 151, 90, 46, 42.1, 0.371, 21, "Yes");
                yield return new Pima_tr2(168, 6, 144, 72, 27, 33.9, 0.255, 40, "No");
                yield return new Pima_tr2(169, 3, 111, 90, 12, 28.4, 0.495, 29, "No");
                yield return new Pima_tr2(170, 1, 107, 68, 19, 26.5, 0.165, 24, "No");
                yield return new Pima_tr2(171, 6, 115, 60, 39, 33.7, 0.245, 40, "Yes");
                yield return new Pima_tr2(172, 5, 105, 72, 29, 36.9, 0.159, 28, "No");
                yield return new Pima_tr2(173, 7, 194, 68, 28, 35.9, 0.745, 41, "Yes");
                yield return new Pima_tr2(174, 4, 184, 78, 39, 37, 0.264, 31, "Yes");
                yield return new Pima_tr2(175, 0, 95, 85, 25, 37.4, 0.247, 24, "Yes");
                yield return new Pima_tr2(176, 7, 124, 70, 33, 25.5, 0.161, 37, "No");
                yield return new Pima_tr2(177, 1, 111, 62, 13, 24, 0.138, 23, "No");
                yield return new Pima_tr2(178, 7, 137, 90, 41, 32, 0.391, 39, "No");
                yield return new Pima_tr2(179, 9, 57, 80, 37, 32.8, 0.096, 41, "No");
                yield return new Pima_tr2(180, 2, 157, 74, 35, 39.4, 0.134, 30, "No");
                yield return new Pima_tr2(181, 2, 95, 54, 14, 26.1, 0.748, 22, "No");
                yield return new Pima_tr2(182, 12, 140, 85, 33, 37.4, 0.244, 41, "No");
                yield return new Pima_tr2(183, 0, 117, 66, 31, 30.8, 0.493, 22, "No");
                yield return new Pima_tr2(184, 8, 100, 74, 40, 39.4, 0.661, 43, "Yes");
                yield return new Pima_tr2(185, 9, 123, 70, 44, 33.1, 0.374, 40, "No");
                yield return new Pima_tr2(186, 0, 138, 60, 35, 34.6, 0.534, 21, "Yes");
                yield return new Pima_tr2(187, 14, 100, 78, 25, 36.6, 0.412, 46, "Yes");
                yield return new Pima_tr2(188, 14, 175, 62, 30, 33.6, 0.212, 38, "Yes");
                yield return new Pima_tr2(189, 0, 74, 52, 10, 27.8, 0.269, 22, "No");
                yield return new Pima_tr2(190, 1, 133, 102, 28, 32.8, 0.234, 45, "Yes");
                yield return new Pima_tr2(191, 0, 119, 64, 18, 34.9, 0.725, 23, "No");
                yield return new Pima_tr2(192, 5, 155, 84, 44, 38.7, 0.619, 34, "No");
                yield return new Pima_tr2(193, 1, 128, 48, 45, 40.5, 0.613, 24, "Yes");
                yield return new Pima_tr2(194, 2, 112, 68, 22, 34.1, 0.315, 26, "No");
                yield return new Pima_tr2(195, 1, 140, 74, 26, 24.1, 0.828, 23, "No");
                yield return new Pima_tr2(196, 2, 141, 58, 34, 25.4, 0.699, 24, "No");
                yield return new Pima_tr2(197, 7, 129, 68, 49, 38.5, 0.439, 43, "Yes");
                yield return new Pima_tr2(198, 0, 106, 70, 37, 39.4, 0.605, 22, "No");
                yield return new Pima_tr2(199, 1, 118, 58, 36, 33.3, 0.261, 23, "No");
                yield return new Pima_tr2(200, 8, 155, 62, 26, 34, 0.543, 46, "Yes");
                yield return new Pima_tr2(201, 2, 134, 70, null, 28.9, 0.542, 23, "Yes");
                yield return new Pima_tr2(202, 10, 75, 82, null, 33.3, 0.263, 38, "No");
                yield return new Pima_tr2(203, 0, 146, 70, null, 37.9, 0.334, 28, "Yes");
                yield return new Pima_tr2(204, 1, 180, null, null, 43.3, 0.282, 41, "Yes");
                yield return new Pima_tr2(205, 5, 104, 74, null, 28.8, 0.153, 48, "No");
                yield return new Pima_tr2(206, 9, 164, 78, null, 32.8, 0.148, 45, "Yes");
                yield return new Pima_tr2(207, 1, 80, 55, null, 19.1, 0.258, 21, "No");
                yield return new Pima_tr2(208, 4, 171, 72, null, 43.6, 0.479, 26, "Yes");
                yield return new Pima_tr2(209, 3, 139, 54, null, 25.6, 0.402, 22, "Yes");
                yield return new Pima_tr2(210, 3, 122, 78, null, 23, 0.254, 40, "No");
                yield return new Pima_tr2(211, 5, 116, 74, null, 25.6, 0.201, 30, "No");
                yield return new Pima_tr2(212, 6, 195, 70, null, 30.9, 0.328, 31, "Yes");
                yield return new Pima_tr2(213, 8, 125, 96, null, null, 0.232, 54, "Yes");
                yield return new Pima_tr2(214, 4, 122, 68, null, 35, 0.394, 29, "No");
                yield return new Pima_tr2(215, 0, 107, 76, null, 45.3, 0.686, 24, "No");
                yield return new Pima_tr2(216, 1, 151, 60, null, 26.1, 0.179, 22, "No");
                yield return new Pima_tr2(217, 9, 165, 88, null, 30.4, 0.302, 49, "Yes");
                yield return new Pima_tr2(218, 10, 168, 74, null, 38, 0.537, 34, "Yes");
                yield return new Pima_tr2(219, 3, 102, 74, null, 29.5, 0.121, 32, "No");
                yield return new Pima_tr2(220, 13, 76, 60, null, 32.8, 0.18, 41, "No");
                yield return new Pima_tr2(221, 5, 143, 78, null, 45, 0.19, 47, "No");
                yield return new Pima_tr2(222, 6, 124, 72, null, 27.6, 0.368, 29, "Yes");
                yield return new Pima_tr2(223, 8, 95, 72, null, 36.8, 0.485, 57, "No");
                yield return new Pima_tr2(224, 3, 78, 70, null, 32.5, 0.27, 39, "No");
                yield return new Pima_tr2(225, 5, 112, 66, null, 37.8, 0.261, 41, "Yes");
                yield return new Pima_tr2(226, 5, 73, 60, null, 26.8, 0.268, 27, "No");
                yield return new Pima_tr2(227, 0, 102, 52, null, 25.1, 0.078, 21, "No");
                yield return new Pima_tr2(228, 2, 109, 92, null, 42.7, 0.845, 54, "No");
                yield return new Pima_tr2(229, 4, 114, 65, null, 21.9, 0.432, 37, "No");
                yield return new Pima_tr2(230, 0, 102, 75, 23, null, 0.572, 21, "No");
                yield return new Pima_tr2(231, 10, 133, 68, null, 27, 0.245, 36, "No");
                yield return new Pima_tr2(232, 4, 118, 70, null, 44.5, 0.904, 26, "No");
                yield return new Pima_tr2(233, 7, 136, 90, null, 29.9, 0.21, 50, "No");
                yield return new Pima_tr2(234, 7, 100, null, null, 30, 0.484, 32, "Yes");
                yield return new Pima_tr2(235, 1, 138, 82, null, 40.1, 0.236, 28, "No");
                yield return new Pima_tr2(236, 0, 131, null, null, 43.2, 0.27, 26, "Yes");
                yield return new Pima_tr2(237, 2, 111, 60, null, 26.2, 0.343, 23, "No");
                yield return new Pima_tr2(238, 7, 133, 84, null, 40.2, 0.696, 37, "No");
                yield return new Pima_tr2(239, 6, 137, 61, null, 24.2, 0.151, 55, "No");
                yield return new Pima_tr2(240, 5, 115, 98, null, 52.9, 0.209, 28, "Yes");
                yield return new Pima_tr2(241, 3, 125, 58, null, 31.6, 0.151, 24, "No");
                yield return new Pima_tr2(242, 4, 142, 86, null, 44, 0.645, 22, "Yes");
                yield return new Pima_tr2(243, 4, 146, 92, null, 31.2, 0.539, 61, "Yes");
                yield return new Pima_tr2(244, 4, 128, 70, null, 34.3, 0.303, 24, "No");
                yield return new Pima_tr2(245, 0, 132, 78, null, 32.4, 0.393, 21, "No");
                yield return new Pima_tr2(246, 4, 134, 72, null, 23.8, 0.277, 60, "Yes");
                yield return new Pima_tr2(247, 2, 120, 54, null, 26.8, 0.455, 27, "No");
                yield return new Pima_tr2(248, 0, 111, 65, null, 24.6, 0.66, 31, "No");
                yield return new Pima_tr2(249, 2, 139, 75, null, 25.6, 0.167, 29, "No");
                yield return new Pima_tr2(250, 1, 106, 76, null, 37.5, 0.197, 26, "No");
                yield return new Pima_tr2(251, 6, 147, 80, null, 29.5, 0.178, 50, "Yes");
                yield return new Pima_tr2(252, 8, 107, 80, null, 24.6, 0.856, 34, "No");
                yield return new Pima_tr2(253, 4, 183, null, null, 28.4, 0.212, 36, "Yes");
                yield return new Pima_tr2(254, 6, 96, null, null, 23.7, 0.19, 28, "No");
                yield return new Pima_tr2(255, 4, 158, 78, null, 32.9, 0.803, 31, "Yes");
                yield return new Pima_tr2(256, 11, 127, 106, null, 39, 0.19, 51, "No");
                yield return new Pima_tr2(257, 6, 87, 80, null, 23.2, 0.084, 32, "No");
                yield return new Pima_tr2(258, 4, 123, 62, null, 32, 0.226, 35, "Yes");
                yield return new Pima_tr2(259, 2, 118, 80, null, 42.9, 0.693, 21, "Yes");
                yield return new Pima_tr2(260, 6, 103, 66, null, 24.3, 0.249, 29, "No");
                yield return new Pima_tr2(261, 4, 110, 66, null, 31.9, 0.471, 29, "No");
                yield return new Pima_tr2(262, 5, 147, 78, null, 33.7, 0.218, 65, "No");
                yield return new Pima_tr2(263, 0, 119, null, null, 32.4, 0.141, 24, "Yes");
                yield return new Pima_tr2(264, 4, 156, 75, null, 48.3, 0.238, 32, "Yes");
                yield return new Pima_tr2(265, 8, 197, 74, null, 25.9, 1.191, 39, "Yes");
                yield return new Pima_tr2(266, 6, 102, 82, null, 30.8, 0.18, 36, "Yes");
                yield return new Pima_tr2(267, 0, 131, 88, null, 31.6, 0.743, 32, "Yes");
                yield return new Pima_tr2(268, 5, 136, 82, null, null, 0.64, 69, "No");
                yield return new Pima_tr2(269, 13, 158, 114, null, 42.3, 0.257, 44, "Yes");
                yield return new Pima_tr2(270, 0, 93, 60, null, 35.3, 0.263, 25, "No");
                yield return new Pima_tr2(271, 2, 87, null, 23, 28.9, 0.773, 25, "No");
                yield return new Pima_tr2(272, 10, 108, 66, null, 32.4, 0.272, 42, "Yes");
                yield return new Pima_tr2(273, 10, 139, 80, null, 27.1, 1.441, 57, "No");
                yield return new Pima_tr2(274, 4, 110, 92, null, 37.6, 0.191, 30, "No");
                yield return new Pima_tr2(275, 4, 114, 64, null, 28.9, 0.126, 24, "No");
                yield return new Pima_tr2(276, 0, 101, 62, null, 21.9, 0.336, 25, "No");
                yield return new Pima_tr2(277, 2, 91, 62, null, 27.3, 0.525, 22, "No");
                yield return new Pima_tr2(278, 8, 133, 72, null, 32.9, 0.27, 39, "Yes");
                yield return new Pima_tr2(279, 1, 111, 94, null, 32.8, 0.265, 45, "No");
                yield return new Pima_tr2(280, 5, 147, 75, null, 29.9, 0.434, 28, "No");
                yield return new Pima_tr2(281, 4, 92, 80, null, 42.2, 0.237, 29, "No");
                yield return new Pima_tr2(282, 2, 90, 60, null, 23.5, 0.191, 25, "No");
                yield return new Pima_tr2(283, 7, 114, 64, null, 27.4, 0.732, 34, "Yes");
                yield return new Pima_tr2(284, 7, 125, 86, null, 37.6, 0.304, 51, "No");
                yield return new Pima_tr2(285, 2, 119, null, null, 19.6, 0.832, 72, "No");
                yield return new Pima_tr2(286, 5, 115, 76, null, 31.2, 0.343, 44, "Yes");
                yield return new Pima_tr2(287, 0, 141, null, null, 42.4, 0.205, 29, "Yes");
                yield return new Pima_tr2(288, 0, 167, null, null, 32.3, 0.839, 30, "Yes");
                yield return new Pima_tr2(289, 4, 90, null, null, 28, 0.61, 31, "No");
                yield return new Pima_tr2(290, 5, 132, 80, null, 26.8, 0.186, 69, "No");
                yield return new Pima_tr2(291, 0, 125, 96, null, 22.5, 0.262, 21, "No");
                yield return new Pima_tr2(292, 3, 150, 76, null, 21, 0.207, 37, "No");
                yield return new Pima_tr2(293, 4, 95, 64, null, 32, 0.161, 31, "Yes");
                yield return new Pima_tr2(294, 4, 136, 70, null, 31.2, 1.182, 22, "Yes");
                yield return new Pima_tr2(295, 8, 110, 76, null, 27.8, 0.237, 58, "No");
                yield return new Pima_tr2(296, 0, 125, 68, null, 24.7, 0.206, 21, "No");
                yield return new Pima_tr2(297, 6, 92, 92, null, 19.9, 0.188, 28, "No");
                yield return new Pima_tr2(298, 3, 141, null, null, 30, 0.761, 27, "Yes");
                yield return new Pima_tr2(299, 0, 73, null, null, 21.1, 0.342, 25, "No");
                yield return new Pima_tr2(300, 2, 129, 84, null, 28, 0.284, 27, "No");
            }
        }
    }
}
