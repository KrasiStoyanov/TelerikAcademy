var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

// arr.every - all data must pass the if statement
var every = arr.every(function (number, index) {
	return !(number % 2); // check if number is even
});

console.log(arr.toString() + " arr.every() = " + every);

// arr.some - some data may not pass the if statement
var some = arr.some(function (number, index) {
	return !(number % 2);
});

console.log(arr.toString() + " arr.some() = " + some);

// arr.filter
var filter = arr.filter(function (number, index) {
	return !(number % 2);
});

console.log(arr.toString() + " arr.filter()  = " + filter.toString());

// BONUS: isPrime
function isPrime (number) {
	var divisor,
		maxDivisor = Math.sqrt(number);
	for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
		if (!(number % divisor)) {
			return false;
		}
	}

	return number > 1;
}

var filterPrimeNumbers = arr.filter(isPrime);

console.log(filterPrimeNumbers); // [2, 3, 5, 7, 11, 13]

// arr.reduce
var reduce = arr.reduce(nextSum, 1);

function nextSum (sum, number) {
	if (!(number % 2)) {
		sum += number;
	}

	return sum;
}

console.log(reduce); // 57

// BONUS: Flatten array
var flatArr = [1, [2, 3], [4, 5, 6]];

var flattenedArray = flatArr.reduce(function (arr, item) {
	if (Array.isArray(item)) {
		arr = arr.concat(item);
	} else {
		arr.push(item);
	}

	return arr;
}, []);

console.log(flattenedArray); // [1, 2, 3, 4, 5, 6]

// arr.map
var str = '1 2 3 4 5 6 7 8 9 10';

var numbers = str.split(' ').map(Number);

console.log(numbers); // [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

// arr.forEach
var names = ['John', 'Peter', 'Marijka'];

names.forEach(function (name) {
	console.log(name);
});

// arr.find
var foundNumber = arr.find(function (number) {
	return !(number % 2);
});

console.log(foundNumber); // 2

// arr.findIndex
var findIndexOfNumber = arr.findIndex(function (number) {
	return !(number % 2);
});

console.log(findIndexOfNumber); // 1

// arr.sort
var numbers = [11, 2, 7, 3, 8, 4, 9, 5];

numbers.sort(function (x, y) {
	return x - y;
});

console.log(numbers); // [2, 3, 4, 5, 7, 8, 9, 11]

// arr.fill
var emptyArr = [],
	count = 5;
emptyArr.length = count;

emptyArr.fill('Pesho');
console.log(emptyArr);