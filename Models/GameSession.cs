using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MindRush.Models;

[Table("game_sessions")]
public class GameSession : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("player_name")]
    public string PlayerName { get; set; } = "";

    [Column("category_name")]
    public string? CategoryName { get; set; }

    [Column("score")]
    public int Score { get; set; }

    [Column("correct_count")]
    public int CorrectCount { get; set; }

    [Column("answered_count")]
    public int AnsweredCount { get; set; }

    [Column("duration_seconds")]
    public int DurationSeconds { get; set; } = 60;

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at", ignoreOnInsert: true, ignoreOnUpdate: true)]
    public DateTime? CreatedAt { get; set; }
}