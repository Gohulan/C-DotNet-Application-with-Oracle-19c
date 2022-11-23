# C-DotNet-Application-with-Oracle-19c-Database
This repository will show to develop a C# dotnet application with Oracle 19c database.
Replace YOUR ORACLE DATABASE SERVER IP/SERVER NAME HERE with Oracle Database server actual name
Change the connection string as below 
string connectionstring = "Data Source = (DESCRIPTION = " +
             "(ADDRESS = (PROTOCOL = TCP)(HOST = YOUR ORACLE DATABASE SERVER IP/SERVER NAME HERE)(PORT = 1521))" +
             "(CONNECT_DATA = " +
               " (SERVER = DEDICATED)" +
               " (SERVICE_NAME = ORACLE DATABASE ID HERE)" +
             " )" +
           "); User Id = ORACLE DATABASE USER HERE ; password=ORACLE DATABASE PASSWORD HERE;";
