using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    internal class Labyrinth
    {
        public string name { get; private set; }
        public int wallsCount { get; private set; } = 0;
        public int interiorItemsCount { get; private set; } = 0;
        public int trapsCount { get; private set; } = 0;

        public Labyrinth(string _name) { SetName(_name); }

        public void SetName(string _name) => name = _name;
        public void AddWalls(int count)
        {
            if (count <= 0 ) return;
            wallsCount += count;
        }
        public void AddInterior(int count)
        {
            if (count <= 0) return;
            interiorItemsCount += count;
        }
        public void AddTraps(int count)
        {
            if (count <= 0) return;
            trapsCount += count;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Labyrinth - {0}\n", name);
            stringBuilder.AppendFormat("Walls: {0}\n", wallsCount);
            stringBuilder.AppendFormat("Interior: {0}\n", interiorItemsCount);
            stringBuilder.AppendFormat("Traps: {0}\n", trapsCount);
            return stringBuilder.ToString();
        }
    }
}
