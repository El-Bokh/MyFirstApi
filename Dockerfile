FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["MyFirstApi.csproj", "./"]
RUN dotnet restore "MyFirstApi.csproj"

COPY . .
WORKDIR "/src"
RUN dotnet build "MyFirstApi.csproj" -c Release -o /app/build
RUN dotnet publish "MyFirstApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MyFirstApi.dll"]
