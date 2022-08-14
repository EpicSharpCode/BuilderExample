using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder
{
    internal class SmallLabyrinthBuilder : LabyrinthBuilderBase
    {
        public SmallLabyrinthBuilder() : base() { }
        public override void BuildInterior() { labyrinth.AddInterior(10); }

        public override void BuildTraps() { labyrinth.AddTraps(5); }

        public override void BuildWalls() { labyrinth.AddWalls(30); }
    }
}
