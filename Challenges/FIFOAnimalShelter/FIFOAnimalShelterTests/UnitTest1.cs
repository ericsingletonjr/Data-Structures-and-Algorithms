using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelterTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("cat","cat")]
        [InlineData("dog","dog")]
        [InlineData("Cat","cat")]
        [InlineData("Dog","dog")]
        public void FirstAnimalIsFrontOfQueue(string value, string expected)
        {
            AnimalShelter shelter = new AnimalShelter(new Animal(value));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("dog"));

            Assert.Equal(expected, shelter.Front.Type);
        }
        [Theory]
        [InlineData("cat", "cat")]
        [InlineData("dog", "dog")]
        [InlineData("Cat", "cat")]
        [InlineData("Dog", "dog")]
        public void LastAnimalIsEndOfQueue(string value, string expected)
        {
            AnimalShelter shelter = new AnimalShelter(new Animal("dog"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal(value));

            Assert.Equal(expected, shelter.Rear.Type);
        }
        [Theory]
        [InlineData("cat", "cat")]
        [InlineData("dog", "dog")]
        [InlineData("Cat", "cat")]
        [InlineData("Dog","dog")]
        public void DequeueAnimalFrontMatchesUserPreferenceOrNone(string value, string expected)
        {
            AnimalShelter shelter = new AnimalShelter(new Animal(value));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("dog"));

            Assert.Equal(expected, shelter.Dequeue(value).Type);
        }
        [Fact]
        public void DequeueAnimalMatchesFurtherInQueueMaintainingOrder()
        {
            AnimalShelter shelter = new AnimalShelter(new Animal("cat"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("dog"));

            shelter.Dequeue("dog");

            Assert.Equal("cat", shelter.Front.Type);
        }
    }
}
