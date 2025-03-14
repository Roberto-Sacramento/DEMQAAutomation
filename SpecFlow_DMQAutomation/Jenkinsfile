pipeline 
{
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building...'
                // Adicione os comandos para construir seu projeto aqui
            }
        }

        stage('Test') {
            steps {
                echo 'Testing...'
                // Adicione os comandos para executar seus testes aqui
            }
        }

        stage('Deploy') {
            steps {
                echo 'Deploying...'
                // Adicione os comandos para implantar seu projeto aqui
            }
        }
    }

    post {
        always {
            echo 'This will always run'
        }
        success {
            echo 'This will run only if successful'
        }
        failure {
            echo 'This will run only if failed'
        }
     }
}  