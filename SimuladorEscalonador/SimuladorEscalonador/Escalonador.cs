using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Escalonador
    {
        public static MyList minhaLista = new MyList();

        public static Processo executando;
        public static Thread execucao;
        public static Estados estado;

    }
}
