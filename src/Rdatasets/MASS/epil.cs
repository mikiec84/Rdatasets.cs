// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Seizure Counts for Epileptics
    /// </summary>

    public class epil
    {
        public readonly int κ;
        public readonly int y;
        public readonly string trt;
        public readonly int @base;
        public readonly int age;
        public readonly int V4;
        public readonly int subject;
        public readonly int period;
        public readonly double lbase;
        public readonly double lage;

        public epil(int κ, int y, string trt, int @base, int age, int V4, int subject, int period, double lbase, double lage)
        {
            this.κ = κ;
            this.y = y;
            this.trt = trt;
            this.@base = @base;
            this.age = age;
            this.V4 = V4;
            this.subject = subject;
            this.period = period;
            this.lbase = lbase;
            this.lage = lage;
        }

        public static IEnumerable<epil> Data
        {
            get
            {
                yield return new epil(1, 5, "placebo", 11, 31, 0, 1, 1, -0.756353788717556, 0.114203695299265);
                yield return new epil(2, 3, "placebo", 11, 31, 0, 1, 2, -0.756353788717556, 0.114203695299265);
                yield return new epil(3, 3, "placebo", 11, 31, 0, 1, 3, -0.756353788717556, 0.114203695299265);
                yield return new epil(4, 3, "placebo", 11, 31, 1, 1, 4, -0.756353788717556, 0.114203695299265);
                yield return new epil(5, 3, "placebo", 11, 30, 0, 2, 1, -0.756353788717556, 0.0814138724762743);
                yield return new epil(6, 5, "placebo", 11, 30, 0, 2, 2, -0.756353788717556, 0.0814138724762743);
                yield return new epil(7, 3, "placebo", 11, 30, 0, 2, 3, -0.756353788717556, 0.0814138724762743);
                yield return new epil(8, 3, "placebo", 11, 30, 1, 2, 4, -0.756353788717556, 0.0814138724762743);
                yield return new epil(9, 2, "placebo", 6, 25, 0, 3, 1, -1.36248959228787, -0.10090768431768);
                yield return new epil(10, 4, "placebo", 6, 25, 0, 3, 2, -1.36248959228787, -0.10090768431768);
                yield return new epil(11, 0, "placebo", 6, 25, 0, 3, 3, -1.36248959228787, -0.10090768431768);
                yield return new epil(12, 5, "placebo", 6, 25, 1, 3, 4, -1.36248959228787, -0.10090768431768);
                yield return new epil(13, 4, "placebo", 8, 36, 0, 4, 1, -1.07480751983609, 0.263735429270229);
                yield return new epil(14, 4, "placebo", 8, 36, 0, 4, 2, -1.07480751983609, 0.263735429270229);
                yield return new epil(15, 1, "placebo", 8, 36, 0, 4, 3, -1.07480751983609, 0.263735429270229);
                yield return new epil(16, 4, "placebo", 8, 36, 1, 4, 4, -1.07480751983609, 0.263735429270229);
                yield return new epil(17, 7, "placebo", 66, 22, 0, 5, 1, 1.0354056805105, -0.228741055827565);
                yield return new epil(18, 18, "placebo", 66, 22, 0, 5, 2, 1.0354056805105, -0.228741055827565);
                yield return new epil(19, 9, "placebo", 66, 22, 0, 5, 3, 1.0354056805105, -0.228741055827565);
                yield return new epil(20, 21, "placebo", 66, 22, 1, 5, 4, 1.0354056805105, -0.228741055827565);
                yield return new epil(21, 5, "placebo", 27, 29, 0, 6, 1, 0.141587804488402, 0.047512320800593);
                yield return new epil(22, 2, "placebo", 27, 29, 0, 6, 2, 0.141587804488402, 0.047512320800593);
                yield return new epil(23, 8, "placebo", 27, 29, 0, 6, 3, 0.141587804488402, 0.047512320800593);
                yield return new epil(24, 7, "placebo", 27, 29, 1, 6, 4, 0.141587804488402, 0.047512320800593);
                yield return new epil(25, 6, "placebo", 12, 31, 0, 7, 1, -0.669342411727926, 0.114203695299265);
                yield return new epil(26, 4, "placebo", 12, 31, 0, 7, 2, -0.669342411727926, 0.114203695299265);
                yield return new epil(27, 0, "placebo", 12, 31, 0, 7, 3, -0.669342411727926, 0.114203695299265);
                yield return new epil(28, 2, "placebo", 12, 31, 1, 7, 4, -0.669342411727926, 0.114203695299265);
                yield return new epil(29, 40, "placebo", 52, 42, 0, 8, 1, 0.796994657065501, 0.417886109097487);
                yield return new epil(30, 20, "placebo", 52, 42, 0, 8, 2, 0.796994657065501, 0.417886109097487);
                yield return new epil(31, 21, "placebo", 52, 42, 0, 8, 3, 0.796994657065501, 0.417886109097487);
                yield return new epil(32, 12, "placebo", 52, 42, 1, 8, 4, 0.796994657065501, 0.417886109097487);
                yield return new epil(33, 5, "placebo", 23, 37, 0, 9, 1, -0.018754845586777, 0.291134403458343);
                yield return new epil(34, 6, "placebo", 23, 37, 0, 9, 2, -0.018754845586777, 0.291134403458343);
                yield return new epil(35, 6, "placebo", 23, 37, 0, 9, 3, -0.018754845586777, 0.291134403458343);
                yield return new epil(36, 5, "placebo", 23, 37, 1, 9, 4, -0.018754845586777, 0.291134403458343);
                yield return new epil(37, 14, "placebo", 10, 28, 0, 10, 1, -0.851663968521881, 0.0124210009893226);
                yield return new epil(38, 13, "placebo", 10, 28, 0, 10, 2, -0.851663968521881, 0.0124210009893226);
                yield return new epil(39, 6, "placebo", 10, 28, 0, 10, 3, -0.851663968521881, 0.0124210009893226);
                yield return new epil(40, 0, "placebo", 10, 28, 1, 10, 4, -0.851663968521881, 0.0124210009893226);
                yield return new epil(41, 26, "placebo", 52, 36, 0, 11, 1, 0.796994657065501, 0.263735429270229);
                yield return new epil(42, 12, "placebo", 52, 36, 0, 11, 2, 0.796994657065501, 0.263735429270229);
                yield return new epil(43, 6, "placebo", 52, 36, 0, 11, 3, 0.796994657065501, 0.263735429270229);
                yield return new epil(44, 22, "placebo", 52, 36, 1, 11, 4, 0.796994657065501, 0.263735429270229);
                yield return new epil(45, 12, "placebo", 33, 24, 0, 12, 1, 0.342258499950553, -0.141729678837935);
                yield return new epil(46, 6, "placebo", 33, 24, 0, 12, 2, 0.342258499950553, -0.141729678837935);
                yield return new epil(47, 8, "placebo", 33, 24, 0, 12, 3, 0.342258499950553, -0.141729678837935);
                yield return new epil(48, 4, "placebo", 33, 24, 1, 12, 4, 0.342258499950553, -0.141729678837935);
                yield return new epil(49, 4, "placebo", 18, 23, 0, 13, 1, -0.263877303619762, -0.184289293256731);
                yield return new epil(50, 4, "placebo", 18, 23, 0, 13, 2, -0.263877303619762, -0.184289293256731);
                yield return new epil(51, 6, "placebo", 18, 23, 0, 13, 3, -0.263877303619762, -0.184289293256731);
                yield return new epil(52, 2, "placebo", 18, 23, 1, 13, 4, -0.263877303619762, -0.184289293256731);
                yield return new epil(53, 7, "placebo", 42, 36, 0, 14, 1, 0.583420556767442, 0.263735429270229);
                yield return new epil(54, 9, "placebo", 42, 36, 0, 14, 2, 0.583420556767442, 0.263735429270229);
                yield return new epil(55, 12, "placebo", 42, 36, 0, 14, 3, 0.583420556767442, 0.263735429270229);
                yield return new epil(56, 14, "placebo", 42, 36, 1, 14, 4, 0.583420556767442, 0.263735429270229);
                yield return new epil(57, 16, "placebo", 87, 26, 0, 15, 1, 1.31165905713866, -0.061686971164399);
                yield return new epil(58, 24, "placebo", 87, 26, 0, 15, 2, 1.31165905713866, -0.061686971164399);
                yield return new epil(59, 10, "placebo", 87, 26, 0, 15, 3, 1.31165905713866, -0.061686971164399);
                yield return new epil(60, 9, "placebo", 87, 26, 1, 15, 4, 1.31165905713866, -0.061686971164399);
                yield return new epil(61, 11, "placebo", 50, 26, 0, 16, 1, 0.75777394391222, -0.061686971164399);
                yield return new epil(62, 0, "placebo", 50, 26, 0, 16, 2, 0.75777394391222, -0.061686971164399);
                yield return new epil(63, 0, "placebo", 50, 26, 0, 16, 3, 0.75777394391222, -0.061686971164399);
                yield return new epil(64, 5, "placebo", 50, 26, 1, 16, 4, 0.75777394391222, -0.061686971164399);
                yield return new epil(65, 0, "placebo", 18, 28, 0, 17, 1, -0.263877303619762, 0.0124210009893226);
                yield return new epil(66, 0, "placebo", 18, 28, 0, 17, 2, -0.263877303619762, 0.0124210009893226);
                yield return new epil(67, 3, "placebo", 18, 28, 0, 17, 3, -0.263877303619762, 0.0124210009893226);
                yield return new epil(68, 3, "placebo", 18, 28, 1, 17, 4, -0.263877303619762, 0.0124210009893226);
                yield return new epil(69, 37, "placebo", 111, 31, 0, 18, 1, 1.55528113979641, 0.114203695299265);
                yield return new epil(70, 29, "placebo", 111, 31, 0, 18, 2, 1.55528113979641, 0.114203695299265);
                yield return new epil(71, 28, "placebo", 111, 31, 0, 18, 3, 1.55528113979641, 0.114203695299265);
                yield return new epil(72, 29, "placebo", 111, 31, 1, 18, 4, 1.55528113979641, 0.114203695299265);
                yield return new epil(73, 3, "placebo", 18, 32, 0, 19, 1, -0.263877303619762, 0.145952393613845);
                yield return new epil(74, 5, "placebo", 18, 32, 0, 19, 2, -0.263877303619762, 0.145952393613845);
                yield return new epil(75, 2, "placebo", 18, 32, 0, 19, 3, -0.263877303619762, 0.145952393613845);
                yield return new epil(76, 5, "placebo", 18, 32, 1, 19, 4, -0.263877303619762, 0.145952393613845);
                yield return new epil(77, 3, "placebo", 20, 21, 0, 20, 1, -0.158516787961936, -0.275261071462458);
                yield return new epil(78, 0, "placebo", 20, 21, 0, 20, 2, -0.158516787961936, -0.275261071462458);
                yield return new epil(79, 6, "placebo", 20, 21, 0, 20, 3, -0.158516787961936, -0.275261071462458);
                yield return new epil(80, 7, "placebo", 20, 21, 1, 20, 4, -0.158516787961936, -0.275261071462458);
                yield return new epil(81, 3, "placebo", 12, 29, 0, 21, 1, -0.669342411727926, 0.047512320800593);
                yield return new epil(82, 4, "placebo", 12, 29, 0, 21, 2, -0.669342411727926, 0.047512320800593);
                yield return new epil(83, 3, "placebo", 12, 29, 0, 21, 3, -0.669342411727926, 0.047512320800593);
                yield return new epil(84, 4, "placebo", 12, 29, 1, 21, 4, -0.669342411727926, 0.047512320800593);
                yield return new epil(85, 3, "placebo", 9, 21, 0, 22, 1, -0.957024484179707, -0.275261071462458);
                yield return new epil(86, 4, "placebo", 9, 21, 0, 22, 2, -0.957024484179707, -0.275261071462458);
                yield return new epil(87, 3, "placebo", 9, 21, 0, 22, 3, -0.957024484179707, -0.275261071462458);
                yield return new epil(88, 4, "placebo", 9, 21, 1, 22, 4, -0.957024484179707, -0.275261071462458);
                yield return new epil(89, 2, "placebo", 17, 32, 0, 23, 1, -0.321035717459711, 0.145952393613845);
                yield return new epil(90, 3, "placebo", 17, 32, 0, 23, 2, -0.321035717459711, 0.145952393613845);
                yield return new epil(91, 3, "placebo", 17, 32, 0, 23, 3, -0.321035717459711, 0.145952393613845);
                yield return new epil(92, 5, "placebo", 17, 32, 1, 23, 4, -0.321035717459711, 0.145952393613845);
                yield return new epil(93, 8, "placebo", 28, 25, 0, 24, 1, 0.177955448659277, -0.10090768431768);
                yield return new epil(94, 12, "placebo", 28, 25, 0, 24, 2, 0.177955448659277, -0.10090768431768);
                yield return new epil(95, 2, "placebo", 28, 25, 0, 24, 3, 0.177955448659277, -0.10090768431768);
                yield return new epil(96, 8, "placebo", 28, 25, 1, 24, 4, 0.177955448659277, -0.10090768431768);
                yield return new epil(97, 18, "placebo", 55, 30, 0, 25, 1, 0.853084123716544, 0.0814138724762743);
                yield return new epil(98, 24, "placebo", 55, 30, 0, 25, 2, 0.853084123716544, 0.0814138724762743);
                yield return new epil(99, 76, "placebo", 55, 30, 0, 25, 3, 0.853084123716544, 0.0814138724762743);
                yield return new epil(100, 25, "placebo", 55, 30, 1, 25, 4, 0.853084123716544, 0.0814138724762743);
                yield return new epil(101, 2, "placebo", 9, 40, 0, 26, 1, -0.957024484179707, 0.369095944928055);
                yield return new epil(102, 1, "placebo", 9, 40, 0, 26, 2, -0.957024484179707, 0.369095944928055);
                yield return new epil(103, 2, "placebo", 9, 40, 0, 26, 3, -0.957024484179707, 0.369095944928055);
                yield return new epil(104, 1, "placebo", 9, 40, 1, 26, 4, -0.957024484179707, 0.369095944928055);
                yield return new epil(105, 3, "placebo", 10, 19, 0, 27, 1, -0.851663968521881, -0.375344530019441);
                yield return new epil(106, 1, "placebo", 10, 19, 0, 27, 2, -0.851663968521881, -0.375344530019441);
                yield return new epil(107, 4, "placebo", 10, 19, 0, 27, 3, -0.851663968521881, -0.375344530019441);
                yield return new epil(108, 2, "placebo", 10, 19, 1, 27, 4, -0.851663968521881, -0.375344530019441);
                yield return new epil(109, 13, "placebo", 47, 22, 0, 28, 1, 0.695898540194132, -0.228741055827565);
                yield return new epil(110, 15, "placebo", 47, 22, 0, 28, 2, 0.695898540194132, -0.228741055827565);
                yield return new epil(111, 13, "placebo", 47, 22, 0, 28, 3, 0.695898540194132, -0.228741055827565);
                yield return new epil(112, 12, "placebo", 47, 22, 1, 28, 4, 0.695898540194132, -0.228741055827565);
                yield return new epil(113, 11, "progabide", 76, 18, 0, 29, 1, 1.1764842787704, -0.429411751289717);
                yield return new epil(114, 14, "progabide", 76, 18, 0, 29, 2, 1.1764842787704, -0.429411751289717);
                yield return new epil(115, 9, "progabide", 76, 18, 0, 29, 3, 1.1764842787704, -0.429411751289717);
                yield return new epil(116, 8, "progabide", 76, 18, 1, 29, 4, 1.1764842787704, -0.429411751289717);
                yield return new epil(117, 8, "progabide", 38, 32, 0, 30, 1, 0.483337098210459, 0.145952393613845);
                yield return new epil(118, 7, "progabide", 38, 32, 0, 30, 2, 0.483337098210459, 0.145952393613845);
                yield return new epil(119, 9, "progabide", 38, 32, 0, 30, 3, 0.483337098210459, 0.145952393613845);
                yield return new epil(120, 4, "progabide", 38, 32, 1, 30, 4, 0.483337098210459, 0.145952393613845);
                yield return new epil(121, 0, "progabide", 19, 20, 0, 31, 1, -0.209810082349486, -0.32405123563189);
                yield return new epil(122, 4, "progabide", 19, 20, 0, 31, 2, -0.209810082349486, -0.32405123563189);
                yield return new epil(123, 3, "progabide", 19, 20, 0, 31, 3, -0.209810082349486, -0.32405123563189);
                yield return new epil(124, 0, "progabide", 19, 20, 1, 31, 4, -0.209810082349486, -0.32405123563189);
                yield return new epil(125, 3, "progabide", 10, 30, 0, 32, 1, -0.851663968521881, 0.0814138724762743);
                yield return new epil(126, 6, "progabide", 10, 30, 0, 32, 2, -0.851663968521881, 0.0814138724762743);
                yield return new epil(127, 1, "progabide", 10, 30, 0, 32, 3, -0.851663968521881, 0.0814138724762743);
                yield return new epil(128, 3, "progabide", 10, 30, 1, 32, 4, -0.851663968521881, 0.0814138724762743);
                yield return new epil(129, 2, "progabide", 19, 18, 0, 33, 1, -0.209810082349486, -0.429411751289717);
                yield return new epil(130, 6, "progabide", 19, 18, 0, 33, 2, -0.209810082349486, -0.429411751289717);
                yield return new epil(131, 7, "progabide", 19, 18, 0, 33, 3, -0.209810082349486, -0.429411751289717);
                yield return new epil(132, 4, "progabide", 19, 18, 1, 33, 4, -0.209810082349486, -0.429411751289717);
                yield return new epil(133, 4, "progabide", 24, 24, 0, 34, 1, 0.0238047688320189, -0.141729678837935);
                yield return new epil(134, 3, "progabide", 24, 24, 0, 34, 2, 0.0238047688320189, -0.141729678837935);
                yield return new epil(135, 1, "progabide", 24, 24, 0, 34, 3, 0.0238047688320189, -0.141729678837935);
                yield return new epil(136, 3, "progabide", 24, 24, 1, 34, 4, 0.0238047688320189, -0.141729678837935);
                yield return new epil(137, 22, "progabide", 31, 30, 0, 35, 1, 0.279738142969219, 0.0814138724762743);
                yield return new epil(138, 17, "progabide", 31, 30, 0, 35, 2, 0.279738142969219, 0.0814138724762743);
                yield return new epil(139, 19, "progabide", 31, 30, 0, 35, 3, 0.279738142969219, 0.0814138724762743);
                yield return new epil(140, 16, "progabide", 31, 30, 1, 35, 4, 0.279738142969219, 0.0814138724762743);
                yield return new epil(141, 5, "progabide", 14, 35, 0, 36, 1, -0.515191731900668, 0.235564552303532);
                yield return new epil(142, 4, "progabide", 14, 35, 0, 36, 2, -0.515191731900668, 0.235564552303532);
                yield return new epil(143, 7, "progabide", 14, 35, 0, 36, 3, -0.515191731900668, 0.235564552303532);
                yield return new epil(144, 4, "progabide", 14, 35, 1, 36, 4, -0.515191731900668, 0.235564552303532);
                yield return new epil(145, 2, "progabide", 11, 27, 0, 37, 1, -0.756353788717556, -0.023946643181552);
                yield return new epil(146, 4, "progabide", 11, 27, 0, 37, 2, -0.756353788717556, -0.023946643181552);
                yield return new epil(147, 0, "progabide", 11, 27, 0, 37, 3, -0.756353788717556, -0.023946643181552);
                yield return new epil(148, 4, "progabide", 11, 27, 1, 37, 4, -0.756353788717556, -0.023946643181552);
                yield return new epil(149, 3, "progabide", 67, 20, 0, 38, 1, 1.05044355787504, -0.32405123563189);
                yield return new epil(150, 7, "progabide", 67, 20, 0, 38, 2, 1.05044355787504, -0.32405123563189);
                yield return new epil(151, 7, "progabide", 67, 20, 0, 38, 3, 1.05044355787504, -0.32405123563189);
                yield return new epil(152, 7, "progabide", 67, 20, 1, 38, 4, 1.05044355787504, -0.32405123563189);
                yield return new epil(153, 4, "progabide", 41, 22, 0, 39, 1, 0.559323005188381, -0.228741055827565);
                yield return new epil(154, 18, "progabide", 41, 22, 0, 39, 2, 0.559323005188381, -0.228741055827565);
                yield return new epil(155, 2, "progabide", 41, 22, 0, 39, 3, 0.559323005188381, -0.228741055827565);
                yield return new epil(156, 5, "progabide", 41, 22, 1, 39, 4, 0.559323005188381, -0.228741055827565);
                yield return new epil(157, 2, "progabide", 7, 28, 0, 40, 1, -1.20833891246061, 0.0124210009893226);
                yield return new epil(158, 1, "progabide", 7, 28, 0, 40, 2, -1.20833891246061, 0.0124210009893226);
                yield return new epil(159, 1, "progabide", 7, 28, 0, 40, 3, -1.20833891246061, 0.0124210009893226);
                yield return new epil(160, 0, "progabide", 7, 28, 1, 40, 4, -1.20833891246061, 0.0124210009893226);
                yield return new epil(161, 0, "progabide", 22, 23, 0, 41, 1, -0.0632066081576108, -0.184289293256731);
                yield return new epil(162, 2, "progabide", 22, 23, 0, 41, 2, -0.0632066081576108, -0.184289293256731);
                yield return new epil(163, 4, "progabide", 22, 23, 0, 41, 3, -0.0632066081576108, -0.184289293256731);
                yield return new epil(164, 0, "progabide", 22, 23, 1, 41, 4, -0.0632066081576108, -0.184289293256731);
                yield return new epil(165, 5, "progabide", 13, 40, 0, 42, 1, -0.58929970405439, 0.369095944928055);
                yield return new epil(166, 4, "progabide", 13, 40, 0, 42, 2, -0.58929970405439, 0.369095944928055);
                yield return new epil(167, 0, "progabide", 13, 40, 0, 42, 3, -0.58929970405439, 0.369095944928055);
                yield return new epil(168, 3, "progabide", 13, 40, 1, 42, 4, -0.58929970405439, 0.369095944928055);
                yield return new epil(169, 11, "progabide", 46, 33, 0, 43, 1, 0.674392334973168, 0.176724052280599);
                yield return new epil(170, 14, "progabide", 46, 33, 0, 43, 2, 0.674392334973168, 0.176724052280599);
                yield return new epil(171, 25, "progabide", 46, 33, 0, 43, 3, 0.674392334973168, 0.176724052280599);
                yield return new epil(172, 15, "progabide", 46, 33, 1, 43, 4, 0.674392334973168, 0.176724052280599);
                yield return new epil(173, 10, "progabide", 36, 21, 0, 44, 1, 0.429269876940183, -0.275261071462458);
                yield return new epil(174, 5, "progabide", 36, 21, 0, 44, 2, 0.429269876940183, -0.275261071462458);
                yield return new epil(175, 3, "progabide", 36, 21, 0, 44, 3, 0.429269876940183, -0.275261071462458);
                yield return new epil(176, 8, "progabide", 36, 21, 1, 44, 4, 0.429269876940183, -0.275261071462458);
                yield return new epil(177, 19, "progabide", 38, 35, 0, 45, 1, 0.483337098210459, 0.235564552303532);
                yield return new epil(178, 7, "progabide", 38, 35, 0, 45, 2, 0.483337098210459, 0.235564552303532);
                yield return new epil(179, 6, "progabide", 38, 35, 0, 45, 3, 0.483337098210459, 0.235564552303532);
                yield return new epil(180, 7, "progabide", 38, 35, 1, 45, 4, 0.483337098210459, 0.235564552303532);
                yield return new epil(181, 1, "progabide", 7, 25, 0, 46, 1, -1.20833891246061, -0.10090768431768);
                yield return new epil(182, 1, "progabide", 7, 25, 0, 46, 2, -1.20833891246061, -0.10090768431768);
                yield return new epil(183, 2, "progabide", 7, 25, 0, 46, 3, -1.20833891246061, -0.10090768431768);
                yield return new epil(184, 3, "progabide", 7, 25, 1, 46, 4, -1.20833891246061, -0.10090768431768);
                yield return new epil(185, 6, "progabide", 36, 26, 0, 47, 1, 0.429269876940183, -0.061686971164399);
                yield return new epil(186, 10, "progabide", 36, 26, 0, 47, 2, 0.429269876940183, -0.061686971164399);
                yield return new epil(187, 8, "progabide", 36, 26, 0, 47, 3, 0.429269876940183, -0.061686971164399);
                yield return new epil(188, 8, "progabide", 36, 26, 1, 47, 4, 0.429269876940183, -0.061686971164399);
                yield return new epil(189, 2, "progabide", 11, 25, 0, 48, 1, -0.756353788717556, -0.10090768431768);
                yield return new epil(190, 1, "progabide", 11, 25, 0, 48, 2, -0.756353788717556, -0.10090768431768);
                yield return new epil(191, 0, "progabide", 11, 25, 0, 48, 3, -0.756353788717556, -0.10090768431768);
                yield return new epil(192, 0, "progabide", 11, 25, 1, 48, 4, -0.756353788717556, -0.10090768431768);
                yield return new epil(193, 102, "progabide", 151, 22, 0, 49, 1, 1.863030775299, -0.228741055827565);
                yield return new epil(194, 65, "progabide", 151, 22, 0, 49, 2, 1.863030775299, -0.228741055827565);
                yield return new epil(195, 72, "progabide", 151, 22, 0, 49, 3, 1.863030775299, -0.228741055827565);
                yield return new epil(196, 63, "progabide", 151, 22, 1, 49, 4, 1.863030775299, -0.228741055827565);
                yield return new epil(197, 4, "progabide", 22, 32, 0, 50, 1, -0.0632066081576108, 0.145952393613845);
                yield return new epil(198, 3, "progabide", 22, 32, 0, 50, 2, -0.0632066081576108, 0.145952393613845);
                yield return new epil(199, 2, "progabide", 22, 32, 0, 50, 3, -0.0632066081576108, 0.145952393613845);
                yield return new epil(200, 4, "progabide", 22, 32, 1, 50, 4, -0.0632066081576108, 0.145952393613845);
                yield return new epil(201, 8, "progabide", 41, 25, 0, 51, 1, 0.559323005188381, -0.10090768431768);
                yield return new epil(202, 6, "progabide", 41, 25, 0, 51, 2, 0.559323005188381, -0.10090768431768);
                yield return new epil(203, 5, "progabide", 41, 25, 0, 51, 3, 0.559323005188381, -0.10090768431768);
                yield return new epil(204, 7, "progabide", 41, 25, 1, 51, 4, 0.559323005188381, -0.10090768431768);
                yield return new epil(205, 1, "progabide", 32, 35, 0, 52, 1, 0.3114868412838, 0.235564552303532);
                yield return new epil(206, 3, "progabide", 32, 35, 0, 52, 2, 0.3114868412838, 0.235564552303532);
                yield return new epil(207, 1, "progabide", 32, 35, 0, 52, 3, 0.3114868412838, 0.235564552303532);
                yield return new epil(208, 5, "progabide", 32, 35, 1, 52, 4, 0.3114868412838, 0.235564552303532);
                yield return new epil(209, 18, "progabide", 56, 21, 0, 53, 1, 0.871102629219222, -0.275261071462458);
                yield return new epil(210, 11, "progabide", 56, 21, 0, 53, 2, 0.871102629219222, -0.275261071462458);
                yield return new epil(211, 28, "progabide", 56, 21, 0, 53, 3, 0.871102629219222, -0.275261071462458);
                yield return new epil(212, 13, "progabide", 56, 21, 1, 53, 4, 0.871102629219222, -0.275261071462458);
                yield return new epil(213, 6, "progabide", 24, 41, 0, 54, 1, 0.0238047688320189, 0.393788557518427);
                yield return new epil(214, 3, "progabide", 24, 41, 0, 54, 2, 0.0238047688320189, 0.393788557518427);
                yield return new epil(215, 4, "progabide", 24, 41, 0, 54, 3, 0.0238047688320189, 0.393788557518427);
                yield return new epil(216, 0, "progabide", 24, 41, 1, 54, 4, 0.0238047688320189, 0.393788557518427);
                yield return new epil(217, 3, "progabide", 16, 32, 0, 55, 1, -0.381660339276146, 0.145952393613845);
                yield return new epil(218, 5, "progabide", 16, 32, 0, 55, 2, -0.381660339276146, 0.145952393613845);
                yield return new epil(219, 4, "progabide", 16, 32, 0, 55, 3, -0.381660339276146, 0.145952393613845);
                yield return new epil(220, 3, "progabide", 16, 32, 1, 55, 4, -0.381660339276146, 0.145952393613845);
                yield return new epil(221, 1, "progabide", 22, 26, 0, 56, 1, -0.0632066081576108, -0.061686971164399);
                yield return new epil(222, 23, "progabide", 22, 26, 0, 56, 2, -0.0632066081576108, -0.061686971164399);
                yield return new epil(223, 19, "progabide", 22, 26, 0, 56, 3, -0.0632066081576108, -0.061686971164399);
                yield return new epil(224, 8, "progabide", 22, 26, 1, 56, 4, -0.0632066081576108, -0.061686971164399);
                yield return new epil(225, 2, "progabide", 25, 21, 0, 57, 1, 0.0646267633522741, -0.275261071462458);
                yield return new epil(226, 3, "progabide", 25, 21, 0, 57, 2, 0.0646267633522741, -0.275261071462458);
                yield return new epil(227, 0, "progabide", 25, 21, 0, 57, 3, 0.0646267633522741, -0.275261071462458);
                yield return new epil(228, 1, "progabide", 25, 21, 1, 57, 4, 0.0646267633522741, -0.275261071462458);
                yield return new epil(229, 0, "progabide", 13, 36, 0, 58, 1, -0.58929970405439, 0.263735429270229);
                yield return new epil(230, 0, "progabide", 13, 36, 0, 58, 2, -0.58929970405439, 0.263735429270229);
                yield return new epil(231, 0, "progabide", 13, 36, 0, 58, 3, -0.58929970405439, 0.263735429270229);
                yield return new epil(232, 0, "progabide", 13, 36, 1, 58, 4, -0.58929970405439, 0.263735429270229);
                yield return new epil(233, 1, "progabide", 12, 37, 0, 59, 1, -0.669342411727926, 0.291134403458343);
                yield return new epil(234, 4, "progabide", 12, 37, 0, 59, 2, -0.669342411727926, 0.291134403458343);
                yield return new epil(235, 3, "progabide", 12, 37, 0, 59, 3, -0.669342411727926, 0.291134403458343);
                yield return new epil(236, 2, "progabide", 12, 37, 1, 59, 4, -0.669342411727926, 0.291134403458343);
            }
        }
    }
}
