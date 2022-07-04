using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin
    {
        public string Nazwa_voina { get; set; }
        public float HP { get; set; }
        public float Kof { get; set; }
        public float Add_life { get; set; }
       
        public Voin (string Nazwa_voina, float HP,float Kof,float Add_life)
        {
            this.Nazwa_voina = Nazwa_voina;
            this.HP = HP;
            this.Kof = Kof;
            this.Add_life = Add_life;
           
        }
        enum Damege1
        {
                Luk=5,
                Kniwe=10,
                Pula=15
       }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Воiн: " + Nazwa_voina);
            float Life = HP + (HP * Add_life);
            Console.WriteLine("Life: " + Life);
            
        }

        public virtual void Damega()
        {
            float Dem = (float)Damege1.Luk * Kof;
            Console.WriteLine("Damege Luk " +Dem);
            float Dem1 = (float)Damege1.Pula * Kof;
            Console.WriteLine("Damege Pula " + Dem1);
            float Dem2 = (float)Damege1.Kniwe * Kof;
            Console.WriteLine("Damege Luk " + Dem2);
        }
        
          
       
    }
}
