const prompt = require('prompt-sync')();

function feetToInch(feet) {
    return feet * 12;
}

function inchToFeet(inches) {
    return inches / 12;
}

function feetToMeter(feet) {
    return feet * 0.3048;
}

function meterToFeet(meters) {
    return meters / 0.3048;
}

console.log("Unit Conversion Options:");
console.log("1. Feet to Inch");
console.log("2. Inch to Feet");
console.log("3. Feet to Meter");
console.log("4. Meter to Feet");

const choice = parseInt(prompt("Enter your choice (1-4): "));
const value = parseFloat(prompt("Enter the value to convert: "));

let result;

switch (choice) {
    case 1:
        result = feetToInch(value);
        console.log(`${value} Feet is equal to ${result} Inches`);
        break;
    case 2:
        result = inchToFeet(value);
        console.log(`${value} Inches is equal to ${result} Feet`);
        break;
    case 3:
        result = feetToMeter(value);
        console.log(`${value} Feet is equal to ${result} Meters`);
        break;
    case 4:
        result = meterToFeet(value);
        console.log(`${value} Meters is equal to ${result} Feet`);
        break;
    default:
        console.log("Invalid choice");
}