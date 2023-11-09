# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
The variable would show up as null or in other words the Non-exiting in the program.
2. Describe the three A(s) of a test:  
A - Arrange  This is the first A. We use Arrange to lay out the preparation of what we expect our test to such as creating a new variable. Also could be the 1st step of a <= 2 step program. 

A - Act  This is the second A. The Act is the portoin of our test that we plan the determine the outcome of. Also could be any thats not the 1st step of a <= 2 step program and may even be contained in the Assert under the proper circumstances.

A - Assert  This is the final A. Assert is the line of code we use to output our test to the main Console/Program. The Assert will always be at the bottom of each test code block.

3. What is the difference between `public` and `private` access modifiers?
A public access modifier Is accessable through out all class Vs a Private access modifier only allows for you to look with in the same class it is assigned.

4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  <<<<<<<<
(B) Return some information about an object  <<<<<<<<<<<
(C) Make changes to an object and return information about the object.  X
(D) None of the Above.  X

^^^^^^^^^^^^^^^^(X = NO, <<<<<<<<< = YES)^^^^^^^^^^^^^

5. How did you determine what to answer for the question above?
I looked back at my notes and I relized that between query Methods and command Methods. Query can tippaclly returns something witch directly alines with (B) and elimates (D). Commands more often then not will change something This alines with (A). My resoning for believing (C) is incorrect Because during our Refaactoring lesson we disscused the a good method SHOULD only contain ether a query method OR a command method but nevr both in 1.

## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
