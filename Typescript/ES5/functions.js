function addition() {
    console.log(arguments)
    if(arguments.length === 0)
        return 1000;
    else if(arguments.length === 1)
        return arguments[0] + 1000;
    else if(arguments.length === 2)
        return arguments[0] + arguments[1];
    else if(arguments.length === 3)
        return arguments[0] + arguments[1] + arguments[2];
    else
        return 0;
}
function addition(num1, num2) {
  return num1 + num2;
}
function addition(num1=0, num2=0, num3=0) {
  return num1 + num2 + num3;
}

console.log(addition());
console.log(addition(1000));
console.log(addition(1000,2000));
console.log(addition(1000,2000,3000));

function multiply(num1,num2){
    console.log(num1)
    console.log(num2)
    return num1 * num2;
}

console.log(multiply())
console.log('')
console.log(multiply(10))
console.log('')
console.log(multiply(10,20))
console.log('')
console.log(multiply(10,20,30))