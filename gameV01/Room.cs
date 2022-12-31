using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameV01
{
    public class Room
    {
        public string name;
        public string description;
        public int n;
        public int s;
        public int w;
        public int e;

        public Room(string name, string description, int n, int s, int w, int e)
        {
            this.name = name;
            this.description = description;
            this.n = n;
            this.s = s;
            this.w = w;
            this.e = e;
        }
    }
}
