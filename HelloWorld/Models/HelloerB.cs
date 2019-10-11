namespace HelloWorld.Models
{
    public class HelloerB : IHelloer
    {
        public string CurrentName => nameof(HelloerB);

        public string SayHello()
        {
            return $"Hello from {nameof(HelloerB)}";
        }
    }
}
