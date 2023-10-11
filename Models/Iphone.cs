namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} da AppStore em seu Iphone...");
        }
        public override void ConsultaNumero(string numero)
        {
            Console.WriteLine($"Este é seu número de telefone do seu Iphone : {numero} \n");
        }
    }
}