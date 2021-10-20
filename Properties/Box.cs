using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {

        #region CONSTRUTOR - no longer need to get the values directly in Program
        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }
        #endregion

        // member variables - on the level of the class Box
        // have a direct impact on Mox & can be used in different way

        // PUBLIC - can be changed by anyone
        // public int length;
        //public int height;
        //public int width;
        //public int volume;

        // PRIVATE - better practice, cant be accessed from outside / via getters and setters

       
        public int FrontSurface
        {
            get { return Height * Length; }
        }

        private int length;
        public int Length
        {
           get { return length; }
           set { length = value; }
        }

        #region THE PATTERN.
        // pattern:
        // private version in lowercase or _lowercase
        // public get set in upper case
        // you're getting the private one, setting it to value
        // value will be assigned when creating a new instance, using the Uppercase properties
        // PinkBox.Height = 10;
        #endregion

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
    
        public int Volume
        {
            get { return length * height * width; }
           
        }

        // to access properties in Program (since we made them private here), use get & set

        //public void SetLength(int length)
        //{
        //    if (length < 0){
        //        throw new Exception("length should be higher than 0");
        //    }
        //    this.length = length;
        //}

     

      

        public void DisplayInfo()
        {
            Console.WriteLine($"length is {Length}\nheight is {Height}\nwidth is {Width}");
            
        }
    }
}