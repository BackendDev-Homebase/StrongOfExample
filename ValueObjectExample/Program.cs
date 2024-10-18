namespace ValueObjectExample;

public record UserId(int Value);
public record class UserName(string Value);
public record class Age(int Value);
public record class Centimeters(int Value);
public record class Kilograms(int Value);

public class User(UserId userId, UserName name, Age age, Centimeters height, Kilograms weight)
{
    public UserId UserId { get; set; } = userId;
    public UserName Name { get; set; } = name;
    public Age Age { get; set; } = age;
    public Centimeters Height { get; set; } = height;
    public Kilograms Weight { get; set; } = weight;
}

internal class Program
{
    static void Main(string[] args)
    {
        CreationExample();
        MethodExample();
        Console.WriteLine(CompareExample());
    }

    private static void CreationExample()
    {
        UserId userId = new(1);
        UserName name = new("Batman");
        Age age = new(47);
        Centimeters height = new(183);
        Kilograms weight = new(84);

        // Parameters "weight" and "height" are swapped.
        // Compile error CS1503
        var user = new User(userId, name, age, weight, height);
    }

    private static void MethodExample()
    {
        var userName = new UserName("Batman");

        // Method does not exist.
        var lowerUserName = userName.ToLower();
    }

    private static bool CompareExample()
    {
        var userName1 = new UserName("Batman");
        var userName2 = "Batman";

        // No out-of-the-box comparison possible
        // Compile error CS0019
        var result = userName1 == userName2;
        return result;
    }
}