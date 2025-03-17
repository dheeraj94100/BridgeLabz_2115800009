function convertTemperature(value, conversionType) {
    let result;
    switch (conversionType) {
        case 'CtoF':
            if (value >= 0 && value <= 100) {
                result = (value * 9/5) + 32;
            } else {
                throw new Error("Input value out of range for Celsius.");
            }
            break;
        case 'FtoC':
            if (value >= 32 && value <= 212) {
                result = (value - 32) * 5/9;
            } else {
                throw new Error("Input value out of range for Fahrenheit.");
            }
            break;
        default:
            throw new Error("Invalid conversion type.");
    }
    return result;
}

// Example usage:
try {
    console.log(convertTemperature(100, 'CtoF')); // 212
    console.log(convertTemperature(32, 'FtoC'));  // 0
} catch (error) {
    console.error(error.message);
}