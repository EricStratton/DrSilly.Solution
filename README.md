## Dr. SillyStringz Factory Admin Page -- Many-to-Many MySQL Database

### _Webpage to create many-to-many relationships between fictional factory equipment and engineers who repiar them_

### _Created by: Eric Stratton_

## Description

Use this webpage to create multiple many-to-many relationships which are accessible from both sides of the relationship. An aid for a factory manager to generate a table of which engineers specialize in repairing which equipment. 

## Setup/Instillation

### Requirements:

- Internet browser
- Code editor if you wish to view/edit the code (recommended)
- .NET Core SDK
- MySQL 

### .NET Core:

- Application is built using the deprecated .NET Core vs 2.2.
- .NET Core is a requirement for running this application, if you need to install it visit <https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer>
- Or if you wish to downloaded the latest editions of .Net Core, select `.NET core` in the file path at the top of the dowloaded page provided in the link above

### MySQL:

- Application utilizes a database created using MySQL
- Download from MySQL Community Server <https://dev.mysql.com/downloads/file/?id=484914>
- Either make an account or select `No thanks, just start my dowload`
- Follow install instructions and configure to your specifications
- Recommend including _MySQL Workbench_ in install
- Check if properly installed by running command `mysql -uroot -p<password>` in terminal

### Download: 

- Download this repository by clicking the green 'Code' icon and selecting download zip
- Use your favorite zip.file opener to extract files to your local device
- Follow install window and select configuration of your choice

### Terminal:

- Open command terminal on local device
- Navigate to desktop in terminal using `$ cd desktop`
- Copy repository link by clicking on green 'Code' icon and clicking the clipboard to the right of the url
- Use command `$ git clone {specific_repository_URL}`
- From desktop, run command `$ cd {newly-downloaded-directory}` to navigate to the installed directory
- Run command `$ code .` to open directory in default code editor
- Run command `dotnet restore <rootDirectory>` in the console to upload necessary .NET Core files
- Run command `$ cd <rootDirectory>` to navigate into the root directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the web application should run in the web browser at `localhost:5000`

### Import Database using Entity Framework Core

**_A copy of the database structure exists in the project root_**
- Navigate to `Factory` directory in your terminal
- Run command `dotnet ef database update` to generate database based on provided structure
- If you make changes and want to update database run command `dotnet ef migrations add <MigrationName>`

### Import Database using MySQL Workbench 

- Open MySQL Workbench
- Navigate to the `Administration` window on the left hand side
- Use option `Import from Self-Contained File`
- Set `Default Target Schema` or alternatively make a new schema
- Select Schema Object from this project's directory
- In the dropdown select `Dump Structure Only`
- Click `Start Import`

### Navigating in Application:

- App opens on landing page at `localhost:5000/`
- Click on one of the hyperlinks to navigate to a different section of app

### RESTful Protocol:

- **_Page routes are named using RESTful notation as reflected in the pathway urls_**
- `localhost:5000/`: landing page
- `localhost:5000/vendors`: homepage for vendor profiles, displays all existing vendor profiles
- `localhost:5000/vendoes/new`: page for creating a new vendor profile
- `localhost:5000/vendors/{vendorId}`: page for select vendor profile, displays vendor description and existing orders for vendor
- `localhost:5000/vendors/{vendorId}/orders/new`: page for select vendor to place new order
- `localhost:5000/vendors/{vendorId}/orders/{orderId}`: page for specific order details


## Known Bugs/Issues

Program is incompletet at this time.

## Support & Contact Details

Do not hesitate to contact me at:

<strattonericj@gmail.com>

## Technologies 

- _VisualStudio Code_
- _C#_
- _.NET Core 2.2_
- _MySQL_
- _MySQL Workbench_
- _Git_
- _GitHub_

## Licensing

Copyright (c) 2020 **_Eric Stratton_**

This software is licensed under the MIT license