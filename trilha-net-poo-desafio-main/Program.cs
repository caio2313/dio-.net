using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero: "2313", modelo: "Iphone13", imei: "12243548", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone nokia");
Smartphone nokia = new Iphone(numero: "6360", modelo: "G11 Plus", imei: "25448890", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");