using System;
using System.Collections.Generic;

namespace PracticeExercise3
{
	public class Queue<T>: IQueue<T>
	{
        private LinkedList<T> linkedList;

		public Queue()
		{
            linkedList = new LinkedList<T>();
		}

        public T First => throw new NotImplementedException();

        public T Last => throw new NotImplementedException();

        public int Length => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            T first = linkedList.First.Value;
            linkedList.RemoveFirst();

            return first;
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}

