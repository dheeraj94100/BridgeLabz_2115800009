const number = prompt('Enter a number (0-6): ');
let day;
if (number == 0) {
    day = 'Sunday';
} else if (number == 1) {
    day = 'Monday';
} else if (number == 2) {
    day = 'Tuesday';
} else if (number == 3) {
    day = 'Wednesday';
} else if (number == 4) {
    day = 'Thursday';
} else if (number == 5) {
    day = 'Friday';
} else if (number == 6) {
    day = 'Saturday';
} else {
    day = 'Invalid number. Please enter a number between 0 and 6.';
}
console.log(day);
