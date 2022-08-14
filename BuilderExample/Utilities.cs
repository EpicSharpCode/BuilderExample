using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    internal static class Utilities
    {
        static Random random = new Random();
        public static string GetNewCypher(int count)
        {
            var stringBuilder = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                int rndValue = 10; // new line char code
                while (rndValue == 10) { rndValue = random.Next(0, 255); }
                stringBuilder.Append(string.Format("{0}", (char)rndValue).ToUpper());
            }
            return stringBuilder.ToString();
        }
    }
}
