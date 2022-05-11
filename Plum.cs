using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    enum plum
    { nigra, americana, dulcis, salicina }
    class Plum : GardenTree
    {
        public plum sort;
       
        public Plum(int num, plum sort, int age, int fecundity)
        {
            this.sort = sort;

            this.age = age;
            this.fecundity = fecundity;
            this.num = num;
        }
      
        public override void Show()
        {
            {
                Console.Write($"Номер сливи: {num};сорт:{sort};вік: {age}; плодовитість: {fecundity};");
                
            }
        }
        public override void Grow()
        {

            Console.WriteLine("Сливи ростуть");

        }
    }
}
