using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CustomApp
{
    class Program
    {


        static void Main(string[] args)
        {



            //
            //PersonCollection myPeoples = new PersonCollection();
            // myPeoples.AddPerson(new Person("Igor","Bukur", 22));
            //myPeoples.AddPerson(new Person("Vlad", "Musica", 19));

            //foreach (Person p in myPeoples)
            //  Console.WriteLine(p);
            //

            ObservableCollection<Person> people = new ObservableCollection<Person>
            {
                new Person { FirstName = "Igor", LastName = "Bukur", Age = 22 },
                new Person { FirstName = "Vlad", LastName = "Musica", Age = 19 },
            };

            people.CollectionChanged += people_CollectionChanged;



            people.Add(new Person("Kekw", "Loles", 20));
            people.RemoveAt(1);


            Console.ReadLine();
        }

        static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old item: ");
                foreach (Person P in e.OldItems)
                {
                    Console.WriteLine(P.ToString());
                }
                Console.WriteLine();
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}
