# BASED OFF DOT NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# GENERIC CONTAINER SETUP
EXPOSE 80
EXPOSE 443

# COPY REQUIRED SOURCE CODE
COPY ./nuget.config ./nuget.config
COPY ./src/ExampleWebApi.WebApi ./src/ExampleWebApi.WebApi

# RESTORE PACKAGES
RUN dotnet restore ./src/ExampleWebApi.WebApi

# BUILD SOLUTION IN PUBLISH MODE
RUN dotnet publish --no-restore -c Release -o ./out ./src/ExampleWebApi.WebApi

# BASED OFF ASP NET RUNTIME
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# COPY BUILD ARTIFACTS FROM PREVIOUS IMAGE
COPY --from=build-env ./out ./app

# RUN THE APP
WORKDIR /app
ENTRYPOINT ["dotnet", "ExampleWebApi.WebApi.dll"]