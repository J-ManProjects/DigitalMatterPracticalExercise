# Organize the input parameters.
param (
	[Alias('h')]
	[Switch]$help,

	[Alias('e')]
	[Switch]$explorer,

	[Alias('v')]
	[Switch]$vscode,

	[Alias('p')]
	[Switch]$python,

	[Alias('g')]
	[Switch]$github
)

# If help is requested, show the help menu and exit.
if ($help) {
	Write-Host "╔══════════════════════════════════════════════════════════════════════╗"
	Write-Host "║ Usage: openRepo.ps1 [option]                                         ║"
	Write-Host "║ optional arguments:                                                  ║"
	Write-Host "║    -h, -help:      Shows the help dialogue                           ║"
	Write-Host "║    -e, -explorer:  Opens the current directory in Windows Explorer   ║"
	Write-Host "║    -v, -vscode:    Opens the current directory in VSCode             ║"
	Write-Host "║    -p, -python:    Opens the current directory in Python IDE Spyder  ║"
	Write-Host "║    -g, -github:    Opens the GitHub repository in default browser    ║"
	Write-Host "║                                                                      ║"
	Write-Host "║ Opens Windows Explorer, VSCode, Spyder, and the GitHub link          ║"
	Write-Host "║ by default if no arguments are provided.                             ║"
	Write-Host "╚══════════════════════════════════════════════════════════════════════╝"
	exit 1
}

# Set all to true if no parameters were given.
if (-not ($explorer -or $vscode -or $python -or $github)) {
	$explorer = $true
	$vscode = $true
	$python = $true
	$github = $true
}

# Open directory in Windows Explorer.
if ($explorer) {
	Invoke-Item .
}

# Open directory in VSCode.
if ($vscode) {
	Start-Process -WindowStyle Hidden code .
}

# Open directory in Spyder.
if ($python) {
	spyder -p . &
}

# Open link to GitHub repository.
if ($github) {
	$url = ((cat ".git\config" | Select-String "url") -split "\s")[-1]
	Start-Process $url
}