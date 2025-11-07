using System;

class Passagem {
    static void Main() {
        Console.WriteLine("Cidades de destino:");
        Console.WriteLine("1 - Morros (R$ 120,00)");
        Console.WriteLine("2 - Barreirinhas (R$ 200,00)");
        Console.WriteLine("3 - Bacabeira (R$ 50,00)");
        Console.WriteLine("4 - Rosário (R$ 80,00)");
        Console.Write("Digite o código da cidade de destino: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Compra de ida e volta? (s/n): ");
        string opcao = Console.ReadLine().ToLower();

        double valor = 0;
        switch (codigo) {
            case 1: valor = 120; break;
            case 2: valor = 200; break;
            case 3: valor = 50; break;
            case 4: valor = 80; break;
            default: Console.WriteLine("Código inválido!"); return;
        }

        if (opcao == "s") valor *= 2 * 0.9; // ida e volta com 10% desconto
        Console.WriteLine($"Valor total a pagar: R$ {valor:F2}");
    }
}