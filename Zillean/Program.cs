using System;
namespace uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, torrex, torrey, falso, verdadeiro;

            int[,] mat;
            M = int.Parse(Console.ReadLine());
            falso = 1;
            verdadeiro = 0;
            mat = new int[8, 8];

            for (int i = 0; i < M; i++)
            {
                verdadeiro = 0;
                for (int j = 0; j < 8; j++)
                {
                    string[] s = Console.ReadLine().Split(' ');

                    for (int g = 0; g < 8; g++)
                    {
                        mat[j, g] = int.Parse(s[g]);
                    }
                }
                string[] vet = Console.ReadLine().Split(' ');
                torrex = int.Parse(vet[0]);
                torrey = int.Parse(vet[1]);
                torrex = torrex - 1;
                torrey = torrey - 1;
                for(int k = 0; k < 8; k++)
                {
                    if (mat[torrex, k] == 1)
                    {

                        verdadeiro++;
                    }
                    else
                    {
                        falso = 0;
                    }
                    
                }
                for (int k = 0; k < 8; k++)
                {
                    if (mat[k, torrey] == 1)
                    {
                        verdadeiro++;
                    }
                    else
                    {
                        falso = 0;
                    }
                }
                if (verdadeiro > 0)
                {
                    Console.WriteLine("S");
                }
                else
                {

                    Console.WriteLine("N");
                }
            }
          
            }


        }
    }
