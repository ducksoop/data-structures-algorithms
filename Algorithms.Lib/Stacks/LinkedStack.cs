using System.Collections;
using Algorithms.Lib.Lists;

namespace Algorithms.Lib.Stacks
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> _list = new();

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        public void Pop()
        {
            if (IsEmpty) throw new InvalidOperationException();

            _list.RemoveFirst();
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException();

            return _list.Head!.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty => Count == 0;
        public int Count => _list.Count;
    }
}