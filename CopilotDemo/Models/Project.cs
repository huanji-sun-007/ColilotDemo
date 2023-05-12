using System.ComponentModel.DataAnnotations;

/// <summary>
/// Project
/// </summary>
public class Project
{
    /// <summary>
    /// ProjectId
    /// </summary>
    [Key]
    public Guid ProjectId { get; set; }

    /// <summary>
    /// ProjectName
    /// </summary>
    public string ProjectName { get; set; } = string.Empty;

    /// <summary>
    /// CreatedDate
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// ModifiedDate
    /// </summary>
    public DateTime ModifiedDate { get; set; }
}