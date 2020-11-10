<br>
<p align="center">
  <u><big>|| <b>National Park API // by Grant Eadie, Nov. 2020</b> ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <a>
        <img src="https://i.imgur.com/1kUf5JG.jpg">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/GrantEadie">
            <strong>Grant Eadie</strong>
        </a> 
    </p>
</p>

<p align="center">
  <small>Created on November 8th, 2020.</small>
</p>

---

# <u>Table of Contents</u>

  - <a href="#-Description">Description</a>
  - <a href="#-known-bugs">Known Bugs</a>
  - <a href="#-built-with">Built With</a>
  - <a href="#-getting-started">Getting Started</a>
  - <a href="#-setup-and-use">Setup and Use</a>
  - <a href="#-contact-and-support">Contact</a>
  - <a href="#-license">License</a>


---

# 📖 Description

Use this really sweet little API to log the reserves, states, and their subsequent pairs in a SQL database. Simply GET and POST to this API to transfer information. Authorization is held in a Bearer Key - more details below! 

# 🦠 Known Bugs

- Join table can be tricky at times. 

# 🛠 Built With

- [Visual Studio Code](https://code.visualstudio.com/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
- [MySQL](https://dev.mysql.com/)
- [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)

# Getting Started

## Install .NET Core

- On macOS Mojave or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
- On Windows 10 x64 or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

## Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal for macOS or PowerShell for Windows.

## Install MySQL Workbench

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

## Code Editor

To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:
   - Option 1: [Atom](https://nodejs.org/en/)
   - Option 2: [VisualStudio Code](https://www.npmjs.com/)
2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a [GitHub Account](https://github.com)

<hr>

## Database Settings

1. Create a new file in the NationalParks directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=national_parks0;uid=root;pwd=YourPassword;"
  }
}
```

3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

# ⚙️ Setup and Use

- copy the repository URL and paste it after this GIT command `git clone {repository url}`
- after opening the repository in your code reader, run `dotnet build`
- once build is complete and no errors are thrown, run `dotnet watch run` in the terminal
- in [Postman](https://www.postman.com/), paste this in the "request" line `http://localhost:4000/users/authenticate`
- change the request action to POST and copy this text into the body 

  ```
  {
    "username":"test",
    "password":"test"
  }
  ```
- copy the Bearer Token received in the body of the return and paste into your client
- POST or GET to `http://localhost:4000/api/reserves` or `http://localhost:4000/api/states`

# POSTING 

- in [Postman](https://www.postman.com/) or other client, paste your Bearer Token into a header
- paste this url into the request line -- http://localhost/api/{reserves OR states}
- to POST in RESERVES, paste this syntax into the body of your POST 

```
{
  "reserveName": "{the name of the reserve you are posting}"
  "states": "{states they currently reside in.}"
}
```
- for STATES
```
{
  "stateName": "{the name of the state you are posting}"
  "reserves": "{reserves currently in this state}"
}
```

# GETTING
- in [Postman](https://www.postman.com/) or other client, paste your Bearer Token into a header
- paste this url into the request line -- http://localhost/api/{reserves OR states}
- send request and reap the benefits of this incredible API!


## Database

1. Navigate to the NationalParksApi directory using the MacOS Terminal or Windows Powershell
2. Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

---

# Contact and Support

If you have any feedback or concerns, please contact <grantleadie@gmail.com>.

---

# License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2020 Grant Eadie All Rights Reserved.

```

MIT License

Copyright (c) 2020 Grant Eadie

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```