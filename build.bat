@rem deploy su cartella
tools\nuget restore CorsoMaggioWeb.sln

@rem clean
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe  CorsoMaggioWeb.sln /t:clean /p:Configuration=Release

@rem deploy su cartella
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe  CorsoMaggioWeb.sln   /p:Configuration=Release /p:MvcBuildViews=True /m /p:DeployOnBuild=True /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:DeleteExistingFiles=True /p:publishUrl=e:\tmp\test-release 

@rem C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe  CorsoMaggioWeb.sln   /p:DeployOnBuild=true;PublishProfile=prod
@rem  /p:Configuration=Debug;VisualStudioVersion=12.0;