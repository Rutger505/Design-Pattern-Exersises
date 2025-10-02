// See https://aka.ms/new-console-template for more information

using SingletonPattern;

Console.WriteLine("Hello, World!");

var daggoe = Dawg.GetInstance();

daggoe.Woof();
daggoe.Woof();
daggoe.Woof();
daggoe.Woof();

Console.WriteLine("Getting another dawg");
var myNewDawg = Dawg.GetInstance();

myNewDawg.Woof();