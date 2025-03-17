// Get three numbers from the user
let a = prompt("Enter the first number (a): ");
let b = prompt("Enter the second number (b): ");
let c = prompt("Enter the third number (c): ");

// Perform the arithmetic operations
let result1 = a + b * c;
let result2 = a % b + c;
let result3 = c + a / b;
let result4 = a * b + c;

// Find the maximum and minimum results
let maxResult = Math.max(result1, result2, result3, result4);
let minResult = Math.min(result1, result2, result3, result4);

// Display the results
console.log(`Results of the operations:
1. a + b * c = ${result1}
2. a % b + c = ${result2}
3. c + a / b = ${result3}
4. a * b + c = ${result4}`);

console.log(`Maximum result: ${maxResult}`);
console.log(`Minimum result: ${minResult}`);