﻿namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            
            
            // Adicionar novos elementos
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            // listar todos os elementos
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            // indice de um elemento
            Console.WriteLine("Posição da nota 4.0" + notas.IndexOf(4.0));

            // Checar se o elemento existe
            Console.WriteLine("A nota 4.0 existe?" + notas.Contains(4.0) );

            // Deletar elemento
            notas.Remove(4.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);

            }

            // Tamanho da lista
            Console.WriteLine("Quantos elementos tem na lista? " + notas.Count());

            //Ordenação crescente
            notas.Sort();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // ordenação decrescente
            notas.Reverse();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // alteração de nota
            notas[0] = 9.0;

            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}