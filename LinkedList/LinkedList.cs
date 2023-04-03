using System.Collections;

namespace MyDataStructures
{
    class LinkedList<T> : IEnumerable<T>
    {
        private int _count;
        private Node<T> _head;
        private Node<T> _tail;
        public Node<T> First => _head;
        public Node<T> Last => _tail;

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        public void Add(T data)
        {
            Node<T> node = new(data);
            if (_head == null) _head = node;
            else
            {
                _tail.Next = node;
            }

            _tail = node;
            _count++;
        }
        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous is null)
                    {
                        _head = _head.Next;
                        if (_head is null)
                            _tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current.Next is null)
                            _tail = previous;
                    }
                    _count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        public void Prepend(T data)
        {
            Node<T> node = new(data);
            node.Next = _head;
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
            Node<T> current = _head;
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
            Node<T> current = _head;
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
