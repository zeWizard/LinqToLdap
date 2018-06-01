IF [%1] == [] (
 SET APIKEY=""
)

IF NOT [%1] == [] (
 SET APIKEY=%1%
)

del *.nupkg

MSBuild.exe ..\LinqToLdap.sln /t:Clean /p:Configuration=Release /p:Platform="Any CPU"
MSBuild.exe ..\LinqToLdap.sln /t:Build /p:Configuration=Release /p:Platform="Any CPU"

nuget.exe pack ..\LinqToLdap\LinqToLdap.nuspec -IncludeReferencedProjects -Prop Configuration=Release
nuget.exe push *.nupkg %APIKEY% -Source https://api.nuget.org/v3/index.json
