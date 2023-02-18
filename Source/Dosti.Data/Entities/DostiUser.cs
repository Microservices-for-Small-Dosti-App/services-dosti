namespace Dosti.Data.Entities;

public class DostiUser : BaseEntity
{
    public string UserName { get; set; } = string.Empty;

    public string KnownAs { get; set; } = string.Empty;
}
