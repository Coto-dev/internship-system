namespace Internship_system.DAL.Data.Entities;

public class Internship {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Student Student { get; set; }
    public Company Company { get; set; }
    public List<PracticeDiary> PracticeDiaries { get; set; } = [];
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? EndedAt { get; set; }
    public string? OrderNumber { get; set; } // номер приказа
}