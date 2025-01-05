#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/MiddlewareProceda.WebApi/MiddlewareProceda.WebApi.csproj", "src/MiddlewareProceda.WebApi/"]
COPY ["src/MiddlewareProceda.IoC/MiddlewareProceda.IoC.csproj", "src/MiddlewareProceda.IoC/"]
COPY ["src/MiddlewareProceda.Domain/MiddlewareProceda.Domain.csproj", "src/MiddlewareProceda.Domain/"]
COPY ["src/MiddlewareProceda.Common/MiddlewareProceda.Common.csproj", "src/MiddlewareProceda.Common/"]
COPY ["src/MiddlewareProceda.Application/MiddlewareProceda.Application.csproj", "src/MiddlewareProceda.Application/"]
COPY ["src/MiddlewareProceda.ORM/MiddlewareProceda.ORM.csproj", "src/MiddlewareProceda.ORM/"]
RUN dotnet restore "./src/MiddlewareProceda.WebApi/MiddlewareProceda.WebApi.csproj"
COPY . .
WORKDIR "/src/src/MiddlewareProceda.WebApi"
RUN dotnet build "./MiddlewareProceda.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MiddlewareProceda.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiddlewareProceda.WebApi.dll"]