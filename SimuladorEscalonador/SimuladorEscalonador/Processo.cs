using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class Processo
    {
        int processId;
        string Name;
        int Priority;
        Estados estado;
        double executionTime, tempoEspera;
        int cicleNum;

        public int getProcessId()
        {
            return this.processId;
        }

        public void setProcessId(int pid)
        {
            this.processId = pid;
        }

        public string getNome()
        {
            return this.Name;
        }

        public void setNome(string n)
        {
            this.Name = n;
        }

        public int getPrioridade()
        {
            return this.Priority;
        }

        public void setPrioridade(int pri)
        {
            this.Priority = pri;
        }

        public double getTempoExec()
        {
            return this.executionTime;
        }

        public void setTempoExec(double tempExec)
        {
            this.executionTime = tempExec;
        }

        public int getNumClicos()
        {
            return this.cicleNum;
        }

        public void setNumCiclos(int numC)
        {
            this.cicleNum = numC;
        }

        public double getTempoEspera()
        {
            return this.tempoEspera;
        }

        public void setTempoEspera(double tempEsp)
        {
            this.tempoEspera = tempEsp;
        }

        public Estados getEstado()
        {
            return this.estado;
        }

        public void setEstado(Estados state)
        {
            this.estado = state;
        }

        public Processo(int pid, string nome)
        {
            this.processId = pid;
            this.Name = nome;
        }

        public Processo(int pid, string nome, int pri, double timeExec, int numC, double tEspera)
        {
            this.processId = pid;
            this.Name = nome;
            this.Priority = pri;
            this.executionTime = timeExec;
            this.cicleNum = numC;
            this.tempoEspera = tEspera;
            this.estado = Estados.PRONTO;
        }

        public Processo(int pid, string nome, int priority, int cicleNum, double executionTime) : this(pid, nome)
        {
            this.Priority = priority;
            this.cicleNum = cicleNum;
            this.executionTime = executionTime;
        }

        public void ImprimeProcesso()
        {
            string printProcess = "";

            printProcess += "Process Id" + processId.ToString();
            printProcess += "Nome do processo" + Name.ToString();
            printProcess += "Prioridade do processo" + Priority.ToString();
            printProcess += "Tempo de execução" + executionTime.ToString();
            printProcess += "Numero de ciclos" + cicleNum.ToString();
            printProcess += "Estado do processo" + Enum.GetName(typeof(Estados), estado);
        }
    }


}
