using NUnit.Framework;
using Facade;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FacadeTest()
        {
            TextEditor textEditor = new TextEditor();
            Compillier compiller = new Compillier();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}