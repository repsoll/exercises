using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.March20.Enums;

namespace Test.March20
{
    public class ZooManager
    {
        private List<Animals> animals = new List<Animals>();
        private int nextAnimalId = 1;

        public async Task AddAnimalAsync()
        {
            Console.WriteLine("Add new Animal");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Habitat Type Jungle = 1, Savanna = 2, Forest = 3:");
            HabitatType habitatType = (HabitatType)Enum.Parse(typeof(HabitatType), Console.ReadLine());
            Console.WriteLine("Diet Type Herbivore = 1, Carnivore = 2, Omnivore = 3:");
            DietType dietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());

            int animalId = nextAnimalId++;
            var newPet = new Animals
            {
                Name = name,
                AnimalID = animalId,
                Age = age,
                HabitatType = habitatType,
                DietType = dietType
            };
            animals.Add(newPet);

            await Task.Delay(200);
        }

        public async Task GetAnimalsAsync()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal ID: {animal.AnimalID}, Name: {animal.Name}, Age: {animal.Age}, Habitat Type: {animal.HabitatType}, Diet Type: {animal.DietType}");
            }
        }

        public async Task DeleteAnimalAsync()
        {
            Console.WriteLine("Enter animal ID to delete:");
            int animalId = Convert.ToInt32(Console.ReadLine());


            var indexToRemove = animals.FindIndex(animal => animal.AnimalID == animalId);

            if (indexToRemove != -1)
                animals.RemoveAt(indexToRemove);
            else
                Console.WriteLine("Not found");
            await Task.Delay(200);
        }

        public async Task UpdateAnimalAsync()
        {
            Console.WriteLine("Enter animal ID to update:");
            int animalId = Convert.ToInt32(Console.ReadLine());

            var animalToUpdate = animals.FirstOrDefault(animal => animal.AnimalID == animalId);
            if (animalToUpdate != null)
            {
                Console.WriteLine("Select property to update:");
                Console.WriteLine("1.Name");
                Console.WriteLine("2.Age");
                Console.WriteLine("3.Habitat Type");
                Console.WriteLine("4.Diet Type");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("New name:");
                        animalToUpdate.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("New name:");
                        animalToUpdate.Age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("New name:");
                        animalToUpdate.HabitatType = (HabitatType)Enum.Parse(typeof(HabitatType), Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("New name:");
                        animalToUpdate.DietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());
                        break;
                }
            }
            else
                Console.WriteLine("Animal not found");
            await Task.Delay(200);
        }
    }
}
