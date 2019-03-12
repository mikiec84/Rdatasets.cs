// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from A.-M. Guerry, "Essay on the Moral Statistics of France"
    /// </summary>

    public class Guerry
    {
        public readonly int κ;
        public readonly int dept;
        public readonly string Region;
        public readonly string Department;
        public readonly int Crime_pers;
        public readonly int Crime_prop;
        public readonly int Literacy;
        public readonly int Donations;
        public readonly int Infants;
        public readonly int Suicides;
        public readonly string MainCity;
        public readonly int Wealth;
        public readonly int Commerce;
        public readonly int Clergy;
        public readonly int Crime_parents;
        public readonly int Infanticide;
        public readonly int Donation_clergy;
        public readonly int Lottery;
        public readonly int Desertion;
        public readonly int Instruction;
        public readonly int Prostitutes;
        public readonly double Distance;
        public readonly int Area;
        public readonly double Pop1831;

        public Guerry(int κ, int dept, string Region, string Department, int Crime_pers, int Crime_prop, int Literacy, int Donations, int Infants, int Suicides, string MainCity, int Wealth, int Commerce, int Clergy, int Crime_parents, int Infanticide, int Donation_clergy, int Lottery, int Desertion, int Instruction, int Prostitutes, double Distance, int Area, double Pop1831)
        {
            this.κ = κ;
            this.dept = dept;
            this.Region = Region;
            this.Department = Department;
            this.Crime_pers = Crime_pers;
            this.Crime_prop = Crime_prop;
            this.Literacy = Literacy;
            this.Donations = Donations;
            this.Infants = Infants;
            this.Suicides = Suicides;
            this.MainCity = MainCity;
            this.Wealth = Wealth;
            this.Commerce = Commerce;
            this.Clergy = Clergy;
            this.Crime_parents = Crime_parents;
            this.Infanticide = Infanticide;
            this.Donation_clergy = Donation_clergy;
            this.Lottery = Lottery;
            this.Desertion = Desertion;
            this.Instruction = Instruction;
            this.Prostitutes = Prostitutes;
            this.Distance = Distance;
            this.Area = Area;
            this.Pop1831 = Pop1831;
        }

        public static IEnumerable<Guerry> Data
        {
            get
            {
                yield return new Guerry(1, 1, "E", "Ain", 28870, 15890, 37, 5098, 33120, 35039, "2:Med", 73, 58, 11, 71, 60, 69, 41, 55, 46, 13, 218.372, 5762, 346.03);
                yield return new Guerry(2, 2, "N", "Aisne", 26226, 5521, 51, 8901, 14572, 12831, "2:Med", 22, 10, 82, 4, 82, 36, 38, 82, 24, 327, 65.945, 7369, 513);
                yield return new Guerry(3, 3, "C", "Allier", 26747, 7925, 13, 10973, 17044, 114121, "2:Med", 61, 66, 68, 46, 42, 76, 66, 16, 85, 34, 161.927, 7340, 298.26);
                yield return new Guerry(4, 4, "E", "Basses-Alpes", 12935, 7289, 46, 2733, 23018, 14238, "1:Sm", 76, 49, 5, 70, 12, 37, 80, 32, 29, 2, 351.399, 6925, 155.9);
                yield return new Guerry(5, 5, "E", "Hautes-Alpes", 17488, 8174, 69, 6962, 23076, 16171, "1:Sm", 83, 65, 10, 22, 23, 64, 79, 35, 7, 1, 320.28, 5549, 129.1);
                yield return new Guerry(6, 7, "S", "Ardeche", 9474, 10263, 27, 3188, 42117, 52547, "1:Sm", 84, 1, 28, 76, 47, 67, 70, 19, 62, 1, 279.413, 5529, 340.73);
                yield return new Guerry(7, 8, "N", "Ardennes", 35203, 8847, 67, 6400, 16106, 26198, "2:Med", 33, 4, 50, 53, 85, 49, 31, 62, 9, 83, 105.694, 5229, 289.62);
                yield return new Guerry(8, 9, "S", "Ariege", 6173, 9597, 18, 3542, 22916, 123625, "1:Sm", 72, 60, 39, 74, 28, 63, 75, 22, 77, 3, 385.313, 4890, 253.12);
                yield return new Guerry(9, 10, "E", "Aube", 19602, 4086, 59, 3608, 18642, 10989, "2:Med", 14, 3, 42, 77, 54, 9, 28, 86, 15, 207, 83.244, 6004, 246.36);
                yield return new Guerry(10, 11, "S", "Aude", 15647, 10431, 34, 2582, 20225, 66498, "2:Med", 17, 35, 15, 80, 35, 27, 50, 63, 48, 1, 370.949, 6139, 270.13);
                yield return new Guerry(11, 12, "S", "Aveyron", 8236, 6731, 31, 3211, 21981, 116671, "2:Med", 50, 70, 3, 51, 5, 23, 81, 10, 44, 4, 296.089, 8735, 359.06);
                yield return new Guerry(12, 13, "S", "Bouches-du-Rhone", 13409, 5291, 38, 2314, 9325, 8107, "3:Lg", 2, 26, 30, 45, 74, 55, 3, 23, 43, 25, 362.568, 5087, 359.47);
                yield return new Guerry(13, 14, "N", "Calvados", 17577, 4500, 52, 27830, 8983, 31807, "2:Med", 10, 48, 7, 57, 56, 11, 13, 12, 22, 194, 117.487, 5548, 494.7);
                yield return new Guerry(14, 15, "C", "Cantal", 18070, 11645, 31, 4093, 15335, 87338, "2:Med", 59, 7, 6, 79, 83, 66, 82, 1, 51, 20, 245.849, 5726, 258.59);
                yield return new Guerry(15, 16, "W", "Charente", 24964, 13018, 36, 13602, 19454, 25720, "2:Med", 86, 47, 79, 2, 7, 81, 60, 61, 47, 8, 224.339, 5956, 362.53);
                yield return new Guerry(16, 17, "W", "Charente-Inferieure", 18712, 5357, 39, 13254, 23999, 16798, "2:Med", 18, 5, 86, 3, 38, 72, 35, 74, 42, 27, 238.538, 6864, 445.25);
                yield return new Guerry(17, 18, "C", "Cher", 21934, 10503, 13, 9561, 23574, 19497, "2:Med", 63, 56, 83, 69, 11, 86, 44, 51, 83, 26, 116.257, 7235, 256.06);
                yield return new Guerry(18, 19, "C", "Correze", 15262, 12949, 12, 14993, 19330, 47480, "2:Med", 74, 80, 46, 86, 16, 82, 84, 2, 86, 3, 227.899, 5857, 294.83);
                yield return new Guerry(19, 21, "E", "Cote-d'Or", 32256, 9159, 60, 2540, 15599, 16128, "2:Med", 16, 12, 37, 49, 27, 18, 33, 78, 13, 206, 136.109, 8763, 375.88);
                yield return new Guerry(20, 22, "W", "Cotes-du-Nord", 28607, 7050, 16, 10387, 36098, 75056, "2:Med", 70, 86, 30, 6, 69, 15, 72, 47, 80, 16, 225.161, 6878, 598.87);
                yield return new Guerry(21, 23, "C", "Creuse", 37014, 20235, 23, 10997, 14363, 77823, "1:Sm", 78, 82, 75, 75, 24, 75, 85, 4, 71, 12, 180.846, 5565, 265.38);
                yield return new Guerry(22, 24, "W", "Dordogne", 21585, 10237, 18, 4687, 21375, 36024, "2:Med", 60, 72, 77, 64, 18, 79, 77, 44, 78, 3, 253.776, 9060, 482.75);
                yield return new Guerry(23, 25, "E", "Doubs", 11560, 5914, 73, 3436, 12512, 40690, "2:Med", 31, 57, 24, 38, 25, 6, 18, 73, 2, 65, 202.065, 5234, 265.54);
                yield return new Guerry(24, 26, "E", "Drome", 13396, 7759, 42, 2829, 16348, 23816, "2:Med", 66, 41, 22, 21, 13, 62, 54, 46, 38, 8, 295.543, 6530, 299.56);
                yield return new Guerry(25, 27, "N", "Eure", 14795, 4774, 51, 11712, 16039, 13493, "2:Med", 20, 17, 27, 39, 45, 45, 47, 27, 23, 179, 61.863, 6040, 424.25);
                yield return new Guerry(26, 28, "C", "Eure-et-Loir", 21368, 4016, 54, 4553, 14475, 15015, "2:Med", 11, 21, 16, 18, 62, 14, 48, 72, 18, 180, 54.558, 5880, 278.82);
                yield return new Guerry(27, 29, "W", "Finistere", 29872, 6842, 15, 23945, 28392, 25143, "2:Med", 36, 84, 66, 24, 78, 25, 36, 77, 81, 42, 276.21, 6733, 524.4);
                yield return new Guerry(28, 30, "S", "Gard", 13115, 7990, 40, 3048, 28726, 18292, "2:Med", 26, 31, 81, 15, 39, 59, 20, 40, 40, 5, 323.004, 5853, 357.38);
                yield return new Guerry(29, 31, "S", "Haute-Garonne", 18642, 7204, 31, 2286, 15378, 56140, "3:Lg", 23, 40, 23, 62, 59, 13, 25, 15, 33, 8, 361.668, 6257, 427.86);
                yield return new Guerry(30, 32, "S", "Gers", 18642, 10486, 38, 2848, 15250, 61510, "2:Med", 40, 30, 12, 43, 13, 32, 74, 30, 44, 1, 343.569, 6309, 312.16);
                yield return new Guerry(31, 33, "W", "Gironde", 24096, 7423, 40, 5076, 10676, 19220, "3:Lg", 8, 20, 69, 27, 80, 48, 4, 13, 41, 39, 291.624, 10000, 554.23);
                yield return new Guerry(32, 34, "S", "Herault", 12814, 10954, 45, 1680, 21346, 30869, "2:Med", 12, 34, 67, 47, 51, 28, 19, 43, 32, 9, 344.03, 6101, 346.3);
                yield return new Guerry(33, 35, "W", "Ille-et-Vilaine", 22138, 6524, 25, 7686, 40736, 45180, "2:Med", 55, 77, 19, 12, 31, 22, 37, 50, 66, 77, 179.379, 6775, 547.05);
                yield return new Guerry(34, 36, "C", "Indre", 32404, 7624, 17, 11315, 20046, 25014, "2:Med", 54, 55, 84, 82, 19, 83, 69, 29, 79, 14, 139.587, 6791, 245.29);
                yield return new Guerry(35, 37, "C", "Indre-et-Loire", 19131, 6909, 27, 7254, 16601, 15272, "2:Med", 27, 25, 58, 48, 3, 41, 15, 49, 63, 59, 126.468, 6127, 297.02);
                yield return new Guerry(36, 38, "E", "Isere", 18785, 8326, 29, 4077, 12236, 36275, "2:Med", 65, 46, 53, 52, 27, 73, 23, 26, 57, 12, 268.661, 7431, 550.26);
                yield return new Guerry(37, 39, "E", "Jura", 26221, 8059, 73, 3012, 20384, 34476, "2:Med", 62, 54, 32, 84, 66, 43, 39, 71, 3, 32, 197.155, 4999, 312.5);
                yield return new Guerry(38, 40, "W", "Landes", 17687, 6170, 28, 12059, 15302, 35375, "1:Sm", 81, 68, 63, 1, 43, 56, 73, 28, 58, 3, 344.676, 9243, 281.5);
                yield return new Guerry(39, 41, "C", "Loir-et-Cher", 21292, 6017, 27, 5626, 13364, 14417, "2:Med", 19, 23, 57, 65, 37, 70, 46, 54, 61, 54, 90.735, 6343, 235.75);
                yield return new Guerry(40, 42, "C", "Loire", 27491, 12665, 29, 3446, 29605, 71364, "2:Med", 24, 79, 34, 78, 77, 34, 42, 6, 56, 14, 215.598, 4781, 391.22);
                yield return new Guerry(41, 43, "C", "Haute-Loire", 16170, 18043, 21, 2746, 31017, 163241, "2:Med", 75, 85, 8, 73, 17, 65, 62, 3, 72, 10, 248.877, 4977, 292.08);
                yield return new Guerry(42, 44, "W", "Loire-Inferieure", 19314, 9392, 24, 8310, 14097, 27289, "3:Lg", 80, 76, 73, 56, 52, 29, 12, 45, 67, 63, 199.167, 6815, 470.09);
                yield return new Guerry(43, 45, "C", "Loiret", 17722, 5042, 42, 4753, 9986, 11813, "2:Med", 9, 24, 54, 44, 22, 16, 17, 60, 37, 256, 61.106, 6775, 305.28);
                yield return new Guerry(44, 46, "S", "Lot", 5883, 9049, 24, 5194, 20383, 48783, "2:Med", 42, 67, 20, 54, 15, 68, 78, 24, 68, 1, 275.725, 5217, 283.83);
                yield return new Guerry(45, 47, "W", "Lot-et-Garonne", 22969, 8943, 31, 4432, 17681, 38501, "2:Med", 7, 53, 49, 26, 32, 46, 52, 34, 50, 5, 302.345, 5361, 346.89);
                yield return new Guerry(46, 48, "S", "Lozere", 7710, 5990, 27, 2040, 25157, 11092, "1:Sm", 77, 69, 2, 72, 45, 42, 86, 5, 60, 0, 283.81, 5167, 140.35);
                yield return new Guerry(47, 49, "W", "Maine-et-Loire", 29692, 8520, 23, 4410, 18708, 33358, "2:Med", 34, 52, 43, 19, 36, 20, 24, 76, 70, 35, 157.437, 7166, 467.87);
                yield return new Guerry(48, 50, "N", "Manche", 31078, 7424, 43, 5179, 14281, 55564, "2:Med", 32, 73, 9, 33, 70, 3, 59, 21, 36, 98, 157.187, 5938, 591.28);
                yield return new Guerry(49, 51, "N", "Marne", 15602, 4950, 63, 3963, 11267, 8334, "2:Med", 13, 6, 47, 8, 58, 39, 22, 81, 10, 262, 77.364, 6211, 337.08);
                yield return new Guerry(50, 52, "E", "Haute-Marne", 26231, 9539, 72, 4013, 17507, 19586, "1:Sm", 25, 7, 18, 63, 55, 4, 56, 65, 4, 138, 129.765, 8162, 249.83);
                yield return new Guerry(51, 53, "W", "Mayenne", 28331, 9198, 19, 2107, 18544, 28331, "2:Med", 38, 75, 40, 59, 40, 8, 61, 58, 75, 46, 139.999, 5175, 352.59);
                yield return new Guerry(52, 54, "E", "Meurthe", 26674, 6831, 68, 3912, 12355, 15652, "2:Med", 57, 11, 26, 5, 71, 1, 21, 70, 8, 154, 159.648, 5241, 415.57);
                yield return new Guerry(53, 55, "N", "Meuse", 24507, 9190, 74, 4196, 17333, 13463, "2:Med", 52, 2, 33, 17, 65, 12, 58, 59, 1, 131, 126.378, 6216, 314.59);
                yield return new Guerry(54, 56, "W", "Morbihan", 23316, 7940, 14, 14739, 31754, 34196, "2:Med", 48, 81, 31, 9, 29, 7, 32, 69, 82, 38, 230.531, 6823, 433.52);
                yield return new Guerry(55, 57, "N", "Moselle", 12153, 4529, 57, 9515, 13877, 25572, "3:Lg", 53, 19, 13, 35, 9, 2, 16, 68, 16, 165, 180.462, 6216, 417);
                yield return new Guerry(56, 58, "C", "Nievre", 25087, 8236, 20, 10452, 19747, 29381, "2:Med", 44, 33, 80, 83, 20, 80, 63, 37, 74, 39, 119.718, 6817, 282.52);
                yield return new Guerry(57, 59, "N", "Nord", 26740, 6175, 45, 6092, 8926, 13851, "3:Lg", 28, 38, 74, 14, 81, 38, 7, 64, 30, 308, 106.335, 5743, 989.94);
                yield return new Guerry(58, 60, "N", "Oise", 28180, 6659, 54, 5501, 18021, 5994, "2:Med", 15, 14, 60, 31, 86, 50, 43, 57, 20, 337, 33.768, 5860, 397.73);
                yield return new Guerry(59, 61, "N", "Orne", 28329, 8248, 45, 9242, 20852, 34069, "2:Med", 35, 62, 21, 29, 50, 31, 57, 25, 33, 117, 97.554, 6103, 441.88);
                yield return new Guerry(60, 62, "N", "Pas-de-Calais", 23101, 4040, 49, 5740, 10575, 15400, "2:Med", 45, 39, 44, 36, 79, 10, 27, 48, 26, 163, 104.4, 6671, 655.22);
                yield return new Guerry(61, 63, "C", "Puy-de-Dome", 17256, 12141, 19, 5963, 22948, 78148, "2:Med", 51, 78, 52, 42, 63, 61, 53, 8, 76, 62, 205.218, 7970, 573.11);
                yield return new Guerry(62, 64, "W", "Basses-Pyrenees", 16722, 8533, 47, 3299, 12393, 65995, "2:Med", 79, 71, 38, 34, 72, 60, 34, 7, 28, 12, 387.935, 7645, 428.4);
                yield return new Guerry(63, 65, "S", "Hautes-Pyrenees", 12223, 9797, 53, 6001, 12125, 148039, "2:Med", 85, 51, 17, 85, 75, 71, 76, 20, 21, 5, 386.559, 4464, 233.03);
                yield return new Guerry(64, 66, "S", "Pyrenees-Orientales", 6728, 7632, 31, 11644, 15167, 37843, "2:Med", 71, 37, 4, 67, 84, 77, 11, 18, 52, 5, 403.445, 4116, 157.05);
                yield return new Guerry(65, 67, "E", "Bas-Rhin", 12309, 4920, 62, 14472, 14356, 18623, "3:Lg", 46, 16, 64, 23, 48, 51, 5, 53, 12, 101, 217.752, 4755, 540.21);
                yield return new Guerry(66, 68, "E", "Haut-Rhin", 7343, 4915, 71, 6001, 14783, 21233, "2:Med", 58, 29, 65, 40, 53, 17, 10, 56, 5, 26, 217.971, 3525, 424.26);
                yield return new Guerry(67, 69, "E", "Rhone", 18793, 4504, 45, 1983, 3910, 17003, "3:Lg", 6, 18, 35, 37, 33, 21, 2, 14, 31, 104, 213.032, 3249, 434.43);
                yield return new Guerry(68, 70, "E", "Haute-Saone", 22339, 7770, 59, 11701, 11850, 39714, "1:Sm", 69, 27, 25, 25, 68, 57, 65, 83, 14, 99, 176.135, 5360, 338.91);
                yield return new Guerry(69, 71, "E", "Saone-et-Loire", 28391, 10708, 32, 3710, 20442, 22184, "2:Med", 49, 61, 59, 11, 10, 58, 45, 31, 49, 40, 168.713, 8575, 523.97);
                yield return new Guerry(70, 72, "C", "Sarthe", 33913, 8294, 30, 3357, 10779, 29280, "2:Med", 41, 45, 41, 41, 57, 19, 49, 75, 35, 79, 108.294, 6206, 457.37);
                yield return new Guerry(71, 75, "N", "Seine", 13945, 1368, 71, 4204, 2660, 3632, "3:Lg", 1, 9, 85, 60, 67, 53, 1, 33, 6, 4744, 0, 762, 935.11);
                yield return new Guerry(72, 76, "N", "Seine-Inferieure", 18355, 2906, 43, 7245, 7506, 9523, "3:Lg", 3, 22, 62, 28, 61, 74, 9, 36, 35, 546, 75.658, 6278, 693.68);
                yield return new Guerry(73, 77, "N", "Seine-et-Marne", 22201, 5786, 54, 5303, 16324, 7315, "2:Med", 4, 13, 56, 16, 73, 26, 29, 67, 37, 453, 27.647, 5915, 323.89);
                yield return new Guerry(74, 78, "N", "Seine-et-Oise", 12477, 3879, 56, 4007, 16303, 3460, "2:Med", 5, 8, 45, 10, 30, 24, 6, 42, 17, 874, 16.888, 5334, 448.18);
                yield return new Guerry(75, 79, "W", "Deux-Sevres", 18400, 6863, 41, 16956, 25461, 24533, "2:Med", 39, 59, 72, 30, 4, 85, 71, 84, 39, 6, 188.474, 5999, 297.85);
                yield return new Guerry(76, 80, "N", "Somme", 33592, 7144, 44, 4964, 12447, 12836, "2:Med", 21, 36, 48, 7, 64, 33, 30, 80, 34, 302, 69.52, 6170, 543.7);
                yield return new Guerry(77, 81, "S", "Tarn", 13019, 6241, 20, 3449, 29305, 68980, "2:Med", 47, 44, 14, 13, 9, 47, 67, 17, 73, 3, 328.146, 5758, 333.84);
                yield return new Guerry(78, 82, "S", "Tarn-et-Garonne", 14790, 8680, 25, 4558, 23771, 48317, "2:Med", 29, 50, 29, 66, 41, 52, 64, 39, 64, 4, 313.09, 3718, 242.51);
                yield return new Guerry(79, 83, "S", "Var", 13145, 9572, 23, 2449, 14800, 13380, "2:Med", 43, 39, 61, 55, 49, 40, 26, 52, 69, 6, 389.512, 5973, 317.5);
                yield return new Guerry(80, 84, "S", "Vaucluse", 13576, 5731, 37, 1246, 17239, 19024, "2:Med", 64, 28, 78, 61, 76, 54, 8, 41, 45, 2, 337.215, 3567, 239.11);
                yield return new Guerry(81, 85, "W", "Vendee", 20827, 7566, 28, 14035, 62486, 67963, "1:Sm", 56, 64, 70, 50, 44, 30, 68, 79, 59, 4, 212.459, 6720, 330.36);
                yield return new Guerry(82, 86, "W", "Vienne", 15010, 4710, 25, 8922, 35224, 21851, "2:Med", 68, 43, 71, 20, 1, 44, 40, 38, 65, 18, 170.523, 6990, 282.73);
                yield return new Guerry(83, 87, "C", "Haute-Vienne", 16256, 6402, 13, 13817, 19940, 33497, "2:Med", 67, 63, 76, 68, 6, 78, 55, 11, 84, 7, 198.874, 5520, 285.13);
                yield return new Guerry(84, 88, "E", "Vosges", 18835, 9044, 62, 4040, 14978, 33029, "2:Med", 82, 42, 51, 58, 34, 5, 14, 85, 11, 43, 174.477, 5874, 397.99);
                yield return new Guerry(85, 89, "C", "Yonne", 18006, 6516, 47, 4276, 16616, 12789, "2:Med", 30, 15, 55, 32, 22, 35, 51, 66, 27, 272, 81.797, 7427, 352.49);
                yield return new Guerry(86, 200, null, "Corse", 2199, 4589, 49, 37015, 24743, 37016, "2:Med", 37, 83, 1, 81, 2, 84, 83, 9, 25, 1, 539.213, 8680, 195.41);
            }
        }
    }
}
