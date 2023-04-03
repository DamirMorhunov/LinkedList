using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructures
{
    class List<T> : IEnumerable<T>
    {   
        private int _count;
        private ListNode<T> _head;
        private ListNode<T> _tail;


        public ListNode<T> First => _head;
        public ListNode<T> Last => _tail;
        public int Count => _count;
        public bool IsEmpty => _count == 0;

        public void Add(T data)
        {
            ListNode<T> node = new(data);
            if (_head == null) _head = node;
            else
            {
                _tail.Next = node;
                node.Previous = _tail;             
            }

            _tail = node;
            _count++;
        }
        public bool Remove(T data)
        {
            ListNode<T> current = _head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if(current.Previous is null)
                    {
                        _head = current.Next;
                        _head.Previous = null;
                    }
                    else if (current.Next is null)
                    {
                        _tail = current.Previous;
                        _tail.Next = null;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    _count--;
                    return true;
                }
                current = current.Next;             
            }          
            return false;
        }
        public void Prepend(T data)
        {
            ListNode<T> node = new(data);
            node.Next = _head;
            _head.Previous = node;
            _head = node;
            if (_count == 0)
                _tail = _head;
            _count++;
        }
        public void Clear()
        {
            _head = _tail = null;
            _count = 0;
        }
        public bool Contains(T data)
        {
            ListNode<T> current = _head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
