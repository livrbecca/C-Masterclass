using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {

        // member variables - on the level of the class Box
        // have a direct impact on Mox & can be used in different way

        // PUBLIC - can be changed by anyone
        //public int length;
        //public int height;
        //public int width;
        //public int volume;

        // PRIVATE - better practice
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        // to access properties in Program, use get & set

        public void DisplayInfo()
        {
            Console.WriteLine($"length is {length}\nheight is {height}\nwidth is {width}\nvolume is {volume = length*height*width}");
            
        }
    }
}
