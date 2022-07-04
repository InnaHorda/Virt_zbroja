using System;
using System.Collections.Generic;

namespace Virt_zbroja
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Voin> Voiny = new List<Voin>();
            Voiny.Add (new Voin_legka_bronja( "Лучник", 100f));
            Voiny.Add(new Voin_tiazka_bronja("мечник", 200f));
           foreach(Voin V in Voiny)
            {
                V.Print();
                
  
            }
        }
    }
}
