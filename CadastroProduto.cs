using System;
using System.Security.Cryptography.X509Certificates;

class CadastroProduto
{
    public List<ProdutoEletronico> produtos;
    public CadastroProduto()
    {
        produtos = new List<ProdutoEletronico>();
    }
    public void AdicionarProduto(int id, string nome, float preco, string descricao, string marca, char situacao)
    {
        ProdutoEletronico produto = new ProdutoEletronico(id, nome, preco, descricao, marca, situacao);
        produtos.Add(produto);
        Console.WriteLine("Produto adicionado.");
    }
    public void ListarProdutos()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
    public void ExcluirProduto(int id)
    {
        ProdutoEletronico produtoParaExcluir = produtos.Find(p => p.id == id);

        if (produtoParaExcluir != null)
        {
            produtos.Remove(produtoParaExcluir);
            Console.WriteLine($"Produto com ID {id} foi removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Produto com ID {id} não encontrado na lista.");
        }
    }

}