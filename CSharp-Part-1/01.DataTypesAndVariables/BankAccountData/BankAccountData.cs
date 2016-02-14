namespace BankAccountData
{
    using System;

    public class BankAccountData
    {
        public static void Main()
        {
            string firstName = "Krasi";
            string middleName = "Kirilov";
            string lastName = "Stoyanov";
            long balance = 123456789;
            string bankName = "Some Bank";
            uint iban = 123456789;
            long firstCardNumber = 1234567812345678;
            long secondCardNumber = 2345678923456789;
            long thirdCardNumber = 3456789034567890;

            Console.WriteLine("First name: {0}" + "\n" + "Middle name: {1}" + "\n" + "Last name: {2}" + "\n" + "Balance: {3}" + "\n" + 
                "Bank name: {4}" + "\n" + "IBAN: {5}" + "\n" + "First Card Number: {6}" + "\n" + "Second Card Number: {7}" + "\n" + "Third Card Number: {8}",
                firstName, middleName, lastName, balance, bankName, iban, firstCardNumber, secondCardNumber, thirdCardNumber);
        }
    }
}
