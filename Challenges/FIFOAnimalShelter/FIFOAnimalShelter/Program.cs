using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }
        static void FIFOAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter(new Animal("Cat"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Llama"));
            shelter.Enqueue(new Animal("cat"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("dog"));

            Console.WriteLine($"Front:{shelter.Front.Type} Rear:{shelter.Rear.Type}");
            shelter.Print();

            Animal adopted = shelter.Dequeue("cat");
            Console.WriteLine($"Front:{shelter.Front.Type} Rear:{shelter.Rear.Type}");
            shelter.Print();

            shelter.Dequeue("dog");
            Console.WriteLine($"Front:{shelter.Front.Type} Rear:{shelter.Rear.Type}");
            shelter.Print();

            shelter.Dequeue("Dog");
            Console.WriteLine($"Front:{shelter.Front.Type} Rear:{shelter.Rear.Type}");
            shelter.Print();
        }
    }
}
