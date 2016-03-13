#SPLIT THE NUMBER
##CHALLENGE DESCRIPTION:

You are given a number N and a pattern. The pattern consists of lowercase latin letters and one operation "+" or "-". The challenge is to split the number and evaluate it according to this pattern e.g. 
1232 ab+cd -> a:1, b:2, c:3, d:2 -> 12+32 -> 44

##INPUT SAMPLE:
Your program should accept as its first argument a path to a filename. Each line of the file is a test case, containing the number and the pattern separated by a single whitespace. E.g.

1. 3413289830 a-bcdefghij
2. 776 a+bc
3. 12345 a+bcde
4. 1232 ab+cd
5. 90602 a+bcde

##OUTPUT SAMPLE:
For each test case print out the result of pattern evaluation. E.g.

1. -413289827
2. 83
3. 2346
4. 44
5. 611

##Constraints: 
* N is in range [100, 1000000000]

