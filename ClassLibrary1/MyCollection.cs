using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClassLibrary1
{
    public class MyCollection<T> 
    {

        public List<T> myList;

        public T this[int index]
        {
            get 
            {
                if (index <= myList.Count - 1 && index >= 0)
                    return (T)myList[index];
                else
                    return default(T);
            }
            set { myList[index] = value; }
        }

        public MyCollection()
        {
            myList = new List<T>();
        }

        public void Add(T item)
        {
            myList.Add(item);
        }        

        public int Count
        {
            get { return myList.Count; }
        }      
        
    }
}
