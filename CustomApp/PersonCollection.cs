using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arrPeople = new ArrayList();
        public Person GetPerson(int pos) => (Person)arrPeople[pos];

        public void AddPerson(Person p)
        { arrPeople.Add(p); }

        public void ClearPeople() { arrPeople.Clear(); }

        public int Count => arrPeople.Count;

        IEnumerator IEnumerable.GetEnumerator() => arrPeople.GetEnumerator();

    }
}
