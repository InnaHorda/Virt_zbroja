using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin_legka_bronja : Voin
    {
        public float Zdorovia_voina { get; set; }
        public float Zachyst_broni { get; set; }
        public Voin_legka_bronja (float Zdorovia_voina, float Zachyst_broni, string Nazwa_voina):base(Nazwa_voina)
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
        }

        public override void Demage_luk()
        {
             base.Demage_luk();
            float demaga1 =30f;
            float d = 0.3f;
            float dem =demaga1-( demaga1*d);
            Console.WriteLine("Удар вiд лука: " + dem);
           
        }
        public override void Demage_pulia()
        {
            base.Demage_pulia();
            float demaga2 = 50f;
            float d = 0.1f;
            float dem2 = demaga2 - (demaga2 * d);
            Console.WriteLine("Удар вiд кулi: " + dem2);
        }
        public override void Demage_knife()
        {
            base.Demage_knife();
            float demaga3 = 60f;
            float d = 0.1f;
            float dem3 = demaga3 - (demaga3 * d);
            Console.WriteLine("Удар вiд ножа: " + dem3);

        }
    }
}
