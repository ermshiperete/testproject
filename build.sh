#!/bin/bash
# Trigger a build for the testproject. This is run on Jenkins.
# More comment on this line
cd $FWROOT
. environ

cd bld
$FWROOT/nant/bin/nant -D:fwroot=$FWROOT testproject
