namespace MindRush.Models;


/// In-memory sample data so the pages work without a database.
public static class SampleData
{
    /// Id used for "you" on the leaderboard.
    public const int CurrentPlayerId = 0;

    /// Pretend previous best, used to decide if a result is a personal best.
    public const int SamplePreviousBest = 200;

    // ---------- Categories ----------
    private static readonly List<Category> _categories = new()
    {
        new() { Id = 1, Name = "Science", Icon = "🔬", Blurb = "Atoms, space and weird biology", ColorClass = "bg-[#6FC2FF]" },
        new() { Id = 2, Name = "Geography", Icon = "🌍", Blurb = "Capitals, rivers and borders", ColorClass = "bg-[#7ED957]" },
        new() { Id = 3, Name = "History", Icon = "🏺", Blurb = "Empires, eras and plot twists", ColorClass = "bg-[#F9963F]" },
        new() { Id = 4, Name = "Sports", Icon = "⚽", Blurb = "Records, rivalries and rules", ColorClass = "bg-[#FFDE00]" },
        new() { Id = 5, Name = "Entertainment", Icon = "🎬", Blurb = "Movies, music and pop culture", ColorClass = "bg-[#FF8FB8]" },
        new() { Id = 6, Name = "General Knowledge", Icon = "💡", Blurb = "A bit of everything", ColorClass = "bg-white" },
    };

    public static IReadOnlyList<Category> Categories => _categories;

    // ---------- Questions ----------
    private static readonly List<Question> _questions = BuildQuestions();

    public static IReadOnlyList<Question> Questions => _questions;

    private static List<Question> BuildQuestions()
    {
        var list = new List<Question>();

        void Q(int categoryId, string emoji, string text, int correct, params string[] options)
        {
            var q = new Question
            {
                Id = list.Count + 1,
                CategoryId = categoryId,
                Category = _categories.First(c => c.Id == categoryId),
                Emoji = emoji,
                Text = text,
            };
            q.Options = options.Select((t, i) => new AnswerOption
            {
                Id = q.Id * 10 + i,
                QuestionId = q.Id,
                Text = t,
                IsCorrect = i == correct,
                SortOrder = i,
            }).ToList();
            list.Add(q);
        }

        // Science (1)  
        Q(1, "🪐", "Which planet is known as the Red Planet?", 1, "Venus", "Mars", "Jupiter", "Mercury");
        Q(1, "🥇", "What is the chemical symbol for gold?", 1, "Ag", "Au", "Gd", "Go");
        Q(1, "💎", "What is the hardest natural substance on Earth?", 2, "Gold", "Quartz", "Diamond", "Iron");
        Q(1, "🦴", "How many bones are in the adult human body?", 1, "186", "206", "226", "306");
        Q(1, "🌱", "Which gas do plants take in from the air to make food?", 2, "Oxygen", "Nitrogen", "Carbon dioxide", "Helium");
        Q(1, "⚡", "What is the center of an atom called?", 1, "Electron", "Nucleus", "Proton", "Neutron");
        Q(1, "🌡️", "At what temperature (°C) does water freeze?", 1, "0°C", "32°C", "100°C", "-10°C");
        Q(1, "🩸", "Which blood type is known as the universal donor?", 3, "A+", "AB", "O-", "B+");
        Q(1, "💡", "Who is credited with inventing the practical incandescent electric light bulb?", 2, "Nikola Tesla", "Thomas Edison", "Alexander Graham Bell", "Benjamin Franklin");
        Q(1, "🧬", "What does DNA stand for?", 1, "Deoxyribonucleic acid", "Dinitrogen nucleic acid", "Dioxyribose nucleic atom", "Deoxyribose nucleotide agent");

        // Geography (2) 
        Q(2, "🌊", "Which is the largest ocean on Earth?", 3, "Atlantic", "Indian", "Arctic", "Pacific");
        Q(2, "🦘", "What is the capital city of Australia?", 2, "Sydney", "Melbourne", "Canberra", "Perth");
        Q(2, "🏜️", "Which continent is Egypt in?", 1, "Asia", "Africa", "Europe", "South America");
        Q(2, "⛪", "Which is the smallest country in the world by area?", 2, "Monaco", "Malta", "Vatican City", "San Marino");
        Q(2, "🏔️", "Mount Everest is part of which mountain range?", 3, "Andes", "Alps", "Rockies", "Himalayas");
        Q(2, "🗼", "In which city can you find the Eiffel Tower?", 1, "Paris", "London", "Rome", "Berlin");
        Q(2, "🍁", "Which country has the longest coastline in the world?", 2, "Russia", "Canada", "Australia", "USA");
        Q(2, "🐍", "In which South American country is the Amazon Rainforest mostly located?", 1, "Brazil", "Argentina", "Chile", "Colombia");
        Q(2, "🏝️", "What is the largest island in the world?", 3, "Madagascar", "Borneo", "Greenland", "New Guinea");
        Q(2, "🗽", "Which U.S. state is home to the Grand Canyon?", 1, "Arizona", "Nevada", "Utah", "Colorado");

        // History (3) 
        Q(3, "🌙", "In which year did humans first land on the Moon?", 1, "1959", "1969", "1979", "1989");
        Q(3, "🦅", "Who was the first President of the United States?", 1, "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams");
        Q(3, "🔺", "In which country are the Great Pyramids of Giza?", 2, "Mexico", "Peru", "Egypt", "Iraq");
        Q(3, "🚢", "In which year did the Titanic sink?", 1, "1905", "1912", "1920", "1931");
        Q(3, "🧱", "In which year did the Berlin Wall fall?", 2, "1979", "1985", "1989", "1991");
        Q(3, "⚔️", "Who was the famous Carthaginian general who crossed the Alps with elephants?", 1, "Hannibal", "Julius Caesar", "Alexander the Great", "Spartacus");
        Q(3, "👑", "Who was the longest-reigning British monarch before Queen Elizabeth II?", 1, "Queen Victoria", "King George III", "King Henry VIII", "Queen Mary I");
        Q(3, "📜", "In what year was the Magna Carta signed?", 1, "1215", "1492", "1776", "1066");
        Q(3, "🏛️", "The ancient city of Rome was built on how many hills?", 2, "Five", "Seven", "Nine", "Twelve");
        Q(3, "🧭", "Which explorer's expedition was the first to circumnavigate the globe?", 2, "Christopher Columbus", "Ferdinand Magellan", "Vasco da Gama", "Marco Polo");

        // Sports (4) 
        Q(4, "⚽", "How many players per team are on the field in soccer?", 2, "9", "10", "11", "12");
        Q(4, "🏅", "How often are the Summer Olympic Games held?", 2, "Every year", "Every 2 years", "Every 4 years", "Every 5 years");
        Q(4, "🎾", "In tennis, what is a score of zero called?", 1, "Nil", "Love", "Zero", "Duck");
        Q(4, "🏆", "Which country won the first FIFA World Cup in 1930?", 1, "Brazil", "Uruguay", "Italy", "Argentina");
        Q(4, "🔵", "How many rings are on the Olympic flag?", 1, "4", "5", "6", "7");
        Q(4, "🏀", "How many players are on the court for a single team in basketball?", 1, "5", "6", "7", "4");
        Q(4, "⚾", "How many innings are in a standard Major League Baseball game?", 2, "7", "9", "6", "8");
        Q(4, "🏈", "How many points is a touchdown worth in American football?", 2, "3", "6", "7", "2");
        Q(4, "⛳", "What is a score of one stroke under par on a single golf hole called?", 1, "Birdie", "Eagle", "Bogey", "Albatross");
        Q(4, "🥊", "In boxing, how long is a standard single round?", 1, "3 minutes", "2 minutes", "5 minutes", "1 minute");

        // Entertainment (5)
        Q(5, "🤠", "Who is the cowboy hero of Toy Story?", 1, "Buzz", "Woody", "Rex", "Slinky");
        Q(5, "🎤", "Which band performed Bohemian Rhapsody?", 1, "The Beatles", "Queen", "ABBA", "Pink Floyd");
        Q(5, "⚡", "Which Hogwarts house is Harry Potter in?", 2, "Slytherin", "Ravenclaw", "Gryffindor", "Hufflepuff");
        Q(5, "🐀", "Which Pixar film stars a rat who loves to cook?", 1, "Cars", "Ratatouille", "Up", "Coco");
        Q(5, "🦾", "Who plays Iron Man in the Marvel movies?", 1, "Chris Evans", "Robert Downey Jr.", "Chris Hemsworth", "Mark Ruffalo");
        Q(5, "🧙‍♂️", "What is the name of Frodo's sword in The Lord of the Rings?", 1, "Sting", "Anduril", "Glamdring", "Orcrist");
        Q(5, "🦇", "What is Batman's real name?", 1, "Bruce Wayne", "Clark Kent", "Peter Parker", "Tony Stark");
        Q(5, "🎸", "Who is known as the 'King of Pop'?", 1, "Elvis Presley", "Michael Jackson", "Prince", "Freddie Mercury");
        Q(5, "🚢", "Which actor played Jack Dawson in the 1997 film Titanic?", 2, "Brad Pitt", "Leonardo DiCaprio", "Tom Cruise", "Johnny Depp");
        Q(5, "🦖", "Which Steven Spielberg movie features a theme park full of cloned dinosaurs?", 1, "Jurassic Park", "Godzilla", "King Kong", "The Lost World");

        // General knowledge (6) 
        Q(6, "📅", "How many days are in a leap year?", 1, "365", "366", "364", "367");
        Q(6, "🎨", "Mixing blue and yellow paint makes which color?", 2, "Purple", "Orange", "Green", "Brown");
        Q(6, "🐋", "What is the largest animal on Earth?", 1, "Elephant", "Blue whale", "Giraffe", "Great white shark");
        Q(6, "🌎", "How many continents are there?", 2, "5", "6", "7", "8");
        Q(6, "🔷", "How many sides does a hexagon have?", 1, "5", "6", "7", "8");
        Q(6, "🍀", "How many leaves does a traditional lucky shamrock have?", 1, "3", "4", "5", "2");
        Q(6, "⏱️", "How many seconds are in an hour?", 2, "1,800", "3,600", "6,000", "7,200");
        Q(6, "🔤", "How many letters are in the modern English alphabet?", 2, "24", "26", "28", "30");
        Q(6, "♟️", "What is the starting number of pieces for a single player in chess?", 2, "8", "16", "32", "64");
        Q(6, "☕", "Which country is credited with discovering coffee?", 1, "Ethiopia", "Colombia", "Brazil", "Italy");

        return list;
    }

    /// Random questions (optionally from one category) with the A to D options shuffled.
    public static IReadOnlyList<Question> GetRandomQuestions(int count, int? categoryId = null) =>
        _questions
            .Where(q => categoryId is null || q.CategoryId == categoryId)
            .OrderBy(_ => Random.Shared.Next())
            .Take(count)
            .Select(q => new Question
            {
                Id = q.Id,
                CategoryId = q.CategoryId,
                Category = q.Category,
                Text = q.Text,
                Emoji = q.Emoji,
                Options = q.Options.OrderBy(_ => Random.Shared.Next()).ToList(),
            })
            .ToList();

    // ---------- Leaderboard ----------
    private static readonly (int Id, string Name, int Score)[] _players =
    {
        (1, "Alex", 420), (2, "Jamie", 390), (3, "Taylor", 350), (4, "Morgan", 330), (5, "Riley", 310),
        (6, "Casey", 290), (7, "Jordan", 270), (8, "Sam", 250), (9, "Quinn", 230), (10, "Drew", 210),
    };

    /// Top players by best score, with the current player mixed in if they have played.
    /// Tied scores share a rank (1, 2, 2, 4).
    public static List<LeaderboardEntry> GetLeaderboard(int top, GameSession? mine = null)
    {
        var rows = _players.Select(p => (p.Id, p.Name, p.Score)).ToList();
        if (mine is not null)
            rows.Add((CurrentPlayerId, mine.Player?.DisplayName ?? "You", mine.Score));

        var ordered = rows
            .OrderByDescending(r => r.Score)
            .ThenBy(r => r.Id == CurrentPlayerId) // on a tie, "you" sits below
            .Take(top)
            .ToList();

        var entries = new List<LeaderboardEntry>(ordered.Count);
        var rank = 0;
        for (var i = 0; i < ordered.Count; i++)
        {
            if (i == 0 || ordered[i].Score != ordered[i - 1].Score) rank = i + 1;
            entries.Add(new LeaderboardEntry(rank, ordered[i].Id, ordered[i].Name, ordered[i].Score));
        }
        return entries;
    }

    /// <summary>The current player's rank for a given best score, or null if they have not played.</summary>
    public static PlayerStanding? GetStanding(int? bestScore) =>
        bestScore is int best
            ? new PlayerStanding(best, _players.Count(p => p.Score > best) + 1)
            : null;
}
