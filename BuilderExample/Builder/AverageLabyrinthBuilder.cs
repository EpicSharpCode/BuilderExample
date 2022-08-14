using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    internal class AverageLabyrinthBuilder : LabyrinthBuilderBase
    {
        public AverageLabyrinthBuilder() : base() { }
        public override void BuildInterior() { labyrinth.AddInterior(20); }

        public override void BuildTraps() { labyrinth.AddTraps(10); }

        public override void BuildWalls() { labyrinth.AddWalls(60); }
    }
}
