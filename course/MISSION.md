# Mission: Teach the modern .NET course

## Why
Master's students at Sokhumi State University need to leave COMP M205-1 able to build, check, and explain a real .NET project. The first two weeks exist so that later work (architecture, cloud, data, APIs, the defended project) sits on a platform they can actually run and a pipeline that tells them when it breaks.

## Success looks like
- A student can separate C#, the .NET platform, and the editor, and can start a new project on the supported .NET release.
- A student can write a small program that uses a C# 12 primary constructor and a collection expression, and can run it with `dotnet run`.
- A student can put `dotnet test` on every push with a GitHub Actions workflow, and can say what Azure Pipelines and Jenkins do that is the same job.
- Later weeks can assume this floor and move to architecture, without re-teaching the SDK.
- A student can name the one reason a type should change, and can pass an `IGradeStore` through a constructor instead of constructing the store inside the service.
- A student can register that store as a singleton and the service as transient in `Microsoft.Extensions.DependencyInjection`, and can say which way the arrow points in MVC, MVVM, and Clean Architecture.
- A student can tell WinForms, WPF, WinUI 3, UWP, and MAUI apart, can say which one fits a Windows-only app, a phone-and-desktop app, or an existing WPF codebase, and can name Visual Studio as a WPF app and Microsoft Photos as a WinUI 3 app.

## Constraints
- Each week is a 2-hour lecture plus a 1-hour lab.
- Language of instruction is Georgian. Technical names stay in English, as in the week-1 slide deck.
- Students may know Java, Python, or basic OOP. Do not assume C# syntax.
- The room mixes Windows and Mac. The lecturer demos from a Mac. Full Visual Studio is the Windows editor; Rider, VS Code, and Cursor are accepted when `dotnet --version` works.
- The syllabus names .NET 8+ and C# 12. As of 12 October 2026, new work targets .NET 10. .NET 8 remains an acceptable lab fallback. C# 12 syntax is the required language floor because it builds on both.
- AI may explain an error. A student who cannot explain the code does not yet own it. Quizzes and exams are without tools.

## Out of scope
- Async, cloud deploy, EF Core, and API security. Those are later weeks. Week 4 compares the Windows UI frameworks and does not install the MAUI workload or create a WPF, WinUI, or WinForms project. A website is still later.
- A second IoC container. Autofac and the rest stay names. The lab registers the built-in container.
- Installing Jenkins, or standing up an Azure DevOps organization, in week 2.
- A tour of C# 13 and C# 14. Name the version map. Teach the two C# 12 forms students will type.
