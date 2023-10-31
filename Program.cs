using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto eletronico: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto eletronico : ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Descreva o produto eletronico: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite a marca do produto eletronico: ");
            string marca = Console.ReadLine();
            Console.Write("O produto eletrônico está ativo? (S/N): ");
            char situacao = char.Parse(Console.ReadLine().ToUpper());
            CadastroProduto p = new CadastroProduto();

            p.AdicionarProduto(id,nome, preco, descricao,marca,situacao);
            
            ProdutoEletronico ProdEle = new ProdutoEletronico(id,nome, preco, descricao,marca,situacao);
            Console.WriteLine(ProdEle);
        
            if(situacao == 's')
            {
                ProdEle.Ativacao();
                Console.WriteLine("O produto está ativo");

            }
            else if (situacao =='n')
            {
                ProdEle.Inativo();
                Console.WriteLine("O produto está inativo");
            }

        }
    }
}
