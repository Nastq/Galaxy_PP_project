using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Galaxies : ListGalaxy
    {
        public string name;
        public Galaxy_Type type;
        public string age;

        public Galaxies() { }
        public Galaxies(string name, Galaxy_Type type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Galaxy_Type Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Age
        {
            get { return this.age; } set { this.age = value; }
        }

    }
}
