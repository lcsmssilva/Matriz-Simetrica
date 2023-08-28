using System;
class Program
{
    static void Main(string[] args)
    {
        string Linha = Console.ReadLine();
        string[] Valores = Linha.Split(' ');

        int M = int.Parse(Valores[0]);
        int N = int.Parse(Valores[1]);

        string[] Val;
        string Linhas;

        int[,] L = new int[M,N];

        for (int i = 0; i < N; i++)
        {
            Linhas = Console.ReadLine();
            Val = Linhas.Split(' ');

            for (int j = 0; j < M; j++)
            {
            L[i,j] = int.Parse(Val[j]);
            }
        }

        int true = 1;
        int false = 0;

        for(int i = 0; i<M; i++)
        {
            for(int j = 0; j<N; j++)
            {
                if(L[i,j] == L[j,i])
                {
                    true++;
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
