using System;

class NotasSESI {
    static void Main() {
        double[] notas = new double[7];

        for (int i = 0; i < 7; i++) {
            Console.Write($"Digite a {i + 1}ª nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double media1 = (notas[0] + notas[1] + notas[2]) / 3.0;
        double media2 = (notas[3] + notas[4] + notas[5]) / 3.0;
        double mediaFinal = (media1 + media2 + notas[6]) / 3.0;

        Console.WriteLine($"Média final: {mediaFinal:F1}");

        if (mediaFinal < 60)
            Console.WriteLine("Conceito C");
        else if (mediaFinal < 80)
            Console.WriteLine("Conceito B");
        else
            Console.WriteLine("Conceito A");
    }
}