namespace StringsAndObjects
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string helloString = "Hello";
            string worldString = "World";
            object helloWorldObject = helloString + " " + worldString + "!";
            string helloWorldString = (string)helloWorldObject;
            Console.WriteLine(helloWorldString);
        }
    }
}
