using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal  class DateTimeQueue
    {
        private int _addPosition;
        private int _removePosition;
        private DateTime[] _dateTimes;

        public DateTimeQueue()
        {
            _dateTimes = new DateTime[10];
        }

        public void Enqueue(DateTime value) 
        {
            _dateTimes[_addPosition] = value;
            _addPosition++;
        }

        public DateTime Dequeue() 
        {
            var data= _dateTimes[_removePosition];
            _removePosition++;
            return data;
        }

        public  DateTime Peek() 
        {
            return _dateTimes[_removePosition];
        }
    }
}
