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
            int index1 = -1;
            int index2 = 5;
            Console.WriteLine(category.GetItem(0));
            try
            {
                if (index1 < 0)
                {
                    throw new IndexIsNegativeException(index1);
                }
                else if (index2 < 0)
                { throw new IndexIsNegativeException(index2); }
                category.Swap(index1, index2);

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
        public IndexIsNegativeException(int index) : base($"The index is negative {index}") { }
    }


}