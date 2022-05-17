using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Villa : Appartamento
    {
        public int MqGiardino { get; set; }

        public Villa(string Codice, string Indirizzo, string Cap, string Citta, int Superficie, int NumVani, int NumBagni, int MqGiardino) : base (Codice, Indirizzo, Cap, Citta, Superficie, NumVani, NumBagni)
        {
            this.MqGiardino = MqGiardino;
        }

        public override string ToString()
        {
            return string.Format("Villa: {0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nMq Giardino: {1}", 
                base.Write(), this.MqGiardino);
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.MqGiardino.ToString().Contains(key)) return true;
            else return false;
        }
    }
}