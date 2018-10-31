using System;
using FIFOAnimalShelter.Classes;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        /// <summary>
        /// Constructor is expecting an Animal. It checks to see if 
        /// animal.Type is cat or dog before accepting to the queue
        /// </summary>
        /// <param name="animal">Animal object</param>
        public AnimalShelter(Animal animal)
        {
            if (animal.Type.ToLower() == "cat" || animal.Type.ToLower() == "dog")
            {
                animal.Type = animal.Type.ToLower();
                Front = animal;
                Rear = animal;
            }
        }
        /// <summary>
        /// Method that takes in an animal if the animal.Type is 
        /// either a cat or dog. Otherwise the queue will not be affected
        /// </summary>
        /// <param name="animal">New Animal</param>
        public void Enqueue(Animal animal)
        {
            if (animal.Type.ToLower() == "cat" || animal.Type.ToLower() == "dog")
            {
                animal.Type = animal.Type.ToLower();
                Rear.Next = animal;
                Rear = animal;
            }
        }
        /// <summary>
        /// Method that takes in a user preference. Front Animal is returned if type matches the user preference. 
        /// If not the front animal, queue is traversed finding longest waiting preferred animal,
        /// return it and reconstruct the list, maintaining the order
        /// </summary>
        /// <param name="preference">User can input "cat","dog",or"none"</param>
        /// <returns>Adopted Animal</returns>
        public Animal Dequeue(string preference)
        {
            Animal adopt = Front;
            Animal Current = Front;

            if (preference.ToLower() == Front.Type)
            {
                Front = adopt.Next;
                adopt.Next = null;
                return adopt;
            }
            while (Current.Next != null)
            {
                adopt = adopt.Next;
                if (adopt.Type == preference.ToLower())
                {
                    Current.Next = adopt.Next;
                    adopt.Next = null;
                    return adopt;
                }
                Current = Current.Next;
            }
            return Front;
        }
        /// <summary>
        /// Method Prints the entire queue
        /// </summary>
        public void Print()
        {
            Animal temp = Front;
            while (temp.Next != null)
            {
                Console.Write($"{temp.Type}-->");
                temp = temp.Next;
            }
            Console.Write($"{temp.Type}-->Null");
            Console.WriteLine("");
        }
    }
}
