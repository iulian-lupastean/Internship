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
            try
            {
                ValidateIndex(-1);
                category.Swap(0, -1);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IndexIsNegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(category.GetItem(0));
        }
        public static void ValidateIndex(int index)
        {
            if (index < 0)
            {
                throw new IndexIsNegativeException(index);
            }
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
        public void SetItem(int id, T value)
        {
            list.Insert(id, value);
        }

        public void Swap(int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);

        }

    }
    public class IndexIsNegativeException : Exception
    {
        public IndexIsNegativeException() { }
        public IndexIsNegativeException(int index) : base(String.Format("The index is negative {0}", index)) { }
    }


}