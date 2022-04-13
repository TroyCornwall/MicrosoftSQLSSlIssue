# Project to repoduce an issue connecting to Azure SQL databases, from within a docker container.


### To run
1) Open command prompt
2) cd into the MicrosftSQLSSLIssue directory
3) run `docker build -f Dockerfile -t sqlissue .` 
4) run `docker run sqlissue <dbname>` where <dbname> is a database you can access

This issue is related to https://github.com/dotnet/SqlClient/issues/1402,
but is also due to the fact that the docker container cannot validate the azure sql databases SSL cert.