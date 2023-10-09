# SmartHotel

Welcome to the Smart Hotel project repository

To carry out the project, pay attention to each step described below, and if you have **any questions**, send them to us on the class _Slack_! #vqv 🚀

Here, you will find details on how to structure the development of your project from this repository, using a specific branch and a _Pull Request_ to place your codes.

## Terms and agreements

By starting this project, you agree to the guidelines of [Trybe's Code of Conduct and Student Person's Manual](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa -student).

## Deliverables
---

<details>
<summary><strong>🤷🏽‍♀️ How to deliver</strong></summary>

To deliver your project you must create a _Pull Request_ in this repository.

Remember that you can consult our content on [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca- 4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b 79) and our [Blog - Git & GitHub](https: //blog.betrybe.com/tecnologia/git-e-github/) whenever you need it!

</details>
  
<details>
<summary><strong>🧑‍💻 What should be developed</strong></summary>

His favorite company started developing booking software for several hotel chains.
Your mission is to continue the development of this API. You will need to create a default route to see the application status and build a Dockerfile capable of preparing your application for deployment. At this stage, your mission will be to refactor the project to support this functionality and develop it.

</details>
  
<details>
   <summary><strong>📝 Skills to be worked on </strong></summary>

In this project we check if you are able to:

- Understand the process of creating containers for the application.
- Prepare a system for deployment.


</details>

<details>
<summary><strong>🗓 Delivery Date</strong></summary>

- This project is individual

- There will be 2 days of project.

- Date for final delivery of the project: 09/05/2023 2:00 pm.

</details>

## Guidelines
---

<details>
   <summary><strong>‼️ Before you start developing</strong></summary><br />

   1. Clone the repository

   - Use the command: `git clone git@github.com:tryber/csharp-026-csharp-projeto-trybe-hotel-fase-d.git`.
   - Go to the repository folder you just cloned:
     - `cd csharp-026-csharp-projeto-trybe-hotel-fase-d`

   2. Install dependencies
  
   - Enter the `src/` folder.
   - Run the command: `dotnet restore`.
  
   3. Create a branch from the `master` branch

   - Make sure you are on the `master` branch
     - Example: `git branch`
   - If not, switch to the `master` branch
     - Example: `git checkout master`
   - Now create a branch to which you will commit your project's commits
     - You must create a branch in the following format: `user-name-project-name`
     - Example: `git checkout -b joaozinho-csharp-026-csharp-projeto-trybe-hotel-fase-d`

   4. Add changes to Git _stage_ and `commit`

   - Check that the changes are not yet in _stage_
     - Example: `git status` (the _joaozinho_ folder should appear listed in red)
   - Add the new file to Git _stage_
     - Example:
       - `git add .` (adding all changes - _that were in red_ - to the Git stage)
       - `git status` (the file _joaozinho/README.md_ should appear listed in green)
   - Make the initial `commit`
     - Example:
       - `git commit -m 'starting project x'` (making the first commit)
       - `git status` (a message like this should appear: _nothing to commit_ )

   5. Add your branch with the new `commit` to the remote repository

   - Using the previous example: `git push -u origin joaozinho-csharp-026-csharp-projeto-trybe-hotel-fase-d`

   6. Create a new `Pull Request` _(PR)_

   - Go to the _Pull Requests_ page of [repository on GitHub](https://github.com/tryber/csharp-026-csharp-projeto-trybe-hotel-fase-d/pulls)
   - Click on the green _"New pull request"_ button
   - Click on the _"Compare"_ checkbox and choose your branch **carefully**
   - Put a title for your _Pull Request_
     - Example: _"Create search screen"_
   - Click on the green _"Create pull request"_ button
   - Add a description for the _Pull Request_ and click the green _"Create pull request"_ button
   - **Don't worry about filling out anything else for now!**
   - Go back to the [repository's _Pull Requests_ page](https://github.com/tryber/csharp-0x-projeto-trybe-hotel/pulls) and check that your _Pull Request_ is created

</details>

<details>
   <summary><strong>⌨️ During development</strong></summary><br/>

   - Commit changes you make to the code regularly

   - Always remember, after one (or a few) `commits`, to update the remote repository

   - The commands you will use most frequently are:
     1. `git status` _(to check what is in red - out of stage - and what is in green - on stage)_
     2. `git add` _(to add files to the Git stage)_
     3. `git commit` _(to create a commit with the files that are in the Git stage)_
     4. `git push -u origin branch-name` _(to push the commit to the remote repository the first time you `push` a new branch)_
     5. `git push` _(to push the commit to the remote repository after the previous step)_

</details>

<details>
   <summary><strong>🤝 After finishing development (optional)</strong></summary><br/>

   To signal that your project is ready for _"Code Review"_, do the following:

   - Go to the **YOUR** _Pull Request_ page, add the _"code-review"_ label and tag your colleagues:

     - In the menu on the right, click on the _link_ **"Labels"** and choose the _label_ **code-review**;

     - In the menu on the right, click on the _link_ **"Assignees"** and choose **your username**;

     - In the menu on the right, click on the _link_ **"Reviewers"** and type `students`, select the team `tryber/students-sd-026-csharp`.

   If you have any questions, [here is an explanatory video](https://vimeo.com/362189205).
   
   </details>

<details>
   <summary><strong>🕵🏿 Reviewing a pull request</strong></summary><br />

   Use the content about [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) to help you review _Pull Requests_.

</details>

<details>
   <summary><strong>🎛 Linter</strong></summary><br />

   We will use [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) to perform static analysis of your code.

   This project already comes with _linter_-related dependencies configured in the `.csproj` file.

   The analyzer is already installed by the `Microsoft C#` plugin in `VSCode`. To do this, simply download the [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) and install it.
</details>

<details>
   <summary><strong>🛠 Tests</strong></summary><br />

   .NET already has its own testing platform.
  
   This project is already configured and with its dependencies.

   ### Running all tests

   To run the tests with .NET, run the command inside your project directory `src`!

   ```
   dotnet test
   ```

   ### Running a specific test

   To run a specific test, simply run the command `dotnet test --filter Name~TestReq01`.

   :warning: **Important:** the command will run tests whose name contains `TestReq01`.

   :warning: **The automatic evaluator does not necessarily evaluate your project in the order in which the requirements appear in the readme. This is to make the evaluation process faster. So don't be alarmed if this happens, okay?**

   ### Other testing options
   - Some options that can help you are:
     - `-?|-h|--help`: displays the complete description of how to use the command.
     - `-t|--list-tests`: lists all tests, instead of running them.
     - `-v|--verbosity <LEVEL>`: defines the level of detail in the test response.
       - `q | quiet
       - `m | minimal
       - `n | normal`
       - `d | detailed`
       - `diag | diagnosis
       - Example of use:
          ```
            dotnet test -v diag
          ```
          or
          ```
            dotnet test --verbosity=diagnostic
          ```
</details>

## Project requirements

You are developing an API that will be used in a booking application for several hotel chains.

In the first phase of this project, you developed some entity routes about cities, hotels and rooms. In the second phase, you built routes for registering and logging in for customers and registering reservations. In the third phase, you added new functionality to routes and added external services. **Now, you will develop a functionality to prepare your application for deployment.**

In order to assist development, the product team has already made available the updated entity-relationship diagram and the DevOps team has made available a container in which you can use a database.

The system is divided into specific directories to assist in the organization and development of the project.

- `Controllers/`: This directory stores files with the application's controller logic. The methods to be developed are ready but without any implementation, which you will develop throughout the project.
<br />

- `Models/`: This directory stores the files with the database models. You have already developed the models `City`, `Hotel`, `Room`, `User` and `Bokking` which will be the models for the `Cities`, `Hotels`, `Rooms`, `Users` and `Bookings` tables .
<br />

- `DTO/`: This directory stores the DTO classes. Some routes expect responses based on these DTOs. You can check this by the project requirement and the return of the `repositories` methods.
<br />

- `Repository/`: This directory stores the logic that will interact with the database. The methods for each requirement are already created and you must include the implementation of each of these methods respecting the DTO return. Additionally, you will have the `TrybeHotelContext` file with the context for connecting to the database. All `repository` and `context` have interfaces that are in this directory and provide the contract for these classes. If you need to create a new method to interact with the database that is not mapped, you can freely create this new method in the `repository` but without forgetting to write the contract for this method in the referring interface.
<br />

- `Services`: This directory stores the services responsible for token generation and the geographic service.

<details id='der'>
   <summary><strong>🎲 Database</strong></summary>
   <br/>

   For development, the product team provided an *Entity-Relationship Diagram (DER)* to build the database modeling. With this image you can already know:
   - How to name your tables and columns;
   - What are the types of your columns;
   - Relationships between tables.

     ![database](img/der.png)

   The diagram infers 05 tables:
   - ***Cities***: table that will store a set of cities in which hotels are located (already developed).
   - ***Hotels***: table that will store the hotels in our application. Note that we inform the `CityId`, an attribute that will store the id of the city (already developed).
   - ***Rooms***: table that will store the rooms of each hotel in our application. Note that we inform the `HotelId`, an attribute that will store the hotel id (already developed).
   - ***Users***: table that will store the people using the system.
   - ***Bookings***: table that will store hotel room reservations. Note that we inform the attributes `UserId`, which will store the id of the user and `RoomId`, which will store the id of the reserved room.

   Regarding relationships, using the entity-relationship diagram we have:
   - A city can have several hotels.
   - A hotel can have several rooms.
   - A user can have several reservations.
   - A room can have several reservations.

   ⚠️ **You can create migrations to view the database**

</details>

<details>
<summary><strong>🐳 Docker</strong></summary><br />

To assist in development, this project has a docker compose file to upload a service from the `Azure Data Studio` database. This database has the same architecture as `SQL Server`.

To upload the service, use the command:

```shell
docker-compose up -d --build
```

To connect to your database management system, use the following credentials:

- `Server`: localhost
- `User`: sa
- `Password`: TrybeHotel12!
- `Database`: TrybeHotel
- `Trust server certificate`: true

To create the database context in your application, use as a connection string:

```csharp
var connectionString = "Server=localhost;Database=TrybeHotel;User=SA;Password=TrybeHotel12!;TrustServerCertificate=True";
```

⚠️ ** This connection string can be used in requirement 1 **

</details>

<details id='refactoring'>
   <summary>Continuing the Smart Hotel project</summary>
   
   
   You have already started the project of our application and therefore, all functionalities can be brought in so as not to duplicate the operation. This will be very important, especially when it comes to the database. Some models from your previous database will be referenced in models now, so let's bring in the previous functionality.

But how do we do this:

After cloning this project's repository, just copy and paste the features you built previously:

- `Controllers`: copy all files from the `Controllers` directory of the previous project and paste into the `Controllers` directory of this project.
- `Dto`: copy all files from the `Dto` directory of the previous project and paste into the `Dto` directory of this project.
- `Models`: copy the files relating to the `City`, `Hotel`, `Room`, `User` and `Booking` models from the previous project and paste it into the `Models` directory of this project.
- `Repository`: copy the files `RoomRepository`, `HotelRepository`, `CityRepository`, `UserRepository` and `BookingRepository` from the previous project and paste it into the `Repository` directory of this project. Do not copy interfaces. For the `TrybeHotelContext` file, do not replace it. Just add the `DBSets` and implement the `OnConfiguring()` and `OnModelCreating()` methods.
- `Migrations`: If you have a migrations directory, it means you created migrations in the previous project. Do not copy this directory and create new migrations because the database instance in the container will not be the same.
- `Services`: copy all files from the `Services` directory of the previous project and paste it into the `Services` directory of this project.
- `Tests`: In the testing project, you can copy the functionality from the `src/TrybeHotel.Test/IntegrationTest.cs` file.

</details>



### 1. Develop the GET / endpoint

<details>
   <summary><strong>More information:</strong></summary>

   - Design the `GET /` endpoint so that the API response is a success status with the following response body:

   ```json
   {
"message": "online"
   }
   ```
  - Implement the development in the `GetStatus()` method of the `src/TrybeHotel/Controllers/StatusController.cs` file.

**What will be tested:**

- It will be tested that the API response follows the requested pattern.

</details>


### 2. Develop the Dockerfile

<details>
   <summary><strong>More information:</strong></summary>

   - Develop the application Dockerfile capable of creating a container for your API
   - Implement in the `src/TrybeHotel/Dockerfile` file.

**What will be tested:**

- It will be tested that the API response follows the requested pattern.

</details>


### 3. Deploy the application to Railway - Non-evaluative bonus

<details>
   <summary><strong>More information:</strong></summary>

   - Use the knowledge acquired in this section to publish your Containerized API on Railway.
   - **This requirement is non-evaluative, therefore, it does not have automated evaluation.**


</details>

<details>
   <summary><strong>🗣 Give us feedback on the project!</strong></summary><br />

When finalizing and submitting the project, don't forget to rate your experience by filling out the form.
**Takes less than 3 minutes!**

[PROJECT EVALUATION FORM](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH26-CSHARP&template=betrybe/csharp-0x-projeto-trybe-hotel-fase-d)

</details>

<details>
   <summary><strong>🗂 Share your portfolio!</strong></summary><br />

   Did you know that LinkedIn is the main professional social network and that sharing learnings there is very important for anyone who wants to build a successful career? Share this project on your LinkedIn, tag Trybe's profile (@trybe) and show your network its evolution.

</details>
   
