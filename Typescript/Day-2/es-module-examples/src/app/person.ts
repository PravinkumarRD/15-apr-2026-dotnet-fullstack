console.log('Person Module Started!');
export default class Person {
    constructor(){
        console.log(`Person Class Constructor Executed!`);
    }
    name: string;
    age: number;
}
console.log('Person Module Ended!');