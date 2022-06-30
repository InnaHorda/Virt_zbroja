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
            Console.WriteLine();

        }
        public override void Demage_luk()
        {
            base.Demage_luk();
            float demaga = 30f;
            float d = 0.6f;
            float f = Hit(demaga, d);
            Console.WriteLine("Удар вiд лука: " + f);
            float t = Died1(Zdorovia_voina, Zachyst_broni, demaga, d);
            Console.WriteLine("Пiсля " + t + " влучань воин помре");

        }
        public override void Demage_pulia()
        {
            base.Demage_pulia();
            float demaga = 50f;
            float d = 0.6f;
            float f = Hit(demaga, d);
            Console.WriteLine("Удар вiд куля: " + f);
            float t = Died1(Zdorovia_voina, Zachyst_broni, demaga, d);
            Console.WriteLine("Пiсля " + t + " влучань воин помре");
        }
        public override void Demage_knife()
        {
            base.Demage_knife();
            float demaga = 60f;
            float d = 0.7f;
            float f = Hit(demaga, d);
            Console.WriteLine("Удар вiд ножа: " + f);
            float t = Died1(Zdorovia_voina, Zachyst_broni, demaga, d);
            Console.WriteLine("Пiсля " + t + " влучань воин помре");

        }
    }
}
