FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /home/workmonitor

COPY . ./

RUN dotnet restore
RUN dotnet publish -o out

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /home/workmonitor
COPY --from=build /home/workmonitor/out ./
ENTRYPOINT ["dotnet", "workmonitorAPI.dll"]