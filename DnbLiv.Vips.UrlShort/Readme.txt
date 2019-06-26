_____________________________________________________________________________________________________
-	Solution description
_____________________________________________________________________________________________________
-	General
This project is a .NET  WEB API currently based on .NET Framework 4,6,1
The purpose is to serve DnbLivShortUrl.Frontend to Create a short url  and Redirect
API documentation is provide with Swagger(https://github.com/domaindrivendev/Swashbuckle)
See also https://github.com/Microsoft/aspnet-api-versioning/blob/master/samples/aspnetcore/SwaggerSample/Startup.cs
Current startup endpoint for solution is http://localhost:48668/swagger/index.html.
# Short Url


##How to set it up


```xml
<configuration>
  <connectionStrings>
    No coonection string beacuse in this solution we are not fetching or saving information from database
  </connectionStrings>
</configuration>
```

##How to use

The service cosists of two basic functionalities:

####Create short url
Simple post of long URL to controller action "SHORT" will create record with short URL key and retrieve it back

```http
POST /Short/ HTTP/1.1
Host: localhost:48668
Content-Type: application/json
Cache-Control: no-cache

"http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api"
```

If the short URL already exists with the short URL key then existing short URL key is retrieved.

####Navigate to short url
Passing the short URL key to service in GET request will return redirection header values (including long URL string) order to navigate browser to the long URL assigned to the key.

```http
GET /1639fe HTTP/1.1
Host: localhost:48668
Content-Type: application/json

```

##Settings

Service settings consists of just few web.config key values in appSeetings sections. They are controlling behaviour of URL shortening web service.

| Name  		 					| Default value 	| Description				 	|
| --------------------------------- | ----------------- | ------------------------------|
| **KeyLength**						| 6					| Character length of short URL key for added URLs								|
| **CacheTimeout**					| 5					| How many minutes to keep key and URL after last request								|
| **ApiUrl**						|"http://localhost:48668/"	| Url Need to be changed for diffrent local machine					|

```xml
<configuration>
  <appSettings>   
    <add key="KeyLength" value="6"/>
    <add key="CacheTimeout" value="5"/>
	<add key="ApiUrl" value="http://localhost:48668/"/>
  </appSettings>
</configuration>
```

