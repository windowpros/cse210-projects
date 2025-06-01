using System;

class Menu
{
    public Scripture ChooseScripture()
    {
        while (true)
        {
            Console.WriteLine("Which scripture would you like to study?");
            Console.WriteLine("1. Joshua 1:9");
            Console.WriteLine("2. Alma 11:37");
            Console.WriteLine("3. Joshua 24:15");
            Console.Write("Enter 1, 2, or 3: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Reference r1 = new Reference("Joshua", 1, 9);
                    string t1 = "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.";
                    return new Scripture(r1, t1);

                case "2":
                    Reference r2 = new Reference("Alma", 11, 37);
                    string t2 = "And I say unto you again that he cannot save them in their sins; for I cannot deny his word, and he hath said that no unclean thing can inherit the kingdom of heaven; therefore, how can ye be saved, except ye inherit the kingdom of heaven? Therefore, ye cannot be saved in your sins.";
                    return new Scripture(r2, t2);

                case "3":
                    Reference r3 = new Reference("Joshua", 24, 15);
                    string t3 = "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.";
                    return new Scripture(r3, t3);

                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
