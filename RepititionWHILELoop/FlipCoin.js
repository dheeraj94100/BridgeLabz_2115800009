let headsCount = 0;
let tailsCount = 0;
const targetWins = 11;

while (headsCount < targetWins && tailsCount < targetWins) {
    let flip = Math.random() < 0.5 ? 'heads' : 'tails';
    if (flip === 'heads') {
        headsCount++;
    } else {
        tailsCount++;
    }
    console.log(`Flip: ${flip}, Heads: ${headsCount}, Tails: ${tailsCount}`);
}

if (headsCount === targetWins) {
    console.log("Heads wins 11 times!");
} else {
    console.log("Tails wins 11 times!");
}