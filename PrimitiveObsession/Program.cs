namespace PrimitiveObsession
{
    public class User(int userId, string name, int age, int height, int weight)
    {
        public int UserId { get; set; } = userId;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int Height { get; set; } = height;
        public int Weight { get; set; } = weight;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var userId = 1;
            var name = "Batman";
            var age = 47;
            var height = 183;
            var weight = 84;

            // Parameters "weight" and "height" are swapped
            // No compiler error
            var user = new User(userId, name, age, weight, height);
        }
    }
}
