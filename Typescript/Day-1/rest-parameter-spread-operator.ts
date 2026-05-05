//REST Parameter - It packs comma separated values in an array. Only one rest parameter and it must be the last parameter in the parameters list

function clientOffices(state: string, ...cities: string[]): void {
    console.log(`In State - ${state}`);
    for (const city of cities) {
        console.log(`   Bajaj office is at city - ${city}!`)
    }
}

const MHCities = ["Mumbai", "Pune", "Nagpur", "Nashik"];
//SPREAD - Unpack the array/object values
clientOffices('Maharashtra', ...MHCities);
clientOffices("Andhra Pradesh", "Hyderabad", "Vijayawada", "Nellore");
clientOffices("Karnataka", "Bangaluru", "Mangalore");

const PizzaOrder = {
    customerId: 48932,
    orderId: 3772,
    orderDate: new Date(),
    pizzaName: 'Veg Pizza',
    pizzaSize: 'Personal',
    unitPrice: 450,
    status: 'Your Order has been accepted by PizzaHut'
}

const PizzaInOven = {
    ...PizzaOrder,
    status: 'Your Pizza is getting Baked!'
}

const PizzaOutForDelivery = {
    ...PizzaInOven,
    status: 'Your Pizza is out for Delivery!'
}

console.log(PizzaOrder)
console.log(PizzaInOven)
console.log(PizzaOutForDelivery)

console.log(..."Hello");