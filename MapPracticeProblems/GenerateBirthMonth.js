function generateBirthMonths() {
    let birthMonths = new Map();

    for (let i = 0; i < 50; i++) {
        let month = Math.floor(Math.random() * 12) + 1;
        if (birthMonths.has(month)) {
            birthMonths.get(month).push(`Individual${i + 1}`);
        } else {
            birthMonths.set(month, [`Individual${i + 1}`]);
        }
    }

    return birthMonths;
}

function printBirthMonths(birthMonths) {
    birthMonths.forEach((individuals, month) => {
        console.log(`Month ${month}: ${individuals.join(', ')}`);
    });
}

let birthMonths = generateBirthMonths();
printBirthMonths(birthMonths);