class Troco {
    static void Main() {
        Console.Write("Preço unitário do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade comprada: ");
        int qtd = int.Parse(Console.ReadLine());

        Console.Write("Dinheiro recebido: ");
        double dinheiro = double.Parse(Console.ReadLine());

        double total = preco * qtd;
        double troco = dinheiro - total;

        Console.WriteLine($"Troco: R$ {troco:F2}");
    }
}