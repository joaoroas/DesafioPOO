using DesafioPOO.Helper;
using DesafioPOO.Interfaces;

namespace DesafioPOO.Models
{
    public class Gato : AAnimal
    {
        //public string Nome { get; set; }
        public override void Andar()
        {
            if(string.IsNullOrEmpty(this.Nome))
            {
                throw new AnimalException("O nome não pode ser vazio!");
            }
            throw new Exception();
        }

        public override void Correr()
        {
            throw new NotImplementedException();
        }
    }
}