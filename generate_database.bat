@echo off

:: Test if dotnet is found within the path environment.
echo %path% | find "dotnet" > nul
if errorlevel 1 (
	echo[
	echo Error! The dotnet framework was not found. Please ensure that .Net 8.0 or later is installed.
	pause
) else (
	echo Generating the database.
	echo[
	echo Building data migration . . .
	dotnet ef migrations add InitialCreate
	echo[
	echo Updating the database . . .
	dotnet ef database update
	echo[
	pause
)
