FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DockerCalculator/DockerCalculator.csproj", "DockerCalculator/"]
RUN dotnet restore "DockerCalculator/DockerCalculator.csproj"
COPY . .
WORKDIR "/src/DockerCalculator"
RUN dotnet build "DockerCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerCalculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerCalculator.dll"]
