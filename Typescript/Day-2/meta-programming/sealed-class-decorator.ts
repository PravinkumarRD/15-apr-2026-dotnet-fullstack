function nonExtendable<T extends { new(...args: any[]): {} }>(constructor: T) {
    return class extends constructor {
        constructor(...args: any[]) {
            
            if (new.target !== constructor) {
                throw new Error(`${constructor.name} class cannot be extended`);
            }
            super(...args);
        }
    };
}

@nonExtendable
class BajajCustomer {
    contactName: string;
    constructor(contactName: string) {
        this.contactName = contactName;
    }
    getCustomerInfo() {
        return `Hello, ${this.contactName} From Bajaj Customer Support!`;
    }
}

// Attempt to extend the non-extendable BajajCustomer class
class BajajPrimeCustomer extends BajajCustomer {
    fees: number;
    constructor(message: string, fees: number) {
        super(message);
        this.fees = fees;
    }
    anualFees(): string {
        return `${this.getCustomerInfo()} Please pay INR ${this.fees}/-`;
    }
}

// This will throw an error
try {
    const extendedBajajCustomer = new BajajPrimeCustomer('world', 1499);
    console.log(extendedBajajCustomer.anualFees());
} catch (e: any) {
    console.error(e.message);
}

const bajajCustomer = new BajajCustomer('world'); 
console.log(bajajCustomer.getCustomerInfo()); 
