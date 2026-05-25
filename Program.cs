using System;
class Program
{
    public static void PreencherEstoque(int[] estoque)
    {
        Random rand = new Random();
        for (int i = 0; i < estoque.Length; i++) 
        {
            estoque[i] = rand.Next(5, 51); 
        }
    }
    static void RealizarVenda(ref int quantidade)
    {
        quantidade -= 3;
 
        if (quantidade < 0)
        {
            quantidade = 0;
        }
    }

     static int CalcularTotalEstoque(int[] estoque)
    {
        int total = 0;
        for (int i = 0; i < estoque.Length; i++)
        {
            total += estoque[i];
        }
        return total;
    }

     static void ExibirEstoque(int[] estoque)
    {
        for (int i = 0; i < estoque.Length; i++)
        {
            Console.WriteLine($"  Produto {i + 1,2}: {estoque[i],3} unidades");
        }
    }
 
    static void Main(string[] args) { 
        {
        int[] estoque = new int[12];
 
        PreencherEstoque(estoque);
 
        Console.WriteLine("========================================");
        Console.WriteLine("       SISTEMA DE CONTROLE DE ESTOQUE  ");
        Console.WriteLine("========================================");
        Console.WriteLine("\n ESTOQUE ANTES DAS VENDAS:");
        Console.WriteLine("----------------------------------------");

        ExibirEstoque(estoque);
        Console.WriteLine($"\nTotal antes das vendas: {CalcularTotalEstoque(estoque)} unidades");
 
        Console.WriteLine("\n Realizando venda de 3 unidades por produto...");
        for (int i = 0; i < estoque.Length; i++)
        {
            RealizarVenda(ref estoque[i]);
        }
 
        Console.WriteLine("\n ESTOQUE APÓS AS VENDAS:");
        Console.WriteLine("----------------------------------------");
        ExibirEstoque(estoque);
 
        int totalFinal = CalcularTotalEstoque(estoque);
        Console.WriteLine("\n========================================");
        Console.WriteLine($"  TOTAL FINAL EM ESTOQUE: {totalFinal} unidades");
        Console.WriteLine("========================================");
    }
}
}
