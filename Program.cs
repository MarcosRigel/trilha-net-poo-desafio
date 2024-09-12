using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone celularNokia = new Nokia("123456", "Modelo 1", "1111111111", 64);
celularNokia.Ligar();
celularNokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

Smartphone celularIphone = new Nokia("4987", "Modelo 2", "2222222222", 128);
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Telegram");
