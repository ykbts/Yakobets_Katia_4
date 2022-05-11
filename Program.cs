using System;
using System.IO;
using System.Linq;




namespace laba4
{
    class Program
    {

        static void Main(string[] args)
        {
          

            Garden g = new Garden("1");
            g.Add(new Apple(1, apple.pumila, 9, 40));
            g.Add(new Apple(2, apple.sylvestris, 9, 60));
            g.Add(new Cherry(3, cherry.prunus_incisa, 9, 30));
            g.Add(new Cherry(4, cherry.prunus_cerasus, 12, 50));
            g.Add(new Cherry(5, cherry.prunus_incisa, 1, 9));
            g.Add(new Pear(6, pear.klapa, 2, 10));
            g.Add(new Pear(7, pear.lada, 6, 89));
            g.Add(new Plum(8, plum.nigra, 10, 27));
            g.Add(new Plum(9, plum.americana, 4, 90));

          
            g.Plid();
            g.Peresadka();

        }
    }
}