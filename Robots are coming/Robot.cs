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
         supposedly they can have one of 2 different chips in them, and depending on the chips they will have different properties - 
        however this isnt specified therefore its up to me how to interpret this
         one special kind of robot has wifi, not dependant on chips, but therefrom not specified, so same case applies after that
         all robots are generally white, however some can have color (minority), and those with color will not have batteries in them 
         all cleaner bots have a soap dispenser on exactly 2.3l, but these cant have batteries, however they can easily have colors.
        multiple sizes of bots, and all have wheels except for the smallest one
        battery size goes from 0 to 255
        all of this means a lot of random will be used :)
         */

        Random random = new Random();
        private string[] allColors = { "yellow", "green", "red", "blue", "orange" };

        private string chip;
        private string color;
        private bool hasWifi;
        private bool hasSoapDispenser;

        private bool canGetBatteries;  // makes sure the bot can even get batteries

        private bool isCleanerBot; // no get because we dont actually need to type it out in console 

        private byte botSize;
        private byte wheelCount;
        private byte battery; // battery capacity goes 0-255
        private BotType botType;   // check enum for the bottypes and their numbers
        public const double soapCapacity = 2.3;  // public value so we can get ahold of it no matter what, and as its a const, it shouldnt be able to be changed

        public string Chip
        {
            get { return chip; }
            private set { chip = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public bool HasWifi
        {
            get { return hasWifi; }
            set { hasWifi = value; }
        }
        
        public bool HasSoapDispenser
        {
            get { return hasSoapDispenser; }
            set { hasSoapDispenser = value; }
        }
        
        public bool CanGetBatteries
        {
            get { return canGetBatteries; }
            set { canGetBatteries = value; }
        }
        
        public bool IsCleanerBot
        {
            get { return isCleanerBot; }
            set { isCleanerBot = value; }
        }
        
        public byte BotSize
        {
            get { return botSize; }
            set { botSize= value; }
        }
        public byte WheelCount
        {
            get { return wheelCount; }
            set { wheelCount = value; }
        }
        public byte BatteryCapacity
        {
            get { return battery; }
            set { battery = value; }
        }
        public BotType RobotType
        {
            get { return botType; }
            set { botType = value; }
        }
        
        public enum BotType
        {
            floorCleaner = 1,   // floor cleaner will have the Rx4667 chipset
            windowCleaner = 2, // window cleaner will have the qt8339 chipset
            tireChanger = 3 //tirechanger will also have the qqt8339 chipset
        }
        public Robot() 
        {
            int randomColor = random.Next(0, 20);   // here we get the random color of the bot. i have decided that it will be a 25% chance for the bot to have color 
            if (randomColor < 5)
            {
                this.Color = allColors[randomColor];
                this.CanGetBatteries = false;
            }
            else
            {
                this.Color = "white";
                this.CanGetBatteries = true;
            }
            int rndChip = random.Next(1, 3); // here we decide which chip we will use
            if (rndChip == 1)
            {
                this.Chip = "RX4667";
                this.botType = BotType.floorCleaner;
                this.IsCleanerBot = true;

            }
            else
            {
                this.chip = "QT8339";
                int randomBotType = random.Next(2, 4);
                this.botType = (BotType) randomBotType;
                if (randomBotType == 2)  // makes sure its a cleaner bot, will be used for soap
                {
                    this.isCleanerBot = true;
                }
            }
            int randomWifi = random.Next(1, 2);  // wifi
            if (randomWifi == 1)
            {
                this.hasWifi = true;
            }
            else
            {
                this.hasWifi = false;
            }
            if (isCleanerBot)  // we give cleaner bots soap dispensers
            {
                this.hasSoapDispenser = true;
            }

            this.botSize = (byte)random.Next(1, 3);  // we cast random to byte and assign it straight away

            int randomWheelCount = random.Next(1, 6);  //we get the wheelcount dependant on size
            if (this.botSize != 1)
            {

                this.wheelCount = (byte)randomWheelCount;  // we cast to byte to convert int to byte, as i couldnt see a reason to use a whole int for such a small number, should have done it other places aswell, but im just too lazy
            }
            else
            {
                this.wheelCount = 0;
            }
        }   
    }
}
