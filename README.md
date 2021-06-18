# Student Randomizer API

## **Table of Contents**

<br />

* <a href="#about-the-student-randomizer-API">About the Student Randomizer API</a>
    * <a href="#technologies-used">Technologies Used</a>
* <a href="#Set-Up-and-Launch-the-API">Set Up and Launch the API</a>
* <a href="#Using-the-API">Using the API</a>
* <a href="#Endpoints">Endpoints</a>
    * <a href="#Students">Students</a>
    * <a href="#Groups">Groups</a>
    * <a href="#Matches">Matches</a>
* <a href="#Using-Swagger">Using Swagger</a>
* <a href="#License">License</a>
* <a href="#Acknowledgements">Acknowledgements</a>
* <a href="#Contact-Information">Contact Information</a>

<br />

## **About the Student Randomizer API**
<br />

Note: This API is designed to be used with the MVC application [Student Randomizer](https://github.com/vnessa-su/StudentRandomizerMvc.Solution.git). This project was created during the C#/.NET Team Week (Week XIV) at Epicodus, a web development bootcamp in Portland, Oregon.

During our March 2021 cohort, we discovered that the randomization tools our instructors used to build dev teams out of our cohort of 30+ students produced repetitive groups. We believe our experience suffered as a result, which inspired us to create a better option for our instructors to use. With this API and the cooresponding MVC application, instructors can generate a set of API calls for students, groups, matches, and join entries to build better randomized dev teams of students.
<br />
<br />

## **Technologies Used**
<br />

* C#
* .NET 5 Framework
* Entity Framework Core
* RestSharp

<br />

## **Set Up and Launch the API**
<br />

1. Navigate to desired destination directory using `cd <directory name>` inside of the terminal
2. Clone repository to destinated directory using the syntax `git clone https://github.com/Brenthubbard/StudentRandomizer.Solution.git`.
3. Open the repository using `code .` or `code StudentRandomizer.Solution`
4. Nagivate to project folder using `cd StudentRandomizer`
5. `dotnet restore` to install dependencies.
6. `dotnet run` to run application on server `http://localhost:4000/`
<br />
<br />

## **Using the API**
<br />

To test this API, [Postman](https://www.postman.com/downloads) is a highly recommended client that allows access to these endpoints with GET, POST, PUT, and DELETE requests alongside a host of others. To test, follow these steps in this example:
<br />
<br />

  1. Download and install [Postman](https://www.postman.com/downloads)
  2. Open a new request by selecting the `File` menu or clicking the `+` in the taskbar
  3. Make sure you are running this project by navigating to the production directory at `~/StudentRandomizer` and running, in the following order, the commands `dotnet restore`, `dotnet ef database update`, and `dotnet run`
    * This API relies on seed data. You must apply migrations in order to ensure full functionality of the [MVC app](https://github.com/vnessa-su/StudentRandomizerMvc.Solution.git).
  4. Select the type of request you would like to make.
    * GET and DELETE requests need only call the API endpoint
    * For POST and PUT requests, navigate to the `Body` tab, select `Raw`, select `Json` in the adjacent dropdown menu, and apply the JSON template listed below to fulfill a request
<br />
<br />

## **Endpoints**
<br />

### **Students**
<br />

  * **/api/students**
    1. GET: Returns a list of all students (no JSON body)
    2. POST: Creates and returns a new student with an auto-incremented id
    3. DELETE: Deletes all students (no JSON body; **to reseed database, you must drop the schema and run again `dotnet ef database update`) <br />
    <br />
    
    ```
    {
      "name": "[NEW STUDENT NAME]"
    }
    ```
    <br />

  * **/api/students/{id}**
    1. GET: Returns a specific student (no JSON body)
    2. PUT: Updates a specific student
    3. DELETE: Deletes a specific student (no JSON body) <br />
    <br />
    ```
    {
      "studentId": "[STUDENTID]",
      "name": "[NEW STUDENT NAME]"
    }
    ```
    <br />

  * **/api/Group/{groupId}**
    1. GET: Returns all students associated with a given groupId (no JSON body) <br />
    <br />

  * **/api/Match/{matchId}**
    1. GET: Returns all students associated with a given matchId (no JSON body)
    <br />
<br />

### **Groups**

<br />

  * **/api/groups**
    1. GET: Returns a list of all groups
    2. POST: Creates and returns a new group with an auto-incremented id <br />
    <br />
    ```
    {
      [SEND AN EMPTY JSON BODY]
    }
    ```
    <br />
  
  * **/api/groups/{id}**
    1. GET: Returns a specific group (no JSON body)
    2. PUT: Updates a specific group
    3. DELETE: Deletes a specific group (no JSON body) <br />
    <br />

    ```
    {
      "groupId": "[GROUPID]"
    }
    ```
    <br />
  
  * **/api/groups/AddStudent/{id}**
    1. POST: Adds a join entry that associates a student with a given groupId (id) <br />
    <br />

    ```
    {
      "groupId": [GROUPID],
      "studentId": [STUDENTID],
      "name": "[STUDENT NAME]"
    }
    ```
    <br />

  * **/api/groups/{groupId}/Student/{studentId}**
    1. DELETE: Deletes a join entry removing the association between a given student (no JSON body) <br />
    <br />

  * **/api/groups/GetStudent/{id}**
    1. GET: Returns all groups with a given studentId (no JSON body)
<br />
<br />

### **Matches**
<br />

  * **/api/matches**
    1. GET: Returns all matches (no JSON body)
    2. POST: Creates and returns a new match <br />
    <br />

    ```
    {
      "matchScore": 0
    }
    ```

<br />

  * **/api/matches/{id}**
    1. GET: Returns a specific match (no JSON body)
    2. PUT: Updates a specific match
    3. DELETE: Deletes a specific match (no JSON body) <br />
    <br />

    ```
    {
      "matchId": [MATCHID],
      "matchScore": [MATCHSCORE]
    }
    ```

<br />

  * **/api/matches/AddStudent/{id}**
    1. POST: Adds a join entry that associates a student with a given match

    ```
    {
      "matchId": 352,
      "studentId": 28
    }
    ```
  <br />

  * **/api/matches/{matchId}/Student/{studentId}**
    1. DELETE: Deletes a join entry that associates a student with a given match (no JSON body)

<br />

  * **/api/matches/GetStudent/{id}**
    1. GET: Returns a list of all matches by the given studentId (no JSON body) <br />
<br />

## **Using Swagger**
<br />

- To use swagger navigate to the http://localhost:5000/swagger page.
- When running the API you can use swagger to document your api calls.
- Swagger lets you see all the different requests accessed in the controller.
- To test one of the requests simply click on the request(GET/POST/PUT/DELETE) then click try it out and then execute.
- You will see the response body and the request URL for documentation.

<br />

## **License**

<br />

Copyright (c) 2021 by [Vanessa Su](https://github.com/vnessa-su), [Min Chang](https://github.com/M-H-Chang), [Brent Hubbard](https://github.com/Brenthubbard), and [Jonathan Stull](https://github.com/jonathanstull)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM.cs, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
<br />
<br />

## **Acknowledgements**
<br />

This project was developed alongside the [LearnHowToProgram curriculum](learnhowtoprogram.com) at Epicodus, a coding bootcamp in Portland, Oregon. This project would not have been possible without the collaboration of [Vanessa Su](https://github.com/vnessa-su), [Min Chang](https://github.com/M-H-Chang), [Brent Hubbard](https://github.com/Brenthubbard), and [Jonathan Stull](https://github.com/jonathanstull).

In particular, the developers would like to acknowledge Vanessa Su's algorithmic talents for building a recursive depth-first search and group generation algorithms. Min Chang lended his talent to group scoring, without which there would be no functional distinction from groups with high pairing frequencies. Brent Hubbard lent his abilities to MVC implementation and back- and front-end controller implementation, without which there would be no [user interface](https://github.com/vnessa-su/StudentRandomizerMvc.Solution.git). Jonathan Stull developed and implemented database design and facilitated the overall development of the API, including its models and controllers, without which this API would not be.

This app would not have been possible without the tutelage of Epicodus instructors [Erik Irgens](https://github.com/erik-t-irgens) and [James Henager](https://github.com/jhenager).

## **Contact Information**

- Min Chang: minchangmhc at gmail dot com
- Vanessa Su: vnessa.su at gmail dot com
- Jonathan Stull: jonathan.d.stull at gmail dot com
- Brent Hubbard: hubbardbrent at hotmail dot com