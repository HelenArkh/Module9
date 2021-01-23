using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    public class MyException:Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
}
