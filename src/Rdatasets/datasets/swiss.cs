// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Swiss Fertility and Socioeconomic Indicators (1888) Data
    /// </summary>

    public class swiss
    {
        public readonly string κ;
        public readonly double Fertility;
        public readonly double Agriculture;
        public readonly int Examination;
        public readonly int Education;
        public readonly double Catholic;
        public readonly double Infant_Mortality;

        public swiss(string κ, double Fertility, double Agriculture, int Examination, int Education, double Catholic, double Infant_Mortality)
        {
            this.κ = κ;
            this.Fertility = Fertility;
            this.Agriculture = Agriculture;
            this.Examination = Examination;
            this.Education = Education;
            this.Catholic = Catholic;
            this.Infant_Mortality = Infant_Mortality;
        }

        public static IEnumerable<swiss> Data
        {
            get
            {
                yield return new swiss("Courtelary", 80.2, 17, 15, 12, 9.96, 22.2);
                yield return new swiss("Delemont", 83.1, 45.1, 6, 9, 84.84, 22.2);
                yield return new swiss("Franches-Mnt", 92.5, 39.7, 5, 5, 93.4, 20.2);
                yield return new swiss("Moutier", 85.8, 36.5, 12, 7, 33.77, 20.3);
                yield return new swiss("Neuveville", 76.9, 43.5, 17, 15, 5.16, 20.6);
                yield return new swiss("Porrentruy", 76.1, 35.3, 9, 7, 90.57, 26.6);
                yield return new swiss("Broye", 83.8, 70.2, 16, 7, 92.85, 23.6);
                yield return new swiss("Glane", 92.4, 67.8, 14, 8, 97.16, 24.9);
                yield return new swiss("Gruyere", 82.4, 53.3, 12, 7, 97.67, 21);
                yield return new swiss("Sarine", 82.9, 45.2, 16, 13, 91.38, 24.4);
                yield return new swiss("Veveyse", 87.1, 64.5, 14, 6, 98.61, 24.5);
                yield return new swiss("Aigle", 64.1, 62, 21, 12, 8.52, 16.5);
                yield return new swiss("Aubonne", 66.9, 67.5, 14, 7, 2.27, 19.1);
                yield return new swiss("Avenches", 68.9, 60.7, 19, 12, 4.43, 22.7);
                yield return new swiss("Cossonay", 61.7, 69.3, 22, 5, 2.82, 18.7);
                yield return new swiss("Echallens", 68.3, 72.6, 18, 2, 24.2, 21.2);
                yield return new swiss("Grandson", 71.7, 34, 17, 8, 3.3, 20);
                yield return new swiss("Lausanne", 55.7, 19.4, 26, 28, 12.11, 20.2);
                yield return new swiss("La Vallee", 54.3, 15.2, 31, 20, 2.15, 10.8);
                yield return new swiss("Lavaux", 65.1, 73, 19, 9, 2.84, 20);
                yield return new swiss("Morges", 65.5, 59.8, 22, 10, 5.23, 18);
                yield return new swiss("Moudon", 65, 55.1, 14, 3, 4.52, 22.4);
                yield return new swiss("Nyone", 56.6, 50.9, 22, 12, 15.14, 16.7);
                yield return new swiss("Orbe", 57.4, 54.1, 20, 6, 4.2, 15.3);
                yield return new swiss("Oron", 72.5, 71.2, 12, 1, 2.4, 21);
                yield return new swiss("Payerne", 74.2, 58.1, 14, 8, 5.23, 23.8);
                yield return new swiss("Paysd'enhaut", 72, 63.5, 6, 3, 2.56, 18);
                yield return new swiss("Rolle", 60.5, 60.8, 16, 10, 7.72, 16.3);
                yield return new swiss("Vevey", 58.3, 26.8, 25, 19, 18.46, 20.9);
                yield return new swiss("Yverdon", 65.4, 49.5, 15, 8, 6.1, 22.5);
                yield return new swiss("Conthey", 75.5, 85.9, 3, 2, 99.71, 15.1);
                yield return new swiss("Entremont", 69.3, 84.9, 7, 6, 99.68, 19.8);
                yield return new swiss("Herens", 77.3, 89.7, 5, 2, 100, 18.3);
                yield return new swiss("Martigwy", 70.5, 78.2, 12, 6, 98.96, 19.4);
                yield return new swiss("Monthey", 79.4, 64.9, 7, 3, 98.22, 20.2);
                yield return new swiss("St Maurice", 65, 75.9, 9, 9, 99.06, 17.8);
                yield return new swiss("Sierre", 92.2, 84.6, 3, 3, 99.46, 16.3);
                yield return new swiss("Sion", 79.3, 63.1, 13, 13, 96.83, 18.1);
                yield return new swiss("Boudry", 70.4, 38.4, 26, 12, 5.62, 20.3);
                yield return new swiss("La Chauxdfnd", 65.7, 7.7, 29, 11, 13.79, 20.5);
                yield return new swiss("Le Locle", 72.7, 16.7, 22, 13, 11.22, 18.9);
                yield return new swiss("Neuchatel", 64.4, 17.6, 35, 32, 16.92, 23);
                yield return new swiss("Val de Ruz", 77.6, 37.6, 15, 7, 4.97, 20);
                yield return new swiss("ValdeTravers", 67.6, 18.7, 25, 7, 8.65, 19.5);
                yield return new swiss("V. De Geneve", 35, 1.2, 37, 53, 42.34, 18);
                yield return new swiss("Rive Droite", 44.7, 46.6, 16, 29, 50.43, 18.2);
                yield return new swiss("Rive Gauche", 42.8, 27.7, 22, 29, 58.33, 19.3);
            }
        }
    }
}
