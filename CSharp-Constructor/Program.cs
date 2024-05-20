namespace CSharp_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Her lager vi en instance av Person, deretter henter den sin value av Name og Age.
            // Her kan vi lage flere personer med navn og alder på samme måte.
            void Run()
            {
                var person1 = new Person("Alija", 29);
                Console.WriteLine($"Navn: {person1.Name}, Alder: {person1.Age}");
            }
            //Run();


            // Notater til Videon - Introduksjon til objektorientering del tre

            // Eksempel på hvordan det ser ut uten en constructor, må ha en klasse per pokemon
            void Example1()
            {
            var pikachu = new Pikachu(10, 30); 
            Console.WriteLine($"Pikachu har {pikachu.Health}hp og er level {pikachu.Level}");

            var bulbasaur = new Bulbasaur(2, 5);
            Console.WriteLine($"Bulbasaur har {bulbasaur.Health}hp og er level {bulbasaur.Level}");
            }

            // Eksempel på hvordan det ser ut med en constructor
            void Example2()
            {
                var bulbasaur = new Pokemon("Bulbasaur", 2, 5);
                var pikachu = new Pokemon("Pikachu", 10, 30);

                Console.WriteLine($"{bulbasaur.Name} har {bulbasaur.Health}hp og er level {bulbasaur.Level}");
                Console.WriteLine($"{pikachu.Name} har {pikachu.Health}hp og er level {pikachu.Level}");
            }
            Example2();
        }
    }
}
