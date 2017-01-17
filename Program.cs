using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lion = new Lion();
            lion.name = "Dustin";
            lion.alpha = true;
            System.Console.WriteLine($"The Lion's name is {lion.name} and alpha = {lion.alpha}"); 

            var bear = new Bear();
            bear.name = "New bear";
            bear.height = 10;
            bear.weight = 600;
            bear.clawLength = 2;
            bear.skullMeasuremnt = 12;

            System.Console.WriteLine($"{bear.height}.{bear.weight}.{bear.name}"); 

            var zebra = new Lion();
            zebra.name = "new zebra";
            System.Console.WriteLine($"{zebra.height}.{zebra.weight}.{zebra.name}"); 
        }
    }
}
