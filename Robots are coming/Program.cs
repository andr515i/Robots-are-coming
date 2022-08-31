using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_are_coming
{
    class Program
    {
        static void Main(string[] args)
        {
            // this robot making machine will make a lot of random, quite possibly a lot of useless, and weird robots.
            // the amount will be decided from the user itself, and then printed out to the console, so we can inspect  the robots created
            bool run = true;
            while (run)
            {
                Console.WriteLine("how many robots would you like to be manifactured? \n");
                int initialUserInput = Convert.ToInt32(Console.ReadLine());
                Robot[] bot = new Robot[initialUserInput];

                if (initialUserInput != 0)
                {
                    for (int i = 0; i < initialUserInput; i++)
                    {
                        bot[i] = new Robot();
                        Console.WriteLine("robot type: " + bot[i].RobotType);
                        Console.WriteLine("robot chip: " + bot[i].Chip);
                        Console.WriteLine("robot size scale: " + bot[i].BotSize);
                        Console.WriteLine("robot color: " + bot[i].Color);
                        Console.WriteLine("does robot have wifi? " + bot[i].HasWifi);
                        Console.WriteLine("how many wheels does the robot have? " + bot[i].WheelCount);
                        Console.WriteLine("does robot have soap? " + bot[i].HasSoapDispenser + "\n\n");
                    }
                }
                else
                {
                    run = false;
                }

            }



        }
    }
}
