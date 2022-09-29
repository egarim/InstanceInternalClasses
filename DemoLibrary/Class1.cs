namespace DemoLibrary
{
    internal class Class1 : IMyInterface
    {
        public string Test()
        {
            return "Hello world";
        }
    }
    public class Class2 
    {
     
    }
    internal interface IMyInterface
    {
        string Test();

    }
}