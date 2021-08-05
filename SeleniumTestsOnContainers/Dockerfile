#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM selenium/standalone-chrome-debug:3.141.59-yttrium AS base
WORKDIR /app

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