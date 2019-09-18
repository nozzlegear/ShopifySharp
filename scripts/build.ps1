dotnet restore;
dotnet build -c Release;
dotnet pack --no-build -c Release ShopifySharp/ShopifySharp.csproj;
dotnet pack --no-build -c Release ShopifySharp.Experimental/ShopifySharp.Experimental.fsproj;

$nupkg = (Get-ChildItem "ShopifySharp/bin/Release/*.nupkg")[0];
$experimentalNupkg = (Get-ChildItem "ShopifySharp.Experimental/bin/Release/*.nupkg")[0];

# Push the nuget packages to AppVeyor's artifact list.
Push-AppveyorArtifact $nupkg.FullName -FileName $nupkg.Name -DeploymentName "ShopifySharp.nupkg";
Push-AppveyorArtifact $experimentalNupkg.FullName -FileName $experimentalNupkg.Name -DeploymentName "ShopifySharp.Experimental.nupkg";
