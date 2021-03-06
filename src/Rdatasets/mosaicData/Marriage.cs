// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Marriage records
    /// </summary>

    public class Marriage
    {
        public readonly int κ;
        public readonly string bookpageID;
        public readonly string appdate;
        public readonly string ceremonydate;
        public readonly int delay;
        public readonly string officialTitle;
        public readonly string person;
        public readonly string dob;
        public readonly double age;
        public readonly string race;
        public readonly int prevcount;
        public readonly string prevconc;
        public readonly int hs;
        public readonly int? college;
        public readonly double dayOfBirth;
        public readonly string sign;

        public Marriage(int κ, string bookpageID, string appdate, string ceremonydate, int delay, string officialTitle, string person, string dob, double age, string race, int prevcount, string prevconc, int hs, int? college, double dayOfBirth, string sign)
        {
            this.κ = κ;
            this.bookpageID = bookpageID;
            this.appdate = appdate;
            this.ceremonydate = ceremonydate;
            this.delay = delay;
            this.officialTitle = officialTitle;
            this.person = person;
            this.dob = dob;
            this.age = age;
            this.race = race;
            this.prevcount = prevcount;
            this.prevconc = prevconc;
            this.hs = hs;
            this.college = college;
            this.dayOfBirth = dayOfBirth;
            this.sign = sign;
        }

        public static IEnumerable<Marriage> Data
        {
            get
            {
                yield return new Marriage(1, "B230p539", "10/29/96", "11/9/96", 11, "CIRCUIT JUDGE ", "Groom", "4/11/64", 32.60273973, "White", 0, null, 12, 7, 102, "Aries");
                yield return new Marriage(2, "B230p677", "11/12/96", "11/12/96", 0, "MARRIAGE OFFICIAL", "Groom", "8/6/64", 32.29041096, "White", 1, "Divorce", 12, 0, 219, "Leo");
                yield return new Marriage(3, "B230p766", "11/19/96", "11/27/96", 8, "MARRIAGE OFFICIAL", "Groom", "2/20/62", 34.79178082, "Hispanic", 1, "Divorce", 12, 3, 51.5, "Pisces");
                yield return new Marriage(4, "B230p892", "12/2/96", "12/7/96", 5, "MINISTER", "Groom", "5/20/56", 40.57808219, "Black", 1, "Divorce", 12, 4, 141, "Gemini");
                yield return new Marriage(5, "B230p994", "12/9/96", "12/14/96", 5, "MINISTER", "Groom", "12/14/66", 30.02191781, "White", 0, null, 12, 0, 348.5, "Saggitarius");
                yield return new Marriage(6, "B230p1209", "12/26/96", "12/26/96", 0, "MARRIAGE OFFICIAL", "Groom", "2/21/70", 26.8630137, "White", 1, null, 12, 0, 52.5, "Pisces");
                yield return new Marriage(7, "B230p1354", "1/8/97", "1/24/97", 16, "MARRIAGE OFFICIAL", "Groom", "10/11/71", 25.30684932, "White", 1, "Divorce", 12, 0, 284.25, "Libra");
                yield return new Marriage(8, "B230p1665", "2/10/97", "2/10/97", 0, "MARRIAGE OFFICIAL", "Groom", "1/31/62", 35.05205479, "White", 1, "Divorce", 12, 0, 31.5, "Aquarius");
                yield return new Marriage(9, "B230p1948", "3/3/97", "3/31/97", 28, "MARRIAGE OFFICIAL", "Groom", "12/4/75", 21.3369863, "Black", 0, null, 12, 0, 338.25, "Saggitarius");
                yield return new Marriage(10, "B231p48", "3/12/97", "3/22/97", 10, "MINISTER", "Groom", "7/2/51", 45.75342466, "White", 3, "Divorce", 12, 6, 183.25, "Cancer");
                yield return new Marriage(11, "B231p198", "3/21/97", "3/29/97", 8, "PASTOR", "Groom", "2/6/55", 42.16986301, "Black", 1, "Divorce", 12, 2, 37.25, "Aquarius");
                yield return new Marriage(12, "B231p406", "4/7/97", "4/7/97", 0, "CHIEF CLERK", "Groom", "11/15/67", 29.41369863, "White", 1, "Divorce", 12, 1, 319.25, "Scorpio");
                yield return new Marriage(13, "B231p632", "4/22/97", "4/26/97", 4, "MARRIAGE OFFICIAL", "Groom", "9/1/76", 20.6630137, "White", 0, null, 12, 1, 245, "Virgo");
                yield return new Marriage(14, "B231p713", "4/30/97", "5/4/97", 4, "MINISTER", "Groom", "10/15/78", 18.56438356, "White", 0, null, 10, 0, 288.5, "Libra");
                yield return new Marriage(15, "B231p1042", "5/23/97", "5/23/97", 0, "MARRIAGE OFFICIAL", "Groom", "10/30/54", 42.59178082, "White", 1, "Divorce", 12, 0, 303.5, "Scorpio");
                yield return new Marriage(16, "B231p1201", "6/3/97", "6/7/97", 4, "PASTOR", "Groom", "11/28/59", 37.55068493, "American Indian", 0, null, 12, 4, 332.25, "Saggitarius");
                yield return new Marriage(17, "B231p1436", "6/18/97", "6/27/97", 9, "PASTOR", "Groom", "1/30/66", 31.42739726, "White", 0, null, 12, 2, 30.5, "Aquarius");
                yield return new Marriage(18, "B231p1841", "7/14/97", "7/14/97", 0, "MARRIAGE OFFICIAL", "Groom", "5/19/78", 19.16712329, "Black", 0, null, 12, null, 139.5, "Taurus");
                yield return new Marriage(19, "B232p148", "8/7/97", "8/10/97", 3, "REVEREND", "Groom", "2/20/43", 54.50684932, "White", 1, "Death", 12, null, 51.25, "Pisces");
                yield return new Marriage(20, "B232p299", "8/18/97", "8/30/97", 12, "PASTOR", "Groom", "5/19/48", 49.31506849, "White", 1, "Divorce", 12, 0, 140, "Taurus");
                yield return new Marriage(21, "B232p522", "9/4/97", "9/6/97", 2, "PASTOR", "Groom", "4/10/45", 52.44383562, "White", 1, "Death", 12, 7, 100.75, "Aries");
                yield return new Marriage(22, "B232p770", "9/24/97", "9/26/97", 2, "MINISTER", "Groom", "11/29/52", 44.85479452, "Black", 1, "Divorce", 9, 0, 334, "Saggitarius");
                yield return new Marriage(23, "B232p1079", "10/20/97", "10/20/97", 0, "MARRIAGE OFFICIAL", "Groom", "10/20/58", 39.02739726, "Black", 1, "Divorce", 12, 3, 293.5, "Libra");
                yield return new Marriage(24, "B232p1211", "10/31/97", "10/31/97", 0, "MARRIAGE OFFICIAL", "Groom", "1/6/60", 37.84383562, "White", 1, "Divorce", 12, 1, 6, "Capricorn");
                yield return new Marriage(25, "B232p1519", "11/26/97", "11/26/97", 0, "MARRIAGE OFFICIAL", "Groom", "11/27/72", 25.01369863, "White", 1, "Divorce", 12, 0, 332, "Saggitarius");
                yield return new Marriage(26, "B232p1888", "12/31/97", "12/31/97", 0, "MARRIAGE OFFICIAL", "Groom", "8/6/71", 26.42191781, "White", 0, null, 12, 1, 218.25, "Leo");
                yield return new Marriage(27, "B233p141", "1/30/98", "1/30/98", 0, "MARRIAGE OFFICIAL", "Groom", "10/21/78", 19.29041096, "Black", 0, null, 12, 0, 294.5, "Libra");
                yield return new Marriage(28, "B233p268", "2/12/98", "2/14/98", 2, "ELDER", "Groom", "10/10/79", 18.36164384, "Black", 0, null, 9, 0, 283.25, "Libra");
                yield return new Marriage(29, "B233p429", "2/27/98", "3/7/98", 8, "PASTOR", "Groom", "4/6/57", 40.94520548, "White", 2, "Divorce", 12, 0, 96.75, "Aries");
                yield return new Marriage(30, "B233p674", "3/13/98", "4/4/98", 22, "CATHOLIC PRIEST", "Groom", "3/3/71", 27.10684932, "White", 0, null, 12, 2, 62.25, "Pisces");
                yield return new Marriage(31, "B233p903", "3/31/98", "3/31/98", 0, "MARRIAGE OFFICIAL", "Groom", "2/25/78", 20.10684932, "White", 0, null, 12, 0, 56.5, "Pisces");
                yield return new Marriage(32, "B233p1245", "4/23/98", "4/24/98", 1, "PASTOR", "Groom", "9/19/46", 51.63013699, "White", 2, "Divorce", 12, null, 262.5, "Virgo");
                yield return new Marriage(33, "B233p1381", "5/1/98", "5/23/98", 22, "PASTOR", "Groom", "4/18/75", 23.11232877, "White", 0, null, 12, 5, 108.25, "Aries");
                yield return new Marriage(34, "B233p1690", "5/26/98", "5/30/98", 4, "MINISTER", "Groom", "6/5/64", 34.00547945, "White", 2, "Divorce", 12, 4, 157, "Gemini");
                yield return new Marriage(35, "B233p1899", "6/9/98", "6/27/98", 18, "MARRIAGE OFFICIAL", "Groom", "2/13/75", 23.38356164, "White", 0, null, 12, 4, 44.25, "Aquarius");
                yield return new Marriage(36, "B234p65", "6/18/98", "6/20/98", 2, "BISHOP", "Groom", "11/26/56", 41.59178082, "Black", 0, null, 9, 0, 331, "Saggitarius");
                yield return new Marriage(37, "B234p438", "7/13/98", "8/1/98", 19, "PASTOR", "Groom", "5/21/24", 74.24657534, "White", 1, "Death", 12, 0, 142, "Gemini");
                yield return new Marriage(38, "B234p687", "7/31/98", "7/31/98", 0, "MARRIAGE OFFICIAL", "Groom", "3/18/27", 71.41917808, "White", 1, "Divorce", 12, null, 77.25, "Pisces");
                yield return new Marriage(39, "B234p904", "8/13/98", "8/13/98", 0, "MARRIAGE OFFICIAL", "Groom", "5/28/41", 57.24931507, "Black", 1, "Divorce", 12, 0, 148.75, "Gemini");
                yield return new Marriage(40, "B234p1292", "9/15/98", "9/26/98", 11, "PASTOR", "Groom", "9/20/69", 29.03561644, "White", 0, null, 12, 2, 263.75, "Virgo");
                yield return new Marriage(41, "B234p1485", "10/2/98", "10/2/98", 0, "MARRIAGE OFFICIAL", "Groom", "2/26/43", 55.63561644, "White", 2, "Divorce", 12, 1, 57.25, "Pisces");
                yield return new Marriage(42, "B234p1621", "10/14/98", "10/23/98", 9, "MINISTER", "Groom", "3/7/80", 18.64109589, "White", 0, null, 11, 0, 67, "Pisces");
                yield return new Marriage(43, "B234p1966", "11/9/98", "11/9/98", 0, "MARRIAGE OFFICIAL", "Groom", "5/28/80", 18.4630137, "Black", 0, null, 12, 0, 149, "Gemini");
                yield return new Marriage(44, "B235p7", "11/12/98", "11/28/98", 16, "MINISTER", "Groom", "9/14/78", 20.21917808, "White", 0, null, 12, 2, 257.5, "Virgo");
                yield return new Marriage(45, "B235p259", "12/2/98", "12/5/98", 3, "PASTOR", "Groom", "2/18/55", 43.82465753, "White", 2, "Divorce", 12, null, 49.25, "Pisces");
                yield return new Marriage(46, "B235p404", "12/14/98", "12/14/98", 0, "MARRIAGE OFFICIAL", "Groom", "9/20/60", 38.25753425, "White", 1, "Divorce", 12, 2, 264, "Virgo");
                yield return new Marriage(47, "B235p563", "12/23/98", "12/23/98", 0, "MARRIAGE OFFICIAL", "Groom", "5/20/74", 24.6109589, "White", 0, null, 11, 0, 140.5, "Gemini");
                yield return new Marriage(48, "B235p837", "1/22/99", "1/31/99", 9, "MINISTER", "Groom", "7/19/31", 67.58356164, "White", 1, "Divorce", 12, 7, 200.25, "Cancer");
                yield return new Marriage(49, "B235p992", "2/5/99", "2/6/99", 1, "MINISTER", "Groom", "12/20/59", 39.15890411, "White", 5, "Divorce", 12, 4, 354.25, "Saggitarius");
                yield return new Marriage(50, "B230p539", "10/29/96", "11/9/96", 11, "CIRCUIT JUDGE ", "Bride", "2/25/68", 28.7260274, "White", 0, null, 12, 2, 56, "Pisces");
                yield return new Marriage(51, "B230p677", "11/12/96", "11/12/96", 0, "MARRIAGE OFFICIAL", "Bride", "4/24/44", 52.5890411, "White", 0, null, 12, 2, 115, "Taurus");
                yield return new Marriage(52, "B230p766", "11/19/96", "11/27/96", 8, "MARRIAGE OFFICIAL", "Bride", "3/10/70", 26.7369863, "White", 0, null, 12, 1, 69.5, "Pisces");
                yield return new Marriage(53, "B230p892", "12/2/96", "12/7/96", 5, "MINISTER", "Bride", "5/18/57", 39.58356164, "Black", 1, "Divorce", 12, 1, 138.75, "Taurus");
                yield return new Marriage(54, "B230p994", "12/9/96", "12/14/96", 5, "MINISTER", "Bride", "12/23/72", 23.99178082, "White", 0, null, 12, 6, 358, "Capricorn");
                yield return new Marriage(55, "B230p1209", "12/26/96", "12/26/96", 0, "MARRIAGE OFFICIAL", "Bride", "11/19/71", 25.12054795, "White", 1, null, 12, 2, 323.25, "Scorpio");
                yield return new Marriage(56, "B230p1354", "1/8/97", "1/24/97", 16, "MARRIAGE OFFICIAL", "Bride", "12/8/71", 25.14794521, "White", 1, "Divorce", 12, 0, 342.25, "Saggitarius");
                yield return new Marriage(57, "B230p1665", "2/10/97", "2/10/97", 0, "MARRIAGE OFFICIAL", "Bride", "9/5/76", 20.44657534, "White", 0, null, 10, 0, 249, "Virgo");
                yield return new Marriage(58, "B230p1948", "3/3/97", "3/31/97", 28, "MARRIAGE OFFICIAL", "Bride", "3/20/77", 20.04383562, "Black", 0, null, 12, 0, 79.75, "Aries");
                yield return new Marriage(59, "B231p48", "3/12/97", "3/22/97", 10, "MINISTER", "Bride", "7/22/53", 43.69589041, "White", 1, "Divorce", 12, 2, 203.75, "Leo");
                yield return new Marriage(60, "B231p198", "3/21/97", "3/29/97", 8, "PASTOR", "Bride", "4/13/63", 33.98356164, "Black", 0, null, 12, 2, 103.25, "Aries");
                yield return new Marriage(61, "B231p406", "4/7/97", "4/7/97", 0, "CHIEF CLERK", "Bride", "4/26/73", 23.96438356, "White", 1, "Divorce", 12, 0, 116.75, "Taurus");
                yield return new Marriage(62, "B231p632", "4/22/97", "4/26/97", 4, "MARRIAGE OFFICIAL", "Bride", "4/23/80", 17.01917808, "White", 0, null, 11, 0, 114, "Taurus");
                yield return new Marriage(63, "B231p713", "4/30/97", "5/4/97", 4, "MINISTER", "Bride", "2/1/77", 20.26575342, "White", 0, null, 10, 0, 32.75, "Aquarius");
                yield return new Marriage(64, "B231p1042", "5/23/97", "5/23/97", 0, "MARRIAGE OFFICIAL", "Bride", "6/25/59", 37.9369863, "White", 1, "Divorce", 12, 0, 176.25, "Cancer");
                yield return new Marriage(65, "B231p1201", "6/3/97", "6/7/97", 4, "PASTOR", "Bride", "3/2/58", 39.29315068, "Black", 1, "Death", 12, 0, 61.5, "Pisces");
                yield return new Marriage(66, "B231p1436", "6/18/97", "6/27/97", 9, "PASTOR", "Bride", "4/14/76", 21.21643836, "White", 0, null, 12, 2, 105, "Aries");
                yield return new Marriage(67, "B231p1841", "7/14/97", "7/14/97", 0, "MARRIAGE OFFICIAL", "Bride", "4/17/78", 19.25479452, "White", 0, null, 12, null, 107.5, "Aries");
                yield return new Marriage(68, "B232p148", "8/7/97", "8/10/97", 3, "REVEREND", "Bride", "11/16/47", 49.76712329, "White", 3, "Divorce", 12, null, 320.25, "Scorpio");
                yield return new Marriage(69, "B232p299", "8/18/97", "8/30/97", 12, "PASTOR", "Bride", "6/23/53", 44.21643836, "White", 1, "Divorce", 10, 0, 174.75, "Cancer");
                yield return new Marriage(70, "B232p522", "9/4/97", "9/6/97", 2, "PASTOR", "Bride", "9/10/54", 43.01917808, "White", 2, "Divorce", 12, 2, 253.5, "Virgo");
                yield return new Marriage(71, "B232p770", "9/24/97", "9/26/97", 2, "MINISTER", "Bride", "10/1/52", 45.01643836, "Black", 2, "Divorce", 12, 0, 275, "Libra");
                yield return new Marriage(72, "B232p1079", "10/20/97", "10/20/97", 0, "MARRIAGE OFFICIAL", "Bride", "5/21/70", 27.43561644, "Black", 0, null, 12, 2, 141.5, "Gemini");
                yield return new Marriage(73, "B232p1211", "10/31/97", "10/31/97", 0, "MARRIAGE OFFICIAL", "Bride", "3/29/59", 38.61917808, "White", 2, "Divorce", 12, 0, 88.25, "Aries");
                yield return new Marriage(74, "B232p1519", "11/26/97", "11/26/97", 0, "MARRIAGE OFFICIAL", "Bride", "2/21/77", 20.77534247, "White", 1, "Divorce", 12, 2, 52.75, "Pisces");
                yield return new Marriage(75, "B232p1888", "12/31/97", "12/31/97", 0, "MARRIAGE OFFICIAL", "Bride", "9/27/62", 35.28493151, "White", 2, "Divorce", 12, null, 270.5, "Libra");
                yield return new Marriage(76, "B233p141", "1/30/98", "1/30/98", 0, "MARRIAGE OFFICIAL", "Bride", "8/6/78", 19.49863014, "Black", 0, null, 12, 0, 218.5, "Leo");
                yield return new Marriage(77, "B233p268", "2/12/98", "2/14/98", 2, "ELDER", "Bride", "6/29/80", 17.64109589, "Black", 0, null, 9, 0, 181, "Cancer");
                yield return new Marriage(78, "B233p429", "2/27/98", "3/7/98", 8, "PASTOR", "Bride", "12/3/55", 42.28767123, "White", 0, null, 12, 6, 337.25, "Saggitarius");
                yield return new Marriage(79, "B233p674", "3/13/98", "4/4/98", 22, "CATHOLIC PRIEST", "Bride", "10/29/69", 28.44931507, "White", 0, null, 12, 5, 302.75, "Scorpio");
                yield return new Marriage(80, "B233p903", "3/31/98", "3/31/98", 0, "MARRIAGE OFFICIAL", "Bride", "11/10/79", 18.4, "White", 0, null, 11, 0, 314.25, "Scorpio");
                yield return new Marriage(81, "B233p1245", "4/23/98", "4/24/98", 1, "PASTOR", "Bride", "4/8/55", 43.0739726, "White", 3, "Divorce", 10, 0, 98.25, "Aries");
                yield return new Marriage(82, "B233p1381", "5/1/98", "5/23/98", 22, "PASTOR", "Bride", "3/9/77", 21.21917808, "White", 0, null, 12, 3, 68.75, "Pisces");
                yield return new Marriage(83, "B233p1690", "5/26/98", "5/30/98", 4, "MINISTER", "Bride", "7/17/55", 42.89863014, "White", 1, "Divorce", 12, 0, 198.25, "Cancer");
                yield return new Marriage(84, "B233p1899", "6/9/98", "6/27/98", 18, "MARRIAGE OFFICIAL", "Bride", "3/18/79", 19.29041096, "White", 0, null, 12, 0, 77.25, "Pisces");
                yield return new Marriage(85, "B234p65", "6/18/98", "6/20/98", 2, "BISHOP", "Bride", "8/21/58", 39.85753425, "Black", 0, null, 12, null, 233.5, "Leo");
                yield return new Marriage(86, "B234p438", "7/13/98", "8/1/98", 19, "PASTOR", "Bride", "8/3/30", 68.04109589, "White", 1, "Death", 12, 5, 215.5, "Leo");
                yield return new Marriage(87, "B234p687", "7/31/98", "7/31/98", 0, "MARRIAGE OFFICIAL", "Bride", "10/29/25", 72.80273973, "White", 1, "Divorce", 12, 2, 302.75, "Scorpio");
                yield return new Marriage(88, "B234p904", "8/13/98", "8/13/98", 0, "MARRIAGE OFFICIAL", "Bride", "2/28/44", 54.49315068, "Black", 1, "Divorce", 12, 0, 59, "Pisces");
                yield return new Marriage(89, "B234p1292", "9/15/98", "9/26/98", 11, "PASTOR", "Bride", "2/13/76", 22.63287671, "White", 0, null, 12, 4, 44, "Aquarius");
                yield return new Marriage(90, "B234p1485", "10/2/98", "10/2/98", 0, "MARRIAGE OFFICIAL", "Bride", "9/17/48", 50.0739726, "White", 3, "Death", 12, 4, 261, "Virgo");
                yield return new Marriage(91, "B234p1621", "10/14/98", "10/23/98", 9, "MINISTER", "Bride", "7/20/82", 16.27123288, "White", 0, null, 11, 0, 201.5, "Cancer");
                yield return new Marriage(92, "B234p1966", "11/9/98", "11/9/98", 0, "MARRIAGE OFFICIAL", "Bride", "8/3/80", 18.27945205, "Black", 0, null, 12, 0, 216, "Leo");
                yield return new Marriage(93, "B235p7", "11/12/98", "11/28/98", 16, "MINISTER", "Bride", "9/12/77", 21.22465753, "White", 0, null, 12, null, 255.75, "Virgo");
                yield return new Marriage(94, "B235p259", "12/2/98", "12/5/98", 3, "PASTOR", "Bride", "6/8/67", 31.51506849, "White", 1, "Divorce", 12, 2, 159.25, "Gemini");
                yield return new Marriage(95, "B235p404", "12/14/98", "12/14/98", 0, "MARRIAGE OFFICIAL", "Bride", "6/24/61", 37.49863014, "White", 3, "Divorce", 12, 5, 175.75, "Cancer");
                yield return new Marriage(96, "B235p563", "12/23/98", "12/23/98", 0, "MARRIAGE OFFICIAL", "Bride", "1/21/76", 22.9369863, "White", 1, "Divorce", 8, 0, 21, "Aquarius");
                yield return new Marriage(97, "B235p837", "1/22/99", "1/31/99", 9, "MINISTER", "Bride", "5/26/28", 70.73150685, "White", 2, "Death", 12, 2, 147, "Gemini");
                yield return new Marriage(98, "B235p992", "2/5/99", "2/6/99", 1, "MINISTER", "Bride", "8/31/72", 26.45205479, "White", 0, null, 12, 4, 244, "Virgo");
            }
        }
    }
}
