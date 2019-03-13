using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JobChannelMobile
{
    [Serializable]
    public class ExceptionDAO : Exception
    {
        public ExceptionDAO() { }
        public ExceptionDAO(string message) : base(message) { }
        public ExceptionDAO(string message, Exception inner) : base(message, inner) { }
        protected ExceptionDAO(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
