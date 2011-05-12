using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.core.stubs
{
    public static class StubFactory<T> where T: new()
    {
        public static T Create()
        {
            return new T();
        }
    }
}
