#/bin/bash

msbuild /t:restore src/IRLBR.sln
msbuild src/IRLBR.sln