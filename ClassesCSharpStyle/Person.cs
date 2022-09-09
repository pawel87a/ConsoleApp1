using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    // Person niech ma Name i Age
    public class Person
    {

        //auto-property
        public string Name { get; set; }

        // backing field
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 200)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Wrong value.");
                }
            }
        }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age; 
        }


    }
}
