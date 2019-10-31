#! /bin/bash

mkdir -p tests

function test () {
   cd $1
   ./test.sh
   cd -
}

test 1-hello-world
test 2-hello-world
test 3-stack-overflow
test 4-heap-overflow
test 5-compiler-error
test 6-etc-passwd
test 7-runtime-error
test 8-different-correct
test 9-different-incorrect
