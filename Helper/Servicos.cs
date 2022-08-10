namespace Desafio21DiasPOO

{
    public class Servicos
    {
        public static List<IPessoa> TabelaFisica = new List<IPessoa>();
        public static List<IPessoa> TabelaJuridica = new List<IPessoa>();
        private  IPessoa pessoa;

        public Servicos(IPessoa iPessoa)
        {
            this.pessoa = iPessoa;
        }
        public static void Salvar(IPessoa iPessoa)
        {
            if (iPessoa.GetType().Name == "Fisica")
            {
                TabelaFisica.Add((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                TabelaJuridica.Add((Juridica)iPessoa);
            }
        }
        public  List<IPessoa> Buscar()
        {
            var lista = new List<IPessoa>();
            if (pessoa.GetType() == typeof(Fisica))
            {
                lista.Add(new Fisica() { Nome = "Fisica" });
            }
            else if (pessoa.GetType() == typeof(Juridica))
            {
                lista.Add(new Juridica() { Nome = "Juridica" });
            }
            return lista;
        }

        public static void Excluir(IPessoa iPessoa)
        {
            if (iPessoa.GetType().Name == "Fisica")
            {
                Servicos.ExcluirPessoaFisica((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                Servicos.ExcluirPessoaJuridica((Juridica)iPessoa);
            }
        }

        public static T Procurar<T>()
        {
            if (typeof(T) == typeof(List<Juridica>))
            {
                return (T)Convert.ChangeType(Servicos.TabelaJuridica, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(Servicos.TabelaFisica, typeof(T));
            }
        }

        public static T BuscaPorId<T>(int id)
        {
            if (typeof(T) == typeof(List<Juridica>))
            {
                return (T)Convert.ChangeType(Servicos.TabelaJuridica, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(Servicos.TabelaFisica, typeof(T));
            }
        }

        private static void ExcluirPessoaFisica(Fisica iPessoa)
        {
            throw new NotImplementedException();
        }

        private static void ExcluirPessoaJuridica(Juridica iPessoa)
        {
            throw new NotImplementedException();
        }
    }
}