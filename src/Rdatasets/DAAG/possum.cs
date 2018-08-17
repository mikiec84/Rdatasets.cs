// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Possum Measurements
    /// </summary>

    public class possum
    {
        public readonly int @case;
        public readonly int site;
        public readonly string Pop;
        public readonly string sex;
        public readonly string age;
        public readonly double hdlngth;
        public readonly double skullw;
        public readonly double totlngth;
        public readonly double taill;
        public readonly string footlgth;
        public readonly double earconch;
        public readonly double eye;
        public readonly double chest;
        public readonly double belly;

        public possum(int @case, int site, string Pop, string sex, string age, double hdlngth, double skullw, double totlngth, double taill, string footlgth, double earconch, double eye, double chest, double belly)
        {
            this.@case = @case;
            this.site = site;
            this.Pop = Pop;
            this.sex = sex;
            this.age = age;
            this.hdlngth = hdlngth;
            this.skullw = skullw;
            this.totlngth = totlngth;
            this.taill = taill;
            this.footlgth = footlgth;
            this.earconch = earconch;
            this.eye = eye;
            this.chest = chest;
            this.belly = belly;
        }

        public static IEnumerable<possum> Data
        {
            get
            {
                yield return new possum(1, 1, "Vic", "m", "8", 94.1, 60.4, 89, 36, "74.5", 54.5, 15.2, 28, 36);
                yield return new possum(2, 1, "Vic", "f", "6", 92.5, 57.6, 91.5, 36.5, "72.5", 51.2, 16, 28.5, 33);
                yield return new possum(3, 1, "Vic", "f", "6", 94, 60, 95.5, 39, "75.4", 51.9, 15.5, 30, 34);
                yield return new possum(4, 1, "Vic", "f", "6", 93.2, 57.1, 92, 38, "76.1", 52.2, 15.2, 28, 34);
                yield return new possum(5, 1, "Vic", "f", "2", 91.5, 56.3, 85.5, 36, "71", 53.2, 15.1, 28.5, 33);
                yield return new possum(6, 1, "Vic", "f", "1", 93.1, 54.8, 90.5, 35.5, "73.2", 53.6, 14.2, 30, 32);
                yield return new possum(7, 1, "Vic", "m", "2", 95.3, 58.2, 89.5, 36, "71.5", 52, 14.2, 30, 34.5);
                yield return new possum(8, 1, "Vic", "f", "6", 94.8, 57.6, 91, 37, "72.7", 53.9, 14.5, 29, 34);
                yield return new possum(9, 1, "Vic", "f", "9", 93.4, 56.3, 91.5, 37, "72.4", 52.9, 15.5, 28, 33);
                yield return new possum(10, 1, "Vic", "f", "6", 91.8, 58, 89.5, 37.5, "70.9", 53.4, 14.4, 27.5, 32);
                yield return new possum(11, 1, "Vic", "f", "9", 93.3, 57.2, 89.5, 39, "77.2", 51.3, 14.9, 31, 34);
                yield return new possum(12, 1, "Vic", "f", "5", 94.9, 55.6, 92, 35.5, "71.7", 51, 15.3, 28, 33);
                yield return new possum(13, 1, "Vic", "m", "5", 95.1, 59.9, 89.5, 36, "71", 49.8, 15.8, 27, 32);
                yield return new possum(14, 1, "Vic", "m", "3", 95.4, 57.6, 91.5, 36, "74.3", 53.7, 15.1, 28, 31.5);
                yield return new possum(15, 1, "Vic", "m", "5", 92.9, 57.6, 85.5, 34, "69.7", 51.8, 15.7, 28, 35);
                yield return new possum(16, 1, "Vic", "m", "4", 91.6, 56, 86, 34.5, "73", 51.4, 14.4, 28, 32);
                yield return new possum(17, 1, "Vic", "f", "1", 94.7, 67.7, 89.5, 36.5, "73.2", 53.2, 14.7, 29, 31);
                yield return new possum(18, 1, "Vic", "m", "2", 93.5, 55.7, 90, 36, "73.7", 55.4, 15.3, 28, 32);
                yield return new possum(19, 1, "Vic", "f", "5", 94.4, 55.4, 90.5, 35, "73.4", 53.9, 15.2, 28, 32);
                yield return new possum(20, 1, "Vic", "f", "4", 94.8, 56.3, 89, 38, "73.8", 52.4, 15.5, 27, 36);
                yield return new possum(21, 1, "Vic", "f", "3", 95.9, 58.1, 96.5, 39.5, "77.9", 52.9, 14.2, 30, 40);
                yield return new possum(22, 1, "Vic", "m", "3", 96.3, 58.5, 91, 39.5, "73.5", 52.1, 16.2, 28, 36);
                yield return new possum(23, 1, "Vic", "f", "4", 92.5, 56.1, 89, 36, "72.8", 53.3, 15.4, 28, 35);
                yield return new possum(24, 1, "Vic", "m", "2", 94.4, 54.9, 84, 34, "75", 53.5, 16.2, 27, 32);
                yield return new possum(25, 1, "Vic", "m", "3", 95.8, 58.5, 91.5, 35.5, "72.3", 51.6, 14.9, 31, 35);
                yield return new possum(26, 1, "Vic", "m", "7", 96, 59, 90, 36, "73.6", 56.2, 15, 29, 38);
                yield return new possum(27, 1, "Vic", "f", "2", 90.5, 54.5, 85, 35, "70.3", 50.8, 14.2, 23, 28);
                yield return new possum(28, 1, "Vic", "m", "4", 93.8, 56.8, 87, 34.5, "73.2", 53, 15.3, 27, 30);
                yield return new possum(29, 1, "Vic", "f", "3", 92.8, 56, 88, 35, "74.9", 51.8, 14, 24, 32);
                yield return new possum(30, 1, "Vic", "f", "2", 92.1, 54.4, 84, 33.5, "70.6", 50.8, 14.5, 24.5, 33);
                yield return new possum(31, 1, "Vic", "m", "3", 92.8, 54.1, 93, 37, "68", 52.5, 14.5, 27, 31);
                yield return new possum(32, 1, "Vic", "f", "4", 94.3, 56.7, 94, 39, "74.8", 52, 14.9, 28, 34);
                yield return new possum(33, 1, "Vic", "m", "3", 91.4, 54.6, 89, 37, "70.8", 51.8, 14.8, 24, 30);
                yield return new possum(34, 2, "Vic", "m", "2", 90.6, 55.7, 85.5, 36.5, "73.1", 53.1, 14.4, 26, 28.5);
                yield return new possum(35, 2, "Vic", "m", "4", 94.4, 57.9, 85, 35.5, "71.2", 55.5, 16.4, 28, 35.5);
                yield return new possum(36, 2, "Vic", "m", "7", 93.3, 59.3, 88, 35, "74.3", 52, 14.9, 25.5, 36);
                yield return new possum(37, 2, "Vic", "f", "2", 89.3, 54.8, 82.5, 35, "71.2", 52, 13.6, 28, 31.5);
                yield return new possum(38, 2, "Vic", "m", "7", 92.4, 56, 80.5, 35.5, "68.4", 49.5, 15.9, 27, 30);
                yield return new possum(39, 2, "Vic", "f", "1", 84.7, 51.5, 75, 34, "68.7", 53.4, 13, 25, 25);
                yield return new possum(40, 2, "Vic", "f", "3", 91, 55, 84.5, 36, "72.8", 51.4, 13.6, 27, 30);
                yield return new possum(41, 2, "Vic", "f", "5", 88.4, 57, 83, 36.5, null, 40.3, 15.9, 27, 30.5);
                yield return new possum(42, 2, "Vic", "m", "3", 85.3, 54.1, 77, 32, "62.7", 51.2, 13.8, 25.5, 33);
                yield return new possum(43, 2, "Vic", "f", "2", 90, 55.5, 81, 32, "72", 49.4, 13.4, 29, 31);
                yield return new possum(44, 2, "Vic", "m", null, 85.1, 51.5, 76, 35.5, "70.3", 52.6, 14.4, 23, 27);
                yield return new possum(45, 2, "Vic", "m", "3", 90.7, 55.9, 81, 34, "71.5", 54, 14.6, 27, 31.5);
                yield return new possum(46, 2, "Vic", "m", null, 91.4, 54.4, 84, 35, "72.8", 51.2, 14.4, 24.5, 35);
                yield return new possum(47, 3, "other", "m", "2", 90.1, 54.8, 89, 37.5, "66", 45.5, 15, 25, 33);
                yield return new possum(48, 3, "other", "m", "5", 98.6, 63.2, 85, 34, "66.9", 44.9, 17, 28, 35);
                yield return new possum(49, 3, "other", "m", "4", 95.4, 59.2, 85, 37, "69", 45, 15.9, 29.5, 35.5);
                yield return new possum(50, 3, "other", "f", "5", 91.6, 56.4, 88, 38, "65", 47.2, 14.9, 28, 36);
                yield return new possum(51, 3, "other", "f", "5", 95.6, 59.6, 85, 36, "64", 43.9, 17.4, 28, 38.5);
                yield return new possum(52, 3, "other", "m", "6", 97.6, 61, 93.5, 40, "67.9", 44.3, 15.8, 28.5, 32.5);
                yield return new possum(53, 3, "other", "f", "3", 93.1, 58.1, 91, 38, "67.4", 46, 16.5, 26, 33.5);
                yield return new possum(54, 4, "other", "m", "7", 96.9, 63, 91.5, 43, "71.3", 46, 17.5, 30, 36.5);
                yield return new possum(55, 4, "other", "m", "2", 103.1, 63.2, 92.5, 38, "72.5", 44.9, 16.4, 30.5, 36);
                yield return new possum(56, 4, "other", "m", "3", 99.9, 61.5, 93.7, 38, "68.7", 46.8, 16.4, 27.5, 31.5);
                yield return new possum(57, 4, "other", "f", "4", 95.1, 59.4, 93, 41, "67.2", 45.3, 14.5, 31, 39);
                yield return new possum(58, 4, "other", "m", "3", 94.5, 64.2, 91, 39, "66.5", 46.4, 14.4, 30.5, 33);
                yield return new possum(59, 4, "other", "m", "2", 102.5, 62.8, 96, 40, "73.2", 44.5, 14.7, 32, 36);
                yield return new possum(60, 4, "other", "f", "2", 91.3, 57.7, 88, 39, "63.1", 47, 14.4, 26, 30);
                yield return new possum(61, 5, "other", "m", "7", 95.7, 59, 86, 38, "63.1", 44.9, 15, 26.5, 31);
                yield return new possum(62, 5, "other", "f", "3", 91.3, 58, 90.5, 39, "65.5", 41.3, 16, 27, 32);
                yield return new possum(63, 5, "other", "f", "6", 92, 56.4, 88.5, 38, "64.1", 46.3, 15.2, 25.5, 28.5);
                yield return new possum(64, 5, "other", "f", "3", 96.9, 56.5, 89.5, 38.5, "63", 45.1, 17.1, 25.5, 33);
                yield return new possum(65, 5, "other", "f", "5", 93.5, 57.4, 88.5, 38, "68.2", 41.7, 14, 29, 38.5);
                yield return new possum(66, 5, "other", "f", "3", 90.4, 55.8, 86, 36.5, "63.2", 44.2, 15.7, 26.5, 34);
                yield return new possum(67, 5, "other", "m", "4", 93.3, 57.6, 85, 36.5, "64.7", 44.1, 16.5, 27.5, 29.5);
                yield return new possum(68, 5, "other", "m", "5", 94.1, 56, 88.5, 38, "65.9", 43.1, 17.4, 27, 30);
                yield return new possum(69, 5, "other", "m", "5", 98, 55.6, 88, 37.5, "65", 45.6, 15, 28.5, 34);
                yield return new possum(70, 5, "other", "f", "7", 91.9, 56.4, 87, 38, "65.4", 44.1, 13, 27, 34);
                yield return new possum(71, 5, "other", "m", "6", 92.8, 57.6, 90, 40, "65.7", 42.8, 15, 27.5, 34);
                yield return new possum(72, 5, "other", "m", "1", 85.9, 52.4, 80.5, 35, "62", 42.4, 14.1, 25.5, 30);
                yield return new possum(73, 5, "other", "m", "1", 82.5, 52.3, 82, 36.5, "65.7", 44.7, 16, 23.5, 28);
                yield return new possum(74, 6, "other", "f", "4", 88.7, 52, 83, 38, "61.5", 45.9, 14.7, 26, 34);
                yield return new possum(75, 6, "other", "m", "6", 93.8, 58.1, 89, 38, "66.2", 45.6, 16.9, 26, 33.5);
                yield return new possum(76, 6, "other", "m", "5", 92.4, 56.8, 89, 41, "64.5", 46.4, 17.8, 26, 33);
                yield return new possum(77, 6, "other", "m", "6", 93.6, 56.2, 84, 36, "62.8", 42.9, 16.2, 25, 35);
                yield return new possum(78, 6, "other", "m", "1", 86.5, 51, 81, 36.5, "63", 44.3, 13.2, 23, 28);
                yield return new possum(79, 6, "other", "m", "1", 85.8, 50, 81, 36.5, "62.8", 43, 14.8, 22, 28.5);
                yield return new possum(80, 6, "other", "m", "1", 86.7, 52.6, 84, 38, "62.3", 44.8, 15, 23.5, 30.5);
                yield return new possum(81, 6, "other", "m", "3", 90.6, 56, 85.5, 38, "65.6", 41.7, 17, 27.5, 35);
                yield return new possum(82, 6, "other", "f", "4", 86, 54, 82, 36.5, "60.7", 42.9, 15.4, 26, 32);
                yield return new possum(83, 6, "other", "f", "3", 90, 53.8, 81.5, 36, "62", 43.3, 14, 25, 29);
                yield return new possum(84, 6, "other", "m", "3", 88.4, 54.6, 80.5, 36, "62.6", 43.6, 16.3, 25, 28.5);
                yield return new possum(85, 6, "other", "m", "3", 89.5, 56.2, 92, 40.5, "65.6", 43.5, 14.5, 27, 31.5);
                yield return new possum(86, 6, "other", "f", "3", 88.2, 53.2, 86.5, 38.5, "60.3", 43.7, 13.6, 26, 31);
                yield return new possum(87, 7, "other", "m", "2", 98.5, 60.7, 93, 41.5, "71.7", 46.8, 15, 26, 36);
                yield return new possum(88, 7, "other", "f", "2", 89.6, 58, 87.5, 38, "66.7", 43.5, 16, 25.5, 31.5);
                yield return new possum(89, 7, "other", "m", "6", 97.7, 58.4, 84.5, 35, "64.4", 46.2, 14.4, 29, 30.5);
                yield return new possum(90, 7, "other", "m", "3", 92.6, 54.6, 85, 38.5, "69.8", 44.8, 14.5, 25.5, 32.5);
                yield return new possum(91, 7, "other", "m", "3", 97.8, 59.6, 89, 38, "65.5", 48, 15, 26, 32);
                yield return new possum(92, 7, "other", "m", "2", 90.7, 56.3, 85, 37, "67.6", 46.8, 14.5, 25.5, 31);
                yield return new possum(93, 7, "other", "m", "3", 89.2, 54, 82, 38, "63.8", 44.9, 12.8, 24, 31);
                yield return new possum(94, 7, "other", "m", "7", 91.8, 57.6, 84, 35.5, "64.2", 45.1, 14.4, 29, 35);
                yield return new possum(95, 7, "other", "m", "4", 91.6, 56.6, 88.5, 37.5, "64.5", 45.4, 14.9, 27, 31);
                yield return new possum(96, 7, "other", "m", "4", 94.8, 55.7, 83, 38, "66.5", 47.7, 14, 25, 33);
                yield return new possum(97, 7, "other", "m", "3", 91, 53.1, 86, 38, "63.8", 46, 14.5, 25, 31.5);
                yield return new possum(98, 7, "other", "m", "5", 93.2, 68.6, 84, 35, "65.6", 44.3, 14.5, 28.5, 32);
                yield return new possum(99, 7, "other", "f", "3", 93.3, 56.2, 86.5, 38.5, "64.8", 43.8, 14, 28, 35);
                yield return new possum(100, 7, "other", "m", "1", 89.5, 56, 81.5, 36.5, "66", 46.8, 14.8, 23, 27);
                yield return new possum(101, 7, "other", "m", "1", 88.6, 54.7, 82.5, 39, "64.4", 48, 14, 25, 33);
                yield return new possum(102, 7, "other", "f", "6", 92.4, 55, 89, 38, "63.5", 45.4, 13, 25, 30);
                yield return new possum(103, 7, "other", "m", "4", 91.5, 55.2, 82.5, 36.5, "62.9", 45.9, 15.4, 25, 29);
                yield return new possum(104, 7, "other", "f", "3", 93.6, 59.9, 89, 40, "67.6", 46, 14.8, 28.5, 33.5);
            }
        }
    }
}
