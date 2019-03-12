// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// International Expansion of U.S. Mofa's (majority-owned Foreign Affiliates in Fire (finance, Insurance and Real Estate)
    /// </summary>

    public class Mofa
    {
        public readonly string κ;
        public readonly double capexp;
        public readonly double gdp;
        public readonly double? sales;
        public readonly double nbaf;
        public readonly string netinc;

        public Mofa(string κ, double capexp, double gdp, double? sales, double nbaf, string netinc)
        {
            this.κ = κ;
            this.capexp = capexp;
            this.gdp = gdp;
            this.sales = sales;
            this.nbaf = nbaf;
            this.netinc = netinc;
        }

        public static IEnumerable<Mofa> Data
        {
            get
            {
                yield return new Mofa("Belgium", 2, 0.8524, 2.12, 4.82, "11.5");
                yield return new Mofa("Denmark", 3, 0.57, 0.15, 1.24, "0.1");
                yield return new Mofa("France", 3, 5.3726, 2.7, 9.08, "0.4");
                yield return new Mofa("Germany", 24, 6.6299, 5.35, 10.85, "9.1");
                yield return new Mofa("Greece", 0.25, 0.3395, 0.02, 0.79, "0.1");
                yield return new Mofa("Ireland", 1, 0.1718, 0.29, 2.15, "5.1");
                yield return new Mofa("Italy", 1, 3.4458, 1.43, 5.4, "2.9");
                yield return new Mofa("Netherlands", 12, 1.3652, 3.72, 6.74, "12.1");
                yield return new Mofa("U.K.", 297, 4.7322, 42.88, 19.44, "46.0");
                yield return new Mofa("Austria", 0, 0.6664, 0.03, 1.34, "-0.1");
                yield return new Mofa("Norway", 0, 0.5608, 0, 1.19, "-1.5");
                yield return new Mofa("Portugal", 0, 0.2129, 0, 0.74, "0");
                yield return new Mofa("Spain", 1, 1.8125, 0.43, 3.62, "0.025");
                yield return new Mofa("Sweden", 3, 0.9877, 0.2, 2.01, "0.1");
                yield return new Mofa("Switzerland", 9, 0.9673, 2.08, 5.24, "35.8");
                yield return new Mofa("Turkey", 0, 0.4998, 0, 0.277, "0");
                yield return new Mofa("Japan", 4, 10.6192, 7.38, 7.04, "4.2");
                yield return new Mofa("Australia", 9, 1.6421, 8.35, 7.52, "13.0");
                yield return new Mofa("N. Zealand", 4, 0.2382, 0.6, 1.17, "-0.2");
                yield return new Mofa("S. Africa", 1, 0.7433, 0.43, 2.87, "-0.1");
                yield return new Mofa("Argentina", 1, 0.6445, 0.61, 2.06, "1.3");
                yield return new Mofa("Brazil", 4, 2.4847, 1.64, 6.01, "7.2");
                yield return new Mofa("Chile", 0.25, 0.2414, null, 0.91, null);
                yield return new Mofa("Colombia", 0.25, 0.3497, null, 1.79, null);
                yield return new Mofa("Ecuador", 0.25, 0.1233, 0.04, 0.67, "0.1");
                yield return new Mofa("Peru", 0, 0.2162, 0, 0.77, "0.025");
                yield return new Mofa("Venezuela", 0.25, 0.6949, 0.09, 3.47, "-0.4");
                yield return new Mofa("Mexico", 2, 1.7127, 0.96, 7.02, "-3.3");
                yield return new Mofa("Panama", 5, 0.0419, 0.59, 1.93, "42.6");
                yield return new Mofa("Tr/Tob", 0.25, 0.0697, null, 0.37, null);
                yield return new Mofa("Egypt", 0.25, 0.264, 0.02, 0.7, "0.2");
                yield return new Mofa("Libya", 0, 0.2836, 0, 0.29, "0");
                yield return new Mofa("Liberia", 0, 0.0095, 0.51, 0.55, "1.8");
                yield return new Mofa("Nigeria", 0, 0.7172, 0, 0.89, "0");
                yield return new Mofa("Israel", 1, 0.2049, null, 0.71, null);
                yield return new Mofa("Hong-Kong", 2, 0.2444, null, 3.21, null);
                yield return new Mofa("India", 0, 1.5076, 0, 0.92, "0.1");
                yield return new Mofa("Indonesia", 1, 0.9016, null, 1.43, null);
                yield return new Mofa("Malaysia", 0.25, 0.2587, 0.13, 1.14, "0.3");
                yield return new Mofa("Philippines", 3, 0.3985, null, 1.86, null);
                yield return new Mofa("Singapore", 1, 0.1465, 0.58, 2.38, "0.8");
                yield return new Mofa("S.Korea", 0.25, 0.6842, 0.1, 0.93, "-0.1");
                yield return new Mofa("Thailand", 0.25, 0.3679, 0.02, 0.87, "0.025");
                yield return new Mofa("Canada", 140, 2.8957, 62.36, 20.75, "41.8");
                yield return new Mofa("Finland", 0, 0.4893, 0, 0.51, "0");
                yield return new Mofa("S. Arabia", 0.25, 1.5359, 0.07, 1.6, "-0.5");
                yield return new Mofa("Jamaica", 0.25, 0.0318, 0.08, 0.54, "0.1");
                yield return new Mofa("U. Arab Em.", 0, 0.2987, 0, 0.76, "0");
                yield return new Mofa("Luxembourg", 0, 0.0386, 1.1, 0.62, "12.0");
                yield return new Mofa("Bahamas", 3, 0.0145, 0.9, 1.78, "6.2\x001a");
            }
        }
    }
}
