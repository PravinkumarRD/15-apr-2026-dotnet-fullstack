//one liner arrow functions

const log = () => console.log(`Log of error ${new Date()} !`)
log();

const square = (num: number) => num * num;
console.log(square(10));

//Multiine Arrow Function
const profitCalculation = (cogs: number, expense: number, actualSales: number, gstPercent: number = 18):number => {
    let gstAmount: number = actualSales * gstPercent / 100;
    return actualSales - (cogs + expense + gstAmount);
}

console.log(profitCalculation(12000,13000,150000,30));