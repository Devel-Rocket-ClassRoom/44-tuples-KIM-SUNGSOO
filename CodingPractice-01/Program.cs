using System;

// README.md를 읽고 코드를 작성하세요.
class codPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2_1();
        //Prac_2_2();
        //Prac_3_1();
        //Prac_3_2();
        //Prac_4();
        //Prac_5();
        //Prac_6();
        Prac_7();
    }

    static void Prac_1()
    {
        var value = ("Bob", 23);

        Console.WriteLine($"{value.Item1}");
        Console.WriteLine($"{value.Item2}");
    }
    static void Prac_2_1()
    {
        var value = (12, 34, 56);

        Console.WriteLine($"{value.Item1}, {value.Item2}, {value.Item3}");
        
    }

    static void Prac_2_2()
    {
        var value = ("Hello", 100, true, 3.14);

        Console.WriteLine($"{value.Item1}, {value.Item2}, {value.Item3}, {value.Item4}");
    }

    static void Prac_3_1()
    {
        (string, int) person = ("Alice", 25);

        Console.WriteLine($"{person.Item1}, {person.Item2}");

    }
    static void Prac_3_2()
    {
        (ushort Width, ushort Height) screen = (1920, 1080);
        Console.WriteLine($"해사아도: {screen.Width} X {screen.Height}");
    }

    static void Prac_4()
    {
        var original = ("Bob", 23);
        var copy = original;

        copy.Item1 = "Joe";

        Console.WriteLine($"원본: ({original.Item1}, {original.Item2})");
        Console.WriteLine($"복사본: ({copy.Item1}, {copy.Item2})");
    }

    static void Prac_5()
    {
        var person = (name: "Bob", age: 23);
        Console.WriteLine($"{person.name}");
        Console.WriteLine($"{person.age}");

        Console.WriteLine($"{person.Item1}");
        Console.WriteLine($"{person.Item2}");
    }

    static void Prac_6()
    {
        (string name, int age, char gender) person = ("Bob", 23, 'M');
        Console.WriteLine($"이름: {person.name}");
        Console.WriteLine($"나이: {person.age}");
        Console.WriteLine($"성별: {person.gender}");
    }

    static void Prac_7()
    {
        var now = DateTime.Now;
        var dateTuple = (now.Day, now.Month, now.Year);
        Console.WriteLine($"일: {dateTuple.Day}");
        Console.WriteLine($"월: {dateTuple.Month}");
        Console.WriteLine($"년: {dateTuple.Year}");
    }
}
