function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function rollDieUntilLimit(limit) {
    let results = new Map([[1, 0], [2, 0], [3, 0], [4, 0], [5, 0], [6, 0]]);
    let maxReached = false;

    while (!maxReached) {
        let roll = rollDie();
        results.set(roll, results.get(roll) + 1);
        if (results.get(roll) === limit) {
            maxReached = true;
        }
    }

    return results;
}

function findMaxMin(results) {
    let max = { number: null, count: 0 };
    let min = { number: null, count: Infinity };

    results.forEach((count, number) => {
        if (count > max.count) {
            max.number = number;
            max.count = count;
        }
        if (count < min.count) {
            min.number = number;
            min.count = count;
        }
    });

    return { max, min };
}

const limit = 10;
const results = rollDieUntilLimit(limit);
const { max, min } = findMaxMin(results);

console.log("Results:", Object.fromEntries(results));
console.log("Number that reached maximum times:", max);
console.log("Number that reached minimum times:", min);