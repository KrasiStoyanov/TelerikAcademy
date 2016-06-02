namespace Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        private static void Main()
        {
            string sequence = Console.ReadLine();
            int[] movementOfKitty = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            StartCollectingSouls(sequence, movementOfKitty);
        }

        private static void StartCollectingSouls(string sequence, int[] movementOfKitty)
        {
            var soulsCount = 0;
            var foodCount = 0;
            var deadlockCount = 0;
            var kittyPosition = 0;
            var jumpsBeforeDeadlock = 0;
            StringBuilder copyOfSequence = new StringBuilder(sequence);
            if (sequence[kittyPosition] == '@')
            {
                soulsCount++;
                jumpsBeforeDeadlock++;
            }
            else if (sequence[kittyPosition] == '*')
            {
                foodCount++;
                jumpsBeforeDeadlock++;
            }
            else if (sequence[kittyPosition] == 'x')
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", jumpsBeforeDeadlock);
                return;
            }

            copyOfSequence.Remove(kittyPosition, 1);
            copyOfSequence.Insert(kittyPosition, '.');
            for (int i = 0; i < movementOfKitty.Length; i++)
            {
                var currentMovement = movementOfKitty[i];
                kittyPosition += currentMovement;
                char currentSymbol;

                kittyPosition = kittyPosition % copyOfSequence.Length;
                if (kittyPosition < 0)
                {
                    kittyPosition += copyOfSequence.Length;
                }

                currentSymbol = copyOfSequence[kittyPosition];
                if (currentSymbol == '@')
                {
                    soulsCount++;
                    copyOfSequence.Remove(kittyPosition, 1);
                    copyOfSequence.Insert(kittyPosition, '.');

                    jumpsBeforeDeadlock++;
                    continue;
                }
                else if (currentSymbol == '*')
                {
                    foodCount++;
                    copyOfSequence.Remove(kittyPosition, 1);
                    copyOfSequence.Insert(kittyPosition, '.');

                    jumpsBeforeDeadlock++;
                    continue;
                }
                else if (currentSymbol == 'x')
                {
                    if (soulsCount == 0 && foodCount == 0)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumpsBeforeDeadlock);
                        return;
                    }

                    if (kittyPosition % 2 == 0)
                    {
                        if (soulsCount == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", jumpsBeforeDeadlock);
                            return;
                        }

                        soulsCount--;
                        copyOfSequence.Remove(kittyPosition, 1);
                        copyOfSequence.Insert(kittyPosition, '@');
                    }
                    else
                    {
                        if (foodCount == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", jumpsBeforeDeadlock);
                            return;
                        }

                        foodCount--;
                        copyOfSequence.Remove(kittyPosition, 1);
                        copyOfSequence.Insert(kittyPosition, '*');
                    }

                    deadlockCount++;
                    jumpsBeforeDeadlock++;
                }
            }

            Console.WriteLine("Coder souls collected: {0}", soulsCount);
            Console.WriteLine("Food collected: {0}", foodCount);
            Console.WriteLine("Deadlocks: {0}", deadlockCount);
        }
    }
}
