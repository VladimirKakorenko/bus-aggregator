Param(
    [parameter(Mandatory=$false)][string]$sourceTag="linux-latest",
    [parameter(Mandatory=$false)][string]$sourcePrefix="dav08649",
    [parameter(Mandatory=$false)][string]$targetTag="latest",
    [parameter(Mandatory=$false)][string]$targetPrefix="dav08649"
)

# Write-Host "Building images" -ForegroundColor Green
# Invoke-Expression 'cmd /c "docker-compose build"'

$images = ("adapter.api", "data.api", "webapigw", "webstatus", "webspa")

foreach($image in $images) {
    $sourceImage = "${sourcePrefix}/${image}:${sourceTag}";
    $targetImage = "${targetPrefix}/${image}:${targetTag}";

    Write-Host "Publishing $sourceImage into $targetImage" -ForegroundColor Green
    Invoke-Expression 'cmd /c "docker tag $sourceImage $targetImage"'
    Invoke-Expression 'cmd /c "docker push $targetImage"'
}