using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    
    internal class OrderWithPackage : OrderItem
    {
    private string packageName;
    private decimal packagePrice;
    protected string PackageName { get { return packageName; } }
    protected decimal PackagePrice { get { return packagePrice; } }
    public OrderWithPackage(string name, int quantity, decimal unitprice,string packageName, decimal packagePrice) : base (name, quantity,unitprice)
    {
            this.packagePrice=packagePrice;
            this.packageName=packageName;
    }

    public override decimal GetValue() => base.GetValue() + (Quantity * PackagePrice);



    }
}
