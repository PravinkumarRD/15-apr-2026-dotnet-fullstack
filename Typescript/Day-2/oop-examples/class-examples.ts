// class Person{
//     public firstName:string;
//     public lastName:string;
//     public city:string;
//     printPersonInfo():void{
//         console.log(`Person ${this.firstName} ${this.lastName} lives in city ${this.city}!`)
//     }
// }

// class Person {
//     constructor(fname?: string, lname?: string, city?: string) {
//         this.firstName = fname;
//         this.lastName = lname;
//         this.city = city;
//     }
//     public firstName: string | undefined;
//     public lastName: string | undefined;
//     public city: string | undefined;
//     printPersonInfo(): void {
//         console.log(`Person ${this.firstName} ${this.lastName} lives in city ${this.city}!`)
//     }
// }

// class Person {
//     constructor(public firstName: string, public lastName: string, public city: string) {

//     }
//     printPersonInfo(): void {
//         console.log(`Person ${this.firstName} ${this.lastName} lives in city ${this.city}!`)
//     }
// }

abstract class Person {
    constructor(public firstName?: string, public lastName?: string, public city?: string) {

    }
    private _address: string;
    get address(): string {
        return this._address;
    }
    set address(v: string) {
        //validation
        this._address = v;
    }
    printPersonInfo(): void {
        console.log(`Person ${this.firstName} ${this.lastName} lives in city ${this.city}!`)
    }
    abstract changeAddress(oldAddress: string, newAddress: string): boolean;
}

//Customer IS-A Person
class Customer extends Person {
    constructor() {
        super();
    }
    changeAddress(oldAddress: string, newAddress: string): boolean {
        console.log(`Customer ${this.firstName} ${this.lastName} has changed his/her adress from ${oldAddress} to ${newAddress}!`);
        return true;
    }
}

const p1: Person = new Customer();
p1.address = "Moon City";
p1.printPersonInfo();

// p1.firstName = "Alisha";
// p1.lastName = "C.";
// p1.city = "Mumbai";
p1.changeAddress(p1.address, "Earth City");

class Parent {
    constructor();
    constructor(id: number);
    constructor(id?: number, name?: string);
    constructor(id?: number, name?: string) {
        if (!id && !name) {
            console.log('Default Parent Constructor called!');
        } else if (id && !name) {
            console.log('1 Parameter  Parent Constructor called!');
        } else if (id && name) {
            console.log('2 Parameters  Parent Constructor called!');
        }
    }
    protected socialId: number;
}
class Child extends Parent {

}
class GrandChild extends Child {

}

const pt: Parent = new Parent(1000, "Alisha C.");

class Counter {
    private static _count: number = 1;

    static incrementCounter(): number {
        return this._count++;
    }
}
console.log(Counter.incrementCounter());
console.log(Counter.incrementCounter());
console.log(Counter.incrementCounter());


