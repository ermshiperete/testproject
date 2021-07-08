#!/bin/bash
# Trigger a build for the testproject. This is run on Jenkins.
# More comments on this line
cd $FWROOT
. environ

cd bld
$FWROOT/nant/bin/nant -D:fwroot=$FWROOT testproject

# Add comment

# This is a long comment that will go so long that it will be over 130 characters so that we see how much GitHub will display in one line.