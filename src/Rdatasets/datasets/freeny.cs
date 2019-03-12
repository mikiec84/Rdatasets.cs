// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Freeny's Revenue Data
    /// </summary>

    public class freeny
    {
        public readonly double κ;
        public readonly double y;
        public readonly double lag_quarterly_revenue;
        public readonly double price_index;
        public readonly double income_level;
        public readonly double market_potential;

        public freeny(double κ, double y, double lag_quarterly_revenue, double price_index, double income_level, double market_potential)
        {
            this.κ = κ;
            this.y = y;
            this.lag_quarterly_revenue = lag_quarterly_revenue;
            this.price_index = price_index;
            this.income_level = income_level;
            this.market_potential = market_potential;
        }

        public static IEnumerable<freeny> Data
        {
            get
            {
                yield return new freeny(1962.25, 8.79236, 8.79636, 4.70997, 5.8211, 12.9699);
                yield return new freeny(1962.5, 8.79137, 8.79236, 4.70217, 5.82558, 12.9733);
                yield return new freeny(1962.75, 8.81486, 8.79137, 4.68944, 5.83112, 12.9774);
                yield return new freeny(1963, 8.81301, 8.81486, 4.68558, 5.84046, 12.9806);
                yield return new freeny(1963.25, 8.90751, 8.81301, 4.64019, 5.85036, 12.9831);
                yield return new freeny(1963.5, 8.93673, 8.90751, 4.62553, 5.86464, 12.9854);
                yield return new freeny(1963.75, 8.96161, 8.93673, 4.61991, 5.87769, 12.99);
                yield return new freeny(1964, 8.96044, 8.96161, 4.61654, 5.89763, 12.9943);
                yield return new freeny(1964.25, 9.00868, 8.96044, 4.61407, 5.92574, 12.9992);
                yield return new freeny(1964.5, 9.03049, 9.00868, 4.60766, 5.94232, 13.0033);
                yield return new freeny(1964.75, 9.06906, 9.03049, 4.60227, 5.95365, 13.0099);
                yield return new freeny(1965, 9.05871, 9.06906, 4.5896, 5.9612, 13.0159);
                yield return new freeny(1965.25, 9.10698, 9.05871, 4.57592, 5.97805, 13.0212);
                yield return new freeny(1965.5, 9.12685, 9.10698, 4.58661, 6.00377, 13.0265);
                yield return new freeny(1965.75, 9.17096, 9.12685, 4.57997, 6.02829, 13.0351);
                yield return new freeny(1966, 9.18665, 9.17096, 4.57176, 6.03475, 13.0429);
                yield return new freeny(1966.25, 9.23823, 9.18665, 4.56104, 6.03906, 13.0497);
                yield return new freeny(1966.5, 9.26487, 9.23823, 4.54906, 6.05046, 13.0551);
                yield return new freeny(1966.75, 9.28436, 9.26487, 4.53957, 6.05563, 13.0634);
                yield return new freeny(1967, 9.31378, 9.28436, 4.51018, 6.06093, 13.0693);
                yield return new freeny(1967.25, 9.35025, 9.31378, 4.50352, 6.07103, 13.0737);
                yield return new freeny(1967.5, 9.35835, 9.35025, 4.4936, 6.08018, 13.077);
                yield return new freeny(1967.75, 9.39767, 9.35835, 4.46505, 6.08858, 13.0849);
                yield return new freeny(1968, 9.4215, 9.39767, 4.44924, 6.10199, 13.0918);
                yield return new freeny(1968.25, 9.44223, 9.4215, 4.43966, 6.11207, 13.095);
                yield return new freeny(1968.5, 9.48721, 9.44223, 4.42025, 6.11596, 13.0984);
                yield return new freeny(1968.75, 9.52374, 9.48721, 4.4106, 6.12129, 13.1089);
                yield return new freeny(1969, 9.5398, 9.52374, 4.41151, 6.122, 13.1169);
                yield return new freeny(1969.25, 9.58123, 9.5398, 4.3981, 6.13119, 13.1222);
                yield return new freeny(1969.5, 9.60048, 9.58123, 4.38513, 6.14705, 13.1266);
                yield return new freeny(1969.75, 9.64496, 9.60048, 4.3732, 6.15336, 13.1356);
                yield return new freeny(1970, 9.6439, 9.64496, 4.3277, 6.15627, 13.1415);
                yield return new freeny(1970.25, 9.69405, 9.6439, 4.32023, 6.16274, 13.1444);
                yield return new freeny(1970.5, 9.69958, 9.69405, 4.30909, 6.17369, 13.1459);
                yield return new freeny(1970.75, 9.68683, 9.69958, 4.30909, 6.16135, 13.152);
                yield return new freeny(1971, 9.71774, 9.68683, 4.30552, 6.18231, 13.1593);
                yield return new freeny(1971.25, 9.74924, 9.71774, 4.29627, 6.18768, 13.1579);
                yield return new freeny(1971.5, 9.77536, 9.74924, 4.27839, 6.19377, 13.1625);
                yield return new freeny(1971.75, 9.79424, 9.77536, 4.27789, 6.2003, 13.1664);
            }
        }
    }
}
