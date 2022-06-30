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
            Console.WriteLine();
            Console.WriteLine("Воiн: " + Nazwa_voina);
            
        }
         public static float Life(float Zdorovia_voina, float Zachyst_broni)
        { return Zachyst_broni + Zdorovia_voina;   
        }
        public static float Hit(float demaga, float d)
        {

            float dem = demaga - (demaga * d);
            return dem;
        }
        public virtual void Demage_luk()
        {            
        }
        public virtual void Demage_pulia()
        {
        }
        public virtual void Demage_knife()
        {
        }
      
       public static float Died1(float Zdorovia_voina, float Zachyst_broni,float demaga,float d)
        {
            float Life1 = Life(Zdorovia_voina, Zachyst_broni);  
            float Hit1 = Hit(demaga, d);
            float r = 0f;
            float counter = 0f;
            for (float i=0; i<Life1; i++)
            {
                if (Life1>0)
                {
                    r = Life1 - Hit1;
                    Life1 = r;
                    counter++;
                }
                else
                {
                    break;
                }
               
            }
  
           return counter;
          
       }
    }
}
