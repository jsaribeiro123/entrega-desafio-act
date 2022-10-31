FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Wallet.NFT/Wallet.NFT.csproj", "Wallet.NFT/"]
COPY ["Wallet.DAL/Wallet.NFT.DAL.csproj", "Wallet.DAL/"]
COPY ["Wallet.Domain/Wallet.NFT.Domain.csproj", "Wallet.Domain/"]
COPY ["Wallet.Service/Wallet.NFT.Service.csproj", "Wallet.Service/"]
RUN dotnet restore "Wallet.NFT/Wallet.NFT.csproj"
COPY . .
WORKDIR "/src/Wallet.NFT"
RUN dotnet build "Wallet.NFT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Wallet.NFT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wallet.NFT.dll"]