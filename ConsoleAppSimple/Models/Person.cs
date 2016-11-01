using System;

namespace ConsoleAppSimple.Models
{
    public class Person
    {
        private int _age;

        public Person(int age)
        {
            _age = age;
        }

        public Person() : this(0)
        {            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        
        public int Age { get { return _age; } }

        public void MakeOlder(int years)
        {
            _age += years;
        }

        public override string ToString()
        {
            return String.Format("FullName: {0}, Age: {1}", FullName, Age);
        }
    }
}