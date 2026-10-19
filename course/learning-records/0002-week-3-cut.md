# Week 3 is the arrow, not a window

Week 3 teaches SOLID and the three syllabus architectures as one dependency direction, and the lab is constructor injection of `IGradeStore` into `GradingService` with the built-in container. MVC is not an ASP.NET project this week. MVVM is not a XAML window. WinUI, WPF, and MAUI stay in week 4. The class library does not reference `Microsoft.Extensions.DependencyInjection`.

**Evidence**: The syllabus puts architectural patterns, SOLID, MVC, MVVM, Clean Architecture, DI, and IoC in week 3, and puts WinUI, WPF, and MAUI in week 4. The room is Mac and Windows, so a WPF lab would not run for everyone. The lecturer asked for the week-3 topic as the syllabus states it.

**Implications**: Do not open week 4 by re-teaching the container. The window binds to a view model that already does not know the view. If a lab shows that `GradingService` still constructs `MemoryGradeStore`, week 4 waits.
