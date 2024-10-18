namespace ExtensionTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class ExtensionTypes
    {
        public explicit extension UserId for Guid
            {
        }
}
}
