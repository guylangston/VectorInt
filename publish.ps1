param(
     [string]$ver
    )
$name = "VectorInt"

if ([string]::IsNullOrEmpty($ver))
{
    $ver = Get-Content ./package-version.txt
}

echo "Package: '$name'"
echo "Package-Version: '$ver'"

$confirmation = Read-Host "Does the version look correct? y/n"
if ($confirmation -eq 'y') {
    pushd
    
    dotnet build -c Release --no-incremental "-p:PackageVersion=$ver"
    dotnet pack -c Release "-p:PackageVersion=$ver"
    
    
    copy ".\bin\Release\$name.$ver.nupkg"  "C:\Projects\LocalNuGet\$name.$ver.nupkg"
    
    echo " ==> C:\Projects\LocalNuGet\$name.$ver.nupkg"
    
    popd
}

