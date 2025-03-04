pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git credentialsId: 'YOUR_GIT_CREDENTIALS_ID', url: 'YOUR_GIT_REPOSITORY_URL', branch: 'YOUR_BRANCH'
            }
        }

        stage('Testing') {
            steps {
                script {
                    if (isUnix()) {
                        sh './gradlew test' // Example for Gradle projects on Unix-like systems
                    } else {
                        bat 'gradlew.bat test' // Example for Gradle projects on Windows
                    }
                }
                // Or if using Maven
                // sh 'mvn test'
                // Or if using a specific test framework like pytest
                // sh 'pytest'
                // Add your specific test commands here
            }
            post {
                always {
                    junit '**/TEST-*.xml' // For JUnit test results
                    // If you have other types of test results (e.g., coverage), add post-build actions here.
                }
            }
        }

        stage('Building') {
            steps {
                script {
                    if (isUnix()) {
                        sh './gradlew build' // Example for Gradle projects on Unix-like systems
                    } else {
                        bat 'gradlew.bat build' // Example for Gradle projects on Windows
                    }
                }
                // Or if using Maven
                // sh 'mvn clean package'
                // Or if building docker images
                // sh 'docker build -t your-image-name:latest .'
            }
            post {
                success {
                    archiveArtifacts artifacts: 'build/libs/*.jar' // Example for Gradle JAR files
                    // Or for Maven
                    // archiveArtifacts artifacts: 'target/*.jar'
                    // Or for Docker
                    // sh 'docker push your-image-name:latest'
                }
                failure {
                    echo 'Build failed. Artifacts not archived.'
                }
            }
        }

        stage('Deploying') {
            steps {
                script {
                    if (env.BRANCH_NAME == 'main') { //Example for deploying only from main branch
                        // Add your deployment steps here. Examples:
                        // sh 'ssh user@remote-server "deploy-script.sh"'
                        // deploy to a cloud platform
                        // deploy to a container orchestrator (Kubernetes)
                        echo "Deploying to production environment"
                        //example of deploying a docker image.
                         //sh 'ssh user@remote-server "docker pull your-image-name:latest && docker stop your-container && docker rm your-container && docker run -d --name your-container your-image-name:latest"'
                    } else if (env.BRANCH_NAME == 'develop') {
                        echo "Deploying to development environment"
                        //Deploy to dev environment
                    } else {
                        echo "Skipping deployment for branch ${env.BRANCH_NAME}"
                    }
                }
            }
        }
    }
    post {
        always {
            cleanWs()
        }
    }
}