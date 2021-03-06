#KNIGHT MOVES
##CHALLENGE DESCRIPTION:

In chess, the knight moves to any of the closest squares that are not on the same rank, file, or diagonal. Thus the move is in the “L” form: two squares vertically and one square horizontally, or two squares horizontally and one square vertically:


Your task is to find all possible positions for the next move of the knight on the empty chessboard.

##INPUT SAMPLE:

The first argument is a filename that contains positions of the knight on the chessboard in the CN form, where:

* C is a letter from “a” to “h” and denotes a column.
* N is a number from 1 to 8 and denotes a row.
* Each position is indicated in a new line.

For example:

    g2
    a1
    d6
    e5
    b1

##OUTPUT SAMPLE:

Print to stdout all possible positions for the next move of the knight ordered alphabetically.

For example:

    e1 e3 f4 h4
    b3 c2
    b5 b7 c4 c8 e4 e8 f5 f7
    c4 c6 d3 d7 f3 f7 g4 g6
    a3 c3 d2

##CONSTRAINTS:

* The number of test cases is 40.
