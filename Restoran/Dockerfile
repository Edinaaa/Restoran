#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Restoran/Restoran.csproj", "Restoran/"]
COPY ["Model/Restoran.Model.csproj", "Model/"]
RUN dotnet restore "Restoran/Restoran.csproj"
COPY . .
WORKDIR "/src/Restoran"
RUN dotnet build "Restoran.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Restoran.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Restoran.dll"]
