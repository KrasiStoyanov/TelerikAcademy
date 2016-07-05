function solve (args) {
	// CONSTANTS
	var EMPTY_CELL_KEY = '-',
		KING_KEY = 'K',
		QUEEN_KEY = 'Q';

	var input = args,
        rows = +input[0],
        cols = +input[1],
        tests = +input[rows + 2],
        knightMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]],
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

    function canMoveKing(from, to) {
        for (var k = 0; k < knightMoves.length; k += 1) {
            if (knightMoves[k][0] + from.r === to.r && knightMoves[k][1] + from.c === to.c) {
                return true;
            }
        }
    }

    for(var m of moves) {
        var move = parseMove(m);

        var piece = chessboard[move.from.r][move.from.c];
        if (piece === KING_KEY) {
            var canMove = canMoveKing(move.from, move.to);

            console.log(canMove ? 'yes' : 'no');
        } else if (piece === QUEEN_KEY) {
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
		'--K-',
		'K--K',
		'Q--Q',
		'12',
		'd1 b3',
		'a1 a3',
		'c3 b2',
		'a1 c1',
		'a1 b2',
		'a1 c3',
		'a2 c1',
		'd2 b1',
		'b1 b2',
		'c3 a3',
		'a2 a3',
		'd1 d3'
	],
	[
		'5',
		'5',
		'Q---Q',
		'-----',
		'-K---',
		'--K--',
		'Q---Q',
		'10',
		'a1 a1',
		'a1 d4',
		'e1 b4',
		'a5 d2',
		'e5 b2',
		'b3 d4',
		'b3 c1',
		'b3 d1',
		'c2 a3',
		'c2 b4'
	]
];

tests.forEach(function (test) {
	solve(test);
});