namespace Desafio21DiasPOO
{
    public class Juridica : Pessoa
    {
        public string? CNPJ { get; set; }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
