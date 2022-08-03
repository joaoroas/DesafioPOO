namespace Desafio21DiasPOO
{
    public class Fisica : Pessoa
    {

        public string? CPF { get; set; }
        public string? RG { get; set; }

        public static List<Fisica> bancoDados = new List<Fisica>();

        public override void Salvar()
        {
            Fisica.bancoDados.Add(this);
        }

        public static void SalvarInstancia(Fisica obj)
        {
            Fisica.bancoDados.Add(obj);
        }

        public static List<Fisica> BuscarTodos()
        {
            return Fisica.bancoDados;
        }

        public static List<Fisica> PorNome(string nome)
        {
            var lista = new List<Fisica>();
            foreach (var instancia in Fisica.bancoDados)
            {
                if (instancia.Nome.ToLower().Contains(nome.ToLower()))
                {
                    lista.Add(instancia);
                }
            }
            return lista;

        }

        public override void Busca()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}