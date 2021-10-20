using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box PinkBox = new Box(10, 15, 49); // with a constructor, you put the values here, order is important!
            
            Console.WriteLine($"Total volume: {PinkBox.Volume}");
            Console.WriteLine($"Front surface of the box is: {PinkBox.FrontSurface}");
            //PinkBox.Height = 10; // setting this way not needed with constructor
            //PinkBox.Length = 20;
            //PinkBox.Width = 34;
            // PinkBox.Volume = read only. getting the sum result
            PinkBox.DisplayInfo();
        }
    }
}
