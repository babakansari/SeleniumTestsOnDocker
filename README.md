This fork is made from the code and explanation from the following link:
https://medium.com/@HoussemDellai/run-selenium-ui-tests-in-docker-containers-f41ae2796b8d

Run the following if nuget exception happened

dotnet restore


docker run -d -p 4444:4444 -p 5900:5900 -v /dev/shm:/dev/shm selenium/standalone-chrome-debug:3.141.59-yttrium


dotnet test -s .runsettings -- RunConfiguration.remoteWebDriverUrl="http://selenium-hub:4444/wd/hub"


Notes
- Use NUnit .NET liberary for the unit tests
- Image could be created by the `Build Docker Image` selection in the `Dockerfile` context menu in Visual Studio .NET version 16.05 or higher
