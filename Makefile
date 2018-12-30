test:
	@./packages/nunit.consolerunner/3.9.0/tools/nunit3-console.exe DataStructures.csproj

install:
	@dotnet restore --packages ./packages