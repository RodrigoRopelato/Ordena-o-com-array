using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Ordenação_algotimo_com_array
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciaAplicação();

        }
               
        private static void IniciaAplicação()
        {
           
            bool continuar = true;
            string opcao;
            int qtdPosicoes = QuantidadeArray();
            int[] numeros   = new int[qtdPosicoes];
            int[] Ordenados = new int[qtdPosicoes];
            Console.Clear();
            do
            {
                               
                Menu();  
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
                //numeros.CopyTo(Ordenados,0);
                for (int p = 0; p < qtdPosicoes; p++)
                {
                    Ordenados[p] = numeros[p];
                }
                
                switch (opcao)
                {
                    case "1":
                        numeros = CadastrarNumerosArray(qtdPosicoes);
                        break;

                    case "2":
                        numeros = CadastrarNumerosArrayAleatorio(qtdPosicoes);
                        break;

                    case "3":
                        ExibirArray(numeros);
                        break;

                    case "4":
                        ExibirArray(numeros);
                        OrdenarArrayInsertion(Ordenados);
                        break;

                    case "5":
                        ExibirArray(numeros);
                        OrdenarArrayGnomeSort(Ordenados);
                        break;

                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                
                Console.ReadKey();
                Console.Clear();

            } while (continuar);
        }


        //Gnome Sort APRESENTAR NA PROXIMA AULA
        //O Gnome Sort é um algoritmo com uma sequencia grande de trocas como o Bubble Sort, 
        //porem ele é similar ao Insertion Sort com a diferença de levar um elemento para sua posição correta.
        //ver link: https://pt.wikipedia.org/wiki/Gnome_sort
        private static void OrdenarArrayGnomeSort(int[] vetor)
        {
            Console.WriteLine("\nLista Ordenada Com Algoritimo GnomeSort");

            int p = 0;
            int aux;
            while (p < (vetor.Length - 1))
            {
                if (vetor[p] > vetor[p + 1])
                {
                    aux = vetor[p];
                    vetor[p] = vetor[p + 1];
                    vetor[p + 1] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }
            for (int h = 0; h < vetor.Length; h++)
            {
                Console.Write("{0}, ", vetor[h]);
            }

        }

        private static void OrdenarArrayInsertion(int[] vetor)
        {
            Console.WriteLine("\nLista Ordenada Com Algoritimo InsertionSort");


            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j -= 1;
                }
                vetor[j] = atual;
            }
            for (int h = 0; h < vetor.Length; h++)
            {
                Console.Write("{0}, ", vetor[h]);
            }

        }

        private static int QuantidadeArray()
        {
            
            Console.WriteLine("Para Iniciar a Aplicação");
            Console.Write("Informe o tamanho do array que deseja criar:");
            int qtdPosicoes = int.Parse(Console.ReadLine());

            return qtdPosicoes;
        }


        private static void ExibirArray(int[] lista)
        {
            Console.WriteLine("\nLista");
            
            for(int i = 0; i < lista.Length; i++)
            {   
               
                Console.Write("{0}, ",(lista[i]));
            }

            Console.WriteLine();
            
        }
        private static int[] CadastrarNumerosArrayAleatorio(int qtdPosicoes)
        {
            Console.Clear();

            int[] numeros = new int[qtdPosicoes];
            Random num = new Random ();
                        
            for (int i = 0; i < qtdPosicoes; i++)
            {
                numeros[i] = num.Next(50);
            }
            Console.WriteLine("Cadastro de Lista efetuado com sucesso!");
            Console.WriteLine("Pressione ENTER para continuar");


            return numeros;

        }

        private static int[] CadastrarNumerosArray(int qtdPosicoes)
        {
            Console.Clear();

            int[] numeros = new int[qtdPosicoes];

            Console.WriteLine("Entre com uma lista de {0} numeros, apertando enter ao fim de cada numero", qtdPosicoes);
            
            for (int i = 0; i < qtdPosicoes; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cadastro de Lista efetuado com sucesso!");
            Console.WriteLine("Pressione ENTER para continuar");
            

            return numeros;
            
        }

        private static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Cadastrar lista de numeros");
            Console.WriteLine("2-Gerar lista com numeros aleatórios");
            Console.WriteLine("3-Exibir Lista");
            Console.WriteLine("4-Ordenar Lista Com Insertion Sort");
            Console.WriteLine("5-Ordenar Lista Com Gnome Sort");
            Console.WriteLine("6-Sair");
                        
        }

       
    }
}
