using BuilderExample.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Factory
{
    internal class EasyLabyrinthFactory : LabyrinthFactoryBase
    {
        public EasyLabyrinthFactory(LabyrinthBuilderBase _labyrinthBuilder) : base(_labyrinthBuilder) { }

        public override Labyrinth ConstructLabyrinth()
        {
            labyrinthBuilder.BuildWalls();
            return labyrinthBuilder.GetLabyrinth();
        }
    }
}
