using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismadurumu1
{
    public class kopek
    {
        private string kopekİsmi;
        private string kopekCinsi;
        private int kopekYasi;


        public string getkopekİsmi()
        {
            return kopekİsmi;
        }

        public void setkopekİsmi(string kopekİsmi)
        {
            this.kopekİsmi = kopekİsmi;
        }

        public string getkopekCinsi()
        {
            return kopekCinsi;

        }
        public void setkopekCinsi(string kopekCinsi)
        {
            this.kopekCinsi = kopekCinsi;
        }

        public int getkopekYasi()
        {
            return kopekYasi;
        }

        public void setkopekYasi(int kopekYasi)
        {
            this.kopekYasi = kopekYasi;
        }

    }

}

