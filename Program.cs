using System;
namespace _001ArraySimples
{
    class Program
    {   // Autor: Douglas  14/02/2024
        // Programa para gestão de notas

        static void Main(string[] args)
        {
            // definição de variáveis
            int[] notas = new int[5];
            int opcao = 99;
            int maiorNota = 0;

            Console.WriteLine("Gestão de Notas de um array!");

            while (opcao != 0)
            {
                opcao = menu();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("INSERÇÃO");
                        for (int i = 0; i < notas.Length; i++)
                        {
                            Console.Write($"{i + 1}ª Nota: ");
                            notas[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("LISTAGEM");
                        // processar a listagem de notas do array
                        int j = 0;
                        do
                        {
                            Console.WriteLine("A {0}ª nota = {1}", j + 1, notas[j]);
                            j++;
                        } while (j < notas.Length);
                        break;
                    case 3:
                        Console.WriteLine("MAIOR NOTA");
                        maiorNota = notas[0]; // inicializa com o valor da 1ª posição do array
                        for (int k = 1; k < notas.Length; k++)
                            if (notas[k] > maiorNota)   // compara cada nota com a maior nota
                                maiorNota = notas[k];   // maiorNota toma valor do array se esta for maior 
                        Console.WriteLine("A maior das notas é {0}!", maiorNota);
                        break;

                }

            }

        }

        static int menu()
        {
            // menu de opções
            Console.WriteLine("MENU - GESTÃO DE NOTAS");
            Console.WriteLine("1 Inserção de notas no array");
            Console.WriteLine("2 Listagem de notas");
            Console.WriteLine("3 Maior das notas");
            Console.WriteLine("4 Menor das notas");
            Console.WriteLine("0 Sair do programa");
            Console.Write("Escolhe a opção: ");
            return Convert.ToInt32(Console.ReadLine()); // retorno da opção escolhida
        }
    }
}
