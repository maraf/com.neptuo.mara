param([string]$buildFolder)

$outputPath = "..\output";
$sitePath = "$($buildFolder)\src\Neptuo.Mara"
$port = 7085
$delay = 3000

# Start IIS.
Write-Host "Running IIS Express from '$($sitePath)' at '$($port)'."
$iis = Start-Process "C:\Program Files (x86)\IIS Express\iisexpress.exe" -NoNewWindow -ArgumentList "/path:$($sitePath) /port:$($port)"

Write-Host "Waiting $($delay)ms."
Start-Sleep -Milliseconds $delay

# Crawl site.
Write-Host "Running StaticSiteCrawler."
.\Tools\StaticSiteCrawler.exe http://localhost:$($port)/ $outputPath

# Copy assets.
If (Test-Path "$($sitePath)\Content\Images") 
{
    New-Item "$($outputPath)\Content\Images" -ItemType Directory
    Copy-Item "$($sitePath)\Content\Images\*" -Destination "$($outputPath)\Content\Images" -Force -Recurse
}

$contentPath = "$($outputPath)\Content";
If (!(Test-Path $contentPath))
{
    New-Item $contentPath -ItemType Directory
}
Copy-Item "$($sitePath)\Content\*.css" -Destination $contentPath -Force -Recurse

$fontsPath = "$($outputPath)\fonts";
If (!(Test-Path $fontsPath)) 
{
    New-Item $fontsPath -ItemType Directory
}
Copy-Item "$($sitePath)\fonts\*" -Destination $fontsPath -Force -Recurse

$scriptsPath = "$($outputPath)\Scripts";
If (!(Test-Path $scriptsPath))
{
    New-Item $scriptsPath -ItemType Directory
}
Copy-Item "$($sitePath)\Scripts\*.js" -Destination $scriptsPath -Force -Recurse

# Debug print output.
Write-Host "Content of output:"
$items = Get-ChildItem -Path $outputPath
ForEach ($item in $items) 
{ 
    $size = (Get-Item "$($outputPath)\$($item)").Length
    Write-Host "'$($item)' - $($size)B"
}

# Stop IIS.
Write-Host "Stopping IIS Express."
Stop-Process -Name iisexpress