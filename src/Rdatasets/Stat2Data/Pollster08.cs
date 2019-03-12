// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Pollster08
    /// </summary>

    public class Pollster08
    {
        public readonly int κ;
        public readonly string PollTaker;
        public readonly string PollDates;
        public readonly string MidDate;
        public readonly int Days;
        public readonly int? n;
        public readonly string Pop;
        public readonly int McCain;
        public readonly int Obama;
        public readonly int Margin;
        public readonly int Charlie;
        public readonly int Meltdown;

        public Pollster08(int κ, string PollTaker, string PollDates, string MidDate, int Days, int? n, string Pop, int McCain, int Obama, int Margin, int Charlie, int Meltdown)
        {
            this.κ = κ;
            this.PollTaker = PollTaker;
            this.PollDates = PollDates;
            this.MidDate = MidDate;
            this.Days = Days;
            this.n = n;
            this.Pop = Pop;
            this.McCain = McCain;
            this.Obama = Obama;
            this.Margin = Margin;
            this.Charlie = Charlie;
            this.Meltdown = Meltdown;
        }

        public static IEnumerable<Pollster08> Data
        {
            get
            {
                yield return new Pollster08(1, "Rasmussen", "8/28-30/08", "8/29", 1, 3000, "LV", 46, 49, 3, 0, 0);
                yield return new Pollster08(2, "Zogby", "8/29-30/08", "8/30", 2, 2020, "LV", 47, 45, -2, 0, 0);
                yield return new Pollster08(3, "Diageo/Hotline", "8/29-31/08", "8/30", 2, 805, "RV", 39, 48, 9, 0, 0);
                yield return new Pollster08(4, "CBS", "8/29-31/08", "8/30", 2, 781, "RV", 40, 48, 8, 0, 0);
                yield return new Pollster08(5, "CNN", "8/29-31/08", "8/30", 2, 927, "RV", 48, 49, 1, 0, 0);
                yield return new Pollster08(6, "Rasmussen", "8/30-9/1/08", "8/31", 3, 3000, "LV", 45, 51, 6, 0, 0);
                yield return new Pollster08(7, "ARG", "8/30-9/1/08", "8/31", 3, 1200, "LV", 43, 49, 6, 0, 0);
                yield return new Pollster08(8, "AP/Yahoo/KN", "8/27-9/5/08", "9/1", 4, 1728, "RV", 36, 40, 4, 0, 0);
                yield return new Pollster08(9, "Gallup", "9/1-3/08", "9/2", 5, 2771, "RV", 42, 49, 7, 0, 0);
                yield return new Pollster08(10, "Economist/YouGov", "9/1-3/08", "9/2", 5, 1000, "A", 39, 42, 3, 0, 0);
                yield return new Pollster08(11, "CBS", "9/1-3/08", "9/2", 5, 734, "RV", 42, 42, 0, 0, 0);
                yield return new Pollster08(12, "Democracy", "9/1-3/08", "9/2", 5, 1000, "LV", 44, 49, 5, 0, 0);
                yield return new Pollster08(13, "Rasmussen", "9/2-4/08", "9/3", 6, 3000, "LV", 46, 48, 2, 0, 0);
                yield return new Pollster08(14, "Diageo/Hotline", "9/2-4/08", "9/3", 6, 916, "RV", 40, 46, 6, 0, 0);
                yield return new Pollster08(15, "Gallup", "9/4-6/08", "9/5", 8, 2765, "RV", 48, 45, -3, 0, 0);
                yield return new Pollster08(16, "IBD/TIPP", "9/2-7/08", "9/5", 8, 868, "RV", 40, 45, 5, 0, 0);
                yield return new Pollster08(17, "Zogby", "9/5-6/08", "9/6", 9, 2312, "LV", 50, 46, -4, 0, 0);
                yield return new Pollster08(18, "Rasmussen", "9/5-7/08", "9/6", 9, 3000, "LV", 48, 47, -1, 0, 0);
                yield return new Pollster08(19, "ABC/Post", "9/5-7/08", "9/6", 9, null, "LV", 49, 47, -2, 0, 0);
                yield return new Pollster08(20, "CNN", "9/5-7/08", "9/6", 9, 942, "RV", 48, 48, 0, 0, 0);
                yield return new Pollster08(21, "USA", "9/5-7/08", "9/6", 9, 823, "LV", 54, 44, -10, 0, 0);
                yield return new Pollster08(22, "Public", "9/6-8/08", "9/7", 10, 800, "LV", 46, 43, -3, 0, 0);
                yield return new Pollster08(23, "NBC/WSJ", "9/6-8/08", "9/7", 10, 860, "RV", 46, 47, 1, 0, 0);
                yield return new Pollster08(24, "ARG", "9/6-8/08", "9/7", 10, 1200, "LV", 46, 47, 1, 0, 0);
                yield return new Pollster08(25, "Ipsos/McClatchy", "9/5-9/08", "9/7", 10, 876, "RV", 46, 45, -1, 0, 0);
                yield return new Pollster08(26, "InsiderAdvantage", "9/8-8/08", "9/8", 11, 807, "LV", 46, 46, 0, 0, 0);
                yield return new Pollster08(27, "Diageo/Hotline", "9/7-9/08", "9/8", 11, 902, "RV", 45, 45, 0, 0, 0);
                yield return new Pollster08(28, "Gallup", "9/7-9/08", "9/8", 11, 2714, "RV", 48, 43, -5, 0, 0);
                yield return new Pollster08(29, "Economist/YouGov", "9/7-9/08", "9/8", 11, 1000, "A", 40, 41, 1, 0, 0);
                yield return new Pollster08(30, "AP-Gfk", "9/5-10/08", "9/8", 11, 812, "LV", 48, 44, -4, 0, 0);
                yield return new Pollster08(31, "FOX", "9/8-9/08", "9/9", 12, 900, "RV", 45, 42, -3, 0, 0);
                yield return new Pollster08(32, "Rasmussen", "9/8-10/08", "9/9", 12, 3000, "LV", 48, 48, 0, 0, 0);
                yield return new Pollster08(33, "DailyKos.com", "9/8-10/08", "9/9", 12, 1100, "LV", 45, 47, 2, 0, 0);
                yield return new Pollster08(34, "Democracy", "9/8-10/08", "9/9", 12, 1000, "LV", 48, 46, -2, 0, 0);
                yield return new Pollster08(35, "AP/Yahoo/KN", "9/5-15/08", "9/10", 13, 1546, "RV", 41, 40, -1, 0, 0);
                yield return new Pollster08(36, "Newsweek", "9/10-11/08", "9/11", 14, 1038, "RV", 46, 46, 0, 0, 0);
                yield return new Pollster08(37, "Diageo/Hotline", "9/10-12/08", "9/11", 14, 912, "RV", 45, 44, -1, 0, 0);
                yield return new Pollster08(38, "Gallup", "9/10-12/08", "9/11", 14, 2761, "RV", 47, 45, -2, 0, 0);
                yield return new Pollster08(39, "Rasmussen", "9/11-13/08", "9/12", 15, 3000, "LV", 50, 47, -3, 1, 0);
                yield return new Pollster08(40, "Reuters/Zogby", "9/11-13/08", "9/12", 15, 1008, "LV", 45, 47, 2, 1, 0);
                yield return new Pollster08(41, "DailyKos.com", "9/11-13/08", "9/12", 15, 1100, "LV", 45, 47, 2, 1, 0);
                yield return new Pollster08(42, "Pew", "9/9-14/08", "9/12", 15, 2307, "LV", 46, 46, 0, 1, 0);
                yield return new Pollster08(43, "ABC/USA", "9/11-14/08", "9/13", 16, 1941, "A", 45, 47, 2, 1, 0);
                yield return new Pollster08(44, "Ipsos/McClatchy", "9/11-15/08", "9/13", 16, 1046, "RV", 45, 45, 0, 1, 0);
                yield return new Pollster08(45, "Diageo/Hotline", "9/13-15/08", "9/14", 17, 909, "RV", 42, 46, 4, 1, 0);
                yield return new Pollster08(46, "Gallup", "9/13-15/08", "9/14", 17, 2800, "RV", 47, 46, -1, 1, 0);
                yield return new Pollster08(47, "ARG", "9/13-15/08", "9/14", 17, 1200, "LV", 48, 45, -3, 1, 0);
                yield return new Pollster08(48, "Quinnipiac", "9/11-16/08", "9/14", 17, 987, "LV", 45, 49, 4, 1, 0);
                yield return new Pollster08(49, "CBS/Times", "9/12-16/08", "9/14", 17, 712, "LV", 44, 49, 5, 1, 0);
                yield return new Pollster08(50, "GWU", "9/10-17/08", "9/14", 17, 800, "LV", 47, 45, -2, 1, 0);
                yield return new Pollster08(51, "Rasmussen", "9/14-16/08", "9/15", 18, 3000, "LV", 48, 47, -1, 1, 0);
                yield return new Pollster08(52, "DailyKos.com", "9/14-16/08", "9/15", 18, 1100, "LV", 44, 48, 4, 1, 0);
                yield return new Pollster08(53, "Economist/YouGov", "9/15-16/08", "9/16", 19, 1000, "A", 45, 43, -2, 1, 1);
                yield return new Pollster08(54, "Big", "9/14-17/08", "9/16", 19, 1114, "RV", 45, 46, 1, 1, 1);
                yield return new Pollster08(55, "Diageo/Hotline", "9/16-18/08", "9/17", 20, 915, "RV", 44, 45, 1, 1, 1);
                yield return new Pollster08(56, "Gallup", "9/16-18/08", "9/17", 20, 2796, "RV", 44, 49, 5, 1, 1);
                yield return new Pollster08(57, "NBC/WSJ", "9/12-22/08", "9/17", 20, 1085, "RV", 46, 48, 2, 1, 1);
                yield return new Pollster08(58, "DailyKos.com", "9/17-19/08", "9/18", 21, 1100, "LV", 42, 50, 8, 1, 1);
                yield return new Pollster08(59, "Rasmussen", "9/17-19/08", "9/18", 21, 3000, "LV", 47, 48, 1, 1, 1);
                yield return new Pollster08(60, "Franklin", "9/15-21/08", "9/18", 21, 1320, "RV", 47, 45, -2, 1, 1);
                yield return new Pollster08(61, "Harris", "9/15-22/08", "9/19", 22, 1562, "LV", 46, 47, 1, 1, 1);
                yield return new Pollster08(62, "Zogby", "9/19-20/08", "9/20", 23, 2331, "LV", 43, 47, 4, 1, 1);
                yield return new Pollster08(63, "CNN", "9/19-21/08", "9/20", 23, 697, "LV", 47, 51, 4, 1, 1);
                yield return new Pollster08(64, "Gallup", "9/19-21/08", "9/20", 23, 2740, "RV", 44, 48, 4, 1, 1);
                yield return new Pollster08(65, "Diageo/Hotline", "9/19-21/08", "9/20", 23, 915, "RV", 42, 47, 5, 1, 1);
                yield return new Pollster08(66, "Ipsos/McClatchy", "9/18-22/08", "9/20", 23, 923, "RV", 43, 44, 1, 1, 1);
                yield return new Pollster08(67, "Times/Bloomberg", "9/19-22/08", "9/21", 24, 838, "LV", 45, 49, 4, 1, 1);
                yield return new Pollster08(68, "ABC/Post", "9/19-22/08", "9/21", 24, 780, "LV", 43, 52, 9, 1, 1);
                yield return new Pollster08(69, "ARG", "9/20-22/08", "9/21", 24, 1200, "LV", 46, 48, 2, 1, 1);
                yield return new Pollster08(70, "Rasmussen", "9/20-22/08", "9/21", 24, 3000, "LV", 48, 48, 0, 1, 1);
                yield return new Pollster08(71, "DailyKos.com", "9/20-22/08", "9/21", 24, 1100, "LV", 43, 49, 6, 1, 1);
                yield return new Pollster08(72, "GWU", "9/18-24/08", "9/21", 24, 1000, "LV", 48, 47, -1, 1, 1);
                yield return new Pollster08(73, "WNBC/Marist", "9/22-23/08", "9/23", 26, 698, "LV", 43, 47, 4, 1, 1);
                yield return new Pollster08(74, "FOX", "9/22-23/08", "9/23", 26, 900, "RV", 39, 45, 6, 1, 1);
                yield return new Pollster08(75, "CBS/Times", "9/21-24/08", "9/23", 26, null, "LV", 43, 48, 5, 1, 1);
                yield return new Pollster08(76, "Economist/YouGov", "9/22-24/08", "9/23", 26, 1000, "A", 43, 46, 3, 1, 1);
                yield return new Pollster08(77, "Gallup", "9/22-24/08", "9/23", 26, 2731, "RV", 46, 46, 0, 1, 1);
                yield return new Pollster08(78, "Democracy", "9/22-24/08", "9/23", 26, 1007, "LV", 44, 47, 3, 1, 1);
                yield return new Pollster08(79, "Diageo/Hotline", "9/22-24/08", "9/23", 26, 912, "RV", 43, 47, 4, 1, 1);
                yield return new Pollster08(80, "DailyKos.com", "9/23-25/08", "9/24", 27, 1100, "LV", 43, 48, 5, 1, 1);
                yield return new Pollster08(81, "Rasmussen", "9/23-25/08", "9/24", 27, 3000, "LV", 45, 50, 5, 1, 1);
                yield return new Pollster08(82, "Zogby", "9/23-25/08", "9/24", 27, 4752, "LV", 46, 44, -2, 1, 1);
                yield return new Pollster08(83, "Gallup", "9/25-27/08", "9/26", 29, 2719, "RV", 42, 50, 8, 1, 1);
                yield return new Pollster08(84, "Diageo/Hotline", "9/25-27/08", "9/26", 29, 905, "RV", 42, 47, 5, 1, 1);
                yield return new Pollster08(85, "Zogby", "9/26-27/08", "9/27", 30, 2102, "LV", 46, 47, 1, 1, 1);
                yield return new Pollster08(86, "Rasmussen", "9/26-28/08", "9/27", 30, 3000, "LV", 45, 50, 5, 1, 1);
                yield return new Pollster08(87, "DailyKos.com", "9/26-28/08", "9/27", 30, 1100, "LV", 42, 51, 9, 1, 1);
                yield return new Pollster08(88, "GWU", "9/25-30/08", "9/27", 30, 800, "LV", 46, 48, 2, 1, 1);
                yield return new Pollster08(89, "Ipsos/McClatchy", "9/26-29/08", "9/28", 31, 1007, "RV", 42, 46, 4, 1, 1);
                yield return new Pollster08(90, "Time", "9/26-29/08", "9/28", 31, 1133, "LV", 43, 50, 7, 1, 1);
                yield return new Pollster08(91, "Economist/YouGov", "9/27-29/08", "9/28", 31, 1000, "A", 42, 47, 5, 1, 1);
                yield return new Pollster08(92, "Pew", "9/27-29/08", "9/28", 31, 1181, "LV", 43, 49, 6, 1, 1);
                yield return new Pollster08(93, "ABC/Post", "9/27-29/08", "9/28", 31, 916, "LV", 46, 50, 4, 1, 1);
                yield return new Pollster08(94, "ARG", "9/27-29/08", "9/28", 31, 1200, "LV", 45, 49, 4, 1, 1);
                yield return new Pollster08(95, "CBS", "9/27-30/08", "9/29", 32, null, "LV", 41, 50, 9, 1, 1);
                yield return new Pollster08(96, "AP-Gfk", "9/27-30/08", "9/29", 32, 808, "LV", 41, 48, 7, 1, 1);
                yield return new Pollster08(97, "Marist", "9/28-30/08", "9/29", 32, 943, "LV", 44, 49, 5, 1, 1);
                yield return new Pollster08(98, "Gallup", "9/28-30/08", "9/29", 32, 2746, "RV", 44, 48, 4, 1, 1);
                yield return new Pollster08(99, "Democracy", "9/28-30/08", "9/29", 32, 1000, "LV", 45, 49, 4, 1, 1);
                yield return new Pollster08(100, "Diageo/Hotline", "9/28-30/08", "9/29", 32, 902, "RV", 42, 47, 5, 1, 1);
                yield return new Pollster08(101, "Rasmussen", "9/29-10/1/08", "9/30", 33, 3000, "LV", 44, 51, 7, 1, 1);
                yield return new Pollster08(102, "DailyKos.com", "9/29-10/1/08", "9/30", 33, 1100, "LV", 40, 51, 11, 1, 1);
            }
        }
    }
}
