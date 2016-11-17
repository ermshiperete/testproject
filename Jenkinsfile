#!groovy

timestamps {
    node('mono') {
        milestone label: 'Checkout and build'

        stage('Checkout') {
            checkout scm
        }

        stage('Build') {
            withEnv(["FWROOT=${WORKSPACE}"]) {
				sh("env")
                sh("./build.sh")
            }
        }

        stage('Test') {
            withEnv(["FWROOT=${WORKSPACE}"]) {
                sh("""#!/bin/bash -e
                    . environ
                    mono --debug nunit/nunit-console.exe Output_/Debug/*Tests.dll""")
            }
        }

		if (JOB_BASE_NAME =~ "PR-") {
			echo "We're a PR"
		}
    }
}
