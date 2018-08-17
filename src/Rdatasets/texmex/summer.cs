// ReSharper disable All

namespace Rdatasets.texmex
{
    using System.Collections.Generic;

    /// <summary>
    /// Air pollution data, separately for summer and winter months
    /// </summary>

    public class summer
    {
        public readonly int O3;
        public readonly int NO2;
        public readonly int NO;
        public readonly int SO2;
        public readonly int PM10;

        public summer(int O3, int NO2, int NO, int SO2, int PM10)
        {
            this.O3 = O3;
            this.NO2 = NO2;
            this.NO = NO;
            this.SO2 = SO2;
            this.PM10 = PM10;
        }

        public static IEnumerable<summer> Data
        {
            get
            {
                yield return new summer(32, 48, 94, 8, 27);
                yield return new summer(29, 49, 86, 6, 25);
                yield return new summer(32, 34, 16, 20, 32);
                yield return new summer(32, 35, 79, 9, 22);
                yield return new summer(33, 50, 108, 11, 24);
                yield return new summer(27, 58, 92, 16, 26);
                yield return new summer(34, 53, 100, 17, 29);
                yield return new summer(22, 51, 99, 18, 30);
                yield return new summer(30, 40, 45, 16, 29);
                yield return new summer(35, 43, 37, 6, 24);
                yield return new summer(27, 53, 102, 16, 46);
                yield return new summer(23, 58, 153, 35, 46);
                yield return new summer(28, 29, 54, 13, 44);
                yield return new summer(34, 29, 43, 4, 67);
                yield return new summer(35, 29, 42, 5, 33);
                yield return new summer(45, 37, 21, 10, 32);
                yield return new summer(36, 30, 14, 3, 29);
                yield return new summer(26, 45, 106, 15, 44);
                yield return new summer(23, 52, 87, 9, 28);
                yield return new summer(16, 49, 111, 14, 49);
                yield return new summer(23, 48, 175, 18, 56);
                yield return new summer(25, 49, 64, 13, 43);
                yield return new summer(20, 43, 41, 30, 40);
                yield return new summer(36, 41, 58, 8, 23);
                yield return new summer(26, 52, 67, 16, 45);
                yield return new summer(34, 46, 31, 15, 46);
                yield return new summer(34, 36, 44, 4, 31);
                yield return new summer(41, 29, 53, 21, 42);
                yield return new summer(38, 38, 25, 45, 39);
                yield return new summer(38, 47, 40, 63, 107);
                yield return new summer(37, 62, 97, 13, 41);
                yield return new summer(43, 23, 17, 3, 30);
                yield return new summer(36, 29, 42, 8, 29);
                yield return new summer(38, 26, 31, 4, 26);
                yield return new summer(34, 33, 44, 9, 30);
                yield return new summer(30, 33, 47, 5, 30);
                yield return new summer(33, 27, 39, 6, 26);
                yield return new summer(41, 15, 10, 3, 20);
                yield return new summer(42, 23, 12, 2, 19);
                yield return new summer(37, 32, 39, 9, 41);
                yield return new summer(33, 40, 44, 10, 32);
                yield return new summer(34, 31, 52, 5, 32);
                yield return new summer(36, 30, 37, 6, 16);
                yield return new summer(25, 29, 50, 5, 22);
                yield return new summer(35, 27, 17, 5, 108);
                yield return new summer(41, 36, 30, 15, 109);
                yield return new summer(46, 44, 89, 10, 65);
                yield return new summer(41, 40, 94, 4, 47);
                yield return new summer(34, 78, 140, 28, 93);
                yield return new summer(39, 46, 62, 15, 105);
                yield return new summer(29, 41, 51, 5, 27);
                yield return new summer(32, 31, 60, 3, 49);
                yield return new summer(29, 38, 60, 6, 62);
                yield return new summer(20, 49, 139, 12, 34);
                yield return new summer(25, 48, 105, 6, 61);
                yield return new summer(32, 32, 59, 4, 60);
                yield return new summer(24, 26, 34, 3, 39);
                yield return new summer(22, 28, 58, 7, 57);
                yield return new summer(34, 24, 17, 6, 52);
                yield return new summer(25, 27, 48, 5, 41);
                yield return new summer(30, 39, 74, 34, 53);
                yield return new summer(30, 29, 57, 9, 36);
                yield return new summer(32, 36, 54, 3, 101);
                yield return new summer(34, 33, 44, 3, 26);
                yield return new summer(29, 48, 99, 18, 58);
                yield return new summer(28, 26, 26, 5, 40);
                yield return new summer(24, 34, 100, 3, 28);
                yield return new summer(22, 33, 71, 19, 34);
                yield return new summer(27, 43, 104, 8, 24);
                yield return new summer(23, 41, 122, 6, 128);
                yield return new summer(22, 34, 64, 38, 55);
                yield return new summer(52, 51, 40, 123, 59);
                yield return new summer(32, 40, 80, 7, 84);
                yield return new summer(30, 21, 15, 7, 24);
                yield return new summer(29, 36, 79, 22, 64);
                yield return new summer(53, 46, 108, 11, 68);
                yield return new summer(32, 43, 95, 4, 96);
                yield return new summer(23, 49, 47, 178, 101);
                yield return new summer(40, 35, 35, 121, 51);
                yield return new summer(33, 27, 34, 19, 44);
                yield return new summer(71, 61, 52, 11, 77);
                yield return new summer(26, 50, 86, 93, 97);
                yield return new summer(22, 39, 49, 8, 37);
                yield return new summer(14, 45, 68, 38, 70);
                yield return new summer(20, 50, 63, 13, 78);
                yield return new summer(27, 71, 120, 147, 95);
                yield return new summer(31, 42, 38, 11, 82);
                yield return new summer(28, 27, 56, 3, 33);
                yield return new summer(46, 52, 59, 9, 48);
                yield return new summer(65, 60, 99, 28, 97);
                yield return new summer(30, 31, 44, 8, 28);
                yield return new summer(36, 44, 56, 24, 63);
                yield return new summer(27, 28, 58, 10, 71);
                yield return new summer(36, 20, 18, 4, 37);
                yield return new summer(31, 16, 8, 8, 16);
                yield return new summer(30, 29, 40, 38, 34);
                yield return new summer(33, 36, 47, 59, 38);
                yield return new summer(40, 46, 138, 313, 85);
                yield return new summer(38, 58, 103, 24, 119);
                yield return new summer(29, 36, 36, 6, 54);
                yield return new summer(37, 34, 55, 102, 38);
                yield return new summer(40, 48, 66, 136, 84);
                yield return new summer(42, 54, 125, 14, 70);
                yield return new summer(25, 34, 90, 8, 52);
                yield return new summer(24, 39, 57, 4, 30);
                yield return new summer(33, 33, 71, 6, 23);
                yield return new summer(48, 62, 89, 18, 73);
                yield return new summer(55, 41, 21, 28, 65);
                yield return new summer(38, 47, 18, 62, 64);
                yield return new summer(27, 45, 121, 5, 69);
                yield return new summer(27, 33, 73, 15, 88);
                yield return new summer(38, 60, 125, 5, 50);
                yield return new summer(36, 44, 129, 45, 73);
                yield return new summer(31, 51, 80, 22, 56);
                yield return new summer(34, 47, 58, 6, 38);
                yield return new summer(32, 37, 58, 8, 27);
                yield return new summer(27, 30, 23, 8, 44);
                yield return new summer(29, 38, 48, 15, 41);
                yield return new summer(33, 45, 51, 8, 28);
                yield return new summer(33, 48, 125, 21, 67);
                yield return new summer(32, 43, 78, 10, 36);
                yield return new summer(32, 46, 203, 98, 47);
                yield return new summer(46, 41, 127, 41, 53);
                yield return new summer(36, 34, 19, 5, 24);
                yield return new summer(40, 16, 9, 4, 20);
                yield return new summer(45, 42, 57, 2, 18);
                yield return new summer(44, 33, 44, 4, 21);
                yield return new summer(25, 31, 51, 14, 24);
                yield return new summer(25, 49, 75, 9, 30);
                yield return new summer(24, 45, 80, 11, 36);
                yield return new summer(40, 35, 21, 6, 46);
                yield return new summer(38, 35, 12, 52, 31);
                yield return new summer(41, 33, 34, 9, 61);
                yield return new summer(42, 36, 32, 8, 70);
                yield return new summer(43, 28, 29, 4, 41);
                yield return new summer(39, 45, 43, 6, 32);
                yield return new summer(33, 46, 101, 68, 53);
                yield return new summer(29, 29, 14, 55, 36);
                yield return new summer(40, 55, 17, 13, 61);
                yield return new summer(31, 57, 132, 25, 87);
                yield return new summer(37, 82, 70, 20, 71);
                yield return new summer(58, 85, 189, 20, 121);
                yield return new summer(69, 86, 256, 28, 148);
                yield return new summer(64, 70, 68, 33, 58);
                yield return new summer(71, 52, 66, 23, 68);
                yield return new summer(44, 45, 34, 7, 65);
                yield return new summer(40, 19, 21, 4, 20);
                yield return new summer(26, 32, 34, 7, 29);
                yield return new summer(24, 31, 63, 9, 29);
                yield return new summer(29, 31, 36, 5, 17);
                yield return new summer(25, 34, 45, 5, 18);
                yield return new summer(30, 25, 24, 6, 18);
                yield return new summer(33, 34, 44, 5, 18);
                yield return new summer(36, 28, 37, 47, 31);
                yield return new summer(32, 37, 53, 24, 20);
                yield return new summer(36, 40, 41, 6, 23);
                yield return new summer(35, 37, 55, 11, 27);
                yield return new summer(33, 39, 48, 5, 24);
                yield return new summer(33, 25, 19, 11, 21);
                yield return new summer(26, 39, 17, 11, 39);
                yield return new summer(28, 54, 71, 21, 50);
                yield return new summer(50, 43, 40, 70, 61);
                yield return new summer(59, 78, 49, 18, 63);
                yield return new summer(29, 43, 53, 11, 43);
                yield return new summer(23, 43, 44, 10, 31);
                yield return new summer(27, 35, 41, 8, 27);
                yield return new summer(35, 25, 13, 5, 23);
                yield return new summer(35, 23, 11, 5, 21);
                yield return new summer(34, 38, 60, 5, 24);
                yield return new summer(30, 31, 29, 5, 18);
                yield return new summer(31, 40, 47, 5, 23);
                yield return new summer(35, 42, 70, 5, 25);
                yield return new summer(18, 36, 59, 13, 35);
                yield return new summer(34, 23, 20, 14, 20);
                yield return new summer(27, 45, 73, 7, 33);
                yield return new summer(29, 30, 44, 5, 20);
                yield return new summer(24, 33, 34, 6, 17);
                yield return new summer(27, 30, 48, 13, 17);
                yield return new summer(30, 26, 40, 16, 29);
                yield return new summer(32, 27, 38, 6, 21);
                yield return new summer(23, 25, 52, 11, 30);
                yield return new summer(31, 25, 34, 5, 24);
                yield return new summer(24, 27, 39, 11, 39);
                yield return new summer(25, 29, 45, 9, 28);
                yield return new summer(19, 24, 59, 6, 31);
                yield return new summer(14, 33, 94, 8, 38);
                yield return new summer(24, 27, 75, 9, 18);
                yield return new summer(28, 32, 44, 9, 22);
                yield return new summer(26, 27, 59, 15, 34);
                yield return new summer(23, 27, 70, 9, 30);
                yield return new summer(23, 32, 45, 14, 25);
                yield return new summer(33, 29, 97, 14, 30);
                yield return new summer(25, 21, 36, 8, 24);
                yield return new summer(27, 14, 25, 4, 26);
                yield return new summer(20, 16, 22, 4, 26);
                yield return new summer(42, 27, 45, 9, 42);
                yield return new summer(37, 28, 33, 8, 33);
                yield return new summer(57, 38, 31, 12, 39);
                yield return new summer(45, 48, 33, 98, 53);
                yield return new summer(63, 79, 204, 21, 86);
                yield return new summer(33, 19, 15, 14, 18);
                yield return new summer(46, 30, 30, 11, 38);
                yield return new summer(30, 36, 37, 7, 39);
                yield return new summer(32, 41, 84, 5, 43);
                yield return new summer(19, 46, 80, 16, 55);
                yield return new summer(20, 28, 75, 21, 53);
                yield return new summer(24, 29, 71, 15, 48);
                yield return new summer(39, 21, 22, 14, 26);
                yield return new summer(38, 13, 9, 3, 19);
                yield return new summer(40, 26, 45, 5, 39);
                yield return new summer(42, 42, 49, 13, 70);
                yield return new summer(41, 43, 68, 15, 83);
                yield return new summer(27, 52, 67, 13, 53);
                yield return new summer(29, 41, 64, 11, 45);
                yield return new summer(25, 29, 30, 11, 31);
                yield return new summer(34, 30, 42, 6, 19);
                yield return new summer(20, 46, 94, 17, 34);
                yield return new summer(24, 39, 121, 15, 28);
                yield return new summer(18, 31, 96, 11, 27);
                yield return new summer(20, 24, 49, 19, 30);
                yield return new summer(24, 25, 47, 5, 17);
                yield return new summer(25, 32, 41, 4, 18);
                yield return new summer(35, 30, 63, 11, 33);
                yield return new summer(24, 32, 73, 40, 50);
                yield return new summer(37, 32, 26, 88, 50);
                yield return new summer(59, 38, 25, 49, 81);
                yield return new summer(52, 60, 79, 13, 78);
                yield return new summer(34, 39, 47, 11, 41);
                yield return new summer(63, 37, 34, 13, 65);
                yield return new summer(74, 37, 14, 107, 63);
                yield return new summer(70, 34, 32, 7, 64);
                yield return new summer(32, 46, 85, 10, 33);
                yield return new summer(29, 49, 104, 16, 50);
                yield return new summer(32, 58, 71, 65, 69);
                yield return new summer(31, 50, 105, 30, 100);
                yield return new summer(46, 54, 41, 12, 42);
                yield return new summer(36, 44, 28, 12, 56);
                yield return new summer(32, 33, 15, 44, 27);
                yield return new summer(36, 36, 22, 50, 39);
                yield return new summer(19, 54, 35, 15, 51);
                yield return new summer(14, 53, 103, 20, 68);
                yield return new summer(25, 48, 98, 13, 48);
                yield return new summer(26, 62, 138, 21, 82);
                yield return new summer(28, 49, 62, 13, 59);
                yield return new summer(29, 51, 55, 7, 34);
                yield return new summer(34, 62, 48, 104, 51);
                yield return new summer(52, 40, 20, 21, 43);
                yield return new summer(37, 46, 57, 17, 53);
                yield return new summer(31, 49, 100, 13, 33);
                yield return new summer(32, 53, 101, 8, 35);
                yield return new summer(27, 47, 63, 4, 25);
                yield return new summer(27, 47, 73, 29, 26);
                yield return new summer(30, 37, 52, 18, 21);
                yield return new summer(35, 29, 15, 10, 29);
                yield return new summer(23, 47, 82, 11, 29);
                yield return new summer(31, 52, 83, 34, 29);
                yield return new summer(39, 37, 82, 9, 37);
                yield return new summer(40, 33, 32, 2, 25);
                yield return new summer(31, 35, 37, 4, 30);
                yield return new summer(26, 36, 24, 3, 21);
                yield return new summer(36, 27, 20, 5, 20);
                yield return new summer(36, 28, 13, 3, 19);
                yield return new summer(36, 35, 38, 6, 24);
                yield return new summer(27, 36, 49, 7, 33);
                yield return new summer(32, 30, 39, 5, 35);
                yield return new summer(34, 25, 32, 7, 36);
                yield return new summer(26, 31, 28, 7, 43);
                yield return new summer(27, 38, 51, 2, 18);
                yield return new summer(31, 48, 95, 12, 43);
                yield return new summer(41, 41, 89, 19, 41);
                yield return new summer(25, 48, 47, 14, 39);
                yield return new summer(27, 37, 46, 8, 20);
                yield return new summer(28, 36, 37, 5, 21);
                yield return new summer(38, 27, 17, 4, 21);
                yield return new summer(32, 29, 12, 23, 21);
                yield return new summer(33, 48, 32, 9, 23);
                yield return new summer(30, 49, 35, 20, 64);
                yield return new summer(15, 46, 73, 9, 39);
                yield return new summer(23, 44, 71, 10, 25);
                yield return new summer(33, 55, 60, 27, 23);
                yield return new summer(32, 50, 66, 11, 29);
                yield return new summer(28, 35, 25, 9, 28);
                yield return new summer(36, 35, 20, 4, 19);
                yield return new summer(16, 43, 88, 19, 53);
                yield return new summer(16, 46, 71, 5, 19);
                yield return new summer(39, 49, 82, 18, 47);
                yield return new summer(37, 25, 24, 10, 43);
                yield return new summer(30, 50, 70, 10, 27);
                yield return new summer(30, 47, 60, 6, 34);
                yield return new summer(28, 42, 77, 8, 46);
                yield return new summer(30, 52, 72, 15, 45);
                yield return new summer(28, 58, 101, 13, 60);
                yield return new summer(41, 41, 32, 86, 51);
                yield return new summer(34, 66, 73, 16, 68);
                yield return new summer(35, 41, 39, 7, 24);
                yield return new summer(42, 40, 63, 6, 27);
                yield return new summer(32, 54, 77, 6, 30);
                yield return new summer(23, 42, 70, 7, 40);
                yield return new summer(29, 33, 32, 8, 18);
                yield return new summer(35, 37, 32, 10, 39);
                yield return new summer(43, 55, 114, 20, 67);
                yield return new summer(64, 44, 28, 10, 47);
                yield return new summer(68, 52, 9, 48, 77);
                yield return new summer(46, 105, 103, 9, 62);
                yield return new summer(25, 36, 39, 6, 32);
                yield return new summer(31, 39, 31, 15, 27);
                yield return new summer(21, 33, 32, 12, 35);
                yield return new summer(20, 33, 29, 5, 32);
                yield return new summer(29, 41, 33, 8, 31);
                yield return new summer(34, 38, 41, 9, 27);
                yield return new summer(28, 32, 38, 11, 31);
                yield return new summer(27, 40, 53, 4, 47);
                yield return new summer(26, 30, 47, 3, 31);
                yield return new summer(21, 47, 67, 5, 37);
                yield return new summer(28, 50, 92, 11, 38);
                yield return new summer(33, 31, 33, 1, 18);
                yield return new summer(23, 31, 37, 1, 18);
                yield return new summer(22, 37, 97, 3, 19);
                yield return new summer(22, 38, 70, 11, 21);
                yield return new summer(20, 49, 101, 14, 30);
                yield return new summer(25, 37, 68, 5, 23);
                yield return new summer(32, 32, 38, 3, 20);
                yield return new summer(26, 30, 36, 4, 16);
                yield return new summer(27, 36, 24, 4, 24);
                yield return new summer(27, 29, 37, 3, 22);
                yield return new summer(25, 39, 90, 8, 31);
                yield return new summer(17, 27, 117, 3, 25);
                yield return new summer(12, 38, 116, 2, 19);
                yield return new summer(22, 32, 73, 19, 19);
                yield return new summer(14, 33, 86, 28, 38);
                yield return new summer(32, 19, 20, 3, 16);
                yield return new summer(27, 24, 39, 6, 20);
                yield return new summer(32, 33, 24, 13, 28);
                yield return new summer(38, 45, 90, 12, 40);
                yield return new summer(49, 47, 36, 130, 69);
                yield return new summer(40, 51, 52, 89, 75);
                yield return new summer(84, 53, 46, 13, 57);
                yield return new summer(80, 40, 13, 14, 53);
                yield return new summer(67, 49, 55, 10, 64);
                yield return new summer(53, 36, 56, 10, 39);
                yield return new summer(23, 23, 30, 4, 23);
                yield return new summer(26, 33, 50, 8, 33);
                yield return new summer(14, 27, 112, 8, 35);
                yield return new summer(28, 23, 44, 6, 22);
                yield return new summer(25, 31, 28, 5, 27);
                yield return new summer(19, 34, 72, 5, 37);
                yield return new summer(18, 33, 68, 13, 41);
                yield return new summer(17, 33, 86, 7, 23);
                yield return new summer(17, 52, 135, 3, 27);
                yield return new summer(33, 47, 78, 2, 33);
                yield return new summer(28, 37, 17, 10, 40);
                yield return new summer(8, 53, 239, 16, 70);
                yield return new summer(18, 56, 173, 24, 105);
                yield return new summer(36, 53, 189, 17, 60);
                yield return new summer(28, 38, 49, 8, 30);
                yield return new summer(31, 38, 32, 9, 151);
                yield return new summer(28, 39, 49, 6, 43);
                yield return new summer(23, 39, 65, 4, 160);
                yield return new summer(38, 19, 12, 2, 185);
                yield return new summer(21, 44, 58, 5, 67);
                yield return new summer(26, 45, 101, 10, 38);
                yield return new summer(29, 41, 70, 15, 74);
                yield return new summer(35, 60, 103, 12, 82);
                yield return new summer(27, 41, 77, 2, 90);
                yield return new summer(27, 33, 22, 15, 37);
                yield return new summer(22, 37, 25, 9, 42);
                yield return new summer(37, 50, 114, 5, 23);
                yield return new summer(39, 24, 20, 2, 20);
                yield return new summer(28, 35, 27, 6, 28);
                yield return new summer(44, 46, 167, 17, 53);
                yield return new summer(58, 59, 151, 14, 69);
                yield return new summer(40, 47, 44, 27, 66);
                yield return new summer(34, 34, 34, 4, 51);
                yield return new summer(34, 18, 12, 1, 14);
                yield return new summer(26, 31, 33, 4, 28);
                yield return new summer(24, 34, 77, 6, 20);
                yield return new summer(25, 43, 60, 5, 26);
                yield return new summer(29, 41, 76, 8, 56);
                yield return new summer(18, 44, 40, 7, 44);
                yield return new summer(31, 30, 37, 5, 31);
                yield return new summer(32, 34, 39, 6, 35);
                yield return new summer(37, 40, 47, 6, 29);
                yield return new summer(25, 37, 58, 7, 29);
                yield return new summer(42, 36, 122, 84, 61);
                yield return new summer(32, 36, 34, 6, 52);
                yield return new summer(33, 31, 30, 4, 50);
                yield return new summer(39, 43, 30, 5, 53);
                yield return new summer(26, 40, 51, 5, 60);
                yield return new summer(32, 29, 31, 4, 27);
                yield return new summer(23, 29, 29, 4, 28);
                yield return new summer(32, 36, 24, 5, 27);
                yield return new summer(38, 43, 77, 61, 34);
                yield return new summer(36, 38, 19, 3, 29);
                yield return new summer(30, 26, 22, 7, 45);
                yield return new summer(35, 37, 36, 129, 40);
                yield return new summer(33, 56, 124, 150, 63);
                yield return new summer(39, 66, 139, 70, 103);
                yield return new summer(53, 27, 28, 83, 41);
                yield return new summer(44, 9, 4, 1, 42);
                yield return new summer(43, 20, 20, 5, 50);
                yield return new summer(36, 24, 20, 9, 38);
                yield return new summer(39, 40, 32, 133, 173);
                yield return new summer(53, 30, 26, 35, 45);
                yield return new summer(35, 51, 42, 55, 36);
                yield return new summer(30, 26, 24, 5, 31);
                yield return new summer(33, 25, 13, 7, 39);
                yield return new summer(23, 32, 39, 9, 30);
                yield return new summer(36, 35, 42, 75, 41);
                yield return new summer(27, 34, 63, 6, 33);
                yield return new summer(14, 48, 95, 12, 32);
                yield return new summer(25, 36, 50, 7, 26);
                yield return new summer(25, 19, 18, 2, 24);
                yield return new summer(26, 36, 31, 5, 22);
                yield return new summer(27, 38, 51, 59, 38);
                yield return new summer(35, 45, 78, 13, 56);
                yield return new summer(28, 47, 99, 10, 50);
                yield return new summer(26, 37, 48, 6, 34);
                yield return new summer(16, 34, 69, 29, 43);
                yield return new summer(14, 25, 27, 7, 19);
                yield return new summer(32, 18, 12, 14, 25);
                yield return new summer(22, 26, 37, 6, 23);
                yield return new summer(21, 36, 58, 8, 29);
                yield return new summer(32, 36, 35, 32, 36);
                yield return new summer(37, 19, 21, 3, 13);
                yield return new summer(29, 19, 20, 4, 34);
                yield return new summer(29, 28, 20, 3, 32);
                yield return new summer(28, 19, 11, 3, 18);
                yield return new summer(31, 32, 62, 4, 28);
                yield return new summer(19, 37, 71, 5, 38);
                yield return new summer(17, 40, 70, 8, 35);
                yield return new summer(8, 32, 73, 10, 34);
                yield return new summer(30, 35, 55, 6, 39);
                yield return new summer(28, 19, 17, 4, 24);
                yield return new summer(25, 20, 16, 4, 18);
                yield return new summer(20, 27, 54, 5, 29);
                yield return new summer(30, 44, 50, 47, 52);
                yield return new summer(57, 81, 136, 40, 91);
                yield return new summer(9, 34, 70, 148, 67);
                yield return new summer(24, 38, 61, 242, 103);
                yield return new summer(43, 42, 36, 14, 59);
                yield return new summer(26, 37, 19, 5, 38);
                yield return new summer(22, 32, 27, 7, 29);
                yield return new summer(16, 29, 48, 14, 28);
                yield return new summer(18, 31, 65, 11, 22);
                yield return new summer(20, 30, 35, 3, 29);
                yield return new summer(28, 23, 21, 6, 35);
                yield return new summer(42, 46, 67, 27, 42);
                yield return new summer(48, 36, 30, 20, 36);
                yield return new summer(42, 39, 37, 36, 35);
                yield return new summer(28, 35, 29, 15, 41);
                yield return new summer(46, 46, 47, 10, 61);
                yield return new summer(28, 42, 55, 3, 35);
                yield return new summer(22, 24, 28, 4, 27);
                yield return new summer(16, 31, 64, 7, 27);
                yield return new summer(22, 23, 17, 2, 17);
                yield return new summer(18, 27, 62, 4, 27);
                yield return new summer(35, 36, 171, 15, 65);
                yield return new summer(19, 31, 52, 3, 29);
                yield return new summer(17, 29, 86, 2, 21);
                yield return new summer(30, 28, 25, 2, 19);
                yield return new summer(32, 23, 14, 11, 20);
                yield return new summer(33, 44, 91, 16, 40);
                yield return new summer(26, 36, 35, 18, 22);
                yield return new summer(30, 31, 20, 5, 20);
                yield return new summer(23, 47, 133, 10, 44);
                yield return new summer(26, 47, 45, 11, 32);
                yield return new summer(38, 50, 76, 34, 32);
                yield return new summer(43, 23, 18, 5, 21);
                yield return new summer(39, 14, 12, 3, 21);
                yield return new summer(38, 18, 10, 2, 25);
                yield return new summer(34, 18, 7, 1, 14);
                yield return new summer(38, 25, 22, 3, 15);
                yield return new summer(36, 49, 44, 4, 22);
                yield return new summer(35, 54, 46, 8, 23);
                yield return new summer(40, 29, 36, 6, 21);
                yield return new summer(47, 19, 14, 1, 26);
                yield return new summer(41, 30, 13, 2, 29);
                yield return new summer(39, 47, 10, 155, 42);
                yield return new summer(26, 42, 119, 12, 47);
                yield return new summer(19, 63, 221, 16, 84);
                yield return new summer(31, 49, 45, 16, 46);
                yield return new summer(27, 45, 94, 9, 36);
                yield return new summer(34, 41, 55, 16, 29);
                yield return new summer(37, 38, 22, 7, 23);
                yield return new summer(40, 41, 18, 4, 28);
                yield return new summer(30, 44, 57, 9, 36);
                yield return new summer(33, 42, 76, 13, 38);
                yield return new summer(41, 39, 45, 51, 37);
                yield return new summer(43, 34, 17, 4, 31);
                yield return new summer(45, 27, 21, 3, 28);
                yield return new summer(39, 24, 15, 6, 26);
                yield return new summer(44, 50, 36, 2, 30);
                yield return new summer(41, 46, 39, 3, 36);
                yield return new summer(35, 50, 62, 3, 33);
                yield return new summer(36, 62, 120, 4, 20);
                yield return new summer(31, 30, 25, 2, 29);
                yield return new summer(26, 62, 36, 15, 58);
                yield return new summer(35, 41, 39, 6, 47);
                yield return new summer(33, 27, 7, 3, 17);
                yield return new summer(34, 34, 28, 3, 32);
                yield return new summer(31, 40, 27, 8, 53);
                yield return new summer(30, 43, 27, 6, 71);
                yield return new summer(33, 34, 34, 44, 52);
                yield return new summer(57, 33, 37, 19, 72);
                yield return new summer(59, 42, 20, 53, 35);
                yield return new summer(51, 36, 10, 87, 27);
                yield return new summer(42, 61, 89, 107, 72);
                yield return new summer(41, 47, 55, 10, 50);
                yield return new summer(27, 37, 62, 10, 68);
                yield return new summer(35, 25, 22, 5, 27);
                yield return new summer(37, 36, 30, 9, 48);
                yield return new summer(41, 26, 17, 1, 20);
                yield return new summer(39, 23, 22, 0, 18);
                yield return new summer(33, 13, 12, 1, 14);
                yield return new summer(32, 25, 38, 4, 25);
                yield return new summer(28, 35, 35, 1, 21);
                yield return new summer(27, 32, 31, 3, 35);
                yield return new summer(37, 40, 29, 39, 59);
                yield return new summer(35, 24, 12, 4, 42);
                yield return new summer(38, 34, 12, 68, 56);
                yield return new summer(31, 35, 35, 11, 52);
                yield return new summer(35, 22, 20, 3, 9);
                yield return new summer(31, 32, 35, 7, 25);
                yield return new summer(24, 35, 62, 16, 30);
                yield return new summer(30, 27, 18, 85, 28);
                yield return new summer(26, 43, 33, 12, 43);
                yield return new summer(38, 42, 66, 2, 20);
                yield return new summer(38, 45, 59, 4, 28);
                yield return new summer(33, 26, 60, 4, 26);
                yield return new summer(30, 38, 81, 3, 19);
                yield return new summer(34, 24, 25, 5, 17);
                yield return new summer(23, 36, 53, 4, 22);
                yield return new summer(18, 33, 22, 17, 22);
                yield return new summer(33, 17, 7, 2, 19);
                yield return new summer(35, 29, 23, 2, 31);
                yield return new summer(43, 34, 23, 9, 30);
                yield return new summer(27, 32, 54, 12, 31);
                yield return new summer(17, 28, 88, 7, 35);
                yield return new summer(23, 45, 86, 5, 37);
                yield return new summer(33, 40, 31, 11, 51);
                yield return new summer(45, 23, 11, 5, 37);
                yield return new summer(24, 43, 85, 20, 28);
                yield return new summer(27, 24, 31, 10, 29);
                yield return new summer(18, 35, 80, 5, 32);
                yield return new summer(25, 30, 50, 7, 30);
                yield return new summer(25, 26, 47, 5, 30);
                yield return new summer(25, 22, 48, 3, 22);
                yield return new summer(34, 25, 33, 9, 25);
                yield return new summer(29, 24, 20, 5, 32);
                yield return new summer(27, 35, 53, 8, 60);
                yield return new summer(22, 15, 15, 3, 24);
                yield return new summer(33, 15, 14, 2, 56);
                yield return new summer(27, 25, 31, 78, 29);
                yield return new summer(24, 29, 43, 14, 38);
                yield return new summer(22, 39, 54, 10, 43);
                yield return new summer(26, 31, 39, 4, 34);
                yield return new summer(23, 37, 68, 12, 51);
                yield return new summer(30, 25, 14, 8, 34);
                yield return new summer(31, 24, 20, 8, 27);
                yield return new summer(29, 28, 50, 3, 39);
                yield return new summer(33, 39, 104, 4, 64);
                yield return new summer(23, 38, 74, 3, 50);
                yield return new summer(24, 41, 62, 5, 40);
                yield return new summer(21, 38, 80, 5, 48);
                yield return new summer(29, 29, 49, 3, 27);
                yield return new summer(18, 31, 20, 5, 27);
                yield return new summer(16, 33, 120, 8, 37);
                yield return new summer(28, 26, 50, 6, 32);
                yield return new summer(27, 38, 44, 5, 35);
                yield return new summer(26, 30, 61, 5, 31);
                yield return new summer(26, 37, 53, 4, 55);
                yield return new summer(32, 31, 57, 5, 26);
                yield return new summer(28, 32, 26, 6, 28);
                yield return new summer(26, 30, 57, 5, 35);
                yield return new summer(22, 36, 86, 4, 24);
                yield return new summer(25, 39, 74, 4, 25);
                yield return new summer(24, 34, 88, 3, 29);
                yield return new summer(23, 30, 41, 3, 26);
            }
        }
    }
}
