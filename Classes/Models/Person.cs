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
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public string getName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int GetAge()
        {
            return _age;
        }

        //Napisz setter dla wieku i ustawiaj wiek tylko gdy przekazany wiek jest wiekszy rowny
        //0 i mniejszy od 200
        public void SetAge(int age)
        {

            if (age >= 0 && age < 200)
            {
                _age = age;
            }
            else
            {
                throw new ArgumentException("Wrong value.");
            }
        }

    }
}
