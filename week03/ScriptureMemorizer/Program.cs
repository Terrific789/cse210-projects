using System;

class Program
{
    static void Main()
    {
        // Create a reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // Create a scripture passage
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");
        
        while (true)
        {
            // Console.Clear();
            Console.WriteLine(reference.GetDisplayText("Proverbs", 3, 5, 6));
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();
            
            if (input == "quit")
                break;
            
            scripture.HideRandomWord();
            
            if (scripture.IsCompletelyHidden(true))
            {
                Console.Clear();
                Console.WriteLine(reference.GetDisplayText("Proverbs", 3, 5, 6));
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Program ending...");
                break;
            }
        }
    }
}
