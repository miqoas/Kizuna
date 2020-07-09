FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY OtterKeys/*.csproj ./OtterKeys/
RUN dotnet restore

# copy and build everything else
COPY OtterKeys/. ./OtterKeys/
RUN dotnet build
