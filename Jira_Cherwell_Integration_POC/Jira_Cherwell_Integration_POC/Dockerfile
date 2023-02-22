#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Jira_Cherwell_Integration_POC.csproj", "."]
RUN dotnet restore "./Jira_Cherwell_Integration_POC.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Jira_Cherwell_Integration_POC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jira_Cherwell_Integration_POC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jira_Cherwell_Integration_POC.dll"]