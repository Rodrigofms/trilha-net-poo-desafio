namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} da Play Store em seu Nokia...");
        }
        public override void ConsultaNumero(string numero)
        {
            Console.WriteLine($"Este é seu número de telefone: {numero} \n");
        }
    }
}