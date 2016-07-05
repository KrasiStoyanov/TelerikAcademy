function solve(args) {
    var input = args,
        n = +args[0].split(' ')[0],
        k = +args[0].split(' ')[1],
        sequence = args[1].split(' ').map(Number),
        index = 0,
        jndex = 0,
        length = n,
        sum = 0;
    for (; index < k; index += 1) {
    	var newSequence = [];
        for (jndex = 0; jndex < length; jndex += 1) {
            debugger;
            var currentNumber = sequence[jndex],
                leftNeighbour,
                rightNeighbour;

            if (jndex + 1 === length) {
                rightNeighbour = sequence[0];
                leftNeighbour = sequence[jndex - 1];
            } else if (jndex - 1 === -1) {
                rightNeighbour = sequence[jndex + 1];
                leftNeighbour = sequence[length - 1];
            } else {
                rightNeighbour = sequence[jndex + 1];
                leftNeighbour = sequence[jndex - 1];
            }

            if (currentNumber === 0) {
                if (rightNeighbour < leftNeighbour) {
                    newSequence[jndex] = Math.abs(leftNeighbour - rightNeighbour);
                } else {
                    newSequence[jndex] = Math.abs(rightNeighbour - leftNeighbour);
                }
            } else if (currentNumber === 1) {
                newSequence[jndex] = leftNeighbour + rightNeighbour;
            } else if (currentNumber % 2 === 0) {
                if (rightNeighbour > leftNeighbour) {
                    newSequence[jndex] = rightNeighbour;
                } else {
                    newSequence[jndex] = leftNeighbour;
                }
            } else if (currentNumber % 2 !== 0) {
                if (rightNeighbour < leftNeighbour) {
                    newSequence[jndex] = rightNeighbour;
                } else {
                    newSequence[jndex] = leftNeighbour;
                }
            }
        }

        sequence = newSequence;
    }

    sequence.forEach(function(number) {
        sum += number;
    });

    console.log(sum);
}

var tests = [
    [
        '5 1',
        '9 0 2 4 1'
    ],
    [
        '10 3',
        '1 9 1 9 1 9 1 9 1 9'
    ],
    [
        '10 10',
        '0 1 2 3 4 5 6 7 8 9'
    ]
];

tests.forEach(function(test) {
    solve(test);
});
