#CLEAN UP THE WORDS
##CHALLENGE DESCRIPTION:

You have a list of words. Letters of these words are mixed with extra symbols, so it is hard to define the beginning and end of each word. Write a program that will clean up the words from extra numbers and symbols.

##INPUT SAMPLE:

The first argument is a path to a file. Each line includes a test case with a list of words: letters are both lowercase and uppercase, and are mixed with extra symbols.

For example:


1. (--9Hello----World...--)
2. Can 0$9 ---you~
3. 13What213are;11you-123+138doing7

##OUTPUT SAMPLE:

Print the cleaned up words separated by spaces in lowercase letters.

For example:

1. hello world
2. can you
3. what are you doing

##CONSTRAINTS:

* Print the words separated by spaces in lowercase letters.
* The length of a test case together with extra symbols can be in a range from 10 to 100 symbols.
* The number of test cases is 40.
