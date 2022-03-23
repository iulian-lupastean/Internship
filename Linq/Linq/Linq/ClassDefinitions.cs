using System.Diagnostics.CodeAnalysis;

namespace LinqLesson
{

    public class Laptop
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double ProcesorFrequency { get; set; }

        public int RAM { get; set; }
        public int Capacity { get; set; }
        public double ScreenDiagonal { get; set; }
        public string ManufacturerID { get; set; }
        public bool HasSSD { get; set; }
        public override string ToString()
        {
            return $"{Name} has {ProcesorFrequency} Hz procesor,{RAM} GB RAM ,{Capacity} GB storage capacity , {(HasSSD ? " SSD storage," : "")} screen with {ScreenDiagonal} inches diagonal and the price is {Price} RON";
        }
    }
    public class MacBook : Laptop
    {
        public string AppleProcesor { get; set; }
        public override string ToString()
        {
            return $"{Name} has {AppleProcesor} procesor,{RAM} GB RAM ,{Capacity} GB storage capacity , {(HasSSD ? " SSD storage," : "")} screen with {ScreenDiagonal} inches diagonal and the price is {Price} RON";
        }
    }


    public class Manufacturer
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string CEO { get; set; }
        public List<Laptop> Laptops { get; set; }

    }
    public class Tablet
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ManufacturerId { get; set; }
    }
}