using System.Collections;

//PopPeek
namespace MyDataStructures
{
    class Stack<T> : IEnumerable<T>
    {
        Node<T> _head;
        int _count;
        
        public bool IsEmpty => _head is null;
        public int Count => _count;

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = _head;
            _head = node;
            _count++;
        }
        public T Pop()
        {   
            IsEmptyCheck();

            Node<T> node = _head;
            _head = _head.Next;
            _count--;
            return node.Data;
        }
        public T Peek()
        {
            IsEmptyCheck();
            return _head.Data;
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
        private void IsEmptyCheck()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
