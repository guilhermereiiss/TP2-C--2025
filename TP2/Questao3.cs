using System;

namespace TP2_C__2025.TP2
{
    internal class Questao3
    {
        public class Ingresso
        {
            public string NomeDoShow { get; private set; }
            public double Preco { get; private set; }
            public int QuantidadeDisponivel { get; private set; }



            public Ingresso(string nomeDoShow, double preco, int quantidade)
            {
                NomeDoShow = nomeDoShow;
                Preco = preco;
                QuantidadeDisponivel = quantidade;
            }

            public void AlterarPreco(double novoPreco)
            {
                if (novoPreco > 0)
                {
                    Preco = novoPreco;
                    Console.WriteLine($"Preço atualizado para: R$ {Preco:F2}");
                }
                else
                {
                    Console.WriteLine("Erro: O preço deve ser maior que zero.");
                }
            }

            public void AlterarQuantidade(int novaQuantidade)
            {
                if (novaQuantidade >= 0)
                {
                    QuantidadeDisponivel = novaQuantidade;
                    Console.WriteLine($"Quantidade disponível atualizada para: {QuantidadeDisponivel}");
                }
                else
                {
                    Console.WriteLine("Erro: A quantidade não pode ser negativa.");
                }
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Show: {NomeDoShow}\nPreço: R$ {Preco:F2}\nIngressos disponíveis: {QuantidadeDisponivel}");
            }
        }

        public static void Executar()
        {
            Console.Write("Digite o nome do show: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço inicial do ingresso: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade inicial de ingressos disponíveis: ");
            int quantidade = int.Parse(Console.ReadLine());

            Ingresso ingresso = new Ingresso(nome, preco, quantidade);
            ingresso.ExibirInformacoes();

            Console.Write("\nDeseja alterar o preço? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Write("Digite o novo preço: ");
                double novoPreco = double.Parse(Console.ReadLine());
                ingresso.AlterarPreco(novoPreco);
            }

            Console.Write("\nDeseja alterar a quantidade disponível? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Write("Digite a nova quantidade: ");
                int novaQuantidade = int.Parse(Console.ReadLine());
                ingresso.AlterarQuantidade(novaQuantidade);
            }

            Console.WriteLine("\nInformações finais:");
            ingresso.ExibirInformacoes();
        }
    }
}
