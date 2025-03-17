function getRandomThreeDigitNumber() {
    return Math.floor(Math.random() * 900) + 100;
}

let numbers = [];
for (let i = 0; i < 5; i++) {
    numbers.push(getRandomThreeDigitNumber());
}

let min = Math.min(...numbers);
let max = Math.max(...numbers);

console.log("Random 3-digit numbers: ", numbers);
console.log("Minimum value: ", min);
console.log("Maximum value: ", max);