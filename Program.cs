using System.ComponentModel;
using DesafioPOO.Models;

// Testes realizados com sucesso !!!

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "2222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");