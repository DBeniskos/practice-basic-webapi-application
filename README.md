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


# Instructions on how to run this application on windows machine

### 1. Donload artifact
- navigate to [repository](https://github.com/DBeniskos/practice-basic-webapi-application)
- click on *Actions* tab
- click on the latest workflow from *All Workflows* list (the latest is the one on the top) 
- scroll at the bottom of the page in Artifacts section and the click the **Application_Artifact** to download the artifact
### 2. Run Apllication
- navigate to downloaded folder and you will see the *Application_Artifact.zip* folder
- unzip the folder and you can see an .exe and .txt file
- click on **WebApi.exe** file to run the application
- a window displaying some infos will automatically open on your pc
- open a browser and navigate to ``http://localhost:5000``
you wll see a **Hello World!** message in your browser

### 2. Stop running this Apllication
- for stopping the application just close the window, 
or you can type : ``ctl + C`` on application window