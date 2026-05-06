console.log('Employee Module Started!');

import Person from './person';

class Employee extends Person {
    constructor() {
        super();
        console.log(`Employee Class Constructor Executed!`);
    }
    empCode: number;
}


//Singleton pattern
export default new Employee();

console.log('Employee Module Ended!');