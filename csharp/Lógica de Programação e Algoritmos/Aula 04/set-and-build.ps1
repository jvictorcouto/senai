# Define o arquivo .cs que sera o unico compilado (ponto de entrada).
# Uso: .\set-and-build.ps1 "C:\caminho\para\entrada.cs"
param([Parameter(Mandatory=$true)][string]$currentFile)

$ErrorActionPreference = "Stop"
$scriptDir = $PSScriptRoot
$fileName = [System.IO.Path]::GetFileName($currentFile)

# So processar se o arquivo esta nesta pasta
$currentDir = [System.IO.Path]::GetDirectoryName($currentFile)
if ($currentDir -ne $scriptDir) {
    Write-Error "O arquivo nao esta na pasta Aula 04: $currentFile"
    exit 1
}

# Lista de .cs na pasta (excluindo obj)
$allCs = Get-ChildItem -Path $scriptDir -Filter "*.cs" -File | Where-Object { $_.Name -notlike "*.AssemblyInfo*" -and $_.Name -notlike ".NETCoreApp*" -and $_.Name -notlike "*.GlobalUsings*" }
$toRemove = $allCs | Where-Object { $_.Name -ne $fileName } | ForEach-Object { $_.Name }

# Monta o ItemGroup de Compile Remove
$removeLines = $toRemove | ForEach-Object { "    <Compile Remove=`"$_`" />" }
$removeBlock = $removeLines -join "`n"

$csprojContent = @"
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <Using Include="System.Console" Static="true" />
  </ItemGroup>

  <ItemGroup>
$removeBlock
  </ItemGroup>

</Project>
"@

$csprojPath = Join-Path $scriptDir "Aula04.csproj"
Set-Content -Path $csprojPath -Value $csprojContent -Encoding UTF8

Set-Location $scriptDir
& dotnet build --nologo -v q
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
