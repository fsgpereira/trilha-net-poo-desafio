using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatphone Nokia");
Smartphone nokia = new Nokia("15991100245", "123123123", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone");
Smartphone iphone = new Iphone("12345678911", "123123123", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");