## SQL Challenge 

<hr>

#### This repository was inspired by https://github.com/digitalinnovationone/trilha-net-banco-de-dados-desafio and contains the solutions for the SQL statements that return the desired data

#### Instructions to run this project:

#### 1) In order to run the project locally, you will need to have a SQL server installed locally or on premises(this project has used Azure SQL server)

#### 2) After installing the SQL Server, create a database and run the  script located at trilha-net-banco-de-dados-desafio/Script.sql and verify that the tables were created successfully and the data was inserted into them

#### 3) At the root of this project there are the appsettings.json and appsettings.Development file, which contains the connection string to connect to the database, you will need to change the values according to your environment as shown below:

![DBConnection](https://github.com/LucasRBA/Basic-Projects/blob/main/dotNET/SQL-Challenge/assets/Screenshot_20240221_231340.png)<br/>
*The Connection String to be replaced inm both files*

#### 4) You may run the MVC app locally or deploy it on Azure, for this you will need to have a Visual Studio and an Azure account.

#### 5) Running it through Azure Web App/App Service may block your ip from requesting any data to the SQL Server, so you will need to access your SQL Resource and under the Security > Networking > Firewall Rules add your IP address in the allowed IPs(don't forget to save after adding the ip) section as shown below:

![Firewall Rule](/assets/Screenshot_20240221_233117.png)<br/>
*Adding IPv4 to the firewall rules*

#### 6) After that the app should run locally or on Azure without any problem, if you have any problems please feel comfortable to open an issue and I will try to help you as soon as possible.

![App Running](/assets/Screenshot_20240221_233915.png)<br/>
*Fourth solution running the app locally*


#### 7) Note that the solution to the problem is the file SQL-Queries.sql which contains all the queries used in this project. The MVC implementation using Azure and Azure Data Studio were just to learn and practice .NET Core, so they are not the best practices for a real world application.

#### 8) If you are running the project on Linux, specially distros based on Arch you may have problems running it using default settings, it errors related to the following link occurs https://stackoverflow.com/questions/74009347/c-sharp-on-linux-required-framework-not-found . Try to change the settings under /usr/share/dotnet/shared/Microsoft.NETCore.App/{YOUR_VERSION} at the end of the file Microsoft.NETCore.App.deps.json to the ones shown below:

![Linux Settings](/assets/Screenshot_20240221_235026.png)<br/>
*Linux Settings for .NET ASPNET/MVC*

#### PS: dotnet platform runs on windows or unix based platforms, in order to run on linux distros that have their on repos and names under runtimes such as "manjaro-x64" you will need to set a fallback runtime for arch-x64 instead of manjaro-x64, and include linux-x66, unix, and unix-64 inside the array of runtime settings.
