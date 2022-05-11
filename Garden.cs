using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Garden
    {
        public static long Peresadka(List<Apple> a, List<Cherry> c, List<Pear> p, List<Plum> pl)
            {
            foreach (Apple apple in a)
            {
                if (apple.age > 8 && apple.fecundity < 50)
                {
                    apple.Show();
                    Console.Write("-------необхідно пересадити");
                }

            }
            Console.WriteLine();
            foreach (Cherry cherry in c)
            {
                if (cherry.age > 10 && cherry.fecundity < 60)
                {

                    cherry.Show();
                    Console.Write("-------необхідно пересадити");
                }
            }
            Console.WriteLine();
            foreach (Pear pear in p)
            {
                if (pear.age > 6 && pear.fecundity < 50)
                {
                    pear.Show();
                    Console.Write("-------необхідно пересадити");
                }
            }
            Console.WriteLine();
            foreach (Plum plum in pl)
            {
                if (plum.age > 5 && plum.fecundity < 30)
                {

                    plum.Show();
                    Console.Write("-------необхідно пересадити");
                }
            }
            return 0;
        }



        public static long Plid(List<Apple> a, List<Cherry> c, List<Pear> p, List<Plum> pl)
        {
            Console.WriteLine();
            foreach (Apple apple in a)
            {
               
                    Console.WriteLine("Номер яблуні: "+apple.num+"; дані про плід:"+ apple.fecundity);
               

            }
            Console.WriteLine();
            foreach (Cherry cherry in c)
            {
                Console.WriteLine("Номер вишні: " + cherry.num + "; дані про плід:" + cherry.fecundity);
            }
            Console.WriteLine();
            foreach (Pear pear in p)
            {
                Console.WriteLine("Номер груші: " + pear.num + "; дані про плід:" + pear.fecundity);
            }
            Console.WriteLine();
            foreach (Plum plum in pl)
            {
                Console.WriteLine("Номер сливи: " + plum.num + "; дані про плід:" + plum.fecundity);
            }
            return 0;
        }



































        /*
                {foreach (var obj in dereva)
                    {
                        Type derevo=obj.GetType();
                        if (derevo.Equals(typeof(Apple)))
                        {
                            foreach (Apple apple in dereva)
                            {
                                if (apple.age > 8 && apple.fecundity < 50)
                                {

                                    Console.WriteLine("Яблуню: " + apple.sort + "----необхідно пересадити.Дані про плід: " + apple.fecundity);
                                }

                            }
                        }
                       else if (derevo.Equals(typeof(Cherry)))
                        {
                            foreach (Cherry cherry in dereva)
                            {
                                if (cherry.age > 10 && cherry.fecundity < 60)
                                {

                                    Console.WriteLine("Вишню: " + cherry.sort + "----необхідно пересадити.Дані про плід: " + cherry.fecundity);
                                }
                            }
                        }
                        if (derevo.Equals(typeof(Pear)))
                        {
                            foreach (Pear pear in dereva)
                            {
                                if (pear.age > 6 && pear.fecundity < 50)
                                {

                                    Console.WriteLine("Грушу: " + pear.sort + "----необхідно пересадити.Дані про плід: " + pear.fecundity);
                                }
                            }
                        }
                        if (derevo.Equals(typeof(Plum)))
                        {
                            foreach (Plum plum in dereva)
                            {
                                if (plum.age > 5 && plum.fecundity < 30)
                                {

                                    Console.WriteLine("Сливу: " + plum.sort + "----необхідно пересадити.Дані про плід: " + plum.fecundity);
                                }
                            }
                        }
                        else Console.Write("nhhhhhhhhhhhhhhhhhhhhhhh");
                    }

                    return 1;*/
    }

}
    

  

  