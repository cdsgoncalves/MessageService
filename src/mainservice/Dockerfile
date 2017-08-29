FROM microsoft/dotnet
WORKDIR /mainserviceapp
COPY . .
RUN dotnet restore && dotnet publish -c Release -o out
EXPOSE 80:80
ENTRYPOINT ["dotnet", "out/mainservice.dll"]