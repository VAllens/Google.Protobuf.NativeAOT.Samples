dotnet restore --runtime linux-x64
dotnet publish --configuration Release --runtime linux-x64 -o dist/linux-x64 --no-restore