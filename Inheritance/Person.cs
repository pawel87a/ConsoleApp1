using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person 
    {
        public string FirstName { get; set; }

        public Person() { }

        public Person (string firstName)
        {
            FirstName = firstName;
        }

        public virtual void Print()
        {
            Console.WriteLine(FirstName);
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}";
        }
    }

    public class Student : Person
    {
        public string IndexId { get; set; }

        public Student() : base() { }

        public Student(string firstName, string indexId): base(firstName)
        { 
            IndexId = indexId;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(IndexId);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nIndexId: {IndexId}";
        }
    }
}
