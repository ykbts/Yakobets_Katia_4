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
       private static int number=1;
        public apple sort;
       
      public Apple(int num, apple sort, int age,int fecundity)
        {
            this.sort = sort;
            this.age= age;
            this.fecundity = fecundity;
            this.num = num;

        }
      
      
        public override void Grow()
        {
            {
                Console.WriteLine("Яблуні ростуть");
               
            }
        }
      
      
        public override void Show()
        {
            {
                Console.Write($"Номер яблуні: {num}; сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }
        


    }
}
