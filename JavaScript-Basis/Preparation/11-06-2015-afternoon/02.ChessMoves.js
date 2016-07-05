function solve(args) {
    // CONSTANTS
    var EMPTY_CELL_KEY = '-',
        ROOK_KEY = 'R',
        BISIHOP_KEY = 'B',
        QUEEN_KEY = 'Q';

    var input = args,
        rows = +input[0],
        cols = +input[1],
        tests = +input[rows + 2],
        index = 0,
        chessboard = [],
        chessboardChars = [],
        counter = rows,
        letter = 'a',
        move,
        from,
        to,
        row,
        col,
        coordinatesStart = [],
        coordinatesEnd = [];

    for (row = 0; row < rows; row += 1) {
        var newChessArr = [],
            newCharsArr = [];
        for (col = 0; col < cols; col += 1) {
            newChessArr.push(input[row + 2][col]);
            newCharsArr.push(letter + counter);

            letter = nextChar(letter);
        }

        chessboard.push(newChessArr);
        chessboardChars.push(newCharsArr);

        counter -= 1;
        letter = 'a';
    }

    for (; index < tests; index += 1) {
        var passTest = false;
        move = input[rows + 3 + index].split(' ');
        from = move[0];
        to = move[1];

        passTest = canMove(from, to);

        if (passTest) {
            // movePawn(from, to);
            console.log('yes');
        } else {
            console.log('no');
        }
    }

    function nextChar (c) {
        return String.fromCharCode(c.charCodeAt(0) + 1);
    }

    function canMove (from, to) {
        if (from === to) {
            return false;
        } else {
            for (var row = 0; row < rows; row += 1) {
                for (var col = 0; col < cols; col += 1) {
                    if (chessboardChars[row][col] === from) {
                        coordinatesStart[0] = row;
                        coordinatesStart[1] = col;
                    }

                    if (chessboardChars[row][col] === to) {
                        coordinatesEnd[0] = row;
                        coordinatesEnd[1] = col;
                    }
                }
            }

            if (chessboard[coordinatesEnd[0]][coordinatesEnd[1]] === EMPTY_CELL_KEY) {
                switch (chessboard[coordinatesStart[0]][coordinatesStart[1]]) {
                    case EMPTY_CELL_KEY:
                        return false;

                        break;
                    case ROOK_KEY:
                        if (coordinatesStart[0] === coordinatesEnd[0] || coordinatesStart[1] === coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                            return true;
                        }

                        break;
                    case BISIHOP_KEY:
                        if (+from[1] > +to[1]) {
                            if (coordinatesStart[1] > coordinatesEnd[1]) {
                                if (+from[1] - +to[1] === coordinatesStart[1] - coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            } else {
                                if (+from[1] - +to[1] === coordinatesEnd[1] - coordinatesStart[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            }
                        } else {
                            if (coordinatesStart[1] > coordinatesEnd[1]) {
                                if (+to[1] - +from[1] === coordinatesStart[1] - coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            } else {
                                if (+to[1] - +from[1] === coordinatesEnd[1] - coordinatesStart[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            }
                        }

                        break;
                    case QUEEN_KEY:
                        if (coordinatesStart[0] === coordinatesEnd[0] || coordinatesStart[1] === coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                            return true;
                        } else if (+from[1] > +to[1]) {
                            if (coordinatesStart[1] > coordinatesEnd[1]) {
                                if (+from[1] - +to[1] === coordinatesStart[1] - coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            } else {
                                if (+from[1] - +to[1] === coordinatesEnd[1] - coordinatesStart[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            }
                        } else {
                            if (coordinatesStart[1] > coordinatesEnd[1]) {
                                if (+to[1] - +from[1] === coordinatesStart[1] - coordinatesEnd[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            } else {
                                if (+to[1] - +from[1] === coordinatesEnd[1] - coordinatesStart[1] && noFigureInWay(from, to) === true) {
                                    return true;
                                }
                            }
                        }

                        break;
                }
            }
        }

        return false;
    }

    function noFigureInWay (from, to) {
        var pawn = chessboard[coordinatesStart[0]][coordinatesStart[1]],
            horizontalDirection = 'right',
            verticalDirection = 'down';

        if (coordinatesStart[0] > coordinatesEnd[0]) {
            verticalDirection = 'up';
        } else if (coordinatesStart[0] === coordinatesEnd[0]) {
            verticalDirection = 'same';
        }

        if (coordinatesStart[1] > coordinatesEnd[1]) {
            horizontalDirection = 'left';
        } else if (coordinatesStart[1] === coordinatesEnd[1]) {
            horizontalDirection = 'same';
        }

        debugger;

        switch (pawn) {
            case ROOK_KEY:
                if (verticalDirection === 'up' && horizontalDirection === 'same') {
                    for (var row = coordinatesStart[0]; row < coordinatesEnd[0]; row += 1) {
                        if (chessboard[row][coordinatesEnd[1]] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'same') {
                    for (var row = coordinatesEnd[0]; row < coordinatesStart[0]; row += 1) {
                        if (chessboard[row][coordinatesEnd[1]] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                if (horizontalDirection === 'right' && verticalDirection === 'same') {
                    for (var col = coordinatesStart[1]; col < coordinatesEnd[1]; col += 1) {
                        if (chessboard[coordinatesStart[0]][col] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (horizontalDirection === 'left' && verticalDirection === 'same') {
                    for (var col = coordinatesEnd[1]; col < coordinatesStart[1]; col += 1) {
                        if (chessboard[coordinatesStart[0]][col] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                break;
            case BISIHOP_KEY:
                var counter = coordinatesStart[1];

                if (verticalDirection === 'up' && horizontalDirection === 'right') {
                    for (var row = coordinatesStart[0] - 1; row >= coordinatesEnd[0]; row -= 1) {
                        counter += 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'up' && horizontalDirection === 'left') {
                    for (var row = coordinatesStart[0] - 1; row >= coordinatesEnd[0]; row -= 1) {
                        counter -= 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'right') {
                    for (var row = coordinatesStart[0] + 1; row < coordinatesEnd[0]; row += 1) {
                        counter += 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'left') {
                    for (var row = coordinatesStart[0] + 1; row < coordinatesEnd[0]; row += 1) {
                        counter -= 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                break;
            case QUEEN_KEY:
                var counter = coordinatesStart[1];

                if (verticalDirection === 'up' && horizontalDirection === 'same') {
                    for (var row = coordinatesStart[0]; row < coordinatesEnd[0]; row += 1) {
                        if (chessboard[row][coordinatesEnd[1]] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'same') {
                    for (var row = coordinatesEnd[0]; row < coordinatesStart[0]; row += 1) {
                        if (chessboard[row][coordinatesEnd[1]] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                if (horizontalDirection === 'right' && verticalDirection === 'same') {
                    for (var col = coordinatesStart[1]; col < coordinatesEnd[1]; col += 1) {
                        if (chessboard[coordinatesStart[0]][col] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (horizontalDirection === 'left' && verticalDirection === 'same') {
                    for (var col = coordinatesEnd[1]; col < coordinatesStart[1]; col += 1) {
                        if (chessboard[coordinatesStart[0]][col] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                if (verticalDirection === 'up' && horizontalDirection === 'right') {
                    for (var row = coordinatesStart[0] - 1; row >= coordinatesEnd[0]; row -= 1) {
                        counter += 1;
                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'up' && horizontalDirection === 'left') {
                    for (var row = coordinatesStart[0] - 1; row >= coordinatesEnd[0]; row -= 1) {
                        counter -= 1;
                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'right') {
                    for (var row = coordinatesStart[0] + 1; row < coordinatesEnd[0]; row += 1) {
                        counter += 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                } else if (verticalDirection === 'down' && horizontalDirection === 'left') {
                    for (var row = coordinatesStart[0] + 1; row < coordinatesEnd[0]; row += 1) {
                        counter -= 1;

                        if (chessboard[row][counter] !== EMPTY_CELL_KEY) {
                            return false;
                        }
                    }
                }

                break;
        }

        return true;
    }
}

var tests = [
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
