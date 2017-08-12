FROM microsoft/dotnet
WORKDIR /mainserviceapp
COPY . .
RUN dotnet restore && dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/mainservice.dll"]