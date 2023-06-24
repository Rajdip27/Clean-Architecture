
namespace TaskManagement.Shared.Extension;

public static class StringExtensions
{
    public static bool IsNull(this string value) => 
        string.IsNullOrWhiteSpace(value);
    public static void IsNull(this object obj,Action action)
    {
        if (obj is null)
            return;
        action.Invoke();
    }
}
