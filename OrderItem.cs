using System;

public class OrderItem
{
	private string name;
    private int quantity;
    private decimal unitprice;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;;
        }
    }

    public decimal Unitprice
    {
        get
        {
            return unitprice;
        }
        set
        {
            Unitprice = unitprice;
            
        }
    }
    
    
    public OrderItem(string name, int quantity, decimal unitprice)
	{
        this.name = name;
        this.quantity = quantity;
        this.unitprice = unitprice;

    }

    public virtual decimal GetValue()
    {
        return quantity * unitprice;
    }
    public override string ToString();
    {
        return $"{name}, cena: {unitprice} PLN, {quantity} szt, wartość: {GetValue()} PLN";"
    }
}
