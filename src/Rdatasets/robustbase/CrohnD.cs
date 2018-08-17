// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Crohn's Disease Adverse Events Data
    /// </summary>

    public class CrohnD
    {
        public readonly int ID;
        public readonly int nrAdvE;
        public readonly double BMI;
        public readonly int height;
        public readonly string country;
        public readonly string sex;
        public readonly int age;
        public readonly int weight;
        public readonly string treat;

        public CrohnD(int ID, int nrAdvE, double BMI, int height, string country, string sex, int age, int weight, string treat)
        {
            this.ID = ID;
            this.nrAdvE = nrAdvE;
            this.BMI = BMI;
            this.height = height;
            this.country = country;
            this.sex = sex;
            this.age = age;
            this.weight = weight;
            this.treat = treat;
        }

        public static IEnumerable<CrohnD> Data
        {
            get
            {
                yield return new CrohnD(19908, 4, 25.22, 163, "c1", "F", 47, 67, "placebo");
                yield return new CrohnD(19909, 4, 23.8, 164, "c1", "F", 53, 64, "d1");
                yield return new CrohnD(19910, 1, 23.05, 164, "c1", "F", 68, 62, "placebo");
                yield return new CrohnD(20908, 1, 25.71, 165, "c1", "F", 48, 70, "d2");
                yield return new CrohnD(20909, 2, 25.95, 170, "c1", "F", 67, 75, "placebo");
                yield return new CrohnD(20910, 2, 28.7, 168, "c1", "F", 54, 81, "d1");
                yield return new CrohnD(21908, 3, 26.62, 161, "c1", "F", 53, 69, "d1");
                yield return new CrohnD(21909, 0, 26.22, 168, "c1", "F", 53, 74, "placebo");
                yield return new CrohnD(21910, 1, 32.05, 154, "c1", "F", 47, 76, "d2");
                yield return new CrohnD(21911, 0, 33.27, 157, "c1", "F", 58, 82, "placebo");
                yield return new CrohnD(21912, 5, 32.46, 152, "c1", "F", 63, 75, "d2");
                yield return new CrohnD(21913, 2, 37.58, 159, "c1", "F", 54, 95, "d2");
                yield return new CrohnD(21914, 6, 28.37, 170, "c1", "M", 58, 82, "placebo");
                yield return new CrohnD(21915, 0, 23.05, 160, "c1", "F", 54, 59, "d2");
                yield return new CrohnD(21916, 0, 23.94, 177, "c1", "M", 56, 75, "d1");
                yield return new CrohnD(21917, 0, 36.44, 164, "c1", "F", 51, 98, "d2");
                yield return new CrohnD(21918, 0, 31.1, 172, "c1", "F", 59, 92, "d2");
                yield return new CrohnD(22908, 5, 18.2, 159, "c1", "F", 66, 46, "d2");
                yield return new CrohnD(22909, 8, 30.82, 156, "c1", "M", 71, 75, "placebo");
                yield return new CrohnD(22910, 0, 24.76, 182, "c1", "M", 51, 82, "placebo");
                yield return new CrohnD(22911, 3, 24.76, 182, "c1", "M", 68, 82, "d2");
                yield return new CrohnD(22912, 2, 20.96, 162, "c1", "F", 36, 55, "placebo");
                yield return new CrohnD(22913, 9, 23.83, 156, "c1", "F", 47, 58, "d2");
                yield return new CrohnD(22914, 3, 25.15, 157, "c1", "F", 75, 62, "d2");
                yield return new CrohnD(22915, 3, 25.28, 164, "c1", "F", 29, 68, "d2");
                yield return new CrohnD(22916, 2, 30.86, 163, "c1", "F", 53, 82, "d1");
                yield return new CrohnD(22917, 2, 25.2, 153, "c1", "F", 57, 59, "d2");
                yield return new CrohnD(22918, 2, 24.52, 159, "c1", "F", 65, 62, "placebo");
                yield return new CrohnD(23908, 0, 30.44, 158, "c1", "F", 55, 76, "d1");
                yield return new CrohnD(23909, 0, 23.42, 156, "c1", "F", 44, 57, "d1");
                yield return new CrohnD(23910, 0, 26.71, 156, "c1", "F", 59, 65, "d1");
                yield return new CrohnD(23911, 0, 31.79, 180, "c1", "M", 53, 103, "placebo");
                yield return new CrohnD(23912, 0, 16, 150, "c1", "F", 28, 36, "d1");
                yield return new CrohnD(23913, 0, 19.47, 165, "c1", "F", 60, 53, "placebo");
                yield return new CrohnD(23914, 0, 34.48, 172, "c1", "F", 53, 102, "d2");
                yield return new CrohnD(23915, 0, 28.84, 158, "c1", "F", 58, 72, "placebo");
                yield return new CrohnD(24908, 1, 27.06, 173, "c1", "F", 39, 81, "placebo");
                yield return new CrohnD(24909, 0, 22.48, 155, "c1", "F", 52, 54, "d1");
                yield return new CrohnD(24910, 0, 20.96, 156, "c1", "F", 51, 51, "d1");
                yield return new CrohnD(24911, 1, 24.15, 182, "c1", "M", 63, 80, "placebo");
                yield return new CrohnD(24912, 0, 25.15, 162, "c1", "F", 69, 66, "placebo");
                yield return new CrohnD(24913, 0, 24.76, 182, "c1", "M", 56, 82, "d1");
                yield return new CrohnD(24914, 0, 22.77, 165, "c1", "F", 51, 62, "d2");
                yield return new CrohnD(24915, 0, 22.43, 158, "c1", "F", 58, 56, "placebo");
                yield return new CrohnD(24916, 0, 21.56, 164, "c1", "F", 59, 58, "d1");
                yield return new CrohnD(24917, 3, 17.42, 166, "c1", "F", 46, 48, "d1");
                yield return new CrohnD(24918, 0, 25.04, 166, "c1", "F", 44, 69, "d2");
                yield return new CrohnD(25908, 2, 27.12, 176, "c1", "M", 50, 84, "d2");
                yield return new CrohnD(25909, 12, 23.61, 154, "c1", "F", 62, 56, "placebo");
                yield return new CrohnD(25910, 4, 30.63, 149, "c1", "F", 46, 68, "placebo");
                yield return new CrohnD(25911, 8, 21.08, 154, "c1", "F", 39, 50, "d2");
                yield return new CrohnD(25912, 0, 29.3, 160, "c1", "F", 45, 75, "placebo");
                yield return new CrohnD(25913, 1, 25.71, 165, "c1", "F", 56, 70, "d2");
                yield return new CrohnD(25914, 0, 29.39, 166, "c1", "F", 53, 81, "d2");
                yield return new CrohnD(25915, 2, 24.03, 158, "c1", "F", 41, 60, "placebo");
                yield return new CrohnD(25916, 1, 25.25, 178, "c1", "M", 58, 80, "d1");
                yield return new CrohnD(25917, 0, 26.95, 160, "c1", "F", 42, 69, "d2");
                yield return new CrohnD(25918, 5, 23.34, 163, "c1", "F", 52, 62, "placebo");
                yield return new CrohnD(25919, 2, 22.27, 160, "c1", "F", 45, 57, "d1");
                yield return new CrohnD(25920, 1, 27.89, 164, "c1", "F", 69, 75, "d1");
                yield return new CrohnD(25921, 2, 27.14, 164, "c1", "F", 54, 73, "d1");
                yield return new CrohnD(26908, 0, 25.78, 150, "c1", "F", 73, 58, "d1");
                yield return new CrohnD(26909, 2, 26.45, 165, "c1", "F", 57, 72, "d1");
                yield return new CrohnD(26910, 0, 19.1, 165, "c1", "F", 66, 52, "d1");
                yield return new CrohnD(26911, 1, 26.35, 163, "c1", "F", 59, 70, "placebo");
                yield return new CrohnD(26912, 0, 31.96, 176, "c1", "F", 46, 99, "d2");
                yield return new CrohnD(26913, 0, 23.04, 178, "c1", "M", 44, 73, "d2");
                yield return new CrohnD(26914, 1, 25.53, 162, "c1", "F", 66, 67, "placebo");
                yield return new CrohnD(27908, 0, 21.63, 158, "c1", "F", 58, 54, "placebo");
                yield return new CrohnD(28908, 7, 29.34, 162, "c1", "F", 57, 77, "d2");
                yield return new CrohnD(28909, 0, 24.34, 172, "c1", "F", 33, 72, "d1");
                yield return new CrohnD(28910, 0, 26.57, 182, "c1", "M", 56, 88, "d1");
                yield return new CrohnD(28911, 9, 42.27, 124, "c1", "M", 40, 65, "d1");
                yield return new CrohnD(28912, 0, 23.95, 166, "c1", "F", 19, 66, "d1");
                yield return new CrohnD(28913, 0, 21.37, 156, "c1", "F", 56, 52, "d2");
                yield return new CrohnD(28914, 0, 23.42, 164, "c1", "F", 53, 63, "placebo");
                yield return new CrohnD(28915, 0, 24.03, 158, "c1", "F", 40, 60, "d1");
                yield return new CrohnD(28916, 0, 23.24, 162, "c1", "F", 55, 61, "d2");
                yield return new CrohnD(50908, 1, 22.03, 158, "c2", "F", 67, 55, "placebo");
                yield return new CrohnD(50909, 4, 19.37, 176, "c2", "F", 66, 60, "d1");
                yield return new CrohnD(50910, 0, 16.41, 160, "c2", "F", 61, 42, "d1");
                yield return new CrohnD(50911, 4, 24.24, 156, "c2", "F", 63, 59, "d2");
                yield return new CrohnD(50912, 0, 32.45, 172, "c2", "F", 62, 96, "d2");
                yield return new CrohnD(50913, 6, 24.96, 171, "c2", "M", 66, 73, "d2");
                yield return new CrohnD(50914, 0, 26.57, 168, "c2", "F", 62, 75, "d1");
                yield return new CrohnD(50915, 7, 28.4, 173, "c2", "M", 60, 85, "placebo");
                yield return new CrohnD(51908, 0, 23.66, 172, "c2", "M", 38, 70, "d2");
                yield return new CrohnD(51909, 0, 29.9, 153, "c2", "F", 57, 70, "d1");
                yield return new CrohnD(51910, 0, 22.59, 167, "c2", "F", 62, 63, "d1");
                yield return new CrohnD(51911, 4, 22.72, 157, "c2", "F", 55, 56, "placebo");
                yield return new CrohnD(51912, 6, 26.31, 151, "c2", "F", 59, 60, "d1");
                yield return new CrohnD(51913, 2, 23.23, 166, "c2", "F", 54, 64, "placebo");
                yield return new CrohnD(51914, 2, 20.96, 159, "c2", "F", 54, 53, "placebo");
                yield return new CrohnD(51915, 5, 27.92, 165, "c2", "F", 60, 76, "d1");
                yield return new CrohnD(51916, 7, 38.29, 149, "c2", "F", 50, 85, "d1");
                yield return new CrohnD(51917, 12, 29.3, 160, "c2", "F", 66, 75, "placebo");
                yield return new CrohnD(51918, 3, 22.76, 169, "c2", "F", 43, 65, "d2");
                yield return new CrohnD(51919, 7, 30.12, 168, "c2", "F", 46, 85, "placebo");
                yield return new CrohnD(53908, 1, 31.16, 152, "c2", "F", 69, 72, "placebo");
                yield return new CrohnD(53909, 3, 23.66, 172, "c2", "M", 35, 70, "placebo");
                yield return new CrohnD(53910, 6, 24.77, 162, "c2", "F", 70, 65, "d1");
                yield return new CrohnD(53911, 8, 27.34, 160, "c2", "F", 62, 70, "d2");
                yield return new CrohnD(54923, 5, 42.98, 165, "c2", "F", 57, 117, "d2");
                yield return new CrohnD(54924, 0, 22.76, 161, "c2", "F", 30, 59, "d2");
                yield return new CrohnD(54925, 2, 33.2, 160, "c2", "F", 56, 85, "d2");
                yield return new CrohnD(54926, 0, 20.5, 153, "c2", "F", 74, 48, "placebo");
                yield return new CrohnD(54927, 0, 21.33, 150, "c2", "F", 65, 48, "d1");
                yield return new CrohnD(54928, 1, 23.88, 165, "c2", "F", 61, 65, "placebo");
                yield return new CrohnD(54929, 1, 25.54, 152, "c2", "F", 70, 59, "d2");
                yield return new CrohnD(54930, 1, 28.48, 159, "c2", "F", 65, 72, "d1");
                yield return new CrohnD(54931, 0, 22.04, 165, "c2", "F", 54, 60, "placebo");
                yield return new CrohnD(54932, 0, 25.15, 157, "c2", "F", 39, 62, "d2");
                yield return new CrohnD(54933, 2, 26.45, 165, "c2", "F", 73, 72, "placebo");
                yield return new CrohnD(54934, 1, 19.11, 150, "c2", "F", 49, 43, "d2");
                yield return new CrohnD(54935, 1, 44.06, 158, "c2", "F", 47, 110, "d1");
                yield return new CrohnD(54936, 0, 25.81, 155, "c2", "F", 66, 62, "d1");
                yield return new CrohnD(54937, 1, 24.01, 162, "c2", "F", 53, 63, "d2");
            }
        }
    }
}
