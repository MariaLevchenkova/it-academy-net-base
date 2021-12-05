using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class ObjectQueue
    {
        private int _addPosition;
        private int _removePosition;
        private object [] _object;

        public ObjectQueue()
        {
            _object  = new object [10];
        }

        public void Enqueue(object v)
        {
            _object [_addPosition] = v ;
            _addPosition++;
        }

        public object Dequeue()
        {
            object obi= _object[_removePosition];
            _removePosition++;
            return obi;
        }

        public object Peek()
        {
            return  _object[_removePosition];
        }
    }
}
