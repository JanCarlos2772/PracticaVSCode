namespace PracticaVSCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Cambio 1");

        Random dado = new Random();
        int roll1 = dado.Next(1,7);
        int roll2 = dado.Next(1,7);
        int roll3 = dado.Next(1,7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Tirada de Dados: {roll1} + {roll2} + {roll3} = {total}");
        if (((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) && ((roll1 == roll2) && (roll2 == roll3)))
        {
            
        }
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        } 
        if((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }
        if(total >= 15)
        {
            Console.WriteLine("You win!");
        }
        if(total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }
        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }



    }
}
