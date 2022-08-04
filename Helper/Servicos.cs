namespace Desafio21DiasPOO

{
    public class Servicos
    {
        public static List<Fisica> TabelaFisica = new List<Fisica>();
        public static List<Juridica> TabelaJuridica = new List<Juridica>();

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
    }
}