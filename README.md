# MindRush

A 60-second trivia game built with Blazor (.NET 8). Pick a category, answer as many questions as you can before the clock runs out, then see your score on the results page and the leaderboard.

> Midterm Exam project by <Your Name>, <Course / Section>

## Features

- **Category picker:** choose from 6 categories (Science, Geography, History, Sports, Entertainment, General Knowledge), or play all of them mixed. The category picked on the home page carries over to the game page.
- **60-second rounds:** the timer starts only after you press start. Each correct answer is worth 10 points.
- **Instant feedback:** the game shows whether your answer was right or wrong before moving to the next question.
- **Pause and exit:** the exit button pauses the clock and asks for confirmation.
- **Results page:** shows your score, correct answers and accuracy.
- **Leaderboard:** shows the top players alongside your result.

## Tech stack

- C# / .NET 8
- Blazor Web App (Interactive Server rendering)
- Tailwind CSS (loaded from the CDN in `MainLayout.razor`)
- In-memory sample data, so no database is needed

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- An internet connection (Tailwind and Google Fonts load from CDNs)

## How to run

```bash
git clone https://github.com/emer0r1a/MindRush/
cd MidtermExam
dotnet watch run
```

Then open http://localhost:5062 in your browser.

`dotnet watch` rebuilds and refreshes the page automatically whenever you save a file, so there's no need to restart the app while developing. Press `Ctrl + C` in the terminal to stop it.

To run without hot reload, use `dotnet run --launch-profile http` instead.
In Visual Studio, open `MidtermExam.sln` and press the green run button.

## How to play

1. Click **PLAY NOW** on the home page (optionally pick a category first).
2. Choose your category on the game page and press start.
3. Answer as many questions as you can in 60 seconds.
4. View your results and check the leaderboard.

## Project structure

```
MidtermExam/
├── Components/
│   ├── Layout/        # MainLayout (loads Tailwind)
│   ├── Pages/         # Home, Game (/play), Results, Leaderboard
│   └── UI/            # Reusable pieces: Avatar, BrainBolt, TrophyIcon, BestRunCard
├── Models/            # Category, Question, GameSession, GameSettings, SampleData, ...
├── wwwroot/           # Static files (app.css, favicon)
└── Program.cs
```

## Game settings

Rules live in one place, `Models/GameSettings.cs`: round length (60 s), points per correct answer (10), questions per round, and leaderboard size.

## Known limitations

- Questions and leaderboard entries are sample data stored in memory. Nothing is saved between runs.
- Round results are passed to the Results page through the URL.

## Author

Rea Emerald Sabellita
