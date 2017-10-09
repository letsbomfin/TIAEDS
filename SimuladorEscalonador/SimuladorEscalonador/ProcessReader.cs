using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class ProcessReader
    {
        public void LerArquivo(MyList list)
        {
            int index = 0;

            string line;
            // Ler uma linha do arquivo
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"Processos.txt");
            while ((line = file.ReadLine()) != null)
            {
                var prod = CreateProcess(line);

                index++;

            }
            file.Close();
        }

        public Processo CreateProcess(string line)
        {
            //35;/usr/lib/evolution/evolution-addressbook-factory;4;0,65;7

            string [] readedLine = line.Split(';');

            /* NÃO ENTENDI AQUI DIREITO */
            //var process = new Processo(int.Parse(readedLine[0]), readedLine[1]);
            //process.setEstado 

            //para preencher a lista de processos
            int processId = int.Parse(readedLine[0]);
            string Name = readedLine[1];
            int Priority = int.Parse(readedLine[2]);
            int cicleNum = int.Parse(readedLine[3]);
            double executionTime = double.Parse(readedLine[4]);

            /* SEI LA SE ISSO TA CERTO RSS */
            MyList minhaLista = new MyList();
            Processo processo = new Processo(processId, Name, Priority, cicleNum, executionTime);
            minhaLista.inserirFim(processo);
        }

        }
    }
