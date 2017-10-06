using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public static class Estados
    {
        public const int ESPERA = 0; //É o processo que foi colocado na fila de espera de E/S devido ao processador de E/S ser mais lento que a CPU principal
        public const int EXECUCAO = 1; //A execução propriamente dita. O código está sendo processado.
        public const int PRONTO = 2; //esta na memoria esperando ser executado pelo processador
        public const int SUSPENSO = 3; 
    }
}

