using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEscalonador
{
    public class MyList
    {
        public Item first, last;

        /// <summary>
        /// Construtor. Cria uma lista vazia com sentinela.
        /// </summary>
        public MyList()
        {
            this.first = new Item(null);
            this.last = this.first;
        }

        /// <summary>
        /// Busca dados. Precisa receber um objeto com valor igual ao que se deseja buscar.
        /// O objeto precisa ter um método sobrescrito Equals para indicar se é igual a outro objeto da mesma classe
        /// </summary>
        /// <param name="process">O objeto com o valor a ser buscado</param>
        /// <returns>O objeto procurado ou null, caso não exista</returns>
        public Process buscar(Process process)
        {
            Item aux = this.first.prox;
            while (aux != null)
            {
                if (aux.process.Equals(process))
                    return aux.process;
                else aux = aux.prox;
            }
            return null;
        }

        /// <summary>
        /// Insere no final da lista.
        /// </summary>
        /// <param name="process">Objeto novo que se deseja inserir</param>
        public void inserirFim(Process process)
        {
            Item aux = new Item(process);
            this.last.prox = aux;
            this.last = aux;
        }
    }
}
