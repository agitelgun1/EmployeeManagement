## Roof Stacks Test Case - Employee API
Based on
- [More about .NET Core](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Swagger Ui](https://swagger.io/tools/swagger-ui/)
- [Fluent Validation](https://fluentvalidation.net/)
- [JIL](https://github.com/kevin-montrose/Jil)
- [Mapster](https://github.com/MapsterMapper/Mapster)
- [xUnit](https://xunit.net/)
- [Moq](https://github.com/moq/moq)

### Run local with CLI
1. Clone or download this repository to local machine.
2. Install [.NET Core SDK for your platform](https://www.microsoft.com/net/core#windowscmd) if didn't install yet.
3. `cd EmployeeManagement`
4. `dotnet restore`
5. `dotnet run`

### Run on Rider
1. Install [Rider for your platform](https://www.jetbrains.com/rider/) if didn't install yet.
2. Open project
3. Debug => Start debugging
4. You can use swagger ui for your local test => [link](https://localhost:5001/index.html)

### About Project

There is two end point in project.

1. Create : This endpoint create employee. Example curl sample is below:


    curl --request POST \
    --url https://localhost:5001/api/employee/create \
    --header 'Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZWxndW4iLCJleHAiOjE2NTA4MzE4OTAsImlzcyI6Imh0dHBzOi8vcm9vZnN0YWNrc3Rlc3RjYXNlLmNvbSIsImF1ZCI6Imh0dHBzOi8vcm9vZnN0YWNrc3Rlc3RjYXNlLmNvbSJ9.U_iOA0Fawm-SlocOqpDUCyjlH5rQJw3X4E0TjMlepd4' \
    --header 'Content-Type: application/json' \
    --header 'accept: */*' \
    --data '{
    "name": "Ahmet",
    "gender": 0,
    "age": 23,
    "activity": true
    }'

2. ToggleActivity : This endpoint toggle employee activity. Example curl sample is below:


    curl --request PUT \
    --url https://localhost:5001/api/employee/toggleactivity/2 \
    --header 'Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZWxndW4iLCJleHAiOjE2NTA4MzAxMTEsImlzcyI6Imh0dHBzOi8vcm9vZnN0YWNrc3Rlc3RjYXNlLmNvbSIsImF1ZCI6Imh0dHBzOi8vcm9vZnN0YWNrc3Rlc3RjYXNlLmNvbSJ9.mzv6EZkNXeflyLXUtIiVclNCU8LY46VvB6N-5fn40hI' \
    --header 'Content-Type: application/json' \
    --header 'accept: */*'

3. You can follow the versions on Employee.API.csproj (PropertyGroup > Version) file and CHANGELOG.md

4.Test solution structure is designed like a project.
