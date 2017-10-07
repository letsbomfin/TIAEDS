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

            var readedLine = line.Split(';');
            var process = new Processo(int.Parse(readedLine[0]), readedLine[1]);
            process.setEstado

        }

    }
}
