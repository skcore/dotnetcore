# Asp.net Core Web API CRUD application in dotnet8

ASP.NET Interview Questions 
https://gtcore.in/asp-net-core-top-interview-questions/

This is the sample Web API application developed in dotnet8 and implemented CRUD operations in different ways
(EF, ADO.NET)

1. Connected db directly in contoller level with **EF**
2. Connected db using services, repositories with **EF**
3. Connected db using services, repositories with **ADO.NET**

### Technologies
1. ASP.NET CORE (DOTNET 8)
2. C#
3. ADO.NET
4. DEPENDENCY INJECTION
5. SWAGGER UI
6. ENTITY FRAMEWORK
7. SQL SERVER


Note : **Excpetions not handled with try, catch block since it is sample web api application for crud operations in dotnet8**


To compress data in an ASP.NET Core Web API, you can use response compression middleware.
Install ResponseCompression package
--dotnet add package Microsoft.AspNetCore.ResponseCompression

### To verify that response compression is working correctly in your ASP.NET Core Web API, you can follow these steps:

Use Browser Developer Tools:
1. Open your web browser (e.g., Chrome, Firefox).
2. Open the Developer Tools (usually by pressing F12 or right-clicking on the page and selecting "Inspect").
3. Go to the "Network" tab.
4. Make a request to your API endpoint.
5. Click on the request in the network tab to view its details.
6. Check the "Headers" section for the Content-Encoding header. It should show gzip or br (Brotli) if the response is compressed.
