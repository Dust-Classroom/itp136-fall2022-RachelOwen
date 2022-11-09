using System;
using System.IO;
using static System.Console;

class CakeOrder
{
    static void Main(String[] args)
    {
        FileStream file = new FileStream("CakeOrders.csv", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        reader.ReadLine();
        while(!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            CakeOrder currentOrder = new(Convert.ToInt32(values[0]), values[1], values[2], Convert.ToDecimal(values[3]));
            WriteLine("Order Number {0} | Customer: {1,-15} | Type: {2,-12} | {3,5:C2}", currentOrder.orderNum, currentOrder.customerName, currentOrder.cakeType, currentOrder.dollarAmount);
        }
        reader.Close();
        file.Close();
    }
    public int orderNum;
    public string customerName;
    public string cakeType;
    public decimal dollarAmount;
    public CakeOrder(int orderNum, string customerName, string cakeType, decimal dollarAmount)
    {
        this.orderNum = orderNum;
        this.customerName = customerName;
        this.cakeType = cakeType;
        this.dollarAmount = dollarAmount;
    }
}