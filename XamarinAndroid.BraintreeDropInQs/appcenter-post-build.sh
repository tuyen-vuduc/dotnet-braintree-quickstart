echo "List .NET SDKs"
dotnet --list-sdks

echo "Build project"
dotnet build ../DotNetAndroid.BraintreeDropInQs/DotNetAndroid.BraintreeDropInQs.csproj -c Release -v normal