using System;
using System.Collections.Generic;

namespace Virt_zbroja
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Voin> Voiny = new List<Voin>();
            Voiny.Add (new Voin_legka_bronja(60f, 40f, "Лучник"));
            Voiny.Add(new Voin_tiazka_bronja(60f, 60f, "мечник"));
           foreach(Voin V in Voiny)
            {
                V.Print();
                V.Demage_luk();
                V.Demage_pulia();
                V.Demage_knife();
  
            }
        }
    }
}
