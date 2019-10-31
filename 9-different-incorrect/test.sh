#! /bin/bash
# Execute this script from each of the subdirectories.

set -e
mkdir -p bin
fsharpc Program.fs --optimize+ -o bin/Program.exe

mono ./bin/Program.exe < in > out && diff correct out
