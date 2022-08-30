using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_are_coming
{
    class Robot
    {
        /* essentially we have 3 different kinds of robots. floor-cleaners, window-cleaners and car-tire-changers.
         supposedly they have 2 different chips in them, and depending on the chips they will have different properties, however this isnt specified therefore its up to me how to interpret this
         one special kind of robot has wifi, not dependant on chips, but therefrom not specified, so same case applies after that
         all robots are generally white, however some can have color (minority), and those with color will not have batties in them 
         all cleaner bots have a soap dispenser on exactly 2.3l, but these cant have batteries, however they can easily have colors.
        multiple sizes of bots, and all have wheels except for the smallest one
        battery size goes from 0 to 255
        all of this means a lot of random will be used :)
         */

        Random random = new Random();
        private string[] allColors = { "yellow", "green", "red", "blue", "orange" };

        
        private string color { get; }
        private bool hasWifi { get; }
        private byte battery { get; }
        private const double soapCapacity = 2.3;


        public Robot() 
        {
            int randomColor = random.Next(0, 20);   // here we get the random color of the bot. i have decided that it will be a "pseudo random 25% chance" for the bot to have color 
            if (randomColor < 5)
            {
                this.color = allColors[randomColor];
            }
            else
            {
                this.color = "white";
            }
            int rndChip = random.Next(1, 2);
        }
    }
}
