#!/bin/bash
# Trigger a build for the testproject. This is run on Jenkins.
# More comments on this line
cd $FWROOT
. environ

cd bld
$FWROOT/nant/bin/nant -D:fwroot=$FWROOT testproject