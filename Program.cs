using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Implementado
//Nokia
Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia(numero: "123456", modelo: "Lumia 930", imei: "1111111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
//Iphone
Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone(numero: "654321", modelo: "Iphone 14 pro max", imei: "1111111111111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");