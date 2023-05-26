# ITA18_ASPDOTNET

Notes:

ASP.NET is a frameowork to build applications inside the .NET platform.
We can build WEB services, API's and much more.

About WEB Services:
URI - Universal Resource Identifier
It will never define what the server will return.

HTTP - Hyper Text Transfer Protocol

REST - Representational State Transfer
It's the implementation of GET, POST, DELETE, etc of the HTTP.

We will be using Kestrel as our web server. 
Our main focus will be developing API's, specifically controller-based ones. (using classes)

creating a new dotnet webapi project

dotnet new webapi -f net6.0

program.cs does not declare methods or classes, it's the main. The main is just hidden. Why? Just to please JS developers.
It's also here that we configure the middlewares (pipeline), such as CORS policy
