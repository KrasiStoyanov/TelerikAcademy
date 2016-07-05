function solve (args) {
	var input = +args[0],
		count = 0,
		i,
		j,
		k;

	for (i = 0; i <= input / 10; i += 1) {
    for (j = 0; j <= input / 4; j += 1) {
	 		for (k = 0; k <= input / 3; k += 1) {
				if ((i * 10 + j * 4 + k * 3) === input) {
					count += 1;
				}
			}
		}
	}

	return count;
}

var tests = [['7'], ['10'], ['40']];

tests.forEach(function (test) {
	console.log(solve(test));
});