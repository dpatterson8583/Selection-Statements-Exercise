namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.Write("Guess my favorite number. > ");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput == 0)
            {
                Console.WriteLine("Game Over");
            }
            else if(userInput > 1000)
            {
                Console.WriteLine("Out of bounds");
            }
            else if(userInput<favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else if(userInput == favNumber)
            {
                Console.WriteLine("You got it Right!");
            }
            else 
            { Console.WriteLine($"Nevermind...It was {favNumber}"); }
        }
    }
}
