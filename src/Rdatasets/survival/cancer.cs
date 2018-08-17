// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// NCCTG Lung Cancer Data
    /// </summary>

    public class cancer
    {
        public readonly string inst;
        public readonly int time;
        public readonly int status;
        public readonly int age;
        public readonly int sex;
        public readonly string ph_ecog;
        public readonly string ph_karno;
        public readonly string pat_karno;
        public readonly string meal_cal;
        public readonly string wt_loss;

        public cancer(string inst, int time, int status, int age, int sex, string ph_ecog, string ph_karno, string pat_karno, string meal_cal, string wt_loss)
        {
            this.inst = inst;
            this.time = time;
            this.status = status;
            this.age = age;
            this.sex = sex;
            this.ph_ecog = ph_ecog;
            this.ph_karno = ph_karno;
            this.pat_karno = pat_karno;
            this.meal_cal = meal_cal;
            this.wt_loss = wt_loss;
        }

        public static IEnumerable<cancer> Data
        {
            get
            {
                yield return new cancer("3", 306, 2, 74, 1, "1", "90", "100", "1175", null);
                yield return new cancer("3", 455, 2, 68, 1, "0", "90", "90", "1225", "15");
                yield return new cancer("3", 1010, 1, 56, 1, "0", "90", "90", null, "15");
                yield return new cancer("5", 210, 2, 57, 1, "1", "90", "60", "1150", "11");
                yield return new cancer("1", 883, 2, 60, 1, "0", "100", "90", null, "0");
                yield return new cancer("12", 1022, 1, 74, 1, "1", "50", "80", "513", "0");
                yield return new cancer("7", 310, 2, 68, 2, "2", "70", "60", "384", "10");
                yield return new cancer("11", 361, 2, 71, 2, "2", "60", "80", "538", "1");
                yield return new cancer("1", 218, 2, 53, 1, "1", "70", "80", "825", "16");
                yield return new cancer("7", 166, 2, 61, 1, "2", "70", "70", "271", "34");
                yield return new cancer("6", 170, 2, 57, 1, "1", "80", "80", "1025", "27");
                yield return new cancer("16", 654, 2, 68, 2, "2", "70", "70", null, "23");
                yield return new cancer("11", 728, 2, 68, 2, "1", "90", "90", null, "5");
                yield return new cancer("21", 71, 2, 60, 1, null, "60", "70", "1225", "32");
                yield return new cancer("12", 567, 2, 57, 1, "1", "80", "70", "2600", "60");
                yield return new cancer("1", 144, 2, 67, 1, "1", "80", "90", null, "15");
                yield return new cancer("22", 613, 2, 70, 1, "1", "90", "100", "1150", "-5");
                yield return new cancer("16", 707, 2, 63, 1, "2", "50", "70", "1025", "22");
                yield return new cancer("1", 61, 2, 56, 2, "2", "60", "60", "238", "10");
                yield return new cancer("21", 88, 2, 57, 1, "1", "90", "80", "1175", null);
                yield return new cancer("11", 301, 2, 67, 1, "1", "80", "80", "1025", "17");
                yield return new cancer("6", 81, 2, 49, 2, "0", "100", "70", "1175", "-8");
                yield return new cancer("11", 624, 2, 50, 1, "1", "70", "80", null, "16");
                yield return new cancer("15", 371, 2, 58, 1, "0", "90", "100", "975", "13");
                yield return new cancer("12", 394, 2, 72, 1, "0", "90", "80", null, "0");
                yield return new cancer("12", 520, 2, 70, 2, "1", "90", "80", "825", "6");
                yield return new cancer("4", 574, 2, 60, 1, "0", "100", "100", "1025", "-13");
                yield return new cancer("13", 118, 2, 70, 1, "3", "60", "70", "1075", "20");
                yield return new cancer("13", 390, 2, 53, 1, "1", "80", "70", "875", "-7");
                yield return new cancer("1", 12, 2, 74, 1, "2", "70", "50", "305", "20");
                yield return new cancer("12", 473, 2, 69, 2, "1", "90", "90", "1025", "-1");
                yield return new cancer("1", 26, 2, 73, 1, "2", "60", "70", "388", "20");
                yield return new cancer("7", 533, 2, 48, 1, "2", "60", "80", null, "-11");
                yield return new cancer("16", 107, 2, 60, 2, "2", "50", "60", "925", "-15");
                yield return new cancer("12", 53, 2, 61, 1, "2", "70", "100", "1075", "10");
                yield return new cancer("1", 122, 2, 62, 2, "2", "50", "50", "1025", null);
                yield return new cancer("22", 814, 2, 65, 1, "2", "70", "60", "513", "28");
                yield return new cancer("15", 965, 1, 66, 2, "1", "70", "90", "875", "4");
                yield return new cancer("1", 93, 2, 74, 1, "2", "50", "40", "1225", "24");
                yield return new cancer("1", 731, 2, 64, 2, "1", "80", "100", "1175", "15");
                yield return new cancer("5", 460, 2, 70, 1, "1", "80", "60", "975", "10");
                yield return new cancer("11", 153, 2, 73, 2, "2", "60", "70", "1075", "11");
                yield return new cancer("10", 433, 2, 59, 2, "0", "90", "90", "363", "27");
                yield return new cancer("12", 145, 2, 60, 2, "2", "70", "60", null, null);
                yield return new cancer("7", 583, 2, 68, 1, "1", "60", "70", "1025", "7");
                yield return new cancer("7", 95, 2, 76, 2, "2", "60", "60", "625", "-24");
                yield return new cancer("1", 303, 2, 74, 1, "0", "90", "70", "463", "30");
                yield return new cancer("3", 519, 2, 63, 1, "1", "80", "70", "1025", "10");
                yield return new cancer("13", 643, 2, 74, 1, "0", "90", "90", "1425", "2");
                yield return new cancer("22", 765, 2, 50, 2, "1", "90", "100", "1175", "4");
                yield return new cancer("3", 735, 2, 72, 2, "1", "90", "90", null, "9");
                yield return new cancer("12", 189, 2, 63, 1, "0", "80", "70", null, "0");
                yield return new cancer("21", 53, 2, 68, 1, "0", "90", "100", "1025", "0");
                yield return new cancer("1", 246, 2, 58, 1, "0", "100", "90", "1175", "7");
                yield return new cancer("6", 689, 2, 59, 1, "1", "90", "80", "1300", "15");
                yield return new cancer("1", 65, 2, 62, 1, "0", "90", "80", "725", null);
                yield return new cancer("5", 5, 2, 65, 2, "0", "100", "80", "338", "5");
                yield return new cancer("22", 132, 2, 57, 1, "2", "70", "60", null, "18");
                yield return new cancer("3", 687, 2, 58, 2, "1", "80", "80", "1225", "10");
                yield return new cancer("1", 345, 2, 64, 2, "1", "90", "80", "1075", "-3");
                yield return new cancer("22", 444, 2, 75, 2, "2", "70", "70", "438", "8");
                yield return new cancer("12", 223, 2, 48, 1, "1", "90", "80", "1300", "68");
                yield return new cancer("21", 175, 2, 73, 1, "1", "80", "100", "1025", null);
                yield return new cancer("11", 60, 2, 65, 2, "1", "90", "80", "1025", "0");
                yield return new cancer("3", 163, 2, 69, 1, "1", "80", "60", "1125", "0");
                yield return new cancer("3", 65, 2, 68, 1, "2", "70", "50", "825", "8");
                yield return new cancer("16", 208, 2, 67, 2, "2", "70", null, "538", "2");
                yield return new cancer("5", 821, 1, 64, 2, "0", "90", "70", "1025", "3");
                yield return new cancer("22", 428, 2, 68, 1, "0", "100", "80", "1039", "0");
                yield return new cancer("6", 230, 2, 67, 1, "1", "80", "100", "488", "23");
                yield return new cancer("13", 840, 1, 63, 1, "0", "90", "90", "1175", "-1");
                yield return new cancer("3", 305, 2, 48, 2, "1", "80", "90", "538", "29");
                yield return new cancer("5", 11, 2, 74, 1, "2", "70", "100", "1175", "0");
                yield return new cancer("2", 132, 2, 40, 1, "1", "80", "80", null, "3");
                yield return new cancer("21", 226, 2, 53, 2, "1", "90", "80", "825", "3");
                yield return new cancer("12", 426, 2, 71, 2, "1", "90", "90", "1075", "19");
                yield return new cancer("1", 705, 2, 51, 2, "0", "100", "80", "1300", "0");
                yield return new cancer("6", 363, 2, 56, 2, "1", "80", "70", "1225", "-2");
                yield return new cancer("3", 11, 2, 81, 1, "0", "90", null, "731", "15");
                yield return new cancer("1", 176, 2, 73, 1, "0", "90", "70", "169", "30");
                yield return new cancer("4", 791, 2, 59, 1, "0", "100", "80", "768", "5");
                yield return new cancer("13", 95, 2, 55, 1, "1", "70", "90", "1500", "15");
                yield return new cancer("11", 196, 1, 42, 1, "1", "80", "80", "1425", "8");
                yield return new cancer("21", 167, 2, 44, 2, "1", "80", "90", "588", "-1");
                yield return new cancer("16", 806, 1, 44, 1, "1", "80", "80", "1025", "1");
                yield return new cancer("6", 284, 2, 71, 1, "1", "80", "90", "1100", "14");
                yield return new cancer("22", 641, 2, 62, 2, "1", "80", "80", "1150", "1");
                yield return new cancer("21", 147, 2, 61, 1, "0", "100", "90", "1175", "4");
                yield return new cancer("13", 740, 1, 44, 2, "1", "90", "80", "588", "39");
                yield return new cancer("1", 163, 2, 72, 1, "2", "70", "70", "910", "2");
                yield return new cancer("11", 655, 2, 63, 1, "0", "100", "90", "975", "-1");
                yield return new cancer("22", 239, 2, 70, 1, "1", "80", "100", null, "23");
                yield return new cancer("5", 88, 2, 66, 1, "1", "90", "80", "875", "8");
                yield return new cancer("10", 245, 2, 57, 2, "1", "80", "60", "280", "14");
                yield return new cancer("1", 588, 1, 69, 2, "0", "100", "90", null, "13");
                yield return new cancer("12", 30, 2, 72, 1, "2", "80", "60", "288", "7");
                yield return new cancer("3", 179, 2, 69, 1, "1", "80", "80", null, "25");
                yield return new cancer("12", 310, 2, 71, 1, "1", "90", "100", null, "0");
                yield return new cancer("11", 477, 2, 64, 1, "1", "90", "100", "910", "0");
                yield return new cancer("3", 166, 2, 70, 2, "0", "90", "70", null, "10");
                yield return new cancer("1", 559, 1, 58, 2, "0", "100", "100", "710", "15");
                yield return new cancer("6", 450, 2, 69, 2, "1", "80", "90", "1175", "3");
                yield return new cancer("13", 364, 2, 56, 1, "1", "70", "80", null, "4");
                yield return new cancer("6", 107, 2, 63, 1, "1", "90", "70", null, "0");
                yield return new cancer("13", 177, 2, 59, 1, "2", "50", null, null, "32");
                yield return new cancer("12", 156, 2, 66, 1, "1", "80", "90", "875", "14");
                yield return new cancer("26", 529, 1, 54, 2, "1", "80", "100", "975", "-3");
                yield return new cancer("1", 11, 2, 67, 1, "1", "90", "90", "925", null);
                yield return new cancer("21", 429, 2, 55, 1, "1", "100", "80", "975", "5");
                yield return new cancer("3", 351, 2, 75, 2, "2", "60", "50", "925", "11");
                yield return new cancer("13", 15, 2, 69, 1, "0", "90", "70", "575", "10");
                yield return new cancer("1", 181, 2, 44, 1, "1", "80", "90", "1175", "5");
                yield return new cancer("10", 283, 2, 80, 1, "1", "80", "100", "1030", "6");
                yield return new cancer("3", 201, 2, 75, 2, "0", "90", "100", null, "1");
                yield return new cancer("6", 524, 2, 54, 2, "1", "80", "100", null, "15");
                yield return new cancer("1", 13, 2, 76, 1, "2", "70", "70", "413", "20");
                yield return new cancer("3", 212, 2, 49, 1, "2", "70", "60", "675", "20");
                yield return new cancer("1", 524, 2, 68, 1, "2", "60", "70", "1300", "30");
                yield return new cancer("16", 288, 2, 66, 1, "2", "70", "60", "613", "24");
                yield return new cancer("15", 363, 2, 80, 1, "1", "80", "90", "346", "11");
                yield return new cancer("22", 442, 2, 75, 1, "0", "90", "90", null, "0");
                yield return new cancer("26", 199, 2, 60, 2, "2", "70", "80", "675", "10");
                yield return new cancer("3", 550, 2, 69, 2, "1", "70", "80", "910", "0");
                yield return new cancer("11", 54, 2, 72, 1, "2", "60", "60", "768", "-3");
                yield return new cancer("1", 558, 2, 70, 1, "0", "90", "90", "1025", "17");
                yield return new cancer("22", 207, 2, 66, 1, "1", "80", "80", "925", "20");
                yield return new cancer("7", 92, 2, 50, 1, "1", "80", "60", "1075", "13");
                yield return new cancer("12", 60, 2, 64, 1, "1", "80", "90", "993", "0");
                yield return new cancer("16", 551, 1, 77, 2, "2", "80", "60", "750", "28");
                yield return new cancer("12", 543, 1, 48, 2, "0", "90", "60", null, "4");
                yield return new cancer("4", 293, 2, 59, 2, "1", "80", "80", "925", "52");
                yield return new cancer("16", 202, 2, 53, 1, "1", "80", "80", null, "20");
                yield return new cancer("6", 353, 2, 47, 1, "0", "100", "90", "1225", "5");
                yield return new cancer("13", 511, 1, 55, 2, "1", "80", "70", null, "49");
                yield return new cancer("1", 267, 2, 67, 1, "0", "90", "70", "313", "6");
                yield return new cancer("22", 511, 1, 74, 2, "2", "60", "40", "96", "37");
                yield return new cancer("12", 371, 2, 58, 2, "1", "80", "70", null, "0");
                yield return new cancer("13", 387, 2, 56, 1, "2", "80", "60", "1075", null);
                yield return new cancer("1", 457, 2, 54, 1, "1", "90", "90", "975", "-5");
                yield return new cancer("5", 337, 2, 56, 1, "0", "100", "100", "1500", "15");
                yield return new cancer("21", 201, 2, 73, 2, "2", "70", "60", "1225", "-16");
                yield return new cancer("3", 404, 1, 74, 1, "1", "80", "70", "413", "38");
                yield return new cancer("26", 222, 2, 76, 1, "2", "70", "70", "1500", "8");
                yield return new cancer("1", 62, 2, 65, 2, "1", "80", "90", "1075", "0");
                yield return new cancer("11", 458, 1, 57, 1, "1", "80", "100", "513", "30");
                yield return new cancer("26", 356, 1, 53, 2, "1", "90", "90", null, "2");
                yield return new cancer("16", 353, 2, 71, 1, "0", "100", "80", "775", "2");
                yield return new cancer("16", 163, 2, 54, 1, "1", "90", "80", "1225", "13");
                yield return new cancer("12", 31, 2, 82, 1, "0", "100", "90", "413", "27");
                yield return new cancer("13", 340, 2, 59, 2, "0", "100", "90", null, "0");
                yield return new cancer("13", 229, 2, 70, 1, "1", "70", "60", "1175", "-2");
                yield return new cancer("22", 444, 1, 60, 1, "0", "90", "100", null, "7");
                yield return new cancer("5", 315, 1, 62, 2, "0", "90", "90", null, "0");
                yield return new cancer("16", 182, 2, 53, 2, "1", "80", "60", null, "4");
                yield return new cancer("32", 156, 2, 55, 1, "2", "70", "30", "1025", "10");
                yield return new cancer(null, 329, 2, 69, 1, "2", "70", "80", "713", "20");
                yield return new cancer("26", 364, 1, 68, 2, "1", "90", "90", null, "7");
                yield return new cancer("4", 291, 2, 62, 1, "2", "70", "60", "475", "27");
                yield return new cancer("12", 179, 2, 63, 1, "1", "80", "70", "538", "-2");
                yield return new cancer("1", 376, 1, 56, 2, "1", "80", "90", "825", "17");
                yield return new cancer("32", 384, 1, 62, 2, "0", "90", "90", "588", "8");
                yield return new cancer("10", 268, 2, 44, 2, "1", "90", "100", "2450", "2");
                yield return new cancer("11", 292, 1, 69, 1, "2", "60", "70", "2450", "36");
                yield return new cancer("6", 142, 2, 63, 1, "1", "90", "80", "875", "2");
                yield return new cancer("7", 413, 1, 64, 1, "1", "80", "70", "413", "16");
                yield return new cancer("16", 266, 1, 57, 2, "0", "90", "90", "1075", "3");
                yield return new cancer("11", 194, 2, 60, 2, "1", "80", "60", null, "33");
                yield return new cancer("21", 320, 2, 46, 1, "0", "100", "100", "860", "4");
                yield return new cancer("6", 181, 2, 61, 1, "1", "90", "90", "730", "0");
                yield return new cancer("12", 285, 2, 65, 1, "0", "100", "90", "1025", "0");
                yield return new cancer("13", 301, 1, 61, 1, "1", "90", "100", "825", "2");
                yield return new cancer("2", 348, 2, 58, 2, "0", "90", "80", "1225", "10");
                yield return new cancer("2", 197, 2, 56, 1, "1", "90", "60", "768", "37");
                yield return new cancer("16", 382, 1, 43, 2, "0", "100", "90", "338", "6");
                yield return new cancer("1", 303, 1, 53, 1, "1", "90", "80", "1225", "12");
                yield return new cancer("13", 296, 1, 59, 2, "1", "80", "100", "1025", "0");
                yield return new cancer("1", 180, 2, 56, 1, "2", "60", "80", "1225", "-2");
                yield return new cancer("13", 186, 2, 55, 2, "1", "80", "70", null, null);
                yield return new cancer("1", 145, 2, 53, 2, "1", "80", "90", "588", "13");
                yield return new cancer("7", 269, 1, 74, 2, "0", "100", "100", "588", "0");
                yield return new cancer("13", 300, 1, 60, 1, "0", "100", "100", "975", "5");
                yield return new cancer("1", 284, 1, 39, 1, "0", "100", "90", "1225", "-5");
                yield return new cancer("16", 350, 2, 66, 2, "0", "90", "100", "1025", null);
                yield return new cancer("32", 272, 1, 65, 2, "1", "80", "90", null, "-1");
                yield return new cancer("12", 292, 1, 51, 2, "0", "90", "80", "1225", "0");
                yield return new cancer("12", 332, 1, 45, 2, "0", "90", "100", "975", "5");
                yield return new cancer("2", 285, 2, 72, 2, "2", "70", "90", "463", "20");
                yield return new cancer("3", 259, 1, 58, 1, "0", "90", "80", "1300", "8");
                yield return new cancer("15", 110, 2, 64, 1, "1", "80", "60", "1025", "12");
                yield return new cancer("22", 286, 2, 53, 1, "0", "90", "90", "1225", "8");
                yield return new cancer("16", 270, 2, 72, 1, "1", "80", "90", "488", "14");
                yield return new cancer("16", 81, 2, 52, 1, "2", "60", "70", "1075", null);
                yield return new cancer("12", 131, 2, 50, 1, "1", "90", "80", "513", null);
                yield return new cancer("1", 225, 1, 64, 1, "1", "90", "80", "825", "33");
                yield return new cancer("22", 269, 2, 71, 1, "1", "90", "90", "1300", "-2");
                yield return new cancer("12", 225, 1, 70, 1, "0", "100", "100", "1175", "6");
                yield return new cancer("32", 243, 1, 63, 2, "1", "80", "90", "825", "0");
                yield return new cancer("21", 279, 1, 64, 1, "1", "90", "90", null, "4");
                yield return new cancer("1", 276, 1, 52, 2, "0", "100", "80", "975", "0");
                yield return new cancer("32", 135, 2, 60, 1, "1", "90", "70", "1275", "0");
                yield return new cancer("15", 79, 2, 64, 2, "1", "90", "90", "488", "37");
                yield return new cancer("22", 59, 2, 73, 1, "1", "60", "60", "2200", "5");
                yield return new cancer("32", 240, 1, 63, 2, "0", "90", "100", "1025", "0");
                yield return new cancer("3", 202, 1, 50, 2, "0", "100", "100", "635", "1");
                yield return new cancer("26", 235, 1, 63, 2, "0", "100", "90", "413", "0");
                yield return new cancer("33", 105, 2, 62, 1, "2", null, "70", null, null);
                yield return new cancer("5", 224, 1, 55, 2, "0", "80", "90", null, "23");
                yield return new cancer("13", 239, 2, 50, 2, "2", "60", "60", "1025", "-3");
                yield return new cancer("21", 237, 1, 69, 1, "1", "80", "70", null, null);
                yield return new cancer("33", 173, 1, 59, 2, "1", "90", "80", null, "10");
                yield return new cancer("1", 252, 1, 60, 2, "0", "100", "90", "488", "-2");
                yield return new cancer("6", 221, 1, 67, 1, "1", "80", "70", "413", "23");
                yield return new cancer("15", 185, 1, 69, 1, "1", "90", "70", "1075", "0");
                yield return new cancer("11", 92, 1, 64, 2, "2", "70", "100", null, "31");
                yield return new cancer("11", 13, 2, 65, 1, "1", "80", "90", null, "10");
                yield return new cancer("11", 222, 1, 65, 1, "1", "90", "70", "1025", "18");
                yield return new cancer("13", 192, 1, 41, 2, "1", "90", "80", null, "-10");
                yield return new cancer("21", 183, 2, 76, 1, "2", "80", "60", "825", "7");
                yield return new cancer("11", 211, 1, 70, 2, "2", "70", "30", "131", "3");
                yield return new cancer("2", 175, 1, 57, 2, "0", "80", "80", "725", "11");
                yield return new cancer("22", 197, 1, 67, 1, "1", "80", "90", "1500", "2");
                yield return new cancer("11", 203, 1, 71, 2, "1", "80", "90", "1025", "0");
                yield return new cancer("1", 116, 2, 76, 1, "1", "80", "80", null, "0");
                yield return new cancer("1", 188, 1, 77, 1, "1", "80", "60", null, "3");
                yield return new cancer("13", 191, 1, 39, 1, "0", "90", "90", "2350", "-5");
                yield return new cancer("32", 105, 1, 75, 2, "2", "60", "70", "1025", "5");
                yield return new cancer("6", 174, 1, 66, 1, "1", "90", "100", "1075", "1");
                yield return new cancer("22", 177, 1, 58, 2, "1", "80", "90", "1060", "0");
            }
        }
    }
}
