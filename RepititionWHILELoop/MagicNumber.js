const prompt = require('prompt-sync')();

let low = 1;
let high = 100;
let found = false;

console.log("Think of a number between 1 and 100");

while (!found) {
    let mid = Math.floor((low + high) / 2);
    let response = prompt(`Is your number less than ${mid}? (yes/no): `);

    if (response.toLowerCase() === 'yes') {
        high = mid - 1;
    } else {
        response = prompt(`Is your number greater than ${mid}? (yes/no): `);
        if (response.toLowerCase() === 'yes') {
            low = mid + 1;
        } else {
            console.log(`Your magic number is ${mid}`);
            found = true;
        }
    }
}