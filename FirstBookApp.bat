@echo off
.\FirstBookApp\bin\debug\FirstBookApp
@if "%ERRORLEVEL%" == "0" goto success
:fail
   echo thiapp failed!
   echo return value = %ERRORLEVEL%
   goto end
:success
   echo Succcess app!
   echo return value = %ERRORLEVEL%
   goto end
:end
echo All Done.