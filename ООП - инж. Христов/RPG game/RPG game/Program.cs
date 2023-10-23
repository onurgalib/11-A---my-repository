Item sword = new Item("sword", 8.0, 2.0);
Item shield = new Item("shield", 2.0, 10.0);

Hero hero = new Hero("HeroName", Fraction.Knight);

while (true)
{
    Console.WriteLine("Choose an action:");
    Console.WriteLine("1.level up");
    Console.WriteLine("2.view hero's stats");
    Console.WriteLine("3.upgrade item");
    Console.WriteLine("4.change fraction");
    Console.WriteLine("5.quit");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                int newLevel = hero.LevelUp();
                Console.WriteLine($"hero leveled up to level {newLevel}");
                break;
            case 2:
                double attack = hero.GetAttack();
                double defence = hero.GetDefence();
                Console.WriteLine($"hero's Attack: {attack}");
                Console.WriteLine($"hero's Defence: {defence}");
                break;
            case 3:
                Console.WriteLine("enter item name to upgrade (Sword or Shield):");
                string itemName = Console.ReadLine();
                if (itemName == "sword")
                {
                    Console.WriteLine("enter the amount to upgrade Attack:");
                    if (double.TryParse(Console.ReadLine(), out double upgradeAmount))
                    {
                        sword.UpgradeAttack(upgradeAmount);
                    }
                    else
                    {
                        Console.WriteLine("invalid input for upgrade amount.");
                    }
                }
                else if (itemName == "shield")
                {
                    Console.WriteLine("enter the amount to upgrade Defence:");
                    if (double.TryParse(Console.ReadLine(), out double upgradeAmount))
                    {
                        shield.UpgradeDefence(upgradeAmount);
                    }
                    else
                    {
                        Console.WriteLine("invalid input for upgrade amount.");
                    }
                }
                else
                {
                    Console.WriteLine("invalid item name.");
                }
                break;
            case 4:
                Console.WriteLine("choose a new fraction (Mage, Knight, Priest, Ranged, Rogue):");
                string newFraction = Console.ReadLine();
                if (Enum.TryParse<Fraction>(newFraction, out Fraction parsedFraction))
                {
                    hero.Fraction = parsedFraction;
                    Console.WriteLine($"hero's new fraction: {hero.Fraction}");
                }
                else
                {
                    Console.WriteLine("invalid fraction.");
                }
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("invalid choice. Please select a valid option.");
                break;
        }
    }
    else
    {
        Console.WriteLine("invalid input. Please enter a valid number.");
    }
}
        
    
    public class Hero
{
    private double attackCoef = 15;
    private double defenceCoef = 20;
    public string Name { get; }
    public Fraction Fraction { get; set; }
    public int Level { get; private set; }
    public double Health { get; private set; } = 100;
    public double Stamina { get; private set; } = 100;
    public double Mana { get; private set; } = 100;
    public List<Item> ItemSet { get; }
    public Hero(string name, Fraction fraction)
    {
        Name = name;
        Fraction = fraction;
        Level = 0;
        ItemSet = new List<Item>();
    }
    public int LevelUp()
    {
        Level++;
        Health = 100;
        Stamina = 100;
        Mana = 100;
        return Level;
    }
    public double GetAttack()
    {
        double totalAttack = 0;
        foreach (var item in ItemSet)
        {
            totalAttack += item.Attack;
        }
        return totalAttack + (Level * attackCoef);
    }
    public double GetDefence()
    {
        double totalDefence = 0;
        foreach (var item in ItemSet)
        {
            totalDefence += item.Defence;
        }
        return totalDefence + (Level * defenceCoef);
    }
}
public class Item
{
    public string Name { get; }
    public double Attack { get; private set; }
    public double Defence { get; private set; }
    public Item(string name, double atk, double def)
    {
        if (atk < 0 || atk > 10 || def < 0 || def > 10)
        {
            Console.WriteLine("invalid Attack / Defence item value");
        }
        Name = name;
        Attack = atk;
        Defence = def;
    }
    public void UpgradeAttack(double atk)
    {
        if (atk < 0 || atk > 50)
        {
            Console.WriteLine("invalid Attack improvement value");
        }
        else
        {
            Attack += atk;
        }
    }
    public void UpgradeDefence(double def)
    {
        if (def < 0 || def > 50)
        {
            Console.WriteLine("invalid Defence improvement value");
        }
        else
        {
            Defence += def;
        }
    }
}

public enum Fraction
{
    Mage,
    Knight,
    Priest,
    Ranged,
    Rogue
}