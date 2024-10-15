using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Teste Smartphone Nokia: ");
Smartphone nokia = new Nokia("(47) 9999-3333", "N325", "9997755", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("-------------------------------------------------\n");

Console.WriteLine("Teste Smartphone Iphone: ");
Smartphone iphone = new Iphone("(47) 8946-33664", "Ix45", "46464", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");








