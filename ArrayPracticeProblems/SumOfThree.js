function findTriplets(arr) {
    let n = arr.length;
    let found = false;
    arr.sort((a, b) => a - b);

    for (let i = 0; i < n - 2; i++) {
        if (i > 0 && arr[i] === arr[i - 1]) continue;

        let left = i + 1;
        let right = n - 1;

        while (left < right) {
            let sum = arr[i] + arr[left] + arr[right];

            if (sum === 0) {
                console.log(`Triplet: ${arr[i]}, ${arr[left]}, ${arr[right]}`);
                found = true;

                while (left < right && arr[left] === arr[left + 1]) left++;
                while (left < right && arr[right] === arr[right - 1]) right--;

                left++;
                right--;
            } else if (sum < 0) {
                left++;
            } else {
                right--;
            }
        }
    }

    if (!found) {
        console.log("No triplets found");
    }
}

// Example usage:
let arr = [0, -1, 2, -3, 1];
findTriplets(arr);