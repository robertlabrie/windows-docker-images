@echo off
del .\criticalbusinessapp\bin\Debug\criticalbusinessapp.exe
del .\criticalbusinessapp\bin\x64\Release\criticalbusinessapp.exe
del .\criticalbusinessapp\bin\x64\Release\criticalbusinessapp.vshost.exe
del .\criticalbusinessapp\obj\x64\Debug\criticalbusinessapp.exe
del .\criticalbusinessapp\obj\x64\Release\criticalbusinessapp.exe
del .\criticalbusinessapp\bin\Release\criticalbusinessapp.exe
del .\criticalbusinessapp\obj\Release\criticalbusinessapp.exe
@echo on
docker run -v %cd%:c:/source -ti builder c:\source\build-docker.cmd
