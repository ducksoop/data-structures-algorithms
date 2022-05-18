namespace Algorithms.Lib
{
    public class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next { get; set; } = null!;
        public DoublyLinkedNode<T> Previous { get; set; } = null!;

        public T Value { get; set; }

        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
}
