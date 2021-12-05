using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class CustomQueue<T> where T : class
    {
        private int _addPosition;
        private int _removePosition;
        private T[]  _tqueue;

        public CustomQueue()
        {
            _tqueue =new T[10];
        }

        public void Enqueue(T value)
        {
            _tqueue [_addPosition] =value ;
            _addPosition++;
        }

        public T Dequeue()
        {
            T ast = _tqueue[_removePosition];
            _removePosition++;
            return  ast;
        }

        public T Peek()
        {
            return _tqueue[_removePosition];
        }
    }
}

