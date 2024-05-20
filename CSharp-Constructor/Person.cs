using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Constructor
{
    // En constructor blir opprettet når en klasse blir opprettet, og alle har en tom constructor by default.
    // Constructorer brukes til å initialisere objektets egenskaper og utføre eventuelle nødvendige initialiseringsoppgaver.
    // Den har samme navn som klassen og har ingen returtype, heller ikke void.
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Her blir parameterne som blir sendt inn i Person sin constructor satt som value til variablene Name og Age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        

        public Person()
        {

        }
    }


}
