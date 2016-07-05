function solve (args) {
	var input = args[0].split(' ').map(Number),
		counter = 0,
		bestCounter = 0,
		isDecending = input[0] > input[1],
		length = input.length,
		index = 0,
		reseter = 0;

	for (index = 0; index < length - 1; index += 1) {
		var temp = isDecending;
		isDecending = input[index] > input[index + 1];

		if (temp ^ isDecending) {
			reseter += 1;
		}

		if (reseter === 2) {
			counter = 0;
			reseter = 0;
		}

		counter += 1;
		if (counter > bestCounter) {
			bestCounter = counter;
		}
	}

	console.log(bestCounter);
}

var tests = [
	[
		'5 1 7 4 8'
	],
	[
		'5 1 7 6 3 6 4 2 3 8'
	],
	[
		'10 1 2 3 4 5 4 3 2 1 10'
	]
];

tests.forEach(function (test) {
	solve(test);
});