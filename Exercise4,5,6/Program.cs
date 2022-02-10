class Exercise4_5_6
{
    static void Main(string[] args)
    {
        //Exercise4
        int hex = 0xFE;
        float @float = 0.7865f;
        float @float2 = -0.7865f;
        Console.Write(hex);
        Console.Write("       | {0:0.00}", @float);
        Console.Write("       | {0:0.00}", @float2);

        //Exercise5
        Console.Write("Please enter a number:           ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number:     ");
        int num2 = int.Parse(Console.ReadLine());
        int num3;
        for (num3 = num1; num3 <= num2; num3++)
        {
            if (num3 % 5 == 0)
            {
                Console.Write(num3 + ", ");
            }
        }
        for (num3 = num2; num3 <= num1; num3++)
        {
            if (num3 % 5 == 0)
            {
                Console.Write(num3 + ", ");
            }
        }

        //Exercise6
        Console.Write("Please enter a number:           ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number:     ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 > num2 ? (num1 + " is greater than " + num2) : (num2 + " is greater than " + num1));
    }
}