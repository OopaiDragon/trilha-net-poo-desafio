namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //Implementado
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string _modelo, string _imei, int _memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //Implementado
            Modelo = _modelo;
            IMEI = _imei;
            Memoria = _memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}