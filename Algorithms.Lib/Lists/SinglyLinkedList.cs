﻿using System.Collections;

namespace Algorithms.Lib.Lists
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }
        public Node<T>? Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T>? node)
        {
            // save off the current head
            Node<T>? temp = Head;

            Head = node;

            // shifting the former head
            Head!.Next = temp!;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T>? node)
        {
            if (IsEmpty)
                Head = node;
            else
                Tail!.Next = node!;

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty) throw new InvalidOperationException();

            Head = Head?.Next;
            if (Count == 1) Tail = null;

            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty) throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                // find the penultimate node
                var current = Head;
                while (current?.Next != Tail)
                {
                    current = current?.Next;
                }

                current!.Next = null!;
                Tail = current;
            }

            Count--;
        }

        public bool IsEmpty => Count == 0;
        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
