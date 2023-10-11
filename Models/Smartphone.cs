
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Realizando chamada...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo chamada...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void ConsultaNumero(string numero);
    }
}