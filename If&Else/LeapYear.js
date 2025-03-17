function isLeapYear(year) {
    if (year.toString().length !== 4) {
        return "Year must be a 4 digit number";
    }
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        return "Year is a Leap Year";
    } else {
        return "Year is not a Leap Year";
    }
}

// Example usage:
const year = 2024;
console.log(isLeapYear(year)); // Output: Year is a Leap Year