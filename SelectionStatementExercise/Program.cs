namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favoriteNumber = r.Next(1, 100);

            Console.WriteLine("Lets play a guessing game!");
            Console.WriteLine("Think you can guess my favorite number?");
            Console.WriteLine("I'll give you a hint: its between 1 and 100");

            int guess;
            do
            {
                Console.WriteLine("Your guess?");
                guess = int.Parse(Console.ReadLine());

                if (guess > favoriteNumber)
                {
                    Console.WriteLine("Oh my! Your guess is too high!");
                }
                else if (guess < favoriteNumber)
                {
                    Console.WriteLine("Oh no! Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("You guessed it! I'm very impressed!");
                }
            } while (guess != favoriteNumber);
        }
    }

}
