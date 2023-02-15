
/*
 * Author: Daniela Lopez
 * Course: COMP-003A-L01
 * Purpose: looping statements code 
 */

namespace COMP003A
{
   internal class Program
   {
        static void Main (string[] args)
        {
           Console.WriteLine ("".PadRight(43, '*'));
           Console.WriteLine ("For loop section");
           Console.WriteLine ("Output a right triangle based on user input");
           Console.WriteLine ("".PadRight(43, '*'));
           Console.WriteLine ("Enter a positive whole number: ");
           string limitString;
           int limit;
           limitString = Console.ReadLine ();
           limit = Convert.ToInt32(limitString);


           int val =5;
           int i;
           string output ="";
           for (i = 1; i <= val; i++)
           {
               output += "#";
               Console.Write (output);
               Console.WriteLine ("");
           }

           Console.WriteLine("\n");
           Console.WriteLine ("".PadRight(37, '*'));
           Console.WriteLine ("Foreach section");
           Console.WriteLine ("Output all of the friends in an array");
           Console.WriteLine ("".PadRight(37, '*'));
           
           string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
           foreach (string friend in friends)
           {
               Console.WriteLine(friend);
           }

           Console.WriteLine("\n");
           Console.WriteLine ("".PadRight(17, '*'));
           Console.WriteLine ("Do-while section");
           Console.WriteLine ("Output 0-50 by 5s");
           Console.WriteLine ("".PadRight(17, '*'));
           int counter = 0;


           do
           {
               Console.WriteLine ($"{counter}");
               counter+= 5;
           } while (counter <= 50);


           Console.WriteLine("\n");
           Console.WriteLine ("".PadRight(50, '*'));
           Console.WriteLine ("While section");
           Console.WriteLine ("Output 1-20");
           Console.WriteLine ("If the number is divisible by 2, output Foo");
           Console.WriteLine ("If the number is divisible by 5, output Bar");
           Console.WriteLine ("If the number is divisible by 2 & 5, output FooBar");
           Console.WriteLine ("".PadRight(50, '*'));
           int counter2 = 1;


           while (counter2 <= 20)
           {
               if (counter2 % 2 == 0 && counter2 % 5 == 0)
               {
                   Console.WriteLine ("FooBar");
               }


               else if (counter2 % 5 == 0)
               {
                   Console.WriteLine ("Bar");
               }


               else if (counter2 % 2 == 0)
               {
                   Console.WriteLine ("Foo");
               }


               else
               {
                   Console.WriteLine ($"{counter2}");
               }


               counter2++;

           }

       }
   }
}


