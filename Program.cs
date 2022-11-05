// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

Console.Write("Mata in din ålder: ");

string input = Console.ReadLine();

/*int age = 0;

try
{
    age = int.Parse(input);
}
catch
{
    Console.WriteLine("Fel på inmatad ålder");
}

age = age + 10;

Console.WriteLine("Om tio år är du " + age);
*/


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}


