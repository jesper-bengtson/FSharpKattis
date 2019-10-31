#! /bin/bash
# Execute this script from each of the subdirectories.

set -e
mkdir -p bin
fsharpc Program.fs --optimize+ -o bin/Program.exe

export MONO_GC_PARAMS='max-heap-size=2G'

mono ./bin/Program.exe < in > out && diff correct out
echo "Returned: $?"
