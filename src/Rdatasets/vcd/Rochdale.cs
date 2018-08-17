// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Rochdale Data
    /// </summary>

    public class Rochdale
    {
        public readonly string EconActive;
        public readonly string Age;
        public readonly string HusbandEmployed;
        public readonly string Child;
        public readonly string Education;
        public readonly string HusbandEducation;
        public readonly string Asian;
        public readonly string HouseholdWorking;
        public readonly int Freq;

        public Rochdale(string EconActive, string Age, string HusbandEmployed, string Child, string Education, string HusbandEducation, string Asian, string HouseholdWorking, int Freq)
        {
            this.EconActive = EconActive;
            this.Age = Age;
            this.HusbandEmployed = HusbandEmployed;
            this.Child = Child;
            this.Education = Education;
            this.HusbandEducation = HusbandEducation;
            this.Asian = Asian;
            this.HouseholdWorking = HouseholdWorking;
            this.Freq = Freq;
        }

        public static IEnumerable<Rochdale> Data
        {
            get
            {
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "yes", "yes", "yes", 1);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "no", "no", "yes", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "no", "yes", "yes", 2);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "no", "yes", "yes", 1);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "no", "yes", "yes", 1);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "no", "yes", "yes", 1);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "no", "yes", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "no", "no", "no", "yes", "yes", 1);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "yes", "no", "yes", 2);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "yes", "no", "yes", 3);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "yes", "no", "yes", 22);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "yes", "no", "yes", 6);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "yes", "no", "yes", 1);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "yes", "no", "yes", 4);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "yes", "no", "yes", 1);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "yes", "no", "yes", 26);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "yes", "no", "yes", 7);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "yes", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "yes", "no", "yes", 1);
                yield return new Rochdale("no", ">38", "no", "no", "no", "yes", "no", "yes", 1);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "no", "no", "yes", 2);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "no", "no", "yes", 1);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "no", "no", "yes", 10);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "no", "no", "yes", 2);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "no", "no", "yes", 1);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "no", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "no", "no", "yes", 1);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "no", "no", "yes", 1);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "no", "no", "yes", 3);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "no", "no", "yes", 25);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "no", "no", "yes", 10);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "no", "no", "yes", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "no", "no", "yes", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "no", "no", "yes", 4);
                yield return new Rochdale("no", ">38", "no", "no", "no", "no", "no", "yes", 7);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "yes", "yes", "no", 1);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "yes", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "yes", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "yes", "yes", "no", 2);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "yes", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "yes", "yes", "no", 1);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "yes", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "yes", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "yes", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "no", "no", "yes", "yes", "no", 2);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "no", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "no", "yes", "no", 1);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "no", "yes", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "no", "yes", "no", 11);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "no", "yes", "no", 2);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "no", "yes", "no", 8);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "no", "yes", "no", 3);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "no", "yes", "no", 2);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "no", "yes", "no", 2);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "no", "yes", "no", 1);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", "<38", "no", "no", "no", "no", "yes", "no", 2);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "no", "yes", "no", 0);
                yield return new Rochdale("no", ">38", "no", "no", "no", "no", "yes", "no", 3);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "yes", "no", "no", 29);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "yes", "no", "no", 26);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "yes", "no", "no", 3);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "yes", "no", "no", 57);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "yes", "no", "no", 6);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "yes", "no", "no", 43);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "yes", "no", "no", 10);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "yes", "no", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "yes", "no", "no", 2);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "yes", "no", "no", 1);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "yes", "no", "no", 11);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "yes", "no", "no", 13);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "yes", "no", "no", 2);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "yes", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "yes", "no", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "yes", "no", "no", 6);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "yes", "no", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "yes", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "yes", "no", "no", 23);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "yes", "no", "no", 5);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "yes", "no", "no", 37);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "yes", "no", "no", 16);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "yes", "no", "no", 4);
                yield return new Rochdale("no", "<38", "no", "no", "no", "yes", "no", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "yes", "no", "no", 2);
                yield return new Rochdale("no", ">38", "no", "no", "no", "yes", "no", "no", 1);
                yield return new Rochdale("yes", "<38", "yes", "yes", "yes", "no", "no", "no", 11);
                yield return new Rochdale("no", "<38", "yes", "yes", "yes", "no", "no", "no", 3);
                yield return new Rochdale("yes", ">38", "yes", "yes", "yes", "no", "no", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "yes", "no", "no", "no", 1);
                yield return new Rochdale("yes", "<38", "no", "yes", "yes", "no", "no", "no", 0);
                yield return new Rochdale("no", "<38", "no", "yes", "yes", "no", "no", "no", 1);
                yield return new Rochdale("yes", ">38", "no", "yes", "yes", "no", "no", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "yes", "no", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "yes", "no", "no", "no", 22);
                yield return new Rochdale("no", "<38", "yes", "no", "yes", "no", "no", "no", 4);
                yield return new Rochdale("yes", ">38", "yes", "no", "yes", "no", "no", "no", 15);
                yield return new Rochdale("no", ">38", "yes", "no", "yes", "no", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "no", "no", "yes", "no", "no", "no", 1);
                yield return new Rochdale("no", "<38", "no", "no", "yes", "no", "no", "no", 0);
                yield return new Rochdale("yes", ">38", "no", "no", "yes", "no", "no", "no", 0);
                yield return new Rochdale("no", ">38", "no", "no", "yes", "no", "no", "no", 1);
                yield return new Rochdale("yes", "<38", "yes", "yes", "no", "no", "no", "no", 5);
                yield return new Rochdale("no", "<38", "yes", "yes", "no", "no", "no", "no", 8);
                yield return new Rochdale("yes", ">38", "yes", "yes", "no", "no", "no", "no", 0);
                yield return new Rochdale("no", ">38", "yes", "yes", "no", "no", "no", "no", 1);
                yield return new Rochdale("yes", "<38", "no", "yes", "no", "no", "no", "no", 1);
                yield return new Rochdale("no", "<38", "no", "yes", "no", "no", "no", "no", 4);
                yield return new Rochdale("yes", ">38", "no", "yes", "no", "no", "no", "no", 0);
                yield return new Rochdale("no", ">38", "no", "yes", "no", "no", "no", "no", 0);
                yield return new Rochdale("yes", "<38", "yes", "no", "no", "no", "no", "no", 18);
                yield return new Rochdale("no", "<38", "yes", "no", "no", "no", "no", "no", 5);
                yield return new Rochdale("yes", ">38", "yes", "no", "no", "no", "no", "no", 41);
                yield return new Rochdale("no", ">38", "yes", "no", "no", "no", "no", "no", 17);
                yield return new Rochdale("yes", "<38", "no", "no", "no", "no", "no", "no", 3);
                yield return new Rochdale("no", "<38", "no", "no", "no", "no", "no", "no", 5);
                yield return new Rochdale("yes", ">38", "no", "no", "no", "no", "no", "no", 2);
                yield return new Rochdale("no", ">38", "no", "no", "no", "no", "no", "no", 4);
            }
        }
    }
}
