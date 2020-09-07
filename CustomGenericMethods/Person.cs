using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Person : IComparable
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name {FirstName} {LastName}, Age: {Age}";
        }

        int IComparable.CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp != null)
            {
                if (this.Age > temp.Age)
                {
                    return 1;
                }
                if (this.Age < temp.Age)
                {
                    return -1;
                }
                else return 0;
            }
            else
                throw new ArgumentException("Error");
        }
    }
}
