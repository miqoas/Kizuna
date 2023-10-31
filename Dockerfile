FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY OtterKeys/*.csproj ./OtterKeys/
RUN dotnet restore

# copy and build everything else
COPY OtterKeys/. ./OtterKeys/
RUN dotnet build
