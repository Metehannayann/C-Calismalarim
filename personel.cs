using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismadurumu1
{
    public class personel
    {
        private string personelismi;
        private string personeldurumu;
        private int personelmaas;

        public string getpersonelismi()
        {
            return personelismi;
        }

        public void setpersonelismi(string perisim)
        {
            this.personelismi = perisim;
        }
        public string getpersoneldurumu()
        {
            return personeldurumu;
        }
        public int getpersonelmaas()
        {
            return personelmaas;
        }

        public void setpersoneldurumu(string calismadurumu)
        {
            this.personeldurumu = calismadurumu;
        }

        public void setpersonelmaas(int maas1)
        {
            this.personelmaas = maas1;

        }
        public void calisanbilgileri(string isim, string calismadurumu1, int maas)
        {
            Console.WriteLine("Çalışan ismi :  " + isim + " " + "Çalışma Durumu  : " + calismadurumu1 + " " + " Aldığı Maaş : " + maas);
        }
    }
}
