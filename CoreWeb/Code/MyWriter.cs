using System;
using System.Security.Principal;

namespace CoreWeb.Code
{
    public interface IMyWriter
    {
        void ToConsole(string txt);
    }

    public class MyWriter : IMyWriter
    {
        private Guid _Id;

        public MyWriter(Guid id)
        {
            _Id = id;
        }

        public MyWriter() : this(Guid.NewGuid()) { }

        public void ToConsole(string txt)
        {
            Console.WriteLine($"[{_Id}] - {txt}");
        }
    }

    public class MyWriter2 : IMyWriter
    {
        private Guid _Id;

        public MyWriter2(Guid id)
        {
            _Id = id;
        }

        public MyWriter2() : this(Guid.NewGuid()) { }

        public void ToConsole(string txt)
        {
            Console.WriteLine($"[{_Id}] - {txt.ToUpper()}");
        }
    }
}
