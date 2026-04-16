namespace PolymorphismExamples;

//SalesNetProfit = Incoming Money - Outgoing Money
//Incoming [actualSalesAmount]
//Outgoing [cogs, expense, gstAmount]

internal class BajajSales
{
    public double ShippingAmount()
    {
        return 0;
    }
    public virtual int GstPercent()
    {
        return 0;
    }
    public double SalesNetProfit(double cogs, double expense, double actualSales)
    {
        return actualSales - (cogs + expense);
    }

    public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent)
    {
        double gstAmount = actualSales * gstPercent / 100;
        return actualSales - (cogs + expense + gstAmount);
    }
}
