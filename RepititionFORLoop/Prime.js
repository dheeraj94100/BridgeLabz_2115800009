
function isPrime(num) {
    if (num <= 1) return false;
    if (num <= 3) return true;

    if (num % 2 === 0 || num % 3 === 0) return false;

    for (let i = 5; i * i <= num; i += 6) {
        if (num % i === 0 || num % (i + 2) === 0) return false;
    }

    return true;
}

const input = parseInt(prompt("Enter a number: "), 10);
if (isPrime(input)) {
    console.log(`${input} is a prime number.`);
} else {
    console.log(`${input} is not a prime number.`);
}