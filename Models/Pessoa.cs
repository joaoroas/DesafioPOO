
namespace Desafio21DiasPOO
{
    public abstract class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public abstract void Excluir();


        public List<IPessoa> Busca()
        {
            throw new NotImplementedException();
        }

        

        public void Salvar()
        {
            Servicos.Salvar(this);
        }
    }

}