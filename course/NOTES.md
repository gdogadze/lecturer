# Notes

## Who this is for
The user is the lecturer, not the student. Lessons are classroom materials: Georgian prose, English identifiers, theory first, then an exercise with immediate feedback. The agent is the lecturer's teacher. Student questions come back through the lecturer.

## Voice
Match `lectures/week-01/`. Short spoken sentences. One idea, then a check. The week-1 deck already exists (`კვირა-01-შესავალი.pptx`). Lesson 1 follows the same argument and the same `Student` demo so the slides and the page do not diverge.

## Course facts
- Sokhumi State University, Informatics master's, COMP M205-1.
- Do not put the lecturer's name on materials.
- Palette from the deck: navy `#10243E`, paper `#F6F3EC`, copper `#B85C38`, teal `#1B5E56`.
- Fonts are the Noto Sans Georgian files copied into `assets/fonts/` so a lecture hall works offline.

## Versions, checked 12 October 2026
- .NET 10 is the active LTS, released 11 November 2025, supported through 14 November 2028.
- .NET 8 and .NET 9 reach end of support on 10 November 2026. .NET 8 is still a valid lab fallback this month.
- Even-numbered releases are LTS (3 years). Odd-numbered releases are STS (2 years). Quality is the same.
- .NET 11 RC1 was a go-live preview with support ending 13 October 2026. Do not teach it. Do not send new projects there.
- Default C# tracks the target framework. The language-version docs illustrate .NET 6 → C# 10 and .NET 9 → C# 13, so .NET 8 → C# 12 and .NET 10 → C# 14. Do not set `LangVersion` to `latest`.
- GitHub's .NET Actions tutorial still shows old samples (.NET 6, `setup-dotnet@v4`). The action README is the current pin: `actions/checkout@v7`, `actions/setup-dotnet@v6`, and `dotnet-version: "10.0.x"`.

## Teaching preferences already visible
- Ask the room who has written C#, Java, or Python, and who is on Mac or Windows, before spending time on `Main`.
- If the hour slips, cut the alias and lambda aside. Keep the primary constructor and the collection expression.
- Week 1 does not start Git. Week 2 does not deploy.
- Week 3 does not open a window and does not start an ASP.NET project. WinUI, WPF, and MAUI are week 4. The web week is later. MVC and MVVM are maps. The lab is constructor injection of `IGradeStore` on the week-2 GradeBook, registered with `Microsoft.Extensions.DependencyInjection` 10.0.13 (checked 19 October 2026). The class library does not reference the container.
- If the hour slips, read the OCP, LSP, and ISP table and move to the container. Keep SRP, DIP, and the three names.
- The published workflow tests week 2, week 3, and week 4 as separate jobs. The week-2 lesson still shows the single-job file students type.
- Week 4 is a spoken comparison, not a project. No MAUI workload, no WPF, WinUI, or WinForms app, no "ასე არა" reveals, no lab, and no homework. The room is Mac and Windows. The talk follows https://www.youtube.com/watch?v=vlrHb5sQk-8 and the Windows developer FAQ. The playground `week-04-exercise` and its CI job still build the old view model. The lesson does not send students there.
- If the hour slips, read the three-framework table and the four choice questions. Skip Uno, Avalonia, React Native, and PWA. Keep the five Fluent names to one sentence.
- Checked 2 November 2026 against Microsoft Learn: new general-purpose Windows desktop apps start on WinUI 3. WPF and WinForms are not deprecated. UWP and WinUI 2 are not formally deprecated; Xbox, HoloLens 2D apps, and the standard Surface Hub stay on UWP and cannot migrate to WinUI 3. WinUI 2 is `Windows.UI.Xaml`. WinUI 3 is `Microsoft.UI.Xaml`. They do not mix. WinUI 3 has no design surface. Use XAML Hot Reload. Microsoft Photos migrated from UWP to WinUI 3. PowerToys Settings and Command Palette are WinUI 3. Most of the Visual Studio UI is WPF. .NET 10 MAUI minimums: Android API 21, iOS 12.2, macOS 12 via Mac Catalyst, Windows 10 1809 or Windows 11 via WinUI 3. MAUI's support clock is not the .NET clock. Official MAUI targets do not include Linux. `{x:Bind}` defaults to OneTime. WPF's Fluent theme starts with .NET 9. WinForms `Application.SetColorMode` is a normal API on .NET 10, Windows 11 only, and does not follow a live theme change. Mica is Windows 11 and falls back to a solid color on Windows 10.
