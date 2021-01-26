using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class TextEditor : ITextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }
}
