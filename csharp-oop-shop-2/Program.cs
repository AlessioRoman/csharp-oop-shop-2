using cannedfood;
using homeappliances;
using water;
using fruit;
using category;
using product;
using shop;

CannedFood newWater = new(1.5f, "Evian", "Pretty Cool Water", "Drinks", 2023, 1.5f, 1.5f);
Console.WriteLine(newWater.ProductRappresentationString());