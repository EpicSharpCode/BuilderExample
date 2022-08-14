using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    internal abstract class LabyrinthBuilderBase
    {
        protected Labyrinth labyrinth;

        protected LabyrinthBuilderBase()
        {
            labyrinth = new Labyrinth(Utilities.GetNewCypher(10));
        }

        public Labyrinth GetLabyrinth() => labyrinth;

        public abstract void BuildWalls();
        public abstract void BuildInterior();
        public abstract void BuildTraps();
    }
}
