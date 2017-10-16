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
            var processador = new Processador(0.5);

            reader.LerArquivo(escalonador);

            for (int i = 0; i < escalonador.ListasPrioridades.Length; i++)
            {
                var processo = escalonador.PegarProcessoPorPrioridade(i);
                while (processo != null)
                {
                    processo = processador.Processar(processo);
                    if (processo.getTempoExec() > 0)
                    {
                        Console.WriteLine($"Processo {processo.getProcessId()} sendo devolvido a fila, faltando {processo.getTempoExec()} para finalização");
                        escalonador.InserirNaLista(processo);
                    }
                    processo = escalonador.PegarProcessoPorPrioridade(i);
                }
            }

        }
    }
}
