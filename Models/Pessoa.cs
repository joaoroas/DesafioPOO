using DesafioPOO.Interfaces;

namespace Desafio21DiasPOO
{
    public abstract class Pessoa : IPessoa
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public abstract void Busca();
        public abstract void Excluir();
        public abstract void Salvar();


    }

}