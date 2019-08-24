using HelpedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capturing a number of people's names
// Loop through and say hi to them

namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {

            //SetUpSampleData();

            //GreetAllThePeople();

            StringDemoMethod();

            Console.ReadLine();
        }

        private static void SetUpSampleData()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { FirstName = "Jill", LastName = "Jones" });
        }

        private static void StringDemoMethod()
        {
            string s = "";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            for (int i = 0; i < 100000; i++)
            {
                s += "Hi ";
                sb.Append("Hi ");
            }

            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        private static void GreetAllThePeople()
        {
            foreach (var person in people)
            {
                if (person.FirstName == "Tim")
                {
                    Console.WriteLine($"Hello { person.LastName }");
                    Console.WriteLine("How are you doing?");
                }
                else
                {
                    Console.WriteLine($"Hello { person.FirstName } { person.LastName }");
                }

                //if (person.FirstName == "Tim")
                //{

                //}

                //foreach (Person person in people)
                //{

                //}

                //for (int i = people.Count -1 ; i >= 0; i--)
                //{
                //    Console.WriteLine($"Hello { people[i].FirstName } { people[i].LastName }");
                //}
            }
        }
    }
}
