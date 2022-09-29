using DemoLibrary;
using ReflectionMagic;

namespace InstanceInternalClasses
{
    public class Tests
    {
        private const string FullQualifiedNameInterface = "DemoLibrary.IMyInterface";
        private const string FullQualifiedNameClass = "DemoLibrary.Class1";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetInternalTypeFromAssembly()
        {
            Type InternalInterfaceType = typeof(Class2).Assembly.GetType(FullQualifiedNameInterface);

            
            if(InternalInterfaceType?.FullName== FullQualifiedNameInterface)
                Assert.Pass();
            else
                Assert.Fail();  

        }
        [Test]
        public void CreateAnInstanceFromInternalAndAccessMethods()
        {
            var Class1Type = typeof(Class2).Assembly.GetType(FullQualifiedNameClass);

            var Class1Intance = Activator.CreateInstance(Class1Type);

            dynamic dynamic = Class1Intance.AsDynamic();
            var ResultFromMethod = dynamic.Test();

            if (ResultFromMethod.ToString() == "Hello world")
                Assert.Pass();
            else
                Assert.Fail();

        }
    }
}