using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Escalonador
    {
        public int Incremento = 10;
        public MyList[] ListasPrioridades { get; set; }
        public MyList[] ListaAux { get; set; }


        public Escalonador()
        {
            ListasPrioridades = new MyList[10];
        }

        public void InserirNaLista(Processo processo)
        {
            var prioridade = processo.getPrioridade();
            if (ListasPrioridades.Length < prioridade)
            {
                AumentarPrioridade();
                ListasPrioridades[prioridade] = new MyList();
                ListasPrioridades[prioridade].inserirFim(processo);
            }
            else if (ListasPrioridades[prioridade] == null)
            {
                ListasPrioridades[prioridade] = new MyList();
                ListasPrioridades[prioridade].inserirFim(processo);
            }
            else
            {
                ListasPrioridades[prioridade].inserirFim(processo);
            }
            Console.WriteLine($"Id: {processo.getProcessId()}| Processo {processo.getNome()}| Prioridade {processo.getPrioridade()}| Inserido na lista de prioridade {prioridade} ");
        }

        private void AumentarPrioridade()
        {
            ListaAux = ListasPrioridades;
            ListasPrioridades = new MyList[ListaAux.Length + Incremento];
            for (int i = 0; i < ListasPrioridades.Length; i++)
            {
                ListasPrioridades[i] = ListaAux[i];
            }
        }

    }
}
