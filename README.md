This fork is made from the code and explanation from the following link:
https://medium.com/@HoussemDellai/run-selenium-ui-tests-in-docker-containers-f41ae2796b8d

The differences:
- Use NUnit .NET liberary to run the unit tests
- Image could be created by the `Build Docker Image` selection in the `Dockerfile` context menu in Visual Studio .NET version 16.05 or higher
- The docker image could be executed using the `SeleniumTestsOnContainers> .\run.ps1` powershell script
