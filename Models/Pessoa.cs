
namespace Desafio21DiasPOO
{
    public abstract class Pessoa : IPessoa
    {
        private string endereco;
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { 
            get
            {
                return endereco.ToUpper();
            }
            set
            {
                endereco = value.ToLower();
            }
        }

        public abstract void Excluir();


        public List<IPessoa> Buscar()
        {
            return new Servicos(this).Buscar();
        }

        

        public void Salvar()
        {
            Servicos.Salvar(this);
        }
    }

}