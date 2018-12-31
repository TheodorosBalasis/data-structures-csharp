all:
	@echo "Available commands: test, build, install"

test:
	@./packages/nunit.consolerunner/3.9.0/tools/nunit3-console.exe DataStructures.csproj

build: test
	@dotnet build

install:
	@dotnet restore --packages ./packages