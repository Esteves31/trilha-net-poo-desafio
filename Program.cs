using DesafioPOO.Models;

Nokia cel1 = new Nokia("12345678", "Tijolão", "sla", 64);
Iphone cel2 = new Iphone("12345678", "15", "sla", 256);

cel1.ReceberLigacao();
cel1.Ligar();
cel1.InstalarAplicativo("Clash of Clans");

cel2.ReceberLigacao();
cel2.Ligar();
cel2.InstalarAplicativo("Clash of Clans");
