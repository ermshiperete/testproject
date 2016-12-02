#!groovy

timestamps {
    node('linux') {
        milestone label: 'Checkout and build'

        stage('Checkout') {
        checkout([
            $class: 'GitSCM',
            branches: scm.branches,
            doGenerateSubmoduleConfigurations: scm.doGenerateSubmoduleConfigurations,
            extensions: scm.extensions,
            userRemoteConfigs: [[url: 'https://github.com/ermshiperete/testproject'], scm.userRemoteConfigs ])
        }

        stage('Build') {
            withEnv(["FWROOT=${WORKSPACE}"]) {
                sh("./build.sh")
            }
        }
    }
}
