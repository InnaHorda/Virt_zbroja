using System;
using System.Collections.Generic;

namespace Virt_zbroja
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Voin> Voiny = new List<Voin>();
            Voiny.Add(new Voin("Ivan", 100, 1, 0));
            Voiny.Add(new Voin_legka_bronja("Лучник", 100, 0.6f, 0.5f)); ;
            Voiny.Add(new Voin_tiazka_bronja("мечник", 100, 0.2f,1));
           foreach(Voin V in Voiny)
            {
                V.Print();
                V.Damega();
                
  
            }
        }
    }
}
