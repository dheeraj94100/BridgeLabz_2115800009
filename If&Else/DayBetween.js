const day = parseInt(process.argv[2]);
const month = parseInt(process.argv[3]);

function isDayBetween(day, month) {
    if (month < 3 || month > 6) {
        return false;
    }
    if (month === 3 && day < 20) {
        return false;
    }
    if (month === 6 && day > 20) {
        return false;
    }
    return true;
}

console.log(isDayBetween(day, month));