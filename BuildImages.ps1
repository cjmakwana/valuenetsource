clear
Write-Host "Setting up psake..."
Install-Package psake -Confirm
Import-Module psake.psm1
Invoke-psake build.ps1
.\PushImages.ps1 -Repo ancontainer.azurecr.io -UserId ancontainer -Password JWkFSOx2Ul4zj6bnhyT2pEC=tb6LGiev -Version 1.1.0