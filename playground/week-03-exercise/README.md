# Week 3 exercise — GradeBook

Reference solution for the [architecture and SOLID](https://github.com/gdogadze/lecturer/blob/main/course/lessons/0003-solid-architecture.html) lab.

```bash
cd playground/week-03-exercise
dotnet test --configuration Release
dotnet run --project GradeBook.App
```

`dotnet run` prints `9`. The class library does not reference the container. Registration lives in `GradeBook.App` and in one test.
