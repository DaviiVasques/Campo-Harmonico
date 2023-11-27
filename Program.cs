using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite qual campo harmônico deseja saber: ");
        string tom = Console.ReadLine().ToUpper();

        CampoHarmonico CampHarm = new CampoHarmonico();

        if (CampHarm.ValidarNota(tom))
        {
            List<string> campoHarmonicoDo = CampHarm.ObterCampoHarmonico(tom);

            Console.WriteLine($"Campo Harmônico de {tom}:");

            foreach (var nota in campoHarmonicoDo)
            {
                Console.Write($"{nota} ");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Nota inválida.");
        }
    }
}