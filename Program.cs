using System;
using System.Collections.Generic;

// Riddle #1
// What goes on four feet in the morning, two feet at noon, and three feet in the evening? 
// Answer: a person

// Riddle #2
// This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to the meal?
// Answer: Time

// Riddle #3
// Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name
// Answer: Death

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Questions(); 
    } 

     public static void Questions() {
      List<string> riddles = new List<string>();
      riddles.Add("What goes on four feet in the morning, two feet at noon, and three feet in the evening?");
      riddles.Add("This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to the meal?");
      riddles.Add("Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name");
      riddles.Add("I'm alive, but without breath; I'm as cold in life as in death; I'm never thirsty, though I always drink.");

      string[] answerArr = {"person", "time", "death", "fish"};
      
      List<int> listNumbers = new List<int>();
      int number;
      Random rand = new Random();
      number = rand.Next(0,3);
      // for (int i = 0; i < 4; i++)
      // {
      //   do {
      //     number = rand.Next(0, 3);
      //   } while (listNumbers.Contains(number));
      //   listNumbers.Add(number);
      // }

        Console.WriteLine(riddles[number]);
        string strAnswer = Console.ReadLine();
        string lowerStrAnswer = strAnswer.ToLower();

        foreach(string item in riddles){

          if (lowerStrAnswer == answerArr[number]) 
          {
            Console.WriteLine("Sphinx is defeated"); 
            // tempRiddles.RemoveAt(number);
            Questions(); 
          }
          else
          {
            System.Console.WriteLine("You lost, your heart gets eaten, nom nom");
          }
          riddles.RemoveAt(number);
        }
     }
   }
}











//       Console.WriteLine(riddleArr[0]);
//       string strAnswer = Console.ReadLine();

//       if ( strAnswer == "person") 
//       {
//         Console.WriteLine(riddleArr[1]);
//         string strAnswer1 = Console.ReadLine();
//             // } else {
//             //   System.Console.WriteLine("You lost, your heart gets eaten, nom nom");
//             // } 
//         if (strAnswer1 == "Time")
//         {
//           Console.WriteLine(riddleArr[2]);
//           string strAnswer2 = Console.ReadLine();

//           if (strAnswer2 == "Death") {
//             System.Console.WriteLine("The Sphinx is defeated");
//           }
//           else 
//           {
//             System.Console.WriteLine("You lost, your heart gets eaten, nom nom");
//           }
//         }
//       }
//     }
//   }
// }