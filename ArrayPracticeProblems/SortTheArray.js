// a. Generates 10 Random 3 Digit number.
function generateRandomNumbers() {
    let randomNumbers = [];
    for (let i = 0; i < 10; i++) {
        let randomNumber = Math.floor(Math.random() * 900) + 100;
        randomNumbers.push(randomNumber);
    }
    return randomNumbers;
}

// b. Store this random numbers into an array.
let randomNumbersArray = generateRandomNumbers();
console.log("Generated Random Numbers: ", randomNumbersArray);

// c. Find the 2nd largest and the 2nd smallest element without sorting the array.
function findSecondLargestAndSmallest(arr) {
    let firstLargest = -Infinity, secondLargest = -Infinity;
    let firstSmallest = Infinity, secondSmallest = Infinity;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > firstLargest) {
            secondLargest = firstLargest;
            firstLargest = arr[i];
        } else if (arr[i] > secondLargest && arr[i] != firstLargest) {
            secondLargest = arr[i];
        }

        if (arr[i] < firstSmallest) {
            secondSmallest = firstSmallest;
            firstSmallest = arr[i];
        } else if (arr[i] < secondSmallest && arr[i] != firstSmallest) {
            secondSmallest = arr[i];
        }
    }

    return {
        secondLargest: secondLargest,
        secondSmallest: secondSmallest
    };
}

let result = findSecondLargestAndSmallest(randomNumbersArray);
console.log("Second Largest Number: ", result.secondLargest);
console.log("Second Smallest Number: ", result.secondSmallest);

// d. Sort the array and find the 2nd largest and 2nd smallest element.
randomNumbersArray.sort((a, b) => a - b);
console.log("Sorted Array: ", randomNumbersArray);

let secondSmallestSorted = randomNumbersArray[1];
let secondLargestSorted = randomNumbersArray[randomNumbersArray.length - 2];

console.log("Second Smallest Number (Sorted): ", secondSmallestSorted);
console.log("Second Largest Number (Sorted): ", secondLargestSorted);