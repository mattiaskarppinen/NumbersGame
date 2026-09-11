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
                    Console.WriteLine("too high");
                    return false;
                }
                else if (guess < rightAnswer)
                {
                    Console.WriteLine("too low");
                    return false;
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
