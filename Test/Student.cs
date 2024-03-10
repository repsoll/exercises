/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Subjects { get; set; }

        public Student(string name = "Undefined", int age = 0, string[] subjects = null)
        {
            this.Name = name;
            this.Age = age;
            this.Subjects = subjects;
        }
        string[] student = new string[0];
        string[] subject = new string[0];
        public void AddStudent()
        {
            Console.WriteLine("Enter new student name:");
            string studName = Console.ReadLine();
            Array.Resize(ref student, student.Length + 1);
            student[student.Length - 1] = studName;
            Console.WriteLine($"New student: {studName}");
        }
        public void ShowStudent()
        {
            Console.WriteLine($"All students: {string.Join(", ", student)}");
        }
        public void DeleteStudent()
        {
            Console.WriteLine("Enter the student number to delete:");
            Console.WriteLine(string.Join(", ", student));

            int studentNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (studentNumber >= 0 && studentNumber < student.Length)
            {
                string[] newStudentArray = new string[student.Length - 1];

                for (int i = 0, j = 0; i < student.Length; i++)
                {
                    if (i != studentNumber)
                    {
                        newStudentArray[j] = student[i];
                        j++;
                    }
                }
                student = newStudentArray;
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid student number.");
            }
        }
        public void AddSubject()
        {
            Console.WriteLine($"Choose a student: {string.Join(", ", student)}");
            int studAddSubj = Convert.ToInt32(Console.ReadLine());

            if (studAddSubj >= 1 && studAddSubj <= student.Length)
            {
                Console.WriteLine("Enter the subject tot add");
                string newSubj = Console.ReadLine();

                //ств новий масив
                string[] newSubjArray = new string[subject.Length + 1];
                //скопіювали
                for (int i = 0; i < subject.Length; i++)
                {
                    newSubjArray[i] = subject[i];
                }

                int studentIndex = studAddSubj - 1;
                newSubjArray[subject.Length] = $"{studentIndex}  -  {newSubj}";

                subject = newSubjArray;

                Console.WriteLine($"New subject ({newSubj}) added for {student[studentIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid student number.");
            }
        }
        public void DeleteSubject()
        {
            Console.WriteLine("Choose a student");
            Console.WriteLine(string.Join(", ", student));

            int studentNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (studentNumber >= 0 && studentNumber < student.Length)
            {
                Console.WriteLine("Choose subject to delete");
                Console.WriteLine(string.Join(",", subject.Select((s, index) => $"{index + 1}. {s}")));

                int subjectNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                if (subjectNumber >= 0 && subjectNumber < subject.Length)
                {
                    //!!!!!!remove
                    string[] newSubjArray = new string[subject.Length - 1];

                    for (int i = 0, j = 0; i < subject.Length; i++)
                    {
                        if (i != subjectNumber)
                        {
                            newSubjArray[j] = subject[i];
                            j++;
                        }
                    }

                    subject = newSubjArray;
                    Console.WriteLine("Subject deleted");
                }
                else
                    Console.WriteLine("Invalid subject number");

            }
            else
                Console.WriteLine("Invalid student number");
        }

        public void SubjectList()
        {
            Console.WriteLine($"Choose a student: {string.Join(", ", student)}");
            int studentNumber = Convert.ToInt32(Console.ReadLine());

            if (studentNumber >= 1 && studentNumber <= student.Length)
            {
                int studentIndex = studentNumber - 1;

                string[] studentSubject = new string[0];


                foreach (string subj in subject)
                {
                    if (subj.StartsWith($"{studentIndex}"))
                    {
                        Array.Resize(ref studentSubject, studentSubject.Length + 1);
                        studentSubject[studentSubject.Length - 1] = subj;
                    }

                }
                if (studentSubject.Length > 0)
                {
                    Console.WriteLine($"Subjects : {string.Join(", ", studentSubject)}");
                }
                else
                {
                    Console.WriteLine($"No subjects found for {student[studentIndex]}");
                }
            }
            else
            {
                Console.WriteLine("Invalid student number.");
            }

        }
    }
}*/
