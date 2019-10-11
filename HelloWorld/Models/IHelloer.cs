namespace HelloWorld.Models
{
    public interface IHelloer
    {
        string CurrentName { get; }
        string SayHello();
    }
}
