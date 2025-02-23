using System.Transactions;

namespace calismadurumu1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             kopek kopek = new kopek();
             kedi kedi = new kedi();

             kopek.setkopekYasi(5);
             kopek.setkopekİsmi("Karabaş");
             kopek.setkopekCinsi("shitzhu");

             kopek.hayvanBilgileri(kopek.getkopekİsmi(), kopek.getkopekCinsi(), kopek.getkopekYasi());

             Console.WriteLine(kopek.getkopekİsmi());
             Console.WriteLine(kopek.getkopekCinsi());
             Console.WriteLine(kopek.getkopekYasi());
             kopek.KopekSesi();
             kopek.Uyuyor(kopek.getkopekİsmi());

             Console.WriteLine("-------------------------");
             kedi.setkediİsmi("Minnoş");
             kedi.setkediCinsi("British");
             kedi.setKediYasi(2);



             kedi.Uyuyor(kedi.getkediİsmi());
             kedi.hayvanBilgileri(kedi.getkediİsmi(), kedi.getkediCinsi(), kedi.getkediYasi());
             */


            calisan calısan1 = new calisan();
            personel personel1 = new personel();
            yönetici yönetici1 = new yönetici();
            


            calısan1.setcalisanismi("Ali");
            calısan1.setcalismadurumu("Çalışan");
            calısan1.setmaas(500);

            personel1.setpersonelismi("Mehmet");
            personel1.setpersoneldurumu("personel");
            personel1.setpersonelmaas(5000);


            yönetici1.setyöneticiismi("Metehan");
            yönetici1.setyöneticidurumu("Yönetici");
            yönetici1.setyönmaas(50000);



            calısan1.calisanbilgileri(calısan1.getcalisanismi(), calısan1.getcalismadurumu(), calısan1.getmaas());


            Console.WriteLine(calısan1.getcalisanismi());
            Console.WriteLine(calısan1.getcalismadurumu());
            Console.WriteLine(calısan1.getmaas());



            Console.WriteLine("-------------------------------------");
            
            yönetici1.calisanbilgileri(yönetici1.getyöneticiismi(), yönetici1.getyöneticidurumu(), yönetici1.getyönmaas());

            Console.WriteLine(yönetici1.getyöneticiismi());
            Console.WriteLine(yönetici1.getyöneticidurumu());
            Console.WriteLine(yönetici1.getyönmaas());

            Console.WriteLine("--------------------------------------");
            personel1.calisanbilgileri(personel1.getpersonelismi(), personel1.getpersoneldurumu(), personel1.getpersonelmaas());
            
            Console.WriteLine(personel1.getpersonelismi());
            Console.WriteLine(personel1.getpersoneldurumu());
            Console.WriteLine(personel1.getpersonelmaas());




        }
    }
}
