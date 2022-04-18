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
        private static int number = 0;
        public Pear( pear sort, int age, int fecundity)
        {
            this.sort = sort;
            this.age = age;
            this.fecundity = fecundity;
            number++;
        }
        ~Pear()
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
                Console.WriteLine($"Номер груші: {number};сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }
        public override void Grow()
        {

            Console.Write("Груші ростуть");

        }
    }
}
