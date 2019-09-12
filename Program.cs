/*
 * This C# Console application code is meant to
 * display an integer and repeat the counter
 * value as it goes through a for loop. It also displays
 * the lines from a nursery rhyme where applicable.
 */
using System;

namespace ISM4300IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer value between 1 and 100: ");

            try
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);

                if((num > 0) && (num <= 100))
                {
                    for (int i = 1; i <= num; i++)
                    {

                        Console.Write("You have entered " + num.ToString() + ". ");
                        Console.WriteLine("This is the current integer value in the loop: " + i.ToString());
                        switch (i)
                        {
                            case 2:
                                Console.WriteLine("One, two buckle my shoe!");
                                break;
                            case 4:
                                Console.WriteLine("Three, four shut the door!");
                                break;
                            case 6:
                                Console.WriteLine("Five, six pick up sticks!");
                                break;
                            case 8:
                                Console.WriteLine("Seven, eight lay them straight!");
                                break;
                            case 10:
                                Console.WriteLine("Nine, ten a big fat hen!");
                                break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 next time...");
                }
            } //end of try
            catch
            {
                Console.WriteLine("Please check that you are entering a proper integer value");
            } // end of catch
        }
    }
}
