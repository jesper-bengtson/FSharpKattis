#! /bin/bash

mkdir -p tests

function generate_test () {
   mkdir -p tests/$1
   cp $1/*.fs tests/$1/.
   cp $1/test.sh tests/$1/.
   cp $1/in tests/$1/.
   cp $1/correct tests/$1/.
}

generate_test 1-hello-world
generate_test 2-hello-world
generate_test 3-stack-overflow
generate_test 4-heap-overflow
generate_test 5-compiler-error
generate_test 6-etc-passwd
generate_test 7-runtime-error
generate_test 8-different-correct
generate_test 9-different-incorrect



