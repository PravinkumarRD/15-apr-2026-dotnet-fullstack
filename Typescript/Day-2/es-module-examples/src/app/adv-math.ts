console.log('Advance Math Module Started!');
export default function message():string{
    return "Advance Math  Module Message for default export!";
}
export function square(num: number): number {
    return num * num;
}
export function sqaureRoot(num: number): number {
    return Math.sqrt(num);
}

console.log('Advance Math Module Ended!');