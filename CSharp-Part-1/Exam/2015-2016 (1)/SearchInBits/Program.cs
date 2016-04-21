namespace SearchInBits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int index = 0; index < n; index++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int position = 0; position <= 26; position++)
                {
                    bool match = true;
                    for (int j = 0; j <= 3; j++)
                    {
                        var positionInNumber = position + j;
                        var positionInS = j;

                        int bitInNumber = (num & (1 << positionInNumber)) >> positionInNumber;
                        int bitInS = (s & (1 << positionInS)) >> positionInS;

                        if (bitInNumber != bitInS)
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
