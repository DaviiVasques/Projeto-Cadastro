class Produto
{
    public int id;
    public string nome;
    public float preco;
    public string descricao;
    public char situacao;

    public Produto(int id,string nome, float preco, string descricao, char situacao)
    {
        this.id = id;
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.situacao = situacao;
    }
    
        public override string ToString()
    {
        return $"ID: {id}, Nome: {nome}, Preço: {preco:C2}, Descrição: {descricao}, Situação: {situacao}";
    }
}