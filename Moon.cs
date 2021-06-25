using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Moon : ListGalaxy
    {
        public string planetName;
        public string name;
        public Moon() { }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Moon(Planets plt, string name)
        {
            this.planetName = plt.Name;
            this.name = name;
        }
        
    }
}
