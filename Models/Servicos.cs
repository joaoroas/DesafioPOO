using DesafioPOO.Interfaces;

namespace DesafioPOO.Models
{
    public class Servicos
    {
        public static void Salvar(IPessoa ipessoa)
        {
            ipessoa.Salvar();
        }
        public static void Busca(IPessoa ipessoa)
        {
            ipessoa.Busca();
        }
        public static void Excluir(IPessoa ipessoa)
        {
            ipessoa.Excluir();
        }
    }
}