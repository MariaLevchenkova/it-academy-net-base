using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }
        public NotFoundException(string massage)
            : base(massage)
        {
        }
        public NotFoundException(string massage, Exception InnerException)
            : base(massage, InnerException)
        {
        }
        public NotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
