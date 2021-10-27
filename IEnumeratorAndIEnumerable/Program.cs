namespace IEnumeratorAndIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            // IEnumberable <T> interface for generic collections - iterate through a collection, makes it countable
            // IEnumberable nterface for non-generic collections 


            // IEnumerable, contains method that you MUST implement; GetEnumerator(), returns IEnumerator<T> object
            // the object provides the ability to iterate through the collection by exposing a 'current' property


            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter) // make DogShelter implement : IEnumerable<Dog> to get rid of error that shelter is not enumerable,...... or shelter.dogs
            {
                if (!dog.IsNaughty)
                {
                    dog.GiveTreat(3);
                }
                else{
                    dog.GiveTreat(1);
                }
            }
        }
    }
}
