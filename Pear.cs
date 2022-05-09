using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    enum pear
    { lada, klapa }
    class Pear : GardenTree
    {
        public pear sort;
        public Pear(int num, pear sort, int age, int fecundity)
        {
            this.num= num;  
            this.sort = sort;
            this.age = age;
            this.fecundity = fecundity;
           
        }
     
        public override void Show()
        {
            {
                Console.Write($"Номер груші: {num};сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }
        public override void Grow()
        {

            Console.Write("Груші ростуть");

        }
    }
}
