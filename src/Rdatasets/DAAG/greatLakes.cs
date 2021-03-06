// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Yearly averages of Great Lake heights: 1918 - 2009
    /// </summary>

    public class greatLakes
    {
        public readonly int κ;
        public readonly double Erie;
        public readonly double michHuron;
        public readonly double Ontario;
        public readonly double StClair;

        public greatLakes(int κ, double Erie, double michHuron, double Ontario, double StClair)
        {
            this.κ = κ;
            this.Erie = Erie;
            this.michHuron = michHuron;
            this.Ontario = Ontario;
            this.StClair = StClair;
        }

        public static IEnumerable<greatLakes> Data
        {
            get
            {
                yield return new greatLakes(1, 174.015, 176.886666666667, 74.8725, 174.956666666667);
                yield return new greatLakes(2, 174.180833333333, 176.745, 74.9558333333333, 175.076666666667);
                yield return new greatLakes(3, 173.908333333333, 176.625, 74.5675, 174.815);
                yield return new greatLakes(4, 174.025833333333, 176.488333333333, 74.6658333333333, 174.869166666667);
                yield return new greatLakes(5, 173.9275, 176.445, 74.6566666666667, 174.810833333333);
                yield return new greatLakes(6, 173.7575, 176.264166666667, 74.4433333333333, 174.6525);
                yield return new greatLakes(7, 173.843333333333, 176.186666666667, 74.5575, 174.6375);
                yield return new greatLakes(8, 173.593333333333, 175.919166666667, 74.39, 174.405833333333);
                yield return new greatLakes(9, 173.640833333333, 175.885, 74.4025, 174.401666666667);
                yield return new greatLakes(10, 173.818333333333, 176.148333333333, 74.6066666666667, 174.598333333333);
                yield return new greatLakes(11, 173.951666666667, 176.443333333333, 74.8008333333333, 174.805);
                yield return new greatLakes(12, 174.311666666667, 176.895833333333, 75.085, 175.264166666667);
                yield return new greatLakes(13, 174.27, 176.650833333333, 75.0808333333333, 175.095);
                yield return new greatLakes(14, 173.705, 176.118333333333, 74.3575, 174.508333333333);
                yield return new greatLakes(15, 173.735833333333, 175.940833333333, 74.5025, 174.565833333333);
                yield return new greatLakes(16, 173.676666666667, 175.8675, 74.2758333333333, 174.546666666667);
                yield return new greatLakes(17, 173.331666666667, 175.766666666667, 74.0216666666667, 174.274166666667);
                yield return new greatLakes(18, 173.410833333333, 175.890833333333, 74.0041666666667, 174.360833333333);
                yield return new greatLakes(19, 173.488333333333, 175.939166666667, 74.1641666666667, 174.393333333333);
                yield return new greatLakes(20, 173.82, 175.9225, 74.4958333333333, 174.603333333333);
                yield return new greatLakes(21, 173.840833333333, 176.140833333333, 74.5225, 174.689166666667);
                yield return new greatLakes(22, 173.845833333333, 176.269166666667, 74.4925, 174.720833333333);
                yield return new greatLakes(23, 173.795, 176.141666666667, 74.4258333333333, 174.645);
                yield return new greatLakes(24, 173.7, 176.121666666667, 74.4075, 174.581666666667);
                yield return new greatLakes(25, 173.876666666667, 176.334166666667, 74.5166666666667, 174.7675);
                yield return new greatLakes(26, 174.231666666667, 176.626666666667, 75.1341666666667, 175.1125);
                yield return new greatLakes(27, 174.091666666667, 176.596666666667, 74.8458333333333, 174.981666666667);
                yield return new greatLakes(28, 174.188333333333, 176.57, 75.06, 175.089166666667);
                yield return new greatLakes(29, 174.135833333333, 176.601666666667, 74.9933333333333, 175.038333333333);
                yield return new greatLakes(30, 174.235, 176.566666666667, 75.1691666666667, 175.104166666667);
                yield return new greatLakes(31, 174.220833333333, 176.530833333333, 75.0808333333333, 175.0975);
                yield return new greatLakes(32, 173.973333333333, 176.210833333333, 74.7408333333333, 174.831666666667);
                yield return new greatLakes(33, 174.135, 176.260833333333, 74.8916666666667, 174.93);
                yield return new greatLakes(34, 174.324166666667, 176.735833333333, 75.2466666666667, 175.240833333333);
                yield return new greatLakes(35, 174.52, 177.085, 75.3658333333333, 175.499166666667);
                yield return new greatLakes(36, 174.330833333333, 176.933333333333, 75.015, 175.323333333333);
                yield return new greatLakes(37, 174.288333333333, 176.829166666667, 74.9816666666667, 175.235);
                yield return new greatLakes(38, 174.348333333333, 176.7225, 75.1458333333333, 175.251666666667);
                yield return new greatLakes(39, 174.12, 176.44, 74.9216666666667, 174.939166666667);
                yield return new greatLakes(40, 174.036666666667, 176.263333333333, 74.6333333333333, 174.88);
                yield return new greatLakes(41, 173.808333333333, 176.0675, 74.4283333333333, 174.629166666667);
                yield return new greatLakes(42, 173.85, 176.005833333333, 74.475, 174.656666666667);
                yield return new greatLakes(43, 174.094166666667, 176.4775, 74.7125, 174.99);
                yield return new greatLakes(44, 174.100833333333, 176.376666666667, 74.6133333333333, 174.963333333333);
                yield return new greatLakes(45, 173.9075, 176.2225, 74.6416666666667, 174.77);
                yield return new greatLakes(46, 173.726666666667, 175.9225, 74.655, 174.56);
                yield return new greatLakes(47, 173.6075, 175.6825, 74.2866666666667, 174.365);
                yield return new greatLakes(48, 173.7125, 175.915833333333, 74.3958333333333, 174.533333333333);
                yield return new greatLakes(49, 173.899166666667, 176.160833333333, 74.69, 174.756666666667);
                yield return new greatLakes(50, 174.059166666667, 176.300833333333, 74.8583333333333, 174.925);
                yield return new greatLakes(51, 174.204166666667, 176.446666666667, 74.7991666666667, 175.060833333333);
                yield return new greatLakes(52, 174.39, 176.695833333333, 74.7491666666667, 175.261666666667);
                yield return new greatLakes(53, 174.258333333333, 176.678333333333, 74.6858333333333, 175.15);
                yield return new greatLakes(54, 174.311666666667, 176.805, 74.7233333333333, 175.269166666667);
                yield return new greatLakes(55, 174.5, 176.888333333333, 74.935, 175.420833333333);
                yield return new greatLakes(56, 174.740833333333, 177.123333333333, 75.21, 175.65);
                yield return new greatLakes(57, 174.689166666667, 177.093333333333, 75.0658333333333, 175.613333333333);
                yield return new greatLakes(58, 174.615833333333, 176.973333333333, 74.81, 175.515833333333);
                yield return new greatLakes(59, 174.573333333333, 176.899166666667, 75.0441666666667, 175.478333333333);
                yield return new greatLakes(60, 174.2975, 176.505, 74.7583333333333, 175.199166666667);
                yield return new greatLakes(61, 174.3725, 176.590833333333, 74.9208333333333, 175.270833333333);
                yield return new greatLakes(62, 174.391666666667, 176.794166666667, 74.84, 175.355833333333);
                yield return new greatLakes(63, 174.521666666667, 176.803333333333, 74.8233333333333, 175.4075);
                yield return new greatLakes(64, 174.398333333333, 176.698333333333, 74.7858333333333, 175.295833333333);
                yield return new greatLakes(65, 174.425, 176.598333333333, 74.7525, 175.299166666667);
                yield return new greatLakes(66, 174.520833333333, 176.833333333333, 74.8216666666667, 175.433333333333);
                yield return new greatLakes(67, 174.5225, 176.895, 74.9016666666667, 175.435);
                yield return new greatLakes(68, 174.728333333333, 177.126666666667, 74.8775, 175.7);
                yield return new greatLakes(69, 174.898333333333, 177.2925, 75.1475, 175.851666666667);
                yield return new greatLakes(70, 174.6675, 176.97, 74.8491666666667, 175.560833333333);
                yield return new greatLakes(71, 174.261666666667, 176.564166666667, 74.68, 175.193333333333);
                yield return new greatLakes(72, 174.225833333333, 176.400833333333, 74.7608333333333, 175.109166666667);
                yield return new greatLakes(73, 174.294166666667, 176.35, 74.8041666666667, 175.130833333333);
                yield return new greatLakes(74, 174.326666666667, 176.469166666667, 74.87, 175.1975);
                yield return new greatLakes(75, 174.356666666667, 176.479166666667, 74.8325, 175.22);
                yield return new greatLakes(76, 174.504166666667, 176.695833333333, 75.0425, 175.380833333333);
                yield return new greatLakes(77, 174.366666666667, 176.678333333333, 74.755, 175.29);
                yield return new greatLakes(78, 174.284166666667, 176.5275, 74.7391666666667, 175.183333333333);
                yield return new greatLakes(79, 174.375, 176.654166666667, 74.8733333333333, 175.246666666667);
                yield return new greatLakes(80, 174.7175, 176.984166666667, 74.9625, 175.6125);
                yield return new greatLakes(81, 174.550833333333, 176.716666666667, 74.91, 175.3975);
                yield return new greatLakes(82, 174.1025, 176.235833333333, 74.5725, 174.975833333333);
                yield return new greatLakes(83, 173.99, 175.978333333333, 74.78, 174.7925);
                yield return new greatLakes(84, 173.914166666667, 175.950833333333, 74.6991666666667, 174.761666666667);
                yield return new greatLakes(85, 174.058333333333, 176.118333333333, 74.79, 174.883333333333);
                yield return new greatLakes(86, 173.965833333333, 175.891666666667, 74.7133333333333, 174.7375);
                yield return new greatLakes(87, 174.115833333333, 176.110833333333, 74.8483333333333, 174.916666666667);
                yield return new greatLakes(88, 174.17, 176.09, 74.8216666666667, 174.938333333333);
                yield return new greatLakes(89, 174.146666666667, 176.015833333333, 74.8308333333333, 174.891666666667);
                yield return new greatLakes(90, 174.139166666667, 175.943333333333, 74.7516666666667, 174.848333333333);
                yield return new greatLakes(91, 174.159166666667, 176.005, 74.875, 174.92);
                yield return new greatLakes(92, 174.248333333333, 176.258333333333, 74.8733333333333, 175.076666666667);
            }
        }
    }
}
