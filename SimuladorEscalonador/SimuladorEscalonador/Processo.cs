﻿using System;
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
        int Priority, Quantum;
        Estados estado;
        double executionTime;
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

        public int getQuantum()
        {
            return this.Quantum;
        }

        public void setQuantum(int quant)
        {
            this.Quantum = quant;
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

        public Processo(int pid, string nome, int pri, double timeExec, int numC)
        {
            this.processId = pid;
            this.Name = nome;
            this.Priority = pri;
            this.executionTime = timeExec;
            this.cicleNum = numC;
            this.estado = Estados.PRONTO;
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