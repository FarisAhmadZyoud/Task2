using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack
	{
		

		public void PushTostack(Stack<string> myStack)
        {

            myStack.Push("one");
			myStack.Push("two");
			myStack.Push("three");
			myStack.Push("four");
			myStack.Push("five");
			myStack.Push("six");
			Console.Write("Total number of elements in the Stack are : ");
			Console.WriteLine(myStack.Count);

			Console.Write("This is Push operation ");



		}

		internal void pushtostack(MyStack stack1)
        {
            throw new NotImplementedException();
        }
        public void PeekFromStack(Stack<string> myStack)
       {


		Console.WriteLine("Element at the top is : " + myStack.Peek());
		Console.WriteLine("The Count After Peek is : "+ myStack.Count);



		}
		public void PopFromStack(Stack<string> myStack)
		{

			Console.Write(myStack.Pop());
			Console.WriteLine( "The Count After Pop  Element is "+ myStack.Count);
			



		}
		public void ClearStack(Stack<string> myStack)
		{

			myStack.Clear();
			Console.WriteLine("The Count After claering Element is  " + myStack.Count);




		}






	}
}
