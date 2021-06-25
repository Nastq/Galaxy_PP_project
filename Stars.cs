using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Stars : ListGalaxy
    {

        public Class_Star type;
        public string gxName;
        public decimal age;
        public string name;
        public decimal weight;
        public decimal size;
        public int temperature;
        public decimal lightness;

        public Stars() { }

        public Stars(Galaxies galaxy, string name, decimal weight, decimal size, int temperature, decimal lightness)
        {
            this.gxName = galaxy.Name;
            this.name = name;
            this.weight = weight;
            this.size = size;
            this.temperature = temperature;
            this.lightness = lightness;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Class_Star Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public decimal Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public decimal Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public decimal Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public decimal Lightness
        {
            get { return this.lightness; }
            set { this.lightness = value; }

        }
        public int Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }

        }
        
    }
}