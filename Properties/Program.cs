using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Box PinkBox = new Box();
            PinkBox.Height = 10;
            PinkBox.Length = 20;
            PinkBox.Width = 34;
            PinkBox.Volume = PinkBox.Length * PinkBox.Height * PinkBox.Width;
            PinkBox.DisplayInfo();
        }
    }
}
