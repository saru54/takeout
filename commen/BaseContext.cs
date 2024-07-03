using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commen
{
    public class BaseContext
    {
        private ThreadLocal<long> ThreadLocal = new ThreadLocal<long>();
        public void SetCurrentId (long id)
        {
            ThreadLocal.Value = id;
        }
        public long GetCurrentId()
        {
            return ThreadLocal.Value;
        }
    }
}
