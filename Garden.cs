using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Garden
    {
        public string Name { get; set; }
        public List<Object> ListTree { get; set; }
        public Garden(string Name)
        {
            this.Name = Name;
            ListTree = new List<Object>();
        }

        public void Add(Object obj)
        {
            ListTree.Add(obj);
        }

      
        public void Peresadka()
        {
            foreach (var obj in ListTree)
            {
                Type derevo = obj.GetType();
                if (derevo.Equals(typeof(Apple)))
                {
                    Apple apple = (Apple)obj;

                    if (apple.age > 8 && apple.fecundity < 50)
                    {
                        Console.WriteLine();
                        apple.Show();
                        Console.Write("-------необхідно пересадити");
                    }


                }
                else if (derevo.Equals(typeof(Cherry)))
                {
                    Cherry cherry = (Cherry)obj;
                    if (cherry.age > 10 && cherry.fecundity < 60)
                    {

                        Console.WriteLine();
                        cherry.Show();
                        Console.Write("-------необхідно пересадити");
                    }

                }
                if (derevo.Equals(typeof(Pear)))
                {
                    Pear pear = (Pear)obj;
                    if (pear.age > 6 && pear.fecundity < 50)
                    {
                        Console.WriteLine();
                        pear.Show();
                        Console.Write("-------необхідно пересадити");
                    }

                }
                if (derevo.Equals(typeof(Plum)))
                {
                    Plum plum = (Plum)obj;
                    if (plum.age > 5 && plum.fecundity < 30)
                    {
                        Console.WriteLine();
                        plum.Show();
                        Console.Write("-------необхідно пересадити");
                    }
                }

            }
        }



        public void Plid()
        {
            Console.WriteLine();
            foreach (var obj in ListTree)
            {
                Type derevo = obj.GetType();
                if (derevo.Equals(typeof(Apple)))
                {
                    Apple apple = (Apple)obj;
                    Console.WriteLine("Номер яблуні: " + apple.num + "; дані про плід:" + apple.fecundity);
                }



                else if (derevo.Equals(typeof(Cherry)))
                {
                    Cherry cherry = (Cherry)obj;
                    Console.WriteLine("Номер вишні: " + cherry.num + "; дані про плід:" + cherry.fecundity);

                }
                if (derevo.Equals(typeof(Pear)))
                {
                    Pear pear = (Pear)obj;
                    Console.WriteLine("Номер груші: " + pear.num + "; дані про плід:" + pear.fecundity);

                }
                if (derevo.Equals(typeof(Plum)))
                {
                    Plum plum = (Plum)obj;
                    Console.WriteLine("Номер сливи: " + plum.num + "; дані про плід:" + plum.fecundity);
                }

            }
        }
    }
}