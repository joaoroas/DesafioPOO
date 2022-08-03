namespace DesafioPOO.Models
{
    public abstract class AAnimal
    {
        public string Nome { get; set; }
        public abstract void Andar();
        public abstract void Correr();
    }
}