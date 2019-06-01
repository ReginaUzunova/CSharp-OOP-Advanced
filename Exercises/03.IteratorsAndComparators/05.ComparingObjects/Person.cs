using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IPerson
    {
        private string name;
        private string age;
        private string town;

        public Person(string name, string age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        public int CompareTo(IPerson other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);

                if (result == 0)
                {
                    result = this.Town.CompareTo(other.Town);
                }
            }

            return result;
        }
    }
}
