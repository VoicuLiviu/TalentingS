// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Ex2_V2;

class Program {

    static void Main(String[] args)
    {

        //Prices
        Flower rose = new Flower("Rose", 10);
        Flower gladiola = new Flower("Gladiola", 15);
        Flower hydra = new Flower("Hydra", 30);
        Console.WriteLine($"Here are the available flowers:");
        Console.WriteLine($"- {rose.Name}: {rose.Price} RON/piece");
        Console.WriteLine($"- {gladiola.Name}: {gladiola.Price} RON/piece");
        Console.WriteLine($"- {hydra.Name}: {hydra.Price} RON/piece");

        //Bouqets
        Bouquet bigBouquet = new Bouquet("Big Bouqet", 9 * rose.Price + 10 * gladiola.Price + 3 * hydra.Price + 2);
        Bouquet mediumBouquet = new Bouquet("Medium Bouqet", 6 * rose.Price + 5 * gladiola.Price + 2);
        Bouquet smallBouquet = new Bouquet("SmallBouqet", 5 * rose.Price + 2);

        

        //Flower Shop
        FlowerShop shop = new FlowerShop();


        //Sales
        shop.BuyFlower(rose, 20);
        shop.BuyFlower(gladiola, 10);
        shop.BuyBouquet(bigBouquet, 5);
        shop.BuyBouquet(mediumBouquet, 8);
        shop.BuyBouquet(smallBouquet, 12);

        //Inventory
        shop.DisplayMonthlyInventory();









    }

}

