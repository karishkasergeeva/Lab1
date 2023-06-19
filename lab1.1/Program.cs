using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

//1)Написати програму, яка обчислює число голосних і приголосних букв у файлі. Шлях до файлу передавати
//як аргумент у функцію ReadFile(). Вміст текстового файлу заноситься в список символів. Кількість
//голосних і приголосних букв визначається проходом по списку. Передбачити метод, вхідним параметром
//якого є список символів. Метод обчислює кількість голосних і приголосних букв.

class Program
{
    static void Main()
    {
        string filePath = @"C:\універ\Програмування\toLab1.txt";

        List<char> charList = ReadFile(filePath);

        int vowelCount = CountVowels(charList);
        int consonantCount = CountConsonants(charList);

        Console.WriteLine($"Кількість голосних букв: {vowelCount}");
        Console.WriteLine($"Кількість приголосних букв: {consonantCount}");
    }

    // Метод для читання файлу і збереження його в списку символів
    static List<char> ReadFile(string filePath)
    {
        List<char> charList = new List<char>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            do
            {
                string line = reader.ReadLine();
                foreach (char c in line)
                {
                    charList.Add(c);
                }
            }
            while (!reader.EndOfStream);
        }
        return charList;
    }

    // Метод для обчислення кількості голосних букв
    static int CountVowels(List<char> list)
    {
        int count = 0;
        string vowels = "УуЕеЇїІіАаОоЄєЯяИиЮю";

        foreach (char item in list)
        {
            if (vowels.Contains(item.ToString()))
            {
                count++;
            }
        }

        return count;
    }

    // Метод для обчислення кількості приголосних букв
    static int CountConsonants(List<char> list)
    {
        int count = 0;
        string consonants = "ЙйЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЖжЧчМмТтБб";

        foreach (char item in list)
        {
            if (consonants.Contains(item.ToString()))
            {
                count++;
            }
        }
        return count;
    }
}


/*
//2) Дано словник. Вивести всі унікальні значення словників. Вхідний словник : [{"V":"S001"},
//{"V": "S002"}, {"VI": "S001"}, {"VI": "S005", {"VII":"S005"}, {"V":"S009"},{"VIII":"S007"}].
//Вихідний результат : UniqueValues: {'S005', 'S002', 'S007', 'S001', 'S009'}


class Program
{
    public static void Main(string[] args)
    {
// Створення вхідного списку ключ-значення
        List<KeyValuePair<string, string>> inputList = new List<KeyValuePair<string, string>>() 
        {
            new KeyValuePair<string, string>("V", "S001"),
            new KeyValuePair<string, string>("V", "S002"),
            new KeyValuePair<string, string>("VI", "S001"),
            new KeyValuePair<string, string>("VI", "S005"),
            new KeyValuePair<string, string>("VII", "S005"),
            new KeyValuePair<string, string>("V", "S009"),
            new KeyValuePair<string, string>("VIII", "S007")
        };

 // Створення множини для збереження унікальних значень
        HashSet<string> uniqueValues = new HashSet<string>(); //унікальні значення

//додавання значень до множини унікальних значень
        foreach (var item in inputList)
        {
            uniqueValues.Add(item.Value);
        }

// Виведення унікальних значень на консоль
        Console.WriteLine("UniqueValues: {" + string.Join(", ", uniqueValues) + "}");

// Перетворення множини унікальних значень в рядок JSON
        string result = JsonConvert.SerializeObject(uniqueValues);

 // Шлях до вихідного файлу
        string filePath2 = @"C:\універ\Програмування\toLab1(2).txt";

// Запис рядка JSON у файл
        File.WriteAllText(filePath2, result);
    }
}
*/


//3) Дано цифра D (однозначне ціле число) і послідовність цілих чисел A. Вивести перший додатний елемент
//послідовності A, що закінчується цифрою D. Якщо необхідних елементів в послідовності. A немає, то
//вивести 0. (1) First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
//- Count, Sum, Average, Max, Min, Aggregate (агрегування); • Range(генерування послідовностей).

/*
class Program
{    
    static void Main()
    {
 // створення випадкового об'єкта
        Random random= new Random();

// Генерація випадкового числа D в діапазоні від -10 до 10
        int D = random.Next(-10,10);
        Console.WriteLine("The number: " + D);

// Створення масиву A з числами від 1 до 20
        int[] A = Enumerable.Range(1, 20).ToArray();

 // Виведення елементів масиву A на консоль
        foreach (int num in A)
        {
            Console.WriteLine(num);
        }

// Вибір елементів масиву A, що закінчуються цифрою D
        var selectedNumb = from p in A
                             where p.ToString().EndsWith(D.ToString())
                             select p;

// Створення списку Numbers для збереження відібраних чисел
        List<int> Numbers = new List<int>();

// Додавання відібраних чисел до списку Numbers
        foreach (int c in selectedNumb)
        {
            Numbers.Add(c);
        }

// Перевірка, чи є елементи в списку Numbers
        if(Numbers.Count > 0)
        {
            Console.WriteLine("The answer: " + Numbers[0]);
        }
        else
            Console.WriteLine("The answer: 0");
    }  
}
*/
