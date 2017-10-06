using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    class Processo
    {
        int processId;
        string nome;
        int prioridade, quantum, estado;
        double tempoExecucao;
        int numCiclos;

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
            return this.nome;
        }

        public void setNome(string n)
        {
            this.nome = n;
        }

        public int getPrioridade()
        {
            return this.prioridade;
        }

        public void setPrioridade(int pri)
        {
            this.prioridade = pri;
        }

        public int getQuantum()
        {
            return this.quantum;
        }

        public void setQuantum(int quant)
        {
            this.quantum = quant;
        }

        public double getTempoExec()
        {
            return this.tempoExecucao;
        }

        public void setTempoExec(double tempExec)
        {
            this.tempoExecucao = tempExec;
        }

        public int getNumClicos()
        {
            return this.numCiclos;
        }

        public void setNumCiclos(int numC)
        {
            this.numCiclos = numC;
        }

        public int getEstado()
        {
            return this.estado;
        }

        public void setEstado(int state)
        {
            this.estado = state;
        }

        public Processo(int pid, string nome)
        {
            this.processId = pid;
            this.nome = nome;
        }

        public Processo(int pid, string nome, int pri, double timeExec, int numC)
        {
            this.processId = pid;
            this.nome = nome;
            this.prioridade = pri;
            this.tempoExecucao = timeExec;
            this.numCiclos = numC;
            this.estado = Estados.PRONTO;
        }

        public void ImprimeProcesso()
        {
            string printProcess = "";

            printProcess += "Process Id" + processId.ToString();
            printProcess += "Nome do processo" + nome.ToString();
            printProcess += "Prioridade do processo" + prioridade.ToString();
            printProcess += "Tempo de execução" + tempoExecucao.ToString();
            printProcess += "Numero de ciclos" + numCiclos.ToString();
            printProcess += "Estado do processo" + estado.ToString();
        }
    }

   
}
