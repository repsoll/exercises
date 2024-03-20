using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.March20.Enums;

namespace Test.March20
{
    public class March20
    {
        List<Animals> animals = new List<Animals>();              

        public void Run()
        {
            int n;
            do
            {
                Console.WriteLine("1.Add new animal to zoo.\n2.Show animal list.\n3. Delete by Id\n4.U[date animal\n5.End");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        AddAnimal();
                        break;
                    case 2:
                        ShowList();
                        break;
                    case 3:
                        DeleteAnimal();
                        break;
                    case 4:
                        UpdateAnimals();
                        break;
                    case 5:
                        Console.WriteLine("Ending");
                        break;
                }
            } while (n != 5);

            void AddAnimal()
            {
                Console.WriteLine("Add new Animal");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Id:");
                int animalId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Habitat:  \nJungle = 1,\nSavanna = 2,\nForest = 3");
                Habitat habitat = (Habitat)Enum.Parse(typeof(Habitat), Console.ReadLine());
                Console.WriteLine("Diet type: \nHerbivore = 1,\nCarnivore = 2,\nOmnivore = 3");
                DietType dietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());

                Animals newPet = new Animals()
                {
                    Name = name,
                    AnimalID = animalId,
                    Age = age,
                    DietType = dietType,
                    Habitat = habitat
                };
                animals.Add(newPet);
            }

            void ShowList()
            {
                foreach (var animal in animals)
                {
                    Console.WriteLine($"Animal ID: {animal.AnimalID}, Name: {animal.Name}, Age: {animal.Age}, Habitat:{animal.Habitat}, Diet type:{animal.DietType} ");
                }
            }

            void DeleteAnimal()
            {
                Console.WriteLine("Enter petId u want to delete");
                int m = Convert.ToInt32(Console.ReadLine());

                int index = animals.FindIndex(animal => animal.AnimalID == m);
                if (index != -1)
                {
                    animals.RemoveAt(index);
                    Console.WriteLine("Deleted");
                }
                else 
                    Console.WriteLine("Pet not found");
            }

            void UpdateAnimals()
            {
                Console.WriteLine("Enter pet Id u want to update:");
                int idToUpdate = Convert.ToInt32(Console.ReadLine());

                Animals index = animals.FirstOrDefault(animal => animal.AnimalID == idToUpdate);

                if (index != null) 
                {
                    Console.WriteLine("Select property to update:\n1.Name\n2.Age\n3.Habitat\n4.Diet Type");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("New Name:");
                            index.Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter new age:");
                            index.Age = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter new habitat (Jungle = 1, Savanna = 2, Forest = 3):");                           
                            Habitat newHabitat = (Habitat)Enum.Parse(typeof(Habitat), Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter new habitat (Jungle = 1, Savanna = 2, Forest = 3):");
                            DietType newDietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());
                            break;
                    }
                    Console.WriteLine("Animal updated successfully:");
                }
                else
                    Console.WriteLine($"Animal with ID {idToUpdate} not found.");
            }
        }
    }
}
