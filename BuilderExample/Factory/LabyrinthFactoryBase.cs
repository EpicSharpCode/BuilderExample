using BuilderExample.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Factory
{
    internal abstract class LabyrinthFactoryBase
    {
        protected LabyrinthBuilderBase labyrinthBuilder;

        protected LabyrinthFactoryBase(LabyrinthBuilderBase _labyrinthBuilder)
        {
            labyrinthBuilder = _labyrinthBuilder;
        }

        public abstract Labyrinth ConstructLabyrinth();
    }
}
