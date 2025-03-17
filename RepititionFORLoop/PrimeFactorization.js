function primeFactors(N) {
    let factors = [];
    
    // Print the number of 2s that divide N
    while (N % 2 === 0) {
        factors.push(2);
        N = N / 2;
    }

    // N must be odd at this point, so we can skip one element (i.e., we can increment by 2)
    for (let i = 3; i * i <= N; i += 2) {
        // While i divides N, print i and divide N
        while (N % i === 0) {
            factors.push(i);
            N = N / i;
        }
    }

    // This condition is to handle the case when N is a prime number greater than 2
    if (N > 2) {
        factors.push(N);
    }

    return factors;
}

// Example usage:
let N = prompt("Enter a number: ");
console.log(`Prime factors of ${N} are: ${primeFactors(N).join(', ')}`);