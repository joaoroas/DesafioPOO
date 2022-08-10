namespace Desafio21DiasPOO

{
    public interface IPessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        void Salvar();
        List<IPessoa> Buscar();
        void Excluir();

    }
}