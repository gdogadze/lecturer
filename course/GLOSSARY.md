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

## Architecture

**SRP**:
A type has one reason to change.
_Avoid_: one method, one file

**OCP**:
A module can gain behavior by adding a type, while the code that is already right stays unedited.
_Avoid_: never edit anything

**LSP**:
An implementation of an interface must not surprise the code that uses the interface.
_Avoid_: inheritance, when you mean any subtype

**ISP**:
An interface stays small enough that a caller does not depend on methods it does not use.
_Avoid_: one method per interface, as a goal

**DIP**:
High-level code depends on an abstraction. The concrete type implements that abstraction and stays outside.
_Avoid_: dependency injection, when you mean the direction of the arrow

**Dependency Injection**:
The object a class needs arrives through the constructor. The class does not construct it.
_Avoid_: service locator, `new` of a collaborator

**IoC**:
Some outer code builds the object graph. The class being called does not.
_Avoid_: Dependency Injection, when you mean the whole inversion. DI is the technique. IoC is the result

**კონტეინერი (IServiceProvider)**:
The object that creates registered services and passes them to constructors.
_Avoid_: Docker, server, host

**composition root**:
The one place that registers concrete types. In this course it is `Program.cs`.
_Avoid_: the service class, the test that passes a store by hand

**transient**:
A new instance on every request from the container.
_Avoid_: scoped, singleton

**scoped**:
One instance for a scope. In a web app the scope is one request.
_Avoid_: singleton, transient

**singleton**:
One instance for the life of the container.
_Avoid_: static, when you mean a registered service

**MVC**:
Model, view, and controller. The view and the controller depend on the model.
_Avoid_: MVVM

**MVVM**:
Model, view, and view model. The view knows the view model. The view model does not know the view.
_Avoid_: MVC, code-behind

**Clean Architecture**:
Business rules sit in the center. Source dependencies point inward.
_Avoid_: a four-project template, when you mean the dependency rule

**dependency rule**:
Code in an inner circle does not name a type from an outer circle.
_Avoid_: layer, when the direction is missing
