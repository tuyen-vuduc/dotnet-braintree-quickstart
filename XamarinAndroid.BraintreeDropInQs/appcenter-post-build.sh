wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x ./dotnet-install.sh
./dotnet-install.sh --channel 7.0

dotnet --list-sdks

echo "Install .NET Android workdload"
dotnet workload install android

echo "Build project"
dotnet build ../DotNetAndroid.BraintreeDropInQs/DotNetAndroid.BraintreeDropInQs.csproj -c Release -v normal