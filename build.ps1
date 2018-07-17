properties {
  $testMessage = 'Executed Test!'
  $compileMessage = 'Compiled the solution successfully !!!'
  $cleanMessage = 'Cleaned the solution successfully !!!'
}

task default -depends BuildImage

task BuildImage -depends Test -precondition { return $true } {
  Write-Host "Creating docker images..."
  Exec { docker-compose build --force-rm --no-cache }
  if($lastexitcode -ne 0)
  {
    throw "Image creation failed -:("
  }
  Exec { docker rmi $(docker images --filter dangling=true -q) }
}

task Test -depends Compile -precondition { return $true } {
  if ($lastexitcode -ne 0)
  {
    throw "Build failed -:("
  }
  else
  {
    $testMessage
  }
}

task Compile -depends Restore -precondition { return $true } {
  Write-Host "Building the solution..." -ForegroundColor Green
  Exec { dotnet publish ".\ValuenetHub\ValuenetHub.csproj" --self-contained --runtime "ubuntu.14.04-x64" -c release -o .\published }
  if ($lastexitcode -ne 0)
  {
	throw "Clean failed -:("
  }
}

task Restore -depends Clean -precondition { return $true } {
  Write-Host "Restoring the solution..." -ForegroundColor Green
  Exec { dotnet restore "ValuenetHub.sln" }
}

task Clean {
  Write-Host "Cleaning the solution..." -ForegroundColor Green
  Exec { dotnet clean "ValuenetHub.sln" }
}

task ? -Description "Helper to display task info" {
  Write-Documentation
}
