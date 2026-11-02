# Modern .NET course resources

## Knowledge

- [Article: .NET implementations (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/fundamentals/implementations)
  The three implementations: modern .NET, .NET Framework, and Mono. Use for: week 1, whenever a student treats those names as one product.
- [Policy: .NET and .NET Core support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
  Release type, support length, and end-of-support dates. Last updated 8 September 2026. Use for: which version a new project targets. Re-check before a later semester.
- [Article: Choose between .NET and .NET Framework for server apps](https://learn.microsoft.com/en-us/dotnet/standard/choosing-core-framework-server)
  When an existing app stays on Framework. Use for: the "old Windows app" case, Web Forms, and Workflow.
- [Article: What's new in C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
  Primary constructors, collection expressions, aliases, default lambda parameters. Use for: the syntax week 1 actually types.
- [Article: Configure C# language version](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version)
  Language version follows the target framework. Use for: why `net8.0` and `net10.0` do not default to the same C#.
- [Article: Install .NET on Windows](https://learn.microsoft.com/en-us/dotnet/core/install/windows)
  Visual Studio versus VS Code and the C# Dev Kit, and which Visual Studio version carries which SDK. Use for: the editor section.
- [Article: What is continuous integration](https://learn.microsoft.com/en-us/devops/develop/what-is-continuous-integration)
  Microsoft's definition: build and test on every commit. Use for: week 2's opening.
- [Article: What is continuous delivery](https://learn.microsoft.com/en-us/devops/deliver/what-is-continuous-delivery)
  CI plus automated deployment through environments. Use for: the one section on CD. The lab stops at CI.
- [Tutorial: Building and testing .NET (GitHub Docs)](https://docs.github.com/en/actions/tutorials/build-and-test-code/net)
  Where a workflow file lives, and the shape `checkout` → `setup-dotnet` → `dotnet test`. The sample versions on this page lag. Pin versions from the action README below.
- [README: actions/setup-dotnet](https://github.com/actions/setup-dotnet)
  Current action major, version syntax, and `dotnet-channel: LTS`. Use for: the workflow students commit.
- [Article: Build, test, and deploy .NET projects (Azure Pipelines)](https://learn.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops)
  The same job in Azure DevOps, including the `DotNetCoreCLI@2` task. Use for: the comparison, not a second lab.
- [Book chapter: Jenkins Pipeline](https://www.jenkins.io/doc/book/pipeline/)
  What a `Jenkinsfile` is. Use for: showing that Jenkins runs the same `dotnet test`.
- [Reference: dotnet format](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-format)
  `--verify-no-changes` fails when formatting would edit files. Use for: the code-quality check.
- [Article: GitHub Actions and .NET](https://learn.microsoft.com/en-us/dotnet/devops/github-actions-overview)
  Workflow, job, and step, and which `dotnet` commands belong in a step. Use for: vocabulary.
- [Article: Solid Relevance (Robert C. Martin)](https://blog.cleancoder.com/uncle-bob/2020/10/18/Solid-Relevance.html)
  One sentence each for SRP, OCP, LSP, ISP, and DIP, in the form this course repeats. Use for: week 3's definitions. The 1990s slogan "one method" is the thing this page corrects.
- [Article: The Clean Architecture (Robert C. Martin)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
  The dependency rule: source code dependencies point inward. Use for: why `GradingService` does not name `MemoryGradeStore`.
- [Article: Architectural principles (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles)
  Separation of concerns, single responsibility, and dependency inversion, with the arrow drawn. Use for: the same two principles in Microsoft's words.
- [Article: Common web application architectures (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)
  Clean Architecture as the onion: core defines the interfaces, infrastructure implements them. Use for: the picture, not a four-project lab.
- [Article: Overview of ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-10.0)
  Model, view, controller, and which of them reference the model. Use for: the map. The website itself is a later week.
- [Article: Model-View-ViewModel (Microsoft Learn)](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm)
  The view knows the view model. The view model does not know the view. Use for: week 3's naming. The window is week 4.
- [Article: Dependency injection in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
  DI as the technique for IoC, constructor injection, and `IServiceProvider`. Use for: the lab's vocabulary. Their sample uses the Generic Host. The container underneath is the same `IServiceCollection`.
- [Tutorial: Use dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage)
  Transient is new every time, scoped changes with the scope, singleton is one instance. Use for: the lifetime table. Checked against package 10.0.13 on 19 October 2026.
- [Article: Dependency injection guidelines](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines)
  Prefer the built-in container. Captive dependency is a singleton holding a scoped service. Use for: why the lab's store is singleton and the service is transient, and why Autofac stays a name.
- [Article: Inversion of Control Containers and the Dependency Injection pattern (Martin Fowler)](https://martinfowler.com/articles/injection.html)
  Where the name "dependency injection" comes from, and constructor injection as the form this course types. Use for: the one sentence that separates DI from IoC.
- [FAQ: Windows developer FAQ](https://learn.microsoft.com/en-us/windows/apps/get-started/windows-developer-faq)
  Which window to start: WinUI 3 for a new general-purpose Windows desktop app, WPF and WinForms still supported, UWP not formally deprecated, MAUI on Windows is WinUI 3 underneath. Also names Microsoft Photos, Visual Studio, React Native for Desktop, and Blazor Hybrid. Use for: week 4's choice. Re-check before a later semester.
- [Video: What Is The BEST Windows UI Framework For Your Project](https://www.youtube.com/watch?v=vlrHb5sQk-8)
  Pros, limits, and the four questions that pick a framework. Use for: the shape of the week-4 talk. The March 2025 claim that WinForms has no dark mode is out of date on .NET 10.
- [Article: WinUI 3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/)
  The recommended native Windows UI. C# or C++, Windows 10 1809 and later, Fluent, DirectX. Use for: the WinUI section.
- [Article: Windows Forms overview](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-10.0)
  A form, controls, and a handler for the user's action. Use for: the WinForms side of the comparison.
- [Article: What's new in WinForms for .NET 10](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/whats-new/net100)
  `Application.SetColorMode` is no longer experimental. Dark mode is Windows 11 only and does not track a live theme change. Use for: correcting the 2025 video.
- [Article: WPF overview](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/overview/?view=netdesktop-10.0)
  Resolution-independent, vector-based, hardware-accelerated XAML. Use for: the WPF side of the comparison.
- [Article: x:Bind markup extension](https://learn.microsoft.com/en-us/windows/apps/develop/platform/xaml/x-bind-markup-extension)
  WinUI compiled binding. Default mode is OneTime. Use for: why `Mode=OneWay` is in the one XAML line.
- [Article: Migrate from UWP to the Windows App SDK](https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/migrate-to-windows-app-sdk-ovw)
  UWP and WinUI 3 share XAML ideas and do not share a project. Use for: the one paragraph on migration.
- [Article: Design principles](https://learn.microsoft.com/en-us/windows/apps/design/design-principles)
  Effortless, Calm, Personal, Familiar, Complete + Coherent. Use for: the Fluent names.
- [Article: Typography in Windows](https://learn.microsoft.com/en-us/windows/apps/design/signature-experiences/typography)
  The Windows 11 type ramp. Use for: why a click handler does not pick a font size.
- [Article: XAML theme resources](https://learn.microsoft.com/en-us/windows/apps/design/style/xaml-theme-resources)
  `{ThemeResource}` updates when the theme changes. `{StaticResource}` does not. Use for: light, dark, and contrast.
- [Article: What is .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-10.0)
  One C# and XAML UI, four platforms. Use for: the MAUI definition.
- [Article: Supported platforms for .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/supported-platforms?view=net-maui-10.0)
  Minimum OS versions for `net-maui-10.0`. Checked 2 November 2026. Use for: the platform table. Re-check before a later semester.
- [Article: Handlers](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/handlers/?view=net-maui-10.0)
  A MAUI control maps to a native control. Use for: the one sentence on Android, iOS, and macOS.
- [Policy: .NET MAUI support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/maui)
  MAUI's support clock is not the .NET clock, because of Xcode and the Android SDK. Use for: why the lesson does not copy the .NET LTS date onto MAUI.
- [Page: .NET desktop frameworks](https://dotnet.microsoft.com/en-us/apps/desktop)
  Official blurbs for MAUI, WinUI, and Uno. Use for: Uno's target list.
- [Site: Avalonia](https://avaloniaui.net/)
  The WPF-like cross-platform UI, including Linux. Use for: the Avalonia paragraph.

## Wisdom (Communities)

- [r/dotnet](https://www.reddit.com/r/dotnet/)
  Working .NET developers. Use for: "does this project shape make sense?" after a student has a building repo, and for which of WinUI, WPF, and MAUI fits once the student has said Windows-only or four platforms.
- [r/csharp](https://www.reddit.com/r/csharp/)
  Language questions. Use for: a C# 12 form that compiled but still looks wrong.
- [.NET community page](https://dotnet.microsoft.com/en-us/platform/community)
  Microsoft's own list of live and forum communities. Use for: finding a current Discord or meetup rather than inventing one.
- [Microsoft Q&A, .NET](https://learn.microsoft.com/en-us/answers/tags/19/dotnet)
  Moderated questions against the docs. Use for: SDK install and support-policy arguments.

## Gaps
- A current Georgian textbook that uses the `dotnet` SDK and top-level statements. The Georgian companion the week-1 deck mentions is on Visual Studio 2019 and shows `Main`. Lesson 1 says that out loud.
- A single official page that compares GitHub Actions, Azure Pipelines, and Jenkins for .NET. The comparison in lesson 2 is assembled from the three primary docs above.
- A single official page that names a famous WinForms product the way the FAQ names Visual Studio for WPF and Photos for WinUI 3. The lesson says internal tools and the control market, and does not invent a product.
