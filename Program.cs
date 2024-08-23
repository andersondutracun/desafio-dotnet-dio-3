using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um iPhone e testando
        Iphone iphone = new Iphone("123456789", "iPhone 13");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        // Criando um Nokia e testando
        Nokia nokia = new Nokia("987654321", "Nokia 3310");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}