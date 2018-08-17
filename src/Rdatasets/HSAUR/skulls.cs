// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Egyptian Skulls
    /// </summary>

    public class skulls
    {
        public readonly string epoch;
        public readonly int mb;
        public readonly int bh;
        public readonly int bl;
        public readonly int nh;

        public skulls(string epoch, int mb, int bh, int bl, int nh)
        {
            this.epoch = epoch;
            this.mb = mb;
            this.bh = bh;
            this.bl = bl;
            this.nh = nh;
        }

        public static IEnumerable<skulls> Data
        {
            get
            {
                yield return new skulls("c4000BC", 131, 138, 89, 49);
                yield return new skulls("c4000BC", 125, 131, 92, 48);
                yield return new skulls("c4000BC", 131, 132, 99, 50);
                yield return new skulls("c4000BC", 119, 132, 96, 44);
                yield return new skulls("c4000BC", 136, 143, 100, 54);
                yield return new skulls("c4000BC", 138, 137, 89, 56);
                yield return new skulls("c4000BC", 139, 130, 108, 48);
                yield return new skulls("c4000BC", 125, 136, 93, 48);
                yield return new skulls("c4000BC", 131, 134, 102, 51);
                yield return new skulls("c4000BC", 134, 134, 99, 51);
                yield return new skulls("c4000BC", 129, 138, 95, 50);
                yield return new skulls("c4000BC", 134, 121, 95, 53);
                yield return new skulls("c4000BC", 126, 129, 109, 51);
                yield return new skulls("c4000BC", 132, 136, 100, 50);
                yield return new skulls("c4000BC", 141, 140, 100, 51);
                yield return new skulls("c4000BC", 131, 134, 97, 54);
                yield return new skulls("c4000BC", 135, 137, 103, 50);
                yield return new skulls("c4000BC", 132, 133, 93, 53);
                yield return new skulls("c4000BC", 139, 136, 96, 50);
                yield return new skulls("c4000BC", 132, 131, 101, 49);
                yield return new skulls("c4000BC", 126, 133, 102, 51);
                yield return new skulls("c4000BC", 135, 135, 103, 47);
                yield return new skulls("c4000BC", 134, 124, 93, 53);
                yield return new skulls("c4000BC", 128, 134, 103, 50);
                yield return new skulls("c4000BC", 130, 130, 104, 49);
                yield return new skulls("c4000BC", 138, 135, 100, 55);
                yield return new skulls("c4000BC", 128, 132, 93, 53);
                yield return new skulls("c4000BC", 127, 129, 106, 48);
                yield return new skulls("c4000BC", 131, 136, 114, 54);
                yield return new skulls("c4000BC", 124, 138, 101, 46);
                yield return new skulls("c3300BC", 124, 138, 101, 48);
                yield return new skulls("c3300BC", 133, 134, 97, 48);
                yield return new skulls("c3300BC", 138, 134, 98, 45);
                yield return new skulls("c3300BC", 148, 129, 104, 51);
                yield return new skulls("c3300BC", 126, 124, 95, 45);
                yield return new skulls("c3300BC", 135, 136, 98, 52);
                yield return new skulls("c3300BC", 132, 145, 100, 54);
                yield return new skulls("c3300BC", 133, 130, 102, 48);
                yield return new skulls("c3300BC", 131, 134, 96, 50);
                yield return new skulls("c3300BC", 133, 125, 94, 46);
                yield return new skulls("c3300BC", 133, 136, 103, 53);
                yield return new skulls("c3300BC", 131, 139, 98, 51);
                yield return new skulls("c3300BC", 131, 136, 99, 56);
                yield return new skulls("c3300BC", 138, 134, 98, 49);
                yield return new skulls("c3300BC", 130, 136, 104, 53);
                yield return new skulls("c3300BC", 131, 128, 98, 45);
                yield return new skulls("c3300BC", 138, 129, 107, 53);
                yield return new skulls("c3300BC", 123, 131, 101, 51);
                yield return new skulls("c3300BC", 130, 129, 105, 47);
                yield return new skulls("c3300BC", 134, 130, 93, 54);
                yield return new skulls("c3300BC", 137, 136, 106, 49);
                yield return new skulls("c3300BC", 126, 131, 100, 48);
                yield return new skulls("c3300BC", 135, 136, 97, 52);
                yield return new skulls("c3300BC", 129, 126, 91, 50);
                yield return new skulls("c3300BC", 134, 139, 101, 49);
                yield return new skulls("c3300BC", 131, 134, 90, 53);
                yield return new skulls("c3300BC", 132, 130, 104, 50);
                yield return new skulls("c3300BC", 130, 132, 93, 52);
                yield return new skulls("c3300BC", 135, 132, 98, 54);
                yield return new skulls("c3300BC", 130, 128, 101, 51);
                yield return new skulls("c1850BC", 137, 141, 96, 52);
                yield return new skulls("c1850BC", 129, 133, 93, 47);
                yield return new skulls("c1850BC", 132, 138, 87, 48);
                yield return new skulls("c1850BC", 130, 134, 106, 50);
                yield return new skulls("c1850BC", 134, 134, 96, 45);
                yield return new skulls("c1850BC", 140, 133, 98, 50);
                yield return new skulls("c1850BC", 138, 138, 95, 47);
                yield return new skulls("c1850BC", 136, 145, 99, 55);
                yield return new skulls("c1850BC", 136, 131, 92, 46);
                yield return new skulls("c1850BC", 126, 136, 95, 56);
                yield return new skulls("c1850BC", 137, 129, 100, 53);
                yield return new skulls("c1850BC", 137, 139, 97, 50);
                yield return new skulls("c1850BC", 136, 126, 101, 50);
                yield return new skulls("c1850BC", 137, 133, 90, 49);
                yield return new skulls("c1850BC", 129, 142, 104, 47);
                yield return new skulls("c1850BC", 135, 138, 102, 55);
                yield return new skulls("c1850BC", 129, 135, 92, 50);
                yield return new skulls("c1850BC", 134, 125, 90, 60);
                yield return new skulls("c1850BC", 138, 134, 96, 51);
                yield return new skulls("c1850BC", 136, 135, 94, 53);
                yield return new skulls("c1850BC", 132, 130, 91, 52);
                yield return new skulls("c1850BC", 133, 131, 100, 50);
                yield return new skulls("c1850BC", 138, 137, 94, 51);
                yield return new skulls("c1850BC", 130, 127, 99, 45);
                yield return new skulls("c1850BC", 136, 133, 91, 49);
                yield return new skulls("c1850BC", 134, 123, 95, 52);
                yield return new skulls("c1850BC", 136, 137, 101, 54);
                yield return new skulls("c1850BC", 133, 131, 96, 49);
                yield return new skulls("c1850BC", 138, 133, 100, 55);
                yield return new skulls("c1850BC", 138, 133, 91, 46);
                yield return new skulls("c200BC", 137, 134, 107, 54);
                yield return new skulls("c200BC", 141, 128, 95, 53);
                yield return new skulls("c200BC", 141, 130, 87, 49);
                yield return new skulls("c200BC", 135, 131, 99, 51);
                yield return new skulls("c200BC", 133, 120, 91, 46);
                yield return new skulls("c200BC", 131, 135, 90, 50);
                yield return new skulls("c200BC", 140, 137, 94, 60);
                yield return new skulls("c200BC", 139, 130, 90, 48);
                yield return new skulls("c200BC", 140, 134, 90, 51);
                yield return new skulls("c200BC", 138, 140, 100, 52);
                yield return new skulls("c200BC", 132, 133, 90, 53);
                yield return new skulls("c200BC", 134, 134, 97, 54);
                yield return new skulls("c200BC", 135, 135, 99, 50);
                yield return new skulls("c200BC", 133, 136, 95, 52);
                yield return new skulls("c200BC", 136, 130, 99, 55);
                yield return new skulls("c200BC", 134, 137, 93, 52);
                yield return new skulls("c200BC", 131, 141, 99, 55);
                yield return new skulls("c200BC", 129, 135, 95, 47);
                yield return new skulls("c200BC", 136, 128, 93, 54);
                yield return new skulls("c200BC", 131, 125, 88, 48);
                yield return new skulls("c200BC", 139, 130, 94, 53);
                yield return new skulls("c200BC", 144, 124, 86, 50);
                yield return new skulls("c200BC", 141, 131, 97, 53);
                yield return new skulls("c200BC", 130, 131, 98, 53);
                yield return new skulls("c200BC", 133, 128, 92, 51);
                yield return new skulls("c200BC", 138, 126, 97, 54);
                yield return new skulls("c200BC", 131, 142, 95, 53);
                yield return new skulls("c200BC", 136, 138, 94, 55);
                yield return new skulls("c200BC", 132, 136, 92, 52);
                yield return new skulls("c200BC", 135, 130, 100, 51);
                yield return new skulls("cAD150", 137, 123, 91, 50);
                yield return new skulls("cAD150", 136, 131, 95, 49);
                yield return new skulls("cAD150", 128, 126, 91, 57);
                yield return new skulls("cAD150", 130, 134, 92, 52);
                yield return new skulls("cAD150", 138, 127, 86, 47);
                yield return new skulls("cAD150", 126, 138, 101, 52);
                yield return new skulls("cAD150", 136, 138, 97, 58);
                yield return new skulls("cAD150", 126, 126, 92, 45);
                yield return new skulls("cAD150", 132, 132, 99, 55);
                yield return new skulls("cAD150", 139, 135, 92, 54);
                yield return new skulls("cAD150", 143, 120, 95, 51);
                yield return new skulls("cAD150", 141, 136, 101, 54);
                yield return new skulls("cAD150", 135, 135, 95, 56);
                yield return new skulls("cAD150", 137, 134, 93, 53);
                yield return new skulls("cAD150", 142, 135, 96, 52);
                yield return new skulls("cAD150", 139, 134, 95, 47);
                yield return new skulls("cAD150", 138, 125, 99, 51);
                yield return new skulls("cAD150", 137, 135, 96, 54);
                yield return new skulls("cAD150", 133, 125, 92, 50);
                yield return new skulls("cAD150", 145, 129, 89, 47);
                yield return new skulls("cAD150", 138, 136, 92, 46);
                yield return new skulls("cAD150", 131, 129, 97, 44);
                yield return new skulls("cAD150", 143, 126, 88, 54);
                yield return new skulls("cAD150", 134, 124, 91, 55);
                yield return new skulls("cAD150", 132, 127, 97, 52);
                yield return new skulls("cAD150", 137, 125, 85, 57);
                yield return new skulls("cAD150", 129, 128, 81, 52);
                yield return new skulls("cAD150", 140, 135, 103, 48);
                yield return new skulls("cAD150", 147, 129, 87, 48);
                yield return new skulls("cAD150", 136, 133, 97, 51);
            }
        }
    }
}
