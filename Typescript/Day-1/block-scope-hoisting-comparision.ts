//keywors [let - Block level scoping, Redeclaration not allowed within the same scope, hoisting in TDZ, different types of variable comparison not allowed]

{
    let companyName = "Bajaj Finserv!";
}
//console.log(companyName);

if (true) {
    let num1 = 100;
}
// console.log(num1);

for (let i = 0; i < 5; i++) {
    //some logic
}
// console.log(i);

//console.log(myFriend);//Hoisted in Temporal Dead Zone
let myFriend = "Alisha C.";

let n1 = 100;
var n2 = '100';
// console.warn(n1==n2);
//  n1 = 200;