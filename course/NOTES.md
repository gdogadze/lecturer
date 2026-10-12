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
