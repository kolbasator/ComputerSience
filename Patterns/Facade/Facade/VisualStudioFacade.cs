using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public  class VisualStudioFacade : IVisualStudioFacade
    {
        TextEditor textEditor;
        Compillier compiller;
        CLR clr;
        public VisualStudioFacade(TextEditor te, Compillier compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }
        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }
}
