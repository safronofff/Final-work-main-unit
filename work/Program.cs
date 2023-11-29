/* Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Commands();
string[] array = new string[] { };

string NumArray = ReadInput("Введите номер массива: ");
switch (NumArray)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{NumArray} - Команда отсутствует");
        break;
}

int lenArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
        lenArray++;
}

string[] newArray = new string[lenArray];
int x = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[x] = array[i];
        x++;
    }
}

// Функция вывода команды для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Выбор массива:");
    Console.WriteLine("1 массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

// Функция ввода номера выбранного массива
string ReadInput(string arnum)
{
    Console.Write(arnum);
    return Console.ReadLine();
}

//  Функция вывода сформированного массива  в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);
