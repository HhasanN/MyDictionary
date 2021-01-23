using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(001,"Eda");
            myList.Add(002,"Ahmet");
            myList.Add(002,"Hasan");
            myList.Add(003,"Rabia");
            myList.Add(003,"Engin");

            myList.print();
        }
    }
}
