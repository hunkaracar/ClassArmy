using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class HavaOrdusu : Ordu,IHesaplaOrduPrp
    {

        private string _orduismi;
        private string _konumlandıgıyer;
        private int _ordukisisayisi;

        public HavaOrdusu(string orduismi)
        {
            Orduİsmi = orduismi;
            KonumlandıgıYer = "İstanbul";
            OrduKisiSayısı = 100000;

        }

        public HavaOrdusu(string? orduİsmi, string? konumlandıgıYer, int orduKisiSayısı)
        {
            Orduİsmi = orduİsmi;
            KonumlandıgıYer = konumlandıgıYer;
            OrduKisiSayısı = orduKisiSayısı;
        }

        public override string? Orduİsmi { get => _orduismi; set => _orduismi = value; }
        public override string? KonumlandıgıYer { get => _konumlandıgıyer; set => _konumlandıgıyer = value; }
        public override int OrduKisiSayısı { get => _ordukisisayisi; set => _ordukisisayisi = value; }

        public override void AttackWay()
        {
            Console.WriteLine("Sol kanattan saldırın!!!"); ;
        }

        public override int Ekipmansayısı(int ekp)
        {
            return ekp;
        }

        public override void KullandıgıEkipman()
        {
            Console.WriteLine("Şuan F-16 ve Helikopter kullanıyoruz..."); ;
        }

        public int personelCıkar(int value)
        {
           OrduKisiSayısı -= value;

            return OrduKisiSayısı;
        }

        public int personelEkle(int dvalue)
        {
            OrduKisiSayısı += dvalue;

            return OrduKisiSayısı;
        }
        
    }
}
