using System;

class EnterCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone number: ");
        string companyPnone = Console.ReadLine();

        Console.WriteLine("Enter company fax number:  ");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Enter company website: ");
        string companyWesite = Console.ReadLine();

        Console.WriteLine("Enter managers first name: ");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter managers last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Enter managers age: ");
        string managerAge = Console.ReadLine();

        Console.WriteLine("Enter managers phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Company information : ");
        Console.WriteLine();
        Console.WriteLine("name: {0} \naddress: {1} \nphone number: {2} \nfax number: {3} \nwebsite: {4}", companyName, companyAddress, companyPnone, companyFax, companyWesite);
        Console.WriteLine();
        Console.WriteLine("Manager information : ");
        Console.WriteLine();
        Console.WriteLine("name: {0} {1} \nage: {2} \nphone number: {3}", managerFirstName, managerLastName, managerAge, managerPhone);
        Console.WriteLine();
        
    }
}

