# Instructions on how to use this basic-webapi-application

###  Requirements
- **dotnet version 6**
you can download it  [here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.417-windows-x86-installer)


### 1. Clone the repository to your local machine
- go to the folder that you want to clone this repository.
- open the gitbash inside the folder

- use bash ```git clone git@githubcom:DBeniskos/practice-basic-webapi-application.git``` in order to clone the repository
### 2. Buld and Run the application
- open the project folder in terminal just like :
```YourUbuntuFullPathHereWhereTheProjectIsCloned/practice-basic-webapi-application```
- inside this project folder in terminal run ```dotnet build .\src\WebApi\``` to build this application
- after that run ```dotnet run --project ./src/WebApi/``` to run the application

### 3. Stop the application
- in terminal run the following comand : 
```
ctl + C
```
##### Congratulations for running this application 🎉

### 4. Run the unit test
- open the project folder in terminal just like :
```YourUbuntuFullPathHereWhereTheProjectIsCloned/practice-basic-webapi-application```
- inside this project folder in terminal run ```dotnet build .\test\WebApi.Tests\``` to build the test
- after that run following comand :
```
dotnet test
```
You will see a report of jobs in terminal about Passed, Faild and Skipped jobs.

##### Congratulations for testing this application :sparkles:
