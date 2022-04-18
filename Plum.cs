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
        private static int number = 0;
        public Plum( plum sort, int age, int fecundity)
        {
            this.sort = sort;

            this.age = age;
            this.fecundity = fecundity;
            number++;
        }
        ~Plum()
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
                Console.WriteLine($"Номер сливи: {number};сорт:{sort};вік: {age}; плодовитість: {fecundity};");

            }
        }
        public override void Grow()
        {

            Console.WriteLine("Сливи ростуть");

        }
    }
}
