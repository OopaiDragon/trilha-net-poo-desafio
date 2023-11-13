namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //Implementado
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Iphone...");
            Thread.Sleep(1000);
            Console.WriteLine($"{nome} instalado");
        }
    }
}