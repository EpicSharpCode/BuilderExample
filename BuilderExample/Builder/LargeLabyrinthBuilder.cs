using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    internal class LargeLabyrinthBuilder : LabyrinthBuilderBase
    {
        public LargeLabyrinthBuilder() : base() { }
        public override void BuildInterior() { labyrinth.AddInterior(40); }

        public override void BuildTraps() { labyrinth.AddTraps(20); }

        public override void BuildWalls() { labyrinth.AddWalls(100); }
    }
}
