FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PointPWebApi/PointPWebApi.csproj", "PointPWebApi/"]
RUN dotnet restore "PointPWebApi/PointPWebApi.csproj"
COPY . .
WORKDIR "/src/PointPWebApi"
RUN dotnet build "PointPWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PointPWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PointPWebApi.dll"]
