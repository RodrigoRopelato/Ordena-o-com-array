﻿using System;
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
            int[] numerosParaOrdenar = new int[qtdPosicoes];
            int[] numerosOrdenados = new int[qtdPosicoes];
            Console.Clear();
            do
            {
                               
                Menu();  
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
               
                switch (opcao)
                {
                    case "1":
                        numerosParaOrdenar = CadastrarNumerosArray(qtdPosicoes);
                        break;

                    case "2":
                        ExibirArray(numerosParaOrdenar);
                        break;

                    case "3":
                        OrdenarArrayInsertion(numerosOrdenados,numerosParaOrdenar);
                        break;

                    case "4":
                        OrdenarArrayGnomeSort(numerosOrdenados, numerosParaOrdenar);
                        break;

                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                numerosOrdenados = numerosParaOrdenar;
                Console.ReadKey();
                Console.Clear();

            } while (continuar);
        }

        private static void OrdenarArrayGnomeSort(int[] numeros, int[] numerosParaOrdenar)
        {
            ExibirArray(numerosParaOrdenar);

            GnomeSort(numeros);
        }

        #region Gnome Sort APRESENTAR NA PROXIMA AULA
        //O Gnome Sort é um algoritmo com uma sequencia grande de trocas como o Bubble Sort, 
        //porem ele é similar ao Insertion Sort com a diferença de levar um elemento para sua posição correta.
        //ver link: https://pt.wikipedia.org/wiki/Gnome_sort
        private static void GnomeSort(int[] vetor)
        {
           
           
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

                //return vetor;
           

            #endregion
        }

        private static void OrdenarArrayInsertion(int[]numerosParaOrdenar, int[] numeros)
        {
            
            ExibirArray(numerosParaOrdenar);
                     
            InsertionSort(numeros);
        }

        private static int QuantidadeArray()
        {
            
            Console.WriteLine("Para Iniciar a Aplicação");
            Console.Write("Informe o tamanho do array que deseja criar:");
            int qtdPosicoes = int.Parse(Console.ReadLine());

            return qtdPosicoes;
        }

        private static void InsertionSort(int[]vetor)
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

        private static void ExibirArray(int[] lista)
        {
            Console.WriteLine("\nLista");
            
            for(int i = 0; i < lista.Length; i++)
            {   
               
                Console.Write("{0}, ",(lista[i]));
            }

            Console.WriteLine();
            
        }

        private static int[] CadastrarNumerosArray(int qtdPosicoes)
        {
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
            Console.WriteLine("2-Exibir Lista");
            Console.WriteLine("3-Ordenar Lista Com Insertion Sort");
            Console.WriteLine("4-Ordenar Lista Com Gnome Sort");
            Console.WriteLine("5-Sair");
                        
        }

       
    }
}
