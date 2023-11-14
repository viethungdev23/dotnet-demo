
pipeline {

  agent any

  stages {

    stage('Build') {

      steps {
          dotnetBuild configuration: 'Release', project: 'dotnet-demo.sln', sdk: 'dotnetsdk'
      }

    }

    stage('Test'){

      steps {
          dotnetTest configuration: 'Release', project: 'Test/Test.csproj', sdk: 'dotnetsdk'
      }
    }

  }

}       