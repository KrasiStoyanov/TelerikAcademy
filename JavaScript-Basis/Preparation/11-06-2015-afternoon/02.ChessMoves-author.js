function solve(args) {
    var input = args,
        rows = +input[0],
        cols = +input[1],
        tests = +input[rows + 2],
        i,
        move;

    var chessboard = args.slice(2, 2 + rows);
    var moves = args.slice(3 + rows);

    function parseMove(move) {
        var cells = move.split(' ');

        return {
            from: {
                r: rows - (+cells[0][1]),
                c: cells[0].charCodeAt(0) - 97
            },
            to: {
                r: rows - (+cells[1][1]),
                c: cells[1].charCodeAt(0) - 97
            }
        };
    }

    function canMoveRook(from, to) {
    	if (from.c !== to.c && from.r !== to.r) {
    		return false;
    	}

    	if ((from.c === to.c) && (from.r === to.r)) {
    		return false;
    	}

    	var deltaR = from.r > to.r ? -1 : 1,
    		deltaC = from.c > to.c ? -1 : 1;
    	if (from.r === to.r) {
    		deltaR = 0;
    	} else {
    		deltaC = 0;
    	}

    	while((from.r !== to.r) || (from.c !== to.c)) {
    		from.r += deltaR;
    		from.c += deltaC;
    		if (chessboard[from.r][from.c] !== '-') {
    			return false;
    		}
    	}

    	return true;
    }

    function canMoveBishop(from, to) {
    	if (Math.abs(from.r - to.r) !== Math.abs(from.c - to.c)) {
    		return false;
    	}

    	if ((from.c === to.c) && (from.r === to.r)) {
    		return false;
    	}

    	var deltaR = from.r > to.r ? -1 : 1,
    		deltaC = from.c > to.c ? -1 : 1;
		while((from.r !== to.r) || (from.c !== to.c)) {
    		from.r += deltaR;
    		from.c += deltaC;
    		if (chessboard[from.r][from.c] !== '-') {
    			return false;
    		}
    	}

    	return true;
    }

    function canMoveQueen(from, to) {
    	return canMoveBishop(from, to) || canMoveRook(from, to);
    }

    for(var m of moves) {
    	var move = parseMove(m);

    	var piece = chessboard[move.from.r][move.from.c];
    	if (piece === 'R') {
    		var canMove = canMoveRook(move.from, move.to);

    		console.log(canMove ? 'yes' : 'no');
    	} else if (piece === 'B') {
    		var canMove = canMoveBishop(move.from, move.to);

    		console.log(canMove ? 'yes' : 'no');
    	} else if (piece === 'Q') {
    		var canMove = canMoveQueen(move.from, move.to);

    		console.log(canMove ? 'yes' : 'no');
    	} else {
    		console.log('no');
    	}
    }
}

var tests = [
    [
        '3',
        '4',
        '--R-',
        'B--B',
        'Q--Q',
        '12',
        'd1 b3',
        'a1 a3',
        'c3 b2',
        'a1 c1',
        'a1 b2',
        'a1 c3',
        'a2 b3',
        'd2 c1',
        'b1 b2',
        'c3 b1',
        'a2 a3',
        'd1 d3'
    ],
    [
        '5',
        '5',
        'Q---Q',
        '-----',
        '-B---',
        '--R--',
        'Q---Q',
        '10',
        'a1 a1',
        'a1 d4',
        'e1 b4',
        'a5 d2',
        'e5 b2',
        'b3 d5',
        'b3 a2',
        'b3 d1',
        'b3 a4',
        'c2 c5'
    ]
];

tests.forEach(function(test) {
    solve(test);
});
