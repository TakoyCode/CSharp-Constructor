using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Constructor
{
    internal class Pokemon
    {
        public string Name;
        public int Level;
        public int Health;

        public Pokemon(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
