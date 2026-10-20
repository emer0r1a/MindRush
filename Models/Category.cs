using System.ComponentModel.DataAnnotations;

namespace MindRush.Models;

/// A trivia topic shown on the home page tiles and on the game's question card.
public class Category
{
    public int Id { get; set; }

    [Required, MaxLength(40)]
    public string Name { get; set; } = "";

    /// Emoji shown on the category tile.
    [MaxLength(8)]
    public string Icon { get; set; } = "";

    [MaxLength(80)]
    public string Blurb { get; set; } = "";

    /// Tailwind background utility for this category, e.g. "bg-[#6FC2FF]".
    [MaxLength(40)]
    public string ColorClass { get; set; } = "bg-white";

    public List<Question> Questions { get; set; } = new();
}
