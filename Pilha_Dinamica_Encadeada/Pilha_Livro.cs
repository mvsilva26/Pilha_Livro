using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Encadeada
{
    internal class Pilha_Livro
    {
        public Livro Topo { get; set; }


        public int qtd;

        public Pilha_Livro()
        {
            Topo = null;
            //Console.WriteLine("Pilha de Livros criada com sucesso: ");
        }

        public void push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;                     // aux é destruido automaticamente
            qtd++;
        }

        public void print()
        {
            if (vazia())
            {
                Console.WriteLine(" -- PILHA VAZIA -- ");
            }
            else
            {
                Console.WriteLine(" -- OS ELEMENTOS DA PILHA SÃO:  -- ");
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                    Console.WriteLine("Digite algo para parar");
                    Console.ReadKey();

                } while (aux != null);
                Console.WriteLine(" -- FIM DA IMPRESSÃO -- ");
            }
        }

        public bool vazia() // verificar se o top está vazio
        {
            if (Topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine(" -- PILHA VAZIA -- ");
            }
            else
            {
                Topo = Topo.Anterior;
                qtd--;
            }
        }

        public void Qtd()
        {
            if (vazia())
            {
                Console.WriteLine(" -- PILHA VAZIA -- ");
            }
            else
            {          
                Console.WriteLine("\nA quantidade: {0}", qtd);
            }

        }

        public void buscar()
        {
            if (vazia())
            {
                Console.WriteLine(" -- PILHA VAZIA --");
            }
            else
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1 - Buscar por ISBN ");
                Console.WriteLine("2 - Buscar por Título ");
                int opc = Convert.ToInt32(Console.ReadLine());
                Livro aux = Topo;
                Console.Clear();

                if(opc == 1)
                {
                    Console.WriteLine("Você escolheu Buscar por ISBN");
                    Console.WriteLine("Digite o ISBN do livro: ");
                    int numISBN = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        if(numISBN == aux.ISBN)
                        {
                            Console.WriteLine(aux.ToString());
                        }
                        aux = aux.Anterior;
                    } while (aux != null);
                }

                if(opc == 2)
                {
                    Console.WriteLine("Você escolheu a Buscar por Título");
                    Console.WriteLine("Digite o Título do livro: ");
                    string NumTit = Console.ReadLine();
                    do
                    {
                        if(NumTit == aux.Titulo)
                        {
                            Console.WriteLine(aux.ToString());
                        }
                        aux = aux.Anterior;
                    } while (aux != null);
                }

            }
        }


      
    }
}
