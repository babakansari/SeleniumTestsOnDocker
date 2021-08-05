#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Selenium docker image to have chrome and chrome-driver installed
FROM selenium/standalone-chrome-debug:3.141.59-yttrium AS base
WORKDIR /app

# Install dotnet 5.0
RUN wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN sudo dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb

RUN sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0

#FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
#WORKDIR /src
#COPY ["SeleniumTestsOnContainers/SeleniumTestsOnContainers.csproj", "SeleniumTestsOnContainers/"]
#RUN dotnet restore "SeleniumTestsOnContainers/SeleniumTestsOnContainers.csproj"
#COPY . .
#WORKDIR "/src/SeleniumTestsOnContainers"
#RUN dotnet build "SeleniumTestsOnContainers.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "SeleniumTestsOnContainers.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "SeleniumTestsOnContainers.dll"]