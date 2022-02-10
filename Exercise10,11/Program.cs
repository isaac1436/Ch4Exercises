class Exercise10_11
{
    static void Main(string[] args)
    {
        //Exercise10
        Console.Write("please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int count = 1; count <= num; count++)
        {
            Console.WriteLine(count);
        }

        //Exercise11
        int num = 0;
        int num2 = 1;
        int num3 = 0;
        Console.WriteLine("The first 100 numbers in the fibonacci sequence are");
        for (int count = 0; count <= 100; count++)
        {
            Console.Write(num + ", ");
            num3 = num;
            num += num2;
            num2 = num3;
        }
    }
}