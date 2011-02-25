#!/bin/bash
# Trigger a build for the testproject 
cd $FWROOT
. environ
cd bld
$FWROOT/nant/bin/nant -D:fwroot=$FWROOT testproject
