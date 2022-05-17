using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Immobile
    {
        public string Codice { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }

        public Immobile(string Codice, string Indirizzo, string Cap, string Citta, int Superficie)
        {
            this.Codice = Codice;
            this.Indirizzo = Indirizzo;
            this.Cap = Cap;
            this.Citta = Citta;
            this.Superficie = Superficie;
        }

        public override string ToString()
        {
            return string.Format("Immobile: {0}", Write());
        }

        protected virtual string Write()
        {
            return string.Format("\nCodice: {0}\nIndirizzo: {1}\nCap: {2}\nCittà: {3}\nSuperficie: {4}",
                this.Codice, this.Indirizzo, this.Cap, this.Citta, this.Superficie);
        }

        public virtual bool Contains(string key)
        {
            if (this.Codice.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.Cap.Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if (this.Superficie.ToString().Contains(key)) return true;
            else return false;
        }
    }
}