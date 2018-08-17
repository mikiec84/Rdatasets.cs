// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Applications to a Political Science PhD Program
    /// </summary>

    public class admit
    {
        public readonly int score;
        public readonly int gre_quant;
        public readonly int gre_verbal;
        public readonly int ap;
        public readonly int pt;
        public readonly int female;

        public admit(int score, int gre_quant, int gre_verbal, int ap, int pt, int female)
        {
            this.score = score;
            this.gre_quant = gre_quant;
            this.gre_verbal = gre_verbal;
            this.ap = ap;
            this.pt = pt;
            this.female = female;
        }

        public static IEnumerable<admit> Data
        {
            get
            {
                yield return new admit(2, 630, 630, 0, 0, 1);
                yield return new admit(1, 520, 490, 0, 0, 1);
                yield return new admit(4, 670, 400, 0, 0, 0);
                yield return new admit(1, 600, 560, 0, 0, 0);
                yield return new admit(1, 620, 570, 0, 0, 0);
                yield return new admit(4, 730, 670, 0, 0, 0);
                yield return new admit(1, 640, 590, 0, 0, 1);
                yield return new admit(4, 470, 610, 1, 0, 1);
                yield return new admit(2, 550, 500, 1, 0, 0);
                yield return new admit(5, 720, 710, 0, 0, 1);
                yield return new admit(4, 750, 480, 0, 0, 1);
                yield return new admit(1, 720, 470, 0, 0, 0);
                yield return new admit(2, 590, 550, 0, 0, 1);
                yield return new admit(4, 760, 680, 0, 0, 0);
                yield return new admit(4, 750, 690, 0, 0, 0);
                yield return new admit(1, 580, 440, 0, 0, 0);
                yield return new admit(1, 640, 710, 0, 0, 0);
                yield return new admit(5, 710, 560, 0, 0, 0);
                yield return new admit(4, 610, 720, 1, 0, 0);
                yield return new admit(1, 530, 600, 0, 0, 0);
                yield return new admit(4, 740, 750, 0, 0, 0);
                yield return new admit(5, 740, 730, 1, 0, 0);
                yield return new admit(1, 430, 630, 0, 0, 1);
                yield return new admit(2, 510, 620, 0, 0, 0);
                yield return new admit(4, 620, 680, 0, 1, 1);
                yield return new admit(4, 620, 680, 1, 0, 0);
                yield return new admit(1, 330, 460, 0, 0, 0);
                yield return new admit(5, 700, 730, 1, 0, 0);
                yield return new admit(5, 770, 470, 0, 0, 0);
                yield return new admit(5, 790, 760, 0, 0, 1);
                yield return new admit(2, 660, 640, 0, 1, 0);
                yield return new admit(1, 720, 670, 0, 0, 0);
                yield return new admit(2, 630, 590, 1, 0, 0);
                yield return new admit(1, 420, 640, 0, 0, 0);
                yield return new admit(4, 640, 410, 0, 0, 1);
                yield return new admit(2, 670, 610, 0, 0, 0);
                yield return new admit(2, 690, 640, 0, 0, 1);
                yield return new admit(1, 390, 610, 0, 1, 1);
                yield return new admit(1, 410, 410, 0, 0, 0);
                yield return new admit(2, 700, 470, 0, 0, 0);
                yield return new admit(4, 640, 640, 0, 0, 1);
                yield return new admit(2, 740, 650, 0, 0, 1);
                yield return new admit(1, 720, 370, 0, 1, 0);
                yield return new admit(5, 640, 670, 0, 0, 0);
                yield return new admit(1, 740, 290, 0, 0, 0);
                yield return new admit(5, 770, 420, 0, 0, 1);
                yield return new admit(5, 800, 740, 0, 0, 0);
                yield return new admit(2, 750, 510, 0, 0, 0);
                yield return new admit(1, 670, 530, 0, 0, 0);
                yield return new admit(5, 730, 560, 0, 0, 0);
                yield return new admit(2, 620, 600, 0, 0, 0);
                yield return new admit(2, 560, 530, 0, 0, 1);
                yield return new admit(4, 660, 630, 0, 1, 0);
                yield return new admit(5, 750, 630, 1, 0, 0);
                yield return new admit(2, 730, 410, 0, 0, 1);
                yield return new admit(2, 780, 490, 0, 0, 0);
                yield return new admit(4, 770, 670, 0, 0, 0);
                yield return new admit(5, 770, 750, 0, 0, 0);
                yield return new admit(4, 680, 680, 0, 0, 0);
                yield return new admit(2, 720, 530, 0, 0, 0);
                yield return new admit(4, 720, 760, 1, 0, 0);
                yield return new admit(5, 590, 720, 1, 0, 1);
                yield return new admit(4, 770, 480, 0, 0, 0);
                yield return new admit(5, 790, 720, 0, 0, 0);
                yield return new admit(5, 770, 660, 0, 0, 1);
                yield return new admit(1, 540, 460, 0, 0, 1);
                yield return new admit(4, 740, 730, 0, 0, 0);
                yield return new admit(5, 780, 640, 0, 0, 1);
                yield return new admit(4, 740, 650, 0, 0, 0);
                yield return new admit(5, 770, 670, 1, 0, 0);
                yield return new admit(1, 680, 430, 0, 0, 0);
                yield return new admit(2, 720, 760, 0, 0, 0);
                yield return new admit(4, 770, 720, 0, 0, 0);
                yield return new admit(2, 720, 480, 0, 0, 0);
                yield return new admit(4, 770, 510, 0, 0, 0);
                yield return new admit(2, 640, 580, 0, 1, 0);
                yield return new admit(4, 750, 410, 0, 0, 0);
                yield return new admit(4, 660, 710, 0, 0, 1);
                yield return new admit(4, 750, 570, 0, 0, 0);
                yield return new admit(2, 550, 720, 0, 0, 0);
                yield return new admit(3, 540, 640, 0, 0, 1);
                yield return new admit(4, 650, 670, 0, 1, 1);
                yield return new admit(4, 720, 770, 0, 0, 0);
                yield return new admit(1, 470, 320, 0, 0, 1);
                yield return new admit(4, 750, 720, 0, 0, 0);
                yield return new admit(1, 560, 370, 0, 0, 0);
                yield return new admit(1, 560, 690, 0, 0, 1);
                yield return new admit(5, 710, 610, 0, 0, 0);
                yield return new admit(4, 750, 570, 0, 0, 0);
                yield return new admit(4, 760, 620, 0, 0, 0);
                yield return new admit(3, 740, 310, 0, 0, 1);
                yield return new admit(4, 790, 330, 0, 0, 0);
                yield return new admit(4, 790, 710, 0, 0, 0);
                yield return new admit(4, 670, 620, 0, 0, 0);
                yield return new admit(1, 580, 530, 0, 0, 0);
                yield return new admit(5, 790, 700, 0, 0, 1);
                yield return new admit(4, 740, 720, 0, 0, 1);
                yield return new admit(2, 730, 570, 0, 0, 0);
                yield return new admit(2, 730, 620, 0, 0, 1);
                yield return new admit(2, 750, 500, 0, 1, 0);
                yield return new admit(2, 640, 600, 0, 0, 1);
                yield return new admit(5, 720, 720, 1, 0, 1);
                yield return new admit(4, 770, 600, 0, 0, 0);
                yield return new admit(4, 740, 620, 0, 0, 1);
                yield return new admit(4, 760, 600, 0, 0, 1);
                yield return new admit(4, 650, 710, 0, 0, 0);
            }
        }
    }
}
