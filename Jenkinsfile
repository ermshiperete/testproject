#!groovy

timestamps {
    node('linux') {
        milestone label: 'Checkout and build'

        stage('Checkout') {
            checkout scm
        }

        stage('Build') {
            withEnv(["FWROOT=${WORKSPACE}"]) {
                sh("./build.sh")
            }
        }
    }
}
