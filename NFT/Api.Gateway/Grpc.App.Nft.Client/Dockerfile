FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5008

ENV ASPNETCORE_URLS=http://+:5003

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.Gateway/Grpc.App.Nft.Client/Grpc.App.Nft.Client.csproj", "Api.Gateway/Grpc.App.Nft.Client/"]
RUN dotnet restore "Api.Gateway\Grpc.App.Nft.Client\Grpc.App.Nft.Client.csproj"
COPY . .
WORKDIR "/src/Api.Gateway/Grpc.App.Nft.Client"
RUN dotnet build "Grpc.App.Nft.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Grpc.App.Nft.Client.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Grpc.App.Nft.Client.dll"]
