# _Animal Shelter API_

#### By _**Joseph Jackson**_

#### _API that can be called to access a database!_

## Technologies Used

* _C#_
* _.NET_
* _MySQL_
* _HTML_
* _CSS_
* _Entity_
* _Identity_
* _Swagger_


## Description

_This API for an animal shelter lets a user call the shelters database. The user can get data, post data, put to edit data, or delete data. The api utilizes Swagger and MySql for controlling data._

## Setup/Installation Requirements

* _Clone the repository to your desktop_

* _Open the repository in Visual Studio Code_
* _In VS Code terminal, navigate to the AnimalShelter folder_ 
* _In VS Code terminal, run_

```json
 $ dotnet restore
 ```

 * _Followed by,_

```json
 $ dotnet build
 ```

* _Create file named "appsettings.json" in the /AnimalShelter folder_
* _Enter the following into the file_


```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=shelter_db;uid=root;pwd=[YOUR-PASSWORD_HERE];"
  }
}

```
* _Next in VS Code terminal, enter_

```json
 $ dotnet ef database update
 ```

* _In the terminal, to start the application, run_

```json
$ dotnet run
```

* _To access the api, call it with http://localhost:5000/ or http://localhost:5000/swagger_

## Known Bugs

* _No known bugs_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_ 

Copyright (c) _2022_ _Joseph Jackson_