using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    enum apple
    { fucsa, pumila, sylvestris }
    class Apple: GardenTree
    {
       private static int number=0;
        public apple sort;
       
      public Apple( apple sort, int age,int fecundity)
        {
            number++;
            this.sort = sort;
            this.age= age;
            this.fecundity = fecundity;
           
           
        }
      
      
        public override void Grow()
        {
            {
                Console.WriteLine("Яблуні ростуть");
               
            }
        }
      
        ~Apple()
        {
            number--;
        }
        public static int Num()
        {
            return number;
        }
        public override void Show()
        {
            {
                Console.WriteLine($"Номер яблуні: {number}; сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }


    }
}
