namespace EmployeeData
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Krasi";
            string lastName = "Stoyanov";
            byte age = 17;
            char gender = 'm';
            ulong personalID = 8306112507;
            uint uniqueEmployeeID = 27560000;

            Console.WriteLine("First name: {0}" + "\n" + "Last name: {1}" + "\n" + "Age: {2}" + "\n" + "Gender: {3}" + "\n" + "Personal ID: {4}" + "\n" + "Unique Employee ID: {5}",
                firstName, lastName, age, gender, personalID, uniqueEmployeeID);
        }
    }
}
