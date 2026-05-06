console.log('Main Module Started!');

//import { addition, multiplication, square, division, subtraction} from "./app/basic-math";
import * as bajajMath from './app/basic-math';
import e1 from "./app/employee";
import e2 from "./app/employee";

e1.empCode=100;
e1.age=23;
e1.name="John Mark";
console.log(e1);
console.log(e2);
console.log(bajajMath.addition(100,200));
console.log(bajajMath.multiplication(67,45));

console.log('Main Module Ended!');