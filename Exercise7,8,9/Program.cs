class Exercise7_8_9
{
    static void Main(string[] args)
    {
        //Exercise7 & 8 & 9
        int num2 = 0;
        int num3 = 0;
        int endseq = 0;
        Console.WriteLine("enter 0 to exit the program");
        for (int count = 0; count < 5;)
        {
            Console.Write("please enter a number: ");
            string str1 = Console.ReadLine();
            int num1;
            bool parsesuccess1 = Int32.TryParse(str1, out num1);
            if (parsesuccess1)
            {
                num2 += num1;
                if (num1 > num3)
                {
                    num3 = num1;
                }
                if (num1 == endseq)
                {
                    count += 5;
                    break;
                }
            }
            else
            {
                Console.WriteLine("invalid number entered!\n\n");
            }
        }
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}