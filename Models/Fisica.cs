
namespace Desafio21DiasPOO
{
    public class Fisica : Pessoa
    {
        public string? CPF { get; set; }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public List<Fisica> ToList()
        {
            return null;
        }
    }
}