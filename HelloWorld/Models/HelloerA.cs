namespace HelloWorld.Models
{
    public class HelloerA : IHelloer
    {
        public string CurrentName => nameof(HelloerA);

        public string SayHello()
        {
            return $"Hello from {nameof(HelloerA)}";
        }
    }
}
