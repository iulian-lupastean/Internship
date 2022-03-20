
using System.Collections.ObjectModel;
using CSharp_Basics;
namespace CSharpBasics
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ASUS asus = new ASUS { Name = "TUF", Price = 3999.99 };
            Logitech mouse1 = new Logitech { Name = "Logitech 1000", Price = -40.99 };
            Logitech mouse2 = new Logitech { Name = "Logitech 2000", Price = 40.99 };
            DDR4 memory = new DDR4 { Name = "DDR4 ", Price = 400 };
            asus.OpenBrowser();
            asus.OpenBrowser("Chrome");
            asus.GiveRating(Rating.ThreeStars);

            Dictionary<int, PC> AllMyPC = new Dictionary<int, PC>();
            AllMyPC.Add(1, asus);

            foreach (KeyValuePair<int, PC> pair in AllMyPC)
            {
                pair.Value.isUsed();
            }


            Dictionary<int, Mouse> AllMyMouses = new Dictionary<int, Mouse>();
            AllMyMouses.Add(1, mouse1);
            AllMyMouses.Add(2, mouse2);

            Collection<RAM> AllMyRAM = new Collection<RAM>();
            AllMyRAM.Add(memory);

        }
        public class GenericRepository<T> : IGenericRepository<T> where T : class
        {
            public void Delete(object id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<T> GetAll()
            {
                throw new NotImplementedException();
            }

            public T GetByID(object id)
            {
                {
                    throw new NotImplementedException();
                }
            }
            public void Insert(T obj)
            {
                throw new NotImplementedException();
            }

            public void Update(T obj)
            {
                throw new NotImplementedException();
            }

        }

    }

}

public abstract class ElectronicDevice
{
    public string? Name { get; set; }
    public abstract void isUsed();

}

public abstract class PC : ElectronicDevice
{
    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                price = 0;
            else
                price = value;

        }
    }
    public override void isUsed()
    {
        Console.WriteLine("PC " + this.Name + " is running.");
    }
}

public abstract class Mouse : ElectronicDevice
{
    private bool isAttachedToPC = true;
    public bool IsAttachedToPC { get { return isAttachedToPC; } }
    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                price = 0;
            else
                price = value;

        }
    }

    public override void isUsed()
    {
        Console.WriteLine("Mouse " + this.Name + " is used with a PC");
    }

}

public abstract class RAM : ElectronicDevice
{
    private bool isInsidePC = true;
    public bool IsInsidePC { get { return isInsidePC; } }

    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                price = 0;
            else
                price = value;
        }
    }
    public override void isUsed()
    {
        Console.WriteLine("RAM " + this.Name + " is integrated in PC");
    }
}
public class ASUS : PC
{
    public void OpenBrowser()
    {
        Console.WriteLine("PC " + this.Name + " opened default browser");
    }

    public void OpenBrowser(string browser)
    {
        Console.WriteLine("PC " + this.Name + " opened " + browser + " browser");
    }
    public void GiveRating(Rating rating)
    {
        this.rating = rating;
        Console.WriteLine("PC " + this.Name + " has " + rating + " rating");
    }

    private Rating rating;

}

public class Logitech : Mouse
{
    public void DPI()
    {
        Console.WriteLine("Mouse " + this.Name + " has 2000 DPI");
    }
}

public class DDR4 : RAM
{
    public void Capacity()
    {
        Console.WriteLine("The RAM " + this.Name + " has 8 GB ");
    }
}

public enum Rating
{
    OneStar,
    TwoStars,
    ThreeStars,
    FourStars,
    FiveStars
}


