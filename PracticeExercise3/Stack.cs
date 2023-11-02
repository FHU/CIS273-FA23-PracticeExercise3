using System;
namespace PracticeExercise3
{
	public class Stack <T>: IStack<T>
	{
        private LinkedList<T> linkedList;

		public Stack()
		{
            linkedList = new LinkedList<T>();
		}

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            if( IsEmpty )
            {
                throw new EmptyStackException("The stack is empty.");
            }

            T top = linkedList.First.Value;

            linkedList.RemoveFirst();

            return top;
        }

        public void Push(T item)
        {
            linkedList.AddFirst(item);
        }

        public override string ToString()
        {
            string result = "";

            var currentNode = linkedList.Last;

            while (currentNode != null)
            {
                result += currentNode.Value + "\n";
                currentNode = currentNode.Previous;
            }

            return result;
        }
    }
}

