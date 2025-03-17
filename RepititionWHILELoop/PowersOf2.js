const n = parseInt(process.argv[2]);

if (isNaN(n)) {
    console.log("Please provide a valid number as an argument.");
    process.exit(1);
}

let i = 0;
let powerOf2 = 1;

while (i <= n && powerOf2 <= 256) {
    console.log(`2^${i} = ${powerOf2}`);
    powerOf2 *= 2;
    i++;
}