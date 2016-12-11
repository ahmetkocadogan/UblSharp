<#
.SYNOPSIS
  This is a helper function that runs a scriptblock and checks the PS variable $lastexitcode
  to see if an error occcured. If an error is detected then an exception is thrown.
  This function allows you to run command-line programs without having to
  explicitly check the $lastexitcode variable.
.EXAMPLE
  exec { svn info $repository_trunk } "Error executing SVN. Please verify SVN command-line client is installed"
#>
function Exec
{
    [CmdletBinding()]
    param(
        [Parameter(Position=0,Mandatory=1)][scriptblock]$cmd,
        [Parameter(Position=1,Mandatory=0)][string]$errorMessage = ($msgs.error_bad_command -f $cmd)
    )
    & $cmd
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}

Push-Location $(Split-Path $Script:MyInvocation.MyCommand.Path)

if(Test-Path .\..\artifacts) { Remove-Item .\..\artifacts -Force -Recurse }

exec { & dotnet restore }

exec { & dotnet build .\UblSharp -c Release }
exec { & dotnet build .\UblSharp.Validation -c Release }

$revision = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
$revision = "{0:D4}" -f [convert]::ToInt32($revision, 10)

exec { & dotnet test .\UblSharp.Tests -c Release }

exec { & dotnet pack .\UblSharp -c Release -o .\..\artifacts --version-suffix=$revision }
exec { & dotnet pack .\UblSharp.Validation -c Release -o .\..\artifacts --version-suffix=$revision }

Pop-Location