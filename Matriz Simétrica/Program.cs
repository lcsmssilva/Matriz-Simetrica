using System;
class Program
{
    static void ConfereSimetria(int[,] Matriz, int linha, int coluna)
    {
        int Simetrica = 1;

        for(int i = 0; i < linha; i++)
        {
            for(int j = 0; j < coluna; j++)
            {    
                if(Matriz[i,j] != Matriz[j,i])
                {
                    Simetrica = 0;
                }
            }
        }
        
        Console.WriteLine(Simetrica);
    }
    static void Main(string[] args)
    {
        int Simetrica = 0;

        string Linha = Console.ReadLine();
        string[] Valores = Linha.Split(' ');

        int M = int.Parse(Valores[0]);
        int N = int.Parse(Valores[1]);

        if(M != N)
        {
            Console.WriteLine(Simetrica);
        }
        else
        {
            string[] Val;
            string Linhas;

            int[,] L = new int[M,N];

            for (int i = 0; i < M; i++)
            {
                Linhas = Console.ReadLine();
                Val = Linhas.Split(' ');

                for (int j = 0; j < N; j++)
                {
                L[i,j] = int.Parse(Val[j]);
                }
            }
            ConfereSimetria(L, M, N);
        }
    }
}
