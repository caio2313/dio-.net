namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(global::System.String nomeApp)
        {
            Console.WriteLine($"instalando o aplicativo {nomeApp} no iphone.");
        }
    }
}