using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class ProcessReader
    {
        public void LerArquivo(Escalonador escalonador)
        {
            if (escalonador != null)
            {
                string line;
                // Ler uma linha do arquivo
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"Processos.txt");
                while ((line = file.ReadLine()) != null)
                {
                    var process = CreateProcess(line);
                    escalonador.InserirNaLista(process);

                }
                file.Close();
            }
            else
            {
                throw new NullReferenceException("Inicialize a lista antes de tentar fazer uma leitura de dados, pois a leitura já insere os dados na lista");
            }

        }

        public Processo CreateProcess(string line)
        {
            //35;/usr/lib/evolution/evolution-addressbook-factory;4;0,65;7

            var readedLine = line.Split(';');
            var process = new Processo(int.Parse(readedLine[0]), readedLine[1]);
            process.setPrioridade(int.Parse(readedLine[2]));
            process.setTempoExec(double.Parse(readedLine[3]));
            process.setNumCiclos(int.Parse(readedLine[4]));
            process.setEstado(Estados.PRONTO);
            return process;
        }

    }
}
