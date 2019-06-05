using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielUndSpassTool
{
    class Kunde
    {
        private int id;
        private String vorname;
        private String nachname;
        private String firma;
        private String adresse;
        private String telNummer;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        public String Firma
        {
            get { return firma; }
            set { firma = value; }
        }

        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public String TelNr
        {
            get { return telNummer; }
            set { telNummer = value; }
        }
    }
}
