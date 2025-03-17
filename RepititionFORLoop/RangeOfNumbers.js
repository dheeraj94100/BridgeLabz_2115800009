function isPrime(num) {
    if (num <= 1) return false;
    if (num <= 3) return true;

    if (num % 2 === 0 || num % 3 === 0) return false;

    for (let i = 5; i * i <= num; i += 6) {
        if (num % i === 0 || num % (i + 2) === 0) return false;
    }

    return true;
}

function findPrimesInRange(start, end) {
    let primes = [];
    for (let i = start; i <= end; i++) {
        if (isPrime(i)) {
            primes.push(i);
        }
    }
    return primes;
}

// Example usage:
let start = parseInt(prompt("Enter the start of the range: "));
let end = parseInt(prompt("Enter the end of the range: "));

let primes = findPrimesInRange(start, end);
console.log(`Prime numbers between ${start} and ${end} are: ${primes.join(", ")}`);