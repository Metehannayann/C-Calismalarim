using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismadurumu1
{
    public class calisan
    {
        private string calisanismi;
        private string calismadurumu;
        private int maas;



        public string getcalisanismi()
        {
            return calisanismi;
        }

        public void setcalisanismi(string isim)
        {
            this.calisanismi = isim;
        }

        public string getcalismadurumu()
        {
            return calismadurumu;
        }

        public int getmaas()
        {
            return maas;
        }

        public void setcalismadurumu(string durum)
        {
            this.calismadurumu = durum;
        }

        public void setmaas(int maas)
        {
            this.maas = maas;
        }

        public void calisanbilgileri(string isim , string calismadurumu1 ,int maas)
        {
            Console.WriteLine("Çalışan ismi :  "+ isim  + " " + "Çalışma Durumu  : " + calismadurumu1 + " " + " Aldığı Maaş : " + maas);
        }
    }
}
