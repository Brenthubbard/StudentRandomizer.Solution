# Student Randomizer API

## Technologies Used

- C# / .NET 5 Framework / MySQL / Entity

### Description
Note: This API is designed to be used with the MVC application https://github.com/vnessa-su/StudentRandomizerMvc.Solution.git
Users can generate a set of API calls for students, groups, and matches to generate a list.

## Setup Instructions
1. Navigate to destination directory using `cd <directory name>` inside of the terminal.
2. Clone repository to destinated directory using the syntax `git clone https://github.com/Brenthubbard/StudentRandomizer.Solution.git`.
3. Open the repository using `code StudentRandomizer.Solution`.
4. Nagivate to project folder using `cd StudentRandomizer`
5. `dotnet restore` to install dependencies.
6. `dotnet run` to run application on server http://localhost:4000/

#### Launching API
1. Navigate to the root StudentRandomizer file
2. Using the command `dotnet run` in your terminal it will launch http://localhost:5000/ for you
3. Access postman to make requests using the API

#### Using Swagger
- To use swagger navigate to the http://localhost:5000/swagger page.
- When running the API you can use swagger to document your api calls.
- Swagger lets you see all the different requests accessed in the controller.
- To test one of the requests simply click on the request(GET/POST/PUT/DELETE) then click try it out and then execute.
- You will see the response body and the request URL for documentation.

### License

- MIT License

#### Contact Information
- Min Chang: minchangmhc at gmail dot com
- Vanessa Su: vnessa.su at gmail dot com
- Jonathan Stull: jonathan.d.stull at gmail dot com
- Brent Hubbard: hubbardbrent at hotmail dot com