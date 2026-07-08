# C# and .NET Learning
## C# vs .Net
- C# is a programming language
- .NET is a framework for building applications on Windows
    - CLR
    - Class Library
## CLR(Common Language Run-time)
When C# is compiled it is complied as IL(Intermideiate Language) Code which then needs to be understood by the system the application is running on or the Native Code, thats where Common Language Run-time comes in.
## Architecture of .NET Applications
Building blocks of Classes
    - Class
        -Data(Attributes)
        -Methods/Functions (do things for us)
    -Car
        - **Data**
        -Make
        -Model
        -Color
        - **Methods/Functions**
        -Start
        -Move
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