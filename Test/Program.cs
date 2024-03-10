/*string name = "Tom";
Console.WriteLine(name);

name = "Bob";
Console.WriteLine(name);

*/


/*string name = "Yana";
int age = 18;
bool isEmployed = false;
double weight = 55.55;

Console.WriteLine($"Ім'я:{name}");
Console.WriteLine($"Вік:{age}");
Console.WriteLine($"Робота:{isEmployed}");
Console.WriteLine($"Вага:{weight}");*/


/*Console.Write("Enter your name:");
string? name = Console.ReadLine();
Console.WriteLine(name);*/


/*Console.Write("Enter your name:");
string? name = Console.ReadLine();

Console.Write("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your height:");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Name:{name}\nAge:{age} \nHeight:{height}");*/


/*int x1 = 5;
int z1 = ++x1;
Console.WriteLine($"{x1} - {z1}");

int x2 = 5;
int z2 = x2++;
Console.WriteLine($"{x2} - {z2}");


int a = 3;
int b = 5;
int c = 40;
int d = (c - (--b)) * a;    // a=3  b=4  c=40  d=108
Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");*/


/*Console.WriteLine("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());

int c1 = a - b;
int c2 = a + b;
int c3 = a * b;
int c4 = a / b;

Console.WriteLine($"{a}-{b}={c1}");
Console.WriteLine($"{a}+{b}={c2}");
Console.WriteLine($"{a}*{b}={c3}");
Console.WriteLine($"{a}/{b}={c4}");*/

//
/*Console.WriteLine("Enter your age:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 18)
    Console.WriteLine("You are a minor");
else if (a >= 18 && a < 65)
    Console.WriteLine("You are an adult");
else if (a >= 65)
    Console.WriteLine("You are a pensioner");
*/

//калькулятор
/*Console.WriteLine("Enter a math action(+, -, *, /):");
char mathAction = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enrter a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enrter b:");
int b = Convert.ToInt32(Console.ReadLine());

string result;
switch (mathAction)
{
    case '+':
        result = $"{a} + {b} = {a + b}";
        break;
    case '-':
        result = $"{a} - {b} = {a - b}";
        break;
    case '*':
        result = $"{a} * {b} = {a * b}";
        break;
    case '/':
        result = $"{a} / {b} = {a / b}";
        break;
    default:
        result = "Invalid operator";
        break;
}

Console.WriteLine(result);
*/

//сумма
/*Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int n1 = 1; n1 <= n; n1++)
    sum += n1;
Console.WriteLine($"Sum:{sum}");*/

//парне не парне
/*Console.WriteLine("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

int z = n % 2;

if (z != 0)
    Console.WriteLine("Число не парне");
else
    Console.WriteLine("Число парне");*/

//Sorting !!!!
/*int[] nums = new int[5];

Console.WriteLine("Enter 5 nums");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            int z = nums[i];
            nums[i] = nums[j];
            nums[j] = z;
        }
    }
}
Console.WriteLine("Array");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
*/

//reverse
/*
int[] numb1 = { 1, 2, 3, 4, 5 };
int[] numb2 = new int [numb1.Length];

int k = numb1.Length / 2;
for (int i = 0; i < k; i++)
{
    int z = numb1[i];
    numb1[i] = numb1[numb1.Length - 1 - i];
    numb1[numb1.Length - 1 - i] = z;
}

for (int i=0 ; i<numb1.Length; i++)
{
    numb2[i] = numb1[i];
}

for (int i=0 ;i<numb2.Length; i++)
{
    Console.WriteLine(numb2[i]);
}
*/

//обєднання і викид дублікатів
/*
int[] array1 = { 1, 2, 3, 4 };
int[] array2 = { 3, 4, 5 };
int[] array3 = { 4, 5, 6, 7 };
int[] array4 = { 7, 8, 9 };

int lenght = array1.Length + array2.Length + array3.Length + array4.Length;

int newArray = 0;

int[] array5 = new int[lenght];

void Duplicate (int[] someArray, int[] finalArray, ref int newArray) 
{
    for (int i = 0; i < someArray.Length; i++)
    {
        bool isDuplicate = false;
        for (int j = 0; j < newArray; j++) 
        {
            if (someArray[i] == finalArray[j])
            {
                isDuplicate = true;
                break;
            }
        }
        if (!isDuplicate)
        {
            finalArray[newArray] = someArray[i];
            newArray++;
        }
    }
}

Duplicate(array1, array5, ref newArray);
Duplicate(array2, array5, ref newArray);
Duplicate(array3, array5, ref newArray);
Duplicate(array4, array5, ref newArray);
*/
/*for (int i = 0; i < array1.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < newArray; j++)
    {
        if (array1[i] == array5[j])
        {
            isDuplicate = true;
            break;
        }
    }
    if (!isDuplicate)
    {
        array5[newArray] = array1[i];
        newArray++;
    }
}*/

/*for (int i = 0; i < array2.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < newArray; j++)
    {
        if (array2[i] == array5[j])
        {
            isDuplicate = true;
            break;
        }
    }
    if (!isDuplicate)
    {
        array5[newArray] = array2[i];
        newArray++;
    }
}
*/

/*for (int i = 0; i < array3.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < newArray; j++)
    {
        if (array3[i] == array5[j])
        {
            isDuplicate = true;
            break;
        }
    }
    if (!isDuplicate)
    {
        array5[newArray] = array3[i];
        newArray++;
    }
}*/

/*for (int i = 0; i < array4.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < newArray; j++)
    {
        if (array4[i] == array5[j])
        {
            isDuplicate = true;
            break;
        }
    }
    if (!isDuplicate)
    {
        array5[newArray] = array4[i];
        newArray++;
    }
}*/
/*
for (int i = 0; i < array5.Length; i++)
{
    Console.WriteLine(array5[i]);
}
*/


//прості методи
/*void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x}+{y}={result}");
}

Sum(5, 12);*/

/*void PrintPerson(string name, int age, string company = "Undefined")
{
    Console.WriteLine($"Name:{name}  Age: {age} Company: {company}");
}
int b = 19;
PrintPerson("Tom", b);
PrintPerson(age: 37, name: "Bob", company: "Microsoft");*/



//крута
/*string[] students;
Console.WriteLine("1.Add Student \n2.Delete student.\n3.Show all students.");
int n = Convert.ToInt32(Console.ReadLine());
*/


//!!!
/*using Test;

Student student = new Student();

int n;

do
{
    Console.WriteLine("1. Add student.\n2. Show all students\n3. Delete student.\n4. Add subject.\n5. Delete subject.\n6. List of subjects of the selected student\n7. End");
    n = Convert.ToInt32(Console.ReadLine());

    switch (n)
    {
        case 1:
            student.AddStudent();
            break;
        case 2:
            student.ShowStudent();
            break;
        case 3:
            student.DeleteStudent();
            break;
        case 4:
            student.AddSubject();
            break;
        case 5:
            student.DeleteSubject();
            break;
        case 6:
            student.SubjectList();
            break;
        case 7:
            Console.WriteLine("Exiting program.");
            break;
    }
} while (n != 7);

*/

//сортування та генерування масиву обобщ
/*
using static System.Runtime.InteropServices.JavaScript.JSType;

Sorting<int> sort1 = new Sorting<int>();

sort1.Init(5);
 
sort1.PrintArray();

Console.WriteLine("Sorted in Ascending Order:");
sort1.SortAcs();

Console.WriteLine("Sorted in Descending Order:");
sort1.SortDesc();

Console.ReadLine();
class Sorting<T>
{
    T[] numbers;
    public void Init(int arraySize)
    {
        Random rand = new Random(); 
        numbers = new T[arraySize];


        for (int i = 0; i < arraySize; i++) 
        {
            numbers[i] = (T)(object)rand.Next(0, 9);
        }
    }
    public void PrintArray()
    {
        Console.WriteLine("Array:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    public void SortAcs()
    {
        Array.Sort(numbers, Comparer<T>.Default);
        for (int i = 0; i < numbers.Length; i++)
        {
                Console.WriteLine(numbers[i]);
        }
    }
    public void SortDesc()
    {
        Array.Sort(numbers, Comparer<T>.Default);
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
         {
                Console.WriteLine(numbers[i]);
         }
    }
}
*/

using System.Reflection;
using Test;

var asd = new _7March();
asd.Run();

