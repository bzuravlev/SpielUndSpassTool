using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielUndSpassTool
{
    class Artikel
    {
        private int id;
        private String name;
        private float preis;
        private String anmerkung;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Preis
        {
            get { return preis; }
            set { preis = value; }
        }

        public String Anmerkung
        {
            get { return anmerkung; }
            set { anmerkung = value; }
        }
    }
}
