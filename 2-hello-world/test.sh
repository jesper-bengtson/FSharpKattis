#! /bin/bash
# Execute this script from each of the subdirectories.

set -e
mkdir -p bin
fsharpc HelloWorld2.fs HelloWorld.fs Program.fs --optimize+ -o bin/Program.exe

mono ./bin/Program.exe < in > out && diff correct out
