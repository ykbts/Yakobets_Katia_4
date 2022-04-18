using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    abstract class GardenTree
    {
      
        public int age { get; set; }
        public int fecundity { get; set; }
       

        public abstract void Grow();
        public abstract void Show();


    }
}
