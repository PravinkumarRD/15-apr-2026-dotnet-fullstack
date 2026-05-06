interface Physics {
    physicsCalci(message: string): string;
}
interface Biology {
    biologyCalci(message: string): string;
}
interface Chemistry {
    chemistryCalci(message: string): string;
}

interface ScienceDepartment extends Physics,Chemistry,Biology{

}

class Sceince implements ScienceDepartment{
    physicsCalci(message: string): string {
        return `${message} From Physics Department!`;
    }
    chemistryCalci(message: string): string {
        return `${message} From Chemistry Department!`;
    }
    biologyCalci(message: string): string {
        return `${message} From Biology Department!`;
    }
}

const physics:Physics = new Sceince();
console.log(physics.physicsCalci("Hello"));

const chemistry:Chemistry = new Sceince();
console.log(chemistry.chemistryCalci("Hello"));

const biology:Biology = new Sceince();
console.log(biology.biologyCalci("Hello"));

const hod:ScienceDepartment=new Sceince();

interface Product{
    productId:number;
    productName:string;
    unitPrice:number;
    stock:number;
    company:string;
    isBlackListed?:boolean;
}

const MyProduct:Product={
     productId:1000,
    productName:"Product - 1",
    unitPrice:1200,
    stock:78,
    company:"Bajaj"
}

function printMyProduct(product:Product):void{
    console.log(`I have a product ${product.productName} from company ${product.company} with unit price INR ${product.unitPrice}!`)
}
printMyProduct(MyProduct);