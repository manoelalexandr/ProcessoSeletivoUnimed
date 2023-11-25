using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árvore_binária_simples
{
    public class ArvoreBinaria
    {
        public No Raiz;

        //Construtor da classe, ja iniciando a raiz principal como null
        public ArvoreBinaria()
        {
            Raiz = null;
        }

        //Método que mante salvo a raiz principal e seus nós 
        public void Inserir(int valor)
        {
            Raiz = InserirRecursivo(Raiz, valor);
        }

        //Método que usa recursividade para navagar entre os nós e implementar mais a
        //direita ou mais a esquerda o próximo valor caso ele seja maior ou menor respectivamente 
        private No InserirRecursivo(No raiz, int valor)
        {
            //Se a raiz estiver nula nesse ponto ele cria uma nova instancia dela
            if (raiz == null)
            {
                raiz = new No(valor);
                return raiz;
            }
            //caso o valor seja menor que o do Nó no momento, ele verifica e vai para o nó a esquerda
            //caso esse ja tenha valor entra novamente nesse if, caso não raiz == null e ele entra
            // no primeiro if, criando uma nova instancia de nó
            if (valor < raiz.Valor)
            {
                raiz.Esquerda = InserirRecursivo(raiz.Esquerda, valor);
            }
            //caso o valor seja maior que o do Nó no momento, ele verifica e vai para o nó a direita
            //caso esse ja tenha valor entra novamente nesse if, caso não raiz == null e ele entra
            // no primeiro if, criando uma nova instancia de nó
            else if (valor > raiz.Valor)
            {
                raiz.Direita = InserirRecursivo(raiz.Direita, valor);
            }

            return raiz;
        } 
        public void PercorrerArvore(No raiz)
        {
            if (raiz != null)
            {
                PercorrerArvore(raiz.Esquerda);
                Console.Write(raiz.Valor + " ");
                PercorrerArvore(raiz.Direita);
            }
        }
    }
}
