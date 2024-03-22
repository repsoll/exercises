using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Test.March20.Enums;

namespace Test.March20
{
    public class March20
    {
        private readonly ZooManager zooManager = new ZooManager();

        public async Task RunAsync()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add new animal");
                Console.WriteLine("2. Show animal list");
                Console.WriteLine("3. Delete animal by ID");
                Console.WriteLine("4. Update animal");
                Console.WriteLine("5. End");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        await zooManager.AddAnimalAsync();
                        break;
                    case 2:
                        await zooManager.GetAnimalsAsync();
                        break;
                    case 3:
                        await zooManager.DeleteAnimalAsync();
                        break;
                    case 4:
                        await zooManager.UpdateAnimalAsync();
                        break;
                    case 5:
                        Console.WriteLine("Ending");
                        break;
                }
            } while (choice != 5);
        }
    }
}
