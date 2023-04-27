using csharp_shop_3;
using System.Diagnostics.Metrics;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Shop Eurospin = new Shop("Eurospin", "Roma", "Via Paolo", "42");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");

Console.WriteLine(AcquaSantAnna);

Eurospin.AddNewProductToShopList(AcquaSantAnna);

























/*
BagOfFruits Busta1 = new BagOfFruits("Busta", "Plastica", 0.2f, "Contenitori", "Plastica", 5);
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Busta1.AddFruitInBag(Limone);
Eurospin.AddNewProductToShopList(Busta1);

Fruit Mela = new Fruit("Mela", "Mela rosso", 0.2f, "mela", "Roma", "frutta");

//CONSOLE
Console.WriteLine(Eurospin.ToString());
Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());
Console.WriteLine(Mela.ToString("newline"));
Busta1.AddFruitInBag(Mela);
*/