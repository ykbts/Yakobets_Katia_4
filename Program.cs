using System;
using System.IO;
using System.Linq;




namespace laba4
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Apple> a = new List<Apple>()
            {
             new Apple(1,apple.pumila, 9, 40),
             new Apple(2,apple.sylvestris, 9, 60),
            };
            List<Cherry> c = new List<Cherry>()
            {
                 new Cherry(3,cherry.prunus_incisa, 9, 30),
             new Cherry(4,cherry.prunus_cerasus, 12, 50),
             new Cherry(5,cherry.prunus_incisa, 1, 9),
            };

            List<Pear> p = new List<Pear>()
            {

             new Pear(6,pear.klapa, 2, 10),
             new Pear(7,pear.lada, 6, 89),
            };
            List<Plum> pl = new List<Plum>()
            {
             new Plum(8,plum.nigra, 10, 27),
             new Plum(9,plum.americana, 4, 90),

            };


            List<Object> dereva = new List<Object>();
            dereva.Add(a); dereva.Add(c); dereva.Add(p); dereva.Add(pl);


            Garden.Peresadka(a, c, p, pl);

            Garden.Plid(a, c, p, pl);


        }
    }
}