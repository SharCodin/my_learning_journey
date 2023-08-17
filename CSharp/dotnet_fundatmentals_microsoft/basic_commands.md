# DotNET Framework Fundamentals

## Create a new `.net console project`

1. Check console template .net framework default with: 

    `dotnet new console -h`

2. Look for `Template options > --framework`

3. Create a new project with one of the following commands:

    `dotnet new console --output HelloWorldProject --framework net7.0`

    or

    `dotnet new console -o HelloWorldProject -f net7.0`
    
    or

    `dotnet new console -o HelloWorldProject`

3. Change directory to the project.

    `cd HelloWorldProject`

4. Check the `csproj` file

5. Run the project with:

    `dotnet run`

6. Build the project with:

    `dotnet build`
    