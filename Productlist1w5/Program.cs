// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        List<string> products = new List<string>();

        Console.WriteLine("Enter product names. Type 'exit' when done.");

        while (true)
        {
            Console.Write("Product: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (IsExitCommand(input))
                break;

            products.Add(input);
        }

        Console.WriteLine("\nList of Entered Products:");

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static bool IsExitCommand(string input)
    {
        return input == "exit" || input == "exit " || input == " exit" || input == " exit ";
    }
}