namespace CompanyInfo
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            sbyte managerAge = sbyte.Parse(Console.ReadLine());
            string managerPhoneNumber = Console.ReadLine();

            if (faxNumber.Length == 0)
            {
                faxNumber = "(no fax)";
            }

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", 
                companyName, companyAddress, phoneNumber, faxNumber, website, managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
    }
}
