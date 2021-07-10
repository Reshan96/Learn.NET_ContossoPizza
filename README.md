# Learn.NET_ContossoPizza

This is a tutorial for learining ASP .NET api concepts

To create new project use following command:
  `dotnet new webapi --no-https`

To build, use : 
  `dotnet build`
  
To run, use :
  `dotnet run`
  
Opens in http://localhost:5000/

To test the api and create api requests you can use REPL:
  * `dotnet tool install -g Microsoft.dotnet-httprepl`
  * The preceding command installs the .NET HTTP Read-Eval-Print Loop (REPL) command-line tool that we will use to make HTTP requests to our web API.
  * To connect REPL run this command in new terminal while api is running: `httprepl http://localhost:5000`
  * Command: `http://localhost:5000/> ls`   -> will list out the endpoints available on api
  * Command: `cd pizza`    -> command will output available APIs available for the Pizza endpoint (case insensitive)
  * use get, put, delete, post requests 
