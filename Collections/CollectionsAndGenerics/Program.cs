using System.Collections;
using System.Collections.Generic;
using System;
namespace ExceptionsAndDebbuging
{
    class Program
    {
        static void Main(string[] args)
        {
            Category<string> category = new Category<string>();
            category.SetItem(0, "ex1");
            category.SetItem(1, "ex2");
            Console.WriteLine(category.GetItem(0));

        }

    }
    class Category<T>
    {
        List<T> list = new List<T>();
        public T GetItem(int id)
        {
            try
            {
                return list[id];
            }
            catch (Exception e)
            {
                return (T)Convert.ChangeType(e.Message, typeof(T));
            }
           
        }
        public void SetItem(int id,T value)
        {
            list.Insert(id,value);
        }

        public void Swap(int index1,int index2)
        {
            T tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }
       
    }



}