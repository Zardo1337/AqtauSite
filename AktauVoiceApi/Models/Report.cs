namespace AktauVoiceApi.Models;

public class Report
{
    public int Id { get; set; }
    public string District { get; set; } = "";
    public string House { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "other";
    public string Status { get; set; } = "new";
    public bool IsValid { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}