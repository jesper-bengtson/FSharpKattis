#! /bin/bash
# Execute this script from each of the subdirectories.

set -e
mkdir -p bin
fsharpc HelloWorld2.fs HelloWorld.fs Program.fs --optimize+ -o bin/Program.exe

ulimit -t 3
ulimit -d 16000
ulimit -s 1024
ulimit -m 4096

mono ./bin/Program.exe < in > out && diff correct out
