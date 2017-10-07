using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    
    public  enum Estados
    {
        ESPERA, //É o processo que foi colocado na fila de espera de E/S devido ao processador de E/S ser mais lento que a CPU principal
        EXECUCA  //A execução propriamente dita. O código está sendo processado.O,
        PRONTO,//esta na memoria esperando ser executado pelo processador
        SUSPENSO
    }
}

