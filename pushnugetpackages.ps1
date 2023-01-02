#$repoPath = "C:\Users\mrlst\OneDrive\Documents\Repos\Common\"
#$Common_AspDotNet_path = $repoPath + "Common.AspDotNet\bin"
#
#cd $repoPath

$packageSourceName = "AWSCodeArtifact"

dotnet nuget push C:\nuget\Common.1.0.1.nupkg --source $packageSourceName
dotnet nuget push C:\nuget\Common.AspDotNet.1.0.1.nupkg --source $packageSourceName
dotnet nuget push C:\nuget\Common.EntityFramework.1.0.1.nupkg --source $packageSourceName
dotnet nuget push C:\nuget\Common.Extensions.1.0.1.nupkg --source $packageSourceName
dotnet nuget push C:\nuget\Common.Interfaces.1.0.1.nupkg --source $packageSourceName
dotnet nuget push C:\nuget\Common.Models.1.0.1.nupkg --source $packageSourceName
