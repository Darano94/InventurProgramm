using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventurProgramm
{
    class Geraet
    {
        private string typ;
        private string bezeichnung;
        private string hersteller;
        private string inventurnummer;
        private string seriennummer;
        private DateTime kaufdatum;

        //getter und setter
        public void setTyp(string typ)
        {
            this.typ = typ;
        }
        public string getTyp()
        {
            return this.typ;
        }
        public void setBezeichnung(string bez)
        {
            this.bezeichnung = bez;
        }
        public string getBezeichnung()
        {
            return this.bezeichnung;
        }
        public void setHersteller(string hersteller)
        {
            this.hersteller = hersteller;
        }
        public string getHersteller()
        {
            return this.hersteller;
        }
        public void setInventurnummer(string num)
        {
            this.inventurnummer = num;
        }
        public string getInventurnummer()
        {
            return this.inventurnummer;
        }
        public void setSeriennummer(string num)
        {
            this.seriennummer = num;
        }
        public string getSeriennummer()
        {
            return this.seriennummer;
        }
        public void setKaufdatum(DateTime date)
        {
            this.kaufdatum = date;
        }
        public DateTime getKaufdatum()
        {
            return this.kaufdatum;
        }

        public override string ToString()
        {
            return this.typ + ";" + this.bezeichnung + ";" + this.hersteller + ";" + this.inventurnummer + ";" + this.seriennummer + ";" + this.kaufdatum.ToString();
        }

        //konstruktoren
        public Geraet()
        {
            Guid guid = Guid.NewGuid();
            this.inventurnummer = guid.ToString("D"); // D entspricht 32 Zeichen separiert mit -
        }
    }
}
