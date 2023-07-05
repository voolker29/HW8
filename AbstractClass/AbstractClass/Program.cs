using AbstractClass;

Console.WriteLine("Введите имя собаки");
var name = Console.ReadLine();

var userDog = new Dog();
userDog.SetName(name);

Console.WriteLine($"Dog name {userDog.GetName()}");
userDog.Eat();
