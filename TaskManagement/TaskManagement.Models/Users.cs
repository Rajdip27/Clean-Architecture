using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TaskManagement.Shared;

namespace TaskManagement.Models;
[ExcludeFromCodeCoverage]
public class Users : IEntity
{
    public Users()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Phone=string.Empty;
        Email=string.Empty;
        UserName = string.Empty;
        Password=string.Empty;
        CreateBy=string.Empty;


    }
    /// <summary>
    /// Entity Id
    /// </summary>
    public  int Id { get; set; }
    /// <summary>
    /// Entity CreateDate
    /// </summary>
    public DateTimeOffset CreateDate { get; set; }
    /// <summary>
    /// Entity UpdateDate
    /// </summary>
    public DateTimeOffset? UpdateDate { get; set; }
    /// <summary>
    /// Entity CreateBy
    /// </summary>
    public string CreateBy { get; set; }
    /// <summary>
    /// Entity UpdateBy
    /// </summary>
    public string? UpdateBy { get; set; }
    /// <summary>
    /// Entity Status
    /// </summary>
    public EntityStatus Status { get; set; }
    /// <summary>
    ///  First Name
    /// </summary>
    [MaxLength(50)]
    public string FirstName { get; set; }
    /// <summary>
    /// Last Name
    /// </summary>
    [MaxLength(30)]
    public string LastName { get; set; }
    /// <summary>
    /// Email
    /// </summary>
    [MaxLength(100)]
    public string Email { get; set; }
    /// <summary>
    /// Hash Password
    /// </summary>
    [DataType(DataType.Password)]
    public string Password { get; set; }
    /// <summary>
    /// phone
    /// </summary>
    [MaxLength(20)]
    public string Phone { get; set; }
    /// <summary>
    /// User Name
    /// </summary>
    [MaxLength(100)]
    public string UserName { get; set; }
}