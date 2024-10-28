using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_structs_oop
{
    internal class Dude
    {
        public string name;
        public int exp = 0;

        public Dude()
        {
            name = "Not assigned";
            Reset();
        }

        public Dude(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine($"Dude: {this.name} - {this.exp} EXP");
        }
        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }
}
