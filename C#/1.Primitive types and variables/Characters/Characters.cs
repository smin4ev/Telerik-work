using System;

class Characters
{
    static void Main()
    {
        char symbol = 'a';
        Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (int)symbol);

        symbol = 'b';
        Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (int)symbol);

        symbol = 'A';
        Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (int)symbol);

        symbol = 'щ'; // Cyrillic letter 'sht'
        Console.WriteLine("Кода на  '{0}' is: {1}",
            symbol, (int)symbol);

       
        
	}
}
