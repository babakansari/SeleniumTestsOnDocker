# dotnet test bin/Debug/net5.0/SeleniumTestsOnContainers.dll --logger:junit;LogFileName=bin/Debug/netcoreapp3.1/Intelex.Automation.DataImport-results.xml  -v:n

# Run in the host
# dotnet test bin/Debug/net5.0/SeleniumTestsOnContainers.dll

# Run in the container
dotnet test SeleniumTestsOnContainers.dll 
