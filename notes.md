# C# and .NET Learning
## C# vs .Net
- C# is a programming language
- .NET is a framework for building applications on Windows
    - CLR
    - Class Library

**Big Takeaway**

C# is the programming language, while .NET is the environment which allows all operating systems(Windows,MacOS, Linux) and hardwares (64-bit or 32-bit processor) to run your program.
## CLR(Common Language Run-time)
When C# is compiled it is complied as IL(Intermideiate Language) Code which then needs to be understood by the system the application is running on or the Native Code, thats where Common Language Run-time comes in.
## Architecture of .NET Applications
Building blocks of Classes
- Class
    - Data(Attributes)
    - Methods/Functions (do things for us)
- Car
    - **Data**
    - Make
    - Model
    - Color
    - **Methods/Functions**
    - Start
    - Move

Lots of Classes pile up we need a way to organize them
Namespace is a container for related Classes
- Data
- Graphics
- Functions

Namespaces need an container too, which are Assembly's
and Assembly's need a container too, which is the Application.

Sooooo, it goes
    -> Application -> Assembly -> Namespace -> Classes 
## Our First #C Application
Refer to HelloWorld
### How to create your first project
To make a new .NET project in VS Code, ensure you have the .NET SDK and the C# Dev Kit extension installed. Open VS Code, press Ctrl + Shift + P (or Cmd + Shift + P on Mac), type .NET: New Project, select your template (e.g., Console App), choose a location, and name it.

### What is a literal value
A literal value is a value that never changes, it is constant. 
using single quotes '' will only allow a single letter, because it looks for char as the data type (alphanumeric value)

## C# vs F#
**What is the Difference between the two?**

C# is an object oriented model while F# is based on functional programming. Meaning C# focuses on uses classes, objects, and interfaces to organize applications. While, F# is focusing on functions, using functions to deal with data.

## .NET application frameworks and libraries
Software is built in layers.

Starting with the computers hardware

To the operating system

To the development and running of applications

To the application frameworks and libraries of functionality to build rich applications fast

A code library stores functionality for a specific purpose into a single assembly. Libraries allow you to provide all kinds of functionality in your applications. Simply, reference those assemblies and call the methods you need. This way you are building on top of existing developers work to save time and energy.

An application framework combines several libraries, so you can build entire applications for a specific purpose. Application frameworks are known as app models. .Net application frameworks are available for popular app models like web, desktop and mobile, and game dev.

## .NET runtime
The .NEt runtime is like protective bubble that provides a run environment for your applications.
The .NET runtime:
- Complies intermediate code into binary format on the first run. The binary format is specific to the computer it's running on.
- Locates the programs entry point and begins running each instruction in the proper order
- Manages computer memory and network access. It works with the operating system to save memory for your application. When your application no longer needs something saved it will do a garbage collection feature which releases that memory back to the operating system without any instructions from the developer.
- Will block any software that may have malicious intent

## Adding Dependencies
**What is a dependency**

A package dependency is a third-party library. It's a piece of reuseable code that accomplishes something and that you add to your application. Your application is now *depending* on that third-party library.

**How to Add one**

Using the .NET CLI enter this command in the terminal, this will add it to your .csproj file
`dotnet add package <name of package>`

Once installed, to see what packages are installed (the top-level packages only)
`dotnet list package`

to include ALL dependencies including transitive (ones that are in the main dependency)
`dotnet list package --include-transitive`

To restore any dependencies when clone a project
`dotnet restore`

but in most cases you will not need this, by running the `new`, `run`, or `build` commands NuGet will restore any dependencies when necessary.

To remove a dependency/package, this will remove the package from your projects .csproj file
`dotnet remove package <name of dependency>`

## Starting a .NET project

Create a Program.cs file in your project folder
`dotnet new console -n MyFirstApp`

To run your project
`dotnet run`

## Updating a package
`<!-- Accepts any version 6.1 and later. -->
<PackageReference Include="ExamplePackage" Version="6.1" />

<!-- Accepts any 6.x.y version. -->
<PackageReference Include="ExamplePackage" Version="6.*" />
<PackageReference Include="ExamplePackage" Version="[6,7)" />

<!-- Accepts any later version, but not including 4.1.3. Could be
     used to guarantee a dependency with a specific bug fix. -->
<PackageReference Include="ExamplePackage" Version="(4.1.3,)" />

<!-- Accepts any version earlier than 5.x, which might be used to prevent pulling in a later
     version of a dependency that changed its interface. However, we don't recommend this form because determining the earliest version can be difficult. -->
<PackageReference Include="ExamplePackage" Version="(,5.0)" />

<!-- Accepts any 1.x or 2.x version, but not 0.x or 3.x and later. -->
<PackageReference Include="ExamplePackage" Version="[1,3)" />

<!-- Accepts 1.3.2 up to 1.4.x, but not 1.5 and later. -->
<PackageReference Include="ExamplePackage" Version="[1.3.2,1.5)" />`


