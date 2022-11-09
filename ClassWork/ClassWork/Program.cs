using ClassWork;

namespace ClassWork;

class Program
{
    public static void Main()
    {
        KaraOrdusu karaOrdusu = new KaraOrdusu("Ölüm Ordusu");

        HavaOrdusu havaOrdusu = new HavaOrdusu("ŞahinPençe Ordusu");

        Console.WriteLine($"{karaOrdusu.Orduİsmi} {karaOrdusu.KonumlandıgıYer} {karaOrdusu.OrduKisiSayısı}");
        Console.WriteLine($"{havaOrdusu.Orduİsmi} {havaOrdusu.KonumlandıgıYer} {havaOrdusu.OrduKisiSayısı}");

        Console.WriteLine("Kara ordusu atak yap");
        karaOrdusu.AttackWay();
        Console.WriteLine("Hava ordusu atak yap");
        havaOrdusu.AttackWay();
        Console.WriteLine("Kara ordusu Hangi Ekipmanları Kullanıyorsun?");
        karaOrdusu.KullandıgıEkipman();
        Console.WriteLine("Hava ordusu Hangi Ekipmanları Kullanıyorsun?");
        havaOrdusu.KullandıgıEkipman();

        Console.WriteLine("Kara ordusu ekipman sayını bildir!");
        Console.WriteLine(karaOrdusu.Ekipmansayısı(150)); 
        Console.WriteLine("Hava ordusu ekipman sayını bildir!");
        Console.WriteLine(havaOrdusu.Ekipmansayısı(100));
        Console.WriteLine("-----------------------------------------------------------------------");

        havaOrdusu.personelEkle(1200);
        Console.WriteLine(" Hava ordusu Kişi Sayısı:{0}",havaOrdusu.OrduKisiSayısı);
        Console.WriteLine("-----------------------------------------------------------------------");
        karaOrdusu.personelCıkar(1000);
        Console.WriteLine(" Kara ordusu Kişi Sayısı:{0}", karaOrdusu.OrduKisiSayısı);


        //Console.WriteLine($"{ordu.Orduİsmi} {ordu.KonumlandıgıYer} {ordu.OrduKisiSayısı}");


    }
}

