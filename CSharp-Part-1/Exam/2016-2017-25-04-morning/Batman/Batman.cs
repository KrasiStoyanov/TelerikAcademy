namespace Batman
{
    using System;

    public class Batman
    {
        public static void Main()
        {
            int sizeOfLogo = int.Parse(Console.ReadLine());
            int characterToRepresent = Console.Read();
            char characterFromUser = (char)characterToRepresent;
            if (sizeOfLogo % 2 == 1)
            {
                if (sizeOfLogo >= 5 && sizeOfLogo <= 51)
                {
                    if (characterToRepresent >= 33 && characterToRepresent <= 64)
                    {
                        int j = 0;
                        int counter = 2;
                        for (int i = 0; i < sizeOfLogo - 2; i++)
                        {
                            if (i < (sizeOfLogo - 2) / 2)
                            {
                                Console.Write("{0}", new String(' ', i));
                                Console.Write("{0}", new String(characterFromUser, sizeOfLogo - i));
                                Console.Write("{0}", new String(' ', sizeOfLogo));
                                Console.Write("{0}", new String(characterFromUser, sizeOfLogo - i));
                                Console.Write("{0}", new String(' ', i));
                                Console.WriteLine();

                            }
                            else if (i == (sizeOfLogo - 2) / 2)
                            {
                                Console.Write("{0}", new String(' ', i));
                                Console.Write("{0}", new String(characterFromUser, sizeOfLogo - i));
                                Console.Write("{0}", new String(' ', (sizeOfLogo - 3) / 2));
                                Console.Write("{0}{1}{2}", characterFromUser, ' ', characterFromUser);
                                Console.Write("{0}", new String(' ', (sizeOfLogo - 3) / 2));
                                Console.Write("{0}", new String(characterFromUser, sizeOfLogo - i));
                                Console.Write("{0}", new String(' ', i));
                                Console.WriteLine();

                                j = i + 1;
                            }
                            else
                            {
                                Console.Write("{0}", new String(' ', j));
                                Console.Write("{0}", new String(characterFromUser, sizeOfLogo * 3 - 2 * j));
                                Console.Write("{0}", new String(' ', j));
                                Console.WriteLine();
                            }
                        }

                        for (int i = 0; i < sizeOfLogo / 2; i++)
                        {
                            Console.Write("{0}", new String(' ', sizeOfLogo + i + 1));
                            Console.Write("{0}", new String(characterFromUser, sizeOfLogo - counter));
                            Console.Write("{0}", new String(' ', sizeOfLogo + i + 1));
                            Console.WriteLine();

                            counter += 2;
                        }
                    }
                }
            }
        }
    }
}
