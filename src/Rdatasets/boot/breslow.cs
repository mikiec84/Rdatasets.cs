// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Smoking Deaths Among Doctors
    /// </summary>

    public class breslow
    {
        public readonly int age;
        public readonly int smoke;
        public readonly int n;
        public readonly int y;
        public readonly int ns;

        public breslow(int age, int smoke, int n, int y, int ns)
        {
            this.age = age;
            this.smoke = smoke;
            this.n = n;
            this.y = y;
            this.ns = ns;
        }

        public static IEnumerable<breslow> Data
        {
            get
            {
                yield return new breslow(40, 0, 18790, 2, 0);
                yield return new breslow(50, 0, 10673, 12, 0);
                yield return new breslow(60, 0, 5710, 28, 0);
                yield return new breslow(70, 0, 2585, 28, 0);
                yield return new breslow(80, 0, 1462, 31, 0);
                yield return new breslow(40, 1, 52407, 32, 52407);
                yield return new breslow(50, 1, 43248, 104, 43248);
                yield return new breslow(60, 1, 28612, 206, 28612);
                yield return new breslow(70, 1, 12663, 186, 12663);
                yield return new breslow(80, 1, 5317, 102, 5317);
            }
        }
    }
}
