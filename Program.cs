using DesafioPOO.Models;

// Implementado

Iphone iphone = new Iphone("(11) 22334-5566", "iPhone 12", "0123456789abcde", 64);
Console.WriteLine("iPhone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------------");

Nokia nokia = new Nokia("(77) 88990-1122", "Nokia C12", "9876543210edcba", 64);
Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");