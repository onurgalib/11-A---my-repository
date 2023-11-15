using System;
using System.Collections.Generic;

public enum DriverType
{
    Undefined,
    AutomobilesB,
    TrucksC,
    Bycicle0,
    MotorA
}

public class Customer
{
    private static decimal annualRefundCoef = 15.00m;
    private static int maxVIPLvlVIP = 10;

    public string Name { get; }
    public string Address { get; set; }
    public DateTime BirthDate { get; }
    public DriverType DriverType { get; set; }
    public int VIPLevel { get; private set; }
    public List<Order> Orders { get; }

    public Customer(string name, DriverType driverType)
    {
        Name = name;
        BirthDate = DateTime.Now;
        DriverType = driverType;
        VIPLevel = 0;
        Orders = new List<Order>();
    }

    public int ImproveVip()
    {
        if (VIPLevel < maxVIPLvlVIP)
        {
            VIPLevel++;
        }
        else
        {
            Console.WriteLine($"Maximal VIP= {maxVIPLvlVIP} reached already");
        }
        return VIPLevel;
    }

    public decimal GetSpentMoney()
    {
        return Orders.Sum(order => order.Price);
    }

    public void RegisterOrder(Order order)
    {
        decimal reduction = order.Price * (annualRefundCoef * VIPLevel / 100 * maxVIPLvlVIP);
        order.ApplyDiscount(reduction);
        Orders.Add(order);
    }
}

public class Order
{
    public string Description { get; set; }
    public DateTime Date { get; }
    private decimal _price;

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid Price value!");
                _price = 0;
            }
            else
            {
                _price = value;
            }
        }
    }

    public Order(DateTime date, string description, decimal price)
    {
        Date = date.Year > DateTime.Now.Year ? DateTime.Now : date;
        Description = description;
        Price = price;
    }

    public void ApplyDiscount(decimal reduction)
    {
        Price = Price * (1 - reduction);
    }
}