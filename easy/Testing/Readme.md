#TESTING
##CHALLENGE DESCRIPTION:

In many teams, there is a person who tests a project, finds bugs and errors, and prioritizes them.
Now, you have the unique opportunity to try yourself as a tester and test a product. Here, you have two strings - the first one is provided by developers, and the second one is mentioned in design. You have to find and count the number of bugs, and also prioritize them for fixing using the following statuses: 'Low', 'Medium', 'High', 'Critical' or 'Done'.

##INPUT SAMPLE:
The first argument is a path to a file. Each line includes a test case with two strings separated by a pipeline '|'. The first string is the one the developers provided to you for testing, and the second one is from design.

1. Heelo Codevval | Hello Codeeval
2. hELLO cODEEVAL | Hello Codeeval
3. Hello Codeeval | Hello Codeeval

##OUTPUT SAMPLE:
Write a program that counts the number of bugs and prioritizes them for fixing using the following statuses: 

* 'Low' - 2 or fewer bugs; 
* 'Medium' - 4 or fewer bugs; 
* 'High' - 6 or fewer bugs;
* 'Critical' - more than 6 bugs;
* 'Done' - all is done; 

1. Low
2. Critical
3. Done

##CONSTRAINTS:

Strings are of the same length from 5 to 40 characters.
Upper and lower case matters.
The number of test cases is 40.
