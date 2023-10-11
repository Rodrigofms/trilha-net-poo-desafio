using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(11)98741-2510", modelo: "C21", imei: "581670-81", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.ConsultaNumero("(11)98741-2510");
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Pressione qualquer tecla para continuar o teste");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "(21)98410-8799", modelo: "XR", imei: "410987-77", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.ConsultaNumero("(21)98410-8799");
iphone.InstalarAplicativo("Apple Music");

Console.WriteLine("Pressione qualquer tecla para finalizar o teste");
Console.ReadLine();
Console.Clear();