namespace Payment {
    export namespace COD {
        export function makePayment(customerId: number, orderId: number, amount: number): string {
            return `Customer Id ${customerId} needs to pay CASH INR ${amount}/- for an Order Id ${orderId}!`;
        }
    }
    export namespace Wallet {
        export function makePayment(customerId: number, orderId: number, amount: number, walletName: string): string {
            return `Customer Id ${customerId} needs to pay INR ${amount}/- for an Order Id ${orderId} using wallet ${walletName}!`;
        }
    }
}

console.log(Payment.COD.makePayment(123,782,12000));
console.log(Payment.Wallet.makePayment(123,782,12000,"GPay"));
