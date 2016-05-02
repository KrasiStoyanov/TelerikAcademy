namespace BobbyAvokadoto
{
    using System;

    public class BobbyAvokadoto
    {
        public static void Main()
        {
            uint bobbyHead = uint.Parse(Console.ReadLine());
            string headInBinary = Convert.ToString(bobbyHead, 2);
            var lengthOfHeadChars = headInBinary.Length;
            int numberOfCombs = int.Parse(Console.ReadLine());
            uint bestComb = 0;
            sbyte maxCounter = -1;
            for (int i = 0; i < numberOfCombs; i++)
            {
                sbyte counter = 0;
                uint comb = uint.Parse(Console.ReadLine());
                string combInBinary = Convert.ToString(comb, 2).PadLeft(lengthOfHeadChars, '0');
                for (int index = 0; index < lengthOfHeadChars; index++)
                {
                    var currentHeadChar = headInBinary[index];
                    var currentCombChar = combInBinary[index];
                    if (currentCombChar == '1' && currentHeadChar == '1')
                    {
                        counter = 0;
                        break;
                    }
                    else if (currentCombChar == '1' && currentHeadChar == '0')
                    {
                        counter++;
                    }
                }

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    bestComb = comb;
                }
            }

            Console.WriteLine(bestComb);
        }
    }
}
