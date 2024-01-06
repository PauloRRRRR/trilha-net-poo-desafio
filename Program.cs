using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone meuNokia = new Nokia("123456", "Modelo 1","IMEInokia" ,64);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Whatsapp");
Smartphone meuIphone = new Iphone("54321", "Modelo 2","IMEIphone" ,64);
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Telegram");