pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/Roberto-Sacramento/SpecFlow_DMQAutomation.git'
            }
        }
        stage('Build') {
            steps {
                script {
                    /* groovylint-disable-next-line NestedBlockDepth */
                    if (isUnix()){
                        sh './build.sh' // or your build command
                    /* groovylint-disable-next-line NestedBlockDepth */
                    } else {
                        bat 'build.bat' // or your build command
                    }
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    if (isUnix()) {
                        sh './run-tests.sh' // or your test command
                    } else {
                        bat 'run-tests.bat' // or your test command
                    }
                }
            }
        }
    }   
}