# Week 4 exercise — GradeBook window, without a window

Kept so CI still builds. The [Windows UI](https://github.com/gdogadze/lecturer/blob/main/course/lessons/0004-windows-ui.html) lesson does not assign it.

```bash
cd playground/week-04-exercise
dotnet test --configuration Release
dotnet run --project GradeBook.App
```

`dotnet run` prints `საშუალო: 9`. `GradeBook` and `GradeBook.ViewModels` do not reference WPF, WinUI, WinForms, or MAUI. The week-3 container test still lives in the test project.
