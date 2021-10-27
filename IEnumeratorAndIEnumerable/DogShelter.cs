using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorAndIEnumerable
{
    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
                dogs = new List<Dog>()
                {
                      new Dog("lil", false),
                      new Dog("bill", false),
                      new Dog("till", true),
                      new Dog("mill", false),
                      new Dog("savanah", true)
                };
        
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
