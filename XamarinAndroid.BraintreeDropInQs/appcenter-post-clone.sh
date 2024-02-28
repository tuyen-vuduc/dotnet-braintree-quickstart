wget https://dot.net/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --channel 7.0 --install-dir "$AGENT_TOOLSDIRECTORY/dotnet"

echo "Install .NET Android workdload"
dotnet workload install android