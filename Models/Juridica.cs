namespace Desafio21DiasPOO
{
    public class Juridica : Pessoa
    {
        public string? CNPJ { get; set; }
        public string? NomeFantasia { get; set; }

        public static List<Juridica> listaJuridica = new List<Juridica>();

        public override void Busca()
        {
            foreach (var empresas in listaJuridica)
            {
                var lista = new List<Juridica>();

                Console.WriteLine($"Empresa: {empresas.Nome} CNPJ: {empresas.CNPJ}");
            }
        }

        public override void Excluir()
        {
            foreach (var empresas in listaJuridica)
            {
                System.Console.WriteLine($"Empresa: {empresas.Nome} excluida!");

            }
        }
        public override void Salvar()
        {
            Juridica.listaJuridica.Add(this);
        }
    }
}
