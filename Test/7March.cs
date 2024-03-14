/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test;

namespace Test
{
    public class _7March
    {

         List<Person> people = new List<Person>();

        public void Run()
        {
            int a = 0;
            do
            {
                Console.WriteLine("1.Create new person\n2.Show List\n3.Delete by name\n4.Change person details\n5. End");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                       AddPerson(people);
                        break;
                    case 2:
                        ShowList(people);
                        break;
                    case 3:
                        DeleteByNAme(people);
                        break;
                    case 4:
                        ChangeDATA(); 
                        break;  
                    case 5:
                        Console.WriteLine("Exiting program.");
                        break;
                }
            } while (a != 5);

        }

        private void AddPerson(List<Person> people)
        {
            Console.WriteLine("Enter person name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter person age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter person gender (Male(1)/Female(2)):");
            Gender sex;

            var d = Enum.Parse(typeof(Gender), Console.ReadLine());


            var person = new Person(name, age, (Gender)d);
            people.Add(person);
        }

       private void ShowList(List<Person> people)
        {
            Console.WriteLine("List:");
            foreach (Person person in people)
            {
                person.ShowDta();
            }
        }
        private void ChangeDATA()
        {
            Console.WriteLine("List:");
            foreach (Person person in people)
            {
                person.ShowDta();
            }

            Console.WriteLine("Enter person u want to change:");
            string personToChange = Console.ReadLine();

            Person personChange = null;

            foreach (Person person in people)
            {
                if (person.name == personToChange)
                {
                    personChange = person;
                    break;
                }
            }

            if (personToChange != null)
            {
                Console.WriteLine($"Data for {personToChange}: {personChange.name} {personChange.age} {personChange.sex}");

                Console.WriteLine("Enter new age:");
                int newAge = Convert.ToInt32(Console.ReadLine());
                personChange.age = newAge;

                Console.WriteLine("Enter new gender (Male(1)/Female(2)):");
                var newGender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
                personChange.sex = newGender;

                Console.WriteLine("Data updated");
            }
            else 
            {
                Console.WriteLine("Person not found");
            }
            
        }
        private void DeleteByNAme(List<Person> people) 
        {
            Console.WriteLine("List:");
            foreach (Person person in people)
            {
                person.ShowDta();
            }

            Console.WriteLine("Enter the name to delete:");
            string nameToDelete = Console.ReadLine();

            Person personToDelete = null;

            foreach (Person person in people)
            {
                if (person.name == nameToDelete)
                {
                    personToDelete = person;
                    break; 
                }
            }

            if (personToDelete != null)
            {
                people.Remove(personToDelete);
                Console.WriteLine($"{nameToDelete} has been deleted.");
            }
            else
            {
                Console.WriteLine($"{nameToDelete} not found in the list.");
            }
        }
  
    }
}
*/