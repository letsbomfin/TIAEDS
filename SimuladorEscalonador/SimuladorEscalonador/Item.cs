using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Item
    {
        public Process process;
        public Item prox;


        public Item(Process p)
        {
            this.process = p;
            this.prox = null;
        }
    }
}
