using System;
using System.Globalization;

class ProdutoEletronico : Produto
{
    CultureInfo  culture = new CultureInfo("pt-BR");
    
    string marca;
    bool status;
    
    public ProdutoEletronico(int id,string nome, float preco, string descricao,string marca,char situacao) : base(id, nome,preco,descricao, situacao)
    {
        this.marca = marca;
    }
    
    public void Ativacao()
    {
        status = true;
    }
    public void Inativo()
    {
        status = false;
    }
    
        public override string ToString()
        {
            return base.ToString() + $", Marca: {marca}";
        }
}
    