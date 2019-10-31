# FSharpKattis

This development contains ten tests for Kattis in FSharp as well as a tokenizer for IO. The tests are the following:

1. ```1-hello-world``` A solution to the *hello* problem.
2. ```2-hello-world``` A 2-file solution to the *hello* problem.
3. ```3-stack-overflow``` A program that overflows the stack by summing the elements of a list without using tail recursion.
4. ```4-heap-overflow``` A program that overflows the heap by generating an infinite list on the heap. Note that it is important to fix the heap size in mono before running this program or it will eat an uncomfortable amount of memory.
5. ```5-compiler-error``` A program that will not compile
6. ```6-etc-passwd``` A program that prints /etc/passwd
7. ```7-runtime error``` A program that tries to divide by zero.
8. ```8-different-correct``` A correct solution to the *different* problem.
9. ```9-different-incorrect``` An incorrect solution to the *different* problem.
10. ```10-guess``` A solution to the *guess* problem

To run the tests, run ```generate_tests.sh``` from the root directory. This will generate a ```tests``` folder containing all problems listed above. From that folder you can either run the file ```test.sh``` to run all tests (except ```10-guess```) or enter the individual folders and run the tests from there.