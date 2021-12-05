using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MotorcycleNotFoundException : Exception
    {
        public MotorcycleNotFoundException()
        {
        }

        public MotorcycleNotFoundException(string massage)
            : base(massage)
        {
        }
        
        public MotorcycleNotFoundException(string massage, Exception InnerException)
            : base(massage, InnerException)
        {
        }
        
        public MotorcycleNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
