FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["TCM.Web.API.Core/TCM.Web.API.Core.csproj", "TCM.Web.API.Core/"]
RUN dotnet restore "TCM.Web.API.Core/TCM.Web.API.Core.csproj"
COPY . .
WORKDIR "/src/TCM.Web.API.Core"
RUN dotnet build "TCM.Web.API.Core.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TCM.Web.API.Core.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TCM.Web.API.Core.dll"]