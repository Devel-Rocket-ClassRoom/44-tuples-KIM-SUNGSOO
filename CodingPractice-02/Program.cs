using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        Prac_3();
        //Prac_4();
        //Prac_5();
        //Prac_6();
        //Prac_7();
        //Prac_8();   
        //Prac_9();
    }

    static void Prac_1()
    {
        var t = Tally();
        Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");
        static (int, int) Tally()
        {
            var result = (12, 3);
            return result;
        }
    }
    static void Prac_2()
    {
        var c = Calculator();
        Console.WriteLine($"합계 {c.Sum}, 개수: {c.Count}");

        (int Sum, int Count) Calculator()
        {
            var result = (45, 6);
            return result;
        }
    }
    static void Prac_3()
    {
        var pair = GetPair();
        Console.WriteLine($"{pair.first}, {pair.second}");
        (int first, int second) GetPair() => (100, 200);
    }
    static void Prac_4()
    {
        int[] data = { 5, 2, 8, 1, 9, 3 };
        var result = FindMinMax(data);
        Console.WriteLine($"최솟값: {result.min}, 최댓값: {result.max}");
        (int min, int max) FindMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            return (min, max);
        }
    }
    static void Prac_5()
    {
        var zeros = ZeroZero();
        Console.WriteLine($"{zeros.Item1}, {zeros.Item2}");
        static (int, int) ZeroZero() => default;
    }
    static void Prac_6()
    {
        var bob = ("Bob", 23);

        (string name, int age) = bob;

        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"나이: {age}");
    }
    static void Prac_7()
    {
        var (sum, count) = Tally();
        Console.WriteLine($"Sum: {sum}, Count: {count}");
        static (int, int) Tally() => (12, 3);
        
    }
    static void Prac_8()
    {
        string firstName = "";
        int userAge = 0;
        var person = ("Alice", 30);

        (firstName, userAge) = person;

        Console.WriteLine($"{firstName}, {userAge}");
    }
    static void Prac_9()
    {
        var (_, age, _) = GetPerson();
        Console.WriteLine($"나이: {age}");

        static (string name, int age, char gender) GetPerson() => ("Bob", 23, 'M');
    }

}