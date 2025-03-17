function factorial(n) {
    if (n < 0) {
        return "Factorial is not defined for negative numbers";
    }
    let result = 1;
    for (let i = 1; i <= n; i++) {
        result *= i;
    }
    return result;
}

const inputNumber = parseInt(prompt("Enter a number: "), 10);
if (!isNaN(inputNumber)) {
    console.log(`The factorial of ${inputNumber} is ${factorial(inputNumber)}`);
} else {
    console.log("Please enter a valid number");
}