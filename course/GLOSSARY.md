# Glossary for COMP M205-1

Canonical words for this course. Lessons use these and not their near-synonyms.

## Terms

**ენა (C#)**:
The language a program is written in.
_Avoid_: .NET, Visual Studio, when you mean the language

**პლატფორმა (.NET)**:
The runtime and libraries that build and run that program.
_Avoid_: Core, when you mean a new project. Framework, when you mean today's .NET

**რედაქტორი (IDE)**:
The program where the text is written. Visual Studio, Rider, VS Code, and Cursor are editors.
_Avoid_: გარემო, for the editor. That word is already doing too much

**SDK**:
The install a developer needs in order to create and build. It includes the runtime.
_Avoid_: Runtime, when `dotnet new` must work

**Runtime**:
The install that only runs a built program.
_Avoid_: SDK

**LTS**:
A release with three years of patches. Even-numbered releases are LTS.
_Avoid_: "the stable one." STS is the same quality with a shorter clock

**STS**:
A release with two years of patches. Odd-numbered releases are STS.
_Avoid_: Current

**სამიზნე (TargetFramework)**:
The `net10.0` or `net8.0` line in the project file. It chooses the platform and the default C# version.
_Avoid_: LangVersion latest

**პირველადი კონსტრუქტორი (primary constructor)**:
Constructor parameters written on the type name. On a class they are parameters, not properties, until the class assigns them.
_Avoid_: record, when you mean an ordinary class

**კოლექცია კვადრატულ ფრჩხილებში (collection expression)**:
The `[...]` form. The type on the left decides which collection is created. `..` spreads another collection into it.
_Avoid_: array initializer, for this syntax

**CI**:
Building and testing on every change to the shared code.
_Avoid_: deploy, CD

**CD**:
CI plus taking a build that passed and running it in an environment.
_Avoid_: CI

**workflow**:
The YAML file that describes the steps. In GitHub it lives in `.github/workflows/`.
_Avoid_: pipeline, for the file. Jenkins calls the file a pipeline too. There the filename is `Jenkinsfile`

**pipeline**:
A run of that file: the steps actually executing.
_Avoid_: workflow, for the run
