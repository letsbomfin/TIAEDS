using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Processador
    {
        public double Quantum { get; set; }

        public Processador(double quantum)
        {
            this.Quantum = quantum;
        }
        public Processo Processar(Processo processo)
        {
            Console.WriteLine($"Iniciando execução de processo {processo.getProcessId()}");
            processo.setEstado(Estados.EXECUTA);
            Thread.Sleep(TimeSpan.FromSeconds(processo.getTempoExec()));
            processo.setTempoExec(processo.getTempoExec() - Quantum);
            Console.WriteLine($"Processo {processo.getProcessId()} executa por Quantum {Quantum}");
            if (processo.getTempoExec() <= 0)
            {
                processo.setTempoExec(0);
                Console.WriteLine($"Processo {processo.getProcessId()} finalizado");
            }
            processo.setEstado(Estados.PRONTO);
            return processo;

        }
    }
}
