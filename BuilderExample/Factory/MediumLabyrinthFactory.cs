using BuilderExample.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Factory
{
    internal class MediumLabyrinthFactory : LabyrinthFactoryBase
    {
        public MediumLabyrinthFactory(LabyrinthBuilderBase _labyrinthBuilder) : base(_labyrinthBuilder) { }

        public override Labyrinth ConstructLabyrinth()
        {
            labyrinthBuilder.BuildWalls();
            labyrinthBuilder.BuildInterior();
            return labyrinthBuilder.GetLabyrinth();
        }
    }
}
