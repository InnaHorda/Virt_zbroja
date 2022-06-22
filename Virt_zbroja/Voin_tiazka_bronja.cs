using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin_tiazka_bronja:Voin
    {
        public float Zdorovia_voina { get; set; }
        public float Zachyst_broni { get; set; }
        public Voin_tiazka_bronja(float Zdorovia_voina, float Zachyst_broni, string Nazwa_voina) : base(Nazwa_voina)
        {
            this.Zdorovia_voina = Zdorovia_voina;
            this.Zachyst_broni = Zachyst_broni;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Здоровя воiна: " + Zdorovia_voina);
            float life = Life(Zdorovia_voina, Zachyst_broni);
            Console.WriteLine("Life: " + life);
            float demaga1 = Demage_luk(life);
            Console.WriteLine("Удар вiд лука: " + demaga1);
            float demaga2 = Demage_pulia(life);
            Console.WriteLine("Удар вiд : " + demaga2);
        }
    }
}
