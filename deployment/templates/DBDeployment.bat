@echo off

SET DIR=%~d0%~p0%

SET database.name="${database.name}"
SET sql.files.directory="${dirs.db}"
SET backup.file="${restore.from.path}"
SET server.database="${server.database}"
SET repository.path="${repository.path}"
SET version.file="_BuildInfo.xml"
SET version.xpath="//buildInfo/version"
SET environment="${environment}"

"%DIR%rh\rh.exe" /d=%database.name% /f=%sql.files.directory% /s=%server.database% /vf=%version.file% /vx=%version.xpath% /r=%repository.path% /env=%environment% /simple 

pause