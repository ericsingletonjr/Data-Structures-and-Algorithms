using System;
using MergeLists.Classes;

namespace MergeLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkList listOne = new LinkList(new Node(3));
            listOne.Add(new Node(8));
            listOne.Add(new Node(23));
            listOne.Add(new Node(1));

            LinkList listTwo = new LinkList(new Node(45));
            listTwo.Add(new Node(16));
            listTwo.Add(new Node(5));
            listTwo.Add(new Node(2));

            listOne.Print();
            listTwo.Print();

            LinkList listThree = MergeLists(listOne, listTwo);
            Console.WriteLine("----");
            listOne.Print();
            listTwo.Print();
            listThree.Print();
            
        }
        /// <summary>
        /// Method that takes in two separate lists
        /// and merges them in a Zip pattern. It takes the current of
        /// each list and compares them if they are null and iterates
        /// until the completion of the list
        /// </summary>
        /// <param name="listOne">Linked List One</param>
        /// <param name="listTwo">Linked List Two</param>
        /// <returns>A merged Linked List</returns>
        public static LinkList MergeLists(LinkList listOne, LinkList listTwo)
        {
            listOne.Current = listOne.Head;
            listTwo.Current = listTwo.Head;

            Node runner1 = listOne.Head;
            Node runner2 = listTwo.Head;

            while (runner1.Next != null)
            {
                runner1 = runner1.Next;
                runner2 = runner2.Next;

                listTwo.Current.Next = runner1;
                listOne.Current.Next = listTwo.Current;
                listTwo.Current = runner2;
                if (listTwo.Current == null) return listOne;
                listOne.Current = runner1;
            }
            if (listTwo.Current != null) listOne.Current.Next = listTwo.Current;

            return listOne;
        }
    }
}
