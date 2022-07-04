using System;
using System.Collections.Generic;
using System.Text;

namespace Virt_zbroja
{
    class Voin_tiazka_bronja:Voin
    {
        
        public Voin_tiazka_bronja( string Nazwa_voina, float HP,float Kof,float Add_life) : base(Nazwa_voina,HP,Kof,Add_life)
        {
           
        }
        public override void Print()
        {
            base.Print();
            

        }
        public override void Damega()
        {
            base.Damega();
        }

    }
}
