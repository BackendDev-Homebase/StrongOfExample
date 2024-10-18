using StrongOf;

namespace StrongOfExample;

public class UserId(Guid Value) : StrongGuid<UserId>(Value);
public class Kilograms(int Value) : StrongInt32<Kilograms>(Value);
public class Age(int Value) : StrongInt32<Age>(Value);
public class UserName(string Value) : StrongString<UserName>(Value);

internal class Program
{
    static void Main(string[] args)
    {
        MethodExample();
        Console.WriteLine(Compare());
        IsNullOrEmptyExample();
    }

    private static void MethodExample()
    {
        var userName = new UserName("Batman");

        // Can access any method that is defined in the underlying type
        var lowerUserName = userName.ToLower();
    }


    private static bool Compare()
    {
        var userName1 = new UserName("Batman");
        var userName2 = "Batman";
        var result = userName1 == userName2;
        return result;
    }

    public static void IsNullOrEmptyExample()
    {
        UserName? userName = null;

        // Instead of string.IsNullOrEmpty() (extension method on type string)
        if (Strong.IsNullOrEmpty(userName))
        {
            userName = new UserName("Batman");
        }
    }
}
