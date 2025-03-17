// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// Function to get the palindrome of a number
function getPalindrome(num) {
    return parseInt(num.toString().split('').reverse().join(''));
}

// Main function to check if the number and its palindrome are prime
function checkPrimeAndPalindrome() {
    const num = parseInt(prompt("Enter a number:"));
    if (isNaN(num)) {
        console.log("Please enter a valid number.");
        return;
    }

    if (isPrime(num)) {
        const palindrome = getPalindrome(num);
        if (isPrime(palindrome)) {
            console.log(`The number ${num} is prime and its palindrome ${palindrome} is also prime.`);
        } else {
            console.log(`The number ${num} is prime but its palindrome ${palindrome} is not prime.`);
        }
    } else {
        console.log(`The number ${num} is not prime.`);
    }
}

// Call the main function
checkPrimeAndPalindrome();