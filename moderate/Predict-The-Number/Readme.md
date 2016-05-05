#PREDICT THE NUMBER
##CHALLENGE DESCRIPTION:

The sequence "011212201220200112 ..." is constructed as follows:
first goes 0, and then the following action is repeated: existing part is added to the right, but 0 is replaced with 1, 1 with 2, and 2 with 0.

    0 -> 01 -> 0112 -> 01121220 -> ...

Write an algorithm that determines what number is on the N-th position in the sequence.

##INPUT SAMPLE:

Your program should accept a path to a filename as its first argument. Each line in the file contains a number N.

For example:


    0
    5
    101
    25684

##OUTPUT SAMPLE:

Print out a number that is on the N-th position in the sequence.


    0
    2
    1
    0

##CONSTRAINTS:

* 0 <= N <= 3000000000.
