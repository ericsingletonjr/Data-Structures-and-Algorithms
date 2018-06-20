using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Animal
    {
        public string Type { get; set; }
        public Animal Next { get; set; }

        public Animal(string type)
        {
            Type = type;
        }
    }
}
