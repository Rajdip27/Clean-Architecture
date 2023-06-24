namespace TaskManagement.Shared;

public interface IEntity<T> where T : IEquatable<T>
 {
    T Id { get;set; }
    DateTimeOffset CreateDate { get; set; }
    DateTimeOffset ? UpdateDate { get; set; }
    string CreateBy { get; set; }
    string ?UpdateBy { get; set; }
    EntityStatus Status { get; set; }
 }
public interface IEntity : IEntity<int> { }
