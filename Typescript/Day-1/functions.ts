// function addition(num1: number, num2: number): number {
//     return num1 + num2;
// }
// function addition(num1: number, num2: number, num3:number): number {
//     return num1 + num2 + num3;
// }

// console.log(addition(10,20));

//SalesNetProfit = incoming money - outgoing money

// //Optional Parameters - All optional parameters must follow compusary parameters
// function salesNetProfit(cogs: number, expense: number, actualSales: number, gstPercent?: number): number {
//     if (gstPercent === undefined) {
//         gstPercent = 0;
//     }
//     let gstAmount: number = actualSales * gstPercent / 100;
//     return actualSales - (cogs + expense + gstAmount);
// }

// console.log(salesNetProfit(12000,13000,150000))

//Default parameter
function salesNetProfit(cogs: number, expense: number=15000, actualSales: number, gstPercent: number=18): number {
    let gstAmount: number = actualSales * gstPercent / 100;
    return actualSales - (cogs + expense + gstAmount);
}

console.log(salesNetProfit(12000,undefined,150000))