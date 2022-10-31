FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5280

ENV ASPNETCORE_URLS=http://+:5280

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["App.Web/APIConsume/APIConsume.csproj", "App.Web/APIConsume/"]
RUN dotnet restore "App.Web\APIConsume\APIConsume.csproj"
COPY . .
WORKDIR "/src/App.Web/APIConsume"
RUN dotnet build "APIConsume.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APIConsume.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIConsume.dll"]
