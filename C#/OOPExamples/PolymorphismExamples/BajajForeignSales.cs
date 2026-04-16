namespace PolymorphismExamples;

internal class BajajForeignSales : BajajSales
{
    public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent, double shippingAmount)
    {
        double gstAmount = actualSales * gstPercent / 100;
        return actualSales - (cogs + expense + gstAmount + shippingAmount);
    }
    public override int GstPercent()
    {
        return 18;
    }
    //Shadowing
    public new double ShippingAmount()
    {
        return 5000;
    }
}
