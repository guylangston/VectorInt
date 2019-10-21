param(
     [string]$ver
    )
$name = "VectorInt"

ls "C:\Projects\LocalNuGet\*$name"

if ($ver -eq ""){
    $ver = Read-Host -Prompt 'Version as "0.1.6"'
}

pushd

dotnet build -c Release
dotnet pack -c Release "-p:PackageVersion=$ver"


copy ".\bin\Release\$name.$ver.nupkg"  "C:\Projects\LocalNuGet\$name.$ver.nupkg"

ls "C:\Projects\LocalNuGet\*$name"

popd