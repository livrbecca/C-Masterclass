using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Human DanielDefault = new Human();
            DanielDefault.Intro();

            Human EvaEvverything = new Human("Eva", "Everything", "Green", 25);
            EvaEvverything.Intro();

            Human JaneBlue = new Human("Jane", "Doe", "Blue");
            JaneBlue.Intro();

            Human SallySimple = new Human("Sally", 18);
            SallySimple.Intro();

            Human FirstNameFizz = new Human("Fizz");
            FirstNameFizz.Intro();

            Human TwoNameTim = new Human("Tim", "Tillit"); // doesn't work
            TwoNameTim.Intro();
        }
    }
}
