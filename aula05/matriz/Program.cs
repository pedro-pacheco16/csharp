namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizo1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, } };

            int[,] matriz02 = new int[4, 4];

            int[,] matriz03 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[] vetor = { 1, 2, 3, 4 };

            int Soma = 0;

            for (int iLinha = 0; iLinha < Math.Sqrt(matrizo1.Length); iLinha++)
            {
                for (int iColuna = 0; iColuna < Math.Sqrt(matrizo1.Length); iColuna++)
                {
                    Console.WriteLine($"matriz01[{iLinha},{iColuna}] = {matrizo1[iLinha, iColuna]}");
                }
            }
            Console.WriteLine();

            for (int iLinha = 0; iLinha < Math.Sqrt(matriz02.Length); iLinha++)
            {
                for (int iColuna = 0; iColuna < Math.Sqrt(matriz02.Length); iColuna++)
                {
                    Console.WriteLine($"matriz02[{iLinha},{iColuna}] = ");
                    matriz02[iLinha, iColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
                {
                    Console.WriteLine($"matriz02[{indiceLinha}, {indiceColuna}] = {matriz02[indiceLinha, indiceColuna]}");
                }
            }


            for (int iLinha = 0; iLinha < matriz03.GetLength(0); iLinha++)
            {
                for (int iColuna = 0; iColuna < matriz03.GetLength(1); iColuna++)
                {
                    Console.WriteLine($"matriz03[{iLinha},{iColuna}] = {matriz03[iLinha, iColuna]}");
                }

            }

            foreach( int elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
            foreach (int elemento in matrizo1)
            {
                Soma += elemento; 

                if(elemento % 3 == 0)
                {
                    Console.WriteLine(elemento);
                }

                Console.WriteLine(Soma);
            }
        }

    }
}