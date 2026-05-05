//Type Inference - upon declaration and initiation, typescript compiler will pickup an appropriate type from the type system and retain that type throughout the life of you program

let num1 = '100';
// num1=1000;

//Type Annotations
let num2: number;
num2 = 100;
// num2 = "Pravin";
// num2 = true;

//Type annotations with union types
let INR: number | string;
INR = 100;
console.log(typeof(INR));
INR = "Hundred";

console.log(typeof(INR));
// INR=true;

//Type Annotation in function

//function addition(num1: number, num2: number): number {
// function addition(num1: number, num2: number): void|number {
//     //return num1 + num2;
//     console.log(num1 + num2);
// }

