using DesafioPOO.Models;

Nokia nokia = new Nokia("123", "modelo 123", "1234", 16);
Console.Write("Nokia ");
nokia.Ligar();
nokia.InstalarAplicativo("gov.br");

Console.WriteLine("---------------------------------------------");

Iphone iphone = new Iphone("456", "modelo 456", "4567", 32);
Console.Write("Iphone ");
nokia.Ligar();
nokia.InstalarAplicativo("Waze");