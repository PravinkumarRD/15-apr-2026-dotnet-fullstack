/*console.log("Welcome To ECMAScript 5 Problems List!");
//Block Scoping is not possible in ES5
//How do we scope the variables in ES5?
//Function, Clouser, IIFE, Namespace

{
  var company = "Bajaj Finserv!";
}
console.log(company);

if (true) {
  //var num1 = 100;
}
//console.log(num1);

for (var i = 0; i < 5; i++) {
  //Logic
}
console.log(i);

console.warn(myFriend); //Hoisting - is placing variable and function declaration into memory
var myFriend = "Manish Kaushik";

let n1 = 100;
var n2 = "100";
n2 = true;
console.warn(n1 === n2);

//let n1 = "Pravin";
let num1 = 100;
num1=true;
*/

var cities = ["Bangluru", "Chennai", "Hyderabad", "Mumbai", "Pune"];
for (const city of cities) {
  //if(city==="Mumbai") break;
  console.warn(city);
}

const result = cities[Symbol.iterator]();
console.warn(result.next());
console.warn(result.next());
console.warn(result.next());
console.warn(result.next());
console.warn(result.next());
console.warn(result.next());

function* orderNumber() {
  yield 1000;
  yield 2000;
  yield 3000;
}

for (const ono of orderNumber()) {
  console.warn(ono);
}

function parent(sender) {
  console.log('Parent Function Execution Started!')
  let message = "Parent Function Message!";
  return function(){
    return `${sender} has send the message ${message}`;
  }
}

var output=parent("Pravinkumar R. D.");
console.log('One');
console.log('Two')
console.log(output());