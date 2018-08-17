// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// MLB2007Standings
    /// </summary>

    public class MLB2007Standings
    {
        public readonly string Team;
        public readonly string League;
        public readonly int Wins;
        public readonly int Losses;
        public readonly double WinPct;
        public readonly double BattingAvg;
        public readonly int Runs;
        public readonly int Hits;
        public readonly int HR;
        public readonly int Doubles;
        public readonly int Triples;
        public readonly int RBI;
        public readonly int SB;
        public readonly double OBP;
        public readonly double SLG;
        public readonly double ERA;
        public readonly int HitsAllowed;
        public readonly int Walks;
        public readonly int StrikeOuts;
        public readonly int Saves;
        public readonly double WHIP;

        public MLB2007Standings(string Team, string League, int Wins, int Losses, double WinPct, double BattingAvg, int Runs, int Hits, int HR, int Doubles, int Triples, int RBI, int SB, double OBP, double SLG, double ERA, int HitsAllowed, int Walks, int StrikeOuts, int Saves, double WHIP)
        {
            this.Team = Team;
            this.League = League;
            this.Wins = Wins;
            this.Losses = Losses;
            this.WinPct = WinPct;
            this.BattingAvg = BattingAvg;
            this.Runs = Runs;
            this.Hits = Hits;
            this.HR = HR;
            this.Doubles = Doubles;
            this.Triples = Triples;
            this.RBI = RBI;
            this.SB = SB;
            this.OBP = OBP;
            this.SLG = SLG;
            this.ERA = ERA;
            this.HitsAllowed = HitsAllowed;
            this.Walks = Walks;
            this.StrikeOuts = StrikeOuts;
            this.Saves = Saves;
            this.WHIP = WHIP;
        }

        public static IEnumerable<MLB2007Standings> Data
        {
            get
            {
                yield return new MLB2007Standings("Arizona Diamondbacks", "NL", 90, 72, 0.556, 0.25, 712, 1350, 171, 286, 40, 687, 109, 0.321, 0.413, 4.13, 1446, 546, 1088, 51, 1.38);
                yield return new MLB2007Standings("Atlanta Braves", "NL", 84, 78, 0.519, 0.275, 810, 1562, 176, 328, 27, 781, 64, 0.339, 0.435, 4.11, 1442, 537, 1106, 36, 1.36);
                yield return new MLB2007Standings("Baltimore Orioles", "AL", 69, 93, 0.426, 0.272, 756, 1529, 142, 306, 30, 718, 144, 0.333, 0.412, 5.17, 1491, 696, 1087, 30, 1.52);
                yield return new MLB2007Standings("Boston Red Sox", "AL", 96, 66, 0.593, 0.279, 867, 1561, 166, 352, 35, 829, 96, 0.362, 0.444, 3.87, 1350, 482, 1149, 45, 1.27);
                yield return new MLB2007Standings("Chicago Cubs", "NL", 85, 77, 0.525, 0.271, 752, 1530, 151, 340, 28, 711, 86, 0.333, 0.422, 4.04, 1340, 573, 1211, 39, 1.32);
                yield return new MLB2007Standings("Chicago White Sox", "AL", 72, 90, 0.444, 0.246, 693, 1341, 190, 249, 20, 667, 78, 0.318, 0.404, 4.77, 1556, 499, 1015, 42, 1.43);
                yield return new MLB2007Standings("Cincinnati Reds", "NL", 72, 90, 0.444, 0.267, 783, 1496, 204, 293, 23, 747, 97, 0.335, 0.436, 4.94, 1605, 482, 1068, 34, 1.44);
                yield return new MLB2007Standings("Cleveland Indians", "AL", 96, 66, 0.593, 0.268, 811, 1504, 178, 305, 27, 784, 72, 0.343, 0.428, 4.05, 1519, 410, 1047, 49, 1.32);
                yield return new MLB2007Standings("Colorado Rockies", "NL", 90, 73, 0.552, 0.28, 860, 1591, 171, 313, 36, 823, 100, 0.354, 0.437, 4.32, 1497, 504, 967, 39, 1.36);
                yield return new MLB2007Standings("Detroit Tigers", "AL", 88, 74, 0.543, 0.287, 887, 1652, 177, 352, 50, 857, 103, 0.345, 0.458, 4.57, 1498, 566, 1047, 44, 1.43);
                yield return new MLB2007Standings("Florida Marlins", "NL", 71, 91, 0.438, 0.267, 790, 1504, 201, 340, 38, 749, 105, 0.336, 0.448, 4.94, 1617, 661, 1142, 40, 1.58);
                yield return new MLB2007Standings("Houston Astros", "NL", 73, 89, 0.451, 0.26, 723, 1457, 167, 293, 30, 700, 65, 0.33, 0.412, 4.68, 1566, 510, 1109, 38, 1.42);
                yield return new MLB2007Standings("Kansas City Royals", "AL", 69, 93, 0.426, 0.261, 706, 1447, 102, 300, 46, 660, 78, 0.322, 0.388, 4.48, 1547, 520, 993, 36, 1.44);
                yield return new MLB2007Standings("Los Angeles Angels", "AL", 94, 68, 0.58, 0.284, 822, 1578, 123, 324, 23, 776, 139, 0.345, 0.417, 4.23, 1480, 477, 1156, 43, 1.36);
                yield return new MLB2007Standings("Los Angeles Dodgers", "NL", 82, 80, 0.506, 0.275, 735, 1544, 129, 276, 35, 706, 137, 0.337, 0.406, 4.2, 1443, 518, 1184, 43, 1.35);
                yield return new MLB2007Standings("Milwaukee Brewers", "NL", 83, 79, 0.512, 0.262, 801, 1455, 231, 310, 37, 774, 96, 0.329, 0.456, 4.41, 1513, 507, 1174, 49, 1.4);
                yield return new MLB2007Standings("Minnesota Twins", "AL", 79, 83, 0.488, 0.264, 718, 1460, 118, 273, 36, 671, 112, 0.33, 0.391, 4.15, 1505, 420, 1094, 38, 1.34);
                yield return new MLB2007Standings("New York Mets", "NL", 88, 74, 0.543, 0.275, 804, 1543, 177, 294, 27, 761, 200, 0.342, 0.432, 4.26, 1415, 570, 1134, 39, 1.37);
                yield return new MLB2007Standings("New York Yankees", "AL", 94, 68, 0.58, 0.29, 968, 1656, 201, 326, 32, 929, 123, 0.366, 0.463, 4.49, 1498, 578, 1009, 34, 1.43);
                yield return new MLB2007Standings("Oakland Athletics", "AL", 76, 86, 0.469, 0.256, 741, 1430, 171, 295, 16, 711, 52, 0.338, 0.407, 4.28, 1468, 530, 1036, 36, 1.38);
                yield return new MLB2007Standings("Philadelphia Phillies", "NL", 89, 73, 0.549, 0.274, 892, 1558, 213, 326, 41, 850, 138, 0.354, 0.458, 4.73, 1555, 558, 1050, 42, 1.45);
                yield return new MLB2007Standings("Pittsburgh Pirates", "NL", 68, 94, 0.42, 0.263, 724, 1463, 148, 322, 31, 694, 68, 0.325, 0.411, 4.93, 1627, 518, 997, 32, 1.48);
                yield return new MLB2007Standings("San Diego Padres", "NL", 89, 74, 0.546, 0.251, 741, 1408, 171, 322, 31, 704, 55, 0.322, 0.411, 3.7, 1406, 474, 1136, 45, 1.27);
                yield return new MLB2007Standings("San Francisco Giants", "NL", 71, 91, 0.438, 0.254, 683, 1407, 131, 267, 37, 641, 119, 0.322, 0.387, 4.19, 1442, 593, 1057, 37, 1.4);
                yield return new MLB2007Standings("Seattle Mariners", "AL", 88, 74, 0.543, 0.287, 794, 1629, 153, 284, 22, 754, 81, 0.337, 0.425, 4.73, 1578, 546, 1020, 43, 1.48);
                yield return new MLB2007Standings("St. Louis Cardinals", "NL", 78, 84, 0.481, 0.274, 725, 1513, 141, 279, 13, 690, 56, 0.337, 0.405, 4.65, 1514, 509, 945, 34, 1.41);
                yield return new MLB2007Standings("Tampa Bay Devil Rays", "AL", 66, 96, 0.407, 0.268, 782, 1500, 187, 291, 36, 750, 131, 0.336, 0.433, 5.53, 1649, 568, 1194, 28, 1.55);
                yield return new MLB2007Standings("Texas Rangers", "AL", 75, 87, 0.463, 0.263, 816, 1460, 179, 298, 36, 768, 88, 0.328, 0.426, 4.75, 1525, 668, 976, 42, 1.53);
                yield return new MLB2007Standings("Toronto Blue Jays", "AL", 83, 79, 0.512, 0.259, 753, 1434, 165, 344, 24, 719, 57, 0.327, 0.419, 4, 1383, 479, 1067, 44, 1.29);
                yield return new MLB2007Standings("Washington Nationals", "NL", 73, 89, 0.451, 0.256, 673, 1415, 123, 309, 31, 646, 69, 0.325, 0.39, 4.58, 1502, 580, 931, 46, 1.44);
            }
        }
    }
}
