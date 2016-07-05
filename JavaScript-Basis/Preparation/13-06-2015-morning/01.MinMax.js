function solve (args) {
	var input = args,
		n = +input[0],
		k = +input[1],
		numbers = input[2].split(' ').map(Number),
		index = 0,
		jndex = 0,
		length = numbers.length,
		result = [],
		min = Number.MAX_VALUE,
		max = Number.MIN_VALUE;

	for (index = 0; index < length - k + 1; index += 1) {
		debugger;
		for (jndex = index; jndex < index + k; jndex += 1) {
			if (numbers[jndex] > max) {
				max = numbers[jndex];
			}

			if (numbers[jndex] < min) {
				min = numbers[jndex];
			}
		}

		result.push(min + max);
		min = Number.MAX_VALUE;
		max = Number.MIN_VALUE;
	}

	console.log(result.join(','));
}

var tests = [
	[
		'4',
		'1',
		'1 3 1 8'
	],
	[
		'5',
		'3',
		'7 7 8 9 10'
	],
	[
		'8',
		'4',
		'1 8 8 4 2 9 8 11'
	]
];

tests.forEach(function (test) {
	solve(test);
});