namespace exercio04_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz= new float[10, 4];
            float[] soma = new float [10];


            for (int iLinha = 0; iLinha < matriz.GetLength(0); iLinha++)
            {

                for (int iColuna = 0; iColuna < matriz.GetLength(1); iColuna++)
                {
                    Console.WriteLine($"matriz[{iLinha},{iColuna}] = ");
                    matriz[iLinha, iColuna] = Convert.ToSingle(Console.ReadLine());

                }
            }
            for (int iLinha = 0; iLinha < matriz.GetLength(0); iLinha++)
            {

                for (int iColuna = 0; iColuna < matriz.GetLength(1); iColuna++)
                {
                    soma[iLinha] += matriz[iLinha,iColuna];
                }

                soma[iLinha] = soma[iLinha] / 4;
            }
            for(int iLinha = 0; iLinha < matriz.GetLength(0); iLinha++)
            {
                Console.WriteLine($"As médias são: {soma[iLinha]:F1}");
            }
        }
    }
}