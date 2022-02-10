class Exercise3
{
    static void Main(string[] args)
    {
        //Exercise3
        Console.WriteLine("Please enter information about your company as is specified below");
        Console.Write("Company's Name:");
        string companyName = Console.ReadLine();
        Console.Write("Address:       ");
        string address = Console.ReadLine();
        Console.Write("Phone No:      ");
        long phoneNo = long.Parse(Console.ReadLine());
        Console.Write("Fax Number:    ");
        long faxNo = long.Parse(Console.ReadLine());
        Console.Write("Website:       ");
        string website = Console.ReadLine();
        Console.Write("Manager:       ");
        string mgr = Console.ReadLine();

        Console.WriteLine("\n\n\n=============================================================================================");
        Console.WriteLine("Please tell me more about " + mgr);
        Console.Write("First Name:    ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name:     ");
        string lastName = Console.ReadLine();
        Console.Write("Phone No:      ");
        long mgrPhoneNo = long.Parse(Console.ReadLine());

        Console.WriteLine("\n\n\n\n\n\n\n\t\t\t\t\tFINAL REPORT");
        Console.WriteLine("Company's Name:          " + companyName);
        Console.WriteLine("Address:                 " + address);
        Console.WriteLine("Phone No:                {0:(234) ### ### ####}", phoneNo);
        Console.WriteLine("Fax Number:              {0:(234) ### #### ###}", faxNo);
        Console.WriteLine("Website:                 " + website);
        Console.WriteLine("Manager:                 " + mgr);
        Console.WriteLine("=============================================================================================");
        Console.WriteLine("Manager's First Name:    " + firstName);
        Console.WriteLine("Manager's Last Name:     " + lastName);
        Console.WriteLine("Manager's Phone No:      {0:(234) ### ### ####}", mgrPhoneNo);

    }
}