#define MYCONDITION 
using System;
namespace ExceptionsAndDebbuging
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var age = -11;
            string name = "popescu";
            try
            {
                if (unchecked(age != (int)age))
                {
                    throw new AgeIsNotIntegerException(age);
                }
                var user = new User(name, (int)age);
            }
            catch (AgeIsNotIntegerException ex)
            {
                Console.WriteLine(ex.Message);
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
                // Nothing To release here
            }


#endif
        }
        class User
        {
            public User(string userName, int age)
            {
                if (userName == null)
                    throw new ArgumentNullException(nameof(userName), "username is invalid!");
                if (age < 0 || age > 100)
                    throw new ArgumentOutOfRangeException(nameof(age), "age is invalid");
                UserName = userName;
                Age = age;
            }
            public string UserName { get; private set; }
            public int Age { get; private set; }
        }
    }
    public class AgeIsNotIntegerException : Exception
    {
        public AgeIsNotIntegerException(double age) : base($"Age is not integer {age}") { }
    }
}