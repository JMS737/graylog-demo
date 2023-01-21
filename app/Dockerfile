# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /src
COPY src/*.sln .
COPY src/Client/*.csproj ./Client/
COPY src/Server/*.csproj ./Server/
COPY src/Shared/*.csproj ./Shared/
RUN dotnet restore
COPY src .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
RUN apt-get update && apt-get install -y curl
WORKDIR /app
COPY --from=build-env /publish .
EXPOSE 80
HEALTHCHECK --interval=30s --timeout=30s --start-period=5s --retries=3 CMD curl -f http://localhost/healthcheck || exit 1
ENTRYPOINT ["dotnet", "webapp.Server.dll"]