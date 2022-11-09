using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public abstract class Ordu
    {
        private string? _konumlandıgıYer;
        private int _ordukisisayisi;

        public abstract string? Orduİsmi { get; set; }
        public abstract string? KonumlandıgıYer { get; set; }
        public abstract int OrduKisiSayısı { get; set; }


        public abstract void AttackWay();

        public abstract void KullandıgıEkipman();

        public abstract int Ekipmansayısı(int ekp);

       


    }
}
