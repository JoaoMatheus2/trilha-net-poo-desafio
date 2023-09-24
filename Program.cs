using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("/n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4887", modelo: "Modelo 2", imei: "2222222", memoria : 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
