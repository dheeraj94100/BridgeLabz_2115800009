function isPalindrome(num) {
    const str = num.toString();
    const reversedStr = str.split('').reverse().join('');
    return str === reversedStr;
}

function areBothPalindromes(num1, num2) {
    return isPalindrome(num1) && isPalindrome(num2);
}

// Example usage:
const num1 = prompt('Enter the first number: ');
const num2 = prompt('Enter the second number: ');
console.log(areBothPalindromes(num1, num2)); // Output: true