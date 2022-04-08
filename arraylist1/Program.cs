using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ArrayList com Menu: Inserir / Remover / Listar / Pesquisar / Ordenar */

namespace arraylist1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            bool menu = true;

            while (menu == true)
            {
                Console.WriteLine("  ======= MENU ========");
                Console.WriteLine("  1....Inserir Elemento");
                Console.WriteLine("  2....Remover Elemento");
                Console.WriteLine("  3.....Listar Elemento");
                Console.WriteLine("  4..Pesquisar Elemento");
                Console.WriteLine("  5....Ordenar Elemento");
                Console.WriteLine("  6................Sair");
                Console.WriteLine("  =====================");

                int opc;
                Console.Write("\n - ");
                opc = int.Parse(Console.ReadLine());

                if (opc < 1 || opc > 6)
                {
                    Console.WriteLine("\n Opção inválida, verifique.\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (opc)
                {
                    case 1:
                        Console.Write("\n == Insira o Elemento \n - ");
                        arr.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine(" Elemento Inserido!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("\n == Remover o Elemento \n - ");
                        arr.Remove(int.Parse(Console.ReadLine()));
                        Console.WriteLine(" Elemento Removido!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("\n == Listar Elementos");
                        MostrarElementos();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("\n == Pesquisar Elemento\n - ");
                        bool contem = arr.Contains(int.Parse(Console.ReadLine()));
                        Console.WriteLine(contem ? " - Contém o Elemento!" : "- Não Contém o Elemento!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("\n == Ordenar Elemento");
                        arr.Sort();
                        Console.WriteLine(" Elemento Ordenados!");
                        Console.ReadLine();
                        Console.Clear();
                        //MostrarElementos();
                        break;

                    default:
                        Console.WriteLine(" == Pressione qualquer tecla para sair\n");
                        menu = false;
                        break;
                }
            }
            Console.ReadLine();

            void MostrarElementos()
            {
                foreach (int num in arr)
                {
                    Console.WriteLine(" - " + num);
                }
                Console.WriteLine();
            }
        }
    }
}
