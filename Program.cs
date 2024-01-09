using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo X", imei: "00000000000", memoria: 128);
Console.WriteLine("Testando Smartphone Nokia: ");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo S", imei: "999999999", memoria: 128);
Console.WriteLine("Testando Smartphone Iphone: ");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");