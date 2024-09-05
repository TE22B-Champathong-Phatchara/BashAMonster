


Megaman Player = new Megaman() { 
    hp = 100,
    atk = 10  
};

Enemy Jack = new Enemy() {
    name = "Jack the Tripper",
    hp= 100,
    atk = 10
};

System.Console.WriteLine("\nEnter your name:\n");

Player.name = Console.ReadLine();

System.Console.WriteLine($"\n{Player.name} huh? Sounds silly!");
Thread.Sleep(2000);
System.Console.WriteLine("Okay, now it's time for...!");
Thread.Sleep(2000);
System.Console.WriteLine($"{Jack.name} has appeared!\n");
Thread.Sleep(2000);
Console.Clear();
Thread.Sleep(2000);




System.Console.WriteLine($"{Player.name} vs {Jack.name}"!);
Thread.Sleep(200);
System.Console.WriteLine("___________________________________________\n");
Thread.Sleep(200);
System.Console.WriteLine($"[{Player.hp}]---------------------------------[{Jack.hp}]");
Thread.Sleep(200);
System.Console.WriteLine("___________________________________________");
Thread.Sleep(200);
System.Console.WriteLine($"Press Enter to punch {Jack.name}!");
Console.ReadLine();
Jack.hp -= Player.atk;


while(Player.hp != 0 || Jack.hp != 0)
{
    System.Console.WriteLine($"{Player.name} vs {Jack.name}"!);
    System.Console.WriteLine("___________________________________________\n");
    System.Console.WriteLine($"[{Player.hp}]---------------------------------[{Jack.hp}]");
    System.Console.WriteLine("___________________________________________");
    System.Console.WriteLine($"Press Enter to punch {Jack.name}!");
    Console.ReadLine();
    Console.Clear();

    Jack.hp-= Player.atk;

}

Console.ReadLine();

