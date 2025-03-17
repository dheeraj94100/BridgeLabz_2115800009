function simulateCoinFlip() {
    // Generate a random number between 0 and 1
    let randomNum = Math.random();
    
    // If the number is less than 0.5, it's Heads, otherwise it's Tails
    if (randomNum < 0.5) {
        console.log("Heads");
    } else {
        console.log("Tails");
    }
}

// Call the function to simulate the coin flip
simulateCoinFlip();