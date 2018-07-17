FROM microsoft/aspnetcore:2.0 AS base
COPY ./published /app
WORKDIR /app
ENTRYPOINT ["dotnet", "TurtleAttack.dll"]
EXPOSE 80

#FROM microsoft/aspnetcore:2.0 AS base
#WORKDIR /app
#EXPOSE 2742
#
#FROM microsoft/aspnetcore-build:2.0 AS build
#WORKDIR /src
#COPY ValuenetHub.sln ./
#COPY ValuenetHub/ValuenetHub.csproj ValuenetHub/
#RUN dotnet restore -nowarn:msb3202,nu1503
#COPY . .
#WORKDIR /src/ValuenetHub
#RUN dotnet build -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#EXPOSE 2742
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "ValuenetHub.dll"]
#