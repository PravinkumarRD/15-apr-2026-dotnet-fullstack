//Product Search [Company Name, Stock]
const Products = [
    {
        productId: 101,
        productName: 'Samsung Galaxy',
        company: 'Samsung',
        stock: 100,
        unitPrice: 34000
    },
    {
        productId: 102,
        productName: 'Apple iPhone',
        company: 'Apple',
        stock: 56,
        unitPrice: 65000
    },
    {
        productId: 103,
        productName: 'Apple Tab',
        company: 'Apple',
        stock: 67,
        unitPrice: 75000
    },
    {
        productId: 104,
        productName: 'Samsung Note',
        company: 'Samsung',
        stock: 34,
        unitPrice: 123000
    },
    {
        productId: 105,
        productName: 'Vivo',
        company: 'Vivo',
        stock: 45,
        unitPrice: 18000
    }
];

function searchProducts(companyName: string): string[];
function searchProducts(stock: number): string[];
function searchProducts(value: string | number): string[] {
    const allProducts = [...Products];
    const availableProducts: string[] = [];
    if (typeof (value) === 'string') {
        for (const product of allProducts) {
            if (product.company === value)
                availableProducts.push(product.productName);
        }
    } else {
        for (const product of allProducts) {
            if (product.stock >= value)
                availableProducts.push(product.productName);
        }
    }
    return availableProducts;
}

console.log(searchProducts("Samsung"));
console.log(searchProducts(45));