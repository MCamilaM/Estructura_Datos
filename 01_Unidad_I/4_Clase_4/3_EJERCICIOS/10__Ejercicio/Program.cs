﻿using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
			int posicionCentralVector;
			int longitudVector;

			Random numeroAleatorio = new Random();

			do
			{
				Console.Write("Digite la longitud de un vector de tamaño impar: ");
				longitudVector = int.Parse(System.Console.ReadLine());
			} 
			while (longitudVector % 2 != 1);

			int[] vectorNumerosAleatorios = new int[longitudVector];

			for (int i = 0; i < longitudVector; i++){
				vectorNumerosAleatorios[i] = numeroAleatorio.Next (0,20);
				Console.Write($"| {vectorNumerosAleatorios[i]} |");
			}

			posicionCentralVector = longitudVector/2;
			Console.WriteLine($"\n\nEl elemento central de vector es: {vectorNumerosAleatorios[posicionCentralVector]}");
		}
    }
}
