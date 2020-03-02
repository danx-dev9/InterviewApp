@echo off

setlocal
call :setESC

cls

echo %ESC%[36mBuilding solution InterviewApp%ESC%[0m
echo.
echo %ESC%[36mPlease wait this may take a bit...%ESC%[0m
echo.
dotnet build
echo.

echo %ESC%[36mBuild solution completed.%ESC%[0m
echo.
echo %ESC%[36mRunning tests...%ESC%[0m
echo.
dotnet test
echo.

pause

:setESC
for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do rem"') do (
  set ESC=%%b
  exit /B 0
)