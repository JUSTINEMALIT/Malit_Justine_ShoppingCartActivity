using System;

// base class para sa lahat ng  menu items

class MenuItem
{
    public int    Id       { get; protected set; }
    public string Name     { get; protected set; }
    public string Category { get; protected set; }
    public double Price    { get; protected set; }

    public const int LOW_STOCK_THRESHOLD = 5;

    public MenuItem(int id, string name, string category, double price)
    {
        Id       = id;
        Name     = name;
        Category = category;
        Price    = price;
    }

    public virtual void DisplayFood()
    {
        Console.WriteLine($"  [{Id}] {Name,-25} {Category,-14} PHP {Price,8:F2}");
    }

    public double GetItemTotal(int quantity) => Price * quantity;
}