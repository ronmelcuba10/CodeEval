#DOUBLE TROUBLE
##CHALLENGE DESCRIPTION:

Historians have discovered a mysterious lost code that until this day remains undeciphered. Looks like the code dates back to the 5th century AD. Scientists were trying to decipher the code, which could reveal many details about our ancestors’ life, but they failed. Could you help them? 
According to the analysis, there can be only 2 letters in the code: A and B. All messages are transmitted in a form of two equal parts (ABAB, AAAA, BABA, and so on). 
Some messages are so mutilated that scientists need to know how many correct variants of the messages might exist to decide whether it would make sense to decipher their meaning, and how long it would take. Therefore, you need to calculate the number of possible correct variants for each message.

##INPUT SAMPLE:

The first argument is a path to a file. Each line includes a test case containing one message that includes three symbols:   

    A and B – deciphered code;   
    * - lost letter;

For example:


    ABA*
    BAA*
    A*A*

##OUTPUT SAMPLE:

Print the number of possible correct variants of each message.

For example:


    1
    0
    2

##CONSTRAINTS:

* A message may be from 2 to 70 letters long.
* All messages have an even number of letters.
* Some messages may be incorrect. In such cases, print 0.
* The number of test cases is 40.
