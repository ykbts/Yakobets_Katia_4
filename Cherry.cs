using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    enum cherry
    { prunus_cerasus, prunus_incisa }
    class Cherry : GardenTree
    {
        public cherry sort;
        private static int number = 0;
        public Cherry(int num, cherry sort, int age, int fecundity) {
          
            this.age = age;
            this.fecundity = fecundity;
            this.sort = sort;
            this.num = num;
            
        }
      
        public override void  Show()
        {
            {
               
                Console.Write($"Номер вишні: {num};сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }
        public override void Grow()
        {
            
                Console.WriteLine("Вишні ростуть");
            
        }

      
    }
}
