using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", imei: "000000000", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--------------------------------------");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "987654", modelo: "Modelo 3", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
