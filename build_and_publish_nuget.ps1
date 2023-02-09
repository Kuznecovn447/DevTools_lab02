param(
    [Parameter(Mandatory=$false)]
    [string] $GITHUB_NAME = "Kuznecovn447",

    [Parameter(Mandatory=$false)]
    [string] $GITHUB_PAT = "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",

    [Parameter(Mandatory=$false)]
    [string] $NUGET_API_KEY = "oy2leavgsmqtz7hbugpq4ko2dzucox6eben6m62up4mcqe",

    [Parameter(Mandatory=$false)]
    [string] $GITHUB_SOURCE = "kuznecov-cs-package",

    [Parameter(Mandatory=$false)]
    [string] $SOURCE = "./PowerCollections/bin/Release/PowerCollectionsUniversityEdition.1.0.0.nupkg",

    [Parameter(Mandatory=$true)]
    [string] $VERSION

    # [string] $NUGET_PATH = "./nuget.exe"
) 

# [string] $NUGET_DOWNLOAD_URL = "https://dist.nuget.org/win-x86-commandline/v6.4.0/nuget.exe"

[System.Console]::Clear() 

$SOURCE = [string]::Format("./PowerCollections/bin/Release/PowerCollectionsUniversityEdition.{0}.nupkg", $VERSION)

# if(-not(Test-Path -Path $NUGET_PATH -PathType Leaf))
# {
#     Write-Host("Downloading nuget.exe...")
#     Invoke-WebRequest -URI $NUGET_DOWNLOAD_URL -OutFile $NUGET_PATH
# }

Write-Host("Building (Release)...")
dotnet build -c:Release
Write-Host("Packing...")
dotnet pack -c:Release -p:PackageVersion=$VERSION

[string] $NUGET_GITHUB_URL = [string]::Format("https://nuget.pkg.github.com/{0}/index.json", $GITHUB_NAME)
[string] $GITHUB_SOURCE_NAME = [string]::Format("github-{0}", $GITHUB_SOURCE)

dotnet nuget remove $GITHUB_SOURCE_NAME
Write-Host("Update remote credentials...")
dotnet nuget add source `
--username $GITHUB_NAME `
--password $NUGET_API_KEY `
--store-password-in-clear-text `
--name $GITHUB_SOURCE_NAME `
$NUGET_GITHUB_URL

Write-Host("Pushing...")
dotnet nuget push `
--skip-duplicate `
$SOURCE `
--api-key $GITHUB_PAT `
--source $GITHUB_SOURCE_NAME

