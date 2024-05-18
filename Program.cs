using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Iphone iphone = new Iphone(numero: "654321", modelo: "modelo 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");
nokia.ReceberLigacao();
