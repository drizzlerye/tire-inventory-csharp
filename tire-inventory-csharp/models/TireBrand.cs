public class TireBrand
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public Guid ModifiedBy { get; set; }
}