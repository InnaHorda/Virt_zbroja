using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin
    {
        public string Nazwa_voina { get; set; }
        public Voin (string Nazwa_voina)
        {
            this.Nazwa_voina = Nazwa_voina;
        }
        public virtual void Print()
        {
            Console.WriteLine("Воiн: " + Nazwa_voina);
        }
         public virtual float Life(float Zdorovia_voina, float Zachyst_broni)
        { return Zachyst_broni + Zdorovia_voina;
            
        }
        public virtual float Demage_luk(float life )
        {
            float a = 0.25f;
            return life * a;
        }
        public virtual float Demage_pulia(float life)
        {
            float b = 1f;
            return life * b;
        }
        
    }
}
