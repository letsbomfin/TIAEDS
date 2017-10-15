using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ProcessReader();
            var escalonador = new Escalonador();

            reader.LerArquivo(escalonador);
        }
    }
}
