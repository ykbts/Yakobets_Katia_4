using System;
using System.IO;
using System.Linq;




namespace laba4
{
    class Program
    {

        static void Main(string[] args)
        {

           

            Apple apple1 = new Apple(apple.pumila, 9, 40); apple1.Show();
            Apple apple2 = new Apple(apple.sylvestris, 9, 60); apple2.Show();


            Cherry cherry1 = new Cherry(cherry.prunus_incisa, 9, 30); cherry1.Show();
            Cherry cherry2 = new Cherry(cherry.prunus_cerasus, 12, 50); cherry2.Show(); 
            Cherry cherry3 = new Cherry(cherry.prunus_incisa, 1, 9); cherry3.Show();

            Pear pear1 = new Pear(pear.klapa, 2, 10); pear1.Show(); 
            Pear pear2 = new Pear(pear.lada, 6, 89);pear2.Show();

            Plum plum1 = new Plum(plum.nigra, 10, 27); plum1.Show();
            Plum plum2 = new Plum( plum.americana, 4, 90); plum2.Show();


            Console.WriteLine();


            List<Apple> a = new List<Apple>() { apple1, apple2 };
            foreach(Apple apple in a)
            {
               if (apple.age>8 && apple.fecundity<50 )
                {
                    
                    Console.WriteLine("Яблуню: "+apple.sort+"----необхідно пересадити.Дані про плід: "+apple.fecundity); }

            }

            List<Cherry> c = new List<Cherry>() { cherry1, cherry2, cherry3 };
            foreach (Cherry cherry in c)
            {
                if (cherry.age > 10 && cherry.fecundity < 60)
                {

                    Console.WriteLine("Вишню: "+cherry.sort+ "----необхідно пересадити.Дані про плід: " + cherry.fecundity);
                }
            }

            List<Pear> p = new List<Pear>() { pear1,pear2 };
            foreach (Pear pear in p)
            {
                if (pear.age > 6 && pear.fecundity < 50)
                {

                    Console.WriteLine("Грушу: "+pear.sort+ "----необхідно пересадити.Дані про плід: " + pear.fecundity);
                }
            }

            List<Plum> pl = new List<Plum>() { plum1, plum2 };
            foreach (Plum plum in pl)
            {
                if (plum.age > 5 && plum.fecundity < 30)
                {
                   
                    Console.WriteLine("Сливу: "+plum.sort+ "----необхідно пересадити.Дані про плід: " + plum.fecundity);
                }
            }


        }
    }
}