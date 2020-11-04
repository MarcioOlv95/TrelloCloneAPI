#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/services/TC.Identidade/TC.Identidade/TC.Identidade.csproj", "src/services/TC.Identidade/TC.Identidade/"]
RUN dotnet restore "src/services/TC.Identidade/TC.Identidade/TC.Identidade.csproj"
COPY . .
WORKDIR "/src/src/services/TC.Identidade/TC.Identidade"
RUN dotnet build "TC.Identidade.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TC.Identidade.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TC.Identidade.dll"]