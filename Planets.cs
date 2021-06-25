using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Planets : ListGalaxy
    {
        public string starName;
        public string name;
        public Planet_Type type;
        public bool obitaemi;

        public Planets() { }
        public Planets(Stars st, string name, Planet_Type type, bool obitaemi)
        {
            this.starName = st.Name;
            this.obitaemi = obitaemi;
            this.name = name;
            this.type = type;
        }
        public Planet_Type Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
  
        public bool Obitaemi
        {
            get { return this.obitaemi; } set { this.obitaemi = value; }
        }
    }
}
