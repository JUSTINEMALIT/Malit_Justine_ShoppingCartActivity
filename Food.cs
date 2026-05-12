using System;

//food.CS

//create ng food constructors

class Food : MenuItem
{
    public int RemainingStock { get; set; }

    public Food(int id, string name, string category, double price, int remainingStock)
        : base(id, name, category, price)
    {
        RemainingStock = remainingStock;
    }


       //  Display 
    public override void DisplayFood()
    {
        Console.WriteLine($"  [{Id}] {Name,-25} {Category,-14} PHP {Price,8:F2}   Stock: {RemainingStock}");
    }


        // Stocks categories helpers 
    public bool HasEnoughStock(int qty)  => RemainingStock >= qty;
    public void DeductStock(int qty)     => RemainingStock -= qty;
    public void RestoreStock(int qty)    => RemainingStock += qty;
    public bool IsLowStock()             => RemainingStock <= LOW_STOCK_THRESHOLD;
}