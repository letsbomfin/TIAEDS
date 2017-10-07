using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Item
    {
        public Processo process;
        public Item prox;


        public Item(Processo p)
        {
            this.process = p;
            this.prox = null;
        }
    }
}
