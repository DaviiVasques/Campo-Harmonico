using System;
using System.Collections.Generic;

class CampoHarmonico
{
    public List<string> notasValidas = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    public bool ValidarNota(string nota)
    {
        return notasValidas.Contains(nota);
    }

    public List<string> ObterCampoHarmonico(string nota)
    {
        List<string> notas = new List<string>
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };

        int indiceNota = notas.IndexOf(nota);

        if (indiceNota == -1)
        {
            Console.WriteLine("Nota inválida.");
            return new List<string>();
        }

        List<string> campoHarmonico = new List<string>
        {
            notas[indiceNota], notas[(indiceNota + 2) % 12], notas[(indiceNota + 4) % 12],
            notas[(indiceNota + 5) % 12], notas[(indiceNota + 7) % 12], notas[(indiceNota + 9) % 12],
            notas[(indiceNota + 11) % 12]
        };

        return campoHarmonico;
    }
}
