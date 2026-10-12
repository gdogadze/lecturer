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

## Wisdom (Communities)

- [r/dotnet](https://www.reddit.com/r/dotnet/)
  Working .NET developers. Use for: "does this project shape make sense?" after a student has a building repo.
- [r/csharp](https://www.reddit.com/r/csharp/)
  Language questions. Use for: a C# 12 form that compiled but still looks wrong.
- [.NET community page](https://dotnet.microsoft.com/en-us/platform/community)
  Microsoft's own list of live and forum communities. Use for: finding a current Discord or meetup rather than inventing one.
- [Microsoft Q&A, .NET](https://learn.microsoft.com/en-us/answers/tags/19/dotnet)
  Moderated questions against the docs. Use for: SDK install and support-policy arguments.

## Gaps
- A current Georgian textbook that uses the `dotnet` SDK and top-level statements. The Georgian companion the week-1 deck mentions is on Visual Studio 2019 and shows `Main`. Lesson 1 says that out loud.
- A single official page that compares GitHub Actions, Azure Pipelines, and Jenkins for .NET. The comparison in lesson 2 is assembled from the three primary docs above.
