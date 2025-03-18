let repeatedDigits = [];

//Because [0,9] are not repeated digits
for (let i = 10; i <= 100; i++) {
    let strNum = i.toString();
    if (strNum[0] === strNum[1]) {
        repeatedDigits.push(i);
    }
}

console.log(repeatedDigits);