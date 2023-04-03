namespace MyDataStructures
{
    class ListNode<T>
    {
        public ListNode<T> Previous { get; set; }
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            Data = data;
        }

    }
}
