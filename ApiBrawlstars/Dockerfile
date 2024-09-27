#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiBrawlstars/ApiBrawlstars.csproj", "ApiBrawlstars/"]
RUN dotnet restore "ApiBrawlstars/ApiBrawlstars.csproj"
COPY . .
WORKDIR "/src/ApiBrawlstars"
RUN dotnet build "ApiBrawlstars.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiBrawlstars.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiBrawlstars.dll"]