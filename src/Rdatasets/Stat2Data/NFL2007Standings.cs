// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// NFL2007Standings
    /// </summary>

    public class NFL2007Standings
    {
        public readonly int κ;
        public readonly string Team;
        public readonly string Conference;
        public readonly string Division;
        public readonly int Wins;
        public readonly int Losses;
        public readonly double WinPct;
        public readonly int PointsFor;
        public readonly int PointsAgainst;
        public readonly int NetPts;
        public readonly int TDs;

        public NFL2007Standings(int κ, string Team, string Conference, string Division, int Wins, int Losses, double WinPct, int PointsFor, int PointsAgainst, int NetPts, int TDs)
        {
            this.κ = κ;
            this.Team = Team;
            this.Conference = Conference;
            this.Division = Division;
            this.Wins = Wins;
            this.Losses = Losses;
            this.WinPct = WinPct;
            this.PointsFor = PointsFor;
            this.PointsAgainst = PointsAgainst;
            this.NetPts = NetPts;
            this.TDs = TDs;
        }

        public static IEnumerable<NFL2007Standings> Data
        {
            get
            {
                yield return new NFL2007Standings(1, "New England Patriots", "AFC", "ACE", 16, 0, 1, 589, 274, 315, 75);
                yield return new NFL2007Standings(2, "Dallas Cowboys", "NFC", "NCE", 13, 3, 0.813, 455, 325, 130, 54);
                yield return new NFL2007Standings(3, "Green Bay Packers", "NFC", "NCN", 13, 3, 0.813, 435, 291, 144, 49);
                yield return new NFL2007Standings(4, "Indianapolis Colts", "AFC", "ACS", 13, 3, 0.813, 450, 262, 188, 54);
                yield return new NFL2007Standings(5, "Jacksonville Jaguars", "AFC", "ACS", 11, 5, 0.688, 411, 304, 107, 50);
                yield return new NFL2007Standings(6, "San Diego Chargers", "AFC", "ACW", 11, 5, 0.688, 412, 284, 128, 49);
                yield return new NFL2007Standings(7, "Cleveland Browns", "AFC", "ACN", 10, 6, 0.625, 402, 382, 20, 46);
                yield return new NFL2007Standings(8, "New York Giants", "NFC", "NCE", 10, 6, 0.625, 373, 351, 22, 44);
                yield return new NFL2007Standings(9, "Pittsburgh Steelers", "AFC", "ACN", 10, 6, 0.625, 393, 269, 124, 46);
                yield return new NFL2007Standings(10, "Seattle Seahawks", "NFC", "NCW", 10, 6, 0.625, 393, 291, 102, 44);
                yield return new NFL2007Standings(11, "Tennessee Titans", "AFC", "ACS", 10, 6, 0.625, 301, 297, 4, 28);
                yield return new NFL2007Standings(12, "Tampa Bay Buccaneers", "NFC", "NCS", 9, 7, 0.563, 334, 270, 64, 36);
                yield return new NFL2007Standings(13, "Washington Redskins", "NFC", "NCE", 9, 7, 0.563, 334, 310, 24, 35);
                yield return new NFL2007Standings(14, "Arizona Cardinals", "NFC", "NCW", 8, 8, 0.5, 404, 399, 5, 49);
                yield return new NFL2007Standings(15, "Houston Texans", "AFC", "ACS", 8, 8, 0.5, 379, 384, -5, 43);
                yield return new NFL2007Standings(16, "Minnesota Vikings", "NFC", "NCN", 8, 8, 0.5, 365, 311, 54, 43);
                yield return new NFL2007Standings(17, "Philadelphia Eagles", "NFC", "NCE", 8, 8, 0.5, 336, 300, 36, 38);
                yield return new NFL2007Standings(18, "Buffalo Bills", "AFC", "ACE", 7, 9, 0.438, 252, 354, -102, 25);
                yield return new NFL2007Standings(19, "Carolina Panthers", "NFC", "NCS", 7, 9, 0.438, 267, 347, -80, 28);
                yield return new NFL2007Standings(20, "Chicago Bears", "NFC", "NCN", 7, 9, 0.438, 334, 348, -14, 34);
                yield return new NFL2007Standings(21, "Cincinnati Bengals", "AFC", "ACN", 7, 9, 0.438, 380, 385, -5, 41);
                yield return new NFL2007Standings(22, "Denver Broncos", "AFC", "ACW", 7, 9, 0.438, 320, 409, -89, 34);
                yield return new NFL2007Standings(23, "Detroit Lions", "NFC", "NCN", 7, 9, 0.438, 346, 444, -98, 37);
                yield return new NFL2007Standings(24, "New Orleans Saints", "NFC", "NCS", 7, 9, 0.438, 379, 388, -9, 47);
                yield return new NFL2007Standings(25, "Baltimore Ravens", "AFC", "ACN", 5, 11, 0.313, 275, 384, -109, 28);
                yield return new NFL2007Standings(26, "San Francisco 49ers", "NFC", "NCW", 5, 11, 0.313, 219, 364, -145, 24);
                yield return new NFL2007Standings(27, "Atlanta Falcons", "NFC", "NCS", 4, 12, 0.25, 259, 414, -155, 26);
                yield return new NFL2007Standings(28, "Kansas City Chiefs", "AFC", "ACW", 4, 12, 0.25, 226, 335, -109, 24);
                yield return new NFL2007Standings(29, "New York Jets", "AFC", "ACE", 4, 12, 0.25, 268, 355, -87, 26);
                yield return new NFL2007Standings(30, "Oakland Raiders", "AFC", "ACW", 4, 12, 0.25, 283, 398, -115, 30);
                yield return new NFL2007Standings(31, "St. Louis Rams", "NFC", "NCW", 3, 13, 0.188, 263, 438, -175, 27);
                yield return new NFL2007Standings(32, "Miami Dolphins", "AFC", "ACE", 1, 15, 0.063, 267, 437, -170, 29);
            }
        }
    }
}
