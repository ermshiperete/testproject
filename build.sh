#!/bin/bash
cd $FWROOT
. environ
cd bld
$FWROOT/nant/bin/nant -D:fwroot=$FWROOT testproject

