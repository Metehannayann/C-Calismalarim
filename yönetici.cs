using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismadurumu1
{
    public class yönetici
    {
        private string yöneticiismi;
        private string yöneticidurumu;
        private int yönmaas;

        public string getyöneticiismi()
        {
            return yöneticiismi;
        }

        public void setyöneticiismi(string yonisim)
        {
            this.yöneticiismi = yonisim;
        }

        public string getyöneticidurumu()
        {
            return yöneticidurumu;
        }

        public int getyönmaas()
        {
            return yönmaas;
        }

        public void setyöneticidurumu(string calismadurumu)
        {
            this.yöneticidurumu = calismadurumu;
        }

        public void setyönmaas(int maas)
        {
            this.yönmaas = maas;
        }

        public void calisanbilgileri(string isim, string calismadurumu1, int maas)
        {
            Console.WriteLine("Çalışan ismi :  " + isim + " " + "Çalışma Durumu  : " + calismadurumu1 + " " + " Aldığı Maaş : " + maas);
        }
    }
}
