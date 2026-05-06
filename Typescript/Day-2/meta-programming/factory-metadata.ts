//Method Decorator
function gst(gstPercentage: number) {
    return function (target: Object, key: string, descriptor: PropertyDescriptor) {
        const originalFunc = descriptor.value;

        descriptor.value = function () {
            const gstAmount = arguments[2] * gstPercentage / 100;
            return originalFunc(arguments[0], arguments[1], arguments[2]) - gstAmount;
        };
        return descriptor;
    }
}

class IndianSalesCalculator {
    @gst(18)
    salesNetProfit(cogs: number, expense: number, actualSales: number): number {
        return actualSales - (cogs + expense);
    }
}
const sales: IndianSalesCalculator = new IndianSalesCalculator();
console.log(sales.salesNetProfit(12000, 13000, 150000));