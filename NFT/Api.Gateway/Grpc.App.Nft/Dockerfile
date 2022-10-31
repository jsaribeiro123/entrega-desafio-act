FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.Gateway/Grpc.App.Nft/Grpc.App.Nft.csproj", "Api.Gateway/Grpc.App.Nft/"]
RUN dotnet restore "Api.Gateway\Grpc.App.Nft\Grpc.App.Nft.csproj"
COPY . .
WORKDIR "/src/Api.Gateway/Grpc.App.Nft"
RUN dotnet build "Grpc.App.Nft.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Grpc.App.Nft.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Grpc.App.Nft.dll"]
