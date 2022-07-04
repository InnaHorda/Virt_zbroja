using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin
    {
        public string Nazwa_voina { get; set; }
        public float HP { get; set; }
        public Voin (string Nazwa_voina, float HP)
        {
            this.Nazwa_voina = Nazwa_voina;
            this.HP = HP;

        }
        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Воiн  : " + Nazwa_voina);
            
        }
        public virtual void Damega()
        {

        }
        
          
       
    }
}
