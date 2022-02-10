using System;
class Ch4Exercises
{
    static void Main(string[] args)
    {

        //Exercise 1
        int num1, num2, num3;
        Console.Write("Please enter a number:\t");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Please enter another number:\t");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Please enter another number:\t");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers entered is " + (num1 + num2 + num3));

    }
}