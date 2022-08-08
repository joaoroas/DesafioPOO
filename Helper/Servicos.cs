namespace Desafio21DiasPOO

{
    public class Servicos
    {
        public static List<IPessoa> TabelaFisica = new List<IPessoa>();
        public static List<IPessoa> TabelaJuridica = new List<IPessoa>();

        public static void Salvar(IPessoa instancia)
        {
            if (instancia.GetType().Name == "Fisica")
            {
                TabelaFisica.Add((Fisica)instancia);
            }
            else if (instancia.GetType().Name == "Juridica")
            {
                TabelaJuridica.Add((Juridica)instancia);
            }
        }
        public static List<IPessoa> Buscar(IPessoa iPessoa)
        {
            if(iPessoa.GetType() == typeof(Fisica))
            {
                return Servicos.TabelaFisica;
            }
            else if(iPessoa.GetType() == typeof(Juridica))
            {
                return Servicos.TabelaJuridica;
            }
            return null;
        }
         public static T Procurar<T>()
        {
            var lista = Servicos.TabelaFisica;
            //List<IPessoa> lista = new List<IPessoa>();
            return (T)Convert.ChangeType(lista, typeof(T));
          /*   if(T.GetType() == typeof(Fisica))
            {
                return Servicos.TabelaFisica;
            }
            else if(iPessoa.GetType() == typeof(Juridica))
            {
                return Servicos.TabelaJuridica;
            }
            return null; */
        }
    }
}