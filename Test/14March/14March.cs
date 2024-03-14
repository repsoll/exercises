using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._14March
{
    public class _14March
    {
        List<Student> students = new List<Student>
        {
            new Student{ Name = "Bob", Age = 21, AverageMark = 4.4 },
            new Student{ Name = "Tom", Age = 28, AverageMark = 3.9 },
            new Student{ Name = "Alice", Age = 18, AverageMark = 5 },
            new Student{ Name = "Mark", Age = 19, AverageMark = 2.5 },
            new Student{ Name = "Mary", Age = 26, AverageMark = 4.7 },
            new Student{ Name = "David", Age = 16, AverageMark = 4.1 },
            new Student{ Name = "Frank", Age = 20, AverageMark = 2.6 },
            new Student{ Name = "Eva", Age = 23, AverageMark = 3 },
            new Student{ Name = "Charlie", Age = 17, AverageMark = 4.2 },
            new Student{ Name = "Justin", Age = 26, AverageMark = 5 }
        };
        public void Run()
        {
           var OlderAge = students.Where(students => students.Age > 20 );
           Console.WriteLine("Students with age 20+");
           foreach ( var student in OlderAge)
           {
                Console.Write($" {student.Name}  {student.Age} , ");
           }
            Console.WriteLine();

            var SortByAveregeMarkDescending = students.OrderByDescending(students => students.AverageMark);
            Console.WriteLine("Students Sort By Average Mark By Descending");
            foreach ( var student in SortByAveregeMarkDescending)
            {
               Console.Write($" {student.Name}  {student.AverageMark} , ");
            }
            Console.WriteLine();

            var AgeAverage = students.Average(students => students.Age);
            Console.WriteLine($"Average Students Age {AgeAverage} ");

            var groupedStudentsByAge = students.GroupBy(student =>
            {
                if (student.Age >= 15 && student.Age < 20)
                    return "15-20";
                else if (student.Age >= 20 && student.Age < 25)
                    return "20-25";
                else if (student.Age >= 25 && student.Age < 30)
                    return "25-30";
                else
                    return "30+";
            });

            Console.WriteLine("Students Grouped By Age Range:");
            foreach (var group in groupedStudentsByAge)
            {
                Console.WriteLine($"Age Range: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($" {student.Name}  {student.Age} , ");
                }
            }
        }
    }
}
