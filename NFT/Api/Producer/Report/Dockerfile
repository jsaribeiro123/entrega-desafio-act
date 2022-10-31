FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5225

ENV ASPNETCORE_URLS=http://+:5225

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api/Producer/Report/Api.Producer.Report.csproj", "Api/Producer/Report/"]
RUN dotnet restore "Api\Producer\Report\Api.Producer.Report.csproj"
COPY . .
WORKDIR "/src/Api/Producer/Report"
RUN dotnet build "Api.Producer.Report.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Producer.Report.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Producer.Report.dll"]
