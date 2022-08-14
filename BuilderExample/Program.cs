using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Builder;
using BuilderExample.Factory;

namespace BuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LabyrinthFactoryBase labyrinthFactory;

            labyrinthFactory = new EasyLabyrinthFactory(new SmallLabyrinthBuilder());
            var easyLabyrinth = labyrinthFactory.ConstructLabyrinth();
            Console.WriteLine(easyLabyrinth.ToString());

            labyrinthFactory = new MediumLabyrinthFactory(new AverageLabyrinthBuilder());
            var mediumLabyrinth = labyrinthFactory.ConstructLabyrinth();
            Console.WriteLine(mediumLabyrinth.ToString());

            labyrinthFactory = new HardLabyrinthFactory(new LargeLabyrinthBuilder());
            var hardLabyrinth = labyrinthFactory.ConstructLabyrinth();
            Console.WriteLine(hardLabyrinth.ToString());

            labyrinthFactory = new EasyLabyrinthFactory(new LargeLabyrinthBuilder());
            var easyLargeLabyrinth = labyrinthFactory.ConstructLabyrinth();
            Console.WriteLine(easyLargeLabyrinth.ToString());

            Console.ReadLine();
        }
    }
}
