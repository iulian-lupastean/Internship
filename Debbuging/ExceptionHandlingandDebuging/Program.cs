#define MYCONDITION 
using System;
namespace ExceptionsAndDebbuging
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            try
            {
                var user = new User("popescu", -3);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("This is an Argument OutOfRange Exception ");
                Console.WriteLine();
            }


            try
            {
                var user = new User(null, 23);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("This is an Argument Null Exception ");
            }

#endif
        }
        class User
        {
            public User(string userName,int age)
            {
                if (userName == null)
                    throw new ArgumentNullException(nameof(userName), "username is invalid!");
                if (age < 0 || age > 120)
                    throw new ArgumentOutOfRangeException(nameof(age), "age is invalid");
                UserName = userName;
                Age = age;
            }
            public string UserName { get;private set; }
            public int Age { get;private set; }
        }
    }
}