using BuilderExample.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Factory
{
    internal class HardLabyrinthFactory : LabyrinthFactoryBase
    {
        public HardLabyrinthFactory(LabyrinthBuilderBase _labyrinthBuilder) : base(_labyrinthBuilder) { }

        public override Labyrinth ConstructLabyrinth()
        {
            labyrinthBuilder.BuildWalls();
            labyrinthBuilder.BuildInterior();
            labyrinthBuilder.BuildTraps();
            return labyrinthBuilder.GetLabyrinth();
        }
    }
}
