class Program
{
    private static void Main(string[] args)
    {
        string inputPlayer, inputCPU;
        int randomInt;

        Console.Write("Choose between ROCK, PAPER, and SCISSORS:   ");
        inputPlayer = Console.ReadLine();

        Random rnd = new Random();

        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                inputCPU = "ROCK";
                Console.WriteLine("Computer chose ROCK");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You Lost! :(");
                }
                break;
            case 2:
                inputCPU = "PAPER";
                Console.WriteLine("Computer chose PAPER");
                if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You Lost! :(");
                }
                break;
            case 3:
                inputCPU = "SCISSORS";
                Console.WriteLine("Computer chose SCISSORS");
                if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("You win!");
                } else
                {
                    Console.WriteLine("You Lost! :(");
                }
                break;
            default:
                break;
        }
    }
}