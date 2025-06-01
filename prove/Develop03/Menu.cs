// class Menu
// {
//     public void ChooseReference()
//     {
//         bool running = true;
//         while (running)
//         {

            
//             Console.WriteLine("Which scripture would you like to study?");
//             Console.WriteLine("1. Joshua 1:9");
//             Console.WriteLine("2. Alma 11:37");
//             Console.WriteLine("3. Joshua 24:15");
//             Console.WriteLine("4. Quit");
//             string _selection = Console.ReadLine();
//             int _numberChoice = int.Parse(_selection);

//             switch (_numberChoice)
//             {


//                 case 1:
//                     Console.WriteLine("Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.");
//                     break;

//                 case 2:
//                     Console.WriteLine("And I say unto you again that he cannot save them in their sins; for I cannot deny his word, and he hath said that no unclean thing can inherit the kingdom of heaven; therefore, how can ye be saved, except ye inherit the kingdom of heaven? Therefore, ye cannot be saved in your sins.");
//                     break;

//                 case 3:
//                     Console.WriteLine("And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.");
//                     break;

//                 case 4:
//                     running = false;
//                     break;

//                 default:
//                     Console.WriteLine("Invalid response. Select 1, 2, or 3.");
//                     break;
//             }
//         }
//     }
// }