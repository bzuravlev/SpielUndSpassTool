using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielUndSpassTool
{
    class Auftrag
    {
        private int id;
        private int kdNummer;
        private DateTime datum;
        private int artNummer;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int KdNr
        {
            get { return kdNummer; }
            set { kdNummer = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public int ArtNr
        {
            get { return artNummer; }
            set { artNummer = value; }
        }
    }
}
