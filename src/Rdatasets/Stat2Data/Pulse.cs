// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Pulse
    /// </summary>

    public class Pulse
    {
        public readonly int Active;
        public readonly int Rest;
        public readonly int Smoke;
        public readonly int Gender;
        public readonly int Exercise;
        public readonly int Hgt;
        public readonly int Wgt;

        public Pulse(int Active, int Rest, int Smoke, int Gender, int Exercise, int Hgt, int Wgt)
        {
            this.Active = Active;
            this.Rest = Rest;
            this.Smoke = Smoke;
            this.Gender = Gender;
            this.Exercise = Exercise;
            this.Hgt = Hgt;
            this.Wgt = Wgt;
        }

        public static IEnumerable<Pulse> Data
        {
            get
            {
                yield return new Pulse(97, 78, 0, 1, 1, 63, 119);
                yield return new Pulse(82, 68, 1, 0, 3, 70, 225);
                yield return new Pulse(88, 62, 0, 0, 3, 72, 175);
                yield return new Pulse(106, 74, 0, 0, 3, 72, 170);
                yield return new Pulse(78, 63, 0, 1, 3, 67, 125);
                yield return new Pulse(109, 65, 0, 0, 3, 74, 188);
                yield return new Pulse(66, 43, 0, 1, 3, 67, 140);
                yield return new Pulse(68, 65, 0, 0, 3, 70, 200);
                yield return new Pulse(100, 63, 0, 0, 1, 70, 165);
                yield return new Pulse(70, 59, 0, 1, 2, 65, 115);
                yield return new Pulse(98, 57, 0, 0, 3, 72, 175);
                yield return new Pulse(140, 65, 0, 1, 3, 66, 135);
                yield return new Pulse(105, 85, 0, 1, 1, 64, 140);
                yield return new Pulse(84, 64, 0, 0, 3, 75, 207);
                yield return new Pulse(134, 70, 0, 1, 2, 68, 150);
                yield return new Pulse(117, 66, 0, 1, 2, 65, 120);
                yield return new Pulse(100, 72, 0, 0, 3, 74, 200);
                yield return new Pulse(108, 72, 0, 0, 3, 67, 170);
                yield return new Pulse(76, 75, 0, 0, 2, 70, 155);
                yield return new Pulse(86, 68, 1, 0, 2, 73, 195);
                yield return new Pulse(110, 72, 0, 1, 3, 66, 130);
                yield return new Pulse(65, 61, 0, 1, 3, 66, 145);
                yield return new Pulse(85, 74, 0, 1, 1, 68, 135);
                yield return new Pulse(80, 72, 0, 0, 1, 70, 135);
                yield return new Pulse(87, 72, 1, 0, 2, 70, 173);
                yield return new Pulse(133, 97, 0, 1, 1, 65, 130);
                yield return new Pulse(125, 64, 0, 1, 3, 70, 172);
                yield return new Pulse(61, 53, 0, 0, 3, 70, 175);
                yield return new Pulse(117, 78, 0, 0, 2, 74, 160);
                yield return new Pulse(90, 85, 0, 1, 2, 65, 120);
                yield return new Pulse(110, 80, 0, 1, 1, 68, 145);
                yield return new Pulse(68, 58, 0, 0, 3, 74, 175);
                yield return new Pulse(102, 77, 1, 0, 2, 72, 200);
                yield return new Pulse(67, 53, 0, 0, 3, 68, 158);
                yield return new Pulse(112, 75, 0, 1, 2, 64, 125);
                yield return new Pulse(86, 51, 0, 0, 3, 74, 195);
                yield return new Pulse(85, 74, 0, 1, 3, 64, 120);
                yield return new Pulse(66, 59, 0, 0, 3, 69, 175);
                yield return new Pulse(73, 47, 0, 1, 3, 62, 145);
                yield return new Pulse(85, 72, 0, 0, 1, 72, 140);
                yield return new Pulse(110, 78, 0, 0, 1, 69, 165);
                yield return new Pulse(97, 72, 0, 1, 1, 64, 135);
                yield return new Pulse(93, 70, 0, 1, 1, 67, 115);
                yield return new Pulse(86, 63, 0, 1, 3, 65, 145);
                yield return new Pulse(80, 60, 0, 1, 3, 60, 106);
                yield return new Pulse(96, 80, 0, 1, 2, 67, 140);
                yield return new Pulse(74, 67, 0, 0, 3, 68, 150);
                yield return new Pulse(124, 64, 0, 0, 2, 73, 260);
                yield return new Pulse(78, 65, 0, 0, 1, 72, 150);
                yield return new Pulse(93, 72, 0, 0, 2, 71, 160);
                yield return new Pulse(80, 65, 0, 0, 2, 75, 245);
                yield return new Pulse(80, 67, 1, 1, 2, 65, 133);
                yield return new Pulse(92, 69, 0, 0, 3, 68, 210);
                yield return new Pulse(69, 60, 0, 0, 3, 72, 205);
                yield return new Pulse(82, 62, 0, 0, 3, 74, 194);
                yield return new Pulse(88, 67, 0, 1, 1, 64, 135);
                yield return new Pulse(74, 71, 0, 0, 1, 70, 190);
                yield return new Pulse(74, 62, 0, 0, 2, 71, 200);
                yield return new Pulse(75, 54, 0, 0, 3, 72, 149);
                yield return new Pulse(120, 66, 0, 1, 2, 67, 150);
                yield return new Pulse(105, 77, 0, 1, 3, 67, 138);
                yield return new Pulse(104, 82, 0, 1, 2, 65, 120);
                yield return new Pulse(99, 78, 1, 0, 3, 71, 165);
                yield return new Pulse(113, 64, 0, 0, 2, 70, 160);
                yield return new Pulse(67, 58, 0, 1, 3, 68, 135);
                yield return new Pulse(125, 80, 1, 1, 3, 65, 125);
                yield return new Pulse(133, 92, 1, 0, 1, 69, 185);
                yield return new Pulse(98, 67, 0, 1, 2, 64, 140);
                yield return new Pulse(80, 64, 0, 1, 3, 71, 135);
                yield return new Pulse(91, 65, 1, 0, 2, 67, 150);
                yield return new Pulse(76, 63, 0, 1, 3, 63, 135);
                yield return new Pulse(78, 52, 0, 0, 3, 75, 215);
                yield return new Pulse(94, 74, 0, 1, 2, 64, 160);
                yield return new Pulse(150, 64, 0, 0, 2, 71, 170);
                yield return new Pulse(92, 66, 0, 0, 3, 77, 180);
                yield return new Pulse(96, 67, 1, 1, 2, 64, 165);
                yield return new Pulse(68, 58, 0, 1, 3, 67, 140);
                yield return new Pulse(82, 62, 0, 1, 3, 62, 145);
                yield return new Pulse(102, 77, 0, 1, 1, 63, 124);
                yield return new Pulse(69, 63, 0, 0, 2, 69, 140);
                yield return new Pulse(65, 69, 0, 0, 3, 71, 165);
                yield return new Pulse(84, 64, 0, 0, 3, 72, 185);
                yield return new Pulse(86, 60, 1, 1, 1, 68, 150);
                yield return new Pulse(84, 61, 0, 1, 2, 65, 115);
                yield return new Pulse(116, 70, 1, 1, 2, 70, 150);
                yield return new Pulse(88, 71, 0, 1, 1, 61, 110);
                yield return new Pulse(65, 63, 0, 1, 3, 64, 120);
                yield return new Pulse(101, 75, 0, 0, 1, 64, 110);
                yield return new Pulse(89, 71, 0, 1, 3, 61, 150);
                yield return new Pulse(128, 64, 0, 1, 3, 67, 133);
                yield return new Pulse(68, 56, 0, 1, 3, 66, 160);
                yield return new Pulse(90, 72, 0, 0, 2, 67, 130);
                yield return new Pulse(80, 65, 0, 0, 3, 69, 150);
                yield return new Pulse(80, 63, 0, 0, 1, 70, 135);
                yield return new Pulse(98, 79, 0, 0, 2, 74, 180);
                yield return new Pulse(90, 61, 0, 0, 3, 71, 183);
                yield return new Pulse(82, 68, 0, 1, 1, 64, 120);
                yield return new Pulse(97, 61, 0, 1, 3, 64, 113);
                yield return new Pulse(90, 67, 1, 0, 2, 74, 180);
                yield return new Pulse(98, 67, 0, 1, 2, 63, 150);
                yield return new Pulse(88, 54, 0, 0, 3, 67, 176);
                yield return new Pulse(94, 69, 0, 0, 2, 72, 195);
                yield return new Pulse(92, 58, 1, 0, 2, 65, 165);
                yield return new Pulse(96, 76, 0, 1, 2, 67, 155);
                yield return new Pulse(80, 68, 0, 1, 2, 64, 135);
                yield return new Pulse(66, 55, 0, 1, 3, 65, 125);
                yield return new Pulse(110, 83, 1, 1, 1, 63, 114);
                yield return new Pulse(87, 80, 0, 1, 2, 69, 141);
                yield return new Pulse(88, 56, 0, 1, 3, 68, 172);
                yield return new Pulse(94, 83, 0, 0, 1, 66, 110);
                yield return new Pulse(96, 74, 0, 1, 2, 67, 123);
                yield return new Pulse(89, 78, 0, 0, 3, 67, 145);
                yield return new Pulse(74, 61, 0, 0, 3, 75, 180);
                yield return new Pulse(111, 75, 0, 0, 2, 71, 180);
                yield return new Pulse(81, 72, 0, 1, 3, 70, 135);
                yield return new Pulse(98, 63, 1, 0, 3, 78, 238);
                yield return new Pulse(99, 78, 0, 1, 2, 63, 115);
                yield return new Pulse(65, 54, 0, 0, 3, 74, 190);
                yield return new Pulse(95, 80, 0, 0, 3, 72, 175);
                yield return new Pulse(127, 69, 0, 1, 2, 64, 135);
                yield return new Pulse(76, 50, 0, 0, 3, 71, 208);
                yield return new Pulse(102, 69, 0, 1, 2, 63, 110);
                yield return new Pulse(88, 67, 0, 0, 2, 68, 157);
                yield return new Pulse(125, 80, 0, 1, 1, 61, 110);
                yield return new Pulse(72, 63, 1, 0, 2, 72, 210);
                yield return new Pulse(76, 68, 0, 1, 2, 62, 137);
                yield return new Pulse(112, 64, 0, 0, 3, 70, 192);
                yield return new Pulse(69, 48, 0, 1, 3, 67, 140);
                yield return new Pulse(101, 82, 0, 1, 3, 64, 125);
                yield return new Pulse(72, 64, 0, 1, 3, 63, 145);
                yield return new Pulse(112, 79, 1, 1, 1, 69, 130);
                yield return new Pulse(81, 61, 0, 0, 3, 68, 160);
                yield return new Pulse(90, 73, 0, 1, 2, 67, 140);
                yield return new Pulse(96, 75, 0, 1, 1, 66, 135);
                yield return new Pulse(66, 59, 0, 0, 2, 70, 175);
                yield return new Pulse(114, 74, 0, 1, 2, 67, 150);
                yield return new Pulse(71, 66, 0, 1, 2, 62, 102);
                yield return new Pulse(75, 60, 0, 0, 2, 70, 160);
                yield return new Pulse(102, 76, 0, 0, 3, 70, 160);
                yield return new Pulse(138, 92, 0, 1, 1, 64, 120);
                yield return new Pulse(85, 71, 0, 1, 3, 68, 130);
                yield return new Pulse(80, 72, 0, 0, 3, 70, 180);
                yield return new Pulse(107, 68, 0, 0, 2, 67, 155);
                yield return new Pulse(119, 81, 0, 1, 2, 61, 130);
                yield return new Pulse(98, 68, 0, 0, 3, 72, 195);
                yield return new Pulse(95, 58, 0, 0, 2, 74, 225);
                yield return new Pulse(95, 63, 0, 1, 2, 69, 125);
                yield return new Pulse(76, 84, 0, 0, 1, 71, 155);
                yield return new Pulse(96, 74, 0, 1, 2, 63, 116);
                yield return new Pulse(102, 78, 0, 0, 2, 71, 154);
                yield return new Pulse(82, 68, 0, 0, 3, 72, 195);
                yield return new Pulse(99, 66, 0, 1, 2, 65, 145);
                yield return new Pulse(80, 70, 0, 0, 2, 70, 175);
                yield return new Pulse(83, 72, 0, 0, 2, 73, 175);
                yield return new Pulse(102, 84, 0, 1, 2, 64, 150);
                yield return new Pulse(102, 77, 0, 0, 2, 72, 187);
                yield return new Pulse(106, 78, 0, 1, 2, 66, 154);
                yield return new Pulse(79, 63, 0, 1, 3, 68, 140);
                yield return new Pulse(80, 60, 0, 1, 3, 61, 115);
                yield return new Pulse(79, 68, 1, 0, 2, 69, 163);
                yield return new Pulse(110, 80, 0, 1, 2, 61, 125);
                yield return new Pulse(144, 106, 0, 1, 1, 62, 140);
                yield return new Pulse(80, 73, 0, 0, 2, 70, 155);
                yield return new Pulse(97, 73, 0, 1, 1, 67, 115);
                yield return new Pulse(60, 55, 0, 0, 3, 72, 160);
                yield return new Pulse(80, 62, 0, 0, 3, 72, 193);
                yield return new Pulse(108, 63, 0, 0, 3, 71, 165);
                yield return new Pulse(107, 75, 0, 1, 2, 67, 150);
                yield return new Pulse(51, 54, 0, 0, 3, 74, 150);
                yield return new Pulse(68, 72, 0, 0, 1, 70, 205);
                yield return new Pulse(80, 63, 0, 0, 3, 71, 183);
                yield return new Pulse(80, 74, 0, 1, 2, 68, 139);
                yield return new Pulse(60, 58, 0, 0, 3, 70, 168);
                yield return new Pulse(64, 60, 0, 0, 3, 71, 165);
                yield return new Pulse(87, 70, 0, 0, 2, 73, 210);
                yield return new Pulse(110, 95, 1, 0, 1, 69, 180);
                yield return new Pulse(110, 88, 0, 1, 2, 66, 145);
                yield return new Pulse(82, 70, 1, 0, 1, 70, 185);
                yield return new Pulse(154, 82, 0, 0, 1, 71, 250);
                yield return new Pulse(139, 72, 1, 1, 1, 63, 112);
                yield return new Pulse(86, 58, 0, 0, 3, 70, 185);
                yield return new Pulse(95, 68, 0, 1, 3, 64, 145);
                yield return new Pulse(112, 90, 0, 1, 2, 61, 122);
                yield return new Pulse(120, 81, 0, 0, 2, 71, 150);
                yield return new Pulse(79, 69, 0, 0, 3, 71, 148);
                yield return new Pulse(64, 48, 0, 0, 3, 69, 170);
                yield return new Pulse(84, 60, 0, 0, 2, 72, 177);
                yield return new Pulse(65, 75, 1, 1, 2, 65, 145);
                yield return new Pulse(60, 54, 0, 0, 3, 73, 194);
                yield return new Pulse(79, 58, 0, 1, 3, 67, 150);
                yield return new Pulse(79, 53, 0, 0, 2, 72, 172);
                yield return new Pulse(70, 55, 0, 1, 3, 68, 150);
                yield return new Pulse(75, 71, 0, 0, 2, 70, 175);
                yield return new Pulse(107, 65, 0, 1, 2, 65, 128);
                yield return new Pulse(78, 68, 1, 0, 2, 72, 165);
                yield return new Pulse(74, 62, 0, 0, 2, 73, 180);
                yield return new Pulse(80, 68, 0, 0, 3, 69, 160);
                yield return new Pulse(121, 94, 1, 0, 1, 74, 250);
                yield return new Pulse(120, 58, 0, 0, 3, 71, 187);
                yield return new Pulse(96, 74, 0, 1, 2, 70, 151);
                yield return new Pulse(75, 73, 0, 0, 1, 71, 152);
                yield return new Pulse(106, 78, 0, 1, 2, 61, 122);
                yield return new Pulse(88, 63, 0, 1, 2, 69, 145);
                yield return new Pulse(91, 58, 0, 1, 2, 68, 143);
                yield return new Pulse(98, 70, 0, 0, 3, 70, 245);
                yield return new Pulse(63, 53, 0, 1, 3, 65, 107);
                yield return new Pulse(95, 63, 0, 0, 2, 73, 192);
                yield return new Pulse(85, 67, 0, 1, 2, 70, 165);
                yield return new Pulse(83, 55, 0, 0, 3, 70, 190);
                yield return new Pulse(92, 68, 0, 1, 3, 67, 135);
                yield return new Pulse(81, 64, 0, 1, 1, 66, 145);
                yield return new Pulse(89, 60, 0, 1, 2, 62, 136);
                yield return new Pulse(103, 73, 1, 0, 1, 71, 220);
                yield return new Pulse(110, 74, 0, 1, 2, 66, 130);
                yield return new Pulse(78, 66, 0, 0, 2, 70, 185);
                yield return new Pulse(122, 80, 0, 0, 3, 67, 150);
                yield return new Pulse(122, 98, 0, 1, 1, 62, 105);
                yield return new Pulse(71, 57, 0, 1, 3, 65, 145);
                yield return new Pulse(65, 61, 0, 0, 3, 71, 175);
                yield return new Pulse(92, 70, 0, 0, 1, 76, 260);
                yield return new Pulse(93, 71, 0, 1, 2, 67, 175);
                yield return new Pulse(88, 57, 0, 0, 3, 76, 230);
                yield return new Pulse(90, 73, 0, 0, 3, 70, 205);
                yield return new Pulse(56, 52, 0, 1, 3, 66, 145);
                yield return new Pulse(95, 70, 0, 1, 2, 66, 150);
                yield return new Pulse(83, 64, 0, 0, 3, 68, 135);
                yield return new Pulse(97, 55, 0, 0, 3, 67, 175);
                yield return new Pulse(105, 85, 0, 1, 2, 64, 150);
                yield return new Pulse(82, 74, 0, 1, 3, 66, 124);
                yield return new Pulse(102, 81, 0, 0, 2, 69, 172);
                yield return new Pulse(87, 67, 0, 0, 2, 68, 170);
                yield return new Pulse(81, 62, 0, 0, 3, 68, 151);
            }
        }
    }
}
