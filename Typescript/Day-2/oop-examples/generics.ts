//Purchase Order System
class Category{
    constructor(public categoryId: number, public categoryName: string, public description:string) { }
}

class BajajProduct {
    constructor(
        public productId: number,
        public productName: string,
        public unitPrice: number,
        public categoryId: number
    ) { }
}

interface ICommonCrud<T>{
    getAll():T[];
    getDetailsById(id:number):T;
    insert(item:T):void;
    update(item:T):void;
    delete(id:number):void;
}

class CommonRepository<T> implements ICommonCrud<T>{
    private _localDb:Array<T> = new Array<T>();

    getAll(): T[] {
        return this._localDb;
    }
    getDetailsById(id: number): T {
        return this._localDb[0];
    }
    insert(item: T): void {
        this._localDb.push(item);
    }
    update(item: T): void {
        throw new Error("Method not implemented.");
    }
    delete(id: number): void {
        throw new Error("Method not implemented.");
    }

}

const cat1:Category=new Category(1,"Electronics","Electronic Devices");
const cat2:Category=new Category(1,"Electrics","Electric Devices");

const product1:BajajProduct=new BajajProduct(1000,"Washing Machine",52000,1);
const product2:BajajProduct=new BajajProduct(1001,"Oven",32000,1);
const product3:BajajProduct=new BajajProduct(1000,"Socket",200,2);
const product4:BajajProduct=new BajajProduct(1001,"Wire",300,2);

const catRepo:ICommonCrud<Category>=new CommonRepository<Category>();
catRepo.insert(cat1);
catRepo.insert(cat2);
console.log(catRepo.getAll());
console.log(catRepo.getDetailsById(cat1.categoryId));

const productRepo:ICommonCrud<BajajProduct>=new CommonRepository<BajajProduct>();
productRepo.insert(product1);
productRepo.insert(product2);
productRepo.insert(product3);
productRepo.insert(product4);
console.log(productRepo.getAll());
console.log(productRepo.getDetailsById(product1.productId));