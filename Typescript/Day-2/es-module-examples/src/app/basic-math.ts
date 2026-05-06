console.log('Basic Math Module Started!');

import message,{ square } from "./adv-math";

function addition(num1: number, num2: number): number {
    return num1 + num2;
}
function subtraction(num1: number, num2: number): number {
    return num1 - num2;
}
function multiplication(num1: number, num2: number): number {
    return num1 * num2;
}
function division(num1: number, num2: number): number {
    return num1 / num2;
}

console.log(`Basic Math Module Executed message function : ${   message()}`);
console.log(`Square from Basic Math ${square(30)}!`)
export { addition, multiplication, subtraction, division, square};

console.log('Basic Math Module Ended!');