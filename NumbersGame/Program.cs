namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate a random answer
            Random ran = new Random();
            int rightAnswer = ran.Next(1, 20);

            int attempts = 4;
            Console.WriteLine("Guess the secret number (1-20) You have {0} attempts.", attempts + 1);

            do
            {
                string guess = Console.ReadLine();
                if (int.TryParse(guess, out int tal))
                {
                    //call method to check if the user guessed right
                    bool gotIt = CheckGuess(tal, rightAnswer);
                    if (gotIt == false)
                    {
                        Console.WriteLine($"You have {attempts} attempts left.");
                        attempts--;
                    }
                    else
                    {
                        Console.WriteLine($"Wohoo, you did it! <3");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

            }
            while (attempts >= 0);
            Console.WriteLine($"Game Over!");
            Console.ReadLine();

            static bool CheckGuess(int guess, int rightAnswer)
            {
                if (guess > rightAnswer)
                {
                    Random rand = new Random();
                    int slumpsvar = rand.Next(1, 5);
                    switch (slumpsvar)
                    {
                        case 1:
                            Console.WriteLine("You guessed too high.");
                            return false;
                            break;
                        case 2:
                            Console.WriteLine("No, no, that's too big.");
                            return false;
                            break;
                        case 3:
                            Console.WriteLine("Hehe, that's too much.");
                            return false;
                            break;
                        case 4:
                            Console.WriteLine("Try something lower.");
                            return false;
                            break;
                    }
                }
                else if (guess < rightAnswer)
                {
                    Random rand = new Random();
                    int slumpsvar = rand.Next(1, 5);
                    switch (slumpsvar)
                    {
                        case 1:
                            Console.WriteLine("Try going higher.");
                            return false;
                            break;
                        case 2:
                            Console.WriteLine("That's too low.");
                            return false;
                            break;
                        case 3:
                            Console.WriteLine("No, go higher.");
                            return false;
                            break;
                        case 4:
                            Console.WriteLine("Don't be shy, go higher.");
                            return false;
                            break;
                    }
                }
                if (guess == rightAnswer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
